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

namespace Amethar
{
    public partial class NewCharacter : Form
    {
        public NewCharacter()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.NewCharacter_FormClosing);
        }
        private void NewCharacter_FormClosing(object sender, FormClosedEventArgs e)
        {
            Music.mainmenu = false;
            if (Forms.f01_confirm == 0 && Forms.f01_back == 0)
            {
                Globals.gender_selection = 0;
                Forms.f00.Show();
                Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Tainted.mp3";
                Forms.f00.MusicPlayer.settings.setMode("loop", true);
                Music.chargen = true;
            }
            else if (Forms.f01_back == 1)
            {
                Globals.gender_selection = 0;
                Globals.player_name = "";
                Forms.f01_back = 0;
                Forms.f01_confirm = 0;
                Forms.f00.Show();
                Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Tainted.mp3";
                Forms.f00.MusicPlayer.settings.setMode("loop", true);
                Music.chargen = true;
            }
            else Forms.f01_confirm = 0;
        }

        private void f01_icon_male_Click(object sender, EventArgs e)
        {
            if (Globals.gender_selection == 0) { f01_icon_male.Image = Amethar.Properties.Resources.GenderMaleActive; Globals.gender_selection++; Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav"; }
            else if (Globals.gender_selection == 1) { f01_icon_male.Image = Amethar.Properties.Resources.GenderMaleStatic; Globals.gender_selection--; f01_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic; Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; }
            else { f01_icon_female.Image = Amethar.Properties.Resources.GenderFemaleStatic; f01_icon_male.Image = Amethar.Properties.Resources.GenderMaleActive; Globals.gender_selection--; Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav"; }
            if (f01_textbox_playername.Text.Length > 1 && Globals.gender_selection != 0) f01_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f01_icon_female_Click(object sender, EventArgs e)
        {
            if (Globals.gender_selection == 0) { f01_icon_female.Image = Amethar.Properties.Resources.GenderFemaleActive; Globals.gender_selection += 2; Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav"; }
            else if (Globals.gender_selection == 2) { f01_icon_female.Image = Amethar.Properties.Resources.GenderFemaleStatic; Globals.gender_selection -= 2; f01_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic; Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; }
            else { f01_icon_male.Image = Amethar.Properties.Resources.GenderMaleStatic; f01_icon_female.Image = Amethar.Properties.Resources.GenderFemaleActive; Globals.gender_selection++; Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav"; }
            if (f01_textbox_playername.Text.Length > 1 && Globals.gender_selection != 0) f01_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f01_button_confirm_Click(object sender, EventArgs e)
        {
            if (f01_textbox_playername.Text.Length > 1 && Globals.gender_selection != 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                Globals.player_name = f01_textbox_playername.Text;
                Globals.gender_active = Globals.gender_selection;
                Forms.f01_confirm = 1;
                Globals.gender_selection = 0;
                Forms.f02 = new RaceSelection();
                Forms.f02.Show();
                this.Close();
            }
        }

        private void f01_textbox_playername_TextChanged(object sender, EventArgs e)
        {
            f01_textbox_playername.Text = string.Concat(f01_textbox_playername.Text.Where(char.IsLetter));
            f01_textbox_playername.SelectionStart = f01_textbox_playername.Text.Length + 1;
            if (f01_textbox_playername.Text.Length != 0)
            {
                int i; string s = ""; char c = Char.ToUpper(f01_textbox_playername.Text[0]);
                for (i = 1; i < f01_textbox_playername.Text.Length; i++)
                {
                    s = s + Char.ToLower(f01_textbox_playername.Text[i]);
                }
                f01_textbox_playername.Text = c + s;
            }
            if (f01_textbox_playername.Text.Length <= 1) { f01_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic; }
            if (f01_textbox_playername.Text.Length > 1 && Globals.gender_selection != 0) f01_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f01_textbox_playername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f01_textbox_playername.Text.Length == 0 || f01_textbox_playername.SelectionStart==0) e.KeyChar = Char.ToUpper(e.KeyChar);
            else e.KeyChar = Char.ToLower(e.KeyChar);
        }

        private void f01_icon_male_Move(object sender, MouseEventArgs e)
        {
            if (Globals.gender_selection != 1)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f01_icon_male.Image = Amethar.Properties.Resources.GenderMaleHover;
            }
        }

        private void f01_icon_female_Move(object sender, MouseEventArgs e)
        {
            if (Globals.gender_selection != 2)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f01_icon_female.Image = Amethar.Properties.Resources.GenderFemaleHover;
            }
        }

        private void f01_icon_male_Leave(object sender, EventArgs e)
        {
            if (Globals.gender_selection != 1) f01_icon_male.Image = Amethar.Properties.Resources.GenderMaleStatic;
            Buttons.soundfx = true;
        }

        private void f01_icon_female_Leave(object sender, EventArgs e)
        {
            if (Globals.gender_selection != 2) f01_icon_female.Image = Amethar.Properties.Resources.GenderFemaleStatic;
            Buttons.soundfx = true;
        }

        private void f01_button_confirm_Move(object sender, MouseEventArgs e)
        {
            if (f01_textbox_playername.Text.Length > 1 && Globals.gender_selection != 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f01_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmHover;
            }
        }

        private void f01_button_confirm_Leave(object sender, EventArgs e)
        {
            if (f01_textbox_playername.Text.Length > 1 && Globals.gender_selection != 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f01_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            Buttons.soundfx = true;
        }
        private void f01_button_formback_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f01_button_formback.Image = Amethar.Properties.Resources.ButtonFormBackHover;
        }

        private void f01_button_formback_Leave(object sender, EventArgs e)
        {
            f01_button_formback.Image = Amethar.Properties.Resources.ButtonFormBack;
            Buttons.soundfx = true;
        }

        private void NewCharacter_Load(object sender, EventArgs e)
        {
            if (Music.chargen == true)
            {
                Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Call of Adventure.mp3";
                Forms.f00.MusicPlayer.settings.setMode("loop", true);
                Music.chargen = false;
            }
        }

        private void f01_button_formback_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            Forms.f01_back = 1;
            this.Close();
        }
    }
}
