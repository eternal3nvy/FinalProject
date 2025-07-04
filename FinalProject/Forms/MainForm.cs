using FinalProject.Forms;
using FinalProject.Models;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private readonly InterpolBase interpolBase = new();
        public bool IsDataChanged { get; set; } = false;
        public MainForm()
        {
            InitializeComponent();
            //interpolBase.GenerateTestData(500);
            interpolBase.DeserializeData("data.json");
            criminalBindingSource.DataSource = interpolBase.Criminals;
            notFoundLabel.Visible = interpolBase.Criminals.Count == 0 ? true : false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsDataChanged)
            {
                return;
            }
            var dialogRes = MessageBox.Show("Save changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (dialogRes)
            {
                case DialogResult.Yes:
                    interpolBase.SerializeData("data.json");
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var found = interpolBase.FindCriminal(firstNameBox.Text, lastNameBox.Text);
            criminalBindingSource.DataSource = found;
            if (found.Count == 0)
                notFoundLabel.Visible = true;
            else notFoundLabel.Visible = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using AddCriminalForm form = new();
            var res = form.ShowDialog();
            if (res == DialogResult.Yes)
            {
                interpolBase.AddCriminal(form.criminal);
                IsDataChanged = true;
                MessageBox.Show($"Criminal {form.criminal.FirstName} {form.criminal.LastName} added");

            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void addCriminalContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isItemSelected = listBox.SelectedItem != null;

            removeToolStripMenuItem.Visible = isItemSelected;
            editToolStripMenuItem1.Visible = isItemSelected;
            moveToArchiveToolStripMenuItem.Visible = isItemSelected;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is Criminal selectedCriminal)
            {
                var res = MessageBox.Show($"Delete {selectedCriminal.ShortInfo}", "Cancel", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    interpolBase.RemoveCriminal(selectedCriminal);
                    IsDataChanged = true;
                    //findButton_Click(sender, e); 
                    criminalBindingSource.DataSource = null; // it fixes the problem with listBox
                    criminalBindingSource.DataSource = interpolBase.Criminals;
                }
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var chosedCriminal = listBox.SelectedItem as Criminal;
            if (chosedCriminal == null)
            {
                MessageBox.Show("Firstly chose criminal");
                return;
            }
            using Edit form = new(chosedCriminal, interpolBase);
            var res = form.ShowDialog();
            switch (res)
            {
                case DialogResult.Yes:
                    criminalBindingSource.ResetBindings(false);
                    IsDataChanged = true;
                    MessageBox.Show("Criminal updated");
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void advancedSearchButton_Click(object sender, EventArgs e)
        {
            using FormAdvancedSearch form = new();
            var res = form.ShowDialog();
            if (res == DialogResult.Yes)
            {
                if (form.container != null)
                {
                    var foundCriminals = interpolBase.AdvancedSearch(form.container, interpolBase.Criminals);
                    criminalBindingSource.DataSource = foundCriminals;
                    if (foundCriminals.Count == 0)
                        notFoundLabel.Visible = true;
                    else notFoundLabel.Visible = false;
                }
                else
                {
                    MessageBox.Show("No search criteria provided.");
                }
            }
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new(interpolBase);
            groupForm.Show();
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var archiveForm = new Archive(interpolBase);
            archiveForm.Show();
        }

        
        private void moveToArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedCriminal = listBox.SelectedItem as Criminal;

            if (selectedCriminal == null)
            {
                MessageBox.Show("Please select a criminal to move to archive.");
                return;
            }
            using var reasonform = new ReasonInputForm();
            reasonform.ShowDialog();
            if (reasonform.DialogResult == DialogResult.OK)
            {
                var reason = reasonform.Reason;
                interpolBase.moveToArchive(selectedCriminal, reason);
                IsDataChanged = true;
                criminalBindingSource.DataSource = null; // reset the binding source to refresh the list
                criminalBindingSource.DataSource = interpolBase.Criminals;

                //if archive is opened reset datagridview
                if (Application.OpenForms.OfType<Archive>().FirstOrDefault() is Archive archiveForm)
                {
                    archiveForm.RefreshData();
                }
            }
        }
    }
}
