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
    public partial class GroupForm : Form
    {
        private InterpolBase _interpolBase;
        public GroupForm(InterpolBase interpolBase)
        {
            _interpolBase = interpolBase;
            InitializeComponent();
            this.Text = "Groups";
            groupBindingSource.DataSource = interpolBase.GroupDB.GetGroups();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem is string group && !string.IsNullOrEmpty(group))
            {
                using GroupInfo form = new GroupInfo(_interpolBase.GroupDB.GetGroupMembers(group), group);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a group to view its information.");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string groupName = groupNametextBox.Text.Trim();
            if (string.IsNullOrEmpty(groupName))
            {
                groupBindingSource.DataSource = _interpolBase.GroupDB.GetGroups();
            }
            var foundGroups = _interpolBase.GroupDB.GetGroups()
                .Where(g => g.Contains(groupName, StringComparison.OrdinalIgnoreCase))
                .ToList();
            if (foundGroups.Count > 0)
            {
                groupBindingSource.DataSource = foundGroups;
            }
            else
            {
                MessageBox.Show($"No groups found with the name '{groupName}'.");
                groupBindingSource.DataSource = _interpolBase.GroupDB.GetGroups(); 
            }
        }
    }
}
