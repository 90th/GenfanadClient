namespace GenfanadClient {
    partial class Client {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.TransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.siticoneAnimateWindow1 = new Siticone.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStrip,
            this.javaScriptToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1117, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshToolStrip
            // 
            this.refreshToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshToolStrip.ForeColor = System.Drawing.Color.GhostWhite;
            this.refreshToolStrip.Image = global::GenfanadClient.Properties.Resources.icons8_refresh_32;
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStrip.Size = new System.Drawing.Size(28, 20);
            this.refreshToolStrip.Text = "Refresh";
            this.refreshToolStrip.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.refreshToolStrip.ToolTipText = "Refresh.";
            this.refreshToolStrip.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // javaScriptToolStrip
            // 
            this.javaScriptToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.javaScriptToolStrip.ForeColor = System.Drawing.Color.GhostWhite;
            this.javaScriptToolStrip.Image = global::GenfanadClient.Properties.Resources.icons8_javascript_32;
            this.javaScriptToolStrip.Name = "javaScriptToolStrip";
            this.javaScriptToolStrip.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.javaScriptToolStrip.Size = new System.Drawing.Size(28, 20);
            this.javaScriptToolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.javaScriptToolStrip.ToolTipText = "Javascript executor";
            this.javaScriptToolStrip.Click += new System.EventHandler(this.JavaScriptToolStrip_Click);
            // 
            // ControlBox1
            // 
            this.ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ControlBox1.HoveredState.Parent = this.ControlBox1;
            this.ControlBox1.IconColor = System.Drawing.Color.White;
            this.ControlBox1.Location = new System.Drawing.Point(1095, -1);
            this.ControlBox1.Name = "ControlBox1";
            this.ControlBox1.PressedColor = System.Drawing.Color.IndianRed;
            this.ControlBox1.ShadowDecoration.Enabled = true;
            this.ControlBox1.ShadowDecoration.Parent = this.ControlBox1;
            this.ControlBox1.Size = new System.Drawing.Size(22, 24);
            this.ControlBox1.TabIndex = 2;
            this.ControlBox1.Click += new System.EventHandler(this.ControlBox1_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.SystemColors.Control;
            this.siticoneControlBox1.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1067, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedColor = System.Drawing.Color.IndianRed;
            this.siticoneControlBox1.ShadowDecoration.Enabled = true;
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(22, 24);
            this.siticoneControlBox1.TabIndex = 3;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.SystemColors.Control;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1039, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.PressedColor = System.Drawing.Color.IndianRed;
            this.siticoneControlBox2.ShadowDecoration.Enabled = true;
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(22, 24);
            this.siticoneControlBox2.TabIndex = 4;
            // 
            // TransparentDrag1
            // 
            this.TransparentDrag1.DragEndTransparencyValue = 1D;
            this.TransparentDrag1.DragStartTransparencyValue = 0.6D;
            this.TransparentDrag1.TargetDragControl = this.menuStrip1;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 24);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1117, 867);
            this.chromiumWebBrowser1.TabIndex = 5;
            // 
            // siticoneAnimateWindow1
            // 
            this.siticoneAnimateWindow1.AnimationType = Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_BLEND;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 891);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.ControlBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genfanad";
            this.Load += new System.EventHandler(this.Client_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStrip;
        private System.Windows.Forms.ToolStripMenuItem javaScriptToolStrip;
        private Siticone.UI.WinForms.SiticoneControlBox ControlBox1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneTransparentDrag TransparentDrag1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private Siticone.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
    }
}

