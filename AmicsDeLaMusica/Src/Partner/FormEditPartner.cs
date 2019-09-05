using AmicsDeLaMusicaClassLibrary.Src.Partner;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AmicsDeLaMusica.Src.Partner
{
    public partial class FormEditPartner : Form
    {

        private IPartnerService _partnerService;


        private AmicsDeLaMusicaClassLibrary.Src.Partner.Partner partner;

        public FormEditPartner(IPartnerService pPartnerService)
        {
            InitializeComponent();

            _partnerService = pPartnerService;
        }

        public void SetPartner(AmicsDeLaMusicaClassLibrary.Src.Partner.Partner value)
        {
            partner = value;
        }

        private void FormEditPartner_Load(object sender, EventArgs e)
        {

            AutoCompleteStringCollection _citiesSource = new AutoCompleteStringCollection();
            AutoCompleteStringCollection _streetsSource = new AutoCompleteStringCollection();

            _citiesSource.AddRange(_partnerService.GetCities().ToArray());
            _streetsSource.AddRange(_partnerService.GetStreets().ToArray());

            CBCity.AutoCompleteCustomSource = _citiesSource;
            CBCity.DataSource = _citiesSource;
            CBCity.SelectedIndex = -1;

            CBStreet.AutoCompleteCustomSource = _citiesSource;
            CBStreet.DataSource = _streetsSource;
            CBStreet.SelectedIndex = -1;

            TBPartnerName.Text = partner.PartnerName;
            CBCity.SelectedText = partner.City;
            CBStreet.SelectedText = partner.Street;
            NumericStreetNumber.Value = String.IsNullOrWhiteSpace(partner.StreetNumber) ? 0 : Convert.ToInt32(partner.StreetNumber);
            TBEmail.Text = partner.Email;
            TBPhone.Text = partner.Phone;
            CBReponsible.SelectedValue = partner.ResponsibleMusician;
                
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

            try
            {
                _partnerService.Update(GetPartnerFromForm());

                MessageBox.Show("Soci editat correctament", 
                    "Informació",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private AmicsDeLaMusicaClassLibrary.Src.Partner.Partner GetPartnerFromForm()
        {

            partner.PartnerName = TBPartnerName.Text.Trim();
            partner.City = CBCity.Text;
            partner.Street = CBStreet.Text;
            partner.StreetNumber = NumericStreetNumber.Value.ToString();
            partner.Email = TBEmail.Text.Trim();
            partner.Phone = TBPhone.Text.Trim();
            partner.ResponsibleMusician = (AmicsDeLaMusicaClassLibrary.Src.Musician.Musician)CBReponsible.SelectedItem;
      
            return partner;

        }
    }
}
