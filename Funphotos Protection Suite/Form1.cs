using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funphotos_Protection_Suite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnSaveKey.Enabled = false;            
            textBoxClavePrivada.MaxLength = 25;
            textBoxClavePrivada.TextAlign = HorizontalAlignment.Center;
            textBoxClavePrivada.Text = "Escriba aqui su clave privada (25 Caracteres)";
            textBoxKey.MaxLength = 25;
            textBoxKey.TextAlign = HorizontalAlignment.Center;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnKeyGenerate_Click(object sender, EventArgs e)
        {
            textBoxKey.Text = "Trabajando. Espera porfavor";
            string hwid = HardwareID.GET_HARDWAREID;
            textBoxKey.Text = hwid;            
            labelCPU.Text = HardwareID.GET_CPUID;
            labelHDD.Text = HardwareID.GET_HDDSIGNATURE;
            labelMotherBoard.Text = HardwareID.GET_BIOSVERSION;

            btnSaveKey.Enabled = true;
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            if (textBoxClavePrivada.Text != "Escriba aqui su clave privada (25 Caracteres)")
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    btnSaveKey.Text = folderDlg.SelectedPath;
                    string fullPath = Path.Combine(folderDlg.SelectedPath, "key.txt");
                    File.WriteAllText(fullPath, string.Empty);

                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(folderDlg.SelectedPath, "key.txt"), true))
                    {
                        outputFile.WriteLine(HardwareID.GET_HARDWAREID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Introduzca una clave de 10 caracteres para continuar");
            }
        }        
    }
}
