using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace Amethar
{
    public partial class IntroCinematic : Form
    {
        public IntroCinematic()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.IntroCinematic_FormClosing);
        }
        private void IntroCinematic_FormClosing(object sender, FormClosedEventArgs e)
        {
                Forms.f08 = new SceneBitterleafInn01();
                Forms.f08.Show();
                Music.chargen = true;
        }

        private void IntroCinematic_Load(object sender, EventArgs e)
        {
            Music.mainmenu = false;
            Forms.f00.MusicPlayer.Ctlcontrols.stop();
            CinematicPlayer.URL = Application.StartupPath + @"/cinematics/intro.wmv";
            CinematicPlayer.Ctlcontrols.play();
            Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Visions of the Past.mp3";
            Forms.f00.MusicPlayer.settings.setMode("loop", false);
            Cinematic.Start();
        }

        private void Cinematic_Tick(object sender, EventArgs e)
        {
                Forms.f07.Close();
        }
    }
}
