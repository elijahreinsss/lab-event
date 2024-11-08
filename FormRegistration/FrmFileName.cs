using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegistration
{
    public partial class FrmFileName : Form
    {
        public FrmFileName()
        {
            InitializeComponent();
        }
        public static string SetFileName;
        private void btnokay_Click(object sender, EventArgs e)
        {
            SetFileName = textFileName.Text + ".txt";
            this.Close();
            FrmRegistration frmRegistration = new FrmRegistration();
           frmRegistration.ShowDialog();
        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {

        }
    }
}
