using AmicsDeLaMusicaClassLibrary.Src.Partner;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AmicsDeLaMusicaClassLibrary.Src.Reports
{
    public class ReportService
    {

        private const string OUTPUT_PATH = "C:\\Temp\\merged.pdf";

        private IPartnerService _partnerService;

        private IEnumerable<Partner.Partner> _partners;

        public ReportService(IPartnerService pPartnerService)
        {
            _partnerService = pPartnerService;
        }

        public void GetPartnerReport(string pLetterPath)
        {
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

                //Add report musician sheet
                //Add report tickets

                for(int i = 0; i < _partnerGroup.NumberOfPartners; i++)
                {
                    for (int j = 0; j < _letter.Pages.Count; j++)
                    {
                        _outputFile.AddPage(_letter.Pages[j]);
                    }
                }
             
            }
     
            _outputFile.Save(OUTPUT_PATH);

            Process.Start(OUTPUT_PATH);

        }
    }
}
