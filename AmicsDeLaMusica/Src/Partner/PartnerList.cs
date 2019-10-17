using AmicsDeLaMusicaClassLibrary.Src.Container;
using AmicsDeLaMusicaClassLibrary.Src.Partner;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace AmicsDeLaMusica.Src.Partner
{
    public partial class PartnerList : Form
    {

        private IPartnerService _partnerService;

        public PartnerList(IPartnerService pPartnerService)
        {
            InitializeComponent();

            _partnerService = pPartnerService;

        }

        private void PartnerList_Load(object sender, EventArgs e)
        {
            DGVPartners.AutoGenerateColumns = false;
            LoadData();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DGVPartners.DataSource = _partnerService.FindAll(GetPartnerFromForm());
        }

        private AmicsDeLaMusicaClassLibrary.Src.Partner.Partner GetPartnerFromForm()
        {

            return new AmicsDeLaMusicaClassLibrary.Src.Partner.Partner
            {
                PartnerName = TBPartnerName.Text.Trim(),
                ResponsibleMusician = TBResponsibleMusician.Text.Trim(),
            };

        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            AppContainer.GetInstance().GetInstance<FormNewPartner>().ShowDialog();

            LoadData();

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

            if (DGVPartners.CurrentRow != null)
            {

                FormEditPartner form = AppContainer.GetInstance().GetInstance<FormEditPartner>();

                form.SetPartner((AmicsDeLaMusicaClassLibrary.Src.Partner.Partner) DGVPartners.CurrentRow.DataBoundItem);

                form.ShowDialog();

                LoadData();

                TBPartnerName.Focus();

            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            DialogResult _result;

            AmicsDeLaMusicaClassLibrary.Src.Partner.Partner _partner;

            if (DGVPartners.CurrentRow != null) {

                try
                {
                    _partner = (AmicsDeLaMusicaClassLibrary.Src.Partner.Partner) 
                        DGVPartners.CurrentRow.DataBoundItem;

                    _result = MessageBox.Show(
                        $"Vols borrar el soci {_partner.PartnerName}? Aquesta operació no es pot desfer.", 
                        "Confirmació", 
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (_result == DialogResult.Yes) {

                        _partnerService.Delete(_partner);

                        MessageBox.Show(
                            "Soci eliminat correctament",
                            "Informació",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadData();

                    }
                 
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
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DGVPartners_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonUpdate.PerformClick();
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {

            IEnumerable<AmicsDeLaMusicaClassLibrary.Src.Partner.Partner> _partnersWithoutResponsibleMusician;
            string _errorMessage = string.Empty;
            string _confirmationMessage = string.Empty;
            AmicsDeLaMusicaClassLibrary.Src.Partner.Partner _lastPartner;
            int _gapPartnerID;
            DialogResult _result;

            if (_partnerService.Validate()){
                MessageBox.Show(
                    "La informació dels socis és correcta!",
                    "Informació",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show(
                    "La informació dels socis NO és correcta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                _partnersWithoutResponsibleMusician = _partnerService.FindAllWithoutResponsibleMusician();

                if (_partnersWithoutResponsibleMusician.Count() > 0)
                {

                    _errorMessage += "Assigna músic responsable als següents socis:\n\n";

                    foreach (var _partner in _partnersWithoutResponsibleMusician)
                    {
                        _errorMessage += _partner.ToString() + "\n";
                    }

                    MessageBox.Show(
                        _errorMessage,
                        "Informació",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }

                if (_partnerService.HasGap())
                {

                    _lastPartner = _partnerService.MaxPartner();
                    _gapPartnerID = _partnerService.GetNextId();

                    _confirmationMessage = "N'hi ha llocs en blanc entre els socis.\n\n";
                    _confirmationMessage += $"Vols moure el soci {_lastPartner.ToString()} al lloc {_gapPartnerID}?";

                    _result = MessageBox.Show(
                      _confirmationMessage,
                      "Confirmació",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);

                    if(_result == DialogResult.Yes)
                    {

                        try
                        {

                            _partnerService.UpdateID(_lastPartner, _gapPartnerID);

                            MessageBox.Show(
                                "Soci editat correctament",
                                "Informació",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadData();

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

                }

            }

        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {

            if (_partnerService.Validate())
            {
                AppContainer.GetInstance().GetInstance<FormReportPartner>().ShowDialog();
            }
            else
            {

                MessageBox.Show(
                    "La informació dels socis NO és correcta. Valida-la per a continuar.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
    }
}
