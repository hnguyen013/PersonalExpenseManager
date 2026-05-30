using PersonalExpenseManager.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseManager
{
    public partial class frmSavings : frmMainLayout
    {
        public frmSavings()
        {
            InitializeComponent();
            btnSavings.FillColor = Color.FromArgb(239, 196, 85);
            btnSavings.ForeColor = Color.FromArgb(47, 93, 80);
        }
    }
}
