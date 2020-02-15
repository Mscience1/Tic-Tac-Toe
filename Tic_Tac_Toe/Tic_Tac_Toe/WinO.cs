using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tic_Tac_Toe
{
    public partial class WinO : Form
    {
        public WinO()
        {
            InitializeComponent();
        }

        private void WinO_Load(object sender, EventArgs e)
        {
            SoundPlayer sX = new SoundPlayer(Tic_Tac_Toe.Properties.Resources.X);
            sX.Play();      
                   
        }
    }
}
