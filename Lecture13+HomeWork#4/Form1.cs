using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lecture13_HomeWork_4
{

    public partial class Form : System.Windows.Forms.Form
    {
        private List<string> countries;
        private Dictionary<string, List<string>> cities;

        // Constructor
        public Form()
        {
            InitializeComponent();

            // Initialize countries and cities data
            countries = new List<string> { "Jordan", "Syria", "Saudi Aarbia" };
            cities = new Dictionary<string, List<string>>();
            cities.Add("Jordan", new List<string> { "Amman", "Irbid", "Karak" });
            cities.Add("Syria", new List<string> { "Damascus", "Hama", "Tartus" });
            cities.Add("Saudi Aarbia", new List<string> { "Ryadh", "Jaddah", "Damam" });

            // Populate country combo box
            cmbCountry.DataSource = countries;
        }

        // Event handler for country selection change
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = cmbCountry.SelectedItem.ToString();
            if (cities.ContainsKey(selectedCountry))
            {
                // Populate city combo box based on selected country
                cmbCity.DataSource = cities[selectedCountry];
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nationalNumber = txtNationalNumber.Text;
            string fullName = txtFullName.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string country = cmbCountry.SelectedItem.ToString();
            string city = cmbCity.SelectedItem?.ToString();
            string gender = rdoMale.Checked ? "Male" : "Female";
            string Jobtime = rdoPart.Checked ? "Part Time" : "Full Time";
            List<string> skills = new List<string>();
            foreach (var item in clbSkills2.CheckedItems)
            {
                skills.Add(item.ToString());
            }

            // Create an instance of Employee class
            Employee newEmployee = new Employee(nationalNumber, fullName, dateOfBirth, country, city, gender, skills,Jobtime);
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Now.AddYears(-age)) age--;
            if (age < 22)
            {
                MessageBox.Show("Employee Age cannot be less than 22 at the time of Registration.");
                return;
            }

            // Print summary message
            string summary = $"Employee Information:\n\n" +
                $"National Number: {newEmployee.NationalNumber}\n" +
                $"Full Name: {newEmployee.FullName}\n" +
                $"Date of Birth: {newEmployee.DateOfBirth.ToShortDateString()}\n" +
                $"Country: {newEmployee.Country}\n" +
                $"City: {newEmployee.City}\n" +
                $"Gender: {newEmployee.Gender}\n" +
                $"Job Time: {newEmployee.Jobtime}\n"+
                $"Skills: {string.Join(", ", newEmployee.Skills)}";
            lblAf0530.Visible = true;
            MessageBox.Show("Employee "+newEmployee.FullName+" has Registared");
            MessageBox.Show(summary, "Employee Registration Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

       
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void txtNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Do not show any characters on the textbox
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Do not show any characters on the textbox
            }
        }

        private void clbSkills2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
    }

    // Employee class to hold employee information
    public class Employee
    {
        public string NationalNumber { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string skills { get; set; }
        public string Jobtime { get; set; }
        public List<string> Skills { get; set; }

        public Employee(string nationalNumber, string fullName, DateTime dateOfBirth, string country, string city, string gender, List<string> skills,string jobtime)
        {
            NationalNumber = nationalNumber;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Country = country;
            City = city;
            Gender = gender;
            Skills = skills;
            Jobtime = jobtime;
        }
    }
}