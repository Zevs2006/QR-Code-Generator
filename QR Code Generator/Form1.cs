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
            // Получаем текст или URL из текстового поля
            string inputText = txtInput.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Пожалуйста, введите текст или URL.");
                return;
            }

            // Генерация QR-кода
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    // Получаем изображение QR-кода
                    pictureBoxQRCode.Image = qrCode.GetGraphic(20); // 20 - это размер в пикселях
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверка на наличие сгенерированного изображения
            if (pictureBoxQRCode.Image == null)
            {
                MessageBox.Show("Сначала сгенерируйте QR-код.");
                return;
            }

            // Открытие диалогового окна для сохранения изображения
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Сохранить QR-код как изображение";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Сохранение изображения
                    pictureBoxQRCode.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("QR-код успешно сохранен!");
                }
            }
        }
    }
}
