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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            FrmFileName.SetFileName = studotxtbox.Text;
            string[] StudentInformation = {studotxtbox.Text, $"{lnametxtbox.Text},{fnametxtbox.Text},{mnametxtbox.Text}",
                programcbox.Text, gendercbox.Text,agetxtbox.Text,dateTimePicker.Text,contactnotxtbox.Text };

            string docpat = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docpat, FrmFileName.SetFileName))) 
            {
                foreach (string info in StudentInformation)
                {
                    outputFile.WriteLine(info);
                }
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
