
using System;

namespace RTX_Texture_Editor_for_Minecraft
{
    partial class Form1
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
            System.Windows.Forms.Button Eraser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Pen = new System.Windows.Forms.Button();
            this.sliderButtonPicE = new System.Windows.Forms.PictureBox();
            this.SliderM = new System.Windows.Forms.PictureBox();
            this.SliderR = new System.Windows.Forms.PictureBox();
            this.sliderButtonPicM = new System.Windows.Forms.PictureBox();
            this.sliderButtonPicR = new System.Windows.Forms.PictureBox();
            this.Rectangle = new System.Windows.Forms.Button();
            Eraser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SliderE)).BeginInit();
            this.panelCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicR)).BeginInit();
            this.SuspendLayout();
            // 
            // Eraser
            // 
            Eraser.Location = new System.Drawing.Point(12, 12);
            Eraser.Name = "Eraser";
            Eraser.Size = new System.Drawing.Size(88, 88);
            Eraser.TabIndex = 19;
            Eraser.Text = "Eraser";
            Eraser.UseVisualStyleBackColor = true;
            Eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // SliderE
            // 
            this.SliderE.BackColor = System.Drawing.Color.Transparent;
            this.SliderE.Location = new System.Drawing.Point(990, 12);
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
            this.fileOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileOpen.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileOpen.Location = new System.Drawing.Point(107, 618);
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
            // 
            // saveFile
            // 
            this.saveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFile.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveFile.Location = new System.Drawing.Point(411, 618);
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
            this.panelCanvas.Location = new System.Drawing.Point(108, 12);
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
            this.mVal.Location = new System.Drawing.Point(810, 638);
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
            this.eVal.Location = new System.Drawing.Point(980, 638);
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
            this.rVal.Location = new System.Drawing.Point(1150, 638);
            this.rVal.Name = "rVal";
            this.rVal.Size = new System.Drawing.Size(70, 30);
            this.rVal.TabIndex = 10;
            this.rVal.Text = "0";
            this.rVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(770, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "metalness";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(940, 681);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "emissive";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1110, 681);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "roughness";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(813, 721);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(1153, 721);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(983, 721);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // Pen
            // 
            this.Pen.Location = new System.Drawing.Point(12, 106);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(88, 88);
            this.Pen.TabIndex = 20;
            this.Pen.Text = "Pen";
            this.Pen.UseVisualStyleBackColor = true;
            this.Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // sliderButtonPicE
            // 
            this.sliderButtonPicE.Enabled = false;
            this.sliderButtonPicE.Image = ((System.Drawing.Image)(resources.GetObject("sliderButtonPicE.Image")));
            this.sliderButtonPicE.Location = new System.Drawing.Point(990, 591);
            this.sliderButtonPicE.Name = "sliderButtonPicE";
            this.sliderButtonPicE.Size = new System.Drawing.Size(50, 31);
            this.sliderButtonPicE.TabIndex = 21;
            this.sliderButtonPicE.TabStop = false;
            // 
            // SliderM
            // 
            this.SliderM.BackColor = System.Drawing.Color.Transparent;
            this.SliderM.Location = new System.Drawing.Point(820, 12);
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
            this.SliderR.Location = new System.Drawing.Point(1160, 12);
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
            this.sliderButtonPicM.Location = new System.Drawing.Point(820, 591);
            this.sliderButtonPicM.Name = "sliderButtonPicM";
            this.sliderButtonPicM.Size = new System.Drawing.Size(50, 31);
            this.sliderButtonPicM.TabIndex = 24;
            this.sliderButtonPicM.TabStop = false;
            // 
            // sliderButtonPicR
            // 
            this.sliderButtonPicR.Enabled = false;
            this.sliderButtonPicR.Image = ((System.Drawing.Image)(resources.GetObject("sliderButtonPicR.Image")));
            this.sliderButtonPicR.Location = new System.Drawing.Point(1160, 591);
            this.sliderButtonPicR.Name = "sliderButtonPicR";
            this.sliderButtonPicR.Size = new System.Drawing.Size(50, 31);
            this.sliderButtonPicR.TabIndex = 25;
            this.sliderButtonPicR.TabStop = false;
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(13, 201);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(87, 91);
            this.Rectangle.TabIndex = 26;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1319, 823);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.sliderButtonPicR);
            this.Controls.Add(this.sliderButtonPicM);
            this.Controls.Add(this.SliderR);
            this.Controls.Add(this.SliderM);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.sliderButtonPicE);
            this.Controls.Add(this.Pen);
            this.Controls.Add(Eraser);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rVal);
            this.Controls.Add(this.eVal);
            this.Controls.Add(this.mVal);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.fileOpen);
            this.Controls.Add(this.SliderE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SliderE)).EndInit();
            this.panelCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderButtonPicR)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Pen;
        private System.Windows.Forms.PictureBox sliderButtonPicE;
        private System.Windows.Forms.PictureBox SliderM;
        private System.Windows.Forms.PictureBox SliderR;
        private System.Windows.Forms.PictureBox sliderButtonPicM;
        private System.Windows.Forms.PictureBox sliderButtonPicR;
        private System.Windows.Forms.Button Rectangle;
    }
}

