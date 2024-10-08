namespace QR_Code_Generator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnGenerate = new Button();
            pictureBoxQRCode = new PictureBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(14, 14);
            txtInput.Margin = new Padding(4, 3, 4, 3);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(419, 23);
            txtInput.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(441, 12);
            btnGenerate.Margin = new Padding(4, 3, 4, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(88, 27);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Сгенерировать";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(14, 44);
            pictureBoxQRCode.Margin = new Padding(4, 3, 4, 3);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(1135, 906);
            pictureBoxQRCode.TabIndex = 2;
            pictureBoxQRCode.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(537, 14);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(514, 27);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить QR-код";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 962);
            Controls.Add(btnSave);
            Controls.Add(pictureBoxQRCode);
            Controls.Add(btnGenerate);
            Controls.Add(txtInput);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Генератор QR-кодов";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }

}
