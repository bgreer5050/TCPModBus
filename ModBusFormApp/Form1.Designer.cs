namespace ModBusFormApp
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
            this.btnSendHoldingRegister = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServerValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendHoldingRegister
            // 
            this.btnSendHoldingRegister.Location = new System.Drawing.Point(70, 50);
            this.btnSendHoldingRegister.Name = "btnSendHoldingRegister";
            this.btnSendHoldingRegister.Size = new System.Drawing.Size(144, 23);
            this.btnSendHoldingRegister.TabIndex = 0;
            this.btnSendHoldingRegister.Text = "Send Holding Reg";
            this.btnSendHoldingRegister.UseVisualStyleBackColor = true;
            this.btnSendHoldingRegister.Click += new System.EventHandler(this.btnSendHoldingRegister_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Value";
            // 
            // lblServerValue
            // 
            this.lblServerValue.AutoSize = true;
            this.lblServerValue.Location = new System.Drawing.Point(117, 157);
            this.lblServerValue.Name = "lblServerValue";
            this.lblServerValue.Size = new System.Drawing.Size(0, 13);
            this.lblServerValue.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblServerValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSendHoldingRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendHoldingRegister;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServerValue;
    }
}

