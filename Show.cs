﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiApp
{
    public partial class Show : Form
    {
        public Show(List<Item> items)
        {
            InitializeComponent();
            foreach (var item in items)
            {
                panelShow.Controls.Add(item);
            }
        }
    }
}
