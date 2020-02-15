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
    public partial class WinX : Form
    {
        public WinX()
        {
            InitializeComponent();
        }

        private void WinX_Load(object sender, EventArgs e)
        {
            SoundPlayer sO = new SoundPlayer(Tic_Tac_Toe.Properties.Resources.O);
            sO.Play();                       
        }        
    }
}
