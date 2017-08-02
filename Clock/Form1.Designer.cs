namespace Clock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.miFullSize = new System.Windows.Forms.ToolStripMenuItem();
            this.miMove = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.Label();
            this.miHide = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxMenu
            // 
            this.ctxMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ctxMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHide,
            this.miFullSize,
            this.miMove,
            this.miTransparent,
            this.miExit});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.ShowCheckMargin = true;
            this.ctxMenu.ShowImageMargin = false;
            this.ctxMenu.Size = new System.Drawing.Size(251, 187);
            // 
            // miTransparent
            // 
            this.miTransparent.CheckOnClick = true;
            this.miTransparent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miTransparent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miTransparent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miTransparent.Name = "miTransparent";
            this.miTransparent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.miTransparent.Size = new System.Drawing.Size(250, 30);
            this.miTransparent.Text = "Transparent";
            this.miTransparent.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.miTransparent.Click += new System.EventHandler(this.miTransparent_Click);
            // 
            // miFullSize
            // 
            this.miFullSize.CheckOnClick = true;
            this.miFullSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miFullSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miFullSize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miFullSize.Name = "miFullSize";
            this.miFullSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.miFullSize.Size = new System.Drawing.Size(250, 30);
            this.miFullSize.Text = "Full Size";
            this.miFullSize.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.miFullSize.Click += new System.EventHandler(this.miFullSize_Click);
            // 
            // miMove
            // 
            this.miMove.CheckOnClick = true;
            this.miMove.Name = "miMove";
            this.miMove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miMove.Size = new System.Drawing.Size(250, 30);
            this.miMove.Text = "Move";
            this.miMove.Click += new System.EventHandler(this.miMove_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.miExit.Size = new System.Drawing.Size(250, 30);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ContextMenuStrip = this.ctxMenu;
            this.lblTime.Font = new System.Drawing.Font("Courier New", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(12, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 60);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "t";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miHide
            // 
            this.miHide.Name = "miHide";
            this.miHide.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.miHide.Size = new System.Drawing.Size(250, 30);
            this.miHide.Text = "Hide";
            this.miHide.Click += new System.EventHandler(this.miHide_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(473, 70);
            this.ContextMenuStrip = this.ctxMenu;
            this.ControlBox = false;
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem miTransparent;
        private System.Windows.Forms.ToolStripMenuItem miFullSize;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miMove;
        private System.Windows.Forms.ToolStripMenuItem miHide;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

