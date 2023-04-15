using System.Drawing;
using System.Windows.Forms;

namespace Lecture13_HomeWork_4
{
    partial class Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNationalNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.CheckBox chkProgramming;
        private System.Windows.Forms.CheckBox chkWebDesign;
        private System.Windows.Forms.CheckBox chkUIUX;
        private System.Windows.Forms.Button btnRegister;
        // ... other control declarations and layout code

        // Form Designer code
        private void InitializeComponent()
        {
            this.txtNationalNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.chkProgramming = new System.Windows.Forms.CheckBox();
            this.chkWebDesign = new System.Windows.Forms.CheckBox();
            this.chkUIUX = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblNationalNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clbSkills2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoPart = new System.Windows.Forms.RadioButton();
            this.rdoFull = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAf0530 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.Location = new System.Drawing.Point(150, 39);
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(200, 20);
            this.txtNationalNumber.TabIndex = 1;
            this.txtNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNumber_KeyPress);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(150, 79);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 20);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(150, 119);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 5;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Items.AddRange(new object[] {
            "United States",
            "Canada",
            "United Kingdom",
            "Australia"});
            this.cmbCountry.Location = new System.Drawing.Point(150, 159);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbCountry.TabIndex = 7;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.Items.AddRange(new object[] {
            "New York",
            "Los Angeles",
            "Toronto",
            "London",
            "Sydney"});
            this.cmbCity.Location = new System.Drawing.Point(150, 199);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 9;
            // 
            // rdoMale
            // 
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(150, 239);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(104, 24);
            this.rdoMale.TabIndex = 11;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            // 
            // rdoFemale
            // 
            this.rdoFemale.Location = new System.Drawing.Point(260, 239);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(104, 24);
            this.rdoFemale.TabIndex = 12;
            this.rdoFemale.Text = "Female";
            // 
            // chkProgramming
            // 
            this.chkProgramming.Location = new System.Drawing.Point(0, 0);
            this.chkProgramming.Name = "chkProgramming";
            this.chkProgramming.Size = new System.Drawing.Size(104, 24);
            this.chkProgramming.TabIndex = 0;
            // 
            // chkWebDesign
            // 
            this.chkWebDesign.Location = new System.Drawing.Point(0, 0);
            this.chkWebDesign.Name = "chkWebDesign";
            this.chkWebDesign.Size = new System.Drawing.Size(104, 24);
            this.chkWebDesign.TabIndex = 0;
            // 
            // chkUIUX
            // 
            this.chkUIUX.Location = new System.Drawing.Point(0, 0);
            this.chkUIUX.Name = "chkUIUX";
            this.chkUIUX.Size = new System.Drawing.Size(104, 24);
            this.chkUIUX.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(0, 0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            // 
            // lblNationalNumber
            // 
            this.lblNationalNumber.Location = new System.Drawing.Point(20, 39);
            this.lblNationalNumber.Name = "lblNationalNumber";
            this.lblNationalNumber.Size = new System.Drawing.Size(100, 23);
            this.lblNationalNumber.TabIndex = 0;
            this.lblNationalNumber.Text = "National Number:";
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(20, 79);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 23);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(20, 119);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(100, 23);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(20, 159);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(100, 23);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country of Residence:";
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(20, 199);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(100, 23);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City of Residence:";
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(20, 239);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 23);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender:";
            // 
            // lblSkills
            // 
            this.lblSkills.Location = new System.Drawing.Point(20, 307);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(100, 23);
            this.lblSkills.TabIndex = 13;
            this.lblSkills.Text = "Skills:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clbSkills2
            // 
            this.clbSkills2.CheckOnClick = true;
            this.clbSkills2.Items.AddRange(new object[] {
            "Programming",
            "Web Design",
            "Gaming",
            "Sleeping",
            "Other"});
            this.clbSkills2.Location = new System.Drawing.Point(150, 319);
            this.clbSkills2.Name = "clbSkills2";
            this.clbSkills2.Size = new System.Drawing.Size(194, 94);
            this.clbSkills2.TabIndex = 15;
            this.clbSkills2.SelectedIndexChanged += new System.EventHandler(this.clbSkills2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Part/Full:";
            // 
            // rdoPart
            // 
            this.rdoPart.Checked = true;
            this.rdoPart.Location = new System.Drawing.Point(6, 13);
            this.rdoPart.Name = "rdoPart";
            this.rdoPart.Size = new System.Drawing.Size(104, 24);
            this.rdoPart.TabIndex = 17;
            this.rdoPart.TabStop = true;
            this.rdoPart.Text = "Part Time";
            // 
            // rdoFull
            // 
            this.rdoFull.Location = new System.Drawing.Point(116, 13);
            this.rdoFull.Name = "rdoFull";
            this.rdoFull.Size = new System.Drawing.Size(78, 24);
            this.rdoFull.TabIndex = 18;
            this.rdoFull.Text = "Full Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPart);
            this.groupBox1.Controls.Add(this.rdoFull);
            this.groupBox1.Location = new System.Drawing.Point(144, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 43);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // lblAf0530
            // 
            this.lblAf0530.AutoSize = true;
            this.lblAf0530.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAf0530.Location = new System.Drawing.Point(120, 9);
            this.lblAf0530.Name = "lblAf0530";
            this.lblAf0530.Size = new System.Drawing.Size(230, 29);
            this.lblAf0530.TabIndex = 20;
            this.lblAf0530.Text = "Ahmed Tamari AF0530";
            this.lblAf0530.UseCompatibleTextRendering = true;
            this.lblAf0530.Visible = false;
            this.lblAf0530.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(469, 482);
            this.Controls.Add(this.lblAf0530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbSkills2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNationalNumber);
            this.Controls.Add(this.txtNationalNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.lblSkills);
            this.Name = "Form";
            this.Text = "Human Resource Empoyment";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblNationalNumber;
        private Label lblFullName;
        private Label lblDateOfBirth;
        private Label lblCountry;
        private Label lblCity;
        private Label lblGender;
        private Label lblSkills;
        private Button button1;
        private CheckedListBox clbSkills;
        private CheckedListBox clbSkills2;
        private Label label1;
        private RadioButton rdoPart;
        private RadioButton rdoFull;
        private GroupBox groupBox1;
        private Label lblAf0530;
    }
}

