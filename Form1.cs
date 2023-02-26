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
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing.Text;

namespace RTX_Texture_Editor_for_Minecraft
{
    public partial class Form : System.Windows.Forms.Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        float scaleFactor;
        public Form()
        {
            InitializeComponent();
            this.panelCanvas.MouseWheel += PanelCanvas_MouseWheel;
            savePath = Settings.Default.SaveLocation;
            scaleFactor = 150f / CreateGraphics().DpiY;
            createFont();
            setFonts(scaleFactor);
            textColor(Color.FromArgb(76, 76, 76));
            undoButton.Enabled = false;
            redoButton.Enabled = false;
        }
        Stack<Color[,]> undoNormal = new Stack<Color[,]>();
        Stack<Color[,]> undoGray = new Stack<Color[,]>();
        Stack<Color[,]> redoNormal = new Stack<Color[,]>();
        Stack<Color[,]> redoGray = new Stack<Color[,]>();
        private void createFont()
        {
            byte[] fontData = Properties.Resources.minecraft_font;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.minecraft_font.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.minecraft_font.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);
        }
        private void setFonts(float factor)
        {
            grayScaleButton.Font = new Font(fonts.Families[0], 9.0F * factor);
            penSizeUp.Font = new Font(fonts.Families[0], 9.0F * factor);
            penSizeDown.Font = new Font(fonts.Families[0], 9.0F * factor);
            pen_size.Font = new Font(fonts.Families[0], 9.0F * factor);
            SaveLocButton.Font = new Font(fonts.Families[0], 8.0F * factor);
            fileOpen.Font = new Font(fonts.Families[0], 9.0F * factor);
            saveFile.Font = new Font(fonts.Families[0], 9.0F * factor);
            createTextureSet.Font = new Font(fonts.Families[0], 9.0F * factor);
            mVal.Font = new Font(fonts.Families[0], 11.0F * factor);
            eVal.Font = new Font(fonts.Families[0], 11.0F * factor);
            rVal.Font = new Font(fonts.Families[0], 11.0F * factor);
            gVal.Font = new Font(fonts.Families[0], 11.0F * factor);
            metalnessLabel.Font = new Font(fonts.Families[0], 10.0F * factor);
            emissiveLabel.Font = new Font(fonts.Families[0], 10.0F * factor);
            roughnessLabel.Font = new Font(fonts.Families[0], 10.0F * factor);
            grayLabel.Font = new Font(fonts.Families[0], 10.0F * factor);
            SelectedItem.Font = new Font(fonts.Families[0], 12.0F * factor);
            undoButton.Font = new Font(fonts.Families[0], 9.0F * factor);
            redoButton.Font = new Font(fonts.Families[0], 9.0F * factor);
        }
        private void textColor(Color c)
        {
            penSizeUp.ForeColor = c;
            penSizeDown.ForeColor = c;
            saveFile.ForeColor = c;
            fileOpen.ForeColor = c;
            SaveLocButton.ForeColor = c;
            createTextureSet.ForeColor = c;
            undoButton.ForeColor = c;
            redoButton.ForeColor = c;
            grayScaleButton.ForeColor = c;
        }
        int pixelX, pixelY;
        float def_valueM = 0.0f, def_valueE = 0.0f, def_valueR = 0.0f, def_valueG = 0.0f, Min = 0.0f, Max = 1.0f;
        bool firstTime = true;
        public float BarM(float value)
        {
            return (SliderM.Height-28) * (value - Min) / (float)(Max - Min);
        }
        public float BarE(float value)
        {
            return (SliderE.Height - 28) * (value - Min) / (float)(Max - Min);
        }
        public float BarR(float value)
        {
            return (SliderR.Height - 28) * (value - Min) / (float)(Max - Min);
        }
        public float BarG(float value)
        {
            return (SliderG.Height - 28) * (value - Min) / (float)(Max - Min);
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
        public void thumbG(float value)
        {
            if (value < Min)
                value = Min;
            if (value > Max)
                value = Max;
            def_valueG = value;
            SliderG.Refresh();
        }
        public float Slider_height(int y)
        {
            return Min + (Max - Min) * y / (float)(SliderE.Height);
        }
        float slidery;
        bool mouse = false;
        private void Slider_PaintM(object sender, PaintEventArgs e)
        {
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
        private void Slider_PaintG(object sender, PaintEventArgs e)
        {
            Bitmap bmpSld = new Bitmap(sliderButtonPicG.Image);
            float bar_size = 0.5f;
            Color sliderEmptyColor = Color.FromArgb(64, 64, 64);
            slidery = SliderG.Height - BarG(def_valueG);
            int x = (int)(SliderG.Width * bar_size);
            e.Graphics.FillRectangle(Brushes.Black, 8, 0, 33, SliderG.Height);
            e.Graphics.FillRectangle(new SolidBrush(sliderEmptyColor), 11, 3, 27, SliderG.Height - 6);
            sliderButtonPicG.Location = new Point(SliderG.Location.X, (int)(slidery + SliderG.Location.Y - sliderButtonPicG.Height));
            e.Graphics.FillRectangle(Brushes.LightGray, 11, slidery, 27, SliderG.Height - slidery - 3);
        }
        private void Slider_MouseDownG(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumbG(Slider_height(SliderG.Height - e.Y));
            G = (int)((SliderG.Height - slidery) / (SliderG.Height - sliderButtonPicG.Height + 3) * 255);
            gVal.Text = G.ToString();
        }
        private void Slider_MouseMoveG(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            thumbG(Slider_height(SliderG.Height - e.Y));
            G = (int)((SliderG.Height - slidery) / (SliderG.Height - sliderButtonPicG.Height + 3) * 255);
            grayColor = Color.FromArgb(G, G, G);
            gVal.Text = G.ToString();
        }
        private void Slider_MouseUpG(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
        Image file;
        Image tempPic;
        Image tempPicGray;
        Boolean opened = false;
        Color[,] pixel;
        Color[,] pixelGray;
        string filePath = "";
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
                zoom = 1;
                factor = 1;
                limit = 64;
                pixelX = x;
                pixelY = y;
                pixel = new Color[pixelX, pixelY];
                pixelGray = new Color[pixelX, pixelY];
                undoNormal.Clear();
                redoNormal.Clear();
                var tempP = (Color[,])pixel.Clone();
                undoNormal.Push(tempP);
                firstTime = true;
                firstTimeGray = true;
                GrayScale = false;
                grayScaleButton.Text = "Gray Scale: OFF";
                undoButton.Enabled = false;
                redoButton.Enabled = false;
            }
        }
        void saveImage()
        {
            if (opened)
            {
                if (savePath != "")
                {
                    int temp = zoom;
                    zoom = 1;
                    canvas.Size = new Size(x, y);
                    canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                    canvas.Invalidate();
                    string fileName = Path.GetFileName(filePath);
                    fileName = fileName.Substring(0, fileName.Length - 4);
                    if (!GrayScale)
                        using (var bitmap = new Bitmap(canvas.Width, canvas.Height))
                        {
                            canvas.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                            bitmap.Save(@$"{savePath}\{fileName}_mer.png");
                            zoom = temp;
                            canvas.Size = new Size(zoom * x, zoom * y);
                            canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                            canvas.Invalidate();
                        }
                    if (GrayScale)
                    {

                        using (var bitmap = new Bitmap(canvas.Width, canvas.Height))
                        {
                            for (int i = 0; i <= canvas.Width - 1; i++)
                            {
                                for (int j = 0; j <= canvas.Height - 1; j++)
                                {
                                    bitmap.SetPixel(i, j, bmpGray.GetPixel(i, j));
                                }
                            }
                            bitmap.Save(@$"{savePath}\{fileName}_normal.png",ImageFormat.Png);
                            string image = @$"{savePath}\{fileName}_normal.png";
                            OpenCvSharp.Mat grayScale = OpenCvSharp.Cv2.ImRead(image, OpenCvSharp.ImreadModes.Grayscale);
                            OpenCvSharp.Cv2.ImWrite(@$"{savePath}\{fileName}_normal.png", grayScale);
                            zoom = temp;
                            canvas.Size = new Size(zoom * x, zoom * y);
                            canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                            canvas.Invalidate();
                        }
                    }
                }
                else { MessageBox.Show("Select a folder first. "); }
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
        int zoom = 1, limit, x, y, factor = 1;
        int M, E, R, G;
        Color grayColor = Color.FromArgb(0, 0, 0);
        private void PanelCanvas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (bm != null)
            {
                if (firstTime)
                {
                    canvas.Image = null;
                    firstTime = false;
                    zoom = 1;
                    canvas.Size = new Size(zoom * x, zoom * y);
                    canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                }
                if (e.Delta > 0 && zoom * 2 <= limit)
                {
                    zoom = zoom * 2;
                    factor++;
                    canvas.Size = new Size(zoom * x, zoom * y);
                    if (zoom >= limit)
                    {
                        canvas.Location = new Point(0, 0);
                    }
                    else
                    {
                        canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                    }
                }
                else if (e.Delta < 0 && zoom / 2 > 0.5f)
                {
                    zoom = zoom / 2;
                    factor--;
                    canvas.Size = new Size(zoom * x, zoom * y);
                    canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                }
                canvas.Invalidate();
            }
        }
        bool eraserOn = false;
        int penSize = 1;
        int penSizeTemp = 1;
        private void penSizeUp_Click(object sender, EventArgs e)
        {
            if (penSize + 2 <= 15 && penOn)
                penSize += 2;
            if (penOn)
            {
                penSizeTemp = penSize;
                if (penSizeTemp == 1)
                    pen_size.Text = "Pen size:\n" + penSizeTemp.ToString() + "\npixel";
                else
                    pen_size.Text = "Pen size:\n" + penSizeTemp.ToString() + "\npixels";
            }
        }
        private void penSizeDown_Click(object sender, EventArgs e)
        {
            if (penSize - 2 > 0 && penOn)
                penSize -= 2;
            if (penOn) 
            {
                penSizeTemp = penSize;
                if (penSizeTemp == 1)
                    pen_size.Text = "Pen size:\n" + penSizeTemp.ToString() + "\npixel";
                else
                    pen_size.Text = "Pen size:\n" + penSizeTemp.ToString() + "\npixels";
            }
        }
        bool GrayScale = false;
        bool firstTimeGray = true;
        string savePath = Settings.Default.SaveLocation;
        private void SaveLocButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                savePath = path.SelectedPath;
                Settings.Default.SaveLocation = savePath;
                Settings.Default.Save();
            }
        }
        private void createTextureSet_Click(object sender, EventArgs e)
        {
            if (savePath != "")
            {
                if (opened)
                {
                    string fileName = Path.GetFileName(filePath);
                    fileName = fileName.Substring(0, fileName.Length - 4);
                    TextWriter json = new StreamWriter(@$"{savePath}\{fileName}.texture_set.json");
                    json.WriteLine("{\n" +
                                   "    \"format_version\":\"1.16.100\",\n" +
                                   "    \"minecraft:texture_set\":{\n" +
                                   "       \"color\":" + "\"" + @$"{fileName}" + "\",\n" +
                                   "       \"metalness_emissive_roughness\":" + "\"" + @$"{fileName}_mer" + "\",\n" +
                                   "       \"heightmap\":" + "\"" + @$"{fileName}_normal" + "\"\n" +
                                   "    }\n" +
                                   "}\n");
                    json.Close();
                }
                else { MessageBox.Show("No image loaded, first upload an image. "); }
            }
            else { MessageBox.Show("Select a folder first. "); }
        }
        Bitmap bmpGray;
        private void grayScaleButton_Click(object sender, EventArgs e)
        {
            if (opened && !GrayScale)
            {
                GrayScale = true;
                grayScaleButton.Text = "Gray Scale: ON";
                tempPic = canvas.Image;
                if (firstTimeGray)
                {
                    firstTimeGray = false;
                    int temp = zoom;
                    zoom = 1;
                    canvas.Size = new Size(x, y);
                    canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                    bmpGray = new Bitmap(canvas.Width, canvas.Height);
                    using (var bitmap = new Bitmap(canvas.Width, canvas.Height))
                    {
                        canvas.DrawToBitmap(bmpGray, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                        zoom = temp;
                        canvas.Size = new Size(zoom * x, zoom * y);
                        canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                        canvas.Invalidate();
                    }
                }
                else if (GrayScale)
                {
                    canvas.Image = tempPicGray;
                }
                for (int i = 0; i < bm.Width; i++)
                {
                    for (int j = 0; j < bm.Height; j++)
                    {
                        pixelGray[i, j] = bmpGray.GetPixel(i, j);
                        Color color = Color.FromArgb((int)((pixelGray[i, j].R + pixelGray[i, j].G + pixelGray[i, j].B) / 3), (int)((pixelGray[i, j].R + pixelGray[i, j].G + pixelGray[i, j].B) / 3), (int)((pixelGray[i, j].R + pixelGray[i, j].G + pixelGray[i, j].B) / 3));
                        pixelGray[i, j] = color;
                    }
                }
                ColorPanel.Visible = false;
                ColorPanel.Enabled = false;
                GrayScalePanel.Visible = true;
                GrayScalePanel.Enabled = true;
            }
            else if(opened && GrayScale)
            {
                GrayScale = false;
                grayScaleButton.Text = "Gray Scale: OFF";
                tempPicGray = canvas.Image;
                canvas.Image = tempPic;
                ColorPanel.Visible = true;
                ColorPanel.Enabled = true;
                GrayScalePanel.Visible = false;
                GrayScalePanel.Enabled = false;
            }
            canvas.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            redoNormal.Push(undoNormal.Pop());
            var v = (Color[,])undoNormal.Peek().Clone();
            pixel = v;
            canvas.Invalidate();
            if (undoNormal.Count == 1)
                undoButton.Enabled = false;
        }
        private void undoButton_Click(object sender, EventArgs e)
        {
            redoNormal.Push(undoNormal.Pop());
            if (undoNormal.Count > 0)
            {
                var v = (Color[,])undoNormal.Peek().Clone();
                pixel = v;
            }
            if (undoNormal.Count == 1)
                undoButton.Enabled = false;
            redoButton.Enabled = true;
            canvas.Invalidate();
        }
        private void redoButton_Click(object sender, EventArgs e)
        {
            if (redoNormal.Count > 0)
            {
                var v = (Color[,])redoNormal.Peek().Clone();
                pixel = v;
                undoNormal.Push(redoNormal.Pop());
            }
            if (redoNormal.Count == 0) 
                redoButton.Enabled = false;
            if (undoNormal.Count > 1)
                undoButton.Enabled = true;
            canvas.Invalidate();
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true) {
                switch (e.KeyCode)
                {
                    case Keys.Z:
                        undoButton.PerformClick();
                        break;
                    case Keys.Y:
                        redoButton.PerformClick();
                        break;
                    default:
                        break;
                }
            }
            switch (e.KeyCode)
            {
                case Keys.D1:
                    Eraser.PerformClick();
                    break;
                case Keys.D2:
                    Pen.PerformClick();
                    break;
                case Keys.D3:
                    Rectangle.PerformClick();
                    break;
                case Keys.E:
                    Eraser.PerformClick();
                    break;
                case Keys.P:
                    Pen.PerformClick();
                    break;
                case Keys.R:
                    Rectangle.PerformClick();
                    break;
                default:
                    break;
            }
        }
        bool penOn = true, rectOn = false;
        private void Pen_Click(object sender, EventArgs e)
        {
            eraserOn = false;
            penOn = true;
            rectOn = false;
            penSize = penSizeTemp;
            buttonFrame.Location = new Point(PenInside.Location.X - 12, PenInside.Location.Y - 12);
            SelectedItem.Text = "Pen";
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            eraserOn = false;
            penOn = false;
            rectOn = true;
            buttonFrame.Location = new Point(RectangleInside.Location.X - 12, RectangleInside.Location.Y - 12);
            SelectedItem.Text = "Rectangle";
        }
        private void Eraser_Click(object sender, EventArgs e)
        {
            eraserOn = true;
            penOn = false;
            rectOn = false;
            penSize = 1;
            buttonFrame.Location = new Point(EraserInside.Location.X - 12, EraserInside.Location.Y - 12);
            SelectedItem.Text = "Eraser";
        }
        int recx, recy;
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            redoNormal.Clear();
            redoButton.Enabled = false;
            if (opened && (penOn || eraserOn))
            {
                Color color = Color.FromArgb(M, E, R);
                Color eraserColor = Color.FromArgb(255, 255, 255);
                SolidBrush myBrush = new SolidBrush(color);
                SolidBrush eraser = new SolidBrush(eraserColor);
                if ((penOn || rectOn) && !eraserOn) 
                {
                    if (!GrayScale)
                        myBrush.Color = Color.FromArgb(255, color);
                    else
                        myBrush.Color = grayColor;
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
                Point touch = new Point((xAxis - penSize/2) * zoom, (yAxis - penSize/2) * zoom);
                graphics.FillRectangle(myBrush, touch.X, touch.Y, file.Width * penSize * zoom / bm.Width, file.Height * penSize * zoom / bm.Height);
                if ((xAxis <= (canvas.Width / zoom) - 1 && yAxis <= (canvas.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) && penOn)
                {
                    for (int i = (xAxis - (int)(penSize / 2)); i <= (xAxis + (int)(penSize / 2)); i++)
                    {
                        for (int j = (yAxis - (int)(penSize / 2)); j <= (yAxis + (int)(penSize / 2)); j++) 
                        {
                            if (i <= (canvas.Width / zoom) - 1 && j <= (canvas.Height / zoom) - 1 && i >= 0 && j >= 0)
                            {
                                if (GrayScale)
                                    pixelGray[i, j] = grayColor;
                                else
                                    pixel[i, j] = color;
                            }
                        }
                    }
                }
                else if ((xAxis <= (canvas.Width / zoom) - 1 && yAxis <= (canvas.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) && eraserOn)
                {
                    if (GrayScale)
                        pixelGray[xAxis, yAxis] = eraserColor;
                    else
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
                if (penOn && !eraserOn)
                {
                    if (!GrayScale)
                        myBrush.Color = Color.FromArgb(255, color);
                    else
                        myBrush.Color = grayColor;
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
                    Point touch = new Point((xAxis - penSize/2) * zoom, (yAxis - penSize/2) * zoom);
                    graphics.FillRectangle(myBrush, touch.X, touch.Y, file.Width * penSize * zoom / bm.Width, file.Height * penSize * zoom / bm.Height);
                    if ((xAxis <= (canvas.Width / zoom) - 1 && yAxis <= (canvas.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) && penOn)
                    {
                        for (int i = (xAxis - (int)(penSize / 2)); i <= (xAxis + (int)(penSize / 2)); i++)
                        {
                            for (int j = (yAxis - (int)(penSize / 2)); j <= (yAxis + (int)(penSize / 2)); j++)
                            {
                                if (i <= (canvas.Width / zoom) - 1 && j <= (canvas.Height / zoom) - 1 && i >= 0 && j >= 0)
                                {
                                    if (GrayScale)
                                        pixelGray[i, j] = grayColor;
                                    else
                                        pixel[i, j] = color;
                                }
                            }
                        }
                    }
                    else if ((xAxis <= (canvas.Width / zoom) - 1 && yAxis <= (canvas.Height / zoom) - 1 && xAxis >= 0 && yAxis >= 0) && eraserOn)
                    {
                        if (GrayScale)
                            pixelGray[xAxis, yAxis] = eraserColor;
                        else
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
                if (!GrayScale)
                    myBrush.Color = Color.FromArgb(255, color);
                else
                    myBrush.Color = grayColor;
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
                            {
                                if (GrayScale)
                                    pixelGray[i, j] = grayColor;
                                else
                                    pixel[i, j] = color;
                            }
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
                            {
                                if (GrayScale)
                                    pixelGray[i, j] = grayColor;
                                else
                                    pixel[i, j] = color;
                            }
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
                            {
                                if (GrayScale)
                                    pixelGray[i, j] = grayColor;
                                else
                                    pixel[i, j] = color;
                            }
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
                            {
                                if (GrayScale)
                                    pixelGray[i, j] = grayColor;
                                else
                                    pixel[i, j] = color;
                            }
                        }
                    }
                }
                if (!GrayScale)
                {
                    var tempP = (Color[,])pixel.Clone();
                    undoNormal.Push(tempP);
                    undoButton.Enabled = true;
                }
            }
            cursorX = -1;
            cursorY = -1;
            if (GrayScale)
            {
                int temp = zoom;
                zoom = 1;
                using (var bitmap = new Bitmap(canvas.Width, canvas.Height))
                {
                    canvas.DrawToBitmap(bmpGray, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                    zoom = temp;
                    canvas.Size = new Size(zoom * x, zoom * y);
                    canvas.Location = new Point((panelCanvas.Size.Width - canvas.Width) / 2, (panelCanvas.Size.Height - canvas.Height) / 2);
                    canvas.Invalidate();
                }
            }
            if (opened && !GrayScale && (penOn || eraserOn)) 
            {
                var tempP = (Color[,])pixel.Clone();
                undoNormal.Push(tempP);
                undoButton.Enabled = true;
            }
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            if (file != null && !GrayScale) 
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
            if (file != null && GrayScale)
            {
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
                e.Graphics.DrawImage(bm, 0, 0, canvas.Width, canvas.Height);
                for (int i = 0; i < pixel.GetLength(0); i++)
                {
                    for (int j = 0; j < pixel.GetLength(1); j++)
                    {
                        if (!pixelGray[i, j].IsEmpty)
                        {
                            int xAxis = i;
                            int yAxis = j;
                            Point touch = new Point(xAxis * zoom, yAxis * zoom);
                            Color color = pixelGray[i, j];
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