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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funphotos_Protection_Suite
{
    public partial class Main : Form
    {
        public Main()
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
            btnSaveKey.Enabled = true;
            btnSaveKey.Focus();
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
                MessageBox.Show("Introduzca una clave de 25 caracteres para continuar");
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            HardwareID.CollectData();
            Thread.Sleep(2000);
            foreach (var cpu in HardwareID.cpus)
            {
                comboBoxCpu.Items.Add(cpu);
            }
            foreach (var hdd in HardwareID.hdds)
            {
                comboBoxHdd.Items.Add(hdd);
            }
            foreach (var bios in HardwareID.bioses)
            {
                comboBoxBios.Items.Add(bios);
            }
            comboBoxCpu.SelectedIndex = comboBoxCpu.Items.Count - 1;
            comboBoxHdd.SelectedIndex = comboBoxHdd.Items.Count - 1;
            comboBoxBios.SelectedIndex = comboBoxBios.Items.Count - 1;
        }

        private void comboBoxBios_SelectedValueChanged(object sender, EventArgs e)
        {
            labelMotherBoard.Text = comboBoxBios.SelectedItem.ToString();
        }

        private void comboBoxCpu_SelectedValueChanged(object sender, EventArgs e)
        {
            labelCPU.Text = comboBoxCpu.SelectedItem.ToString();
        }

        private void comboBoxHdd_SelectedValueChanged(object sender, EventArgs e)
        {
            labelHDD.Text = comboBoxHdd.SelectedItem.ToString();
        }
    }
}
