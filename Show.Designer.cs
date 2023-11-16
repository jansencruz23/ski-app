namespace SkiApp
{
    partial class Show
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
            panelShow = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panelShow
            // 
            panelShow.AutoScroll = true;
            panelShow.Dock = DockStyle.Fill;
            panelShow.FlowDirection = FlowDirection.TopDown;
            panelShow.Location = new Point(0, 0);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(268, 339);
            panelShow.TabIndex = 0;
            panelShow.WrapContents = false;
            // 
            // Show
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 339);
            Controls.Add(panelShow);
            Name = "Show";
            Text = "Show";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelShow;
    }
}