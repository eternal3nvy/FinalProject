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
    public partial class Archive : Form
    {
        public InterpolBase interpolBase;
        public Archive(InterpolBase interpolBase)
        {
            InitializeComponent();
            this.interpolBase = interpolBase;
            archivedCriminalBindingSource.DataSource = interpolBase.Archive;
        }

        private void advancedSearchButton_Click(object sender, EventArgs e)
        {
            using FormAdvancedSearch form = new FormAdvancedSearch();
            var res = form.ShowDialog();
            if (res == DialogResult.Yes)
            {
                Criminal? criminal = form.container;
                if (criminal != null)
                {
                    var foundCriminals = interpolBase.AdvancedSearch(criminal, interpolBase.Archive);
                    archivedCriminalBindingSource.DataSource = foundCriminals.Cast<ArchivedCriminal>().ToList();

                }
            }
        }
        public void RefreshData()
        {
            archivedCriminalBindingSource.DataSource = null;
            archivedCriminalBindingSource.DataSource = interpolBase.Archive;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var selectedCriminal = dataGridView1.CurrentCell.Value as Criminal;
            if (selectedCriminal != null)
            {
                using Edit form = new(selectedCriminal, interpolBase, false);
                form.ShowDialog();
            }
        }
    }
}
