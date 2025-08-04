namespace Contact_Manager_FL_MG_JW
{
    partial class GUI_Dashboard
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
            bttmCreateOnDash = new Button();
            lblTitel = new Label();
            BtnResetDB = new Button();
            SuspendLayout();
            // 
            // bttmCreateOnDash
            // 
            bttmCreateOnDash.Location = new Point(305, 229);
            bttmCreateOnDash.Name = "bttmCreateOnDash";
            bttmCreateOnDash.Size = new Size(172, 59);
            bttmCreateOnDash.TabIndex = 0;
            bttmCreateOnDash.Text = "Neuer Kontakt erstellen";
            bttmCreateOnDash.UseVisualStyleBackColor = true;
            bttmCreateOnDash.Click += bttmCreateOnDash_Click;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(339, 63);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(99, 15);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Contact Manager";
            // 
            // BtnResetDB
            // 
            BtnResetDB.Location = new Point(305, 359);
            BtnResetDB.Name = "BtnResetDB";
            BtnResetDB.Size = new Size(172, 59);
            BtnResetDB.TabIndex = 2;
            BtnResetDB.Text = "Datenbank zurücksetzten";
            BtnResetDB.UseVisualStyleBackColor = true;
            BtnResetDB.Click += BtnResetDB_Click;
            //
            // BtnViewAll
            //
            BtnViewAll = new Button();
            BtnViewAll.Location = new Point(305, 294); 
            BtnViewAll.Name = "BtnViewAll";
            BtnViewAll.Size = new Size(172, 59);
            BtnViewAll.TabIndex = 3;
            BtnViewAll.Text = "Alle Kontakte anzeigen";
            BtnViewAll.UseVisualStyleBackColor = true;
            BtnViewAll.Click += new EventHandler(this.BtnViewAll_Click);
            Controls.Add(this.BtnViewAll);
            // 
            // GUI_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnResetDB);
            Controls.Add(lblTitel);
            Controls.Add(bttmCreateOnDash);
            Name = "GUI_Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttmCreateOnDash;
        private Label lblTitel;
        private Button BtnResetDB;
        private Button BtnViewAll;
    }
}
