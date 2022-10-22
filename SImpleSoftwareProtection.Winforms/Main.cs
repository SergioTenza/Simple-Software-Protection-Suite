
using SimpleSoftwareProtection.Core.Interfaces;
using SimpleSoftwareProtection.Core.Windows;

namespace SImpleSoftwareProtection.Winforms
{
    public partial class Main : Form
    {
        private IWindowsKeyGenerator? _windowsKeyGenerator;
        private IWindowsHardwareInfo? _windowsHardwareInfo;

        public Main()
        {
            InitializeComponent();
            btnSaveKey.Enabled = false;
            textBoxClavePrivada.TextAlign = HorizontalAlignment.Center;
            textBoxClavePrivada.Text = "Escriba aqui su clave privada";
            textBoxKey.TextAlign = HorizontalAlignment.Center;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnGetData.PerformClick();
        }
        private void btnKeyGenerate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            _windowsKeyGenerator = new WindowsKeyGenerator(textBoxClavePrivada.Text, labelCPU.Text,labelHDD.Text,labelMotherBoard.Text);
            textBoxKey.Text = _windowsKeyGenerator.ReturnKey();
            btnSaveKey.Enabled = true;
            btnSaveKey.Focus();
            this.Cursor = Cursors.Default;
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            if (textBoxClavePrivada.Text != "Escriba aqui su clave privada")
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
                        outputFile.WriteLine(_windowsKeyGenerator?.ReturnKey());
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
            _windowsHardwareInfo = new WindowsHardwareInfo();
            _windowsHardwareInfo.CollectData();
            if (_windowsHardwareInfo.Cpus.Any())
            {
                foreach (var cpu in _windowsHardwareInfo.Cpus)
                {
                    comboBoxCpu.Items.Add(cpu);
                }
                
            }
            comboBoxCpu.SelectedIndex = comboBoxCpu.Items.Count > 0 ? comboBoxCpu.Items.Count - 1 : 0;
            if (_windowsHardwareInfo.Hdds.Any())
            {
                foreach (var hdd in _windowsHardwareInfo.Hdds)
                {
                    comboBoxHdd.Items.Add(hdd);
                }
            }
            comboBoxHdd.SelectedIndex = comboBoxCpu.Items.Count > 0 ? comboBoxCpu.Items.Count - 1 : 0;
            if (_windowsHardwareInfo.Bios.Any())
            {
                foreach (var bios in _windowsHardwareInfo.Bios)
                {
                    comboBoxBios.Items.Add(bios);
                }
            }
            comboBoxBios.SelectedIndex = comboBoxCpu.Items.Count > 0 ? comboBoxCpu.Items.Count - 1 : 0;
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
