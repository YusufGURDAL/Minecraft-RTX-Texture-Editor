
using System;

namespace RTX_Texture_Editor_for_Minecraft
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Eraser = new System.Windows.Forms.Button();
            this.SliderE = new System.Windows.Forms.PictureBox();
            this.fileOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.mVal = new System.Windows.Forms.Label();
            this.eVal = new System.Windows.Forms.Label();
            this.rVal = new System.Windows.Forms.Label();
            this.metalnessLabel = new System.Windows.Forms.Label();
            this.emissiveLabel = new System.Windows.Forms.Label();
            this.roughnessLabel = new System.Windows.Forms.Label();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.Pen = new System.Windows.Forms.Button();
            this.sliderButtonPicE = new System.Windows.Forms.PictureBox();
            this.SliderM = new System.Windows.Forms.PictureBox();
            this.SliderR = new System.Windows.Forms.PictureBox();
            this.sliderButtonPicM = new System.Windows.Forms.PictureBox();
            this.sliderButtonPicR = new System.Windows.Forms.PictureBox();
            this.Rectangle = new System.Windows.Forms.Button();
            this.canvasPanelFrame = new System.Windows.Forms.PictureBox();
            this.penSizeUp = new System.Windows.Forms.Button();
            this.penSizeDown = new System.Windows.Forms.Button();
            this.pen_size = new System.Windows.Forms.Label();
            this.buttonFrame = new System.Windows.Forms.PictureBox();
            this.EraserInside = new System.Windows.Forms.PictureBox();
            this.PenInside = new System.Windows.Forms.PictureBox();
            this.RectangleInside = new System.Windows.Forms.PictureBox();
            this.SelectedItem = new System.Windows.Forms.Label();
            this.grayScaleButton = new System.Windows.Forms.Button();
            this.sliderButtonPicG = new System.Windows.Forms.PictureBox();
            this.pictureBoxGray = new System.Windows.Forms.PictureBox();
            this.grayLabel = new System.Windows.Forms.Label();
            this.gVal = new System.Windows.Forms.Label();
            this.SliderG = new System.Windows.Forms.PictureBox();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.GrayScalePanel = new System.Windows.Forms.Panel();
            this.SaveLocButton = new System.Windows.Forms.Button();
            this.createTextureSet = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SliderE)).BeginInit();
            this.panelCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPanelFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserInside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenInside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleInside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderG)).BeginInit();
            this.ColorPanel.SuspendLayout();
            this.GrayScalePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Eraser
            // 
            this.Eraser.BackColor = System.Drawing.Color.Transparent;
            this.Eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eraser.BackgroundImage")));
            this.Eraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eraser.Location = new System.Drawing.Point(12, 12);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(80, 80);
            this.Eraser.TabIndex = 19;
            this.Eraser.UseVisualStyleBackColor = false;
            this.Eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // SliderE
            // 
            this.SliderE.BackColor = System.Drawing.Color.Transparent;
            this.SliderE.Location = new System.Drawing.Point(230, 0);
            this.SliderE.Name = "SliderE";
            this.SliderE.Size = new System.Drawing.Size(50, 610);
            this.SliderE.TabIndex = 0;
            this.SliderE.TabStop = false;
            this.SliderE.Paint += new System.Windows.Forms.PaintEventHandler(this.Slider_PaintE);
            this.SliderE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseDownE);
            this.SliderE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseMoveE);
            this.SliderE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseUpE);
            // 
            // fileOpen
            // 
            this.fileOpen.BackgroundImage = global::RTX_Texture_Editor_for_Minecraft.Properties.Resources._296x40_button;
            this.fileOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileOpen.FlatAppearance.BorderSize = 0;
            this.fileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileOpen.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileOpen.Location = new System.Drawing.Point(117, 638);
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(296, 40);
            this.fileOpen.TabIndex = 2;
            this.fileOpen.Text = "Open file";
            this.fileOpen.UseVisualStyleBackColor = true;
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "png files (*.png)|*.png";
            // 
            // saveFile
            // 
            this.saveFile.BackgroundImage = global::RTX_Texture_Editor_for_Minecraft.Properties.Resources._296x40_button;
            this.saveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFile.FlatAppearance.BorderSize = 0;
            this.saveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFile.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveFile.Location = new System.Drawing.Point(421, 638);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(296, 40);
            this.saveFile.TabIndex = 3;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // panelCanvas
            // 
            this.panelCanvas.AutoScroll = true;
            this.panelCanvas.BackColor = System.Drawing.Color.DimGray;
            this.panelCanvas.Controls.Add(this.canvas);
            this.panelCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelCanvas.Location = new System.Drawing.Point(117, 21);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(600, 600);
            this.panelCanvas.TabIndex = 4;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(200, 200);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(200, 200);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // mVal
            // 
            this.mVal.BackColor = System.Drawing.Color.Transparent;
            this.mVal.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mVal.ForeColor = System.Drawing.Color.White;
            this.mVal.Location = new System.Drawing.Point(50, 626);
            this.mVal.Name = "mVal";
            this.mVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mVal.Size = new System.Drawing.Size(70, 30);
            this.mVal.TabIndex = 8;
            this.mVal.Text = "0";
            this.mVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eVal
            // 
            this.eVal.BackColor = System.Drawing.Color.Transparent;
            this.eVal.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eVal.ForeColor = System.Drawing.Color.White;
            this.eVal.Location = new System.Drawing.Point(220, 626);
            this.eVal.Name = "eVal";
            this.eVal.Size = new System.Drawing.Size(70, 30);
            this.eVal.TabIndex = 9;
            this.eVal.Text = "0";
            this.eVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rVal
            // 
            this.rVal.BackColor = System.Drawing.Color.Transparent;
            this.rVal.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rVal.ForeColor = System.Drawing.Color.White;
            this.rVal.Location = new System.Drawing.Point(390, 626);
            this.rVal.Name = "rVal";
            this.rVal.Size = new System.Drawing.Size(70, 30);
            this.rVal.TabIndex = 10;
            this.rVal.Text = "0";
            this.rVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metalnessLabel
            // 
            this.metalnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.metalnessLabel.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metalnessLabel.ForeColor = System.Drawing.Color.White;
            this.metalnessLabel.Location = new System.Drawing.Point(10, 669);
            this.metalnessLabel.Name = "metalnessLabel";
            this.metalnessLabel.Size = new System.Drawing.Size(150, 26);
            this.metalnessLabel.TabIndex = 11;
            this.metalnessLabel.Text = "metalness";
            this.metalnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emissiveLabel
            // 
            this.emissiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.emissiveLabel.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emissiveLabel.ForeColor = System.Drawing.Color.White;
            this.emissiveLabel.Location = new System.Drawing.Point(180, 669);
            this.emissiveLabel.Name = "emissiveLabel";
            this.emissiveLabel.Size = new System.Drawing.Size(150, 26);
            this.emissiveLabel.TabIndex = 12;
            this.emissiveLabel.Text = "emissive";
            this.emissiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roughnessLabel
            // 
            this.roughnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.roughnessLabel.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roughnessLabel.ForeColor = System.Drawing.Color.White;
            this.roughnessLabel.Location = new System.Drawing.Point(350, 669);
            this.roughnessLabel.Name = "roughnessLabel";
            this.roughnessLabel.Size = new System.Drawing.Size(160, 26);
            this.roughnessLabel.TabIndex = 13;
            this.roughnessLabel.Text = "roughness";
            this.roughnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRed.Image")));
            this.pictureBoxRed.Location = new System.Drawing.Point(53, 709);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxRed.TabIndex = 15;
            this.pictureBoxRed.TabStop = false;
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBlue.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlue.Image")));
            this.pictureBoxBlue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxBlue.Location = new System.Drawing.Point(393, 709);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxBlue.TabIndex = 16;
            this.pictureBoxBlue.TabStop = false;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreen.Image")));
            this.pictureBoxGreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxGreen.Location = new System.Drawing.Point(223, 709);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxGreen.TabIndex = 17;
            this.pictureBoxGreen.TabStop = false;
            // 
            // Pen
            // 
            this.Pen.BackColor = System.Drawing.Color.Transparent;
            this.Pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pen.BackgroundImage")));
            this.Pen.FlatAppearance.BorderSize = 0;
            this.Pen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pen.Location = new System.Drawing.Point(12, 106);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(80, 80);
            this.Pen.TabIndex = 20;
            this.Pen.UseVisualStyleBackColor = false;
            this.Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // sliderButtonPicE
            // 
            this.sliderButtonPicE.Enabled = false;
            this.sliderButtonPicE.Image = ((System.Drawing.Image)(resources.GetObject("sliderButtonPicE.Image")));
            this.sliderButtonPicE.Location = new System.Drawing.Point(230, 579);
            this.sliderButtonPicE.Name = "sliderButtonPicE";
            this.sliderButtonPicE.Size = new System.Drawing.Size(50, 31);
            this.sliderButtonPicE.TabIndex = 21;
            this.sliderButtonPicE.TabStop = false;
            // 
            // SliderM
            // 
            this.SliderM.BackColor = System.Drawing.Color.Transparent;
            this.SliderM.Location = new System.Drawing.Point(60, 0);
            this.SliderM.Name = "SliderM";
            this.SliderM.Size = new System.Drawing.Size(50, 610);
            this.SliderM.TabIndex = 22;
            this.SliderM.TabStop = false;
            this.SliderM.Paint += new System.Windows.Forms.PaintEventHandler(this.Slider_PaintM);
            this.SliderM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseDownM);
            this.SliderM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseMoveM);
            this.SliderM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseUpM);
            // 
            // SliderR
            // 
            this.SliderR.BackColor = System.Drawing.Color.Transparent;
            this.SliderR.Location = new System.Drawing.Point(400, 0);
            this.SliderR.Name = "SliderR";
            this.SliderR.Size = new System.Drawing.Size(50, 610);
            this.SliderR.TabIndex = 23;
            this.SliderR.TabStop = false;
            this.SliderR.Paint += new System.Windows.Forms.PaintEventHandler(this.Slider_PaintR);
            this.SliderR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseDownR);
            this.SliderR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseMoveR);
            this.SliderR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseUpR);
            // 
            // sliderButtonPicM
            // 
            this.sliderButtonPicM.Enabled = false;
            this.sliderButtonPicM.Image = ((System.Drawing.Image)(resources.GetObject("sliderButtonPicM.Image")));
            this.sliderButtonPicM.Location = new System.Drawing.Point(60, 579);
            this.sliderButtonPicM.Name = "sliderButtonPicM";
            this.sliderButtonPicM.Size = new System.Drawing.Size(50, 31);
            this.sliderButtonPicM.TabIndex = 24;
            this.sliderButtonPicM.TabStop = false;
            // 
            // sliderButtonPicR
            // 
            this.sliderButtonPicR.Enabled = false;
            this.sliderButtonPicR.Image = ((System.Drawing.Image)(resources.GetObject("sliderButtonPicR.Image")));
            this.sliderButtonPicR.Location = new System.Drawing.Point(400, 579);
            this.sliderButtonPicR.Name = "sliderButtonPicR";
            this.sliderButtonPicR.Size = new System.Drawing.Size(50, 31);
            this.sliderButtonPicR.TabIndex = 25;
            this.sliderButtonPicR.TabStop = false;
            // 
            // Rectangle
            // 
            this.Rectangle.BackColor = System.Drawing.Color.Transparent;
            this.Rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rectangle.BackgroundImage")));
            this.Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rectangle.Location = new System.Drawing.Point(12, 200);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(80, 80);
            this.Rectangle.TabIndex = 26;
            this.Rectangle.UseVisualStyleBackColor = false;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // canvasPanelFrame
            // 
            this.canvasPanelFrame.BackColor = System.Drawing.Color.Transparent;
            this.canvasPanelFrame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("canvasPanelFrame.BackgroundImage")));
            this.canvasPanelFrame.Location = new System.Drawing.Point(108, 12);
            this.canvasPanelFrame.Name = "canvasPanelFrame";
            this.canvasPanelFrame.Size = new System.Drawing.Size(618, 618);
            this.canvasPanelFrame.TabIndex = 27;
            this.canvasPanelFrame.TabStop = false;
            // 
            // penSizeUp
            // 
            this.penSizeUp.BackgroundImage = global::RTX_Texture_Editor_for_Minecraft.Properties.Resources._88x35_button;
            this.penSizeUp.FlatAppearance.BorderSize = 0;
            this.penSizeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penSizeUp.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.penSizeUp.Location = new System.Drawing.Point(12, 452);
            this.penSizeUp.Name = "penSizeUp";
            this.penSizeUp.Size = new System.Drawing.Size(88, 35);
            this.penSizeUp.TabIndex = 28;
            this.penSizeUp.Text = "+";
            this.penSizeUp.UseVisualStyleBackColor = true;
            this.penSizeUp.Click += new System.EventHandler(this.penSizeUp_Click);
            // 
            // penSizeDown
            // 
            this.penSizeDown.BackgroundImage = global::RTX_Texture_Editor_for_Minecraft.Properties.Resources._88x35_button;
            this.penSizeDown.FlatAppearance.BorderSize = 0;
            this.penSizeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penSizeDown.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.penSizeDown.Location = new System.Drawing.Point(12, 593);
            this.penSizeDown.Name = "penSizeDown";
            this.penSizeDown.Size = new System.Drawing.Size(88, 35);
            this.penSizeDown.TabIndex = 29;
            this.penSizeDown.Text = "-";
            this.penSizeDown.UseVisualStyleBackColor = true;
            this.penSizeDown.Click += new System.EventHandler(this.penSizeDown_Click);
            // 
            // pen_size
            // 
            this.pen_size.BackColor = System.Drawing.Color.Transparent;
            this.pen_size.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pen_size.ForeColor = System.Drawing.Color.White;
            this.pen_size.Location = new System.Drawing.Point(12, 492);
            this.pen_size.Name = "pen_size";
            this.pen_size.Size = new System.Drawing.Size(88, 98);
            this.pen_size.TabIndex = 30;
            this.pen_size.Text = "Pen\r\nsize:\r\n1\r\npixel";
            this.pen_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFrame
            // 
            this.buttonFrame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFrame.BackgroundImage")));
            this.buttonFrame.Enabled = false;
            this.buttonFrame.Location = new System.Drawing.Point(8, 102);
            this.buttonFrame.Name = "buttonFrame";
            this.buttonFrame.Size = new System.Drawing.Size(88, 88);
            this.buttonFrame.TabIndex = 31;
            this.buttonFrame.TabStop = false;
            // 
            // EraserInside
            // 
            this.EraserInside.BackColor = System.Drawing.Color.Transparent;
            this.EraserInside.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EraserInside.BackgroundImage")));
            this.EraserInside.Enabled = false;
            this.EraserInside.Location = new System.Drawing.Point(20, 20);
            this.EraserInside.Name = "EraserInside";
            this.EraserInside.Size = new System.Drawing.Size(64, 64);
            this.EraserInside.TabIndex = 32;
            this.EraserInside.TabStop = false;
            // 
            // PenInside
            // 
            this.PenInside.BackColor = System.Drawing.Color.Transparent;
            this.PenInside.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PenInside.BackgroundImage")));
            this.PenInside.Enabled = false;
            this.PenInside.Location = new System.Drawing.Point(20, 114);
            this.PenInside.Name = "PenInside";
            this.PenInside.Size = new System.Drawing.Size(64, 64);
            this.PenInside.TabIndex = 33;
            this.PenInside.TabStop = false;
            // 
            // RectangleInside
            // 
            this.RectangleInside.BackColor = System.Drawing.Color.Transparent;
            this.RectangleInside.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RectangleInside.BackgroundImage")));
            this.RectangleInside.Enabled = false;
            this.RectangleInside.Location = new System.Drawing.Point(20, 208);
            this.RectangleInside.Name = "RectangleInside";
            this.RectangleInside.Size = new System.Drawing.Size(64, 64);
            this.RectangleInside.TabIndex = 34;
            this.RectangleInside.TabStop = false;
            // 
            // SelectedItem
            // 
            this.SelectedItem.BackColor = System.Drawing.Color.Transparent;
            this.SelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectedItem.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedItem.ForeColor = System.Drawing.Color.White;
            this.SelectedItem.Location = new System.Drawing.Point(117, 747);
            this.SelectedItem.Name = "SelectedItem";
            this.SelectedItem.Size = new System.Drawing.Size(600, 40);
            this.SelectedItem.TabIndex = 35;
            this.SelectedItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grayScaleButton
            // 
            this.grayScaleButton.BackColor = System.Drawing.SystemColors.Control;
            this.grayScaleButton.BackgroundImage = global::RTX_Texture_Editor_for_Minecraft.Properties.Resources._88x160_button;
            this.grayScaleButton.FlatAppearance.BorderSize = 0;
            this.grayScaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayScaleButton.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grayScaleButton.Location = new System.Drawing.Point(12, 286);
            this.grayScaleButton.Name = "grayScaleButton";
            this.grayScaleButton.Size = new System.Drawing.Size(88, 160);
            this.grayScaleButton.TabIndex = 37;
            this.grayScaleButton.Text = "Gray Scale: OFF";
            this.grayScaleButton.UseVisualStyleBackColor = false;
            this.grayScaleButton.Click += new System.EventHandler(this.grayScaleButton_Click);
            // 
            // sliderButtonPicG
            // 
            this.sliderButtonPicG.Enabled = false;
            this.sliderButtonPicG.Image = ((System.Drawing.Image)(resources.GetObject("sliderButtonPicG.Image")));
            this.sliderButtonPicG.Location = new System.Drawing.Point(71, 579);
            this.sliderButtonPicG.Name = "sliderButtonPicG";
            this.sliderButtonPicG.Size = new System.Drawing.Size(50, 31);
            this.sliderButtonPicG.TabIndex = 42;
            this.sliderButtonPicG.TabStop = false;
            // 
            // pictureBoxGray
            // 
            this.pictureBoxGray.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGray.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGray.Image")));
            this.pictureBoxGray.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxGray.Location = new System.Drawing.Point(64, 709);
            this.pictureBoxGray.Name = "pictureBoxGray";
            this.pictureBoxGray.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxGray.TabIndex = 41;
            this.pictureBoxGray.TabStop = false;
            // 
            // grayLabel
            // 
            this.grayLabel.BackColor = System.Drawing.Color.Transparent;
            this.grayLabel.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grayLabel.ForeColor = System.Drawing.Color.White;
            this.grayLabel.Location = new System.Drawing.Point(21, 669);
            this.grayLabel.Name = "grayLabel";
            this.grayLabel.Size = new System.Drawing.Size(150, 26);
            this.grayLabel.TabIndex = 40;
            this.grayLabel.Text = "height";
            this.grayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gVal
            // 
            this.gVal.BackColor = System.Drawing.Color.Transparent;
            this.gVal.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gVal.ForeColor = System.Drawing.Color.White;
            this.gVal.Location = new System.Drawing.Point(61, 626);
            this.gVal.Name = "gVal";
            this.gVal.Size = new System.Drawing.Size(70, 30);
            this.gVal.TabIndex = 39;
            this.gVal.Text = "0";
            this.gVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SliderG
            // 
            this.SliderG.BackColor = System.Drawing.Color.Transparent;
            this.SliderG.Location = new System.Drawing.Point(71, 0);
            this.SliderG.Name = "SliderG";
            this.SliderG.Size = new System.Drawing.Size(50, 610);
            this.SliderG.TabIndex = 38;
            this.SliderG.TabStop = false;
            this.SliderG.Paint += new System.Windows.Forms.PaintEventHandler(this.Slider_PaintG);
            this.SliderG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseDownG);
            this.SliderG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseMoveG);
            this.SliderG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseUpG);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.Transparent;
            this.ColorPanel.Controls.Add(this.pictureBoxGreen);
            this.ColorPanel.Controls.Add(this.mVal);
            this.ColorPanel.Controls.Add(this.sliderButtonPicR);
            this.ColorPanel.Controls.Add(this.pictureBoxBlue);
            this.ColorPanel.Controls.Add(this.sliderButtonPicM);
            this.ColorPanel.Controls.Add(this.sliderButtonPicE);
            this.ColorPanel.Controls.Add(this.eVal);
            this.ColorPanel.Controls.Add(this.pictureBoxRed);
            this.ColorPanel.Controls.Add(this.rVal);
            this.ColorPanel.Controls.Add(this.roughnessLabel);
            this.ColorPanel.Controls.Add(this.metalnessLabel);
            this.ColorPanel.Controls.Add(this.emissiveLabel);
            this.ColorPanel.Controls.Add(this.SliderM);
            this.ColorPanel.Controls.Add(this.SliderE);
            this.ColorPanel.Controls.Add(this.SliderR);
            this.ColorPanel.Location = new System.Drawing.Point(760, 12);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(537, 796);
            this.ColorPanel.TabIndex = 43;
            // 
            // GrayScalePanel
            // 
            this.GrayScalePanel.BackColor = System.Drawing.Color.Transparent;
            this.GrayScalePanel.Controls.Add(this.sliderButtonPicG);
            this.GrayScalePanel.Controls.Add(this.SliderG);
            this.GrayScalePanel.Controls.Add(this.grayLabel);
            this.GrayScalePanel.Controls.Add(this.gVal);
            this.GrayScalePanel.Controls.Add(this.pictureBoxGray);
            this.GrayScalePanel.Location = new System.Drawing.Point(837, 12);
            this.GrayScalePanel.Name = "GrayScalePanel";
            this.GrayScalePanel.Size = new System.Drawing.Size(192, 796);
            this.GrayScalePanel.TabIndex = 26;
            // 
            // SaveLocButton
            // 
            this.SaveLocButton.BackgroundImage = global::RTX_Texture_Editor_for_Minecraft.Properties.Resources._88x81_button;
            this.SaveLocButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveLocButton.FlatAppearance.BorderSize = 0;
            this.SaveLocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLocButton.Font = new System.Drawing.Font("Minecraft", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveLocButton.Location = new System.Drawing.Point(12, 685);
            this.SaveLocButton.Name = "SaveLocButton";
            this.SaveLocButton.Size = new System.Drawing.Size(88, 81);
            this.SaveLocButton.TabIndex = 44;
            this.SaveLocButton.Text = "Select a folder";
            this.SaveLocButton.UseVisualStyleBackColor = true;
            this.SaveLocButton.Click += new System.EventHandler(this.SaveLocButton_Click);
            // 
            // createTextureSet
            // 
            this.createTextureSet.BackgroundImage = global::RTX_Texture_Editor_for_Minecraft.Properties.Resources._600x40_button;
            this.createTextureSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTextureSet.FlatAppearance.BorderSize = 0;
            this.createTextureSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTextureSet.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTextureSet.Location = new System.Drawing.Point(117, 685);
            this.createTextureSet.Name = "createTextureSet";
            this.createTextureSet.Size = new System.Drawing.Size(600, 40);
            this.createTextureSet.TabIndex = 45;
            this.createTextureSet.Text = "Create .json file";
            this.createTextureSet.UseVisualStyleBackColor = true;
            this.createTextureSet.Click += new System.EventHandler(this.createTextureSet_Click);
            // 
            // undoButton
            // 
            this.undoButton.BackgroundImage = global::RTX_Texture_Editor_for_Minecraft.Properties.Resources._42x35_button;
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.undoButton.Location = new System.Drawing.Point(12, 639);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(42, 35);
            this.undoButton.TabIndex = 46;
            this.undoButton.Text = "<";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.BackgroundImage = global::RTX_Texture_Editor_for_Minecraft.Properties.Resources._42x35_button;
            this.redoButton.FlatAppearance.BorderSize = 0;
            this.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoButton.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.redoButton.Location = new System.Drawing.Point(58, 639);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(42, 35);
            this.redoButton.TabIndex = 47;
            this.redoButton.Text = ">";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1319, 823);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.createTextureSet);
            this.Controls.Add(this.SaveLocButton);
            this.Controls.Add(this.grayScaleButton);
            this.Controls.Add(this.SelectedItem);
            this.Controls.Add(this.RectangleInside);
            this.Controls.Add(this.PenInside);
            this.Controls.Add(this.EraserInside);
            this.Controls.Add(this.buttonFrame);
            this.Controls.Add(this.pen_size);
            this.Controls.Add(this.penSizeDown);
            this.Controls.Add(this.penSizeUp);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Pen);
            this.Controls.Add(this.Eraser);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.fileOpen);
            this.Controls.Add(this.canvasPanelFrame);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.GrayScalePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form";
            this.Text = "RTX Texture Editor for Minecraft - Version Beta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SliderE)).EndInit();
            this.panelCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPanelFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserInside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenInside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleInside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderG)).EndInit();
            this.ColorPanel.ResumeLayout(false);
            this.GrayScalePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.PictureBox SliderE;
        private System.Windows.Forms.Button fileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label mVal;
        private System.Windows.Forms.Label eVal;
        private System.Windows.Forms.Label rVal;
        private System.Windows.Forms.Label metalnessLabel;
        private System.Windows.Forms.Label emissiveLabel;
        private System.Windows.Forms.Label roughnessLabel;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.Button Pen;
        private System.Windows.Forms.PictureBox sliderButtonPicE;
        private System.Windows.Forms.PictureBox SliderM;
        private System.Windows.Forms.PictureBox SliderR;
        private System.Windows.Forms.PictureBox sliderButtonPicM;
        private System.Windows.Forms.PictureBox sliderButtonPicR;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.PictureBox canvasPanelFrame;
        private System.Windows.Forms.Button penSizeUp;
        private System.Windows.Forms.Button penSizeDown;
        private System.Windows.Forms.Label pen_size;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.PictureBox RectangleInside;
        private System.Windows.Forms.PictureBox buttonFrame;
        private System.Windows.Forms.PictureBox EraserInside;
        private System.Windows.Forms.PictureBox PenInside;
        private System.Windows.Forms.Label SelectedItem;
        private System.Windows.Forms.Button grayScaleButton;
        private System.Windows.Forms.PictureBox sliderButtonPicG;
        private System.Windows.Forms.PictureBox pictureBoxGray;
        private System.Windows.Forms.Label grayLabel;
        private System.Windows.Forms.Label gVal;
        private System.Windows.Forms.PictureBox SliderG;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Panel GrayScalePanel;
        private System.Windows.Forms.Button SaveLocButton;
        private System.Windows.Forms.Button createTextureSet;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
    }
}

