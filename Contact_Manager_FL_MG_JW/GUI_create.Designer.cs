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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Create));
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
            TxtbCoPlace = new TextBox();
            LblCoPlace = new Label();
            txtprplz = new TextBox();
            label2 = new Label();
            groupBoxEmployee = new GroupBox();
            ChkbExitDate = new CheckBox();
            LblEmpPlace = new Label();
            txtbEmpPlace = new TextBox();
            LblEmpPlz = new Label();
            txtbEmpPlz = new TextBox();
            label1 = new Label();
            groupBoxTrainee = new GroupBox();
            BtnSave = new Button();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)nudEmpLevel).BeginInit();
            groupBoxCustomer.SuspendLayout();
            groupBoxEmployee.SuspendLayout();
            groupBoxTrainee.SuspendLayout();
            SuspendLayout();
            // 
            // txtbTitel
            // 
            txtbTitel.Location = new Point(344, 155);
            txtbTitel.Margin = new Padding(4, 5, 4, 5);
            txtbTitel.Name = "txtbTitel";
            txtbTitel.Size = new Size(284, 31);
            txtbTitel.TabIndex = 110;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(289, 159);
            lblTitel.Margin = new Padding(4, 0, 4, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(48, 25);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Titel:";
            // 
            // txtbFirstName
            // 
            txtbFirstName.Location = new Point(344, 204);
            txtbFirstName.Margin = new Padding(4, 5, 4, 5);
            txtbFirstName.Name = "txtbFirstName";
            txtbFirstName.Size = new Size(284, 31);
            txtbFirstName.TabIndex = 120;
            // 
            // txtbLastName
            // 
            txtbLastName.Location = new Point(344, 255);
            txtbLastName.Margin = new Padding(4, 5, 4, 5);
            txtbLastName.Name = "txtbLastName";
            txtbLastName.Size = new Size(284, 31);
            txtbLastName.TabIndex = 130;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(256, 209);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(87, 25);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "Vorname:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(276, 260);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 25);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Name:";
            // 
            // ddlGender
            // 
            ddlGender.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlGender.FormattingEnabled = true;
            ddlGender.Items.AddRange(new object[] { "Männlich", "Weiblich", "LGBTQ+" });
            ddlGender.Location = new Point(891, 99);
            ddlGender.Margin = new Padding(4, 5, 4, 5);
            ddlGender.MaxDropDownItems = 3;
            ddlGender.Name = "ddlGender";
            ddlGender.Size = new Size(284, 33);
            ddlGender.TabIndex = 140;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(786, 104);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 25);
            lblGender.TabIndex = 8;
            lblGender.Text = "Geschlecht:";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(890, 199);
            dtpBirthday.Margin = new Padding(4, 5, 4, 5);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(284, 31);
            dtpBirthday.TabIndex = 160;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(784, 205);
            lblBirthday.Margin = new Padding(4, 0, 4, 0);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(104, 25);
            lblBirthday.TabIndex = 10;
            lblBirthday.Text = "Geburtstag:";
            // 
            // ddlSalutation
            // 
            ddlSalutation.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlSalutation.FormattingEnabled = true;
            ddlSalutation.Items.AddRange(new object[] { "", "Herr", "Frau" });
            ddlSalutation.Location = new Point(344, 104);
            ddlSalutation.Margin = new Padding(4, 5, 4, 5);
            ddlSalutation.MaxDropDownItems = 3;
            ddlSalutation.Name = "ddlSalutation";
            ddlSalutation.Size = new Size(284, 33);
            ddlSalutation.TabIndex = 100;
            // 
            // lblSalutation
            // 
            lblSalutation.AutoSize = true;
            lblSalutation.Location = new Point(267, 109);
            lblSalutation.Margin = new Padding(4, 0, 4, 0);
            lblSalutation.Name = "lblSalutation";
            lblSalutation.Size = new Size(73, 25);
            lblSalutation.TabIndex = 12;
            lblSalutation.Text = "Anrede:";
            // 
            // txtbEMail
            // 
            txtbEMail.Location = new Point(889, 149);
            txtbEMail.Margin = new Padding(4, 5, 4, 5);
            txtbEMail.Name = "txtbEMail";
            txtbEMail.Size = new Size(284, 31);
            txtbEMail.TabIndex = 150;
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.Location = new Point(817, 155);
            lblEMail.Margin = new Padding(4, 0, 4, 0);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(65, 25);
            lblEMail.TabIndex = 14;
            lblEMail.Text = "E-Mail:";
            // 
            // ddbStatus
            // 
            ddbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ddbStatus.FormattingEnabled = true;
            ddbStatus.Items.AddRange(new object[] { "aktiv", "inaktiv" });
            ddbStatus.Location = new Point(890, 249);
            ddbStatus.Margin = new Padding(4, 5, 4, 5);
            ddbStatus.MaxDropDownItems = 2;
            ddbStatus.Name = "ddbStatus";
            ddbStatus.Size = new Size(284, 33);
            ddbStatus.TabIndex = 170;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(821, 254);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Status:";
            // 
            // rbttCustomer
            // 
            rbttCustomer.AutoSize = true;
            rbttCustomer.Location = new Point(617, 359);
            rbttCustomer.Margin = new Padding(4, 5, 4, 5);
            rbttCustomer.Name = "rbttCustomer";
            rbttCustomer.Size = new Size(87, 29);
            rbttCustomer.TabIndex = 180;
            rbttCustomer.TabStop = true;
            rbttCustomer.Text = "Kunde";
            rbttCustomer.UseVisualStyleBackColor = true;
            rbttCustomer.CheckedChanged += rbttCustomer_CheckedChanged;
            // 
            // rbttEmployee
            // 
            rbttEmployee.AutoSize = true;
            rbttEmployee.Location = new Point(710, 359);
            rbttEmployee.Margin = new Padding(4, 5, 4, 5);
            rbttEmployee.Name = "rbttEmployee";
            rbttEmployee.Size = new Size(123, 29);
            rbttEmployee.TabIndex = 190;
            rbttEmployee.TabStop = true;
            rbttEmployee.Text = "Mitarbeiter";
            rbttEmployee.UseVisualStyleBackColor = true;
            rbttEmployee.CheckedChanged += rbttEmployee_CheckedChanged;
            // 
            // rbttKtA
            // 
            rbttKtA.AutoSize = true;
            rbttKtA.Location = new Point(424, 62);
            rbttKtA.Margin = new Padding(4, 5, 4, 5);
            rbttKtA.Name = "rbttKtA";
            rbttKtA.Size = new Size(49, 29);
            rbttKtA.TabIndex = 200;
            rbttKtA.TabStop = true;
            rbttKtA.Text = "A";
            rbttKtA.UseVisualStyleBackColor = true;
            // 
            // rbttKtB
            // 
            rbttKtB.AutoSize = true;
            rbttKtB.Location = new Point(480, 62);
            rbttKtB.Margin = new Padding(4, 5, 4, 5);
            rbttKtB.Name = "rbttKtB";
            rbttKtB.Size = new Size(47, 29);
            rbttKtB.TabIndex = 210;
            rbttKtB.TabStop = true;
            rbttKtB.Text = "B";
            rbttKtB.UseVisualStyleBackColor = true;
            // 
            // rbttKtC
            // 
            rbttKtC.AutoSize = true;
            rbttKtC.Location = new Point(534, 62);
            rbttKtC.Margin = new Padding(4, 5, 4, 5);
            rbttKtC.Name = "rbttKtC";
            rbttKtC.Size = new Size(48, 29);
            rbttKtC.TabIndex = 220;
            rbttKtC.TabStop = true;
            rbttKtC.Text = "C";
            rbttKtC.UseVisualStyleBackColor = true;
            // 
            // rbttKtD
            // 
            rbttKtD.AutoSize = true;
            rbttKtD.Location = new Point(590, 62);
            rbttKtD.Margin = new Padding(4, 5, 4, 5);
            rbttKtD.Name = "rbttKtD";
            rbttKtD.Size = new Size(50, 29);
            rbttKtD.TabIndex = 230;
            rbttKtD.TabStop = true;
            rbttKtD.Text = "D";
            rbttKtD.UseVisualStyleBackColor = true;
            // 
            // rbttKtE
            // 
            rbttKtE.AutoSize = true;
            rbttKtE.Location = new Point(646, 62);
            rbttKtE.Margin = new Padding(4, 5, 4, 5);
            rbttKtE.Name = "rbttKtE";
            rbttKtE.Size = new Size(46, 29);
            rbttKtE.TabIndex = 240;
            rbttKtE.TabStop = true;
            rbttKtE.Text = "E";
            rbttKtE.UseVisualStyleBackColor = true;
            // 
            // txtbCoName
            // 
            txtbCoName.Location = new Point(756, 120);
            txtbCoName.Margin = new Padding(4, 5, 4, 5);
            txtbCoName.Name = "txtbCoName";
            txtbCoName.Size = new Size(284, 31);
            txtbCoName.TabIndex = 270;
            // 
            // lblCoName
            // 
            lblCoName.AutoSize = true;
            lblCoName.Location = new Point(627, 125);
            lblCoName.Margin = new Padding(4, 0, 4, 0);
            lblCoName.Name = "lblCoName";
            lblCoName.Size = new Size(124, 25);
            lblCoName.TabIndex = 25;
            lblCoName.Text = "Firmennamen:";
            // 
            // txtbCoAddresse
            // 
            txtbCoAddresse.Location = new Point(756, 168);
            txtbCoAddresse.Margin = new Padding(4, 5, 4, 5);
            txtbCoAddresse.Name = "txtbCoAddresse";
            txtbCoAddresse.Size = new Size(284, 31);
            txtbCoAddresse.TabIndex = 280;
            // 
            // lblCoAddresse
            // 
            lblCoAddresse.AutoSize = true;
            lblCoAddresse.Location = new Point(604, 173);
            lblCoAddresse.Margin = new Padding(4, 0, 4, 0);
            lblCoAddresse.Name = "lblCoAddresse";
            lblCoAddresse.Size = new Size(152, 25);
            lblCoAddresse.TabIndex = 27;
            lblCoAddresse.Text = "Geschäftsadresse:";
            // 
            // lblCoPhoneNr
            // 
            lblCoPhoneNr.AutoSize = true;
            lblCoPhoneNr.Location = new Point(594, 222);
            lblCoPhoneNr.Margin = new Padding(4, 0, 4, 0);
            lblCoPhoneNr.Name = "lblCoPhoneNr";
            lblCoPhoneNr.Size = new Size(159, 25);
            lblCoPhoneNr.TabIndex = 28;
            lblCoPhoneNr.Text = "Geschäftsnummer:";
            // 
            // txtbCoPhoneNr
            // 
            txtbCoPhoneNr.Location = new Point(756, 217);
            txtbCoPhoneNr.Margin = new Padding(4, 5, 4, 5);
            txtbCoPhoneNr.Name = "txtbCoPhoneNr";
            txtbCoPhoneNr.Size = new Size(284, 31);
            txtbCoPhoneNr.TabIndex = 290;
            // 
            // txtbPrStreet
            // 
            txtbPrStreet.Location = new Point(186, 123);
            txtbPrStreet.Margin = new Padding(4, 5, 4, 5);
            txtbPrStreet.Name = "txtbPrStreet";
            txtbPrStreet.Size = new Size(284, 31);
            txtbPrStreet.TabIndex = 250;
            // 
            // lblPrAddress
            // 
            lblPrAddress.AutoSize = true;
            lblPrAddress.Location = new Point(111, 133);
            lblPrAddress.Margin = new Padding(4, 0, 4, 0);
            lblPrAddress.Name = "lblPrAddress";
            lblPrAddress.Size = new Size(71, 25);
            lblPrAddress.TabIndex = 31;
            lblPrAddress.Text = "Strasse:";
            // 
            // txtbPrPhone
            // 
            txtbPrPhone.Location = new Point(186, 270);
            txtbPrPhone.Margin = new Padding(4, 5, 4, 5);
            txtbPrPhone.Name = "txtbPrPhone";
            txtbPrPhone.Size = new Size(284, 31);
            txtbPrPhone.TabIndex = 260;
            // 
            // lblPrPhone
            // 
            lblPrPhone.AutoSize = true;
            lblPrPhone.Location = new Point(19, 278);
            lblPrPhone.Margin = new Padding(4, 0, 4, 0);
            lblPrPhone.Name = "lblPrPhone";
            lblPrPhone.Size = new Size(163, 25);
            lblPrPhone.TabIndex = 33;
            lblPrPhone.Text = "Telefonnr/Handynr:";
            // 
            // txtbAHVNr
            // 
            txtbAHVNr.Location = new Point(240, 82);
            txtbAHVNr.Margin = new Padding(4, 5, 4, 5);
            txtbAHVNr.Name = "txtbAHVNr";
            txtbAHVNr.Size = new Size(284, 31);
            txtbAHVNr.TabIndex = 200;
            // 
            // lblAHVNr
            // 
            lblAHVNr.AutoSize = true;
            lblAHVNr.Location = new Point(107, 87);
            lblAHVNr.Margin = new Padding(4, 0, 4, 0);
            lblAHVNr.Name = "lblAHVNr";
            lblAHVNr.Size = new Size(129, 25);
            lblAHVNr.TabIndex = 35;
            lblAHVNr.Text = "AHV-Nummer:";
            // 
            // lblEmpNr
            // 
            lblEmpNr.AutoSize = true;
            lblEmpNr.Location = new Point(69, 42);
            lblEmpNr.Margin = new Padding(4, 0, 4, 0);
            lblEmpNr.Name = "lblEmpNr";
            lblEmpNr.Size = new Size(169, 25);
            lblEmpNr.TabIndex = 36;
            lblEmpNr.Text = "Mitarbeiternummer:";
            // 
            // lblEmpNrOut
            // 
            lblEmpNrOut.AutoSize = true;
            lblEmpNrOut.Location = new Point(240, 42);
            lblEmpNrOut.Margin = new Padding(4, 0, 4, 0);
            lblEmpNrOut.Name = "lblEmpNrOut";
            lblEmpNrOut.Size = new Size(116, 25);
            lblEmpNrOut.TabIndex = 37;
            lblEmpNrOut.Text = "xxxxxxxxxxxxx";
            // 
            // dtphiringdate
            // 
            dtphiringdate.Location = new Point(783, 77);
            dtphiringdate.Margin = new Padding(4, 5, 4, 5);
            dtphiringdate.MinDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtphiringdate.Name = "dtphiringdate";
            dtphiringdate.Size = new Size(284, 31);
            dtphiringdate.TabIndex = 270;
            // 
            // lblhiringdate
            // 
            lblhiringdate.AutoSize = true;
            lblhiringdate.Location = new Point(653, 87);
            lblhiringdate.Margin = new Padding(4, 0, 4, 0);
            lblhiringdate.Name = "lblhiringdate";
            lblhiringdate.Size = new Size(127, 25);
            lblhiringdate.TabIndex = 39;
            lblhiringdate.Text = "Eintrittsdatum:";
            // 
            // dtpExitDate
            // 
            dtpExitDate.Location = new Point(783, 182);
            dtpExitDate.Margin = new Padding(4, 5, 4, 5);
            dtpExitDate.MinDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpExitDate.Name = "dtpExitDate";
            dtpExitDate.Size = new Size(284, 31);
            dtpExitDate.TabIndex = 280;
            dtpExitDate.Visible = false;
            // 
            // lblExitDate
            // 
            lblExitDate.AutoSize = true;
            lblExitDate.Location = new Point(644, 192);
            lblExitDate.Margin = new Padding(4, 0, 4, 0);
            lblExitDate.Name = "lblExitDate";
            lblExitDate.Size = new Size(134, 25);
            lblExitDate.TabIndex = 41;
            lblExitDate.Text = "Austrittsdatum:";
            // 
            // txtbEmpStreet
            // 
            txtbEmpStreet.Location = new Point(240, 133);
            txtbEmpStreet.Margin = new Padding(4, 5, 4, 5);
            txtbEmpStreet.Name = "txtbEmpStreet";
            txtbEmpStreet.Size = new Size(284, 31);
            txtbEmpStreet.TabIndex = 210;
            // 
            // lblEmpAddress
            // 
            lblEmpAddress.AutoSize = true;
            lblEmpAddress.Location = new Point(159, 138);
            lblEmpAddress.Margin = new Padding(4, 0, 4, 0);
            lblEmpAddress.Name = "lblEmpAddress";
            lblEmpAddress.Size = new Size(71, 25);
            lblEmpAddress.TabIndex = 43;
            lblEmpAddress.Text = "Strasse:";
            // 
            // txtbMoPhone
            // 
            txtbMoPhone.Location = new Point(240, 307);
            txtbMoPhone.Margin = new Padding(4, 5, 4, 5);
            txtbMoPhone.Name = "txtbMoPhone";
            txtbMoPhone.Size = new Size(284, 31);
            txtbMoPhone.TabIndex = 220;
            // 
            // lblMoPhone
            // 
            lblMoPhone.AutoSize = true;
            lblMoPhone.Location = new Point(101, 312);
            lblMoPhone.Margin = new Padding(4, 0, 4, 0);
            lblMoPhone.Name = "lblMoPhone";
            lblMoPhone.Size = new Size(135, 25);
            lblMoPhone.TabIndex = 47;
            lblMoPhone.Text = "Handynummer:";
            // 
            // txtbNationality
            // 
            txtbNationality.Location = new Point(240, 363);
            txtbNationality.Margin = new Padding(4, 5, 4, 5);
            txtbNationality.Name = "txtbNationality";
            txtbNationality.Size = new Size(284, 31);
            txtbNationality.TabIndex = 240;
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(127, 365);
            lblNationality.Margin = new Padding(4, 0, 4, 0);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(107, 25);
            lblNationality.TabIndex = 49;
            lblNationality.Text = "Nationalität:";
            // 
            // nudEmpLevel
            // 
            nudEmpLevel.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudEmpLevel.Location = new Point(783, 400);
            nudEmpLevel.Margin = new Padding(4, 5, 4, 5);
            nudEmpLevel.Name = "nudEmpLevel";
            nudEmpLevel.Size = new Size(57, 31);
            nudEmpLevel.TabIndex = 320;
            // 
            // lblEmpLevel
            // 
            lblEmpLevel.AutoSize = true;
            lblEmpLevel.Location = new Point(610, 403);
            lblEmpLevel.Margin = new Padding(4, 0, 4, 0);
            lblEmpLevel.Name = "lblEmpLevel";
            lblEmpLevel.Size = new Size(173, 25);
            lblEmpLevel.TabIndex = 51;
            lblEmpLevel.Text = "Beschäftigungsgrad:";
            // 
            // lblLoAddress
            // 
            lblLoAddress.AutoSize = true;
            lblLoAddress.Location = new Point(640, 35);
            lblLoAddress.Margin = new Padding(4, 0, 4, 0);
            lblLoAddress.Name = "lblLoAddress";
            lblLoAddress.Size = new Size(144, 25);
            lblLoAddress.TabIndex = 53;
            lblLoAddress.Text = "Standortadresse:";
            // 
            // ddbLoAddress
            // 
            ddbLoAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            ddbLoAddress.FormattingEnabled = true;
            ddbLoAddress.Items.AddRange(new object[] { "Abtwil", "Steinach", "Herisau" });
            ddbLoAddress.Location = new Point(783, 28);
            ddbLoAddress.Margin = new Padding(4, 5, 4, 5);
            ddbLoAddress.Name = "ddbLoAddress";
            ddbLoAddress.Size = new Size(284, 33);
            ddbLoAddress.TabIndex = 260;
            // 
            // ddbDepartment
            // 
            ddbDepartment.FormattingEnabled = true;
            ddbDepartment.Items.AddRange(new object[] { "HR", "IT", "Entwicklung", "Produktion", "Kundensupport", "Facility Management" });
            ddbDepartment.Location = new Point(780, 283);
            ddbDepartment.Margin = new Padding(4, 5, 4, 5);
            ddbDepartment.Name = "ddbDepartment";
            ddbDepartment.Size = new Size(284, 33);
            ddbDepartment.TabIndex = 300;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(683, 288);
            lblDepartment.Margin = new Padding(4, 0, 4, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(93, 25);
            lblDepartment.TabIndex = 56;
            lblDepartment.Text = "Abteilung:";
            // 
            // txtbRole
            // 
            txtbRole.Location = new Point(780, 340);
            txtbRole.Margin = new Padding(4, 5, 4, 5);
            txtbRole.Name = "txtbRole";
            txtbRole.Size = new Size(284, 31);
            txtbRole.TabIndex = 310;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(589, 345);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(189, 25);
            lblRole.TabIndex = 58;
            lblRole.Text = "Tätigkeitsbezeichnung:";
            // 
            // lblCadreLvl
            // 
            lblCadreLvl.AutoSize = true;
            lblCadreLvl.Location = new Point(677, 240);
            lblCadreLvl.Margin = new Padding(4, 0, 4, 0);
            lblCadreLvl.Name = "lblCadreLvl";
            lblCadreLvl.Size = new Size(100, 25);
            lblCadreLvl.TabIndex = 60;
            lblCadreLvl.Text = "Kaderstufe:";
            // 
            // ddbCadreLvl
            // 
            ddbCadreLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            ddbCadreLvl.FormattingEnabled = true;
            ddbCadreLvl.Items.AddRange(new object[] { "0 - keine Kaderfunktion", "1 - unterste Kaderstufe", "2 - mittleres Kader", "3 - hohes Kader", "4 - Verwaltung", "5 - Geschäftsführung" });
            ddbCadreLvl.Location = new Point(780, 235);
            ddbCadreLvl.Margin = new Padding(4, 5, 4, 5);
            ddbCadreLvl.MaxDropDownItems = 6;
            ddbCadreLvl.Name = "ddbCadreLvl";
            ddbCadreLvl.Size = new Size(284, 33);
            ddbCadreLvl.TabIndex = 290;
            // 
            // txtbIntPhNr
            // 
            txtbIntPhNr.Location = new Point(783, 128);
            txtbIntPhNr.Margin = new Padding(4, 5, 4, 5);
            txtbIntPhNr.Name = "txtbIntPhNr";
            txtbIntPhNr.Size = new Size(284, 31);
            txtbIntPhNr.TabIndex = 250;
            // 
            // lblIntPhNr
            // 
            lblIntPhNr.AutoSize = true;
            lblIntPhNr.Location = new Point(591, 133);
            lblIntPhNr.Margin = new Padding(4, 0, 4, 0);
            lblIntPhNr.Name = "lblIntPhNr";
            lblIntPhNr.Size = new Size(190, 25);
            lblIntPhNr.TabIndex = 63;
            lblIntPhNr.Text = "Telefonnummer Intern:";
            // 
            // ChbTrainee
            // 
            ChbTrainee.AutoSize = true;
            ChbTrainee.Location = new Point(676, 485);
            ChbTrainee.Margin = new Padding(4, 5, 4, 5);
            ChbTrainee.Name = "ChbTrainee";
            ChbTrainee.Size = new Size(100, 29);
            ChbTrainee.TabIndex = 330;
            ChbTrainee.Text = "Lehrling";
            ChbTrainee.UseVisualStyleBackColor = true;
            ChbTrainee.CheckedChanged += ChbTrainee_CheckedChanged;
            // 
            // txtbNrOfYearsOfAppr
            // 
            txtbNrOfYearsOfAppr.Location = new Point(253, 42);
            txtbNrOfYearsOfAppr.Margin = new Padding(4, 5, 4, 5);
            txtbNrOfYearsOfAppr.Name = "txtbNrOfYearsOfAppr";
            txtbNrOfYearsOfAppr.Size = new Size(284, 31);
            txtbNrOfYearsOfAppr.TabIndex = 340;
            // 
            // lblNrOfYearsOfAppr
            // 
            lblNrOfYearsOfAppr.AutoSize = true;
            lblNrOfYearsOfAppr.Location = new Point(14, 47);
            lblNrOfYearsOfAppr.Margin = new Padding(4, 0, 4, 0);
            lblNrOfYearsOfAppr.Name = "lblNrOfYearsOfAppr";
            lblNrOfYearsOfAppr.Size = new Size(242, 25);
            lblNrOfYearsOfAppr.TabIndex = 66;
            lblNrOfYearsOfAppr.Text = "Anzahl der Ausbildungsjahre:";
            // 
            // txtbWhYearsOfAppr
            // 
            txtbWhYearsOfAppr.Location = new Point(799, 42);
            txtbWhYearsOfAppr.Margin = new Padding(4, 5, 4, 5);
            txtbWhYearsOfAppr.Name = "txtbWhYearsOfAppr";
            txtbWhYearsOfAppr.Size = new Size(284, 31);
            txtbWhYearsOfAppr.TabIndex = 350;
            // 
            // lblWhYearsOfAppr
            // 
            lblWhYearsOfAppr.AutoSize = true;
            lblWhYearsOfAppr.Location = new Point(580, 47);
            lblWhYearsOfAppr.Margin = new Padding(4, 0, 4, 0);
            lblWhYearsOfAppr.Name = "lblWhYearsOfAppr";
            lblWhYearsOfAppr.Size = new Size(220, 25);
            lblWhYearsOfAppr.TabIndex = 68;
            lblWhYearsOfAppr.Text = "Aktuelles Ausbildungsjahr:";
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.BackColor = Color.Transparent;
            groupBoxCustomer.Controls.Add(TxtbCoPlace);
            groupBoxCustomer.Controls.Add(LblCoPlace);
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
            groupBoxCustomer.Location = new Point(163, 551);
            groupBoxCustomer.Margin = new Padding(4, 5, 4, 5);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Padding = new Padding(4, 5, 4, 5);
            groupBoxCustomer.Size = new Size(1070, 365);
            groupBoxCustomer.TabIndex = 69;
            groupBoxCustomer.TabStop = false;
            // 
            // TxtbCoPlace
            // 
            TxtbCoPlace.Location = new Point(186, 217);
            TxtbCoPlace.Margin = new Padding(4, 5, 4, 5);
            TxtbCoPlace.Name = "TxtbCoPlace";
            TxtbCoPlace.Size = new Size(284, 31);
            TxtbCoPlace.TabIndex = 294;
            // 
            // LblCoPlace
            // 
            LblCoPlace.AutoSize = true;
            LblCoPlace.Location = new Point(139, 217);
            LblCoPlace.Margin = new Padding(4, 0, 4, 0);
            LblCoPlace.Name = "LblCoPlace";
            LblCoPlace.Size = new Size(42, 25);
            LblCoPlace.TabIndex = 293;
            LblCoPlace.Text = "Ort:";
            // 
            // txtprplz
            // 
            txtprplz.Location = new Point(186, 168);
            txtprplz.Margin = new Padding(4, 5, 4, 5);
            txtprplz.Name = "txtprplz";
            txtprplz.Size = new Size(284, 31);
            txtprplz.TabIndex = 292;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 168);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 291;
            label2.Text = "PLZ:";
            // 
            // groupBoxEmployee
            // 
            groupBoxEmployee.BackColor = Color.Transparent;
            groupBoxEmployee.Controls.Add(ChkbExitDate);
            groupBoxEmployee.Controls.Add(LblEmpPlace);
            groupBoxEmployee.Controls.Add(txtbEmpPlace);
            groupBoxEmployee.Controls.Add(LblEmpPlz);
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
            groupBoxEmployee.Location = new Point(128, 483);
            groupBoxEmployee.Margin = new Padding(4, 5, 4, 5);
            groupBoxEmployee.Name = "groupBoxEmployee";
            groupBoxEmployee.Padding = new Padding(4, 5, 4, 5);
            groupBoxEmployee.Size = new Size(1143, 635);
            groupBoxEmployee.TabIndex = 70;
            groupBoxEmployee.TabStop = false;
            // 
            // ChkbExitDate
            // 
            ChkbExitDate.AutoSize = true;
            ChkbExitDate.Location = new Point(1084, 190);
            ChkbExitDate.Margin = new Padding(4, 5, 4, 5);
            ChkbExitDate.Name = "ChkbExitDate";
            ChkbExitDate.Size = new Size(22, 21);
            ChkbExitDate.TabIndex = 335;
            ChkbExitDate.UseVisualStyleBackColor = true;
            ChkbExitDate.CheckedChanged += ChkbExitDate_CheckedChanged;
            // 
            // LblEmpPlace
            // 
            LblEmpPlace.AutoSize = true;
            LblEmpPlace.Location = new Point(186, 240);
            LblEmpPlace.Margin = new Padding(4, 0, 4, 0);
            LblEmpPlace.Name = "LblEmpPlace";
            LblEmpPlace.Size = new Size(42, 25);
            LblEmpPlace.TabIndex = 334;
            LblEmpPlace.Text = "Ort:";
            // 
            // txtbEmpPlace
            // 
            txtbEmpPlace.Location = new Point(240, 235);
            txtbEmpPlace.Margin = new Padding(4, 5, 4, 5);
            txtbEmpPlace.Name = "txtbEmpPlace";
            txtbEmpPlace.Size = new Size(284, 31);
            txtbEmpPlace.TabIndex = 333;
            // 
            // LblEmpPlz
            // 
            LblEmpPlz.AutoSize = true;
            LblEmpPlz.Location = new Point(185, 185);
            LblEmpPlz.Margin = new Padding(4, 0, 4, 0);
            LblEmpPlz.Name = "LblEmpPlz";
            LblEmpPlz.Size = new Size(45, 25);
            LblEmpPlz.TabIndex = 332;
            LblEmpPlz.Text = "PLZ:";
            // 
            // txtbEmpPlz
            // 
            txtbEmpPlz.Location = new Point(240, 182);
            txtbEmpPlz.Margin = new Padding(4, 5, 4, 5);
            txtbEmpPlz.Name = "txtbEmpPlz";
            txtbEmpPlz.Size = new Size(284, 31);
            txtbEmpPlz.TabIndex = 331;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(849, 403);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 70;
            label1.Text = "%";
            // 
            // groupBoxTrainee
            // 
            groupBoxTrainee.Controls.Add(lblWhYearsOfAppr);
            groupBoxTrainee.Controls.Add(txtbNrOfYearsOfAppr);
            groupBoxTrainee.Controls.Add(lblNrOfYearsOfAppr);
            groupBoxTrainee.Controls.Add(txtbWhYearsOfAppr);
            groupBoxTrainee.Location = new Point(9, 512);
            groupBoxTrainee.Margin = new Padding(4, 5, 4, 5);
            groupBoxTrainee.Name = "groupBoxTrainee";
            groupBoxTrainee.Padding = new Padding(4, 5, 4, 5);
            groupBoxTrainee.Size = new Size(1077, 113);
            groupBoxTrainee.TabIndex = 69;
            groupBoxTrainee.TabStop = false;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(183, 1138);
            BtnSave.Margin = new Padding(4, 5, 4, 5);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(350, 75);
            BtnSave.TabIndex = 9000;
            BtnSave.Text = "Eintrag speichern";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(870, 1138);
            BtnDelete.Margin = new Padding(4, 5, 4, 5);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(350, 75);
            BtnDelete.TabIndex = 9001;
            BtnDelete.Text = "Eintrag löschen";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Visible = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // GUI_Create
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1378, 1344);
            Controls.Add(groupBoxEmployee);
            Controls.Add(groupBoxCustomer);
            Controls.Add(BtnDelete);
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
            Controls.Add(BtnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(2600, 2600);
            MinimumSize = new Size(1400, 1400);
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
        internal Label LblEmpPlz;
        internal TextBox txtbEmpPlz;
        internal Label LblEmpPlace;
        internal TextBox txtbEmpPlace;
        internal TextBox TxtbCoPlace;
        internal Label LblCoPlace;
        private CheckBox ChkbExitDate;
        internal Button BtnDelete;
    }
}