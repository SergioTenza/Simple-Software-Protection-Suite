namespace SImpleSoftwareProtection.Winforms
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelMotherBoard = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelHDD = new System.Windows.Forms.Label();
            this.labelClaveSecreta = new System.Windows.Forms.Label();
            this.textBoxClavePrivada = new System.Windows.Forms.TextBox();
            this.btnKeyGenerate = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBios = new System.Windows.Forms.ComboBox();
            this.comboBoxCpu = new System.Windows.Forms.ComboBox();
            this.comboBoxHdd = new System.Windows.Forms.ComboBox();
            this.btnGetData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SImpleSoftwareProtection.Winforms.Properties.Resources.motherboard;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SImpleSoftwareProtection.Winforms.Properties.Resources.cpu;
            this.pictureBox2.Location = new System.Drawing.Point(14, 95);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SImpleSoftwareProtection.Winforms.Properties.Resources.harddisk;
            this.pictureBox3.Location = new System.Drawing.Point(14, 175);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // labelMotherBoard
            // 
            this.labelMotherBoard.AutoSize = true;
            this.labelMotherBoard.Location = new System.Drawing.Point(271, 14);
            this.labelMotherBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMotherBoard.Name = "labelMotherBoard";
            this.labelMotherBoard.Size = new System.Drawing.Size(103, 15);
            this.labelMotherBoard.TabIndex = 3;
            this.labelMotherBoard.Text = "Select your option";
            this.labelMotherBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(271, 95);
            this.labelCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(103, 15);
            this.labelCPU.TabIndex = 4;
            this.labelCPU.Text = "Select your option";
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHDD
            // 
            this.labelHDD.AutoSize = true;
            this.labelHDD.Location = new System.Drawing.Point(271, 175);
            this.labelHDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHDD.Name = "labelHDD";
            this.labelHDD.Size = new System.Drawing.Size(103, 15);
            this.labelHDD.TabIndex = 6;
            this.labelHDD.Text = "Select your option";
            this.labelHDD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClaveSecreta
            // 
            this.labelClaveSecreta.AutoSize = true;
            this.labelClaveSecreta.Location = new System.Drawing.Point(215, 234);
            this.labelClaveSecreta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClaveSecreta.Name = "labelClaveSecreta";
            this.labelClaveSecreta.Size = new System.Drawing.Size(61, 15);
            this.labelClaveSecreta.TabIndex = 5;
            this.labelClaveSecreta.Text = "Secret Key";
            // 
            // textBoxClavePrivada
            // 
            this.textBoxClavePrivada.Location = new System.Drawing.Point(124, 253);
            this.textBoxClavePrivada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxClavePrivada.Name = "textBoxClavePrivada";
            this.textBoxClavePrivada.Size = new System.Drawing.Size(274, 23);
            this.textBoxClavePrivada.TabIndex = 7;
            this.textBoxClavePrivada.Text = "Write here your private secret key (15-25 Chars)";
            this.textBoxClavePrivada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxClavePrivada.Enter += new System.EventHandler(this.textBoxClavePrivada_Enter);
            // 
            // btnKeyGenerate
            // 
            this.btnKeyGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeyGenerate.Location = new System.Drawing.Point(121, 322);
            this.btnKeyGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKeyGenerate.Name = "btnKeyGenerate";
            this.btnKeyGenerate.Size = new System.Drawing.Size(275, 32);
            this.btnKeyGenerate.TabIndex = 8;
            this.btnKeyGenerate.Text = "Generate Key";
            this.btnKeyGenerate.UseVisualStyleBackColor = true;
            this.btnKeyGenerate.Click += new System.EventHandler(this.btnKeyGenerate_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(122, 361);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(275, 23);
            this.textBoxKey.TabIndex = 9;
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveKey.Location = new System.Drawing.Point(122, 391);
            this.btnSaveKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(275, 32);
            this.btnSaveKey.TabIndex = 10;
            this.btnSaveKey.Text = "Store Key ";
            this.btnSaveKey.UseVisualStyleBackColor = true;
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Motherboard Bios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPU ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "HDD Serial";
            // 
            // comboBoxBios
            // 
            this.comboBoxBios.FormattingEnabled = true;
            this.comboBoxBios.Location = new System.Drawing.Point(124, 43);
            this.comboBoxBios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxBios.Name = "comboBoxBios";
            this.comboBoxBios.Size = new System.Drawing.Size(274, 23);
            this.comboBoxBios.TabIndex = 14;
            this.comboBoxBios.SelectedValueChanged += new System.EventHandler(this.comboBoxBios_SelectedValueChanged);
            // 
            // comboBoxCpu
            // 
            this.comboBoxCpu.FormattingEnabled = true;
            this.comboBoxCpu.Location = new System.Drawing.Point(124, 120);
            this.comboBoxCpu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCpu.Name = "comboBoxCpu";
            this.comboBoxCpu.Size = new System.Drawing.Size(274, 23);
            this.comboBoxCpu.TabIndex = 15;
            this.comboBoxCpu.SelectedValueChanged += new System.EventHandler(this.comboBoxCpu_SelectedValueChanged);
            // 
            // comboBoxHdd
            // 
            this.comboBoxHdd.FormattingEnabled = true;
            this.comboBoxHdd.Location = new System.Drawing.Point(124, 201);
            this.comboBoxHdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxHdd.Name = "comboBoxHdd";
            this.comboBoxHdd.Size = new System.Drawing.Size(274, 23);
            this.comboBoxHdd.TabIndex = 16;
            this.comboBoxHdd.SelectedValueChanged += new System.EventHandler(this.comboBoxHdd_SelectedValueChanged);
            // 
            // btnGetData
            // 
            this.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetData.Location = new System.Drawing.Point(122, 283);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(275, 32);
            this.btnGetData.TabIndex = 17;
            this.btnGetData.Text = "Reload Computer Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 465);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.comboBoxHdd);
            this.Controls.Add(this.comboBoxCpu);
            this.Controls.Add(this.comboBoxBios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.btnKeyGenerate);
            this.Controls.Add(this.textBoxClavePrivada);
            this.Controls.Add(this.labelHDD);
            this.Controls.Add(this.labelClaveSecreta);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.labelMotherBoard);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protection Suite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelMotherBoard;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelHDD;
        private System.Windows.Forms.Label labelClaveSecreta;
        private System.Windows.Forms.TextBox textBoxClavePrivada;
        private System.Windows.Forms.Button btnKeyGenerate;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button btnSaveKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBios;
        private System.Windows.Forms.ComboBox comboBoxCpu;
        private System.Windows.Forms.ComboBox comboBoxHdd;
        private System.Windows.Forms.Button btnGetData;
    }
}

