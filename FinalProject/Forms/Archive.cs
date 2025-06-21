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
            InitializeComponent(); //todo: serialize archive
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
                    archivedCriminalBindingSource.DataSource = foundCriminals;
                }
            }
        }
    }
}
