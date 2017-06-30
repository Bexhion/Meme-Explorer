using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meme_explorer.Client.Controls {
    public partial class MemeTab : UserControl {

        private List<MemeShower> memes;

        public MemeTab() {
            InitializeComponent();
            memes = new List<MemeShower>();
        }

        private void MemeTab_Load(object sender, EventArgs e) {

        }

        private void MemeTab_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
        }
    }
}
