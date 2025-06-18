namespace SkamtRegister
{
    partial class Form1
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
            btnHamta = new Button();
            btnSpara = new Button();
            btnVisa = new Button();
            lblSkamt = new Label();
            lstResultat = new ListBox();
            SuspendLayout();
            // 
            // btnHamta
            // 
            btnHamta.Location = new Point(199, 86);
            btnHamta.Name = "btnHamta";
            btnHamta.Size = new Size(112, 34);
            btnHamta.TabIndex = 0;
            btnHamta.Text = "Hämta skämt";
            btnHamta.UseVisualStyleBackColor = true;
            btnHamta.Click += btnHamta_Click;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(199, 157);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(112, 34);
            btnSpara.TabIndex = 1;
            btnSpara.Text = "Spara skämt";
            btnSpara.UseVisualStyleBackColor = true;
            btnSpara.Click += btnSpara_Click;
            // 
            // btnVisa
            // 
            btnVisa.Location = new Point(199, 231);
            btnVisa.Name = "btnVisa";
            btnVisa.Size = new Size(112, 34);
            btnVisa.TabIndex = 2;
            btnVisa.Text = "Visa sparade";
            btnVisa.UseVisualStyleBackColor = true;
            btnVisa.Click += btnVisa_Click;
            // 
            // lblSkamt
            // 
            lblSkamt.AutoSize = true;
            lblSkamt.Location = new Point(416, 92);
            lblSkamt.Name = "lblSkamt";
            lblSkamt.Size = new Size(0, 25);
            lblSkamt.TabIndex = 3;
            // 
            // lstResultat
            // 
            lstResultat.FormattingEnabled = true;
            lstResultat.Location = new Point(420, 214);
            lstResultat.Name = "lstResultat";
            lstResultat.Size = new Size(180, 129);
            lstResultat.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 429);
            Controls.Add(lstResultat);
            Controls.Add(lblSkamt);
            Controls.Add(btnVisa);
            Controls.Add(btnSpara);
            Controls.Add(btnHamta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHamta;
      
        private Button btnSpara;
        private Button btnVisa;
        private Label lblSkamt;
        private ListBox lstResultat;
    }
}
