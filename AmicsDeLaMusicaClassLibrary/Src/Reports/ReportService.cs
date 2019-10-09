using AmicsDeLaMusicaClassLibrary.Src.Partner;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System;
using System.IO;

namespace AmicsDeLaMusicaClassLibrary.Src.Reports
{
    public class ReportService
    {

        private IPartnerService _partnerService;

        private IEnumerable<Partner.Partner> _partners;

        public ReportService(IPartnerService pPartnerService)
        {
            _partnerService = pPartnerService;
        }

        public void GetPartnerReport(string pLetterPath, 
            DateTime pDueDate,
            decimal pAmount,
            string pOutputPath)
        {

            string _outputFilePath;
            PdfDocument _outputFile = new PdfDocument();

            PdfDocument _letter = PdfReader.Open(pLetterPath, PdfDocumentOpenMode.Import);

            Partner.Partner _partnerQuery = new Partner.Partner()
            {
                PartnerName = string.Empty,
                ResponsibleMusician = string.Empty,
            };

            _partners = _partnerService.FindAll(_partnerQuery);

            var _groupedPartners =
                from _partner in _partners
                group _partner by _partner.ResponsibleMusician into newGroup
                select new { ResponsibleMusician = newGroup.Key, NumberOfPartners = newGroup.Count() };

            foreach (var _partnerGroup in _groupedPartners)
            {

                AddMusicianSheetReport(
                    _partnerGroup.ResponsibleMusician,
                    _partnerGroup.NumberOfPartners,
                    _partnerGroup.NumberOfPartners * pAmount,
                    pDueDate,
                    _outputFile);
           
                //Add report tickets

                for(int i = 0; i < _partnerGroup.NumberOfPartners; i++)
                {
                    for (int j = 0; j < _letter.Pages.Count; j++)
                    {
                        _outputFile.AddPage(_letter.Pages[j]);
                    }
                }
             
            }

            _outputFilePath = $"{pOutputPath}\\SOCIS{DateTime.Today.Year}.pdf";

            _outputFile.Save(_outputFilePath);

            Process.Start(_outputFilePath);

        }

        private void AddMusicianSheetReport(
            string pResponsibleMusician, 
            int pNumberOfPartners,
            decimal pTotalAmount,
            DateTime pDueDate,
            PdfDocument pOutputFile)
        {
            string _path;
            PdfDocument _musicianSheet;

            MusicianSheet report = new MusicianSheet();

            report.DataDefinition.FormulaFields["ResponsibleMusician"].Text = $"'{pResponsibleMusician}'";
            report.DataDefinition.FormulaFields["TotalPartners"].Text = $"'{pNumberOfPartners}'";
            report.DataDefinition.FormulaFields["TotalAmount"].Text = $"'{pTotalAmount}'";
            report.DataDefinition.FormulaFields["DueDate"].Text = $"'{pDueDate.ToShortDateString()}'";

            _path = $"{Path.GetTempPath()}{pResponsibleMusician}.pdf";

            report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _path);

            _musicianSheet = PdfReader.Open(_path, PdfDocumentOpenMode.Import);

            pOutputFile.AddPage(_musicianSheet.Pages[0]);

            File.Delete(_path);

        }
    }
}
