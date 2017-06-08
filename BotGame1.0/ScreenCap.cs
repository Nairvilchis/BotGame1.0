using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace BotGame1._0
{
    public partial class ScreenCap : Form
    {

        Point posicionVentana;
        bool mover = false;
         Bitmap CapturaBitmap;
     
        public ScreenCap()
        {
            InitializeComponent();
            this.Opacity = 0.9;
            this.TransparencyKey = Color.Turquoise;
            this.ControlBox = false;
            this.Text = "";
        }

       

        private void ScreenCap_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.S)) { this.Visible = false;
                if ((e.KeyCode == Keys.D)) { this.Visible = true; }

            }

        }

        public Bitmap CaputurarPantalla()
        {
            try
            {
           
                CapturaBitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
                Rectangle capturaRectangulo = Screen.AllScreens[0].Bounds;
                Graphics CapturaGrafico = Graphics.FromImage(CapturaBitmap);
                CapturaGrafico.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, capturaRectangulo.Size);
                
            }
               
                
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            return CapturaBitmap;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            posicionVentana = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mover = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Location = new Point(Cursor.Position.X - posicionVentana.X, Cursor.Position.Y - posicionVentana.Y);
            }
        }
    }
}
