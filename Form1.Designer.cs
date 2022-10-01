
namespace Sah
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
            this.p = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deseneazaTablaSahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aseazaPionulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.Location = new System.Drawing.Point(12, 30);
            this.p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(667, 615);
            this.p.TabIndex = 0;
            this.p.TabStop = false;
            this.p.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Paint);
            this.p.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_MouseDown);
            this.p.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_MouseMove);
            this.p.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicatieToolStripMenuItem,
            this.instrumenteToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(684, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicatieToolStripMenuItem
            // 
            this.aplicatieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.aplicatieToolStripMenuItem.Name = "aplicatieToolStripMenuItem";
            this.aplicatieToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.aplicatieToolStripMenuItem.Text = "Aplicatie";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // instrumenteToolStripMenuItem
            // 
            this.instrumenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deseneazaTablaSahToolStripMenuItem,
            this.aseazaPionulToolStripMenuItem});
            this.instrumenteToolStripMenuItem.Name = "instrumenteToolStripMenuItem";
            this.instrumenteToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.instrumenteToolStripMenuItem.Text = "Instrumente";
            // 
            // deseneazaTablaSahToolStripMenuItem
            // 
            this.deseneazaTablaSahToolStripMenuItem.Name = "deseneazaTablaSahToolStripMenuItem";
            this.deseneazaTablaSahToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deseneazaTablaSahToolStripMenuItem.Text = "Joc nou";
            this.deseneazaTablaSahToolStripMenuItem.Click += new System.EventHandler(this.deseneazaTablaSahToolStripMenuItem_Click);
            // 
            // aseazaPionulToolStripMenuItem
            // 
            this.aseazaPionulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.hToolStripMenuItem});
            this.aseazaPionulToolStripMenuItem.Name = "aseazaPionulToolStripMenuItem";
            this.aseazaPionulToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aseazaPionulToolStripMenuItem.Text = "Aseaza pionul";
            this.aseazaPionulToolStripMenuItem.Click += new System.EventHandler(this.aseazaPionulToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem});
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gToolStripMenuItem.Text = "g";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hToolStripMenuItem.Text = "h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 654);
            this.Controls.Add(this.p);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sah";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deseneazaTablaSahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aseazaPionulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
    }
}

