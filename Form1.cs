using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game_1
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "J","J","P","P","M","M","E","E","j","j","o","o","b","b","v","v"
        };
        public Form1()
        {
            InitializeComponent();
        }
    }
}
