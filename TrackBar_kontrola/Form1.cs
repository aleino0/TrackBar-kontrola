using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBar_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void odabir_Scroll(object sender, EventArgs e)
        {
            prikaz.Text = odabir.Value.ToString();
        }
    }
}
