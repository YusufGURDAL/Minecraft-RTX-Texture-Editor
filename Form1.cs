using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace RTX_Texture_Editor_for_Minecraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Slider.Width = 30;
            this.panelCanvas.MouseWheel += PanelCanvas_MouseWheel;
        }
        int pixelX, pixelY;
        float def_value = 0.0f, Min = 0.0f, Max = 1.0f;
        bool firstTime = true;
        public float Bar(float value)
        {
            return (Slider.Height) * (value - Min) / (float)(Max - Min);
        }
        public void thumb(float value)
        {
            if (value < Min)
                value = Min;
            if (value > Max)
                value = Max;
            def_value = value;
            Slider.Refresh();
        }
        public float Slider_height(int y)
        {
            return Min + (Max - Min) * y / (float)(Slider.Height);
        }
        private void Slider_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.45f;
            float y = 450-Bar(def_value);
            int x = (int)(Slider.Width * bar_size);
            if (y > 427)
                y = 427;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DimGray, 12, 0, 6, Slider.Height);
            e.Graphics.FillRectangle(Brushes.Red, 12, y , Slider.Width-2*x, 450 );

           using (Pen pen = new Pen(Color.Black, 8))
            {
                e.Graphics.DrawEllipse(pen, x - 6, y +4, Slider.Width / 2, Slider.Width / 2);
                e.Graphics.FillEllipse(Brushes.Red, x - 6, y+4 , Slider.Width / 2, Slider.Width / 2);
            }
            using (Pen pen = new Pen(Color.White, 5))
            {
                e.Graphics.DrawEllipse(pen, x -6, y +4, Slider.Width / 2, Slider.Width / 2);
            }

        }
        bool mouse = false;
        private void Slider_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumb(Slider_height(450-e.Y));

        }
        private void Slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            thumb(Slider_height(450-e.Y));
        }
        private void Slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
        Image file;
        Boolean opened = false;
        int[,] pixel;
        string filePath="";
        void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                file = Image.FromFile(openFileDialog1.FileName);
                opened = true;
                pictureBox1.Image = file;
                pictureBox1.Height = file.Height;
                pictureBox1.Width = file.Width;
                x = pictureBox1.Width;
                y = pictureBox1.Height;
                pictureBox1.Location = new Point((panelCanvas.Width - x) / 2, (panelCanvas.Height - y) / 2);
                bm = new Bitmap(pictureBox1.Image);
                bm_size = bm.Size;
                zoom = 1;
                limit = 32;
                pixelX = x;
                pixelY = y;
                pixel = new int[pixelX, pixelY];
            }
        }
        void saveImage()
        {
            if (opened)
            {
                zoom = 1;
                pictureBox1.Size = new Size(zoom * x, zoom * y);
                pictureBox1.Location = new Point((panelCanvas.Size.Width - pictureBox1.Width) / 2, (panelCanvas.Size.Height - pictureBox1.Height) / 2);
                pictureBox1.Invalidate();
                string fileName = Path.GetFileName(filePath);
                fileName = fileName.Substring(0, fileName.Length - 4);
                using (var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                {
                    pictureBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                    bitmap.Save(@$"C:\Users\yusuf\Desktop\{fileName}_mer.png");
                }
            }
            else { MessageBox.Show("No image loaded, first upload image "); }
        }
        private void saveFile_Click(object sender, EventArgs e)
        {
            saveImage();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Dispose();
        }
        private void fileOpen_Click(object sender, EventArgs e)
        {
            openImage();
        }
        Bitmap bm;
        Size bm_size;
        int zoom, limit, x, y, factor = 1;
        int M, E, R;
        private void PanelCanvas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (bm != null)
            {
                if (firstTime)
                {
                    pictureBox1.Image = null;
                    firstTime = false;
                }
                if (e.Delta > 0 && zoom * 2 <= limit)
                {
                    zoom = zoom * 2;
                    factor++;
                }
                else if (e.Delta < 0 && zoom / 2 > 0.5f)
                {
                    zoom = zoom / 2;
                    factor--;
                }
                pictureBox1.Size = new Size(zoom * x, zoom * y);
                pictureBox1.Location = new Point((panelCanvas.Size.Width - pictureBox1.Width) / 2, (panelCanvas.Size.Height - pictureBox1.Height) / 2);
                pictureBox1.Invalidate();
            }
        }
        private void metalnessTrackBar_Scroll(object sender, EventArgs e)
        {
            M = metalnessTrackBar.Value;
            mVal.Text = M.ToString("d");
        }
        private void emissiveTrackBar_Scroll(object sender, EventArgs e)
        {
            E = emissiveTrackBar.Value;
            eVal.Text = E.ToString("d");
        }
        private void roughnessTrackBar_Scroll(object sender, EventArgs e)
        {
            R = roughnessTrackBar.Value;
            rVal.Text = R.ToString("d");
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ( opened)
            {
                Color color = Color.FromArgb(M, E, R);
                SolidBrush myBrush = new SolidBrush(color);
                myBrush.Color = Color.FromArgb(255, color);
                cursorMoving = true;
                cursorX = e.X;
                cursorY = e.Y;
                int xAxis = (int)(cursorX * zoom*(float)Math.Pow(2,5-factor) / (float)(bm.Width*Math.Pow(2,factor-1)));
                int yAxis = (int)(cursorY * zoom * (float)Math.Pow(2, 5 - factor) / (float)(bm.Height * Math.Pow(2, factor - 1)));
                Point touch = new Point(xAxis*zoom, yAxis*zoom);
                graphics.FillRectangle(myBrush, touch.X, touch.Y, file.Width * zoom / bm.Width, file.Height * zoom / bm.Height);
                if (xAxis <= (pictureBox1.Width/zoom)-1 && yAxis <= (pictureBox1.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0)
                {
                    pixel[xAxis, yAxis] = 1;
                }
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving && opened) 
            {
                Color color = Color.FromArgb(M, E, R);
                SolidBrush myBrush = new SolidBrush(color);
                myBrush.Color = Color.FromArgb(255, color);
                cursorX = e.X;
                cursorY = e.Y;
                int xAxis = (int)(cursorX * zoom * (float)Math.Pow(2, 5 - factor) / (float)(bm.Width * Math.Pow(2, factor - 1)));
                int yAxis = (int)(cursorY * zoom * (float)Math.Pow(2, 5 - factor) / (float)(bm.Height * Math.Pow(2, factor - 1)));
                Point touch = new Point(xAxis * zoom, yAxis * zoom);
                graphics.FillRectangle(myBrush, touch.X, touch.Y, file.Width * zoom / bm.Width, file.Height * zoom / bm.Height);
                if (xAxis <= (pictureBox1.Width / zoom) - 1 && yAxis <= (pictureBox1.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) 
                {
                    pixel[xAxis, yAxis] = 1;
                }
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (file != null)
            {
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
                e.Graphics.DrawImage(bm, 0, 0, pictureBox1.Width, pictureBox1.Height);
                for (int i = 0; i < pixel.GetLength(0); i++)
                {
                    for (int j = 0; j < pixel.GetLength(1); j++)
                    {
                        if (pixel[i, j] == 1)
                        {
                            int xAxis = i;
                            int yAxis = j;
                            Point touch = new Point(xAxis * zoom, yAxis * zoom);
                            Color color = Color.FromArgb(M, E, R);
                            SolidBrush myBrush = new SolidBrush(color);
                            myBrush.Color = Color.FromArgb(255, color);
                            e.Graphics.FillRectangle(myBrush, touch.X, touch.Y, file.Width * zoom / bm.Width, file.Height * zoom / bm.Height);
                        }
                    }
                }
                graphics = pictureBox1.CreateGraphics();
            }
        }
        Graphics graphics;
        Boolean cursorMoving = false;
        int cursorX = -1;
        int cursorY = -1;
    }
}