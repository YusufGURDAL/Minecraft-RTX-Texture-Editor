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
            this.panelCanvas.MouseWheel += PanelCanvas_MouseWheel;
        }
        int pixelX, pixelY;
        float def_valueM = 0.0f, def_valueE = 0.0f, def_valueR = 0.0f, Min = 0.0f, Max = 1.0f;
        bool firstTime = true;
        public float BarM(float value)
        {
            return (SliderM.Height-28) * (value - Min) / (float)(Max - Min);
        }
        public float BarE(float value)
        {
            return (SliderE.Height - 28) * (value - Min) / (float)(Max - Min);
        }
        public void thumbM(float value)
        {
            if (value < Min)
                value = Min;
            if (value > Max)
                value = Max;
            def_valueM = value;
            SliderM.Refresh();
        }
        public void thumbE(float value)
        {
            if (value < Min)
                value = Min;
            if (value > Max)
                value = Max;
            def_valueE = value;
            SliderE.Refresh();
        }
        public void thumbR(float value)
        {
            if (value < Min)
                value = Min;
            if (value > Max)
                value = Max;
            def_valueR = value;
            SliderR.Refresh();
        }
        public float Slider_height(int y)
        {
            return Min + (Max - Min) * y / (float)(SliderE.Height);
        }
        Image sliderButton1,sliderButton2, sliderButton3;
        float slidery;
        bool mouse = false;
        private void Slider_PaintM(object sender, PaintEventArgs e)
        {
            sliderButton1 = sliderButtonPicM.Image;
            Bitmap bmpSld = new Bitmap(sliderButtonPicM.Image);
            float bar_size = 0.5f;
            Color sliderEmptyColor = Color.FromArgb(64, 64, 64);
            slidery = SliderM.Height - BarM(def_valueM);
            int x = (int)(SliderM.Width * bar_size);
            e.Graphics.FillRectangle(Brushes.Black, 8, 0, 33, SliderM.Height);
            e.Graphics.FillRectangle(new SolidBrush(sliderEmptyColor), 11, 3, 27, SliderM.Height - 6);
            sliderButtonPicM.Location = new Point(SliderM.Location.X, (int)(slidery + SliderM.Location.Y - sliderButtonPicM.Height));
            e.Graphics.FillRectangle(Brushes.LightGray, 11, slidery, 27, SliderM.Height - slidery - 3);
        }
        private void Slider_MouseDownM(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumbM(Slider_height(SliderM.Height - e.Y));
            if (!eraserOn)
            {
                M = (int)((SliderM.Height - slidery) / (SliderM.Height - sliderButtonPicM.Height + 3) * 255);
                mVal.Text = M.ToString();
            }
        }
        private void Slider_MouseMoveM(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            thumbM(Slider_height(SliderM.Height - e.Y));
            if (!eraserOn)
            {
                M = (int)((SliderM.Height - slidery) / (SliderM.Height - sliderButtonPicM.Height + 3) * 255);
                mVal.Text = M.ToString();
            }
        }
        private void Slider_MouseUpM(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
        private void Slider_PaintE(object sender, PaintEventArgs e)
        {
            sliderButton2 = sliderButtonPicE.Image;
            Bitmap bmpSld = new Bitmap(sliderButtonPicE.Image);
            float bar_size = 0.5f;
            Color sliderEmptyColor = Color.FromArgb(64, 64, 64);
            slidery = SliderE.Height-BarE(def_valueE);
            int x = (int)(SliderE.Width * bar_size);
            e.Graphics.FillRectangle(Brushes.Black, 8, 0, 33, SliderE.Height);
            e.Graphics.FillRectangle(new SolidBrush(sliderEmptyColor), 11, 3, 27, SliderE.Height - 6);
            sliderButtonPicE.Location = new Point(SliderE.Location.X,(int) (slidery+ SliderE.Location.Y - sliderButtonPicE.Height));
            e.Graphics.FillRectangle(Brushes.LightGray, 11, slidery, 27, SliderE.Height-slidery-3);
        }
        private void Slider_MouseDownE(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumbE(Slider_height(SliderE.Height-e.Y));
            if (!eraserOn)
            {
                E = (int)((SliderE.Height - slidery) / (SliderE.Height - sliderButtonPicE.Height + 3) * 255);
                eVal.Text = E.ToString();
            }
        }
        private void Slider_MouseMoveE(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            thumbE(Slider_height(SliderE.Height - e.Y));
            if (!eraserOn)
            {
                E = (int)((SliderE.Height - slidery) / (SliderE.Height - sliderButtonPicE.Height + 3) * 255);
                eVal.Text = E.ToString();
            }
        }
        private void Slider_MouseUpE(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
        private void Slider_PaintR(object sender, PaintEventArgs e)
        {
            sliderButton3 = sliderButtonPicR.Image;
            Bitmap bmpSld = new Bitmap(sliderButtonPicR.Image);
            float bar_size = 0.5f;
            Color sliderEmptyColor = Color.FromArgb(64, 64, 64);
            slidery = SliderR.Height - BarE(def_valueR);
            int x = (int)(SliderR.Width * bar_size);
            e.Graphics.FillRectangle(Brushes.Black, 8, 0, 33, SliderR.Height);
            e.Graphics.FillRectangle(new SolidBrush(sliderEmptyColor), 11, 3, 27, SliderR.Height - 6);
            sliderButtonPicR.Location = new Point(SliderR.Location.X, (int)(slidery + SliderR.Location.Y - sliderButtonPicR.Height));
            e.Graphics.FillRectangle(Brushes.LightGray, 11, slidery, 27, SliderR.Height - slidery - 3);
        }
        private void Slider_MouseDownR(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumbR(Slider_height(SliderR.Height - e.Y));
            if (!eraserOn)
            {
                R = (int)((SliderR.Height - slidery) / (SliderR.Height - sliderButtonPicR.Height + 3) * 255);
                rVal.Text = R.ToString();
            }
        }
        private void Slider_MouseMoveR(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            thumbR(Slider_height(SliderR.Height - e.Y));
            if (!eraserOn)
            {
                R = (int)((SliderR.Height - slidery) / (SliderR.Height - sliderButtonPicR.Height + 3) * 255);
                rVal.Text = R.ToString();
            }
        }
        private void Slider_MouseUpR(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
        Image file;
        Boolean opened = false;
        Color[,] pixel;
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
                factor = 1;
                limit = 64;
                pixelX = x;
                pixelY = y;
                pixel = new Color[pixelX, pixelY];
            }
        }
        void saveImage()
        {
            if (opened)
            {
                int temp = zoom;
                zoom = 1;
                pictureBox1.Size = new Size(x, y);
                pictureBox1.Location = new Point((panelCanvas.Size.Width - pictureBox1.Width) / 2, (panelCanvas.Size.Height - pictureBox1.Height) / 2);
                pictureBox1.Invalidate();
                string fileName = Path.GetFileName(filePath);
                fileName = fileName.Substring(0, fileName.Length - 4);
                using (var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                {
                    pictureBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                    bitmap.Save(@$"C:\Users\yusuf\Desktop\{fileName}_mer.png");
                    zoom = temp;
                    pictureBox1.Size = new Size(zoom * x, zoom * y);
                    pictureBox1.Location = new Point((panelCanvas.Size.Width - pictureBox1.Width) / 2, (panelCanvas.Size.Height - pictureBox1.Height) / 2);
                    pictureBox1.Invalidate();
                }
            }
            else { MessageBox.Show("No image loaded, first upload an image. "); }
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
                    zoom = 1;
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
        bool eraserOn = false;
        bool firstEraser = true;
        int tempM, tempE, tempR;
        string drawtool;
        private void Pen_Click(object sender, EventArgs e)
        {
            eraserOn = false;
            if (!eraserOn && !firstEraser) 
            {
                drawtool="pen";
                M = tempM; E = tempE; R = tempR;
                mVal.Text = M.ToString();
                eVal.Text = E.ToString();
                rVal.Text = R.ToString();
            }
        }
        private void Eraser_Click(object sender, EventArgs e)
        {
            eraserOn = true;
            if (eraserOn)
            {
                tempM = M; tempE = E; tempR = R;
                M = 255;
                E = 255;
                R = 255;
                firstEraser = false;
            }
        }
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (opened)
            {
                Color color = Color.FromArgb(M, E, R);
                SolidBrush myBrush = new SolidBrush(color);
                myBrush.Color = Color.FromArgb(255, color);
                cursorMoving = true;
                cursorX = e.X;
                cursorY = e.Y;
                int xAxis = (int)(cursorX * zoom * (float)Math.Pow(2, 5 - factor) * bm.Width / 16 / (float)(bm.Width * Math.Pow(2, factor - 1)));
                int yAxis = (int)(cursorY * zoom * (float)Math.Pow(2, 5 - factor) * bm.Height / 16 / (float)(bm.Height * Math.Pow(2, factor - 1)));
                Point touch = new Point(xAxis * zoom, yAxis * zoom);
                graphics.FillRectangle(myBrush, touch.X, touch.Y, file.Width * zoom / bm.Width, file.Height * zoom / bm.Height);
                if (xAxis <= (pictureBox1.Width / zoom) - 1 && yAxis <= (pictureBox1.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0)
                {
                    pixel[xAxis, yAxis] = color;
                }


            }
        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving && opened) 
            {
                Color color = Color.FromArgb(M, E, R);
                SolidBrush myBrush = new SolidBrush(color);
                myBrush.Color = Color.FromArgb(255, color);
                cursorX = e.X;
                cursorY = e.Y;
                int xAxis = (int)(cursorX * zoom * (float)Math.Pow(2, 5 - factor) * bm.Width / 16 / (float)(bm.Width * Math.Pow(2, factor - 1)));
                int yAxis = (int)(cursorY * zoom * (float)Math.Pow(2, 5 - factor) * bm.Height / 16 / (float)(bm.Height * Math.Pow(2, factor - 1)));
                Point touch = new Point(xAxis * zoom, yAxis * zoom);
                graphics.FillRectangle(myBrush, touch.X, touch.Y, file.Width * zoom / bm.Width, file.Height * zoom / bm.Height);
                if (xAxis <= (pictureBox1.Width / zoom) - 1 && yAxis <= (pictureBox1.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) 
                {
                    pixel[xAxis, yAxis] = color;
                }
            }
        }
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
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
                        if (!pixel[i, j].IsEmpty) 
                        {
                            int xAxis = i;
                            int yAxis = j;
                            Point touch = new Point(xAxis * zoom, yAxis * zoom);
                            Color color = pixel[i, j];
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