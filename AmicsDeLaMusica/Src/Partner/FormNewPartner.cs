using AmicsDeLaMusicaClassLibrary.Src.Partner;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AmicsDeLaMusica.Src.Partner
{
    public partial class FormNewPartner : Form
    {

        private IPartnerService _partnerService;

        public FormNewPartner(IPartnerService pPartnerService)
        {
            InitializeComponent();

            _partnerService = pPartnerService;
        }

        private void FormNewPartner_Load(object sender, EventArgs e)
        {

            AutoCompleteStringCollection _citiesSource = new AutoCompleteStringCollection();
            AutoCompleteStringCollection _streetsSource = new AutoCompleteStringCollection();
            AutoCompleteStringCollection _responsibleMusiciansSource = new AutoCompleteStringCollection();

            _citiesSource.AddRange(_partnerService.GetCities().ToArray());
            _streetsSource.AddRange(_partnerService.GetStreets().ToArray());
            _responsibleMusiciansSource.AddRange(_partnerService.GetResponsibleMusicians().ToArray());

            CBCity.AutoCompleteCustomSource = _citiesSource;
            CBCity.DataSource = _citiesSource;
            CBCity.SelectedIndex = -1;

            CBStreet.AutoCompleteCustomSource = _streetsSource;
            CBStreet.DataSource = _streetsSource;
            CBStreet.SelectedIndex = -1;

            CBReponsible.AutoCompleteCustomSource = _responsibleMusiciansSource;
            CBReponsible.DataSource = _responsibleMusiciansSource;
            CBReponsible.SelectedIndex = -1;

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                _partnerService.Insert(GetPartnerFromForm());

                MessageBox.Show(
                    "Soci creat correctament", 
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

            return new AmicsDeLaMusicaClassLibrary.Src.Partner.Partner
            {
                PartnerName = TBPartnerName.Text.Trim(),
                City = CBCity.Text,
                Street = CBStreet.Text,
                StreetNumber = NumericStreetNumber.Value.ToString(),
                Email = TBEmail.Text.Trim(),
                Phone = TBPhone.Text.Trim(),
                ResponsibleMusician = CBReponsible.Text
            };

        }
    }
}
