
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
            this.Slider = new System.Windows.Forms.PictureBox();
            this.fileOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.panelCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Slider.Location = new System.Drawing.Point(787, 43);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(30, 450);
            this.Slider.TabIndex = 0;
            this.Slider.TabStop = false;
            this.Slider.Paint += new System.Windows.Forms.PaintEventHandler(this.Slider_Paint);
            this.Slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseDown);
            this.Slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseMove);
            this.Slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseUp);
            // 
            // fileOpen
            // 
            this.fileOpen.Location = new System.Drawing.Point(13, 619);
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(209, 40);
            this.fileOpen.TabIndex = 2;
            this.fileOpen.Text = "Dosya aç";
            this.fileOpen.UseVisualStyleBackColor = true;
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(229, 619);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(186, 40);
            this.saveFile.TabIndex = 3;
            this.saveFile.Text = "Kaydet";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.DimGray;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCanvas.Controls.Add(this.pictureBox1);
            this.panelCanvas.Location = new System.Drawing.Point(12, 12);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(600, 600);
            this.panelCanvas.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(200, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(793, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.fileOpen);
            this.Controls.Add(this.Slider);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.panelCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.PictureBox Slider;
        private System.Windows.Forms.Button fileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

