using AmicsDeLaMusica.Src.Partner;
using AmicsDeLaMusicaClassLibrary.Src.Container;
using System;
using System.Windows.Forms;

namespace AmicsDeLaMusica
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonCollaborator_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Pròximament...", 
                "Informació",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonMusicians_Click(object sender, EventArgs e)
        {

        }

        private void buttonPartners_Click(object sender, EventArgs e)
        {
            AppContainer.GetInstance().GetInstance<PartnerList>().Show();
        }
    }
}
