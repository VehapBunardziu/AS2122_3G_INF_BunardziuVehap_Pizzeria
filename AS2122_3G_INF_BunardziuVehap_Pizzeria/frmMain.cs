namespace AS2122_3G_INF_BunardziuVehap_Pizzeria
{
    public partial class frmMain : Form
    {
        int nMargherite = 0;
        int nVerdure = 0;
        int n4Stagioni = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void BTN_Aggiungi_Click(object sender, EventArgs e)
        {
            string SceltaPizza;
            int nMargherite = 0;
            int nVerdure = 0;
            int n4Stagioni = 0;
            if (TXT_Quantità.Text != "")
            {
                SceltaPizza = CBX_Scelta.Text;
                switch (CBX_Scelta.Text)
                {
                    case "Margherita":
                        nMargherite = Convert.ToInt32(TXT_Quantità.Text);
                        LST_Riepilogo.Items.Add("Margherita " + nMargherite);
                        break;
                    case "Verdure":
                        nVerdure = Convert.ToInt32(TXT_Quantità.Text);
                        LST_Riepilogo.Items.Add("Verdure:  " + nVerdure);
                        break;
                    case "4 Stagioni":
                        n4Stagioni = Convert.ToInt32(TXT_Quantità.Text);
                        LST_Riepilogo.Items.Add("4 Stagioni: " + n4Stagioni);
                        break;
                    default:
                        MessageBox.Show("Non hai selezionato una pizza");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Non hai inserito una quantità");
            }
        }
    }
}