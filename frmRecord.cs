using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class frmRecord : Form
    {
        public frmRecord(List<string> history)
        {
            InitializeComponent();
            listRecord.Items.Clear();
            foreach (var record in history)
            {
                listRecord.Items.Add(record);
            }
        }
    }
}
