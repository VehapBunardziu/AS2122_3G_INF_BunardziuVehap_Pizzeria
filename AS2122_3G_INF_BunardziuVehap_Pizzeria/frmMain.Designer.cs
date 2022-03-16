namespace AS2122_3G_INF_BunardziuVehap_Pizzeria
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_TipoPizza = new System.Windows.Forms.Label();
            this.LBL_Quantità = new System.Windows.Forms.Label();
            this.TXT_Quantità = new System.Windows.Forms.TextBox();
            this.CBX_Scelta = new System.Windows.Forms.ComboBox();
            this.LBL_Riepilogo = new System.Windows.Forms.Label();
            this.BTN_Aggiungi = new System.Windows.Forms.Button();
            this.LST_Riepilogo = new System.Windows.Forms.ListBox();
            this.LBL_PizzeMargherite = new System.Windows.Forms.Label();
            this.LBL_PizzeVerdure = new System.Windows.Forms.Label();
            this.LBL_Pizze4Stagioni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_TipoPizza
            // 
            this.LBL_TipoPizza.AutoSize = true;
            this.LBL_TipoPizza.Location = new System.Drawing.Point(27, 63);
            this.LBL_TipoPizza.Name = "LBL_TipoPizza";
            this.LBL_TipoPizza.Size = new System.Drawing.Size(72, 15);
            this.LBL_TipoPizza.TabIndex = 0;
            this.LBL_TipoPizza.Text = "Tipo di pizza";
            // 
            // LBL_Quantità
            // 
            this.LBL_Quantità.AutoSize = true;
            this.LBL_Quantità.Location = new System.Drawing.Point(40, 129);
            this.LBL_Quantità.Name = "LBL_Quantità";
            this.LBL_Quantità.Size = new System.Drawing.Size(53, 15);
            this.LBL_Quantità.TabIndex = 1;
            this.LBL_Quantità.Text = "Quantità";
            // 
            // TXT_Quantità
            // 
            this.TXT_Quantità.Location = new System.Drawing.Point(105, 126);
            this.TXT_Quantità.Name = "TXT_Quantità";
            this.TXT_Quantità.Size = new System.Drawing.Size(35, 23);
            this.TXT_Quantità.TabIndex = 2;
            // 
            // CBX_Scelta
            // 
            this.CBX_Scelta.FormattingEnabled = true;
            this.CBX_Scelta.Location = new System.Drawing.Point(105, 55);
            this.CBX_Scelta.Name = "CBX_Scelta";
            this.CBX_Scelta.Size = new System.Drawing.Size(121, 23);
            this.CBX_Scelta.TabIndex = 3;
            // 
            // LBL_Riepilogo
            // 
            this.LBL_Riepilogo.AutoSize = true;
            this.LBL_Riepilogo.Location = new System.Drawing.Point(549, 25);
            this.LBL_Riepilogo.Name = "LBL_Riepilogo";
            this.LBL_Riepilogo.Size = new System.Drawing.Size(57, 15);
            this.LBL_Riepilogo.TabIndex = 4;
            this.LBL_Riepilogo.Text = "Riepilogo";
            // 
            // BTN_Aggiungi
            // 
            this.BTN_Aggiungi.Location = new System.Drawing.Point(265, 59);
            this.BTN_Aggiungi.Name = "BTN_Aggiungi";
            this.BTN_Aggiungi.Size = new System.Drawing.Size(75, 23);
            this.BTN_Aggiungi.TabIndex = 5;
            this.BTN_Aggiungi.Text = "Aggiungi";
            this.BTN_Aggiungi.UseVisualStyleBackColor = true;
            this.BTN_Aggiungi.Click += new System.EventHandler(this.BTN_Aggiungi_Click);
            // 
            // LST_Riepilogo
            // 
            this.LST_Riepilogo.FormattingEnabled = true;
            this.LST_Riepilogo.ItemHeight = 15;
            this.LST_Riepilogo.Location = new System.Drawing.Point(516, 50);
            this.LST_Riepilogo.Name = "LST_Riepilogo";
            this.LST_Riepilogo.Size = new System.Drawing.Size(120, 94);
            this.LST_Riepilogo.TabIndex = 6;
            // 
            // LBL_PizzeMargherite
            // 
            this.LBL_PizzeMargherite.AutoSize = true;
            this.LBL_PizzeMargherite.Location = new System.Drawing.Point(506, 250);
            this.LBL_PizzeMargherite.Name = "LBL_PizzeMargherite";
            this.LBL_PizzeMargherite.Size = new System.Drawing.Size(0, 15);
            this.LBL_PizzeMargherite.TabIndex = 7;
            // 
            // LBL_PizzeVerdure
            // 
            this.LBL_PizzeVerdure.AutoSize = true;
            this.LBL_PizzeVerdure.Location = new System.Drawing.Point(506, 290);
            this.LBL_PizzeVerdure.Name = "LBL_PizzeVerdure";
            this.LBL_PizzeVerdure.Size = new System.Drawing.Size(0, 15);
            this.LBL_PizzeVerdure.TabIndex = 8;
            // 
            // LBL_Pizze4Stagioni
            // 
            this.LBL_Pizze4Stagioni.AutoSize = true;
            this.LBL_Pizze4Stagioni.Location = new System.Drawing.Point(506, 328);
            this.LBL_Pizze4Stagioni.Name = "LBL_Pizze4Stagioni";
            this.LBL_Pizze4Stagioni.Size = new System.Drawing.Size(0, 15);
            this.LBL_Pizze4Stagioni.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 378);
            this.Controls.Add(this.LBL_Pizze4Stagioni);
            this.Controls.Add(this.LBL_PizzeVerdure);
            this.Controls.Add(this.LBL_PizzeMargherite);
            this.Controls.Add(this.LST_Riepilogo);
            this.Controls.Add(this.BTN_Aggiungi);
            this.Controls.Add(this.LBL_Riepilogo);
            this.Controls.Add(this.CBX_Scelta);
            this.Controls.Add(this.TXT_Quantità);
            this.Controls.Add(this.LBL_Quantità);
            this.Controls.Add(this.LBL_TipoPizza);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_TipoPizza;
        private Label LBL_Quantità;
        private TextBox TXT_Quantità;
        private ComboBox CBX_Scelta;
        private Label LBL_Riepilogo;
        private Button BTN_Aggiungi;
        private ListBox LST_Riepilogo;
        private Label LBL_PizzeMargherite;
        private Label LBL_PizzeVerdure;
        private Label LBL_Pizze4Stagioni;
    }
}