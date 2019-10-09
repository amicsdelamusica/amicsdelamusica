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

        private MusicianSheet _reportMusicianSheet = new MusicianSheet();
        private PartnerTicket _reportPartnerTicket = new PartnerTicket();
        private Reward _reportReward = new Reward();

        private IPartnerService _partnerService;

        public ReportService(IPartnerService pPartnerService)
        {
            _partnerService = pPartnerService;
        }

        public void GetPartnerReport(string pLetterPath, 
            DateTime pDueDate,
            decimal pAmount,
            string pOutputPath)
        {
            IEnumerable<Partner.Partner> _partners;

            string _outputFilePath;
            PdfDocument _outputFile = new PdfDocument();

            Partner.Partner _partnerQuery = new Partner.Partner()
            {
                PartnerName = string.Empty,
                ResponsibleMusician = string.Empty,
            };

            _partners = _partnerService.FindAll(_partnerQuery);

            var _groupedPartners =
                from _partner in _partners
                group _partner by _partner.ResponsibleMusician into newGroup
                orderby newGroup.Key
                select new { ResponsibleMusician = newGroup.Key, NumberOfPartners = newGroup.Count() };

            foreach (var _partnerGroup in _groupedPartners)
            {
  
                AddMusicianSheetReport(
                    _partnerGroup.ResponsibleMusician,
                    _partnerGroup.NumberOfPartners,
                    _partnerGroup.NumberOfPartners * pAmount,
                    pDueDate,
                    _outputFile);

                AddPartnerTicketReport(
                    _partners,
                    pAmount,
                    _partnerGroup.ResponsibleMusician, 
                    _outputFile);

                AddPartnerLetter(_partnerGroup.NumberOfPartners, 
                    pLetterPath, 
                    _outputFile);                         
                        
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

            _reportMusicianSheet.DataDefinition.FormulaFields["ResponsibleMusician"].Text = $"'{pResponsibleMusician}'";
            _reportMusicianSheet.DataDefinition.FormulaFields["TotalPartners"].Text = $"'{pNumberOfPartners}'";
            _reportMusicianSheet.DataDefinition.FormulaFields["TotalAmount"].Text = $"'{pTotalAmount}'";
            _reportMusicianSheet.DataDefinition.FormulaFields["DueDate"].Text = $"'{pDueDate.ToShortDateString()}'";

            _path = $"{Path.GetTempPath()}{pResponsibleMusician}.pdf";

            _reportMusicianSheet.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _path);

            _musicianSheet = PdfReader.Open(_path, PdfDocumentOpenMode.Import);

            pOutputFile.AddPage(_musicianSheet.Pages[0]);

            File.Delete(_path);

        }

        private void AddPartnerTicketReport(
            IEnumerable<Partner.Partner> pPartners,
            decimal pAmount, 
            string pResponsibleMusician,
            PdfDocument pOutputFile)
        {

            string _path;
            PdfDocument _partnerTicket;
            IEnumerable<Partner.Partner> _musicianPartners;

            _reportPartnerTicket.DataDefinition.FormulaFields["Amount"].Text = $"'{pAmount}'";

            _musicianPartners = pPartners.Where(_partner => _partner.ResponsibleMusician == pResponsibleMusician);

                _reportPartnerTicket.SetDataSource(_musicianPartners);

            _path = $"{Path.GetTempPath()}{pResponsibleMusician}.pdf";

                _reportPartnerTicket.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _path);

            _partnerTicket = PdfReader.Open(_path, PdfDocumentOpenMode.Import);

            for (int i = 0; i < _partnerTicket.Pages.Count; i++)
            {
                pOutputFile.AddPage(_partnerTicket.Pages[i]);
            }
                
            File.Delete(_path);
            
        }

        private void AddPartnerLetter(int pNumberOfPartners, 
            string pLetterPath,
            PdfDocument pOutputFile)
        {

            PdfDocument _letter = PdfReader.Open(pLetterPath, PdfDocumentOpenMode.Import);

            for (int i = 0; i < pNumberOfPartners; i++)
            {
                for (int j = 0; j < _letter.Pages.Count; j++)
                {
                    pOutputFile.AddPage(_letter.Pages[j]);
                }
            }
        }

        public void GetRewardReport(string pOutputPath)
        {
            IEnumerable<Partner.Partner> _partners;
            string _path;          

            Partner.Partner _partnerQuery = new Partner.Partner()
            {
                PartnerName = string.Empty,
                ResponsibleMusician = string.Empty,
            };

            _partners = _partnerService.FindAll(_partnerQuery);

            _reportReward.SetDataSource(_partners);

            _path = $"{pOutputPath}\\SORTEIG{DateTime.Today.Year}.pdf";

            _reportReward.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _path);

            Process.Start(_path);

        }

    }
}
