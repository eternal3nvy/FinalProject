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
    public partial class FormAdvancedSearch : Form
    {
        public Criminal? container;
        public FormAdvancedSearch()
        {
            InitializeComponent();
        }



        private void FormAdvancedSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Yes)
            {
                string firstName = string.IsNullOrWhiteSpace(firstNameTextBox.Text) ? "" : firstNameTextBox.Text.Trim();
                string lastName = string.IsNullOrWhiteSpace(lastNameTextBox.Text) ? "" : lastNameTextBox.Text.Trim();
                string nickname = string.IsNullOrWhiteSpace(nicknameTextBox.Text) ? "" : nicknameTextBox.Text.Trim();
                decimal height;
                if (!decimal.TryParse(heightTextBox.Text, out height))
                    height = 0m;
                string hairColor = string.IsNullOrWhiteSpace(hairColorTextBox.Text) ? "" : hairColorTextBox.Text.Trim();
                string eyeColor = string.IsNullOrWhiteSpace(eyeColorTextBox.Text) ? "" : eyeColorTextBox.Text.Trim();
                string distinguishingMarks = string.IsNullOrWhiteSpace(distinguishingMarksTextBox.Text) ? "" : distinguishingMarksTextBox.Text.Trim();
                string citizenship = string.IsNullOrWhiteSpace(citizenshipTextBox.Text) ? "" : citizenshipTextBox.Text.Trim();
                DateTime birth = birthDate.Value;
                string address = string.IsNullOrWhiteSpace(addressTextBox.Text) ? "" : addressTextBox.Text.Trim();
                List<string> languages = string.IsNullOrWhiteSpace(languagesTextBox.Text)
                    ? new List<string>()
                    : languagesTextBox.Text.Split([',', ' '], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList();
                string criminalProfession = string.IsNullOrWhiteSpace(criminalProfessionTextBox.Text) ? "" : criminalProfessionTextBox.Text.Trim();
                string lastCrime = string.IsNullOrWhiteSpace(lastCrimeTextBox.Text) ? "" : lastCrimeTextBox.Text.Trim();
                string groupName = string.IsNullOrWhiteSpace(groupNameTextBox.Text) ? "" : groupNameTextBox.Text.Trim().ToLower();

                container = new Criminal(
                    Int32.MaxValue, // dummy
                    firstName,
                    lastName,
                    nickname,
                    height,
                    hairColor,
                    eyeColor,
                    distinguishingMarks,
                    citizenship,
                    birth,
                    address,
                    languages,
                    criminalProfession,
                    lastCrime,
                    groupName
                );
            }
        }
    }
}
