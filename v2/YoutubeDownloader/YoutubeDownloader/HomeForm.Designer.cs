
namespace YoutubeDownloader
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.minimizedButton = new System.Windows.Forms.Button();
            this.resizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.videoTitleTextBox = new System.Windows.Forms.TextBox();
            this.errLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.audioRadioButton = new ReaLTaiizor.Controls.ParrotRadioButton();
            this.videoRadioButton = new ReaLTaiizor.Controls.ParrotRadioButton();
            this.youtubeLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.footerCreditLabel = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.fillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeLogoPictureBox)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.headerPanel.Controls.Add(this.minimizedButton);
            this.headerPanel.Controls.Add(this.resizeButton);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Controls.Add(this.headerTitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1196, 69);
            this.headerPanel.TabIndex = 0;
            // 
            // minimizedButton
            // 
            this.minimizedButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizedButton.FlatAppearance.BorderSize = 0;
            this.minimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizedButton.Location = new System.Drawing.Point(1025, 0);
            this.minimizedButton.Name = "minimizedButton";
            this.minimizedButton.Size = new System.Drawing.Size(57, 69);
            this.minimizedButton.TabIndex = 2;
            this.minimizedButton.Text = "–";
            this.minimizedButton.UseVisualStyleBackColor = true;
            this.minimizedButton.Click += new System.EventHandler(this.minimizedButton_Click);
            // 
            // resizeButton
            // 
            this.resizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeButton.FlatAppearance.BorderSize = 0;
            this.resizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resizeButton.Location = new System.Drawing.Point(1082, 0);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(57, 69);
            this.resizeButton.TabIndex = 1;
            this.resizeButton.Text = "◻";
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(1139, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(57, 69);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "❌";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.headerTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.headerTitleLabel.Name = "headerTitleLabel";
            this.headerTitleLabel.Size = new System.Drawing.Size(1196, 69);
            this.headerTitleLabel.TabIndex = 0;
            this.headerTitleLabel.Text = "Youtube Downloader";
            this.headerTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerTitleLabel.DoubleClick += new System.EventHandler(this.resizeButton_Click);
            this.headerTitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerTitleLabel_MouseMove);
            // 
            // fillPanel
            // 
            this.fillPanel.BackColor = System.Drawing.SystemColors.Control;
            this.fillPanel.Controls.Add(this.titleLabel);
            this.fillPanel.Controls.Add(this.videoTitleTextBox);
            this.fillPanel.Controls.Add(this.errLabel);
            this.fillPanel.Controls.Add(this.downloadButton);
            this.fillPanel.Controls.Add(this.label1);
            this.fillPanel.Controls.Add(this.linkTextBox);
            this.fillPanel.Controls.Add(this.audioRadioButton);
            this.fillPanel.Controls.Add(this.videoRadioButton);
            this.fillPanel.Controls.Add(this.youtubeLogoPictureBox);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.ForeColor = System.Drawing.Color.White;
            this.fillPanel.Location = new System.Drawing.Point(0, 69);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(1196, 668);
            this.fillPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.titleLabel.Location = new System.Drawing.Point(552, 346);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(90, 23);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "File Name:";
            // 
            // videoTitleTextBox
            // 
            this.videoTitleTextBox.Location = new System.Drawing.Point(223, 372);
            this.videoTitleTextBox.Name = "videoTitleTextBox";
            this.videoTitleTextBox.Size = new System.Drawing.Size(750, 27);
            this.videoTitleTextBox.TabIndex = 7;
            this.videoTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errLabel.ForeColor = System.Drawing.Color.Red;
            this.errLabel.Location = new System.Drawing.Point(531, 571);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(106, 28);
            this.errLabel.TabIndex = 6;
            this.errLabel.Text = "Error Label";
            this.errLabel.Visible = false;
            // 
            // downloadButton
            // 
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downloadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.downloadButton.Location = new System.Drawing.Point(531, 487);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(133, 69);
            this.downloadButton.TabIndex = 5;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(575, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Link:";
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(223, 453);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(750, 27);
            this.linkTextBox.TabIndex = 3;
            this.linkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // audioRadioButton
            // 
            this.audioRadioButton.Checked = false;
            this.audioRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audioRadioButton.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.audioRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.audioRadioButton.Location = new System.Drawing.Point(552, 308);
            this.audioRadioButton.Name = "audioRadioButton";
            this.audioRadioButton.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.audioRadioButton.RadioColor = System.Drawing.Color.Red;
            this.audioRadioButton.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.audioRadioButton.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            this.audioRadioButton.Size = new System.Drawing.Size(125, 20);
            this.audioRadioButton.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.audioRadioButton.TabIndex = 2;
            this.audioRadioButton.Text = "Audio";
            this.audioRadioButton.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // videoRadioButton
            // 
            this.videoRadioButton.Checked = false;
            this.videoRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoRadioButton.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.videoRadioButton.Location = new System.Drawing.Point(552, 270);
            this.videoRadioButton.Name = "videoRadioButton";
            this.videoRadioButton.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.videoRadioButton.RadioColor = System.Drawing.Color.Red;
            this.videoRadioButton.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.videoRadioButton.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            this.videoRadioButton.Size = new System.Drawing.Size(125, 20);
            this.videoRadioButton.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.videoRadioButton.TabIndex = 1;
            this.videoRadioButton.Text = "Video";
            this.videoRadioButton.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // youtubeLogoPictureBox
            // 
            this.youtubeLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("youtubeLogoPictureBox.Image")));
            this.youtubeLogoPictureBox.Location = new System.Drawing.Point(381, 28);
            this.youtubeLogoPictureBox.Name = "youtubeLogoPictureBox";
            this.youtubeLogoPictureBox.Size = new System.Drawing.Size(428, 182);
            this.youtubeLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.youtubeLogoPictureBox.TabIndex = 0;
            this.youtubeLogoPictureBox.TabStop = false;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.footerPanel.Controls.Add(this.footerCreditLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.footerPanel.Location = new System.Drawing.Point(0, 737);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1196, 59);
            this.footerPanel.TabIndex = 2;
            // 
            // footerCreditLabel
            // 
            this.footerCreditLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerCreditLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.footerCreditLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.footerCreditLabel.Location = new System.Drawing.Point(0, 0);
            this.footerCreditLabel.Name = "footerCreditLabel";
            this.footerCreditLabel.Size = new System.Drawing.Size(1196, 59);
            this.footerCreditLabel.TabIndex = 1;
            this.footerCreditLabel.Text = "Created by Simone Zoppelletto";
            this.footerCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.SystemColors.Control;
            this.formPanel.Controls.Add(this.fillPanel);
            this.formPanel.Controls.Add(this.headerPanel);
            this.formPanel.Controls.Add(this.footerPanel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(2, 2);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1196, 796);
            this.formPanel.TabIndex = 3;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.formPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "sssss";
            this.headerPanel.ResumeLayout(false);
            this.fillPanel.ResumeLayout(false);
            this.fillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeLogoPictureBox)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button minimizedButton;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label headerTitleLabel;
        private System.Windows.Forms.PictureBox youtubeLogoPictureBox;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label footerCreditLabel;
        private ReaLTaiizor.Controls.ParrotRadioButton audioRadioButton;
        private ReaLTaiizor.Controls.ParrotRadioButton videoRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox videoTitleTextBox;
    }
}

