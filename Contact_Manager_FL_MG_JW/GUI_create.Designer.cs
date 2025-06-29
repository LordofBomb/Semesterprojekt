namespace Contact_Manager_FL_MG_JW
{
    partial class GUI_Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtbTitel = new TextBox();
            lblTitel = new Label();
            txtbFirstName = new TextBox();
            txtbLastName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            ddlGender = new ComboBox();
            lblGender = new Label();
            dtpBirthday = new DateTimePicker();
            lblBirthday = new Label();
            ddlSalutation = new ComboBox();
            lblSalutation = new Label();
            txtbEMail = new TextBox();
            lblEMail = new Label();
            ddbStatus = new ComboBox();
            lblStatus = new Label();
            rbttCustomer = new RadioButton();
            rbttEmployee = new RadioButton();
            rbttKtA = new RadioButton();
            rbttKtB = new RadioButton();
            rbttKtC = new RadioButton();
            rbttKtD = new RadioButton();
            rbttKtE = new RadioButton();
            txtbCoName = new TextBox();
            lblCoName = new Label();
            txtbCoAddresse = new TextBox();
            lblCoAddresse = new Label();
            lblCoPhoneNr = new Label();
            txtbCoPhoneNr = new TextBox();
            txtbPrAddress = new TextBox();
            lblPrAddress = new Label();
            txtbPrPhone = new TextBox();
            lblPrPhone = new Label();
            txtbAHVNr = new TextBox();
            lblAHVNr = new Label();
            lblEmpNr = new Label();
            lblEmpNrOut = new Label();
            dtphiringdate = new DateTimePicker();
            lblhiringdate = new Label();
            dtpExitDate = new DateTimePicker();
            lblExitDate = new Label();
            txtbEmpAddress = new TextBox();
            lblEmpAddress = new Label();
            txtbEmpResi = new TextBox();
            lblEmpResi = new Label();
            txtbMoPhone = new TextBox();
            lblMoPhone = new Label();
            txtbNationality = new TextBox();
            lblNationality = new Label();
            nudEmpLevel = new NumericUpDown();
            lblEmpLevel = new Label();
            lblLoAddress = new Label();
            ddbLoAddress = new ComboBox();
            ddbDepartment = new ComboBox();
            lblDepartment = new Label();
            txtbRole = new TextBox();
            lblRole = new Label();
            lblCadreLvl = new Label();
            ddbCadreLvl = new ComboBox();
            txtbIntPhNr = new TextBox();
            lblIntPhNr = new Label();
            ChbTrainee = new CheckBox();
            txtbNrOfYearsOfAppr = new TextBox();
            lblNrOfYearsOfAppr = new Label();
            txtbWhYearsOfAppr = new TextBox();
            lblWhYearsOfAppr = new Label();
            groupBoxCustomer = new GroupBox();
            groupBoxEmployee = new GroupBox();
            groupBoxTrainee = new GroupBox();
            BtnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)nudEmpLevel).BeginInit();
            groupBoxCustomer.SuspendLayout();
            groupBoxEmployee.SuspendLayout();
            groupBoxTrainee.SuspendLayout();
            SuspendLayout();
            // 
            // txtbTitel
            // 
            txtbTitel.Location = new Point(582, 149);
            txtbTitel.Name = "txtbTitel";
            txtbTitel.Size = new Size(200, 23);
            txtbTitel.TabIndex = 0;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(543, 152);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(33, 15);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Titel:";
            // 
            // txtbFirstName
            // 
            txtbFirstName.Location = new Point(200, 181);
            txtbFirstName.Name = "txtbFirstName";
            txtbFirstName.Size = new Size(200, 23);
            txtbFirstName.TabIndex = 2;
            // 
            // txtbLastName
            // 
            txtbLastName.Location = new Point(582, 178);
            txtbLastName.Name = "txtbLastName";
            txtbLastName.Size = new Size(200, 23);
            txtbLastName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(137, 184);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(57, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "Vorname:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(534, 181);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(42, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Name:";
            // 
            // ddlGender
            // 
            ddlGender.FormattingEnabled = true;
            ddlGender.Location = new Point(200, 210);
            ddlGender.Name = "ddlGender";
            ddlGender.Size = new Size(200, 23);
            ddlGender.TabIndex = 7;
            ddlGender.SelectedIndexChanged += ddlGender_SelectedIndexChanged;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(126, 213);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 15);
            lblGender.TabIndex = 8;
            lblGender.Text = "Geschlecht:";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(582, 207);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 9;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(508, 213);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(68, 15);
            lblBirthday.TabIndex = 10;
            lblBirthday.Text = "Geburtstag:";
            // 
            // ddlSalutation
            // 
            ddlSalutation.FormattingEnabled = true;
            ddlSalutation.Location = new Point(200, 152);
            ddlSalutation.Name = "ddlSalutation";
            ddlSalutation.Size = new Size(200, 23);
            ddlSalutation.TabIndex = 11;
            // 
            // lblSalutation
            // 
            lblSalutation.AutoSize = true;
            lblSalutation.Location = new Point(146, 155);
            lblSalutation.Name = "lblSalutation";
            lblSalutation.Size = new Size(48, 15);
            lblSalutation.TabIndex = 12;
            lblSalutation.Text = "Anrede:";
            // 
            // txtbEMail
            // 
            txtbEMail.Location = new Point(200, 239);
            txtbEMail.Name = "txtbEMail";
            txtbEMail.Size = new Size(200, 23);
            txtbEMail.TabIndex = 13;
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.Location = new Point(146, 242);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(44, 15);
            lblEMail.TabIndex = 14;
            lblEMail.Text = "E-Mail:";
            // 
            // ddbStatus
            // 
            ddbStatus.FormattingEnabled = true;
            ddbStatus.Location = new Point(582, 239);
            ddbStatus.Name = "ddbStatus";
            ddbStatus.Size = new Size(200, 23);
            ddbStatus.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(534, 242);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Status:";
            // 
            // rbttCustomer
            // 
            rbttCustomer.AutoSize = true;
            rbttCustomer.Location = new Point(391, 306);
            rbttCustomer.Name = "rbttCustomer";
            rbttCustomer.Size = new Size(59, 19);
            rbttCustomer.TabIndex = 17;
            rbttCustomer.TabStop = true;
            rbttCustomer.Text = "Kunde";
            rbttCustomer.UseVisualStyleBackColor = true;
            rbttCustomer.CheckedChanged += rbttCustomer_CheckedChanged;
            // 
            // rbttEmployee
            // 
            rbttEmployee.AutoSize = true;
            rbttEmployee.Location = new Point(456, 306);
            rbttEmployee.Name = "rbttEmployee";
            rbttEmployee.Size = new Size(83, 19);
            rbttEmployee.TabIndex = 18;
            rbttEmployee.TabStop = true;
            rbttEmployee.Text = "Mitarbeiter";
            rbttEmployee.UseVisualStyleBackColor = true;
            rbttEmployee.CheckedChanged += rbttEmployee_CheckedChanged;
            // 
            // rbttKtA
            // 
            rbttKtA.AutoSize = true;
            rbttKtA.Location = new Point(297, 37);
            rbttKtA.Name = "rbttKtA";
            rbttKtA.Size = new Size(33, 19);
            rbttKtA.TabIndex = 19;
            rbttKtA.TabStop = true;
            rbttKtA.Text = "A";
            rbttKtA.UseVisualStyleBackColor = true;
            // 
            // rbttKtB
            // 
            rbttKtB.AutoSize = true;
            rbttKtB.Location = new Point(336, 37);
            rbttKtB.Name = "rbttKtB";
            rbttKtB.Size = new Size(32, 19);
            rbttKtB.TabIndex = 20;
            rbttKtB.TabStop = true;
            rbttKtB.Text = "B";
            rbttKtB.UseVisualStyleBackColor = true;
            // 
            // rbttKtC
            // 
            rbttKtC.AutoSize = true;
            rbttKtC.Location = new Point(374, 37);
            rbttKtC.Name = "rbttKtC";
            rbttKtC.Size = new Size(33, 19);
            rbttKtC.TabIndex = 21;
            rbttKtC.TabStop = true;
            rbttKtC.Text = "C";
            rbttKtC.UseVisualStyleBackColor = true;
            // 
            // rbttKtD
            // 
            rbttKtD.AutoSize = true;
            rbttKtD.Location = new Point(413, 37);
            rbttKtD.Name = "rbttKtD";
            rbttKtD.Size = new Size(33, 19);
            rbttKtD.TabIndex = 22;
            rbttKtD.TabStop = true;
            rbttKtD.Text = "D";
            rbttKtD.UseVisualStyleBackColor = true;
            // 
            // rbttKtE
            // 
            rbttKtE.AutoSize = true;
            rbttKtE.Location = new Point(452, 37);
            rbttKtE.Name = "rbttKtE";
            rbttKtE.Size = new Size(31, 19);
            rbttKtE.TabIndex = 23;
            rbttKtE.TabStop = true;
            rbttKtE.Text = "E";
            rbttKtE.UseVisualStyleBackColor = true;
            // 
            // txtbCoName
            // 
            txtbCoName.Location = new Point(147, 71);
            txtbCoName.Name = "txtbCoName";
            txtbCoName.Size = new Size(200, 23);
            txtbCoName.TabIndex = 24;
            // 
            // lblCoName
            // 
            lblCoName.AutoSize = true;
            lblCoName.Location = new Point(57, 74);
            lblCoName.Name = "lblCoName";
            lblCoName.Size = new Size(84, 15);
            lblCoName.TabIndex = 25;
            lblCoName.Text = "Firmennamen:";
            // 
            // txtbCoAddresse
            // 
            txtbCoAddresse.Location = new Point(147, 100);
            txtbCoAddresse.Name = "txtbCoAddresse";
            txtbCoAddresse.Size = new Size(200, 23);
            txtbCoAddresse.TabIndex = 26;
            // 
            // lblCoAddresse
            // 
            lblCoAddresse.AutoSize = true;
            lblCoAddresse.Location = new Point(41, 103);
            lblCoAddresse.Name = "lblCoAddresse";
            lblCoAddresse.Size = new Size(100, 15);
            lblCoAddresse.TabIndex = 27;
            lblCoAddresse.Text = "Geschäftsadresse:";
            // 
            // lblCoPhoneNr
            // 
            lblCoPhoneNr.AutoSize = true;
            lblCoPhoneNr.Location = new Point(34, 132);
            lblCoPhoneNr.Name = "lblCoPhoneNr";
            lblCoPhoneNr.Size = new Size(107, 15);
            lblCoPhoneNr.TabIndex = 28;
            lblCoPhoneNr.Text = "Geschäftsnummer:";
            // 
            // txtbCoPhoneNr
            // 
            txtbCoPhoneNr.Location = new Point(147, 129);
            txtbCoPhoneNr.Name = "txtbCoPhoneNr";
            txtbCoPhoneNr.Size = new Size(200, 23);
            txtbCoPhoneNr.TabIndex = 29;
            // 
            // txtbPrAddress
            // 
            txtbPrAddress.Location = new Point(529, 72);
            txtbPrAddress.Name = "txtbPrAddress";
            txtbPrAddress.Size = new Size(200, 23);
            txtbPrAddress.TabIndex = 30;
            // 
            // lblPrAddress
            // 
            lblPrAddress.AutoSize = true;
            lblPrAddress.Location = new Point(472, 75);
            lblPrAddress.Name = "lblPrAddress";
            lblPrAddress.Size = new Size(51, 15);
            lblPrAddress.TabIndex = 31;
            lblPrAddress.Text = "Adresse:";
            // 
            // txtbPrPhone
            // 
            txtbPrPhone.Location = new Point(529, 101);
            txtbPrPhone.Name = "txtbPrPhone";
            txtbPrPhone.Size = new Size(200, 23);
            txtbPrPhone.TabIndex = 32;
            // 
            // lblPrPhone
            // 
            lblPrPhone.AutoSize = true;
            lblPrPhone.Location = new Point(412, 104);
            lblPrPhone.Name = "lblPrPhone";
            lblPrPhone.Size = new Size(111, 15);
            lblPrPhone.TabIndex = 33;
            lblPrPhone.Text = "Telefonnr/Handynr:";
            // 
            // txtbAHVNr
            // 
            txtbAHVNr.Location = new Point(550, 23);
            txtbAHVNr.Name = "txtbAHVNr";
            txtbAHVNr.Size = new Size(200, 23);
            txtbAHVNr.TabIndex = 34;
            // 
            // lblAHVNr
            // 
            lblAHVNr.AutoSize = true;
            lblAHVNr.Location = new Point(457, 26);
            lblAHVNr.Name = "lblAHVNr";
            lblAHVNr.Size = new Size(87, 15);
            lblAHVNr.TabIndex = 35;
            lblAHVNr.Text = "AHV-Nummer:";
            // 
            // lblEmpNr
            // 
            lblEmpNr.AutoSize = true;
            lblEmpNr.Location = new Point(48, 25);
            lblEmpNr.Name = "lblEmpNr";
            lblEmpNr.Size = new Size(114, 15);
            lblEmpNr.TabIndex = 36;
            lblEmpNr.Text = "Mitarbeiternummer:";
            // 
            // lblEmpNrOut
            // 
            lblEmpNrOut.AutoSize = true;
            lblEmpNrOut.Location = new Point(168, 25);
            lblEmpNrOut.Name = "lblEmpNrOut";
            lblEmpNrOut.Size = new Size(72, 15);
            lblEmpNrOut.TabIndex = 37;
            lblEmpNrOut.Text = "xxxxxxxxxxxxx";
            // 
            // dtphiringdate
            // 
            dtphiringdate.Location = new Point(168, 51);
            dtphiringdate.Name = "dtphiringdate";
            dtphiringdate.Size = new Size(200, 23);
            dtphiringdate.TabIndex = 38;
            // 
            // lblhiringdate
            // 
            lblhiringdate.AutoSize = true;
            lblhiringdate.Location = new Point(77, 57);
            lblhiringdate.Name = "lblhiringdate";
            lblhiringdate.Size = new Size(85, 15);
            lblhiringdate.TabIndex = 39;
            lblhiringdate.Text = "Eintrittsdatum:";
            // 
            // dtpExitDate
            // 
            dtpExitDate.Location = new Point(550, 52);
            dtpExitDate.Name = "dtpExitDate";
            dtpExitDate.Size = new Size(200, 23);
            dtpExitDate.TabIndex = 40;
            // 
            // lblExitDate
            // 
            lblExitDate.AutoSize = true;
            lblExitDate.Location = new Point(453, 58);
            lblExitDate.Name = "lblExitDate";
            lblExitDate.Size = new Size(89, 15);
            lblExitDate.TabIndex = 41;
            lblExitDate.Text = "Austrittsdatum:";
            // 
            // txtbEmpAddress
            // 
            txtbEmpAddress.Location = new Point(168, 80);
            txtbEmpAddress.Name = "txtbEmpAddress";
            txtbEmpAddress.Size = new Size(200, 23);
            txtbEmpAddress.TabIndex = 42;
            // 
            // lblEmpAddress
            // 
            lblEmpAddress.AutoSize = true;
            lblEmpAddress.Location = new Point(111, 83);
            lblEmpAddress.Name = "lblEmpAddress";
            lblEmpAddress.Size = new Size(51, 15);
            lblEmpAddress.TabIndex = 43;
            lblEmpAddress.Text = "Adresse:";
            // 
            // txtbEmpResi
            // 
            txtbEmpResi.Location = new Point(550, 81);
            txtbEmpResi.Name = "txtbEmpResi";
            txtbEmpResi.Size = new Size(200, 23);
            txtbEmpResi.TabIndex = 44;
            // 
            // lblEmpResi
            // 
            lblEmpResi.AutoSize = true;
            lblEmpResi.Location = new Point(487, 85);
            lblEmpResi.Name = "lblEmpResi";
            lblEmpResi.Size = new Size(57, 15);
            lblEmpResi.TabIndex = 45;
            lblEmpResi.Text = "Wohnort:";
            // 
            // txtbMoPhone
            // 
            txtbMoPhone.Location = new Point(168, 109);
            txtbMoPhone.Name = "txtbMoPhone";
            txtbMoPhone.Size = new Size(200, 23);
            txtbMoPhone.TabIndex = 46;
            // 
            // lblMoPhone
            // 
            lblMoPhone.AutoSize = true;
            lblMoPhone.Location = new Point(71, 112);
            lblMoPhone.Name = "lblMoPhone";
            lblMoPhone.Size = new Size(91, 15);
            lblMoPhone.TabIndex = 47;
            lblMoPhone.Text = "Handynummer:";
            // 
            // txtbNationality
            // 
            txtbNationality.Location = new Point(550, 110);
            txtbNationality.Name = "txtbNationality";
            txtbNationality.Size = new Size(200, 23);
            txtbNationality.TabIndex = 48;
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(472, 113);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(72, 15);
            lblNationality.TabIndex = 49;
            lblNationality.Text = "Nationalität:";
            // 
            // nudEmpLevel
            // 
            nudEmpLevel.Location = new Point(168, 138);
            nudEmpLevel.Name = "nudEmpLevel";
            nudEmpLevel.Size = new Size(200, 23);
            nudEmpLevel.TabIndex = 50;
            // 
            // lblEmpLevel
            // 
            lblEmpLevel.AutoSize = true;
            lblEmpLevel.Location = new Point(47, 140);
            lblEmpLevel.Name = "lblEmpLevel";
            lblEmpLevel.Size = new Size(115, 15);
            lblEmpLevel.TabIndex = 51;
            lblEmpLevel.Text = "Beschäftigungsgrad:";
            // 
            // lblLoAddress
            // 
            lblLoAddress.AutoSize = true;
            lblLoAddress.Location = new Point(450, 142);
            lblLoAddress.Name = "lblLoAddress";
            lblLoAddress.Size = new Size(94, 15);
            lblLoAddress.TabIndex = 53;
            lblLoAddress.Text = "Standortadresse:";
            // 
            // ddbLoAddress
            // 
            ddbLoAddress.FormattingEnabled = true;
            ddbLoAddress.Location = new Point(550, 138);
            ddbLoAddress.Name = "ddbLoAddress";
            ddbLoAddress.Size = new Size(200, 23);
            ddbLoAddress.TabIndex = 54;
            // 
            // ddbDepartment
            // 
            ddbDepartment.FormattingEnabled = true;
            ddbDepartment.Location = new Point(168, 167);
            ddbDepartment.Name = "ddbDepartment";
            ddbDepartment.Size = new Size(200, 23);
            ddbDepartment.TabIndex = 55;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(100, 170);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(62, 15);
            lblDepartment.TabIndex = 56;
            lblDepartment.Text = "Abteilung:";
            // 
            // txtbRole
            // 
            txtbRole.Location = new Point(550, 167);
            txtbRole.Name = "txtbRole";
            txtbRole.Size = new Size(200, 23);
            txtbRole.TabIndex = 57;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(416, 170);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(128, 15);
            lblRole.TabIndex = 58;
            lblRole.Text = "Tätigkeitsbezeichnung:";
            // 
            // lblCadreLvl
            // 
            lblCadreLvl.AutoSize = true;
            lblCadreLvl.Location = new Point(96, 199);
            lblCadreLvl.Name = "lblCadreLvl";
            lblCadreLvl.Size = new Size(66, 15);
            lblCadreLvl.TabIndex = 60;
            lblCadreLvl.Text = "Kaderstufe:";
            // 
            // ddbCadreLvl
            // 
            ddbCadreLvl.FormattingEnabled = true;
            ddbCadreLvl.Location = new Point(168, 196);
            ddbCadreLvl.Name = "ddbCadreLvl";
            ddbCadreLvl.Size = new Size(200, 23);
            ddbCadreLvl.TabIndex = 61;
            // 
            // txtbIntPhNr
            // 
            txtbIntPhNr.Location = new Point(550, 199);
            txtbIntPhNr.Name = "txtbIntPhNr";
            txtbIntPhNr.Size = new Size(200, 23);
            txtbIntPhNr.TabIndex = 62;
            // 
            // lblIntPhNr
            // 
            lblIntPhNr.AutoSize = true;
            lblIntPhNr.Location = new Point(415, 202);
            lblIntPhNr.Name = "lblIntPhNr";
            lblIntPhNr.Size = new Size(129, 15);
            lblIntPhNr.TabIndex = 63;
            lblIntPhNr.Text = "Telefonnummer Intern:";
            // 
            // ChbTrainee
            // 
            ChbTrainee.AutoSize = true;
            ChbTrainee.Location = new Point(359, 235);
            ChbTrainee.Name = "ChbTrainee";
            ChbTrainee.Size = new Size(69, 19);
            ChbTrainee.TabIndex = 64;
            ChbTrainee.Text = "Lehrling";
            ChbTrainee.UseVisualStyleBackColor = true;
            ChbTrainee.CheckedChanged += ChbTrainee_CheckedChanged;
            // 
            // txtbNrOfYearsOfAppr
            // 
            txtbNrOfYearsOfAppr.Location = new Point(177, 25);
            txtbNrOfYearsOfAppr.Name = "txtbNrOfYearsOfAppr";
            txtbNrOfYearsOfAppr.Size = new Size(200, 23);
            txtbNrOfYearsOfAppr.TabIndex = 65;
            // 
            // lblNrOfYearsOfAppr
            // 
            lblNrOfYearsOfAppr.AutoSize = true;
            lblNrOfYearsOfAppr.Location = new Point(10, 28);
            lblNrOfYearsOfAppr.Name = "lblNrOfYearsOfAppr";
            lblNrOfYearsOfAppr.Size = new Size(161, 15);
            lblNrOfYearsOfAppr.TabIndex = 66;
            lblNrOfYearsOfAppr.Text = "Anzahl der Ausbildungsjahre:";
            // 
            // txtbWhYearsOfAppr
            // 
            txtbWhYearsOfAppr.Location = new Point(559, 25);
            txtbWhYearsOfAppr.Name = "txtbWhYearsOfAppr";
            txtbWhYearsOfAppr.Size = new Size(200, 23);
            txtbWhYearsOfAppr.TabIndex = 67;
            // 
            // lblWhYearsOfAppr
            // 
            lblWhYearsOfAppr.AutoSize = true;
            lblWhYearsOfAppr.Location = new Point(406, 28);
            lblWhYearsOfAppr.Name = "lblWhYearsOfAppr";
            lblWhYearsOfAppr.Size = new Size(147, 15);
            lblWhYearsOfAppr.TabIndex = 68;
            lblWhYearsOfAppr.Text = "Aktuelles Ausbildungsjahr:";
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.Controls.Add(lblCoName);
            groupBoxCustomer.Controls.Add(rbttKtA);
            groupBoxCustomer.Controls.Add(rbttKtB);
            groupBoxCustomer.Controls.Add(rbttKtC);
            groupBoxCustomer.Controls.Add(rbttKtD);
            groupBoxCustomer.Controls.Add(rbttKtE);
            groupBoxCustomer.Controls.Add(txtbCoName);
            groupBoxCustomer.Controls.Add(txtbCoAddresse);
            groupBoxCustomer.Controls.Add(lblCoAddresse);
            groupBoxCustomer.Controls.Add(lblCoPhoneNr);
            groupBoxCustomer.Controls.Add(txtbCoPhoneNr);
            groupBoxCustomer.Controls.Add(txtbPrAddress);
            groupBoxCustomer.Controls.Add(lblPrAddress);
            groupBoxCustomer.Controls.Add(txtbPrPhone);
            groupBoxCustomer.Controls.Add(lblPrPhone);
            groupBoxCustomer.Location = new Point(33, 331);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Size = new Size(749, 165);
            groupBoxCustomer.TabIndex = 69;
            groupBoxCustomer.TabStop = false;
            // 
            // groupBoxEmployee
            // 
            groupBoxEmployee.Controls.Add(groupBoxTrainee);
            groupBoxEmployee.Controls.Add(txtbAHVNr);
            groupBoxEmployee.Controls.Add(lblAHVNr);
            groupBoxEmployee.Controls.Add(lblEmpNr);
            groupBoxEmployee.Controls.Add(lblEmpNrOut);
            groupBoxEmployee.Controls.Add(ChbTrainee);
            groupBoxEmployee.Controls.Add(dtphiringdate);
            groupBoxEmployee.Controls.Add(lblIntPhNr);
            groupBoxEmployee.Controls.Add(lblhiringdate);
            groupBoxEmployee.Controls.Add(txtbIntPhNr);
            groupBoxEmployee.Controls.Add(dtpExitDate);
            groupBoxEmployee.Controls.Add(ddbCadreLvl);
            groupBoxEmployee.Controls.Add(lblExitDate);
            groupBoxEmployee.Controls.Add(lblCadreLvl);
            groupBoxEmployee.Controls.Add(txtbEmpAddress);
            groupBoxEmployee.Controls.Add(lblRole);
            groupBoxEmployee.Controls.Add(lblEmpAddress);
            groupBoxEmployee.Controls.Add(txtbRole);
            groupBoxEmployee.Controls.Add(txtbEmpResi);
            groupBoxEmployee.Controls.Add(lblDepartment);
            groupBoxEmployee.Controls.Add(lblEmpResi);
            groupBoxEmployee.Controls.Add(ddbDepartment);
            groupBoxEmployee.Controls.Add(txtbMoPhone);
            groupBoxEmployee.Controls.Add(ddbLoAddress);
            groupBoxEmployee.Controls.Add(lblMoPhone);
            groupBoxEmployee.Controls.Add(lblLoAddress);
            groupBoxEmployee.Controls.Add(txtbNationality);
            groupBoxEmployee.Controls.Add(lblEmpLevel);
            groupBoxEmployee.Controls.Add(lblNationality);
            groupBoxEmployee.Controls.Add(nudEmpLevel);
            groupBoxEmployee.Location = new Point(33, 328);
            groupBoxEmployee.Name = "groupBoxEmployee";
            groupBoxEmployee.Size = new Size(766, 337);
            groupBoxEmployee.TabIndex = 70;
            groupBoxEmployee.TabStop = false;
            // 
            // groupBoxTrainee
            // 
            groupBoxTrainee.Controls.Add(lblWhYearsOfAppr);
            groupBoxTrainee.Controls.Add(txtbNrOfYearsOfAppr);
            groupBoxTrainee.Controls.Add(lblNrOfYearsOfAppr);
            groupBoxTrainee.Controls.Add(txtbWhYearsOfAppr);
            groupBoxTrainee.Location = new Point(6, 260);
            groupBoxTrainee.Name = "groupBoxTrainee";
            groupBoxTrainee.Size = new Size(754, 68);
            groupBoxTrainee.TabIndex = 69;
            groupBoxTrainee.TabStop = false;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(276, 671);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(326, 44);
            BtnSave.TabIndex = 71;
            BtnSave.Text = "Eintrag speichern";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // GUI_Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 911);
            Controls.Add(BtnSave);
            Controls.Add(groupBoxEmployee);
            Controls.Add(rbttEmployee);
            Controls.Add(groupBoxCustomer);
            Controls.Add(rbttCustomer);
            Controls.Add(lblStatus);
            Controls.Add(ddbStatus);
            Controls.Add(lblEMail);
            Controls.Add(txtbEMail);
            Controls.Add(lblSalutation);
            Controls.Add(ddlSalutation);
            Controls.Add(lblBirthday);
            Controls.Add(dtpBirthday);
            Controls.Add(lblGender);
            Controls.Add(ddlGender);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtbLastName);
            Controls.Add(txtbFirstName);
            Controls.Add(lblTitel);
            Controls.Add(txtbTitel);
            Name = "GUI_Create";
            Text = "Kontakt erstellen";
            ((System.ComponentModel.ISupportInitialize)nudEmpLevel).EndInit();
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            groupBoxEmployee.ResumeLayout(false);
            groupBoxEmployee.PerformLayout();
            groupBoxTrainee.ResumeLayout(false);
            groupBoxTrainee.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbTitel;
        private Label lblTitel;
        private TextBox txtbFirstName;
        private TextBox txtbLastName;
        private Label lblFirstName;
        private Label lblLastName;
        private ComboBox ddlGender;
        private Label lblGender;
        private DateTimePicker dtpBirthday;
        private Label lblBirthday;
        private ComboBox ddlSalutation;
        private Label lblSalutation;
        private TextBox txtbEMail;
        private Label lblEMail;
        private ComboBox ddbStatus;
        private Label lblStatus;
        private RadioButton rbttCustomer;
        private RadioButton rbttEmployee;
        private RadioButton rbttKtA;
        private RadioButton rbttKtB;
        private RadioButton rbttKtC;
        private RadioButton rbttKtD;
        private RadioButton rbttKtE;
        private TextBox txtbCoName;
        private Label lblCoName;
        private TextBox txtbCoAddresse;
        private Label lblCoAddresse;
        private Label lblCoPhoneNr;
        private TextBox txtbCoPhoneNr;
        private TextBox txtbPrAddress;
        private Label lblPrAddress;
        private TextBox txtbPrPhone;
        private Label lblPrPhone;
        private TextBox txtbAHVNr;
        private Label lblAHVNr;
        private Label lblEmpNr;
        private Label lblEmpNrOut;
        private DateTimePicker dtphiringdate;
        private Label lblhiringdate;
        private DateTimePicker dtpExitDate;
        private Label lblExitDate;
        private TextBox txtbEmpAddress;
        private Label lblEmpAddress;
        private TextBox txtbEmpResi;
        private Label lblEmpResi;
        private TextBox txtbMoPhone;
        private Label lblMoPhone;
        private TextBox txtbNationality;
        private Label lblNationality;
        private NumericUpDown nudEmpLevel;
        private Label lblEmpLevel;
        private Label lblLoAddress;
        private ComboBox ddbLoAddress;
        private ComboBox ddbDepartment;
        private Label lblDepartment;
        private TextBox txtbRole;
        private Label lblRole;
        private Label lblCadreLvl;
        private ComboBox ddbCadreLvl;
        private TextBox txtbIntPhNr;
        private Label lblIntPhNr;
        private CheckBox ChbTrainee;
        private TextBox txtbNrOfYearsOfAppr;
        private Label lblNrOfYearsOfAppr;
        private TextBox txtbWhYearsOfAppr;
        private Label lblWhYearsOfAppr;
        private GroupBox groupBoxCustomer;
        private GroupBox groupBoxEmployee;
        private GroupBox groupBoxTrainee;
        private Button BtnSave;
    }
}