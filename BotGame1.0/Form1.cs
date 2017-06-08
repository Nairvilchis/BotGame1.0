using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;





namespace BotGame1._0
{
    public partial class Principal : Form
    {
        public ScreenCap sc;

        string path = "c:/temo_bot";
        Bitmap CapturaBitmap;
        Bitmap cropBitmap;


        public Principal()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          sc = new ScreenCap();
            MessageBox.Show("Porfavor ajusta el panel a medida que este visible la zona del juego y presione la letra S ");
            sc.Show();
        }

        public Bitmap CropBitmap(Bitmap bitmap, int cropX, int cropY, int cropWidth, int cropHeight)
        {
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            Bitmap cropped = bitmap.Clone(rect, bitmap.PixelFormat);
            return cropped;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try {

                CapturaBitmap = sc.CaputurarPantalla();
                pbImagen.Image = CapturaBitmap;
                cropBitmap = CropBitmap(CapturaBitmap, 65, 5, 70, 70);
                pbCrop.Image = cropBitmap;
                if (Directory.Exists(path))
                {
                  
                    CapturaBitmap.Save(path + "/" + "Temp" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    cropBitmap.Save(path + "/" + "tempCrop" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                   Directory.CreateDirectory(path);


                    CapturaBitmap.Save(path + "/" + "Temp" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    cropBitmap.Save(path + "/" + "tempCrop" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }




            } catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
              
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
          
        }

        private void rtPalabra_DoubleClick(object sender, EventArgs e)
        {
            rtPalabra.Text = "";
        }
    }
}
