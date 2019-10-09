using AmicsDeLaMusicaClassLibrary.Src.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmicsDeLaMusica.Src.Partner
{
    public partial class FormReportPartner : Form
    {

        private ReportService _reportService;

        public FormReportPartner(ReportService pReportService)
        {
            InitializeComponent();

            _reportService = pReportService;
        }

        private void FormReportPartner_Load(object sender, EventArgs e)
        {
            DTPDueDate.Value = DateTime.Today;
        }

        private void ButtonBrowseLetter_Click(object sender, EventArgs e)
        {
            if (OFDLetter.ShowDialog() == DialogResult.OK)
            {
                TBLetterPath.Text = OFDLetter.FileName;
            }

        }

        private void ButtonPartnerReport_Click(object sender, EventArgs e)
        {
            try
            {

                Validate();

                Cursor = Cursors.WaitCursor;

                _reportService.GetPartnerReport(
                    TBLetterPath.Text.Trim(), 
                    DTPDueDate.Value, 
                    NumericAmount.Value,
                    TBOutputPath.Text.Trim());

            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private new void Validate()
        {
            if (String.IsNullOrWhiteSpace(TBLetterPath.Text))
            {
                throw new ArgumentException("Introdueix la ruta de la carta per als socis.");
            }

            if (!File.Exists(TBLetterPath.Text)){
                throw new ArgumentException($"El document {TBLetterPath.Text.Trim()} no existeix");
            }

            if (NumericAmount.Value == 0)
            {
                throw new ArgumentException("Introdeix l'import a cobrar.");
            }

            ValidateOutputPath();

        }

        private void ButtonBrowseOutput_Click(object sender, EventArgs e)
        {
            if (FBDOutput.ShowDialog() == DialogResult.OK)
            {
                TBOutputPath.Text = FBDOutput.SelectedPath;
            }
        }

        private void ButtonReward_Click(object sender, EventArgs e)
        {
            try
            {

                ValidateOutputPath();

                _reportService.GetRewardReport(TBOutputPath.Text.Trim());

            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void ValidateOutputPath()
        {
            if (String.IsNullOrWhiteSpace(TBOutputPath.Text))
            {
                throw new ArgumentException("Introdueix la ruta on vols generar el document.");
            }

            if (!Directory.Exists(TBOutputPath.Text.Trim()))
            {
                throw new ArgumentException($"La carpeta {TBOutputPath.Text.Trim()} no existeix.");
            }
        }
    }
}
