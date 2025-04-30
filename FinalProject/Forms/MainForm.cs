using FinalProject.Forms;
using FinalProject.Models;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private readonly InterpolBase interpolBase = new();
        public MainForm()
        {
            InitializeComponent();
            //interpolBase.GenerateTestData(500);
            interpolBase.DeserializeData("data.json");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            var founded = interpolBase.FindCriminal(firstNameBox.Text, lastNameBox.Text);
            criminalBindingSource.DataSource = founded;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using AddCriminalForm form = new();
            var res = form.ShowDialog();
            if (res == DialogResult.Yes)
            {
                try
                {
                    interpolBase.AddCriminal(form.criminal);
                    MessageBox.Show("Criminal added");
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using AddCriminalForm form = new();
            var res = form.ShowDialog();
            if (res == DialogResult.Yes)
            {
                try
                {
                    interpolBase.AddCriminal(form.criminal);
                    MessageBox.Show("Criminal added");
                }
                catch (Exception ex)
                {

                }

            }

        }

        private void addCriminalContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isItemSelected = listBox.SelectedItem != null;

            removeToolStripMenuItem.Visible = isItemSelected;
            editToolStripMenuItem1.Visible = isItemSelected;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is Criminal selectedCriminal)
            {
                var res = MessageBox.Show($"Delete {selectedCriminal.ShortInfo}", "Cancel", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    interpolBase.RemoveCriminal(selectedCriminal);
                    //findButton_Click(sender, e);
                    criminalBindingSource.DataSource = interpolBase.Criminals;
                    
                }
            }
            else
                MessageBox.Show("Firstly chose criminal");
        }
    }
}
