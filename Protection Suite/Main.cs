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
// Add the following namespace   
using System.Text.RegularExpressions;

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
            textBoxClavePrivada.Text = "Escriba aqui su clave privada (entre 15-25 Numeros)";
            textBoxKey.MaxLength = 25;
            textBoxKey.TextAlign = HorizontalAlignment.Center;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnGetData.PerformClick();               
        }
        private void btnKeyGenerate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string keyPattern = @"^[0-9]\d{14,24}$";
            bool isKeyValid = Regex.IsMatch(textBoxClavePrivada.Text, keyPattern);
            if (!isKeyValid)
            {
                MessageBox.Show("Please enter a valid key between 15-25 Numbers");
            }
            else
            {
                HardwareID.PRIVATE_KEY = textBoxClavePrivada.Text;
                textBoxKey.Text = HardwareID.ReturnKey();
                btnSaveKey.Enabled = true;
                btnSaveKey.Focus();
            }
            this.Cursor = Cursors.Default;
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            if (textBoxClavePrivada.Text != "Escriba aqui su clave privada (15-25 numeros)")
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
                        outputFile.WriteLine(HardwareID.ReturnKey());
                    }
                }
            }
            else
            {
                MessageBox.Show("Introduzca una clave entre 15-25 numeros para continuar");
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            comboBoxBios.Items.Clear();
            comboBoxCpu.Items.Clear();
            comboBoxHdd.Items.Clear();
            HardwareID.CollectData();
            //Thread.Sleep(2000);
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
            this.Cursor = Cursors.Default;
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

        private void textBoxClavePrivada_Enter(object sender, EventArgs e)
        {
            textBoxClavePrivada.Text = "";
        }
    }
}
