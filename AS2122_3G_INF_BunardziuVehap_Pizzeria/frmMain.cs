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
            if (TXT_Quantità.Text != "")
            {
                SceltaPizza = CBX_Scelta.Text;
                switch (CBX_Scelta.Text)
                {
                    case "Margherita":
                        nMargherite = nMargherite + Convert.ToInt32(TXT_Quantità.Text); ;
                        LST_Riepilogo.Items.Add("Margherita " + TXT_Quantità.Text);
                        break;
                    case "Verdure":
                        nVerdure = nVerdure + Convert.ToInt32(TXT_Quantità.Text);
                        LST_Riepilogo.Items.Add("Verdure:  " + TXT_Quantità.Text);
                        break;
                    case "4 Stagioni":
                        n4Stagioni = n4Stagioni + Convert.ToInt32(TXT_Quantità.Text); ;
                        LST_Riepilogo.Items.Add("4 Stagioni: " + TXT_Quantità.Text);
                        break;
                    default:
                        MessageBox.Show("Non hai selezionato una pizza");
                        break;
                }
                LBL_PizzeMargherite.Text = "Pizze Margherite = " + Convert.ToString(nMargherite);
                LBL_PizzeVerdure.Text = "Pizze Verdure = " + Convert.ToString(nVerdure);
                LBL_Pizze4Stagioni.Text = "Pizze 4 Stagioni = " + Convert.ToString(n4Stagioni);
            }
            else
            {
                MessageBox.Show("Non hai inserito una quantità");
            }
        }
    }
}