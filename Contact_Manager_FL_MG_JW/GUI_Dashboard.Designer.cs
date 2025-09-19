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
<<<<<<< HEAD
            bttmCreateOnDash.Location = new Point(632, 169);
            bttmCreateOnDash.Name = "bttmCreateOnDash";
            bttmCreateOnDash.Size = new Size(172, 59);
=======
            bttmCreateOnDash.Location = new Point(423, 111);
            bttmCreateOnDash.Name = "bttmCreateOnDash";
            bttmCreateOnDash.Size = new Size(172, 58);
>>>>>>> e5d29e8e5173721f7e5a4a025e73b25c301dd531
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
<<<<<<< HEAD
            lblTitel.Location = new Point(615, 94);
=======
            lblTitel.Location = new Point(407, 35);
>>>>>>> e5d29e8e5173721f7e5a4a025e73b25c301dd531
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(211, 32);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Contact Manager";
            // 
            // BtnResetDB
            // 
            BtnResetDB.Anchor = AnchorStyles.Top;
<<<<<<< HEAD
            BtnResetDB.Location = new Point(632, 250);
            BtnResetDB.Name = "BtnResetDB";
            BtnResetDB.Size = new Size(172, 59);
=======
            BtnResetDB.Location = new Point(423, 187);
            BtnResetDB.Name = "BtnResetDB";
            BtnResetDB.Size = new Size(172, 58);
>>>>>>> e5d29e8e5173721f7e5a4a025e73b25c301dd531
            BtnResetDB.TabIndex = 2;
            BtnResetDB.Text = "Datenbank zurücksetzten";
            BtnResetDB.UseVisualStyleBackColor = true;
            BtnResetDB.Click += BtnResetDB_Click;
            // 
            // bttnCsv
            // 
            bttnCsv.Anchor = AnchorStyles.Top;
            bttnCsv.Location = new Point(423, 265);
            bttnCsv.Name = "bttnCsv";
            bttnCsv.Size = new Size(172, 58);
            bttnCsv.TabIndex = 3;
            bttnCsv.Text = "CSV import";
            bttnCsv.UseVisualStyleBackColor = true;
            bttnCsv.Click += bttnCsv_Click;
            // 
            // GUI_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
<<<<<<< HEAD
            ClientSize = new Size(1384, 1361);
=======
            ClientSize = new Size(984, 961);
            Controls.Add(bttnCsv);
>>>>>>> e5d29e8e5173721f7e5a4a025e73b25c301dd531
            Controls.Add(BtnResetDB);
            Controls.Add(lblTitel);
            Controls.Add(bttmCreateOnDash);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
<<<<<<< HEAD
            MaximumSize = new Size(1825, 1576);
            MinimumSize = new Size(985, 854);
=======
            MaximumSize = new Size(1400, 1400);
            MinimumSize = new Size(955, 955);
>>>>>>> e5d29e8e5173721f7e5a4a025e73b25c301dd531
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
