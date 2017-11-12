namespace MyPhotos
{
    partial class AboutBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.lblAboutText = new System.Windows.Forms.Label();
            this.lnkWebSite = new System.Windows.Forms.LinkLabel();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlWebSite = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.lblIcon = new System.Windows.Forms.Label();
            this.pnlWebSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Book_Green.ico");
            this.imageIcons.Images.SetKeyName(1, "camera.ico");
            // 
            // lblAboutText
            // 
            this.lblAboutText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAboutText.Location = new System.Drawing.Point(62, 13);
            this.lblAboutText.Name = "lblAboutText";
            this.lblAboutText.Size = new System.Drawing.Size(310, 42);
            this.lblAboutText.TabIndex = 1;
            this.lblAboutText.Text = "MyPhotos";
            // 
            // lnkWebSite
            // 
            this.lnkWebSite.AutoSize = true;
            this.lnkWebSite.Location = new System.Drawing.Point(12, 64);
            this.lnkWebSite.Name = "lnkWebSite";
            this.lnkWebSite.Size = new System.Drawing.Size(118, 13);
            this.lnkWebSite.TabIndex = 2;
            this.lnkWebSite.TabStop = true;
            this.lnkWebSite.Text = "Click for book\'s website";
            this.lnkWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWebSite_LinkClicked);
            // 
            // lnkClose
            // 
            this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClose.AutoSize = true;
            this.lnkClose.Location = new System.Drawing.Point(263, 64);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(109, 13);
            this.lnkClose.TabIndex = 3;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "Click to close window";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-145, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 40);
            this.panel1.TabIndex = 4;
            // 
            // pnlWebSite
            // 
            this.pnlWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWebSite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWebSite.Controls.Add(this.webBrowser);
            this.pnlWebSite.Location = new System.Drawing.Point(12, 80);
            this.pnlWebSite.Name = "pnlWebSite";
            this.pnlWebSite.Size = new System.Drawing.Size(360, 23);
            this.pnlWebSite.TabIndex = 5;
            this.pnlWebSite.Visible = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(356, 20);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // lblIcon
            // 
            this.lblIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIcon.ImageIndex = 0;
            this.lblIcon.ImageList = this.imageIcons;
            this.lblIcon.Location = new System.Drawing.Point(12, 9);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(44, 46);
            this.lblIcon.TabIndex = 0;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 106);
            this.Controls.Add(this.pnlWebSite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.lnkWebSite);
            this.Controls.Add(this.lblAboutText);
            this.Controls.Add(this.lblIcon);
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About MyPhotos";
            this.pnlWebSite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblAboutText;
        private System.Windows.Forms.LinkLabel lnkWebSite;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlWebSite;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}