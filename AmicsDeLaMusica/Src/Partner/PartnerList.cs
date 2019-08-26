﻿using AmicsDeLaMusicaClassLibrary.Src.Container;
using AmicsDeLaMusicaClassLibrary.Src.Partner;
using System;
using System.Windows.Forms;
using SimpleInjector;

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
            DGVPartners.DataSource = _partnerService.FindAll(null);
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            AppContainer.GetInstance().GetInstance<FormNewPartner>().ShowDialog();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

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
    }
}