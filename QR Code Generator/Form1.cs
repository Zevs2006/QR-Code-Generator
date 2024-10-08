using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QRCoder;

namespace QR_Code_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // �������� ����� ��� URL �� ���������� ����
            string inputText = txtInput.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("����������, ������� ����� ��� URL.");
                return;
            }

            // ��������� QR-����
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    // �������� ����������� QR-����
                    pictureBoxQRCode.Image = qrCode.GetGraphic(20); // 20 - ��� ������ � ��������
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // �������� �� ������� ���������������� �����������
            if (pictureBoxQRCode.Image == null)
            {
                MessageBox.Show("������� ������������ QR-���.");
                return;
            }

            // �������� ����������� ���� ��� ���������� �����������
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "��������� QR-��� ��� �����������";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // ���������� �����������
                    pictureBoxQRCode.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("QR-��� ������� ��������!");
                }
            }
        }
    }
}
