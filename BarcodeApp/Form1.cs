using BarcodeLib;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace BarcodeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeGenerator barcodeGenerator = new BarcodeGenerator();
            Bitmap barcode = barcodeGenerator.GenerateBarcode("123456789", BarcodeFormat.CODE_128, 300, 100);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
