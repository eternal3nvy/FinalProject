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
    }
}
