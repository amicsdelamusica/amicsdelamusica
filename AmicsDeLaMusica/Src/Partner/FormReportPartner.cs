using AmicsDeLaMusicaClassLibrary.Src.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmicsDeLaMusica.Src.Partner
{
    public partial class FormReportPartner : Form
    {
        private string _letterFullPath;

        private ReportService _reportService;

        public FormReportPartner(ReportService pReportService)
        {
            InitializeComponent();

            _reportService = pReportService;
        }

        private void ButtonBrowseLetter_Click(object sender, EventArgs e)
        {
            if (OFDLetter.ShowDialog() == DialogResult.OK)
            {
                _letterFullPath = OFDLetter.FileName;
            }

        }

        private void ButtonPartnerReport_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate();

                _reportService.GetPartnerReport("C:\\Users\\JorGe\\Documents\\1.pdf");

            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    ex.Message,
                    "error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void Validate()
        {
            if (String.IsNullOrWhiteSpace(TBLetterPath.Text))
            {
                throw new ArgumentException("Introdueix la ruta de la carta per als socis.");
            }
        }

     
    }
}
