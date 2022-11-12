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
            M = (int)((SliderM.Height - slidery) / (SliderM.Height - sliderButtonPicM.Height + 3) * 255);
            mVal.Text = M.ToString();
        }
        private void Slider_MouseMoveM(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            thumbM(Slider_height(SliderM.Height - e.Y));
            M = (int)((SliderM.Height - slidery) / (SliderM.Height - sliderButtonPicM.Height + 3) * 255);
            mVal.Text = M.ToString();
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
            thumbE(Slider_height(SliderE.Height - e.Y));
            E = (int)((SliderE.Height - slidery) / (SliderE.Height - sliderButtonPicE.Height + 3) * 255);
            eVal.Text = E.ToString();
        }
        private void Slider_MouseMoveE(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            thumbE(Slider_height(SliderE.Height - e.Y));
            E = (int)((SliderE.Height - slidery) / (SliderE.Height - sliderButtonPicE.Height + 3) * 255);
            eVal.Text = E.ToString();
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
            R = (int)((SliderR.Height - slidery) / (SliderR.Height - sliderButtonPicR.Height + 3) * 255);
            rVal.Text = R.ToString();
        }
        private void Slider_MouseMoveR(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            thumbR(Slider_height(SliderR.Height - e.Y));
            R = (int)((SliderR.Height - slidery) / (SliderR.Height - sliderButtonPicR.Height + 3) * 255);
            rVal.Text = R.ToString();
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
                canvas.Image = file;
                canvas.Height = file.Height;
                canvas.Width = file.Width;
                x = canvas.Width;
                y = canvas.Height;
                canvas.Location = new Point((panelCanvas.Width - x) / 2, (panelCanvas.Height - y) / 2);
                bm = new Bitmap(canvas.Image);
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
                canvas.Size = new Size(x, y);
                canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                canvas.Invalidate();
                string fileName = Path.GetFileName(filePath);
                fileName = fileName.Substring(0, fileName.Length - 4);
                using (var bitmap = new Bitmap(canvas.Width, canvas.Height))
                {
                    canvas.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                    bitmap.Save(@$"C:\Users\yusuf\Desktop\{fileName}_mer.png");
                    zoom = temp;
                    canvas.Size = new Size(zoom * x, zoom * y);
                    canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                    canvas.Invalidate();
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
            if (canvas.Image != null)
                canvas.Dispose();
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
                    canvas.Image = null;
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
                canvas.Size = new Size(zoom * x, zoom * y);
                canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                canvas.Invalidate();
            }
        }
        bool eraserOn = false;
        bool penOn = true, rectOn = false, brushOn = false;
        private void Pen_Click(object sender, EventArgs e)
        {
            eraserOn = false;
            penOn = true;
            rectOn = false;
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            eraserOn = false;
            penOn = false;
            rectOn = true;
        }
        private void Eraser_Click(object sender, EventArgs e)
        {
            eraserOn = true;
            penOn = false;
            rectOn = false;
        }
        int recx, recy;
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (opened && (penOn || eraserOn))
            {
                Color color = Color.FromArgb(M, E, R);
                Color eraserColor = Color.FromArgb(255, 255, 255);
                SolidBrush myBrush = new SolidBrush(color);
                SolidBrush eraser = new SolidBrush(eraserColor);
                if ((penOn || rectOn) && !eraserOn) 
                {
                    myBrush.Color = Color.FromArgb(255, color);
                }
                else if (eraserOn)
                {
                    myBrush.Color = Color.FromArgb(255, eraserColor);
                }
                cursorMoving = true;
                cursorX = e.X;
                cursorY = e.Y;
                int xAxis = (int)(cursorX * zoom * (float)Math.Pow(2, 5 - factor) * bm.Width / 16 / (float)(bm.Width * Math.Pow(2, factor - 1)));
                int yAxis = (int)(cursorY * zoom * (float)Math.Pow(2, 5 - factor) * bm.Height / 16 / (float)(bm.Height * Math.Pow(2, factor - 1)));
                Point touch = new Point(xAxis * zoom, yAxis * zoom);
                graphics.FillRectangle(myBrush, touch.X, touch.Y, file.Width * zoom / bm.Width, file.Height * zoom / bm.Height);
                if ((xAxis <= (canvas.Width / zoom) - 1 && yAxis <= (canvas.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) && penOn)
                {
                    pixel[xAxis, yAxis] = color;
                }
                else if ((xAxis <= (canvas.Width / zoom) - 1 && yAxis <= (canvas.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) && eraserOn)
                {
                    pixel[xAxis, yAxis] = eraserColor;
                }
            }
            else if (opened && rectOn) 
            {
                cursorMoving = true; 
                cursorX = e.X;
                cursorY = e.Y;
                
            }
        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving && opened && (penOn || eraserOn || rectOn)) 
            {
                Color color = Color.FromArgb(M, E, R);
                Color eraserColor = Color.FromArgb(255, 255, 255);
                SolidBrush myBrush = new SolidBrush(color);
                SolidBrush eraser = new SolidBrush(eraserColor);
                if ((penOn || rectOn) && !eraserOn)
                {
                    myBrush.Color = Color.FromArgb(255, color);
                }
                else if (eraserOn)
                {
                    myBrush.Color = Color.FromArgb(255, eraserColor);
                }
                if (penOn || eraserOn) 
                {
                    cursorX = e.X;
                    cursorY = e.Y;
                    int xAxis = (int)(cursorX * zoom * (float)Math.Pow(2, 5 - factor) * bm.Width / 16 / (float)(bm.Width * Math.Pow(2, factor - 1)));
                    int yAxis = (int)(cursorY * zoom * (float)Math.Pow(2, 5 - factor) * bm.Height / 16 / (float)(bm.Height * Math.Pow(2, factor - 1)));
                    Point touch = new Point(xAxis * zoom, yAxis * zoom);
                    graphics.FillRectangle(myBrush, touch.X, touch.Y, file.Width * zoom / bm.Width, file.Height * zoom / bm.Height);
                    if ((xAxis <= (canvas.Width / zoom) - 1 && yAxis <= (canvas.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) && penOn)
                    {
                        pixel[xAxis, yAxis] = color;
                    }
                    else if ((xAxis <= (canvas.Width / zoom) - 1 && yAxis <= (canvas.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) && eraserOn)
                    {
                        pixel[xAxis, yAxis] = eraserColor;
                    }
                }
                if (rectOn)
                {
                    Pen p = new Pen(Color.FromArgb(0, 122, 255), 2);
                    recx = e.X;
                    recy = e.Y;
                    int xAxis1 = (int)(cursorX * zoom * (float)Math.Pow(2, 5 - factor) * bm.Width / 16 / (float)(bm.Width * Math.Pow(2, factor - 1)));
                    int yAxis1 = (int)(cursorY * zoom * (float)Math.Pow(2, 5 - factor) * bm.Height / 16 / (float)(bm.Height * Math.Pow(2, factor - 1)));
                    Point touch1 = new Point(xAxis1 * zoom, yAxis1 * zoom);
                    int xAxis2 = (int)(recx * zoom * (float)Math.Pow(2, 5 - factor) * bm.Width / 16 / (float)(bm.Width * Math.Pow(2, factor - 1)));
                    int yAxis2 = (int)(recy * zoom * (float)Math.Pow(2, 5 - factor) * bm.Height / 16 / (float)(bm.Height * Math.Pow(2, factor - 1)));
                    Point release = new Point(xAxis2 * zoom, yAxis2 * zoom);
                    Refresh();
                    if (cursorX < recx && cursorY < recy)
                        graphics.DrawRectangle(p, touch1.X, touch1.Y, (release.X - touch1.X + zoom) * file.Width / bm.Width, (release.Y - touch1.Y + zoom) * file.Height / bm.Height);
                    else if (cursorX > recx && cursorY < recy)
                        graphics.DrawRectangle(p, release.X, touch1.Y, (touch1.X - release.X + zoom) * file.Width / bm.Width, (release.Y - touch1.Y + zoom) * file.Height / bm.Height);
                    else if (cursorX > recx && cursorY > recy)
                        graphics.DrawRectangle(p, release.X, release.Y, (touch1.X - release.X + zoom) * file.Width / bm.Width, (touch1.Y - release.Y + zoom) * file.Height / bm.Height);
                    else if (cursorX < recx && cursorY > recy)
                        graphics.DrawRectangle(p, touch1.X, release.Y, (release.X - touch1.X + zoom) * file.Width / bm.Width, (touch1.Y - release.Y + zoom) * file.Height / bm.Height);
                }
            }
        }
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            Refresh();
            cursorMoving = false;
            if (opened && rectOn)
            {
                Color color = Color.FromArgb(M, E, R);
                SolidBrush myBrush = new SolidBrush(color);
                myBrush.Color = Color.FromArgb(255, color);
                recx = e.X;
                recy = e.Y;
                int xAxis1 = (int)(cursorX * zoom * (float)Math.Pow(2, 5 - factor) * bm.Width / 16 / (float)(bm.Width * Math.Pow(2, factor - 1)));
                int yAxis1 = (int)(cursorY * zoom * (float)Math.Pow(2, 5 - factor) * bm.Height / 16 / (float)(bm.Height * Math.Pow(2, factor - 1)));
                Point touch = new Point(xAxis1 * zoom, yAxis1 * zoom);
                int xAxis2 = (int)(recx * zoom * (float)Math.Pow(2, 5 - factor) * bm.Width / 16 / (float)(bm.Width * Math.Pow(2, factor - 1)));
                int yAxis2 = (int)(recy * zoom * (float)Math.Pow(2, 5 - factor) * bm.Height / 16 / (float)(bm.Height * Math.Pow(2, factor - 1)));
                Point release = new Point(xAxis2 * zoom, yAxis2 * zoom);
                if (cursorX < recx && cursorY < recy)
                {
                    graphics.FillRectangle(myBrush, touch.X, touch.Y, (release.X - touch.X + zoom) * file.Width / bm.Width, (release.Y - touch.Y + zoom) * file.Height / bm.Height);
                    for (int i = xAxis1; i <= xAxis2; i++)
                    {
                        for (int j = yAxis1; j <= yAxis2; j++)
                        {
                            if (i <= (canvas.Width / zoom) - 1 && j <= (canvas.Height / zoom) - 1 && i >= 0 && j >= 0)
                                pixel[i, j] = color;
                        }
                    }
                }
                else if (cursorX > recx && cursorY < recy)
                {
                    graphics.FillRectangle(myBrush, release.X, touch.Y, (touch.X - release.X + zoom) * file.Width / bm.Width, (release.Y - touch.Y + zoom) * file.Height / bm.Height);
                    for (int i = xAxis2; i <= xAxis1; i++)
                    {
                        for (int j = yAxis1; j <= yAxis2; j++)
                        {
                            if (i <= (canvas.Width / zoom) - 1 && j <= (canvas.Height / zoom) - 1 && i >= 0 && j >= 0)
                                pixel[i, j] = color;
                        }
                    }
                }
                else if (cursorX > recx && cursorY > recy)
                {
                    graphics.FillRectangle(myBrush, release.X, release.Y, (touch.X - release.X + zoom) * file.Width / bm.Width, (touch.Y - release.Y + zoom) * file.Height / bm.Height);
                    for (int i = xAxis2; i <= xAxis1; i++)
                    {
                        for (int j = yAxis2; j <= yAxis1; j++)
                        {
                            if (i <= (canvas.Width / zoom) - 1 && j <= (canvas.Height / zoom) - 1 && i >= 0 && j >= 0)
                                pixel[i, j] = color;
                        }
                    }
                }
                else if (cursorX < recx && cursorY > recy)
                {
                    graphics.FillRectangle(myBrush, touch.X, release.Y, (release.X - touch.X + zoom) * file.Width / bm.Width, (touch.Y - release.Y + zoom) * file.Height / bm.Height);
                    for (int i = xAxis1; i <= xAxis2; i++)
                    {
                        for (int j = yAxis2; j <= yAxis1; j++)
                        {
                            if (i <= (canvas.Width / zoom) - 1 && j <= (canvas.Height / zoom) - 1 && i >= 0 && j >= 0)
                                pixel[i, j] = color;
                        }
                    }
                }
            }
            cursorX = -1;
            cursorY = -1;
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            if (file != null)
            {
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
                e.Graphics.DrawImage(bm, 0, 0, canvas.Width, canvas.Height);
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
                graphics = canvas.CreateGraphics();

            }
        }
        Graphics graphics;
        Boolean cursorMoving = false;
        int cursorX = -1;
        int cursorY = -1;
    }
}