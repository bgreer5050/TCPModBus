namespace NModBus.Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.btnWriteCoil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnReadDigitalInputs = new System.Windows.Forms.Button();
            this.dgvDigitalInputs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDigitalInputs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(86, 96);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(35, 13);
            this.lblResult1.TabIndex = 1;
            this.lblResult1.Text = "label1";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(86, 109);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(35, 13);
            this.lblResult2.TabIndex = 2;
            this.lblResult2.Text = "label1";
            // 
            // btnWriteCoil
            // 
            this.btnWriteCoil.Location = new System.Drawing.Point(199, 60);
            this.btnWriteCoil.Name = "btnWriteCoil";
            this.btnWriteCoil.Size = new System.Drawing.Size(75, 23);
            this.btnWriteCoil.TabIndex = 4;
            this.btnWriteCoil.Text = "Write Coil";
            this.btnWriteCoil.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Read Holding Registers";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Read Input Registers";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnReadDigitalInputs
            // 
            this.btnReadDigitalInputs.Location = new System.Drawing.Point(39, 60);
            this.btnReadDigitalInputs.Name = "btnReadDigitalInputs";
            this.btnReadDigitalInputs.Size = new System.Drawing.Size(136, 23);
            this.btnReadDigitalInputs.TabIndex = 0;
            this.btnReadDigitalInputs.Text = "Read Digital Inputs";
            this.btnReadDigitalInputs.UseVisualStyleBackColor = true;
            this.btnReadDigitalInputs.Click += new System.EventHandler(this.btnReadDigitalInputs_Click);
            // 
            // dgvDigitalInputs
            // 
            this.dgvDigitalInputs.AllowUserToAddRows = false;
            this.dgvDigitalInputs.AllowUserToDeleteRows = false;
            this.dgvDigitalInputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDigitalInputs.Location = new System.Drawing.Point(39, 96);
            this.dgvDigitalInputs.Name = "dgvDigitalInputs";
            this.dgvDigitalInputs.ReadOnly = true;
            this.dgvDigitalInputs.Size = new System.Drawing.Size(136, 100);
            this.dgvDigitalInputs.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 261);
            this.Controls.Add(this.btnReadDigitalInputs);
            this.Controls.Add(this.dgvDigitalInputs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWriteCoil);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Greer Automation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDigitalInputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Button btnWriteCoil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnReadDigitalInputs;
        private System.Windows.Forms.DataGridView dgvDigitalInputs;
    }
}

