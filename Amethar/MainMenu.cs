using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using WMPLib;

namespace Amethar
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            MusicPlayer.URL = Application.StartupPath + @"/music/Tainted.mp3";
            MusicPlayer.settings.setMode("loop", true);
            MusicPlayer.settings.volume = 100;
            Fonts.ff = new PrivateFontCollection();
            Fonts.ff.AddFontFile(Application.StartupPath + @"/fonts/Mithril-Bold.ttf");
            Fonts.main = new Font(Fonts.ff.Families[0], 16, FontStyle.Bold);
            Fonts.dialogue = new Font(Fonts.ff.Families[0], 1000/100, FontStyle.Bold);
            Fonts.title = new Font(Fonts.ff.Families[0], 12, FontStyle.Bold);
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosing);
        }
        private void MainMenu_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void f00_button_exit_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            Buttons.button_exit = 1;
            f00_button_exit.Image = Amethar.Properties.Resources.ButtonExitPressed;
            Close();
        }

        private void f00_button_load_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            Buttons.button_load = 1;
            f00_button_load.Image = Amethar.Properties.Resources.ButtonLoadPressed;
            Forms.f06 = new LoadGame();
            Forms.f06.Show();
            this.Hide();
        }

        private void f00_button_new_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            Buttons.button_new = 1;
            f00_button_new.Image = Amethar.Properties.Resources.ButtonNewPressed;
            Forms.f01 = new NewCharacter();
            Forms.f01.Show();
            Forms.f01_confirm = 0;
            this.Hide();
        }

        private void f00_button_new_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f00_button_new.Image = Amethar.Properties.Resources.ButtonNewStatic;
            Buttons.button_new = 0;
        }

        private void f00_button_load_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f00_button_load.Image = Amethar.Properties.Resources.ButtonLoadStatic;
            Buttons.button_load = 0;
        }

        private void f00_button_exit_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f00_button_exit.Image = Amethar.Properties.Resources.ButtonExitStatic;
            Buttons.button_exit = 0;
        }

        private void f00_button_new_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            if (Buttons.button_new == 0) f00_button_new.Image = Amethar.Properties.Resources.ButtonNewHover;
        }

        private void f00_button_load_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            if (Buttons.button_load == 0) f00_button_load.Image = Amethar.Properties.Resources.ButtonLoadHover;
        }

        private void f00_button_exit_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            if (Buttons.button_exit == 0) f00_button_exit.Image = Amethar.Properties.Resources.ButtonExitHover;
        }
    }
}
