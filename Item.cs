namespace SkiApp
{
    public partial class Item : UserControl
    {
        public Item(Image img, string title)
        {
            InitializeComponent();
            imgIcon.Image = img;
            lblName.Text = title;
        }
    }
}
