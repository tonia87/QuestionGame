using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionGame___List
{
    public partial class frmStart : Form
    {
        string resourcesPath = System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName + @"\Resources";

        public frmStart()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmPlay z = new frmPlay();
            wmpTheme.close();
            z.Show();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            wmpTheme.URL = resourcesPath + @"\" + "Back to the Future Theme.mp3";
            wmpTheme.BeginInit();
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage =Image.FromFile( resourcesPath + @"\" + "background.jpg");
        }

        private void wmpTheme_Enter(object sender, EventArgs e)
        {

        }

        private void frmStart_Activated(object sender, EventArgs e)
        {
            wmpTheme.URL = resourcesPath + @"\" + "Back to the Future Theme.mp3"; wmpTheme.BeginInit();
        }
    }
}
