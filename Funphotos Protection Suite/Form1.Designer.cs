namespace Funphotos_Protection_Suite
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Funphotos_Protection_Suite.Properties.Resources.motherboard;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Funphotos_Protection_Suite.Properties.Resources.cpu;
            this.pictureBox2.Location = new System.Drawing.Point(12, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Funphotos_Protection_Suite.Properties.Resources.harddisk;
            this.pictureBox3.Location = new System.Drawing.Point(12, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // labelMotherBoard
            // 
            this.labelMotherBoard.AutoSize = true;
            this.labelMotherBoard.Location = new System.Drawing.Point(103, 35);
            this.labelMotherBoard.Name = "labelMotherBoard";
            this.labelMotherBoard.Size = new System.Drawing.Size(70, 13);
            this.labelMotherBoard.TabIndex = 3;
            this.labelMotherBoard.Text = "Motherboard:";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(103, 107);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(32, 13);
            this.labelCPU.TabIndex = 4;
            this.labelCPU.Text = "CPU:";
            // 
            // labelHDD
            // 
            this.labelHDD.AutoSize = true;
            this.labelHDD.Location = new System.Drawing.Point(103, 177);
            this.labelHDD.Name = "labelHDD";
            this.labelHDD.Size = new System.Drawing.Size(34, 13);
            this.labelHDD.TabIndex = 6;
            this.labelHDD.Text = "HDD:";
            // 
            // labelClaveSecreta
            // 
            this.labelClaveSecreta.AutoSize = true;
            this.labelClaveSecreta.Location = new System.Drawing.Point(100, 245);
            this.labelClaveSecreta.Name = "labelClaveSecreta";
            this.labelClaveSecreta.Size = new System.Drawing.Size(73, 13);
            this.labelClaveSecreta.TabIndex = 5;
            this.labelClaveSecreta.Text = "Clave Privada";
            // 
            // textBoxClavePrivada
            // 
            this.textBoxClavePrivada.Location = new System.Drawing.Point(179, 242);
            this.textBoxClavePrivada.Name = "textBoxClavePrivada";
            this.textBoxClavePrivada.Size = new System.Drawing.Size(273, 20);
            this.textBoxClavePrivada.TabIndex = 7;
            this.textBoxClavePrivada.Text = "Escriba aqui su clave privada (10 Caracteres)";
            // 
            // btnKeyGenerate
            // 
            this.btnKeyGenerate.Location = new System.Drawing.Point(106, 278);
            this.btnKeyGenerate.Name = "btnKeyGenerate";
            this.btnKeyGenerate.Size = new System.Drawing.Size(346, 28);
            this.btnKeyGenerate.TabIndex = 8;
            this.btnKeyGenerate.Text = "Generar Clave";
            this.btnKeyGenerate.UseVisualStyleBackColor = true;
            this.btnKeyGenerate.Click += new System.EventHandler(this.btnKeyGenerate_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(106, 312);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(346, 20);
            this.textBoxKey.TabIndex = 9;
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Location = new System.Drawing.Point(106, 338);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(346, 28);
            this.btnSaveKey.TabIndex = 10;
            this.btnSaveKey.Text = "Guardar Clave en Fichero";
            this.btnSaveKey.UseVisualStyleBackColor = true;
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Motherboard Bios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPU ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "HDD Serial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 374);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FunPhotos Protection Suite";
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
    }
}

