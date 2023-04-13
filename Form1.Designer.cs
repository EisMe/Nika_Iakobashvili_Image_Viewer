namespace Nika_Iakobashvili_Image_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxViewer = new System.Windows.Forms.GroupBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrevious = new System.Windows.Forms.PictureBox();
            this.pictureBoxCurrent = new System.Windows.Forms.PictureBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBoxImageControls = new System.Windows.Forms.GroupBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.labelDelay = new System.Windows.Forms.Label();
            this.labelLoop = new System.Windows.Forms.Label();
            this.groupBoxDirectories = new System.Windows.Forms.GroupBox();
            this.buttonDelDir = new System.Windows.Forms.Button();
            this.buttonAddDir = new System.Windows.Forms.Button();
            this.listBoxDirs = new System.Windows.Forms.ListBox();
            this.groupBoxImages = new System.Windows.Forms.GroupBox();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).BeginInit();
            this.groupBoxImageControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.groupBoxDirectories.SuspendLayout();
            this.groupBoxImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxViewer
            // 
            this.groupBoxViewer.Controls.Add(this.pictureBoxNext);
            this.groupBoxViewer.Controls.Add(this.pictureBoxPrevious);
            this.groupBoxViewer.Controls.Add(this.pictureBoxCurrent);
            this.groupBoxViewer.Controls.Add(this.buttonPrev);
            this.groupBoxViewer.Controls.Add(this.buttonNext);
            this.groupBoxViewer.Location = new System.Drawing.Point(320, 13);
            this.groupBoxViewer.Name = "groupBoxViewer";
            this.groupBoxViewer.Size = new System.Drawing.Size(952, 615);
            this.groupBoxViewer.TabIndex = 0;
            this.groupBoxViewer.TabStop = false;
            this.groupBoxViewer.Text = "Viewer";
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Location = new System.Drawing.Point(664, 464);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(282, 138);
            this.pictureBoxNext.TabIndex = 1;
            this.pictureBoxNext.TabStop = false;
            // 
            // pictureBoxPrevious
            // 
            this.pictureBoxPrevious.Location = new System.Drawing.Point(6, 465);
            this.pictureBoxPrevious.Name = "pictureBoxPrevious";
            this.pictureBoxPrevious.Size = new System.Drawing.Size(282, 138);
            this.pictureBoxPrevious.TabIndex = 1;
            this.pictureBoxPrevious.TabStop = false;
            // 
            // pictureBoxCurrent
            // 
            this.pictureBoxCurrent.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxCurrent.Name = "pictureBoxCurrent";
            this.pictureBoxCurrent.Size = new System.Drawing.Size(940, 440);
            this.pictureBoxCurrent.TabIndex = 0;
            this.pictureBoxCurrent.TabStop = false;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(294, 518);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(120, 40);
            this.buttonPrev.TabIndex = 0;
            this.buttonPrev.Text = "Previous";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(538, 518);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(120, 40);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // groupBoxImageControls
            // 
            this.groupBoxImageControls.Controls.Add(this.buttonStop);
            this.groupBoxImageControls.Controls.Add(this.checkBoxLoop);
            this.groupBoxImageControls.Controls.Add(this.buttonStart);
            this.groupBoxImageControls.Controls.Add(this.numericUpDownDelay);
            this.groupBoxImageControls.Controls.Add(this.labelDelay);
            this.groupBoxImageControls.Controls.Add(this.labelLoop);
            this.groupBoxImageControls.Location = new System.Drawing.Point(733, 634);
            this.groupBoxImageControls.Name = "groupBoxImageControls";
            this.groupBoxImageControls.Size = new System.Drawing.Size(539, 72);
            this.groupBoxImageControls.TabIndex = 1;
            this.groupBoxImageControls.TabStop = false;
            this.groupBoxImageControls.Text = "Controls";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(418, 30);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Location = new System.Drawing.Point(230, 35);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLoop.TabIndex = 3;
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(291, 30);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownDelay.Location = new System.Drawing.Point(49, 32);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDelay.TabIndex = 6;
            this.numericUpDownDelay.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(6, 35);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(37, 13);
            this.labelDelay.TabIndex = 4;
            this.labelDelay.Text = "Delay:";
            // 
            // labelLoop
            // 
            this.labelLoop.AutoSize = true;
            this.labelLoop.Location = new System.Drawing.Point(185, 35);
            this.labelLoop.Name = "labelLoop";
            this.labelLoop.Size = new System.Drawing.Size(34, 13);
            this.labelLoop.TabIndex = 5;
            this.labelLoop.Text = "Loop:";
            // 
            // groupBoxDirectories
            // 
            this.groupBoxDirectories.Controls.Add(this.buttonDelDir);
            this.groupBoxDirectories.Controls.Add(this.buttonAddDir);
            this.groupBoxDirectories.Controls.Add(this.listBoxDirs);
            this.groupBoxDirectories.Location = new System.Drawing.Point(12, 13);
            this.groupBoxDirectories.Name = "groupBoxDirectories";
            this.groupBoxDirectories.Size = new System.Drawing.Size(302, 328);
            this.groupBoxDirectories.TabIndex = 2;
            this.groupBoxDirectories.TabStop = false;
            this.groupBoxDirectories.Text = "Directories";
            // 
            // buttonDelDir
            // 
            this.buttonDelDir.Location = new System.Drawing.Point(176, 277);
            this.buttonDelDir.Name = "buttonDelDir";
            this.buttonDelDir.Size = new System.Drawing.Size(120, 41);
            this.buttonDelDir.TabIndex = 2;
            this.buttonDelDir.Text = "Delete";
            this.buttonDelDir.UseVisualStyleBackColor = true;
            this.buttonDelDir.Click += new System.EventHandler(this.buttonDelDir_Click);
            // 
            // buttonAddDir
            // 
            this.buttonAddDir.Location = new System.Drawing.Point(7, 277);
            this.buttonAddDir.Name = "buttonAddDir";
            this.buttonAddDir.Size = new System.Drawing.Size(120, 41);
            this.buttonAddDir.TabIndex = 1;
            this.buttonAddDir.Text = "Add";
            this.buttonAddDir.UseVisualStyleBackColor = true;
            this.buttonAddDir.Click += new System.EventHandler(this.buttonAddDir_Click);
            // 
            // listBoxDirs
            // 
            this.listBoxDirs.FormattingEnabled = true;
            this.listBoxDirs.Location = new System.Drawing.Point(7, 20);
            this.listBoxDirs.Name = "listBoxDirs";
            this.listBoxDirs.Size = new System.Drawing.Size(289, 251);
            this.listBoxDirs.TabIndex = 0;
            // 
            // groupBoxImages
            // 
            this.groupBoxImages.Controls.Add(this.listBoxImages);
            this.groupBoxImages.Location = new System.Drawing.Point(12, 347);
            this.groupBoxImages.Name = "groupBoxImages";
            this.groupBoxImages.Size = new System.Drawing.Size(302, 327);
            this.groupBoxImages.TabIndex = 3;
            this.groupBoxImages.TabStop = false;
            this.groupBoxImages.Text = "Images";
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.Location = new System.Drawing.Point(6, 19);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(290, 303);
            this.listBoxImages.TabIndex = 0;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(323, 634);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(35, 13);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 707);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.groupBoxImages);
            this.Controls.Add(this.groupBoxDirectories);
            this.Controls.Add(this.groupBoxImageControls);
            this.Controls.Add(this.groupBoxViewer);
            this.Name = "Form1";
            this.Text = "Nika\'s Image Viewer";
            this.Load += new System.EventHandler(this.Form1_Shown);
            this.groupBoxViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).EndInit();
            this.groupBoxImageControls.ResumeLayout(false);
            this.groupBoxImageControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.groupBoxDirectories.ResumeLayout(false);
            this.groupBoxImages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxViewer;
        private System.Windows.Forms.PictureBox pictureBoxCurrent;
        private System.Windows.Forms.PictureBox pictureBoxPrevious;
        private System.Windows.Forms.GroupBox groupBoxImageControls;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label labelLoop;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.GroupBox groupBoxDirectories;
        private System.Windows.Forms.GroupBox groupBoxImages;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ListBox listBoxDirs;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Button buttonDelDir;
        private System.Windows.Forms.Button buttonAddDir;
        private System.Windows.Forms.Label labelInfo;
    }
}

