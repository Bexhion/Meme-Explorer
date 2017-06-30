namespace Meme_explorer
{
    partial class MainFrame
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
            this.TopExplorer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonMinimize = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Label();
            this.TabNavigator = new System.Windows.Forms.Panel();
            this.DateNavigator = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopExplorer
            // 
            this.TopExplorer.BackColor = System.Drawing.Color.Transparent;
            this.TopExplorer.Controls.Add(this.label1);
            this.TopExplorer.Controls.Add(this.ButtonMinimize);
            this.TopExplorer.Controls.Add(this.ButtonClose);
            this.TopExplorer.Controls.Add(this.TabNavigator);
            this.TopExplorer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopExplorer.Location = new System.Drawing.Point(0, 0);
            this.TopExplorer.Margin = new System.Windows.Forms.Padding(0);
            this.TopExplorer.Name = "TopExplorer";
            this.TopExplorer.Size = new System.Drawing.Size(900, 80);
            this.TopExplorer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meme explorer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.Location = new System.Drawing.Point(836, 0);
            this.ButtonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(32, 30);
            this.ButtonMinimize.TabIndex = 0;
            this.ButtonMinimize.Text = "_";
            this.ButtonMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonClose.Location = new System.Drawing.Point(868, 0);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(32, 30);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "×";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabNavigator
            // 
            this.TabNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabNavigator.ForeColor = System.Drawing.Color.White;
            this.TabNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabNavigator.Location = new System.Drawing.Point(0, 30);
            this.TabNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.TabNavigator.Name = "TabNavigator";
            this.TabNavigator.Size = new System.Drawing.Size(900, 50);
            this.TabNavigator.TabIndex = 0;
            // 
            // DateNavigator
            // 
            this.DateNavigator.BackColor = System.Drawing.Color.Transparent;
            this.DateNavigator.Location = new System.Drawing.Point(5, 85);
            this.DateNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.DateNavigator.Name = "DateNavigator";
            this.DateNavigator.Size = new System.Drawing.Size(200, 416);
            this.DateNavigator.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.panel1.Location = new System.Drawing.Point(205, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 416);
            this.panel1.TabIndex = 1;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateNavigator);
            this.Controls.Add(this.TopExplorer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meme explorer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.TopExplorer.ResumeLayout(false);
            this.TopExplorer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopExplorer;
        internal System.Windows.Forms.Label ButtonMinimize;
        internal System.Windows.Forms.Label ButtonClose;
        private System.Windows.Forms.Panel TabNavigator;
        private System.Windows.Forms.Panel DateNavigator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

