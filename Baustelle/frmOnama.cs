using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baustelle
{
    public partial class frmOnama : Form
    {
        public frmOnama()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// NAVEDENI EVENT HANDLERI NA CLICK OTVARAJU RAZNE PRLJAVE STRANICE :D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pictMislavFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/mislav.boras");
        }

        private void pictStipeFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/stipe.colak93");
        }

        private void pictHrvojeFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/hrvoje.heat");
        }
    
        private void pictHrvojeYT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/user/heat4HD");
        }

        private void pictStipeIN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hr.linkedin.com/pub/stjepan-%C4%8Dolak/92/352/272");
        }

        private void pictMislavYT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/user/mboras100");
        }

        private void pictMislavINSTA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/mboras/");
        }




    }
}
