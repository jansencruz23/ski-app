namespace SkiApp
{
    partial class Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            imgIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)imgIcon).BeginInit();
            SuspendLayout();
            // 
            // imgIcon
            // 
            imgIcon.CustomizableEdges = customizableEdges1;
            imgIcon.ImageRotate = 0F;
            imgIcon.Location = new Point(3, 3);
            imgIcon.Name = "imgIcon";
            imgIcon.ShadowDecoration.CustomizableEdges = customizableEdges2;
            imgIcon.Size = new Size(75, 70);
            imgIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            imgIcon.TabIndex = 0;
            imgIcon.TabStop = false;
            // 
            // lblName
            // 
            lblName.Location = new Point(97, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(122, 33);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblName);
            Controls.Add(imgIcon);
            Name = "Item";
            Size = new Size(236, 76);
            ((System.ComponentModel.ISupportInitialize)imgIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imgIcon;
        private Label lblName;
    }
}
