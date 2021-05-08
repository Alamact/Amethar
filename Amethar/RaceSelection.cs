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
    public partial class RaceSelection : Form
    {
        public RaceSelection()
        {
            InitializeComponent();
            playername.Font = Fonts.main;
            playername.Text = Globals.player_name;
            playername.TextAlign = ContentAlignment.MiddleCenter;
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.RaceSelection_FormClosing);
        }
        private void RaceSelection_FormClosing(object sender, FormClosedEventArgs e)
        {
            Music.mainmenu = false;
            if (Forms.f02_confirm == 0 && Forms.f02_back == 0)
            {
                Globals.race_selection = 0;
                Globals.portrait = 0;
                Forms.f00.Show();
                Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Tainted.mp3";
                Forms.f00.MusicPlayer.settings.setMode("loop", true);
                Music.chargen = true;
            }
            else if (Forms.f02_back == 1)
            {
                Globals.race_selection = 0;
                Globals.portrait = 0;
                Forms.f02_back = 0;
                Forms.f02_confirm = 0;
                Forms.f01 = new NewCharacter();
                Forms.f01.Show();
            }
            else Forms.f02_confirm = 0;
        }

        private void RaceSelection_Load(object sender, EventArgs e)
        {
            tooltip_race.Hide();
            if (Globals.gender_active == 1) f02_portrait.Image = Amethar.Properties.Resources.PMDefault;
            else f02_portrait.Image = Amethar.Properties.Resources.PFDefault;
        }

        private void f02_button_human_move(object sender, MouseEventArgs e)
        {
            if (Globals.race_selection != 1)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanHover;
            }
        }

        private void f02_button_human_leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_race.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.race_selection != 1) f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanStatic;
        }

        private void f02_button_moonelf_move(object sender, MouseEventArgs e)
        {
            if (Globals.race_selection != 2)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfHover;
            }
        }

        private void f02_button_moonelf_leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_race.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.race_selection != 2) f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfStatic;
        }

        private void f02_button_sandelf_move(object sender, MouseEventArgs e)
        {
            if (Globals.race_selection != 3)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfHover;
            }
        }

        private void f02_button_sandelf_leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_race.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.race_selection != 3) f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfStatic;
        }

        private void f02_button_dwarf_move(object sender, MouseEventArgs e)
        {
            if (Globals.race_selection != 4)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfHover;
            }
        }

        private void f02_button_dwarf_leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_race.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.race_selection != 4) f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfStatic;
        }

        private void f02_button_human_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_race.Image = Amethar.Properties.Resources.HumanTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_race.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f02_button_moonelf_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_race.Image = Amethar.Properties.Resources.MoonElfTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_race.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f02_button_sandelf_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_race.Image = Amethar.Properties.Resources.SandElfTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_race.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f02_button_dwarf_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_race.Image = Amethar.Properties.Resources.DwarfTooltip;
            var MP = this.PointToClient(Cursor.Position);
            if (this.Width - MP.X > 200) tooltip_race.Location = new Point(MP.X + 1, MP.Y + 3);
            else tooltip_race.Location = new Point(MP.X - 198, MP.Y + 3);
        }

        private void f02_button_human_Click(object sender, EventArgs e)
        {
            if (Globals.race_selection != 1) f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            else f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            if (Globals.race_selection == 0) 
            { 
                f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanActive;
                Globals.race_selection = 1;
                if (Globals.gender_active == 1) { Globals.portrait = 1; f02_portrait.Image = Amethar.Properties.Resources.PHM01; }
                else { Globals.portrait = 7; f02_portrait.Image = Amethar.Properties.Resources.PHF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 1)
            {
                f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanStatic;
                Globals.race_selection = 0;
                f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                if (Globals.gender_active == 1) f02_portrait.Image = Amethar.Properties.Resources.PMDefault;
                else f02_portrait.Image = Amethar.Properties.Resources.PFDefault;
                Globals.portrait = 0;
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            }
            else if (Globals.race_selection == 2)
            {
                f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfStatic;
                Globals.race_selection = 1;
                f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanActive;
                if (Globals.gender_active == 1) { Globals.portrait = 1; f02_portrait.Image = Amethar.Properties.Resources.PHM01; }
                else { Globals.portrait = 7; f02_portrait.Image = Amethar.Properties.Resources.PHF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 3)
            {
                f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfStatic;
                Globals.race_selection = 1;
                f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanActive;
                if (Globals.gender_active == 1) { Globals.portrait = 1; f02_portrait.Image = Amethar.Properties.Resources.PHM01; }
                else { Globals.portrait = 7; f02_portrait.Image = Amethar.Properties.Resources.PHF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 4)
            {
                f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfStatic;
                Globals.race_selection = 1;
                f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanActive;
                if (Globals.gender_active == 1) { Globals.portrait = 1; f02_portrait.Image = Amethar.Properties.Resources.PHM01; }
                else { Globals.portrait = 7; f02_portrait.Image = Amethar.Properties.Resources.PHF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
        }

        private void f02_button_moonelf_Click(object sender, EventArgs e)
        {
            if (Globals.race_selection != 2) f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            else f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            if (Globals.race_selection == 0) 
            { 
                f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfActive; 
                Globals.race_selection = 2;
                if (Globals.gender_active == 1) { Globals.portrait = 13; f02_portrait.Image = Amethar.Properties.Resources.PMM01; }
                else { Globals.portrait = 18; f02_portrait.Image = Amethar.Properties.Resources.PMF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 2) 
            { 
                f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfStatic; 
                Globals.race_selection = 0; 
                f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                if (Globals.gender_active == 1) f02_portrait.Image = Amethar.Properties.Resources.PMDefault;
                else f02_portrait.Image = Amethar.Properties.Resources.PFDefault;
                Globals.portrait = 0;
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            }
            else if (Globals.race_selection == 1) 
            { 
                f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanStatic; 
                Globals.race_selection = 2; 
                f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfActive;
                if (Globals.gender_active == 1) { Globals.portrait = 13; f02_portrait.Image = Amethar.Properties.Resources.PMM01; }
                else { Globals.portrait = 18; f02_portrait.Image = Amethar.Properties.Resources.PMF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 3) 
            { 
                f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfStatic; 
                Globals.race_selection = 2; 
                f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfActive;
                if (Globals.gender_active == 1) { Globals.portrait = 13; f02_portrait.Image = Amethar.Properties.Resources.PMM01; }
                else { Globals.portrait = 18; f02_portrait.Image = Amethar.Properties.Resources.PMF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 4) 
            { 
                f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfStatic; 
                Globals.race_selection = 2; 
                f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfActive;
                if (Globals.gender_active == 1) { Globals.portrait = 13; f02_portrait.Image = Amethar.Properties.Resources.PMM01; }
                else { Globals.portrait = 18; f02_portrait.Image = Amethar.Properties.Resources.PMF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
        }

        private void f02_button_sandelf_Click(object sender, EventArgs e)
        {
            if (Globals.race_selection != 3) f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            else f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            if (Globals.race_selection == 0) 
            {
                f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfActive; 
                Globals.race_selection = 3;
                if (Globals.gender_active == 1) { Globals.portrait = 23; f02_portrait.Image = Amethar.Properties.Resources.PSM01; }
                else { Globals.portrait = 28; f02_portrait.Image = Amethar.Properties.Resources.PSF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 3) 
            {
                f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfStatic;
                Globals.race_selection = 0;
                f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                if (Globals.gender_active == 1) f02_portrait.Image = Amethar.Properties.Resources.PMDefault;
                else f02_portrait.Image = Amethar.Properties.Resources.PFDefault;
                Globals.portrait = 0;
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            }
            else if (Globals.race_selection == 1) 
            {
                f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanStatic; 
                Globals.race_selection = 3; 
                f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfActive;
                if (Globals.gender_active == 1) { Globals.portrait = 23; f02_portrait.Image = Amethar.Properties.Resources.PSM01; }
                else { Globals.portrait = 28; f02_portrait.Image = Amethar.Properties.Resources.PSF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 2) 
            { 
                f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfStatic;
                Globals.race_selection = 3; 
                f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfActive;
                if (Globals.gender_active == 1) { Globals.portrait = 23; f02_portrait.Image = Amethar.Properties.Resources.PSM01; }
                else { Globals.portrait = 28; f02_portrait.Image = Amethar.Properties.Resources.PSF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 4) 
            {
                f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfStatic; 
                Globals.race_selection = 3; 
                f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfActive;
                if (Globals.gender_active == 1) { Globals.portrait = 23; f02_portrait.Image = Amethar.Properties.Resources.PSM01; }
                else { Globals.portrait = 28; f02_portrait.Image = Amethar.Properties.Resources.PSF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
        }

        private void f02_button_dwarf_Click(object sender, EventArgs e)
        {
            if (Globals.race_selection != 4) f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            else f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            if (Globals.race_selection == 0) 
            { 
                f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfActive; 
                Globals.race_selection = 4;
                if (Globals.gender_active == 1) { Globals.portrait = 33; f02_portrait.Image = Amethar.Properties.Resources.PDM01; }
                else { Globals.portrait = 38; f02_portrait.Image = Amethar.Properties.Resources.PDF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 4) 
            { 
                f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfStatic; 
                Globals.race_selection = 0; 
                f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                if (Globals.gender_active == 1) f02_portrait.Image = Amethar.Properties.Resources.PMDefault;
                else f02_portrait.Image = Amethar.Properties.Resources.PFDefault;
                Globals.portrait = 0;
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            }
            else if (Globals.race_selection == 1) 
            {
                f02_button_human.Image = Amethar.Properties.Resources.ButtonHumanStatic; 
                Globals.race_selection = 4; 
                f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfActive;
                if (Globals.gender_active == 1) { Globals.portrait = 33; f02_portrait.Image = Amethar.Properties.Resources.PDM01; }
                else { Globals.portrait = 38; f02_portrait.Image = Amethar.Properties.Resources.PDF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 2) 
            { 
                f02_button_moonelf.Image = Amethar.Properties.Resources.ButtonMoonElfStatic;
                Globals.race_selection = 4; 
                f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfActive;
                if (Globals.gender_active == 1) { Globals.portrait = 33; f02_portrait.Image = Amethar.Properties.Resources.PDM01; }
                else { Globals.portrait = 38; f02_portrait.Image = Amethar.Properties.Resources.PDF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
            else if (Globals.race_selection == 3) 
            {
                f02_button_sandelf.Image = Amethar.Properties.Resources.ButtonSandElfStatic;
                Globals.race_selection = 4; 
                f02_button_dwarf.Image = Amethar.Properties.Resources.ButtonDwarfActive;
                if (Globals.gender_active == 1) { Globals.portrait = 33; f02_portrait.Image = Amethar.Properties.Resources.PDM01; }
                else { Globals.portrait = 38; f02_portrait.Image = Amethar.Properties.Resources.PDF01; }
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
            }
        }

        private void tooltip_timer_Tick(object sender, EventArgs e)
        {
            if (Buttons.show_tooltip == true) { tooltip_race.Show(); tooltip_race.BringToFront(); Buttons.show_tooltip = false; Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/tooltip.wav"; }
        }

        private void hide_timer_Tick(object sender, EventArgs e)
        {
            tooltip_race.Hide();
        }

        private void f02_button_previous_Click(object sender, EventArgs e)
        {
            if (Globals.portrait > 1 && Globals.race_selection == 1 && Globals.gender_active == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait--;
                if (Globals.portrait == 1) { f02_portrait.Image = Amethar.Properties.Resources.PHM01; }
                else if (Globals.portrait == 2) { f02_portrait.Image = Amethar.Properties.Resources.PHM02; }
                else if (Globals.portrait == 3) { f02_portrait.Image = Amethar.Properties.Resources.PHM03; }
                else if (Globals.portrait == 4) { f02_portrait.Image = Amethar.Properties.Resources.PHM04; }
                else if (Globals.portrait == 5) { f02_portrait.Image = Amethar.Properties.Resources.PHM05; }
            }
            else if (Globals.portrait == 1 && Globals.race_selection == 1 && Globals.gender_active == 1) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 6; f02_portrait.Image = Amethar.Properties.Resources.PHM06; }
            else if (Globals.portrait > 7 && Globals.race_selection == 1 && Globals.gender_active == 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait--;
                if (Globals.portrait == 7) { f02_portrait.Image = Amethar.Properties.Resources.PHF01; }
                else if (Globals.portrait == 8) { f02_portrait.Image = Amethar.Properties.Resources.PHF02; }
                else if (Globals.portrait == 9) { f02_portrait.Image = Amethar.Properties.Resources.PHF03; }
                else if (Globals.portrait == 10) { f02_portrait.Image = Amethar.Properties.Resources.PHF04; }
                else if (Globals.portrait == 11) { f02_portrait.Image = Amethar.Properties.Resources.PHF05; }
            }
            else if (Globals.portrait == 7 && Globals.race_selection == 1 && Globals.gender_active == 2) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 12; f02_portrait.Image = Amethar.Properties.Resources.PHF06; }
            else if (Globals.portrait > 13 && Globals.race_selection == 2 && Globals.gender_active == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait--;
                if (Globals.portrait == 13) { f02_portrait.Image = Amethar.Properties.Resources.PMM01; }
                else if (Globals.portrait == 14) { f02_portrait.Image = Amethar.Properties.Resources.PMM02; }
                else if (Globals.portrait == 15) { f02_portrait.Image = Amethar.Properties.Resources.PMM03; }
                else if (Globals.portrait == 16) { f02_portrait.Image = Amethar.Properties.Resources.PMM04; }
            }
            else if (Globals.portrait == 13 && Globals.race_selection == 2 && Globals.gender_active == 1) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 17; f02_portrait.Image = Amethar.Properties.Resources.PMM05; }
            else if (Globals.portrait > 18 && Globals.race_selection == 2 && Globals.gender_active == 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait--;
                if (Globals.portrait == 18) { f02_portrait.Image = Amethar.Properties.Resources.PMF01; }
                else if (Globals.portrait == 19) { f02_portrait.Image = Amethar.Properties.Resources.PMF02; }
                else if (Globals.portrait == 20) { f02_portrait.Image = Amethar.Properties.Resources.PMF03; }
                else if (Globals.portrait == 21) { f02_portrait.Image = Amethar.Properties.Resources.PMF04; }
            }
            else if (Globals.portrait == 18 && Globals.race_selection == 2 && Globals.gender_active == 2) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 22; f02_portrait.Image = Amethar.Properties.Resources.PMF05; }
            else if (Globals.portrait > 23 && Globals.race_selection == 3 && Globals.gender_active == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait--;
                if (Globals.portrait == 23) { f02_portrait.Image = Amethar.Properties.Resources.PSM01; }
                else if (Globals.portrait == 24) { f02_portrait.Image = Amethar.Properties.Resources.PSM02; }
                else if (Globals.portrait == 25) { f02_portrait.Image = Amethar.Properties.Resources.PSM03; }
                else if (Globals.portrait == 26) { f02_portrait.Image = Amethar.Properties.Resources.PSM04; }
            }
            else if (Globals.portrait == 23 && Globals.race_selection == 3 && Globals.gender_active == 1) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 27; f02_portrait.Image = Amethar.Properties.Resources.PSM05; }
            else if (Globals.portrait > 28 && Globals.race_selection == 3 && Globals.gender_active == 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait--;
                if (Globals.portrait == 28) { f02_portrait.Image = Amethar.Properties.Resources.PSF01; }
                else if (Globals.portrait == 29) { f02_portrait.Image = Amethar.Properties.Resources.PSF02; }
                else if (Globals.portrait == 30) { f02_portrait.Image = Amethar.Properties.Resources.PSF03; }
                else if (Globals.portrait == 31) { f02_portrait.Image = Amethar.Properties.Resources.PSF04; }
            }
            else if (Globals.portrait == 28 && Globals.race_selection == 3 && Globals.gender_active == 2) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 32; f02_portrait.Image = Amethar.Properties.Resources.PSF05; }
            else if (Globals.portrait > 33 && Globals.race_selection == 4 && Globals.gender_active == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait--;
                if (Globals.portrait == 33) { f02_portrait.Image = Amethar.Properties.Resources.PDM01; }
                else if (Globals.portrait == 34) { f02_portrait.Image = Amethar.Properties.Resources.PDM02; }
                else if (Globals.portrait == 35) { f02_portrait.Image = Amethar.Properties.Resources.PDM03; }
                else if (Globals.portrait == 36) { f02_portrait.Image = Amethar.Properties.Resources.PDM04; }
            }
            else if (Globals.portrait == 33 && Globals.race_selection == 4 && Globals.gender_active == 1) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 37; f02_portrait.Image = Amethar.Properties.Resources.PDM05; }
            else if (Globals.portrait > 38 && Globals.race_selection == 4 && Globals.gender_active == 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait--;
                if (Globals.portrait == 38) { f02_portrait.Image = Amethar.Properties.Resources.PDF01; }
                else if (Globals.portrait == 39) { f02_portrait.Image = Amethar.Properties.Resources.PDF02; }
                else if (Globals.portrait == 40) { f02_portrait.Image = Amethar.Properties.Resources.PDF03; }
                else if (Globals.portrait == 41) { f02_portrait.Image = Amethar.Properties.Resources.PDF04; }
            }
            else if (Globals.portrait == 38 && Globals.race_selection == 4 && Globals.gender_active == 2) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 42; f02_portrait.Image = Amethar.Properties.Resources.PDF05; }
        }

        private void f02_button_next_Click(object sender, EventArgs e)
        {
            if (Globals.portrait < 6 && Globals.race_selection == 1 && Globals.gender_active == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait++;
                if (Globals.portrait == 2) { f02_portrait.Image = Amethar.Properties.Resources.PHM02; }
                else if (Globals.portrait == 3) { f02_portrait.Image = Amethar.Properties.Resources.PHM03; }
                else if (Globals.portrait == 4) { f02_portrait.Image = Amethar.Properties.Resources.PHM04; }
                else if (Globals.portrait == 5) { f02_portrait.Image = Amethar.Properties.Resources.PHM05; }
                else if (Globals.portrait == 6) { f02_portrait.Image = Amethar.Properties.Resources.PHM06; }
            }
            else if (Globals.portrait == 6 && Globals.race_selection == 1 && Globals.gender_active == 1) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 1; f02_portrait.Image = Amethar.Properties.Resources.PHM01; }
            else if (Globals.portrait < 12 && Globals.race_selection == 1 && Globals.gender_active == 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait++;
                if (Globals.portrait == 8) { f02_portrait.Image = Amethar.Properties.Resources.PHF02; }
                else if (Globals.portrait == 9) { f02_portrait.Image = Amethar.Properties.Resources.PHF03; }
                else if (Globals.portrait == 10) { f02_portrait.Image = Amethar.Properties.Resources.PHF04; }
                else if (Globals.portrait == 11) { f02_portrait.Image = Amethar.Properties.Resources.PHF05; }
                else if (Globals.portrait == 12) { f02_portrait.Image = Amethar.Properties.Resources.PHF06; }
            }
            else if (Globals.portrait == 12 && Globals.race_selection == 1 && Globals.gender_active == 2) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 7; f02_portrait.Image = Amethar.Properties.Resources.PHF01; }
            else if (Globals.portrait < 17 && Globals.race_selection == 2 && Globals.gender_active == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait++;
                if (Globals.portrait == 14) { f02_portrait.Image = Amethar.Properties.Resources.PMM02; }
                else if (Globals.portrait == 15) { f02_portrait.Image = Amethar.Properties.Resources.PMM03; }
                else if (Globals.portrait == 16) { f02_portrait.Image = Amethar.Properties.Resources.PMM04; }
                else if (Globals.portrait == 17) { f02_portrait.Image = Amethar.Properties.Resources.PMM05; }
            }
            else if (Globals.portrait == 17 && Globals.race_selection == 2 && Globals.gender_active == 1) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 13; f02_portrait.Image = Amethar.Properties.Resources.PMM01; }
            else if (Globals.portrait < 22 && Globals.race_selection == 2 && Globals.gender_active == 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait++;
                if (Globals.portrait == 19) { f02_portrait.Image = Amethar.Properties.Resources.PMF02; }
                else if (Globals.portrait == 20) { f02_portrait.Image = Amethar.Properties.Resources.PMF03; }
                else if (Globals.portrait == 21) { f02_portrait.Image = Amethar.Properties.Resources.PMF04; }
                else if (Globals.portrait == 22) { f02_portrait.Image = Amethar.Properties.Resources.PMF05; }
            }
            else if (Globals.portrait == 22 && Globals.race_selection == 2 && Globals.gender_active == 2) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 18; f02_portrait.Image = Amethar.Properties.Resources.PMF01; }
            else if (Globals.portrait < 27 && Globals.race_selection == 3 && Globals.gender_active == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait++;
                if (Globals.portrait == 24) { f02_portrait.Image = Amethar.Properties.Resources.PSM02; }
                else if (Globals.portrait == 25) { f02_portrait.Image = Amethar.Properties.Resources.PSM03; }
                else if (Globals.portrait == 26) { f02_portrait.Image = Amethar.Properties.Resources.PSM04; }
                else if (Globals.portrait == 27) { f02_portrait.Image = Amethar.Properties.Resources.PSM05; }
            }
            else if (Globals.portrait == 27 && Globals.race_selection == 3 && Globals.gender_active == 1) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 23; f02_portrait.Image = Amethar.Properties.Resources.PSM01; }
            else if (Globals.portrait < 32 && Globals.race_selection == 3 && Globals.gender_active == 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait++;
                if (Globals.portrait == 29) { f02_portrait.Image = Amethar.Properties.Resources.PSF02; }
                else if (Globals.portrait == 30) { f02_portrait.Image = Amethar.Properties.Resources.PSF03; }
                else if (Globals.portrait == 31) { f02_portrait.Image = Amethar.Properties.Resources.PSF04; }
                else if (Globals.portrait == 32) { f02_portrait.Image = Amethar.Properties.Resources.PSF05; }
            }
            else if (Globals.portrait == 32 && Globals.race_selection == 3 && Globals.gender_active == 2) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 28; f02_portrait.Image = Amethar.Properties.Resources.PSF01; }
            else if (Globals.portrait < 37 && Globals.race_selection == 4 && Globals.gender_active == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait++;
                if (Globals.portrait == 34) { f02_portrait.Image = Amethar.Properties.Resources.PDM02; }
                else if (Globals.portrait == 35) { f02_portrait.Image = Amethar.Properties.Resources.PDM03; }
                else if (Globals.portrait == 36) { f02_portrait.Image = Amethar.Properties.Resources.PDM04; }
                else if (Globals.portrait == 37) { f02_portrait.Image = Amethar.Properties.Resources.PDM05; }
            }
            else if (Globals.portrait == 37 && Globals.race_selection == 4 && Globals.gender_active == 1) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 33; f02_portrait.Image = Amethar.Properties.Resources.PDM01; }
            else if (Globals.portrait < 42 && Globals.race_selection == 4 && Globals.gender_active == 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                Globals.portrait++;
                if (Globals.portrait == 39) { f02_portrait.Image = Amethar.Properties.Resources.PDF02; }
                else if (Globals.portrait == 40) { f02_portrait.Image = Amethar.Properties.Resources.PDF03; }
                else if (Globals.portrait == 41) { f02_portrait.Image = Amethar.Properties.Resources.PDF04; }
                else if (Globals.portrait == 42) { f02_portrait.Image = Amethar.Properties.Resources.PDF05; }
            }
            else if (Globals.portrait == 42 && Globals.race_selection == 4 && Globals.gender_active == 2) { Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav"; Globals.portrait = 38; f02_portrait.Image = Amethar.Properties.Resources.PDF01; }
        }

        private void f02_button_previous_Move(object sender, MouseEventArgs e)
        {
            if (Globals.race_selection != 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f02_button_previous.Image = Amethar.Properties.Resources.ButtonPreviousHover;
            }
        }

        private void f02_button_previous_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.race_selection != 0) f02_button_previous.Image = Amethar.Properties.Resources.ButtonPrevious;
        }

        private void f02_button_next_Move(object sender, MouseEventArgs e)
        {
            if (Globals.race_selection != 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f02_button_next.Image = Amethar.Properties.Resources.ButtonNextHover;
            }
        }

        private void f02_button_next_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.race_selection != 0) f02_button_next.Image = Amethar.Properties.Resources.ButtonNext;
        }

        private void f02_button_formback_Move(object sender, MouseEventArgs e)
        {
            f02_button_formback.Image = Amethar.Properties.Resources.ButtonFormBackHover;
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
        }

        private void f02_button_formback_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f02_button_formback.Image = Amethar.Properties.Resources.ButtonFormBack;
        }

        private void f02_button_formback_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            Forms.f02_back = 1;
            this.Close();
        }

        private void f02_button_confirm_Move(object sender, MouseEventArgs e)
        {
            if (Globals.race_selection != 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmHover;
            }
        }

        private void f02_button_confirm_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.race_selection != 0) f02_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f02_button_confirm_Click(object sender, EventArgs e)
        {
            if (Globals.race_selection != 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                Globals.race_active = Globals.race_selection;
                Globals.portrait_active.Image = f02_portrait.Image;
                Forms.f02_confirm = 1;
                Globals.race_selection = 0;
                Forms.f03 = new ClassSelection();
                Forms.f03.Show();
                this.Close();
            }
        }
    }
}
