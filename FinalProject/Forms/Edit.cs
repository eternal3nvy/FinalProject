using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class Edit : Form
    {
        public Criminal Criminal { get; private set; }
        public InterpolBase interpolBase { get; private set; }
        public Edit(Criminal c, InterpolBase _interpolBase)
        {
            InitializeComponent();
            Text = $"{c.FirstName} {c.LastName}";
            Criminal = c;
            LoadCriminalData();
            interpolBase = _interpolBase;
        }

        private bool ChangedMade(Criminal _criminal)
        {
            if (firstNameTextBox.Text != _criminal.FirstName ||
                lastNameTextBox.Text != _criminal.LastName ||
                nicknameTextBox.Text != _criminal.Nickname ||
                heightTextBox.Text != _criminal.Height.ToString() ||
                hairColorTextBox.Text != _criminal.HairColor ||
                eyeColorTextBox.Text != _criminal.EyeColor ||
                distinguishingMarksTextBox.Text != _criminal.DistinguishingMarks ||
                citizenshipTextBox.Text != _criminal.Citizenship ||
                addressTextBox.Text != _criminal.Address ||
                criminalProfessionTextBox.Text != _criminal.CriminalProfession ||
                lastCrimeTextBox.Text != _criminal.LastCrime ||
                birthDate.Value != _criminal.BirthDate ||
                languagesTextBox.Text != string.Join(", ", _criminal.Languages) ||
                groupTextBox.Text != _criminal.GroupName)
            {
                return true;
            }
            return false;
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(nicknameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(heightTextBox.Text) ||
                    string.IsNullOrWhiteSpace(hairColorTextBox.Text) ||
                    string.IsNullOrWhiteSpace(eyeColorTextBox.Text) ||
                    string.IsNullOrWhiteSpace(distinguishingMarksTextBox.Text) ||
                    string.IsNullOrWhiteSpace(citizenshipTextBox.Text) ||
                    string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                    string.IsNullOrWhiteSpace(criminalProfessionTextBox.Text) ||
                    string.IsNullOrWhiteSpace(lastCrimeTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                DialogResult = DialogResult.None;
                return false;
            }
            else if (birthDate.Value >= DateTime.Now.AddDays(-1))
            {
                MessageBox.Show("Birth date must be in the past.");
                DialogResult = DialogResult.None;
                return false;
            }
            else if (!decimal.TryParse(heightTextBox.Text, out decimal height) || height <= 0)
            {
                MessageBox.Show("Height must be a positive number.");
                DialogResult = DialogResult.None;
                return false;
            }

            return true;
        }
        private void UpdateCriminal()
        {
            string newGroupName = groupTextBox.Text.ToLower().Trim();
            string oldGroupName = Criminal.GroupName;

            Criminal.FirstName = firstNameTextBox.Text;
            Criminal.LastName = lastNameTextBox.Text;
            Criminal.Nickname = nicknameTextBox.Text;
            Criminal.Height = decimal.Parse(heightTextBox.Text);
            Criminal.HairColor = hairColorTextBox.Text;
            Criminal.EyeColor = eyeColorTextBox.Text;
            Criminal.DistinguishingMarks = distinguishingMarksTextBox.Text;
            Criminal.Citizenship = citizenshipTextBox.Text;
            Criminal.BirthDate = birthDate.Value;
            Criminal.Address = addressTextBox.Text;
            Criminal.Languages = languagesTextBox.Text
                .Split([',', ' '], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Criminal.CriminalProfession = criminalProfessionTextBox.Text;
            Criminal.LastCrime = lastCrimeTextBox.Text;
            
            if (String.IsNullOrEmpty(oldGroupName) && !String.IsNullOrEmpty(newGroupName))
            {
                interpolBase.GroupDB.AddMember(newGroupName, Criminal);
            }
            else if (!String.IsNullOrEmpty(oldGroupName) && String.IsNullOrEmpty(newGroupName))
            {
                interpolBase.GroupDB.RemoveMember(oldGroupName,Criminal); // remove from old group if exists
            }
            else if (oldGroupName != newGroupName)
            {
                interpolBase.GroupDB.ChangeGroup(Criminal, newGroupName, oldGroupName);
            }
        }

        //retrieve data of opened criminal
        private void LoadCriminalData()
        {
            if (Criminal == null)
            {
                MessageBox.Show("Criminal not found.");
                return;
            }
            firstNameTextBox.Text = Criminal.FirstName;
            lastNameTextBox.Text = Criminal.LastName;
            nicknameTextBox.Text = Criminal.Nickname;
            heightTextBox.Text = Criminal.Height.ToString();
            hairColorTextBox.Text = Criminal.HairColor;
            eyeColorTextBox.Text = Criminal.EyeColor;
            distinguishingMarksTextBox.Text = Criminal.DistinguishingMarks;
            citizenshipTextBox.Text = Criminal.Citizenship;
            birthDate.Value = Criminal.BirthDate;
            addressTextBox.Text = Criminal.Address;
            languagesTextBox.Text = string.Join(", ", Criminal.Languages);
            criminalProfessionTextBox.Text = Criminal.CriminalProfession;
            lastCrimeTextBox.Text = Criminal.LastCrime;
            groupTextBox.Text = Criminal.GroupName;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ChangedMade(Criminal))
            {
                if (ValidateInput())
                {
                    UpdateCriminal();
                    DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                MessageBox.Show("No changes made.");
                DialogResult = DialogResult.No;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
