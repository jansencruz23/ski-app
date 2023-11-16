using Guna.UI2.WinForms;

namespace SkiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Item> items = new();
            foreach (var cb in Controls.OfType<Guna2CheckBox>())
            {
                if (cb.Checked)
                {
                    string image = cb.Text switch
                    {
                        "Earmuffs" => "./Icons/ear.jpg",
                        "Goggles" => "./Icons/goggles.jpg",
                        "Ski Bindings" => "./Icons/bindings.jpg",
                        "Ski Boots" => "./Icons/boots.jpg",
                        "Skis" => "./Icons/skis.png",
                        "Ski Poles" => "./Icons/poles.png",
                        "Snow Gloves" => "./Icons/download.jpg"
                    };

                    items.Add(new Item(Image.FromFile(image), cb.Text));
                }
            }
            var form = new Show(items);
            form.ShowDialog();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var cb in Controls.OfType<Guna2CheckBox>())
            {
                cb.Checked = false;
            }
        }
    }
}