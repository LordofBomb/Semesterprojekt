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
            SuspendLayout();
            // 
            // bttmCreateOnDash
            // 
            bttmCreateOnDash.Anchor = AnchorStyles.Top;
            bttmCreateOnDash.Location = new Point(605, 282);
            bttmCreateOnDash.Margin = new Padding(4, 5, 4, 5);
            bttmCreateOnDash.Name = "bttmCreateOnDash";
            bttmCreateOnDash.Size = new Size(246, 98);
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
            lblTitel.Location = new Point(582, 156);
            lblTitel.Margin = new Padding(4, 0, 4, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(309, 48);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Contact Manager";
            // 
            // BtnResetDB
            // 
            BtnResetDB.Anchor = AnchorStyles.Top;
            BtnResetDB.Location = new Point(605, 416);
            BtnResetDB.Margin = new Padding(4, 5, 4, 5);
            BtnResetDB.Name = "BtnResetDB";
            BtnResetDB.Size = new Size(246, 98);
            BtnResetDB.TabIndex = 2;
            BtnResetDB.Text = "Datenbank zurücksetzten";
            BtnResetDB.UseVisualStyleBackColor = true;
            BtnResetDB.Click += BtnResetDB_Click;
            // 
            // GUI_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1378, 1344);
            Controls.Add(BtnResetDB);
            Controls.Add(lblTitel);
            Controls.Add(bttmCreateOnDash);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1400, 1400);
            MinimumSize = new Size(1400, 1400);
            Name = "GUI_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttmCreateOnDash;
        private Label lblTitel;
        private Button BtnResetDB;
    }
}
