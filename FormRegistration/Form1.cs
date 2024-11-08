using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string getInput = txtInput.Text;
            FrmFileName fileName = new FrmFileName();
            fileName.ShowDialog();

            string docpat = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputfile = new StreamWriter(Path.Combine(docpat, FrmFileName.SetFileName)))
                outputfile.WriteLine(getInput);
            Console.WriteLine(getInput);
        }
    }
}
