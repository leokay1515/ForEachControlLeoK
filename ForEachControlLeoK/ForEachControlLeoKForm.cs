using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachControlLeoK
{
    public partial class frmForEachControlLeoK : Form
    {
        public frmForEachControlLeoK()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //change the bkg color of all objects to gold
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Gold;

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Silver;
                }
            }          
        }
    }
}
