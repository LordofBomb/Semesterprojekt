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
            txtbPrStreet = new TextBox();
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
            txtbEmpStreet = new TextBox();
            lblEmpAddress = new Label();
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
            txtprplz = new TextBox();
            label2 = new Label();
            groupBoxEmployee = new GroupBox();
            label1 = new Label();
            groupBoxTrainee = new GroupBox();
            BtnSave = new Button();
            txtbEmpPlz = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudEmpLevel).BeginInit();
            groupBoxCustomer.SuspendLayout();
            groupBoxEmployee.SuspendLayout();
            groupBoxTrainee.SuspendLayout();
            SuspendLayout();
            // 
            // txtbTitel
            // 
            txtbTitel.Location = new Point(136, 80);
            txtbTitel.Name = "txtbTitel";
            txtbTitel.Size = new Size(200, 23);
            txtbTitel.TabIndex = 110;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(97, 82);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(33, 15);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Titel:";
            // 
            // txtbFirstName
            // 
            txtbFirstName.Location = new Point(136, 109);
            txtbFirstName.Name = "txtbFirstName";
            txtbFirstName.Size = new Size(200, 23);
            txtbFirstName.TabIndex = 120;
            // 
            // txtbLastName
            // 
            txtbLastName.Location = new Point(136, 140);
            txtbLastName.Name = "txtbLastName";
            txtbLastName.Size = new Size(200, 23);
            txtbLastName.TabIndex = 130;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(74, 112);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(57, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "Vorname:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(88, 143);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(42, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Name:";
            // 
            // ddlGender
            // 
            ddlGender.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlGender.FormattingEnabled = true;
            ddlGender.Items.AddRange(new object[] { "Männlich", "Weiblich", "LGBTQ+" });
            ddlGender.Location = new Point(519, 46);
            ddlGender.MaxDropDownItems = 3;
            ddlGender.Name = "ddlGender";
            ddlGender.Size = new Size(200, 23);
            ddlGender.TabIndex = 140;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(445, 49);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 15);
            lblGender.TabIndex = 8;
            lblGender.Text = "Geschlecht:";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(518, 106);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 160;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(444, 110);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(68, 15);
            lblBirthday.TabIndex = 10;
            lblBirthday.Text = "Geburtstag:";
            // 
            // ddlSalutation
            // 
            ddlSalutation.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlSalutation.FormattingEnabled = true;
            ddlSalutation.Items.AddRange(new object[] { "", "Herr", "Frau" });
            ddlSalutation.Location = new Point(136, 49);
            ddlSalutation.MaxDropDownItems = 3;
            ddlSalutation.Name = "ddlSalutation";
            ddlSalutation.Size = new Size(200, 23);
            ddlSalutation.TabIndex = 100;
            // 
            // lblSalutation
            // 
            lblSalutation.AutoSize = true;
            lblSalutation.Location = new Point(82, 52);
            lblSalutation.Name = "lblSalutation";
            lblSalutation.Size = new Size(48, 15);
            lblSalutation.TabIndex = 12;
            lblSalutation.Text = "Anrede:";
            // 
            // txtbEMail
            // 
            txtbEMail.Location = new Point(517, 76);
            txtbEMail.Name = "txtbEMail";
            txtbEMail.Size = new Size(200, 23);
            txtbEMail.TabIndex = 150;
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.Location = new Point(467, 80);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(44, 15);
            lblEMail.TabIndex = 14;
            lblEMail.Text = "E-Mail:";
            // 
            // ddbStatus
            // 
            ddbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ddbStatus.FormattingEnabled = true;
            ddbStatus.Items.AddRange(new object[] { "aktiv", "inaktiv" });
            ddbStatus.Location = new Point(518, 136);
            ddbStatus.MaxDropDownItems = 2;
            ddbStatus.Name = "ddbStatus";
            ddbStatus.Size = new Size(200, 23);
            ddbStatus.TabIndex = 170;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(470, 139);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Status:";
            // 
            // rbttCustomer
            // 
            rbttCustomer.AutoSize = true;
            rbttCustomer.Location = new Point(327, 202);
            rbttCustomer.Name = "rbttCustomer";
            rbttCustomer.Size = new Size(59, 19);
            rbttCustomer.TabIndex = 180;
            rbttCustomer.TabStop = true;
            rbttCustomer.Text = "Kunde";
            rbttCustomer.UseVisualStyleBackColor = true;
            rbttCustomer.CheckedChanged += rbttCustomer_CheckedChanged;
            // 
            // rbttEmployee
            // 
            rbttEmployee.AutoSize = true;
            rbttEmployee.Location = new Point(392, 202);
            rbttEmployee.Name = "rbttEmployee";
            rbttEmployee.Size = new Size(83, 19);
            rbttEmployee.TabIndex = 190;
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
            rbttKtA.TabIndex = 200;
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
            rbttKtB.TabIndex = 210;
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
            rbttKtC.TabIndex = 220;
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
            rbttKtD.TabIndex = 230;
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
            rbttKtE.TabIndex = 240;
            rbttKtE.TabStop = true;
            rbttKtE.Text = "E";
            rbttKtE.UseVisualStyleBackColor = true;
            // 
            // txtbCoName
            // 
            txtbCoName.Location = new Point(529, 72);
            txtbCoName.Name = "txtbCoName";
            txtbCoName.Size = new Size(200, 23);
            txtbCoName.TabIndex = 270;
            // 
            // lblCoName
            // 
            lblCoName.AutoSize = true;
            lblCoName.Location = new Point(439, 75);
            lblCoName.Name = "lblCoName";
            lblCoName.Size = new Size(84, 15);
            lblCoName.TabIndex = 25;
            lblCoName.Text = "Firmennamen:";
            // 
            // txtbCoAddresse
            // 
            txtbCoAddresse.Location = new Point(529, 101);
            txtbCoAddresse.Name = "txtbCoAddresse";
            txtbCoAddresse.Size = new Size(200, 23);
            txtbCoAddresse.TabIndex = 280;
            // 
            // lblCoAddresse
            // 
            lblCoAddresse.AutoSize = true;
            lblCoAddresse.Location = new Point(423, 104);
            lblCoAddresse.Name = "lblCoAddresse";
            lblCoAddresse.Size = new Size(100, 15);
            lblCoAddresse.TabIndex = 27;
            lblCoAddresse.Text = "Geschäftsadresse:";
            // 
            // lblCoPhoneNr
            // 
            lblCoPhoneNr.AutoSize = true;
            lblCoPhoneNr.Location = new Point(416, 133);
            lblCoPhoneNr.Name = "lblCoPhoneNr";
            lblCoPhoneNr.Size = new Size(107, 15);
            lblCoPhoneNr.TabIndex = 28;
            lblCoPhoneNr.Text = "Geschäftsnummer:";
            // 
            // txtbCoPhoneNr
            // 
            txtbCoPhoneNr.Location = new Point(529, 130);
            txtbCoPhoneNr.Name = "txtbCoPhoneNr";
            txtbCoPhoneNr.Size = new Size(200, 23);
            txtbCoPhoneNr.TabIndex = 290;
            // 
            // txtbPrStreet
            // 
            txtbPrStreet.Location = new Point(130, 74);
            txtbPrStreet.Name = "txtbPrStreet";
            txtbPrStreet.Size = new Size(200, 23);
            txtbPrStreet.TabIndex = 250;
            // 
            // lblPrAddress
            // 
            lblPrAddress.AutoSize = true;
            lblPrAddress.Location = new Point(78, 80);
            lblPrAddress.Name = "lblPrAddress";
            lblPrAddress.Size = new Size(46, 15);
            lblPrAddress.TabIndex = 31;
            lblPrAddress.Text = "Strasse:";
            // 
            // txtbPrPhone
            // 
            txtbPrPhone.Location = new Point(130, 130);
            txtbPrPhone.Name = "txtbPrPhone";
            txtbPrPhone.Size = new Size(200, 23);
            txtbPrPhone.TabIndex = 260;
            // 
            // lblPrPhone
            // 
            lblPrPhone.AutoSize = true;
            lblPrPhone.Location = new Point(13, 126);
            lblPrPhone.Name = "lblPrPhone";
            lblPrPhone.Size = new Size(111, 15);
            lblPrPhone.TabIndex = 33;
            lblPrPhone.Text = "Telefonnr/Handynr:";
            // 
            // txtbAHVNr
            // 
            txtbAHVNr.Location = new Point(168, 49);
            txtbAHVNr.Name = "txtbAHVNr";
            txtbAHVNr.Size = new Size(200, 23);
            txtbAHVNr.TabIndex = 200;
            // 
            // lblAHVNr
            // 
            lblAHVNr.AutoSize = true;
            lblAHVNr.Location = new Point(75, 52);
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
            dtphiringdate.Location = new Point(548, 46);
            dtphiringdate.MinDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtphiringdate.Name = "dtphiringdate";
            dtphiringdate.Size = new Size(200, 23);
            dtphiringdate.TabIndex = 270;
            // 
            // lblhiringdate
            // 
            lblhiringdate.AutoSize = true;
            lblhiringdate.Location = new Point(457, 52);
            lblhiringdate.Name = "lblhiringdate";
            lblhiringdate.Size = new Size(85, 15);
            lblhiringdate.TabIndex = 39;
            lblhiringdate.Text = "Eintrittsdatum:";
            // 
            // dtpExitDate
            // 
            dtpExitDate.Location = new Point(548, 109);
            dtpExitDate.MinDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpExitDate.Name = "dtpExitDate";
            dtpExitDate.Size = new Size(200, 23);
            dtpExitDate.TabIndex = 280;
            // 
            // lblExitDate
            // 
            lblExitDate.AutoSize = true;
            lblExitDate.Location = new Point(451, 115);
            lblExitDate.Name = "lblExitDate";
            lblExitDate.Size = new Size(89, 15);
            lblExitDate.TabIndex = 41;
            lblExitDate.Text = "Austrittsdatum:";
            // 
            // txtbEmpStreet
            // 
            txtbEmpStreet.Location = new Point(168, 80);
            txtbEmpStreet.Name = "txtbEmpStreet";
            txtbEmpStreet.Size = new Size(200, 23);
            txtbEmpStreet.TabIndex = 210;
            // 
            // lblEmpAddress
            // 
            lblEmpAddress.AutoSize = true;
            lblEmpAddress.Location = new Point(111, 83);
            lblEmpAddress.Name = "lblEmpAddress";
            lblEmpAddress.Size = new Size(46, 15);
            lblEmpAddress.TabIndex = 43;
            lblEmpAddress.Text = "Strasse:";
            // 
            // txtbMoPhone
            // 
            txtbMoPhone.Location = new Point(169, 136);
            txtbMoPhone.Name = "txtbMoPhone";
            txtbMoPhone.Size = new Size(200, 23);
            txtbMoPhone.TabIndex = 220;
            // 
            // lblMoPhone
            // 
            lblMoPhone.AutoSize = true;
            lblMoPhone.Location = new Point(72, 139);
            lblMoPhone.Name = "lblMoPhone";
            lblMoPhone.Size = new Size(91, 15);
            lblMoPhone.TabIndex = 47;
            lblMoPhone.Text = "Handynummer:";
            // 
            // txtbNationality
            // 
            txtbNationality.Location = new Point(169, 170);
            txtbNationality.Name = "txtbNationality";
            txtbNationality.Size = new Size(200, 23);
            txtbNationality.TabIndex = 240;
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(90, 171);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(72, 15);
            lblNationality.TabIndex = 49;
            lblNationality.Text = "Nationalität:";
            // 
            // nudEmpLevel
            // 
            nudEmpLevel.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudEmpLevel.Location = new Point(548, 240);
            nudEmpLevel.Name = "nudEmpLevel";
            nudEmpLevel.Size = new Size(40, 23);
            nudEmpLevel.TabIndex = 320;
            // 
            // lblEmpLevel
            // 
            lblEmpLevel.AutoSize = true;
            lblEmpLevel.Location = new Point(427, 242);
            lblEmpLevel.Name = "lblEmpLevel";
            lblEmpLevel.Size = new Size(115, 15);
            lblEmpLevel.TabIndex = 51;
            lblEmpLevel.Text = "Beschäftigungsgrad:";
            // 
            // lblLoAddress
            // 
            lblLoAddress.AutoSize = true;
            lblLoAddress.Location = new Point(448, 21);
            lblLoAddress.Name = "lblLoAddress";
            lblLoAddress.Size = new Size(94, 15);
            lblLoAddress.TabIndex = 53;
            lblLoAddress.Text = "Standortadresse:";
            // 
            // ddbLoAddress
            // 
            ddbLoAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            ddbLoAddress.FormattingEnabled = true;
            ddbLoAddress.Items.AddRange(new object[] { "Abtwil", "Steinach", "Herisau" });
            ddbLoAddress.Location = new Point(548, 17);
            ddbLoAddress.Name = "ddbLoAddress";
            ddbLoAddress.Size = new Size(200, 23);
            ddbLoAddress.TabIndex = 260;
            // 
            // ddbDepartment
            // 
            ddbDepartment.FormattingEnabled = true;
            ddbDepartment.Items.AddRange(new object[] { "HR", "IT", "Entwicklung", "Produktion", "Kundensupport", "Facility Management" });
            ddbDepartment.Location = new Point(546, 170);
            ddbDepartment.Name = "ddbDepartment";
            ddbDepartment.Size = new Size(200, 23);
            ddbDepartment.TabIndex = 300;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(478, 173);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(62, 15);
            lblDepartment.TabIndex = 56;
            lblDepartment.Text = "Abteilung:";
            // 
            // txtbRole
            // 
            txtbRole.Location = new Point(546, 204);
            txtbRole.Name = "txtbRole";
            txtbRole.Size = new Size(200, 23);
            txtbRole.TabIndex = 310;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(412, 207);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(128, 15);
            lblRole.TabIndex = 58;
            lblRole.Text = "Tätigkeitsbezeichnung:";
            // 
            // lblCadreLvl
            // 
            lblCadreLvl.AutoSize = true;
            lblCadreLvl.Location = new Point(474, 144);
            lblCadreLvl.Name = "lblCadreLvl";
            lblCadreLvl.Size = new Size(66, 15);
            lblCadreLvl.TabIndex = 60;
            lblCadreLvl.Text = "Kaderstufe:";
            // 
            // ddbCadreLvl
            // 
            ddbCadreLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            ddbCadreLvl.FormattingEnabled = true;
            ddbCadreLvl.Items.AddRange(new object[] { "0 - keine Kaderfunktion", "1 - unterste Kaderstufe", "2 - mittleres Kader", "3 - hohes Kader", "4 - Verwaltung", "5 - Geschäftsführung" });
            ddbCadreLvl.Location = new Point(546, 141);
            ddbCadreLvl.MaxDropDownItems = 6;
            ddbCadreLvl.Name = "ddbCadreLvl";
            ddbCadreLvl.Size = new Size(200, 23);
            ddbCadreLvl.TabIndex = 290;
            // 
            // txtbIntPhNr
            // 
            txtbIntPhNr.Location = new Point(168, 207);
            txtbIntPhNr.Name = "txtbIntPhNr";
            txtbIntPhNr.Size = new Size(200, 23);
            txtbIntPhNr.TabIndex = 250;
            // 
            // lblIntPhNr
            // 
            lblIntPhNr.AutoSize = true;
            lblIntPhNr.Location = new Point(34, 210);
            lblIntPhNr.Name = "lblIntPhNr";
            lblIntPhNr.Size = new Size(129, 15);
            lblIntPhNr.TabIndex = 63;
            lblIntPhNr.Text = "Telefonnummer Intern:";
            // 
            // ChbTrainee
            // 
            ChbTrainee.AutoSize = true;
            ChbTrainee.Location = new Point(473, 291);
            ChbTrainee.Name = "ChbTrainee";
            ChbTrainee.Size = new Size(69, 19);
            ChbTrainee.TabIndex = 330;
            ChbTrainee.Text = "Lehrling";
            ChbTrainee.UseVisualStyleBackColor = true;
            ChbTrainee.CheckedChanged += ChbTrainee_CheckedChanged;
            // 
            // txtbNrOfYearsOfAppr
            // 
            txtbNrOfYearsOfAppr.Location = new Point(177, 25);
            txtbNrOfYearsOfAppr.Name = "txtbNrOfYearsOfAppr";
            txtbNrOfYearsOfAppr.Size = new Size(200, 23);
            txtbNrOfYearsOfAppr.TabIndex = 340;
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
            txtbWhYearsOfAppr.TabIndex = 350;
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
            groupBoxCustomer.Controls.Add(txtprplz);
            groupBoxCustomer.Controls.Add(label2);
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
            groupBoxCustomer.Controls.Add(txtbPrStreet);
            groupBoxCustomer.Controls.Add(lblPrAddress);
            groupBoxCustomer.Controls.Add(txtbPrPhone);
            groupBoxCustomer.Controls.Add(lblPrPhone);
            groupBoxCustomer.Location = new Point(33, 331);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Size = new Size(749, 165);
            groupBoxCustomer.TabIndex = 69;
            groupBoxCustomer.TabStop = false;
            // 
            // txtprplz
            // 
            txtprplz.Location = new Point(130, 101);
            txtprplz.Name = "txtprplz";
            txtprplz.Size = new Size(200, 23);
            txtprplz.TabIndex = 292;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 104);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 291;
            label2.Text = "PLZ und Ort:";
            // 
            // groupBoxEmployee
            // 
            groupBoxEmployee.Controls.Add(label3);
            groupBoxEmployee.Controls.Add(txtbEmpPlz);
            groupBoxEmployee.Controls.Add(label1);
            groupBoxEmployee.Controls.Add(groupBoxTrainee);
            groupBoxEmployee.Controls.Add(txtbAHVNr);
            groupBoxEmployee.Controls.Add(lblAHVNr);
            groupBoxEmployee.Controls.Add(lblEmpNr);
            groupBoxEmployee.Controls.Add(lblEmpNrOut);
            groupBoxEmployee.Controls.Add(ChbTrainee);
            groupBoxEmployee.Controls.Add(dtphiringdate);
            groupBoxEmployee.Controls.Add(lblIntPhNr);
            groupBoxEmployee.Controls.Add(txtbIntPhNr);
            groupBoxEmployee.Controls.Add(lblhiringdate);
            groupBoxEmployee.Controls.Add(dtpExitDate);
            groupBoxEmployee.Controls.Add(ddbCadreLvl);
            groupBoxEmployee.Controls.Add(lblExitDate);
            groupBoxEmployee.Controls.Add(lblCadreLvl);
            groupBoxEmployee.Controls.Add(txtbEmpStreet);
            groupBoxEmployee.Controls.Add(lblRole);
            groupBoxEmployee.Controls.Add(lblEmpAddress);
            groupBoxEmployee.Controls.Add(txtbRole);
            groupBoxEmployee.Controls.Add(lblDepartment);
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
            groupBoxEmployee.Size = new Size(766, 381);
            groupBoxEmployee.TabIndex = 70;
            groupBoxEmployee.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 242);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 70;
            label1.Text = "%";
            // 
            // groupBoxTrainee
            // 
            groupBoxTrainee.Controls.Add(lblWhYearsOfAppr);
            groupBoxTrainee.Controls.Add(txtbNrOfYearsOfAppr);
            groupBoxTrainee.Controls.Add(lblNrOfYearsOfAppr);
            groupBoxTrainee.Controls.Add(txtbWhYearsOfAppr);
            groupBoxTrainee.Location = new Point(6, 307);
            groupBoxTrainee.Name = "groupBoxTrainee";
            groupBoxTrainee.Size = new Size(754, 68);
            groupBoxTrainee.TabIndex = 69;
            groupBoxTrainee.TabStop = false;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(266, 715);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(326, 44);
            BtnSave.TabIndex = 9000;
            BtnSave.Text = "Eintrag speichern";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // txtbEmpPlz
            // 
            txtbEmpPlz.Location = new Point(168, 109);
            txtbEmpPlz.Name = "txtbEmpPlz";
            txtbEmpPlz.Size = new Size(200, 23);
            txtbEmpPlz.TabIndex = 331;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 112);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 332;
            label3.Text = "PLZ und Ort:";
            // 
            // GUI_Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 791);
            Controls.Add(groupBoxEmployee);
            Controls.Add(groupBoxCustomer);
            Controls.Add(BtnSave);
            Controls.Add(rbttEmployee);
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

        internal TextBox txtbTitel;
        internal Label lblTitel;
        internal TextBox txtbFirstName;
        internal TextBox txtbLastName;
        internal Label lblFirstName;
        internal Label lblLastName;
        internal ComboBox ddlGender;
        internal Label lblGender;
        internal DateTimePicker dtpBirthday;
        internal Label lblBirthday;
        internal ComboBox ddlSalutation;
        internal Label lblSalutation;
        internal TextBox txtbEMail;
        internal Label lblEMail;
        internal ComboBox ddbStatus;
        internal Label lblStatus;
        internal RadioButton rbttCustomer;
        internal RadioButton rbttEmployee;
        internal RadioButton rbttKtA;
        internal RadioButton rbttKtB;
        internal RadioButton rbttKtC;
        internal RadioButton rbttKtD;
        internal RadioButton rbttKtE;
        internal TextBox txtbCoName;
        internal Label lblCoName;
        internal TextBox txtbCoAddresse;
        internal Label lblCoAddresse;
        internal Label lblCoPhoneNr;
        internal TextBox txtbCoPhoneNr;
        internal TextBox txtbPrStreet;
        internal Label lblPrAddress;
        internal TextBox txtbPrPhone;
        internal Label lblPrPhone;
        internal TextBox txtbAHVNr;
        internal Label lblAHVNr;
        internal Label lblEmpNr;
        internal Label lblEmpNrOut;
        internal DateTimePicker dtphiringdate;
        internal Label lblhiringdate;
        internal DateTimePicker dtpExitDate;
        internal Label lblExitDate;
        internal TextBox txtbEmpStreet;
        internal Label lblEmpAddress;
        internal TextBox txtbMoPhone;
        internal Label lblMoPhone;
        internal TextBox txtbNationality;
        internal Label lblNationality;
        internal NumericUpDown nudEmpLevel;
        internal Label lblEmpLevel;
        internal Label lblLoAddress;
        internal ComboBox ddbLoAddress;
        internal ComboBox ddbDepartment;
        internal Label lblDepartment;
        internal TextBox txtbRole;
        internal Label lblRole;
        internal Label lblCadreLvl;
        internal ComboBox ddbCadreLvl;
        internal TextBox txtbIntPhNr;
        internal Label lblIntPhNr;
        internal CheckBox ChbTrainee;
        internal TextBox txtbNrOfYearsOfAppr;
        internal Label lblNrOfYearsOfAppr;
        internal TextBox txtbWhYearsOfAppr;
        internal Label lblWhYearsOfAppr;
        internal GroupBox groupBoxCustomer;
        internal GroupBox groupBoxEmployee;
        internal GroupBox groupBoxTrainee;
        internal Button BtnSave;
        internal Label label1;
        internal TextBox txtprplz;
        internal Label label2;
        internal Label label3;
        internal TextBox txtbEmpPlz;
    }
}