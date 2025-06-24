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
    public partial class AddCriminalForm : Form
    {
        public Criminal? criminal;
        public AddCriminalForm()
        {
            InitializeComponent();
        }

        public bool ValidateInput()
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
            else if (birthDate.Value >= DateTime.Now.AddDays(-1) || birthDate.Value <= DateTime.Now.AddYears(-200))
            {
                MessageBox.Show("wrong date");
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

        private void AddCriminalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.Yes)
            {
                if (!ValidateInput())
                {
                    return;
                }
                criminal = new Criminal(
                0, // ID will be generated in the main form
                firstNameTextBox.Text.Trim(),
                lastNameTextBox.Text.Trim(),
                nicknameTextBox.Text.Trim(),
                decimal.Parse(heightTextBox.Text),
                hairColorTextBox.Text.Trim(),
                eyeColorTextBox.Text.Trim(),
                distinguishingMarksTextBox.Text.Trim(),
                citizenshipTextBox.Text.Trim(),
                birthDate.Value,
                addressTextBox.Text.Trim(),
                languagesTextBox.Text.Split([',', ' '], StringSplitOptions.TrimEntries |
                                                        StringSplitOptions.RemoveEmptyEntries)
                                                        .ToList(),
                criminalProfessionTextBox.Text.Trim(),
                lastCrimeTextBox.Text.Trim(),
                groupNameTextBox.Text.Trim().ToLower()
                );
            }

        }
    }
}
