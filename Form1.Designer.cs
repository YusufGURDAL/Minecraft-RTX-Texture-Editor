
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Slider = new System.Windows.Forms.PictureBox();
            this.fileOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metalnessTrackBar = new System.Windows.Forms.TrackBar();
            this.emissiveTrackBar = new System.Windows.Forms.TrackBar();
            this.roughnessTrackBar = new System.Windows.Forms.TrackBar();
            this.mVal = new System.Windows.Forms.Label();
            this.eVal = new System.Windows.Forms.Label();
            this.rVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.panelCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissiveTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roughnessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Slider
            // 
            resources.ApplyResources(this.Slider, "Slider");
            this.Slider.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Slider.Name = "Slider";
            this.Slider.TabStop = false;
            this.Slider.Paint += new System.Windows.Forms.PaintEventHandler(this.Slider_Paint);
            this.Slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseDown);
            this.Slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseMove);
            this.Slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slider_MouseUp);
            // 
            // fileOpen
            // 
            resources.ApplyResources(this.fileOpen, "fileOpen");
            this.fileOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.UseVisualStyleBackColor = true;
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFile
            // 
            resources.ApplyResources(this.saveFile, "saveFile");
            this.saveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFile.Name = "saveFile";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // panelCanvas
            // 
            resources.ApplyResources(this.panelCanvas, "panelCanvas");
            this.panelCanvas.BackColor = System.Drawing.Color.DimGray;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCanvas.Controls.Add(this.pictureBox1);
            this.panelCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelCanvas.Name = "panelCanvas";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metalnessTrackBar
            // 
            resources.ApplyResources(this.metalnessTrackBar, "metalnessTrackBar");
            this.metalnessTrackBar.LargeChange = 1;
            this.metalnessTrackBar.Maximum = 255;
            this.metalnessTrackBar.Name = "metalnessTrackBar";
            this.metalnessTrackBar.Scroll += new System.EventHandler(this.metalnessTrackBar_Scroll);
            // 
            // emissiveTrackBar
            // 
            resources.ApplyResources(this.emissiveTrackBar, "emissiveTrackBar");
            this.emissiveTrackBar.LargeChange = 1;
            this.emissiveTrackBar.Maximum = 255;
            this.emissiveTrackBar.Name = "emissiveTrackBar";
            this.emissiveTrackBar.Scroll += new System.EventHandler(this.emissiveTrackBar_Scroll);
            // 
            // roughnessTrackBar
            // 
            resources.ApplyResources(this.roughnessTrackBar, "roughnessTrackBar");
            this.roughnessTrackBar.LargeChange = 1;
            this.roughnessTrackBar.Maximum = 255;
            this.roughnessTrackBar.Name = "roughnessTrackBar";
            this.roughnessTrackBar.Scroll += new System.EventHandler(this.roughnessTrackBar_Scroll);
            // 
            // mVal
            // 
            resources.ApplyResources(this.mVal, "mVal");
            this.mVal.Name = "mVal";
            // 
            // eVal
            // 
            resources.ApplyResources(this.eVal, "eVal");
            this.eVal.Name = "eVal";
            // 
            // rVal
            // 
            resources.ApplyResources(this.rVal, "rVal");
            this.rVal.Name = "rVal";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rVal);
            this.Controls.Add(this.eVal);
            this.Controls.Add(this.mVal);
            this.Controls.Add(this.roughnessTrackBar);
            this.Controls.Add(this.emissiveTrackBar);
            this.Controls.Add(this.metalnessTrackBar);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.fileOpen);
            this.Controls.Add(this.Slider);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.panelCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissiveTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roughnessTrackBar)).EndInit();
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
        private System.Windows.Forms.TrackBar metalnessTrackBar;
        private System.Windows.Forms.TrackBar emissiveTrackBar;
        private System.Windows.Forms.TrackBar roughnessTrackBar;
        private System.Windows.Forms.Label mVal;
        private System.Windows.Forms.Label eVal;
        private System.Windows.Forms.Label rVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

