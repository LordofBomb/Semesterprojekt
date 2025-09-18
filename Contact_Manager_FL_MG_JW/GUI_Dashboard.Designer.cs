namespace Contact_Manager_FL_MG_JW
{
    partial class GUI_Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Form_ViewAll viewAllPanel;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Dashboard));
            bttmCreateOnDash = new Button();
            lblTitel = new Label();
            BtnResetDB = new Button();
            bttnCsv = new Button();
            SuspendLayout();
            // 
            // bttmCreateOnDash
            // 
            bttmCreateOnDash.Anchor = AnchorStyles.Top;
            bttmCreateOnDash.Location = new Point(602, 283);
            bttmCreateOnDash.Margin = new Padding(4, 5, 4, 5);
            bttmCreateOnDash.Name = "bttmCreateOnDash";
            bttmCreateOnDash.Size = new Size(246, 97);
            bttmCreateOnDash.TabIndex = 0;
            bttmCreateOnDash.Text = "Neuer Kontakt erstellen";
            bttmCreateOnDash.UseVisualStyleBackColor = true;
            bttmCreateOnDash.Click += bttmCreateOnDash_Click;
            // 
            // lblTitel
            // 
            lblTitel.Anchor = AnchorStyles.Top;
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(579, 157);
            lblTitel.Margin = new Padding(4, 0, 4, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(309, 48);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Contact Manager";
            // 
            // BtnResetDB
            // 
            BtnResetDB.Anchor = AnchorStyles.Top;
            BtnResetDB.Location = new Point(602, 410);
            BtnResetDB.Margin = new Padding(4, 5, 4, 5);
            BtnResetDB.Name = "BtnResetDB";
            BtnResetDB.Size = new Size(246, 97);
            BtnResetDB.TabIndex = 2;
            BtnResetDB.Text = "Datenbank zurücksetzten";
            BtnResetDB.UseVisualStyleBackColor = true;
            BtnResetDB.Click += BtnResetDB_Click;
            // 
            // bttnCsv
            // 
            bttnCsv.Anchor = AnchorStyles.Top;
            bttnCsv.Location = new Point(602, 540);
            bttnCsv.Margin = new Padding(4, 5, 4, 5);
            bttnCsv.Name = "bttnCsv";
            bttnCsv.Size = new Size(246, 97);
            bttnCsv.TabIndex = 3;
            bttnCsv.Text = "CSV import";
            bttnCsv.UseVisualStyleBackColor = true;
            bttnCsv.Click += bttnCsv_Click;
            // 
            // GUI_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1378, 1344);
            Controls.Add(bttnCsv);
            Controls.Add(BtnResetDB);
            Controls.Add(lblTitel);
            Controls.Add(bttmCreateOnDash);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(2599, 2591);
            MinimumSize = new Size(1399, 1009);
            Name = "GUI_Dashboard";
            Text = "Contact Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttmCreateOnDash;
        private Label lblTitel;
        private Button BtnResetDB;
        private Button bttnCsv;
    }
}
