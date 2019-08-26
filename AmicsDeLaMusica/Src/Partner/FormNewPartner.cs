using AmicsDeLaMusicaClassLibrary.Src.Partner;
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
    public partial class FormNewPartner : Form
    {

        private IPartnerService _parnerService;

        public FormNewPartner(IPartnerService pPartnerService)
        {
            InitializeComponent();

            _parnerService = pPartnerService;
        }

        private void FormNewPartner_Load(object sender, EventArgs e)
        {

            AutoCompleteStringCollection _citiesSource = new AutoCompleteStringCollection();
            AutoCompleteStringCollection _streetsSource = new AutoCompleteStringCollection();

            _citiesSource.AddRange(_parnerService.GetCities().ToArray());
            _streetsSource.AddRange(_parnerService.GetStreets().ToArray());

            CBCity.AutoCompleteCustomSource = _citiesSource;
            CBCity.DataSource = _citiesSource;
            CBCity.SelectedIndex = -1;

            CBStreet.AutoCompleteCustomSource = _citiesSource;
            CBStreet.DataSource = _streetsSource;
            CBStreet.SelectedIndex = -1;

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
