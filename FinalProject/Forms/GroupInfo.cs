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
    public partial class GroupInfo: Form
    {
        private  List<Criminal> _members;
        public GroupInfo(List<Criminal> members, string name)
        {
            InitializeComponent();
            this.Text = $"Info: {name}"; 
            _members = members;
            criminalBindingSource.DataSource = _members;
        }

    }
}
