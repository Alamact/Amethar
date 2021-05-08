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
    public partial class ClassSelection : Form
    {
        public ClassSelection()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.ClassSelection_FormClosing);
        }

        private void ClassSelection_FormClosing(object sender, FormClosedEventArgs e)
        {
            Music.mainmenu = false;
            if (Forms.f03_confirm == 0 && Forms.f03_back == 0)
            {
                Globals.class_selection = 0;
                Forms.f00.Show();
                Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Tainted.mp3";
                Forms.f00.MusicPlayer.settings.setMode("loop", true);
                Music.chargen = true;
            }
            else if (Forms.f03_back == 1)
            {
                Globals.class_selection = 0;
                Forms.f03_back = 0;
                Forms.f03_confirm = 0;
                Forms.f02 = new RaceSelection();
                Forms.f02.Show();
            }
            else Forms.f03_confirm = 0;
        }

        private void f03_button_fighter_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_selection != 1)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterHover;
            }
        }

        private void f03_button_fighter_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.class_selection != 1) f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterStatic;
        }

        private void f03_button_paladin_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_selection != 2)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinHover;
            }
        }

        private void f03_button_paladin_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.class_selection != 2) f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinStatic;
        }

        private void f03_button_inquisitor_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_selection != 3)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorHover;
            }
        }

        private void f03_button_inquisitor_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.class_selection != 3) f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorStatic;
        }

        private void f03_button_thief_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_selection != 4)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefHover;
            }
        }

        private void f03_button_thief_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.class_selection != 4) f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefStatic;
        }

        private void f03_button_ranger_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_selection != 5)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerHover;
            }
        }

        private void f03_button_ranger_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.class_selection != 5) f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerStatic;
        }

        private void f03_button_druid_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_selection != 6)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidHover;
            }
        }

        private void f03_button_druid_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.class_selection != 6) f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidStatic;
        }

        private void f03_button_cleric_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_selection != 7)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericHover;
            }
        }

        private void f03_button_cleric_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.class_selection != 7) f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericStatic;
        }

        private void f03_button_mage_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_selection != 8)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageHover;
            }
        }

        private void f03_button_mage_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.class_selection != 8) f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageStatic;
        }

        private void f03_button_overview_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.tab_active != 1 && Buttons.tab_active != 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewHover;
            }
        }

        private void f03_button_overview_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Buttons.tab_active != 1 && Buttons.tab_active != 0) f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
        }

        private void f03_button_weapons_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.tab_active != 2 && Buttons.tab_active != 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsHover;
            }
        }

        private void f03_button_weapons_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Buttons.tab_active != 2 && Buttons.tab_active != 0) f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
        }

        private void f03_button_spells_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.tab_active != 3 && Buttons.tab_active != 0 && Globals.class_selection != 1 && Globals.class_selection != 4 && Globals.class_selection != 5)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsHover;
            }
            if (Buttons.tab_active != 3 && Buttons.tab_active != 0 && Globals.class_selection == 4)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSkillsHover;
            }
            if (Buttons.tab_active != 3 && Buttons.tab_active != 0 && Globals.class_selection == 5)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonPetsHover;
            }
        }

        private void f03_button_spells_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Buttons.tab_active != 3 && Buttons.tab_active != 0 && Globals.class_selection != 1 && Globals.class_selection != 4 && Globals.class_selection != 5) f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
            if (Buttons.tab_active != 3 && Buttons.tab_active != 0 && Globals.class_selection == 4) f03_button_spells.Image = Amethar.Properties.Resources.ButtonSkillsStatic;
            if (Buttons.tab_active != 3 && Buttons.tab_active != 0 && Globals.class_selection == 5) f03_button_spells.Image = Amethar.Properties.Resources.ButtonPetsStatic;
        }

        private void f03_button_formback_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f03_button_formback.Image = Amethar.Properties.Resources.ButtonFormBackHover;
        }

        private void f03_button_formback_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f03_button_formback.Image = Amethar.Properties.Resources.ButtonFormBack;
        }

        private void f03_button_fighter_Click(object sender, EventArgs e)
        {
            if(Globals.class_selection != 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterActive;
                Globals.class_selection = 1;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinStatic;
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorStatic;
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefStatic;
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerStatic;
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidStatic;
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericStatic;
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageStatic;
                if (Buttons.tab_active < 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.FighterOverview;
                    Buttons.tab_active = 1;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                }
                else if (Buttons.tab_active == 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.FighterWeapons;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsPressed;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                }
                else if (Buttons.tab_active == 3)
                {
                    Buttons.tab_active = 1;
                    f03_tooltip_main.Image = Amethar.Properties.Resources.FighterOverview;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                }
                f03_tooltip_main.Show();
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterStatic;
                Globals.class_selection = 0;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                Buttons.tab_active = 0;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewInvalid;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsInvalid;
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                f03_tooltip_main.Hide();
            }
        }

        private void f03_button_paladin_Click(object sender, EventArgs e)
        {
            if (Globals.class_selection != 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinActive;
                Globals.class_selection = 2;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterStatic;
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorStatic;
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefStatic;
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerStatic;
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidStatic;
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericStatic;
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageStatic;
                if (Buttons.tab_active < 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.PaladinOverview;
                    Buttons.tab_active = 1;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.PaladinWeapons;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsPressed;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 3)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.PaladinSpells;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsPressed;
                }
                f03_tooltip_main.Show();
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinStatic;
                Globals.class_selection = 0;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                Buttons.tab_active = 0;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewInvalid;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsInvalid;
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                f03_tooltip_main.Hide();
            }
        }

        private void f03_button_inquisitor_Click(object sender, EventArgs e)
        {
            if (Globals.class_selection != 3)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorActive;
                Globals.class_selection = 3;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterStatic;
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinStatic;
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefStatic;
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerStatic;
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidStatic;
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericStatic;
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageStatic;
                if (Buttons.tab_active < 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.InquisitorOverview;
                    Buttons.tab_active = 1;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.InquisitorWeapons;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsPressed;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 3)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.InquisitorSpells;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsPressed;
                }
                f03_tooltip_main.Show();
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorStatic;
                Globals.class_selection = 0;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                Buttons.tab_active = 0;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewInvalid;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsInvalid;
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                f03_tooltip_main.Hide();
            }
        }

        private void f03_button_thief_Click(object sender, EventArgs e)
        {
            if (Globals.class_selection != 4)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefActive;
                Globals.class_selection = 4;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterStatic;
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinStatic;
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorStatic;
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerStatic;
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidStatic;
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericStatic;
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageStatic;
                if (Buttons.tab_active < 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.ThiefOverview;
                    Buttons.tab_active = 1;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSkillsStatic;
                }
                else if (Buttons.tab_active == 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.ThiefWeapons;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsPressed;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSkillsStatic;
                }
                else if (Buttons.tab_active == 3)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.ThiefSkills;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSkillsPressed;
                }
                f03_tooltip_main.Show();
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefStatic;
                Globals.class_selection = 0;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                Buttons.tab_active = 0;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewInvalid;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsInvalid;
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                f03_tooltip_main.Hide();
            }
        }

        private void f03_button_ranger_Click(object sender, EventArgs e)
        {
            if (Globals.class_selection != 5)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerActive;
                Globals.class_selection = 5;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterStatic;
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinStatic;
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorStatic;
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefStatic;
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidStatic;
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericStatic;
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageStatic;
                if (Buttons.tab_active < 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.RangerOverview;
                    Buttons.tab_active = 1;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonPetsStatic;
                }
                else if (Buttons.tab_active == 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.RangerWeapons;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsPressed;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonPetsStatic;
                }
                else if (Buttons.tab_active == 3)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.RangerPets;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonPetsPressed;
                }
                f03_tooltip_main.Show();
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerStatic;
                Globals.class_selection = 0;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                Buttons.tab_active = 0;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewInvalid;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsInvalid;
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                f03_tooltip_main.Hide();
            }
        }

        private void f03_button_druid_Click(object sender, EventArgs e)
        {
            if (Globals.class_selection != 6)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidActive;
                Globals.class_selection = 6;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterStatic;
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinStatic;
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorStatic;
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefStatic;
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerStatic;
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericStatic;
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageStatic;
                if (Buttons.tab_active < 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.DruidOverview;
                    Buttons.tab_active = 1;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.DruidWeapons;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsPressed;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 3)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.DruidSpells;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsPressed;
                }
                f03_tooltip_main.Show();
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidStatic;
                Globals.class_selection = 0;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                Buttons.tab_active = 0;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewInvalid;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsInvalid;
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                f03_tooltip_main.Hide();
            }
        }

        private void f03_button_cleric_Click(object sender, EventArgs e)
        {
            if (Globals.class_selection != 7)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericActive;
                Globals.class_selection = 7;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterStatic;
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinStatic;
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorStatic;
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefStatic;
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerStatic;
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidStatic;
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageStatic;
                if (Buttons.tab_active < 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.ClericOverview;
                    Buttons.tab_active = 1;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.ClericWeapons;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsPressed;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 3)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.ClericSpells;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsPressed;
                }
                f03_tooltip_main.Show();
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericStatic;
                Globals.class_selection = 0;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                Buttons.tab_active = 0;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewInvalid;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsInvalid;
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                f03_tooltip_main.Hide();
            }
        }

        private void f03_button_mage_Click(object sender, EventArgs e)
        {
            if (Globals.class_selection != 8)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageActive;
                Globals.class_selection = 8;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
                f03_button_fighter.Image = Amethar.Properties.Resources.ButtonFighterStatic;
                f03_button_paladin.Image = Amethar.Properties.Resources.ButtonPaladinStatic;
                f03_button_inquisitor.Image = Amethar.Properties.Resources.ButtonInquisitorStatic;
                f03_button_thief.Image = Amethar.Properties.Resources.ButtonThiefStatic;
                f03_button_ranger.Image = Amethar.Properties.Resources.ButtonRangerStatic;
                f03_button_druid.Image = Amethar.Properties.Resources.ButtonDruidStatic;
                f03_button_cleric.Image = Amethar.Properties.Resources.ButtonClericStatic;
                if (Buttons.tab_active < 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.MageOverview;
                    Buttons.tab_active = 1;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 2)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.MageWeapons;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsPressed;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                }
                else if (Buttons.tab_active == 3)
                {
                    f03_tooltip_main.Image = Amethar.Properties.Resources.MageSpells;
                    f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                    f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                    f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsPressed;
                }
                f03_tooltip_main.Show();
            }
            else
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f03_button_mage.Image = Amethar.Properties.Resources.ButtonMageStatic;
                Globals.class_selection = 0;
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
                Buttons.tab_active = 0;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewInvalid;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsInvalid;
                f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                f03_tooltip_main.Hide();
            }
        }

        private void f03_button_overview_Click(object sender, EventArgs e)
        {
            if (Buttons.tab_active != 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewPressed;
                Buttons.tab_active = 1;
                if (Globals.class_selection == 4) f03_button_spells.Image = Amethar.Properties.Resources.ButtonSkillsStatic;
                else if (Globals.class_selection == 5) f03_button_spells.Image = Amethar.Properties.Resources.ButtonPetsStatic;
                else if (Globals.class_selection == 1) f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                else f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                if (Globals.class_selection == 1) f03_tooltip_main.Image = Amethar.Properties.Resources.FighterOverview;
                else if (Globals.class_selection == 2) f03_tooltip_main.Image = Amethar.Properties.Resources.PaladinOverview;
                else if (Globals.class_selection == 3) f03_tooltip_main.Image = Amethar.Properties.Resources.InquisitorOverview;
                else if (Globals.class_selection == 4) f03_tooltip_main.Image = Amethar.Properties.Resources.ThiefOverview;
                else if (Globals.class_selection == 5) f03_tooltip_main.Image = Amethar.Properties.Resources.RangerOverview;
                else if (Globals.class_selection == 6) f03_tooltip_main.Image = Amethar.Properties.Resources.DruidOverview;
                else if (Globals.class_selection == 7) f03_tooltip_main.Image = Amethar.Properties.Resources.ClericOverview;
                else if (Globals.class_selection == 8) f03_tooltip_main.Image = Amethar.Properties.Resources.MageOverview;
            }
        }

        private void f03_button_weapons_Click(object sender, EventArgs e)
        {
            if (Buttons.tab_active != 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsPressed;
                Buttons.tab_active = 2;
                if (Globals.class_selection == 4) f03_button_spells.Image = Amethar.Properties.Resources.ButtonSkillsStatic;
                else if (Globals.class_selection == 5) f03_button_spells.Image = Amethar.Properties.Resources.ButtonPetsStatic;
                else if (Globals.class_selection == 1) f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsInvalid;
                else f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsStatic;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                if (Globals.class_selection == 1) f03_tooltip_main.Image = Amethar.Properties.Resources.FighterWeapons;
                else if (Globals.class_selection == 2) f03_tooltip_main.Image = Amethar.Properties.Resources.PaladinWeapons;
                else if (Globals.class_selection == 3) f03_tooltip_main.Image = Amethar.Properties.Resources.InquisitorWeapons;
                else if (Globals.class_selection == 4) f03_tooltip_main.Image = Amethar.Properties.Resources.ThiefWeapons;
                else if (Globals.class_selection == 5) f03_tooltip_main.Image = Amethar.Properties.Resources.RangerWeapons;
                else if (Globals.class_selection == 6) f03_tooltip_main.Image = Amethar.Properties.Resources.DruidWeapons;
                else if (Globals.class_selection == 7) f03_tooltip_main.Image = Amethar.Properties.Resources.ClericWeapons;
                else if (Globals.class_selection == 8) f03_tooltip_main.Image = Amethar.Properties.Resources.MageWeapons;
            }
        }

        private void f03_button_spells_Click(object sender, EventArgs e)
        {
            if (Buttons.tab_active != 0 && Globals.class_selection != 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                if (Globals.class_selection == 4) f03_button_spells.Image = Amethar.Properties.Resources.ButtonSkillsPressed;
                else if (Globals.class_selection == 5) f03_button_spells.Image = Amethar.Properties.Resources.ButtonPetsPressed;
                else f03_button_spells.Image = Amethar.Properties.Resources.ButtonSpellsPressed;
                Buttons.tab_active = 3;
                f03_button_weapons.Image = Amethar.Properties.Resources.ButtonWeaponsStatic;
                f03_button_overview.Image = Amethar.Properties.Resources.ButtonOverviewStatic;
                if (Globals.class_selection == 2) f03_tooltip_main.Image = Amethar.Properties.Resources.PaladinSpells;
                else if (Globals.class_selection == 3) f03_tooltip_main.Image = Amethar.Properties.Resources.InquisitorSpells;
                else if (Globals.class_selection == 4) f03_tooltip_main.Image = Amethar.Properties.Resources.ThiefSkills;
                else if (Globals.class_selection == 5) f03_tooltip_main.Image = Amethar.Properties.Resources.RangerPets;
                else if (Globals.class_selection == 6) f03_tooltip_main.Image = Amethar.Properties.Resources.DruidSpells;
                else if (Globals.class_selection == 7) f03_tooltip_main.Image = Amethar.Properties.Resources.ClericSpells;
                else if (Globals.class_selection == 8) f03_tooltip_main.Image = Amethar.Properties.Resources.MageSpells;
            }
        }

        private void f03_button_formback_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            Forms.f03_back = 1;
            this.Close();
        }

        private void f03_button_confirm_Click(object sender, EventArgs e)
        {
            if (Globals.class_selection != 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                Globals.class_active = Globals.class_selection;
                Forms.f03_confirm = 1;
                if (Globals.class_active == 1)
                {
                    Weapons.skill_sword = true; Weapons.tier_sword = 5;
                    Weapons.skill_axe = true; Weapons.tier_axe = 5;
                    Weapons.skill_mace = true; Weapons.tier_mace = 5;
                    Weapons.skill_claymore = true; Weapons.tier_claymore = 5;
                    Weapons.skill_halberd = true; Weapons.tier_halberd = 5;
                    Weapons.skill_hammer = true; Weapons.tier_hammer = 5;
                    Weapons.skill_spear = true; Weapons.tier_spear = 5;
                    Weapons.skill_dagger = false; Weapons.tier_dagger = 0;
                    Weapons.skill_quarterstaff = false; Weapons.tier_quarterstaff = 0;
                    Weapons.skill_shortbow = false; Weapons.tier_shortbow = 0;
                    Weapons.skill_longbow = false; Weapons.tier_longbow = 0;
                    Weapons.skill_shield = true; Weapons.tier_shield = 5;
                    Weapons.skill_dualwield = true; Weapons.tier_dualwield = 5;
                    Globals.armor_class = "Heavy";
                }
                else if (Globals.class_active == 2)
                {
                    Weapons.skill_sword = true; Weapons.tier_sword = 4;
                    Weapons.skill_axe = false; Weapons.tier_axe = 0;
                    Weapons.skill_mace = true; Weapons.tier_mace = 4;
                    Weapons.skill_claymore = true; Weapons.tier_claymore = 4;
                    Weapons.skill_halberd = false; Weapons.tier_halberd = 0;
                    Weapons.skill_hammer = true; Weapons.tier_hammer = 4;
                    Weapons.skill_spear = false; Weapons.tier_spear = 0;
                    Weapons.skill_dagger = false; Weapons.tier_dagger = 0;
                    Weapons.skill_quarterstaff = false; Weapons.tier_quarterstaff = 0;
                    Weapons.skill_shortbow = false; Weapons.tier_shortbow = 0;
                    Weapons.skill_longbow = false; Weapons.tier_longbow = 0;
                    Weapons.skill_shield = true; Weapons.tier_shield = 5;
                    Weapons.skill_dualwield = false; Weapons.tier_dualwield = 0;
                    Globals.armor_class = "Heavy";
                    Spellbook.slot_01 = "Detect Evil";
                    Spellbook.slot_02 = "Aegis";
                    Spellbook.detectevil_enabled = true;
                    Spellbook.aegis_enabled = true;
                    Spellbook.resistfear_enabled = true;
                    Spellbook.haste_enabled = true;
                    Spellbook.deathward_enabled = true;
                }
                else if (Globals.class_active == 3)
                {
                    Weapons.skill_sword = true; Weapons.tier_sword = 4;
                    Weapons.skill_axe = true; Weapons.tier_axe = 4;
                    Weapons.skill_mace = true; Weapons.tier_mace = 4;
                    Weapons.skill_claymore = true; Weapons.tier_claymore = 4;
                    Weapons.skill_halberd = true; Weapons.tier_halberd = 4;
                    Weapons.skill_hammer = true; Weapons.tier_hammer = 4;
                    Weapons.skill_spear = false; Weapons.tier_spear = 0;
                    Weapons.skill_dagger = false; Weapons.tier_dagger = 0;
                    Weapons.skill_quarterstaff = false; Weapons.tier_quarterstaff = 0;
                    Weapons.skill_shortbow = false; Weapons.tier_shortbow = 0;
                    Weapons.skill_longbow = false; Weapons.tier_longbow = 0;
                    Weapons.skill_shield = false; Weapons.tier_shield = 0;
                    Weapons.skill_dualwield = true; Weapons.tier_dualwield = 4;
                    Globals.armor_class = "Medium";
                    Spellbook.slot_01 = "Smite";
                    Spellbook.slot_02 = "Detect Evil";
                    Spellbook.smite_enabled = true;
                    Spellbook.frostbolt_enabled = true;
                    Spellbook.purge_enabled = true;
                    Spellbook.freeze_enabled = true;
                    Spellbook.bane_enabled = true;
                    Spellbook.detectevil_enabled = true;
                    Spellbook.detectinvisibility_enabled = true;
                    Spellbook.detectchaos_enabled = true;
                    Spellbook.spellworm_enabled = true;
                }
                else if (Globals.class_active == 4)
                {
                    Weapons.skill_sword = true; Weapons.tier_sword = 3;
                    Weapons.skill_axe = false; Weapons.tier_axe = 0;
                    Weapons.skill_mace = false; Weapons.tier_mace = 0;
                    Weapons.skill_claymore = false; Weapons.tier_claymore = 0;
                    Weapons.skill_halberd = false; Weapons.tier_halberd = 0;
                    Weapons.skill_hammer = false; Weapons.tier_hammer = 0;
                    Weapons.skill_spear = false; Weapons.tier_spear = 0;
                    Weapons.skill_dagger = true; Weapons.tier_dagger = 5;
                    Weapons.skill_quarterstaff = false; Weapons.tier_quarterstaff = 0;
                    Weapons.skill_shortbow = true; Weapons.tier_shortbow = 4;
                    Weapons.skill_longbow = false; Weapons.tier_longbow = 0;
                    Weapons.skill_shield = false; Weapons.tier_shield = 0;
                    Weapons.skill_dualwield = true; Weapons.tier_dualwield = 5;
                    Globals.armor_class = "Medium";
                }
                else if (Globals.class_active == 5)
                {
                    Weapons.skill_sword = true; Weapons.tier_sword = 3;
                    Weapons.skill_axe = true; Weapons.tier_axe = 4;
                    Weapons.skill_mace = false; Weapons.tier_mace = 0;
                    Weapons.skill_claymore = true; Weapons.tier_claymore = 3;
                    Weapons.skill_halberd = false; Weapons.tier_halberd = 0;
                    Weapons.skill_hammer = false; Weapons.tier_hammer = 0;
                    Weapons.skill_spear = true; Weapons.tier_spear = 4;
                    Weapons.skill_dagger = false; Weapons.tier_dagger = 0;
                    Weapons.skill_quarterstaff = false; Weapons.tier_quarterstaff = 0;
                    Weapons.skill_shortbow = true; Weapons.tier_shortbow = 5;
                    Weapons.skill_longbow = true; Weapons.tier_longbow = 5;
                    Weapons.skill_shield = false; Weapons.tier_shield = 0;
                    Weapons.skill_dualwield = false; Weapons.tier_dualwield = 0;
                    Globals.armor_class = "Medium";
                }
                else if (Globals.class_active == 6)
                {
                    Weapons.skill_sword = true; Weapons.tier_sword = 3;
                    Weapons.skill_axe = true; Weapons.tier_axe = 4;
                    Weapons.skill_mace = false; Weapons.tier_mace = 0;
                    Weapons.skill_claymore = false; Weapons.tier_claymore = 0;
                    Weapons.skill_halberd = false; Weapons.tier_halberd = 0;
                    Weapons.skill_hammer = false; Weapons.tier_hammer = 0;
                    Weapons.skill_spear = true; Weapons.tier_spear = 5;
                    Weapons.skill_dagger = true; Weapons.tier_dagger = 4;
                    Weapons.skill_quarterstaff = true; Weapons.tier_quarterstaff = 4;
                    Weapons.skill_shortbow = false; Weapons.tier_shortbow = 0;
                    Weapons.skill_longbow = false; Weapons.tier_longbow = 0;
                    Weapons.skill_shield = false; Weapons.tier_shield = 0;
                    Weapons.skill_dualwield = false; Weapons.tier_dualwield = 0;
                    Globals.armor_class = "Medium";
                    Spellbook.slot_01 = "Moonblast";
                    Spellbook.slot_02 = "Lightning Bolt";
                    Spellbook.slot_03 = "Entangle";
                    Spellbook.slot_04 = "Rejuvenation";
                    Spellbook.moonblast_enabled = true;
                    Spellbook.lightningbolt_enabled = true;
                    Spellbook.magicmissile_enabled = true;
                    Spellbook.venom_enabled = true;
                    Spellbook.entangle_enabled = true;
                    Spellbook.chainlightning_enabled = true;
                    Spellbook.identify_enabled = true;
                    Spellbook.detectalignment_enabled = true;
                    Spellbook.farsight_enabled = true;
                    Spellbook.detectinvisibility_enabled = true;
                    Spellbook.flameshield_enabled = true;
                    Spellbook.truestrike_enabled = true;
                    Spellbook.ironbark_enabled = true;
                    Spellbook.bladebarrier_enabled = true;
                    Spellbook.rejuvenation_enabled = true;
                    Spellbook.removepoison_enabled = true;
                    Spellbook.healingsurge_enabled = true;
                }
                else if (Globals.class_active == 7)
                {
                    Weapons.skill_sword = true; Weapons.tier_sword = 3;
                    Weapons.skill_axe = false; Weapons.tier_axe = 0;
                    Weapons.skill_mace = true; Weapons.tier_mace = 4;
                    Weapons.skill_claymore = false; Weapons.tier_claymore = 0;
                    Weapons.skill_halberd = false; Weapons.tier_halberd = 0;
                    Weapons.skill_hammer = false; Weapons.tier_hammer = 0;
                    Weapons.skill_spear = false; Weapons.tier_spear = 0;
                    Weapons.skill_dagger = true; Weapons.tier_dagger = 3;
                    Weapons.skill_quarterstaff = true; Weapons.tier_quarterstaff = 4;
                    Weapons.skill_shortbow = false; Weapons.tier_shortbow = 0;
                    Weapons.skill_longbow = false; Weapons.tier_longbow = 0;
                    Weapons.skill_shield = false; Weapons.tier_shield = 0;
                    Weapons.skill_dualwield = false; Weapons.tier_dualwield = 0;
                    Globals.armor_class = "Light";
                    Spellbook.slot_01 = "Detect Evil";
                    Spellbook.slot_02 = "Smite";
                    Spellbook.slot_03 = "Aegis";
                    Spellbook.slot_04 = "Identify";
                    Spellbook.smite_enabled = true;
                    Spellbook.purge_enabled = true;
                    Spellbook.detectevil_enabled = true;
                    Spellbook.detectinvisibility_enabled = true;
                    Spellbook.identify_enabled = true;
                    Spellbook.detectalignment_enabled = true;
                    Spellbook.detectthoughts_enabled = true;
                    Spellbook.aegis_enabled = true;
                    Spellbook.telekinesis_enabled = true;
                    Spellbook.levitate_enabled = true;
                    Spellbook.bladebarrier_enabled = true;
                    Spellbook.insanity_enabled = true;
                    Spellbook.greaterheal_enabled = true;
                    Spellbook.removedisease_enabled = true;
                    Spellbook.removepoison_enabled = true;
                    Spellbook.massheal_enabled = true;
                }
                else if (Globals.class_active == 8)
                {
                    Weapons.skill_sword = true; Weapons.tier_sword = 2; Weapons.level_sword = 0;
                    Weapons.skill_axe = false; Weapons.tier_axe = 0; Weapons.level_axe = 0;
                    Weapons.skill_mace = false; Weapons.tier_mace = 0; Weapons.level_mace = 0;
                    Weapons.skill_claymore = false; Weapons.tier_claymore = 0; Weapons.level_claymore = 0;
                    Weapons.skill_halberd = false; Weapons.tier_halberd = 0; Weapons.level_halberd = 0;
                    Weapons.skill_hammer = false; Weapons.tier_hammer = 0; Weapons.level_hammer = 0;
                    Weapons.skill_spear = false; Weapons.tier_spear = 0; Weapons.level_spear = 0;
                    Weapons.skill_dagger = true; Weapons.tier_dagger = 2; Weapons.level_dagger = 0;
                    Weapons.skill_quarterstaff = true; Weapons.tier_quarterstaff = 5; Weapons.level_quarterstaff = 0;
                    Weapons.skill_shortbow = false; Weapons.tier_shortbow = 0; Weapons.level_shortbow = 0;
                    Weapons.skill_longbow = false; Weapons.tier_longbow = 0; Weapons.level_longbow = 0;
                    Weapons.skill_shield = false; Weapons.tier_shield = 0; Weapons.level_shield = 0;
                    Weapons.skill_dualwield = false; Weapons.tier_dualwield = 0; Weapons.level_dualwield = 0;
                    Globals.armor_class = "Light";
                    Spellbook.slot_01 = "Lightning Bolt";
                    Spellbook.slot_02 = "Frostbolt";
                    Spellbook.slot_03 = "Magic Missile";
                    Spellbook.slot_04 = "Detect Invisibility";
                    Spellbook.slot_05 = "Flamestrike";
                    Spellbook.slot_06 = "Identify";
                    Spellbook.lightningbolt_enabled = true;
                    Spellbook.frostbolt_enabled = true;
                    Spellbook.magicmissile_enabled = true;
                    Spellbook.flamestrike_enabled = true;
                    Spellbook.scorch_enabled = true;
                    Spellbook.freeze_enabled = true;
                    Spellbook.purge_enabled = true;
                    Spellbook.chainlightning_enabled = true;
                    Spellbook.firestorm_enabled = true;
                    Spellbook.identify_enabled = true;
                    Spellbook.detectinvisibility_enabled = true;
                    Spellbook.detectthoughts_enabled = true;
                    Spellbook.leech_enabled = true;
                    Spellbook.spellworm_enabled = true;
                    Spellbook.fingerofdeath_enabled = true;
                    Spellbook.flameshield_enabled = true;
                    Spellbook.telekinesis_enabled = true;
                    Spellbook.levitate_enabled = true;
                    Spellbook.frostbolt_enabled = true;
                    Spellbook.magicmissile_enabled = true;
                    Spellbook.flamestrike_enabled = true;
                    Spellbook.purge_enabled = true;
                    Spellbook.freeze_enabled = true;
                    Spellbook.scorch_enabled = true;
                    Spellbook.chainlightning_enabled = true;
                    Spellbook.firestorm_enabled = true;
                    Spellbook.identify_enabled = true;
                    Spellbook.detectinvisibility_enabled = true;
                    Spellbook.detectthoughts_enabled = true;
                    Spellbook.leech_enabled = true;
                    Spellbook.spellworm_enabled = true;
                    Spellbook.fingerofdeath_enabled = true;
                    Spellbook.flameshield_enabled = true;
                    Spellbook.telekinesis_enabled = true;
                    Spellbook.levitate_enabled = true;
                }
                Globals.class_selection = 0;
                Forms.f04 = new AlignmentSelection();
                Forms.f04.Show();
                this.Close();
            }
        }

        private void f03_button_confirm_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_selection != 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmHover;
            }
        }

        private void f03_button_confirm_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Globals.class_selection != 0) f03_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void ClassSelection_Load(object sender, EventArgs e)
        {
            Spellbook.slot_01 = "";
            Spellbook.slot_02 = "";
            Spellbook.slot_03 = "";
            Spellbook.slot_04 = "";
            Spellbook.slot_05 = "";
            Spellbook.slot_06 = "";
            //Invocation
            Spellbook.smite_enabled = false;
            Spellbook.moonblast_enabled = false;
            Spellbook.lightningbolt_enabled = false;
            Spellbook.frostbolt_enabled = false;
            Spellbook.magicmissile_enabled = false;
            Spellbook.flamestrike_enabled = false;
            Spellbook.entangle_enabled = false;
            Spellbook.purge_enabled = false;
            Spellbook.venom_enabled = false;
            Spellbook.freeze_enabled = false;
            Spellbook.scorch_enabled = false;
            Spellbook.bane_enabled = false;
            Spellbook.chainlightning_enabled = false;
            Spellbook.firestorm_enabled = false;
            //Divination
            Spellbook.identify_enabled = false;
            Spellbook.detectevil_enabled = false;
            Spellbook.detectinvisibility_enabled = false;
            Spellbook.detectchaos_enabled = false;
            Spellbook.detectalignment_enabled = false;
            Spellbook.detectthoughts_enabled = false;
            Spellbook.farsight_enabled = false;
            //Evocation
            Spellbook.leech_enabled = false;
            Spellbook.spellworm_enabled = false;
            Spellbook.insanity_enabled = false;
            Spellbook.fingerofdeath_enabled = false;
            //Alteration
            Spellbook.aegis_enabled = false;
            Spellbook.flameshield_enabled = false;
            Spellbook.telekinesis_enabled = false;
            Spellbook.levitate_enabled = false;
            Spellbook.resistfear_enabled = false;
            Spellbook.haste_enabled = false;
            Spellbook.ironbark_enabled = false;
            Spellbook.truestrike_enabled = false;
            Spellbook.bladebarrier_enabled = false;
            Spellbook.deathward_enabled = false;
            //Restoration
            Spellbook.heal_enabled = false;
            Spellbook.rejuvenation_enabled = false;
            Spellbook.greaterheal_enabled = false;
            Spellbook.healingsurge_enabled = false;
            Spellbook.removepoison_enabled = false;
            Spellbook.removedisease_enabled = false;
            Spellbook.massheal_enabled = false;
            //Invocation
            Spellbook.smite = 0;
            Spellbook.moonblast = 0;
            Spellbook.lightningbolt = 0;
            Spellbook.frostbolt = 0;
            Spellbook.magicmissile = 0;
            Spellbook.flamestrike = 0;
            Spellbook.entangle = 0;
            Spellbook.purge = 0;
            Spellbook.venom = 0;
            Spellbook.freeze = 0;
            Spellbook.scorch = 0;
            Spellbook.bane = 0;
            Spellbook.chainlightning = 0;
            Spellbook.firestorm = 0;
            //Divination
            Spellbook.identify = 0;
            Spellbook.detectevil = 0;
            Spellbook.detectinvisibility = 0;
            Spellbook.detectchaos = 0;
            Spellbook.detectalignment = 0;
            Spellbook.detectthoughts = 0;
            Spellbook.farsight = 0;
            //Evocation
            Spellbook.leech = 0;
            Spellbook.spellworm = 0;
            Spellbook.insanity = 0;
            Spellbook.fingerofdeath = 0;
            //Alteration
            Spellbook.aegis = 0;
            Spellbook.flameshield = 0;
            Spellbook.telekinesis = 0;
            Spellbook.levitate = 0;
            Spellbook.resistfear = 0;
            Spellbook.haste = 0;
            Spellbook.ironbark = 0;
            Spellbook.truestrike = 0;
            Spellbook.bladebarrier = 0;
            Spellbook.deathward = 0;
            //Restoration
            Spellbook.heal = 0;
            Spellbook.rejuvenation = 0;
            Spellbook.greaterheal = 0;
            Spellbook.healingsurge = 0;
            Spellbook.removepoison = 0;
            Spellbook.removedisease = 0;
            Spellbook.massheal = 0;
            //Weapons
            Weapons.level_sword = 0;
            Weapons.level_axe = 0;
            Weapons.level_mace = 0;
            Weapons.level_claymore = 0;
            Weapons.level_halberd = 0;
            Weapons.level_hammer = 0;
            Weapons.level_spear = 0;
            Weapons.level_dagger = 0;
            Weapons.level_quarterstaff = 0;
            Weapons.level_shortbow = 0;
            Weapons.level_longbow = 0;
            Weapons.level_shield = 0;
            Weapons.level_dualwield = 0;
        }
    }
}
