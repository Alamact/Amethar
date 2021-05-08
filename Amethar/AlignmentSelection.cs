using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Amethar
{
    public partial class AlignmentSelection : Form
    {
        public AlignmentSelection()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.AlignmentSelection_FormClosing);
        }

        private void AlignmentSelection_FormClosing(object sender, FormClosedEventArgs e)
        {
            Music.mainmenu = false;
            if (Forms.f04_confirm == 0 && Forms.f04_back == 0)
            {
                Globals.class_selection = 0;
                Forms.f00.Show();
                Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Tainted.mp3";
                Forms.f00.MusicPlayer.settings.setMode("loop", true);
                Music.chargen = true;
            }
            else if (Forms.f04_back == 1)
            {
                Globals.alignment_selection = 0;
                Globals.origin_selection = 0;
                Forms.f04_back = 0;
                Forms.f04_confirm = 0;
                Forms.f03 = new ClassSelection();
                Forms.f03.Show();
            }
            else Forms.f04_confirm = 0;
        }

        private void AlignmentSelection_Load(object sender, EventArgs e)
        {
            tooltip_alignment.Hide();
            Globals.origin_human_commoner = false;
            Globals.origin_human_nobility = false;
            Globals.origin_moonelf_commoner = false;
            Globals.origin_moonelf_nobility = false;
            Globals.origin_sandelf_commoner = false;
            Globals.origin_sandelf_nobility = false;
            Globals.origin_dwarf_commoner = false;
            Globals.origin_dwarf_nobility = false;
        }

        private void f04_button_lawful_good_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 1)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodHover;
            }
        }

        private void f04_button_lawful_good_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_alignment.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.alignment_selection != 1) f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
        }

        private void f04_button_neutral_good_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 2)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodHover;
            }
        }

        private void f04_button_neutral_good_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_alignment.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.alignment_selection != 2) f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
        }

        private void f04_button_chaotic_good_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 3)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodHover;
            }
        }

        private void f04_button_chaotic_good_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_alignment.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.alignment_selection != 3) f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
        }

        private void f04_button_lawful_neutral_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 4)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralHover;
            }
        }

        private void f04_button_lawful_neutral_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_alignment.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.alignment_selection != 4) f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
        }

        private void f04_button_true_neutral_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 5)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralHover;
            }
        }

        private void f04_button_true_neutral_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_alignment.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.alignment_selection != 5) f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
        }

        private void f04_button_chaotic_neutral_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 6)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralHover;
            }
        }

        private void f04_button_chaotic_neutral_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_alignment.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.alignment_selection != 6) f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
        }

        private void f04_button_lawful_evil_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 7)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilHover;
            }
        }

        private void f04_button_lawful_evil_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_alignment.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.alignment_selection != 7) f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
        }

        private void f04_button_neutral_evil_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 8)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilHover;
            }
        }

        private void f04_button_neutral_evil_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_alignment.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.alignment_selection != 8) f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
        }

        private void f04_button_chaotic_evil_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 9)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilHover;
            }
        }

        private void f04_button_chaotic_evil_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            tooltip_alignment.Hide();
            tooltip_timer.Stop();
            hide_timer.Stop();
            Buttons.show_tooltip = true;
            if (Globals.alignment_selection != 9) f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
        }

        private void f04_button_commoner_Move(object sender, MouseEventArgs e)
        {
            if (Globals.origin_selection != 1)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_commoner.Image = Amethar.Properties.Resources.ButtonCommonerHover;
            }
        }

        private void f04_button_commoner_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.origin_selection != 1) f04_button_commoner.Image = Amethar.Properties.Resources.ButtonCommonerStatic;
        }

        private void f04_button_nobility_Move(object sender, MouseEventArgs e)
        {
            if (Globals.origin_selection != 2)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_nobility.Image = Amethar.Properties.Resources.ButtonNobilityHover;
            }
        }

        private void f04_button_nobility_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.origin_selection != 2) f04_button_nobility.Image = Amethar.Properties.Resources.ButtonNobilityStatic;
        }

        private void f04_button_confirm_Move(object sender, MouseEventArgs e)
        {
            if (Globals.alignment_selection != 0 && Globals.origin_selection != 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmHover;
            }
        }

        private void f04_button_confirm_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.alignment_selection != 0 && Globals.origin_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_formback_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f04_button_formback.Image = Amethar.Properties.Resources.ButtonFormBackHover;
        }

        private void f04_button_formback_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f04_button_formback.Image = Amethar.Properties.Resources.ButtonFormBack;
        }

        private void f04_button_lawful_good_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_alignment.Image = Amethar.Properties.Resources.LawfulGoodTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_alignment.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f04_button_neutral_good_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_alignment.Image = Amethar.Properties.Resources.NeutralGoodTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_alignment.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f04_button_chaotic_good_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_alignment.Image = Amethar.Properties.Resources.ChaoticGoodTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_alignment.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f04_button_lawful_neutral_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_alignment.Image = Amethar.Properties.Resources.LawfulNeutralTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_alignment.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f04_button_true_neutral_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_alignment.Image = Amethar.Properties.Resources.TrueNeutralTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_alignment.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f04_button_chaotic_neutral_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_alignment.Image = Amethar.Properties.Resources.ChaoticNeutralTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_alignment.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f04_button_lawful_evil_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_alignment.Image = Amethar.Properties.Resources.LawfulEvilTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_alignment.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f04_button_neutral_evil_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_alignment.Image = Amethar.Properties.Resources.NeutralEvilTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_alignment.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void f04_button_chaotic_evil_tooltip(object sender, EventArgs e)
        {
            tooltip_timer.Start();
            hide_timer.Start();
            tooltip_alignment.Image = Amethar.Properties.Resources.ChaoticEvilTooltip;
            var MP = this.PointToClient(Cursor.Position);
            tooltip_alignment.Location = new Point(MP.X + 1, MP.Y + 3);
        }

        private void tooltip_timer_Tick(object sender, EventArgs e)
        {
            if (Buttons.show_tooltip == true) { Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/tooltip.wav"; tooltip_alignment.Show(); tooltip_alignment.BringToFront(); Buttons.show_tooltip = false; }
        }

        private void hide_timer_Tick(object sender, EventArgs e)
        {
            tooltip_alignment.Hide();
        }

        private void f04_button_lawful_good_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 1) 
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodActive; 
                Globals.alignment_selection = 1;
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
                Globals.alignment_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_neutral_good_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodActive;
                Globals.alignment_selection = 2;
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
                Globals.alignment_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_chaotic_good_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 3)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodActive;
                Globals.alignment_selection = 3;
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
                Globals.alignment_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_lawful_neutral_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 4)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralActive;
                Globals.alignment_selection = 4;
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
                Globals.alignment_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_true_neutral_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 5)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralActive;
                Globals.alignment_selection = 5;
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
                Globals.alignment_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_chaotic_neutral_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 6)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralActive;
                Globals.alignment_selection = 6;
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
                Globals.alignment_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_lawful_evil_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 7)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilActive;
                Globals.alignment_selection = 7;
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
                Globals.alignment_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_neutral_evil_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 8)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilActive;
                Globals.alignment_selection = 8;
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
                Globals.alignment_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_chaotic_evil_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 9)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilActive;
                Globals.alignment_selection = 9;
                f04_button_neutral_good.Image = Amethar.Properties.Resources.ButtonNeutralGoodStatic;
                f04_button_chaotic_good.Image = Amethar.Properties.Resources.ButtonChaoticGoodStatic;
                f04_button_lawful_neutral.Image = Amethar.Properties.Resources.ButtonLawfulNeutralStatic;
                f04_button_true_neutral.Image = Amethar.Properties.Resources.ButtonTrueNeutralStatic;
                f04_button_chaotic_neutral.Image = Amethar.Properties.Resources.ButtonChaoticNeutralStatic;
                f04_button_lawful_evil.Image = Amethar.Properties.Resources.ButtonLawfulEvilStatic;
                f04_button_neutral_evil.Image = Amethar.Properties.Resources.ButtonNeutralEvilStatic;
                f04_button_lawful_good.Image = Amethar.Properties.Resources.ButtonLawfulGoodStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_chaotic_evil.Image = Amethar.Properties.Resources.ButtonChaoticEvilStatic;
                Globals.alignment_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_commoner_Click(object sender, EventArgs e)
        {
            if (Globals.origin_selection != 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_commoner.Image = Amethar.Properties.Resources.ButtonCommonerActive;
                Globals.origin_selection = 1;
                f04_button_nobility.Image = Amethar.Properties.Resources.ButtonNobilityStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_commoner.Image = Amethar.Properties.Resources.ButtonCommonerStatic;
                Globals.origin_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_nobility_Click(object sender, EventArgs e)
        {
            if (Globals.origin_selection != 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f04_button_nobility.Image = Amethar.Properties.Resources.ButtonNobilityActive;
                Globals.origin_selection = 2;
                f04_button_commoner.Image = Amethar.Properties.Resources.ButtonCommonerStatic;
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f04_button_nobility.Image = Amethar.Properties.Resources.ButtonNobilityStatic;
                Globals.origin_selection = 0;
                f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
            if (Globals.origin_selection != 0 && Globals.alignment_selection != 0) f04_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f04_button_formback_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            Forms.f04_back = 1;
            this.Close();
        }

        private void f04_button_confirm_Click(object sender, EventArgs e)
        {
            if (Globals.alignment_selection != 0 && Globals.origin_selection != 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                if (Globals.origin_selection == 1)
                {
                    if (Globals.race_active == 1) { Globals.origin_human_commoner = true; Globals.player_surname = "Amallen"; }
                    else if (Globals.race_active == 2) { Globals.origin_moonelf_commoner = true; Globals.player_surname = "Ballamin"; }
                    else if (Globals.race_active == 3) { Globals.origin_sandelf_commoner = true; Globals.player_surname = "Durashi"; }
                    else if (Globals.race_active == 4) { Globals.origin_dwarf_commoner = true; Globals.player_surname = "Crestrock"; }
                }
                else if (Globals.origin_selection == 2)
                {
                    if (Globals.race_active == 1) { Globals.origin_human_nobility = true; Globals.player_surname = "Talyth"; }
                    else if (Globals.race_active == 2) { Globals.origin_moonelf_nobility = true; Globals.player_surname = "Omalar"; }
                    else if (Globals.race_active == 3) { Globals.origin_sandelf_nobility = true; Globals.player_surname = "Nashari"; }
                    else if (Globals.race_active == 4) { Globals.origin_dwarf_nobility = true; Globals.player_surname = "Grayhill"; }
                }
                if (Globals.alignment_selection == 1)
                {
                    Globals.goodevil_points = 65;
                    Globals.lawchaos_points = 65;
                }
                else if (Globals.alignment_selection == 2)
                {
                    Globals.goodevil_points = 65;
                    Globals.lawchaos_points = 50;
                }
                else if (Globals.alignment_selection == 3)
                {
                    Globals.goodevil_points = 65;
                    Globals.lawchaos_points = 35;
                }
                else if (Globals.alignment_selection == 4)
                {
                    Globals.goodevil_points = 50;
                    Globals.lawchaos_points = 65;
                }
                else if (Globals.alignment_selection == 5)
                {
                    Globals.goodevil_points = 50;
                    Globals.lawchaos_points = 50;
                }
                else if (Globals.alignment_selection == 6)
                {
                    Globals.goodevil_points = 50;
                    Globals.lawchaos_points = 35;
                }
                else if (Globals.alignment_selection == 7)
                {
                    Globals.goodevil_points = 35;
                    Globals.lawchaos_points = 65;
                }
                else if (Globals.alignment_selection == 8)
                {
                    Globals.goodevil_points = 35;
                    Globals.lawchaos_points = 50;
                }
                else if (Globals.alignment_selection == 9)
                {
                    Globals.goodevil_points = 35;
                    Globals.lawchaos_points = 35;
                }
                Forms.f04_confirm = 1;
                Forms.f05 = new SummaryScreen();
                Forms.f05.Show();
                Globals.origin_selection = 0;
                Globals.alignment_selection = 0;
                this.Close();
            }
        }
    }
}
