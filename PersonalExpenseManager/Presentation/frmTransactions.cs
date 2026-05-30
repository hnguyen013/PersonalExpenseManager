using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalExpenseManager.DAL;


namespace PersonalExpenseManager.Presentation
{
    public partial class frmTransactions : frmMainLayout
    {
        public frmTransactions()
        {
            InitializeComponent();

            btnTransactions.FillColor = Color.FromArgb(239, 196, 85);
            btnTransactions.ForeColor = Color.FromArgb(47, 93, 80);
        }

    }
}
