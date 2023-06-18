
namespace Student_Mnagement_System
{
    partial class Manage_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_student));
            this.comboBoxprogramme = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtpassstud = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtstudentID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxbatch = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonregister = new System.Windows.Forms.Button();
            this.buttonclearstud = new System.Windows.Forms.Button();
            this.pictureBoxstudpic = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxdep = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.radioButtonmale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtconfpass = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonbrowsephotostud = new System.Windows.Forms.Button();
            this.buttongeneratestudpass = new System.Windows.Forms.Button();
            this.combobatchsearch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlaststudsearch = new System.Windows.Forms.TextBox();
            this.txtidsearch = new System.Windows.Forms.TextBox();
            this.txtmiddlestudsearch = new System.Windows.Forms.TextBox();
            this.txtfirststudsearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxstudpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxprogramme
            // 
            this.comboBoxprogramme.AutoCompleteCustomSource.AddRange(new string[] {
            "Computer Science"});
            this.comboBoxprogramme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxprogramme.FormattingEnabled = true;
            this.comboBoxprogramme.Items.AddRange(new object[] {
            "Undergraduate",
            "Postgraduate"});
            this.comboBoxprogramme.Location = new System.Drawing.Point(154, 581);
            this.comboBoxprogramme.Name = "comboBoxprogramme";
            this.comboBoxprogramme.Size = new System.Drawing.Size(195, 28);
            this.comboBoxprogramme.TabIndex = 103;
            this.comboBoxprogramme.SelectedIndexChanged += new System.EventHandler(this.comboBoxprogramme_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 758);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 24);
            this.label16.TabIndex = 101;
            this.label16.Text = "Confirm Password";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtpassstud
            // 
            this.txtpassstud.Location = new System.Drawing.Point(209, 690);
            this.txtpassstud.Name = "txtpassstud";
            this.txtpassstud.Size = new System.Drawing.Size(171, 26);
            this.txtpassstud.TabIndex = 100;
            this.txtpassstud.TextChanged += new System.EventHandler(this.txtpassstud_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 695);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 24);
            this.label15.TabIndex = 99;
            this.label15.Text = "Password";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtstudentID
            // 
            this.txtstudentID.Location = new System.Drawing.Point(586, 434);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(168, 26);
            this.txtstudentID.TabIndex = 98;
            this.txtstudentID.TextChanged += new System.EventHandler(this.txtstudentID_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(447, 436);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 24);
            this.label14.TabIndex = 97;
            this.label14.Text = "Student Id";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // comboBoxbatch
            // 
            this.comboBoxbatch.AutoCompleteCustomSource.AddRange(new string[] {
            "Computer Science"});
            this.comboBoxbatch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxbatch.FormattingEnabled = true;
            this.comboBoxbatch.Items.AddRange(new object[] {
            "DRB 1701",
            "DRB 1702",
            "DRB 1801",
            "DRB 1802",
            "DRB 1901",
            "DRB 1902",
            "DRB 2001",
            "DRB 2002",
            "DRB 2101",
            "DRB 2102"});
            this.comboBoxbatch.Location = new System.Drawing.Point(433, 475);
            this.comboBoxbatch.Name = "comboBoxbatch";
            this.comboBoxbatch.Size = new System.Drawing.Size(195, 28);
            this.comboBoxbatch.TabIndex = 96;
            this.comboBoxbatch.SelectedIndexChanged += new System.EventHandler(this.comboBoxbatch_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label20.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(338, 479);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 24);
            this.label20.TabIndex = 95;
            this.label20.Text = "Batch";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.Color.Green;
            this.buttonregister.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonregister.Location = new System.Drawing.Point(42, 862);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(307, 49);
            this.buttonregister.TabIndex = 94;
            this.buttonregister.Text = "Update Student Details";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // buttonclearstud
            // 
            this.buttonclearstud.BackColor = System.Drawing.Color.Red;
            this.buttonclearstud.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclearstud.Location = new System.Drawing.Point(375, 862);
            this.buttonclearstud.Name = "buttonclearstud";
            this.buttonclearstud.Size = new System.Drawing.Size(287, 49);
            this.buttonclearstud.TabIndex = 81;
            this.buttonclearstud.Text = "Delete Student";
            this.buttonclearstud.UseVisualStyleBackColor = false;
            this.buttonclearstud.Click += new System.EventHandler(this.buttonclearstud_Click);
            // 
            // pictureBoxstudpic
            // 
            this.pictureBoxstudpic.Location = new System.Drawing.Point(759, 201);
            this.pictureBoxstudpic.Name = "pictureBoxstudpic";
            this.pictureBoxstudpic.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxstudpic.TabIndex = 91;
            this.pictureBoxstudpic.TabStop = false;
            this.pictureBoxstudpic.Click += new System.EventHandler(this.pictureBoxstudpic_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 635);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 24);
            this.label12.TabIndex = 90;
            this.label12.Text = "Department";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBoxdep
            // 
            this.comboBoxdep.AutoCompleteCustomSource.AddRange(new string[] {
            "Computer Science"});
            this.comboBoxdep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxdep.FormattingEnabled = true;
            this.comboBoxdep.Items.AddRange(new object[] {
            "Computer Science",
            "Software Engineering"});
            this.comboBoxdep.Location = new System.Drawing.Point(205, 635);
            this.comboBoxdep.Name = "comboBoxdep";
            this.comboBoxdep.Size = new System.Drawing.Size(189, 28);
            this.comboBoxdep.TabIndex = 89;
            this.comboBoxdep.SelectedIndexChanged += new System.EventHandler(this.comboBoxdep_SelectedIndexChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(160, 436);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(261, 26);
            this.txtemail.TabIndex = 88;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(160, 391);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(168, 26);
            this.txtphone.TabIndex = 87;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(227, 237);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(185, 26);
            this.txtlastname.TabIndex = 86;
            this.txtlastname.TextChanged += new System.EventHandler(this.txtlastname_TextChanged);
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Location = new System.Drawing.Point(227, 196);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(185, 26);
            this.txtmiddlename.TabIndex = 85;
            this.txtmiddlename.TextChanged += new System.EventHandler(this.txtmiddlename_TextChanged);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(227, 156);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(185, 26);
            this.txtfirstname.TabIndex = 84;
            this.txtfirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 24);
            this.label11.TabIndex = 83;
            this.label11.Text = "Phone Number";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 24);
            this.label10.TabIndex = 82;
            this.label10.Text = "Email ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 581);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 80;
            this.label9.Text = "Programme";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.radioButtonfemale.Font = new System.Drawing.Font("Myanmar Text", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonfemale.Location = new System.Drawing.Point(149, 527);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(93, 33);
            this.radioButtonfemale.TabIndex = 79;
            this.radioButtonfemale.Text = "Female";
            this.radioButtonfemale.UseVisualStyleBackColor = false;
            this.radioButtonfemale.CheckedChanged += new System.EventHandler(this.radioButtonfemale_CheckedChanged);
            // 
            // radioButtonmale
            // 
            this.radioButtonmale.AutoSize = true;
            this.radioButtonmale.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.radioButtonmale.Font = new System.Drawing.Font("Myanmar Text", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonmale.Location = new System.Drawing.Point(17, 527);
            this.radioButtonmale.Name = "radioButtonmale";
            this.radioButtonmale.Size = new System.Drawing.Size(76, 33);
            this.radioButtonmale.TabIndex = 78;
            this.radioButtonmale.Text = "Male";
            this.radioButtonmale.UseVisualStyleBackColor = false;
            this.radioButtonmale.CheckedChanged += new System.EventHandler(this.radioButtonmale_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 77;
            this.label8.Text = "Gender";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 29);
            this.label7.TabIndex = 76;
            this.label7.Text = "Year";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 29);
            this.label6.TabIndex = 75;
            this.label6.Text = "Month";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 74;
            this.label5.Text = "Day";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 73;
            this.label4.Text = "Date of Birth";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 72;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "Middle Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 70;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(188, 354);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(71, 26);
            this.txtyear.TabIndex = 106;
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(88, 354);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(61, 26);
            this.txtmonth.TabIndex = 105;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(12, 354);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(49, 26);
            this.txtdate.TabIndex = 104;
            // 
            // txtconfpass
            // 
            this.txtconfpass.Location = new System.Drawing.Point(209, 756);
            this.txtconfpass.Name = "txtconfpass";
            this.txtconfpass.Size = new System.Drawing.Size(171, 26);
            this.txtconfpass.TabIndex = 107;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(725, 354);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(223, 20);
            this.label19.TabIndex = 92;
            this.label19.Text = "Upload a 3.5cm x 4.5cm photo";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // buttonbrowsephotostud
            // 
            this.buttonbrowsephotostud.Font = new System.Drawing.Font("New Century Schoolbook Short", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbrowsephotostud.Location = new System.Drawing.Point(773, 379);
            this.buttonbrowsephotostud.Name = "buttonbrowsephotostud";
            this.buttonbrowsephotostud.Size = new System.Drawing.Size(127, 50);
            this.buttonbrowsephotostud.TabIndex = 93;
            this.buttonbrowsephotostud.Text = "browse photo";
            this.buttonbrowsephotostud.UseVisualStyleBackColor = true;
            this.buttonbrowsephotostud.Click += new System.EventHandler(this.buttonbrowsephotostud_Click);
            // 
            // buttongeneratestudpass
            // 
            this.buttongeneratestudpass.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttongeneratestudpass.Location = new System.Drawing.Point(414, 711);
            this.buttongeneratestudpass.Name = "buttongeneratestudpass";
            this.buttongeneratestudpass.Size = new System.Drawing.Size(195, 42);
            this.buttongeneratestudpass.TabIndex = 108;
            this.buttongeneratestudpass.Text = "Generate Password";
            this.buttongeneratestudpass.UseVisualStyleBackColor = true;
            this.buttongeneratestudpass.Click += new System.EventHandler(this.buttongeneratestudpass_Click_1);
            // 
            // combobatchsearch
            // 
            this.combobatchsearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Computer Science"});
            this.combobatchsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combobatchsearch.FormattingEnabled = true;
            this.combobatchsearch.Items.AddRange(new object[] {
            "DRB 1701",
            "DRB 1702",
            "DRB 1801",
            "DRB 1802",
            "DRB 1901",
            "DRB 1902",
            "DRB 2001",
            "DRB 2002",
            "DRB 2101",
            "DRB 2102"});
            this.combobatchsearch.Location = new System.Drawing.Point(1207, 374);
            this.combobatchsearch.Name = "combobatchsearch";
            this.combobatchsearch.Size = new System.Drawing.Size(195, 28);
            this.combobatchsearch.TabIndex = 120;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1463, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 46);
            this.button1.TabIndex = 119;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtlaststudsearch
            // 
            this.txtlaststudsearch.Location = new System.Drawing.Point(1207, 304);
            this.txtlaststudsearch.Name = "txtlaststudsearch";
            this.txtlaststudsearch.Size = new System.Drawing.Size(185, 26);
            this.txtlaststudsearch.TabIndex = 118;
            // 
            // txtidsearch
            // 
            this.txtidsearch.Location = new System.Drawing.Point(1207, 336);
            this.txtidsearch.Name = "txtidsearch";
            this.txtidsearch.Size = new System.Drawing.Size(185, 26);
            this.txtidsearch.TabIndex = 117;
            // 
            // txtmiddlestudsearch
            // 
            this.txtmiddlestudsearch.Location = new System.Drawing.Point(1207, 261);
            this.txtmiddlestudsearch.Name = "txtmiddlestudsearch";
            this.txtmiddlestudsearch.Size = new System.Drawing.Size(185, 26);
            this.txtmiddlestudsearch.TabIndex = 116;
            // 
            // txtfirststudsearch
            // 
            this.txtfirststudsearch.Location = new System.Drawing.Point(1207, 229);
            this.txtfirststudsearch.Name = "txtfirststudsearch";
            this.txtfirststudsearch.Size = new System.Drawing.Size(185, 26);
            this.txtfirststudsearch.TabIndex = 115;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1033, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 24);
            this.label13.TabIndex = 114;
            this.label13.Text = "Batch";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1033, 336);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 24);
            this.label17.TabIndex = 113;
            this.label17.Text = "ID No";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1033, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 24);
            this.label18.TabIndex = 112;
            this.label18.Text = "Last Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label21.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1033, 261);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 24);
            this.label21.TabIndex = 111;
            this.label21.Text = "Middle Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label22.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1033, 225);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 24);
            this.label22.TabIndex = 110;
            this.label22.Text = "First Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Beige;
            this.label23.Font = new System.Drawing.Font("Perpetua Titling MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1123, 173);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(288, 27);
            this.label23.TabIndex = 109;
            this.label23.Text = "Search for Students";
            // 
            // dgvstudent
            // 
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Location = new System.Drawing.Point(1041, 459);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RowHeadersWidth = 62;
            this.dgvstudent.RowTemplate.Height = 28;
            this.dgvstudent.Size = new System.Drawing.Size(797, 479);
            this.dgvstudent.TabIndex = 121;
            this.dgvstudent.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstudent_RowHeaderMouseDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Font = new System.Drawing.Font("New Century Schoolbook Short", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(642, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 51);
            this.textBox2.TabIndex = 122;
            this.textBox2.Text = "Manage Student";
            // 
            // Manage_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1850, 968);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvstudent);
            this.Controls.Add(this.combobatchsearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtlaststudsearch);
            this.Controls.Add(this.txtidsearch);
            this.Controls.Add(this.txtmiddlestudsearch);
            this.Controls.Add(this.txtfirststudsearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.buttongeneratestudpass);
            this.Controls.Add(this.txtconfpass);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.comboBoxprogramme);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtpassstud);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtstudentID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxbatch);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonregister);
            this.Controls.Add(this.buttonclearstud);
            this.Controls.Add(this.buttonbrowsephotostud);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pictureBoxstudpic);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxdep);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButtonfemale);
            this.Controls.Add(this.radioButtonmale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Manage_student";
            this.Text = "Manage_student";
            this.Load += new System.EventHandler(this.Manage_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxstudpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxprogramme;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtpassstud;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxbatch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Button buttonclearstud;
        private System.Windows.Forms.PictureBox pictureBoxstudpic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxdep;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonfemale;
        private System.Windows.Forms.RadioButton radioButtonmale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtconfpass;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonbrowsephotostud;
        private System.Windows.Forms.Button buttongeneratestudpass;
        private System.Windows.Forms.ComboBox combobatchsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtlaststudsearch;
        private System.Windows.Forms.TextBox txtidsearch;
        private System.Windows.Forms.TextBox txtmiddlestudsearch;
        private System.Windows.Forms.TextBox txtfirststudsearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.TextBox textBox2;
    }
}