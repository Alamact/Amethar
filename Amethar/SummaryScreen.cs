using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Amethar
{
    public partial class SummaryScreen : Form
    {
        int sword = 0, axe = 0, mace = 0, claymore = 0, halberd = 0, hammer = 0, spear = 0, dagger = 0, quarterstaff = 0, shortbow = 0, longbow = 0, shield = 0, dualwield = 0;
        int weaponpoint = 0, spellpoint = 0;
        bool spell01 = false, spell02 = false, spell03 = false, spell04 = false, spell05 = false, spell06 = false;
        int skill01 = 0, skill02 = 0, skill03 = 0;
        bool wolf = false, bear = false, drake = false, raven = false, scorpion = false, moth = false;
        bool button_abilities = true, button_background = false;
        public SummaryScreen()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.SummaryScreen_FormClosing);
        }

        private void SummaryScreen_FormClosing(object sender, FormClosedEventArgs e)
        {
            Music.mainmenu = false;
            Globals.strength = 10;
            Globals.dexterity = 10;
            Globals.intelligence = 10;
            Globals.constitution = 10;
            Globals.wisdom = 10;
            Globals.charisma = 10;
            Globals.attribute_points = 20;
            if (Forms.f05_confirm == 0 && Forms.f05_back == 0)
            {
                Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Tainted.mp3";
                Forms.f00.MusicPlayer.settings.setMode("loop", false);
                Music.chargen = true;
                Forms.f00.Show();
            }
            else if (Forms.f05_back == 1)
            {
                Forms.f05_back = 0;
                Forms.f05_confirm = 0;
                Forms.f04 = new AlignmentSelection();
                Forms.f04.Show();
            }
            else if (Forms.f05_confirm == 1)
            {
                Forms.f05_back = 0;
                Forms.f05_confirm = 0;
                Forms.f07 = new IntroCinematic();
                Forms.f07.Show();
            }
            else Forms.f05_confirm = 0;
        }

        private void SummaryScreen_Load(object sender, EventArgs e)
        {
            Globals.strength = 10;
            Globals.dexterity = 10;
            Globals.intelligence = 10;
            Globals.constitution = 10;
            Globals.wisdom = 10;
            Globals.charisma = 10;
            Globals.health = 50;
            Globals.mana = 5;
            Globals.melee_bonus = 0;
            Globals.ranged_bonus = 0;
            Globals.magic_bonus = 0;
            Globals.armor = 0;
            string SR = "", SC = "";
            f05_text_name.Text = Globals.player_name;
            if (Globals.race_active == 1)
            {
                SR = "Human";
            }
            else if (Globals.race_active == 2)
            {
                SR = "Moon Elf";
                Globals.strength = 8; f05_value_strength.Text = Convert.ToString(Globals.strength);
                Globals.intelligence = 12; f05_value_intelligence.Text = Convert.ToString(Globals.intelligence);
                Globals.constitution = 9; f05_value_constitution.Text = Convert.ToString(Globals.constitution);
                Globals.charisma = 11; f05_value_charisma.Text = Convert.ToString(Globals.charisma);
            }
            else if (Globals.race_active == 3)
            {
                SR = "Sand Elf";
                Globals.strength = 11; f05_value_strength.Text = Convert.ToString(Globals.strength);
                Globals.wisdom = 8; f05_value_wisdom.Text = Convert.ToString(Globals.wisdom);
                Globals.dexterity = 12; f05_value_dexterity.Text = Convert.ToString(Globals.dexterity);
                Globals.charisma = 9; f05_value_charisma.Text = Convert.ToString(Globals.charisma);
            }
            else if (Globals.race_active == 4)
            {
                SR = "Dwarf";
                Globals.strength = 12; f05_value_strength.Text = Convert.ToString(Globals.strength);
                Globals.wisdom = 9; f05_value_wisdom.Text = Convert.ToString(Globals.wisdom);
                Globals.constitution = 11; f05_value_constitution.Text = Convert.ToString(Globals.constitution);
                Globals.dexterity = 8; f05_value_dexterity.Text = Convert.ToString(Globals.dexterity);
            }
            Globals.health = Globals.constitution * 5;
            Globals.mana = Globals.wisdom - 5;
            f05_text_health.Text = "Health: " + Globals.health;
            f05_text_mana.Text = "Mana: " + Globals.mana;
            if (Globals.class_active == 1) SC = "Fighter";
            else if (Globals.class_active == 2) SC = "Paladin";
            else if (Globals.class_active == 3) SC = "Inquisitor";
            else if (Globals.class_active == 4) SC = "Thief";
            else if (Globals.class_active == 5) SC = "Ranger";
            else if (Globals.class_active == 6) SC = "Druid";
            else if (Globals.class_active == 7) SC = "Cleric";
            else if (Globals.class_active == 8) SC = "Mage";
            f05_text_title.Text = SR + " " + SC;
            f05_portrait.Image = Globals.portrait_active.Image;
            //Morality
            if (Globals.goodevil_points >= 65) f05_moralbar.Image = Amethar.Properties.Resources.MoralGood;
            else if (Globals.goodevil_points < 65 && Globals.goodevil_points > 35) f05_moralbar.Image = Amethar.Properties.Resources.MoralNeutral;
            if (Globals.goodevil_points <= 35) f05_moralbar.Image = Amethar.Properties.Resources.MoralEvil;
            if (Globals.lawchaos_points >= 65) f05_socialbar.Image = Amethar.Properties.Resources.SocialLawful;
            else if (Globals.lawchaos_points < 65 && Globals.lawchaos_points > 35) f05_socialbar.Image = Amethar.Properties.Resources.SocialNeutral;
            if (Globals.lawchaos_points <= 35) f05_socialbar.Image = Amethar.Properties.Resources.SocialChaotic;
            //Weapons
            f05_text_sword.Font = new Font(f05_text_sword.Font, FontStyle.Regular);
            f05_text_axe.Font = new Font(f05_text_axe.Font, FontStyle.Regular);
            f05_text_mace.Font = new Font(f05_text_mace.Font, FontStyle.Regular);
            f05_text_claymore.Font = new Font(f05_text_claymore.Font, FontStyle.Regular);
            f05_text_halberd.Font = new Font(f05_text_halberd.Font, FontStyle.Regular);
            f05_text_hammer.Font = new Font(f05_text_hammer.Font, FontStyle.Regular);
            f05_text_spear.Font = new Font(f05_text_spear.Font, FontStyle.Regular);
            f05_text_dagger.Font = new Font(f05_text_dagger.Font, FontStyle.Regular);
            f05_text_quarterstaff.Font = new Font(f05_text_quarterstaff.Font, FontStyle.Regular);
            f05_text_shortbow.Font = new Font(f05_text_shortbow.Font, FontStyle.Regular);
            f05_text_longbow.Font = new Font(f05_text_longbow.Font, FontStyle.Regular);
            f05_text_shield.Font = new Font(f05_text_shield.Font, FontStyle.Regular);
            f05_text_dualwield.Font = new Font(f05_text_dualwield.Font, FontStyle.Regular);
            if (Weapons.skill_sword == true) f05_text_sword.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_sword.ForeColor = Color.Red;
            if (Weapons.skill_axe == true) f05_text_axe.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_axe.ForeColor = Color.Red;
            if (Weapons.skill_mace == true) f05_text_mace.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_mace.ForeColor = Color.Red;
            if (Weapons.skill_claymore == true) f05_text_claymore.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_claymore.ForeColor = Color.Red;
            if (Weapons.skill_halberd == true) f05_text_halberd.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_halberd.ForeColor = Color.Red;
            if (Weapons.skill_hammer == true) f05_text_hammer.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_hammer.ForeColor = Color.Red;
            if (Weapons.skill_spear == true) f05_text_spear.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_spear.ForeColor = Color.Red;
            if (Weapons.skill_dagger == true) f05_text_dagger.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_dagger.ForeColor = Color.Red;
            if (Weapons.skill_quarterstaff == true) f05_text_quarterstaff.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_quarterstaff.ForeColor = Color.Red;
            if (Weapons.skill_shortbow == true) f05_text_shortbow.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_shortbow.ForeColor = Color.Red;
            if (Weapons.skill_longbow == true) f05_text_longbow.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_longbow.ForeColor = Color.Red;
            if (Weapons.skill_shield == true) f05_text_shield.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_shield.ForeColor = Color.Red;
            if (Weapons.skill_dualwield == true) f05_text_dualwield.ForeColor = Color.FromArgb(255, 255, 192, 128);
            else f05_text_dualwield.ForeColor = Color.Red;
            //Statistics
            if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8)
            {
                if (Globals.intelligence > 10) f05_text_ranged.Text = "Magic Damage: +" + Convert.ToString(Globals.intelligence - 10);
                else if (Globals.intelligence == 10) f05_text_ranged.Text = "Magic Damage: " + Convert.ToString(Globals.intelligence - 10);
                else if (Globals.intelligence < 10) f05_text_ranged.Text = "Magic Damage: -" + Convert.ToString(Math.Abs(Globals.intelligence - 10));
            }
            else
            {
                if (Globals.dexterity > 10) f05_text_ranged.Text = "Ranged Damage: +" + Convert.ToString(Globals.dexterity - 10);
                else if (Globals.dexterity == 10) f05_text_ranged.Text = "Ranged Damage: " + Convert.ToString(Globals.dexterity - 10);
                else if (Globals.dexterity < 10) f05_text_ranged.Text = "Ranged Damage: -" + Convert.ToString(Math.Abs(Globals.dexterity - 10));
            }
            if (Globals.strength > 10) f05_text_melee.Text = "Melee Damage: +" + Convert.ToString(Globals.strength - 10);
            else if (Globals.strength == 10) f05_text_melee.Text = "Melee Damage: " + Convert.ToString(Globals.strength - 10);
            else if (Globals.strength < 10) f05_text_melee.Text = "Melee Damage: -" + Convert.ToString(Math.Abs(Globals.strength - 10));
            if (Globals.dexterity >= 10) f05_text_armor.Text = "Armor: " + Convert.ToString(Globals.dexterity - 10) + " (" + Globals.armor_class + ")";
            else if (Globals.dexterity < 10) f05_text_armor.Text = "Armor: " + Convert.ToString(0) + " (" + Globals.armor_class + ")";
            f05_text_resistance.Text = "Magic Resistance: " + Convert.ToString(10 + (Globals.intelligence - 10) * 5) +"%";
            f05_text_reputation.Text = "Reputation: " + Convert.ToString(5 + (Globals.charisma - 10) * 2);
            //Spellbook
            if (Spellbook.slot_01 != "") { f05_text_spell01.Text = Spellbook.slot_01; f05_text_spell01.Visible = true; }
            else f05_text_spell01.Visible = false;
            if (Spellbook.slot_02 != "") { f05_text_spell02.Text = Spellbook.slot_02; f05_text_spell02.Visible = true; }
            else f05_text_spell02.Visible = false;
            if (Spellbook.slot_03 != "") { f05_text_spell03.Text = Spellbook.slot_03; f05_text_spell03.Visible = true; }
            else f05_text_spell03.Visible = false;
            if (Spellbook.slot_04 != "") { f05_text_spell04.Text = Spellbook.slot_04; f05_text_spell04.Visible = true; }
            else f05_text_spell04.Visible = false;
            if (Spellbook.slot_05 != "") { f05_text_spell05.Text = Spellbook.slot_05; f05_text_spell05.Visible = true; }
            else f05_text_spell05.Visible = false;
            if (Spellbook.slot_06 != "") { f05_text_spell06.Text = Spellbook.slot_06; f05_text_spell06.Visible = true; }
            else f05_text_spell06.Visible = false;
            //Class
            if (Globals.class_active == 1)
            {
                f05_text_spells.Visible = false;
                f05_spoints.Visible = false;
            }
            if (Globals.class_active == 4)
            {
                f05_text_spells.Text = "Skills";
                f05_text_skill01.Text = "Locksmith: 0/100";
                f05_text_skill02.Text = "Pickpocketing: 0/100";
                f05_text_skill03.Text = "Sneaking: 0/100";
                f05_text_skill01.Location = f05_text_spell01.Location;
                f05_text_skill02.Location = f05_text_spell02.Location;
                f05_text_skill03.Location = f05_text_spell03.Location;
                f05_text_skill01.Visible = true;
                f05_text_skill02.Visible = true;
                f05_text_skill03.Visible = true;
            }
            if (Globals.class_active == 5)
            {
                f05_text_spells.Text = "Pets";
                f05_text_spell01.Text = "Wolf";
                f05_text_spell02.Text = "Bear";
                f05_text_spell03.Text = "Drake";
                f05_text_spell04.Text = "Raven";
                f05_text_spell05.Text = "Scorpion";
                f05_text_spell06.Text = "Moth";
                f05_text_spell01.Visible = true;
                f05_text_spell02.Visible = true;
                f05_text_spell03.Visible = true;
                f05_text_spell04.Visible = true;
                f05_text_spell05.Visible = true;
                f05_text_spell06.Visible = true;
            }
            //Points
            if (Globals.class_active == 1)
            {
                spellpoint = 0;
                f05_spoints.Text = "Spell Points: " + spellpoint;
                weaponpoint = 4;
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.class_active == 2)
            {
                spellpoint = 1;
                f05_spoints.Text = "Spell Points: " + spellpoint;
                weaponpoint = 3;
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.class_active == 3)
            {
                spellpoint = 1;
                f05_spoints.Text = "Spell Points: " + spellpoint;
                weaponpoint = 3;
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.class_active == 4)
            {
                spellpoint = 60;
                f05_spoints.Text = "Skill Points: " + spellpoint;
                weaponpoint = 3;
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.class_active == 5)
            {
                spellpoint = 1;
                f05_spoints.Text = "Choose Your Pet";
                weaponpoint = 3;
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.class_active == 6)
            {
                spellpoint = 2;
                f05_spoints.Text = "Spell Points: " + spellpoint;
                weaponpoint = 2;
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.class_active == 7)
            {
                spellpoint = 2;
                f05_spoints.Text = "Spell Points: " + spellpoint;
                weaponpoint = 2;
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.class_active == 8)
            {
                spellpoint = 3;
                f05_spoints.Text = "Spell Points: " + spellpoint;
                weaponpoint = 2;
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.origin_human_commoner == true)
            {
                Globals.background_origin = "was born to a poor family of blacksmiths stationed in the eastern temple of the Paladin Order on the shores of Austor's Lake. In your early years, you've aspired to great deeds by observing various travellers and paladins with envious eyes.";
            }
            if (Globals.origin_human_nobility == true)
            {
                Globals.background_origin = "was born as the fourth child of House Talyth - the ruling lords of Eastmarch. You have enjoyed wealth and stature, but soon you've found that as the youngest of your siblings, you could never escape their shadows nor could you prosper above your reputation.";
            }
            if (Globals.origin_moonelf_commoner == true)
            {
                Globals.background_origin = "was born as the child of Yreen's priest. During a vicious siege orchestrated by the Black Empire, you've lost your father to the war and were left with nothing. Unwanting to succumb to despair, you've embraced the world with open arms and left the Moonlands behind.";
            }
            if (Globals.origin_moonelf_nobility == true)
            {
                Globals.background_origin = "was born as the single child of the once great Omalar family. All your life you've struggled to restore your family's position in Elven society, pressured highly by your demanding parents. Having achieved maturity, the burdens of reputation are yours to resolve.";
            }
            if (Globals.origin_sandelf_commoner == true)
            {
                Globals.background_origin = "was born to the Pale Legion in the city of Arakal. You rose through the ranks of the legionnaires with remarkable ease, stirring jealousy from your peers. Betrayed by your former friends, you've been exiled from the Legion and forced to roam the world outside of the Empire.";
            }
            if (Globals.origin_sandelf_nobility == true)
            {
                Globals.background_origin = "was born as the heir to the throne of the Black Empire. Ever since your birth you've been told of seizing a grand future as an entire nation awaited your rule. However, your family was untimely overthrown before you could ascend the throne, leaving you the last of your bloodline.";
            }
            if (Globals.origin_dwarf_commoner == true)
            {
                Globals.background_origin = "was born in Orekin, the child of a dwarven alchemist. After proving yourself in defense against the creatures of the Witherlands, you were rewarded an entry into the Praelium - a tourney that crowned new nobility and a failure that left you a disgrace in the eyes of the city.";
            }
            if (Globals.origin_dwarf_nobility == true)
            {
                Globals.background_origin = "was born as the younger child of Hormith's lords. Your family controls the mithril trade in the Dwarven Republic and they've used its wealth to further their claim to power. While your brother attends to formalities, you were expected to assume a less glorified role.";
            }
            if (Globals.class_active == 1)
            {
                Globals.background_class = "Displaying physical prowess early on, you've spent your days on the road as a mercenary whose reputation of a skilled fighter grew in tale and song with the insistance of your friend Mhaira, a bard from Lakewall.";
            }
            if (Globals.class_active == 2)
            {
                Globals.background_class = "Enamoured by concepts of divine power, you've sought to join the Order yet were refused entry several times until a retired dwarven paladin named Balrigg Riverhorn took you on as his apprentice.";
            }
            if (Globals.class_active == 3)
            {
                Globals.background_class = "Possessing a hatred of forbidden magic, the call of an Inquisitor stirred within your heart and the Order granted you the training you desired under the tutelage of Phaeril Melath - the legendary warlock-huntress.";
            }
            if (Globals.class_active == 4)
            {
                Globals.background_class = "Showing certain talent for the finer aspects of mischief in your youth, your journey takes you to the Disciples of Korvus - an ancient order of rogues with a thirst for competition and occult ritualistic beliefs.";
            }
            if (Globals.class_active == 5)
            {
                Globals.background_class = "Inseparable with your animal companion since birth, you've wandered the land exploring the various secrets it had to offer until the journey took you on a hunt for the Belestani - an enigmatic beast that had always eluded you.";
            }
            if (Globals.class_active == 6)
            {
                Globals.background_class = "A keen bond with nature and a sense for preserving the balance have always defined you. Your potential was recognized by Kosmir, a reclusive moon elf druid living in the deepest glades of Azuremoor as you became his pupil.";
            }
            if (Globals.class_active == 7)
            {
                Globals.background_class = "Chosen as his champion, you've unlocked the powers of divination by becoming the herald of Arrai the Forgotten - a powerful spirit of uncertain motives who offered you the freedom to choose your own path for his tale would grow in turn.";
            }
            if (Globals.class_active == 8)
            {
                Globals.background_class = "Proud of your knowledge in sorcery, you've sought academic study in the Library of Xuren where you've spent five years of audacious study before emerging as an authorized mage alongside your colleague, Kaavys - a braal of the Far North.";
            }
            Globals.background_morality = "You arrive in Bitterleaf after an arduous voyage as you reserve yourself to the local inn...";
            Globals.background = Globals.player_name + " " + Globals.player_surname + " " + Globals.background_origin + Environment.NewLine + Environment.NewLine + Globals.background_class +Environment.NewLine + Environment.NewLine + Globals.background_morality;
            f05_text_background.Text = Globals.background;
        }

        private void f05_strength_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f05_strength.Image = Amethar.Properties.Resources.AttributeStrengthHover;
            f05_text_melee.ForeColor = Color.Gold;
        }

        private void f05_strength_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f05_strength.Image = Amethar.Properties.Resources.AttributeStrengthStatic;
            f05_text_melee.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_dexterity_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f05_dexterity.Image = Amethar.Properties.Resources.AttributeDexterityHover;
            f05_text_armor.ForeColor = Color.Gold;
            if (Globals.class_active == 1 || Globals.class_active == 4 || Globals.class_active == 5) f05_text_ranged.ForeColor = Color.Gold;
        }

        private void f05_dexterity_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f05_dexterity.Image = Amethar.Properties.Resources.AttributeDexterityStatic;
            f05_text_armor.ForeColor = Color.FromArgb(255, 255, 192, 128);
            if (Globals.class_active == 1 || Globals.class_active == 4 || Globals.class_active == 5) f05_text_ranged.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_intelligence_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f05_intelligence.Image = Amethar.Properties.Resources.AttributeIntelligenceHover;
            f05_text_resistance.ForeColor = Color.Gold;
            if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8) f05_text_ranged.ForeColor = Color.Gold;
        }

        private void f05_intelligence_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f05_intelligence.Image = Amethar.Properties.Resources.AttributeIntelligenceStatic;
            f05_text_resistance.ForeColor = Color.FromArgb(255, 255, 192, 128);
            if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8) f05_text_ranged.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_constitution_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f05_constitution.Image = Amethar.Properties.Resources.AttributeConstitutionHover;
            f05_text_health.ForeColor = Color.Gold;
        }

        private void f05_constitution_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f05_constitution.Image = Amethar.Properties.Resources.AttributeConstitutionStatic;
            f05_text_health.ForeColor = Color.Crimson;
        }

        private void f05_wisdom_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f05_wisdom.Image = Amethar.Properties.Resources.AttributeWisdomHover;
            f05_text_mana.ForeColor = Color.Gold;
        }

        private void f05_wisdom_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f05_wisdom.Image = Amethar.Properties.Resources.AttributeWisdomStatic;
            f05_text_mana.ForeColor = Color.DodgerBlue;
        }

        private void f05_charisma_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f05_charisma.Image = Amethar.Properties.Resources.AttributeCharismaHover;
            f05_text_reputation.ForeColor = Color.Gold;
        }

        private void f05_charisma_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f05_charisma.Image = Amethar.Properties.Resources.AttributeCharismaStatic;
            f05_text_reputation.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_formback_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
            f05_button_formback.Image = Amethar.Properties.Resources.ButtonFormBackHover;
        }

        private void f05_formback_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            f05_button_formback.Image = Amethar.Properties.Resources.ButtonFormBack;
        }

        private void f05_add_strength_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_strength_add.Image = Amethar.Properties.Resources.ButtonAddHover;
            f05_strength.Image = Amethar.Properties.Resources.AttributeStrengthHover;
            f05_text_melee.ForeColor = Color.Gold;
        }

        private void f05_add_dexterity_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_dexterity_add.Image = Amethar.Properties.Resources.ButtonAddHover;
            f05_dexterity.Image = Amethar.Properties.Resources.AttributeDexterityHover;
            f05_text_armor.ForeColor = Color.Gold;
            if (Globals.class_active == 1 || Globals.class_active == 4 || Globals.class_active == 5) f05_text_ranged.ForeColor = Color.Gold;
        }

        private void f05_add_intelligence_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_intelligence_add.Image = Amethar.Properties.Resources.ButtonAddHover;
            f05_intelligence.Image = Amethar.Properties.Resources.AttributeIntelligenceHover;
            f05_text_resistance.ForeColor = Color.Gold;
            if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8) f05_text_ranged.ForeColor = Color.Gold;
        }

        private void f05_add_constitution_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_constitution_add.Image = Amethar.Properties.Resources.ButtonAddHover;
            f05_constitution.Image = Amethar.Properties.Resources.AttributeConstitutionHover;
            f05_text_health.ForeColor = Color.Gold;
        }

        private void f05_add_wisdom_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_wisdom_add.Image = Amethar.Properties.Resources.ButtonAddHover;
            f05_wisdom.Image = Amethar.Properties.Resources.AttributeWisdomHover;
            f05_text_mana.ForeColor = Color.Gold;
        }

        private void f05_add_charisma_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_charisma_add.Image = Amethar.Properties.Resources.ButtonAddHover;
            f05_charisma.Image = Amethar.Properties.Resources.AttributeCharismaHover;
            f05_text_reputation.ForeColor = Color.Gold;
        }

        private void f05_sub_strength_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_strength_sub.Image = Amethar.Properties.Resources.ButtonSubHover;
            f05_strength.Image = Amethar.Properties.Resources.AttributeStrengthHover;
            f05_text_melee.ForeColor = Color.Gold;
        }

        private void f05_sub_dexterity_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_dexterity_sub.Image = Amethar.Properties.Resources.ButtonSubHover;
            f05_dexterity.Image = Amethar.Properties.Resources.AttributeDexterityHover;
            f05_text_armor.ForeColor = Color.Gold;
            if (Globals.class_active == 1 || Globals.class_active == 4 || Globals.class_active == 5) f05_text_ranged.ForeColor = Color.Gold;
        }

        private void f05_sub_intelligence_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_intelligence_sub.Image = Amethar.Properties.Resources.ButtonSubHover;
            f05_intelligence.Image = Amethar.Properties.Resources.AttributeIntelligenceHover;
            f05_text_resistance.ForeColor = Color.Gold;
            if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8) f05_text_ranged.ForeColor = Color.Gold;
        }

        private void f05_sub_constitution_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_constitution_sub.Image = Amethar.Properties.Resources.ButtonSubHover;
            f05_constitution.Image = Amethar.Properties.Resources.AttributeConstitutionHover;
            f05_text_health.ForeColor = Color.Gold;
        }

        private void f05_sub_wisdom_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_wisdom_sub.Image = Amethar.Properties.Resources.ButtonSubHover;
            f05_wisdom.Image = Amethar.Properties.Resources.AttributeWisdomHover;
            f05_text_mana.ForeColor = Color.Gold;
        }

        private void f05_sub_charisma_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_charisma_sub.Image = Amethar.Properties.Resources.ButtonSubHover;
            f05_charisma.Image = Amethar.Properties.Resources.AttributeCharismaHover;
            f05_text_reputation.ForeColor = Color.Gold;
        }

        private void f05_add_strength_Leave(object sender, EventArgs e)
        {
            f05_strength_add.Image = Amethar.Properties.Resources.ButtonAddStatic;
            f05_text_melee.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_add_dexterity_Leave(object sender, EventArgs e)
        {
            f05_dexterity_add.Image = Amethar.Properties.Resources.ButtonAddStatic;
            if (Globals.class_active == 1 || Globals.class_active == 4 || Globals.class_active == 5) f05_text_ranged.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_add_intelligence_Leave(object sender, EventArgs e)
        {
            f05_intelligence_add.Image = Amethar.Properties.Resources.ButtonAddStatic;
            if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8) f05_text_ranged.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_add_constitution_Leave(object sender, EventArgs e)
        {
            f05_constitution_add.Image = Amethar.Properties.Resources.ButtonAddStatic;
            f05_text_health.ForeColor = Color.Crimson;
        }

        private void f05_add_wisdom_Leave(object sender, EventArgs e)
        {
            f05_wisdom_add.Image = Amethar.Properties.Resources.ButtonAddStatic;
            f05_text_mana.ForeColor = Color.DodgerBlue;
        }

        private void f05_add_charisma_Leave(object sender, EventArgs e)
        {
            f05_charisma_add.Image = Amethar.Properties.Resources.ButtonAddStatic;
            f05_text_reputation.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_sub_strength_Leave(object sender, EventArgs e)
        {
            f05_strength_sub.Image = Amethar.Properties.Resources.ButtonSubStatic;
            f05_text_melee.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_sub_dexterity_Leave(object sender, EventArgs e)
        {
            f05_dexterity_sub.Image = Amethar.Properties.Resources.ButtonSubStatic;
            if (Globals.class_active == 1 || Globals.class_active == 4 || Globals.class_active == 5) f05_text_ranged.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_sub_intelligence_Leave(object sender, EventArgs e)
        {
            f05_intelligence_sub.Image = Amethar.Properties.Resources.ButtonSubStatic;
            if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8) f05_text_ranged.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_sub_constitution_Leave(object sender, EventArgs e)
        {
            f05_constitution_sub.Image = Amethar.Properties.Resources.ButtonSubStatic;
            f05_text_health.ForeColor = Color.Crimson;
        }

        private void f05_sub_wisdom_Leave(object sender, EventArgs e)
        {
            f05_wisdom_sub.Image = Amethar.Properties.Resources.ButtonSubStatic;
            f05_text_mana.ForeColor = Color.DodgerBlue;
        }

        private void f05_sub_charisma_Leave(object sender, EventArgs e)
        {
            f05_charisma_sub.Image = Amethar.Properties.Resources.ButtonSubStatic;
            f05_text_reputation.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }

        private void f05_strength_add_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (Globals.attribute_points > 0) 
            {
                if (Globals.strength >= 14)
                {
                    if (Globals.attribute_points > 1) { Globals.strength++; Globals.attribute_points -= 2; }
                }
                else if (Globals.strength >= 18)
                {
                    if (Globals.attribute_points > 2) { Globals.strength++; Globals.attribute_points -= 3; }
                }
                else
                {
                    Globals.strength++;
                    Globals.attribute_points--;
                }
                f05_value_strength.Text = Convert.ToString(Globals.strength);
                if (Globals.strength > 10) f05_text_melee.Text = "Melee Damage: +" + Convert.ToString(Globals.strength - 10);
                else if (Globals.strength == 10) f05_text_melee.Text = "Melee Damage: " + Convert.ToString(Globals.strength - 10);
                else if (Globals.strength < 10) f05_text_melee.Text = "Melee Damage: -" + Convert.ToString(Math.Abs(Globals.strength - 10));
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_strength_sub_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
            if (Globals.attribute_points < 20)
            {
                if(Globals.race_active == 1 && Globals.strength > 10)
                {
                    if (Globals.strength > 14)
                    {
                        Globals.strength--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.strength > 18)
                    {
                        Globals.strength--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.strength--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 2 && Globals.strength > 8)
                {
                    if (Globals.strength > 14)
                    {
                        Globals.strength--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.strength > 18)
                    {
                        Globals.strength--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.strength--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 3 && Globals.strength > 11)
                {
                    if (Globals.strength > 14)
                    {
                        Globals.strength--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.strength > 18)
                    {
                        Globals.strength--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.strength--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 4 && Globals.strength > 12)
                {
                    if (Globals.strength > 14)
                    {
                        Globals.strength--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.strength > 18)
                    {
                        Globals.strength--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.strength--;
                        Globals.attribute_points++;
                    }
                }
                f05_value_strength.Text = Convert.ToString(Globals.strength);
                if (Globals.strength > 10) f05_text_melee.Text = "Melee Damage: +" + Convert.ToString(Globals.strength - 10);
                else if (Globals.strength == 10) f05_text_melee.Text = "Melee Damage: " + Convert.ToString(Globals.strength - 10);
                else if (Globals.strength < 10) f05_text_melee.Text = "Melee Damage: -" + Convert.ToString(Math.Abs(Globals.strength - 10));
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_dexterity_add_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (Globals.attribute_points > 0)
            {
                if (Globals.dexterity >= 14)
                {
                    if (Globals.attribute_points > 1) { Globals.dexterity++; Globals.attribute_points -= 2; }
                }
                else if (Globals.dexterity >= 18)
                {
                    if (Globals.attribute_points > 2) { Globals.dexterity++; Globals.attribute_points -= 3; }
                }
                else
                {
                    Globals.dexterity++;
                    Globals.attribute_points--;
                }
                f05_value_dexterity.Text = Convert.ToString(Globals.dexterity);
                if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8)
                {
                    if (Globals.intelligence > 10) f05_text_ranged.Text = "Magic Damage: +" + Convert.ToString(Globals.intelligence - 10);
                    else if (Globals.intelligence == 10) f05_text_ranged.Text = "Magic Damage: " + Convert.ToString(Globals.intelligence - 10);
                    else if (Globals.intelligence < 10) f05_text_ranged.Text = "Magic Damage: -" + Convert.ToString(Math.Abs(Globals.intelligence - 10));
                }
                else
                {
                    if (Globals.dexterity > 10) f05_text_ranged.Text = "Ranged Damage: +" + Convert.ToString(Globals.dexterity - 10);
                    else if (Globals.dexterity == 10) f05_text_ranged.Text = "Ranged Damage: " + Convert.ToString(Globals.dexterity - 10);
                    else if (Globals.dexterity < 10) f05_text_ranged.Text = "Ranged Damage: -" + Convert.ToString(Math.Abs(Globals.dexterity - 10));
                }
                if (Globals.dexterity >= 10) f05_text_armor.Text = "Armor: " + Convert.ToString(Globals.dexterity - 10) + " (" + Globals.armor_class + ")";
                else if (Globals.dexterity < 10) f05_text_armor.Text = "Armor: " + Convert.ToString(0) + " (" + Globals.armor_class + ")";
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_dexterity_sub_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
            if (Globals.attribute_points < 20)
            {
                if (Globals.race_active == 1 && Globals.dexterity > 10)
                {
                    if (Globals.dexterity > 14)
                    {
                        Globals.dexterity--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.dexterity > 18)
                    {
                        Globals.dexterity--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.dexterity--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 2 && Globals.dexterity > 10)
                {
                    if (Globals.dexterity > 14)
                    {
                        Globals.dexterity--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.dexterity > 18)
                    {
                        Globals.dexterity--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.dexterity--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 3 && Globals.dexterity > 12)
                {
                    if (Globals.dexterity > 14)
                    {
                        Globals.dexterity--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.dexterity > 18)
                    {
                        Globals.dexterity--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.dexterity--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 4 && Globals.dexterity > 8)
                {
                    if (Globals.dexterity > 14)
                    {
                        Globals.dexterity--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.dexterity > 18)
                    {
                        Globals.dexterity--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.dexterity--;
                        Globals.attribute_points++;
                    }
                }
                f05_value_dexterity.Text = Convert.ToString(Globals.dexterity);
                if (Globals.class_active == 1 || Globals.class_active == 4 || Globals.class_active == 5)
                {
                    if (Globals.dexterity > 10) f05_text_ranged.Text = "Ranged Damage: +" + Convert.ToString(Globals.dexterity - 10);
                    else if (Globals.dexterity == 10) f05_text_ranged.Text = "Ranged Damage: " + Convert.ToString(Globals.dexterity - 10);
                    else if (Globals.dexterity < 10) f05_text_ranged.Text = "Ranged Damage: -" + Convert.ToString(Math.Abs(Globals.dexterity - 10));
                }
                if (Globals.dexterity >= 10) f05_text_armor.Text = "Armor: " + Convert.ToString(Globals.dexterity - 10) + " (" + Globals.armor_class + ")";
                else if (Globals.dexterity < 10) f05_text_armor.Text = "Armor: " + Convert.ToString(0) + " (" + Globals.armor_class + ")";
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_intelligence_add_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (Globals.attribute_points > 0)
            {
                if (Globals.intelligence >= 14)
                {
                    if (Globals.attribute_points > 1) { Globals.intelligence++; Globals.attribute_points -= 2; }
                }
                else if (Globals.intelligence >= 18)
                {
                    if (Globals.attribute_points > 2) { Globals.intelligence++; Globals.attribute_points -= 3; }
                }
                else
                {
                    Globals.intelligence++;
                    Globals.attribute_points--;
                }
                f05_value_intelligence.Text = Convert.ToString(Globals.intelligence);
                if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8)
                {
                    if (Globals.intelligence > 10) f05_text_ranged.Text = "Magic Damage: +" + Convert.ToString(Globals.intelligence - 10);
                    else if (Globals.intelligence == 10) f05_text_ranged.Text = "Magic Damage: " + Convert.ToString(Globals.intelligence - 10);
                    else if (Globals.intelligence < 10) f05_text_ranged.Text = "Magic Damage: -" + Convert.ToString(Math.Abs(Globals.intelligence - 10));
                }
                f05_text_resistance.Text = "Magic Resistance: " + Convert.ToString(10 + (Globals.intelligence - 10) * 5) + "%";
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_intelligence_sub_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
            if (Globals.attribute_points < 20)
            {
                if (Globals.race_active == 1 && Globals.intelligence > 10)
                {
                    if (Globals.intelligence > 14)
                    {
                        Globals.intelligence--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.intelligence > 18)
                    {
                        Globals.intelligence--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.intelligence--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 2 && Globals.intelligence > 12)
                {
                    if (Globals.intelligence > 14)
                    {
                        Globals.intelligence--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.intelligence > 18)
                    {
                        Globals.intelligence--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.intelligence--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 3 && Globals.intelligence > 10)
                {
                    if (Globals.intelligence > 14)
                    {
                        Globals.intelligence--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.intelligence > 18)
                    {
                        Globals.intelligence--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.intelligence--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 4 && Globals.intelligence > 10)
                {
                    if (Globals.intelligence > 14)
                    {
                        Globals.intelligence--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.intelligence > 18)
                    {
                        Globals.intelligence--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.intelligence--;
                        Globals.attribute_points++;
                    }
                }
                f05_value_intelligence.Text = Convert.ToString(Globals.intelligence);
                if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8)
                {
                    if (Globals.intelligence > 10) f05_text_ranged.Text = "Magic Damage: +" + Convert.ToString(Globals.intelligence - 10);
                    else if (Globals.intelligence == 10) f05_text_ranged.Text = "Magic Damage: " + Convert.ToString(Globals.intelligence - 10);
                    else if (Globals.intelligence < 10) f05_text_ranged.Text = "Magic Damage: -" + Convert.ToString(Math.Abs(Globals.intelligence - 10));
                }
                f05_text_resistance.Text = "Magic Resistance: " + Convert.ToString(10 + (Globals.intelligence - 10) * 5) + "%";
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_constitution_add_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (Globals.attribute_points > 0)
            {
                if (Globals.constitution >= 14)
                {
                    if (Globals.attribute_points > 1) { Globals.constitution++; Globals.attribute_points -= 2; }
                }
                else if (Globals.constitution >= 18)
                {
                    if (Globals.attribute_points > 2) { Globals.constitution++; Globals.attribute_points -= 3; }
                }
                else
                {
                    Globals.constitution++;
                    Globals.attribute_points--;
                }
                Globals.health += 5;
                f05_text_health.Text = "Health: " + Globals.health;
                f05_value_constitution.Text = Convert.ToString(Globals.constitution);
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_constitution_sub_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
            if (Globals.attribute_points < 20)
            {
                if (Globals.race_active == 1 && Globals.constitution > 10)
                {
                    if (Globals.constitution > 14)
                    {
                        Globals.constitution--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.constitution > 18)
                    {
                        Globals.constitution--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.constitution--;
                        Globals.attribute_points++;
                    }
                    Globals.health -= 5;
                }
                if (Globals.race_active == 2 && Globals.constitution > 9)
                {
                    if (Globals.constitution > 14)
                    {
                        Globals.constitution--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.constitution > 18)
                    {
                        Globals.constitution--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.constitution--;
                        Globals.attribute_points++;
                    }
                    Globals.health -= 5;
                }
                if (Globals.race_active == 3 && Globals.constitution > 10)
                {
                    if (Globals.constitution > 14)
                    {
                        Globals.constitution--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.constitution > 18)
                    {
                        Globals.constitution--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.constitution--;
                        Globals.attribute_points++;
                    }
                    Globals.health -= 5;
                }
                if (Globals.race_active == 4 && Globals.constitution > 11)
                {
                    if (Globals.constitution > 14)
                    {
                        Globals.constitution--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.constitution > 18)
                    {
                        Globals.constitution--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.constitution--;
                        Globals.attribute_points++;
                    }
                    Globals.health -= 5;
                }
                f05_text_health.Text = "Health: " + Globals.health;
                f05_value_constitution.Text = Convert.ToString(Globals.constitution);
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_wisdom_add_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (Globals.attribute_points > 0)
            {
                if (Globals.wisdom >= 14)
                {
                    if (Globals.attribute_points > 1) { Globals.wisdom++; Globals.attribute_points -= 2; }
                }
                else if (Globals.wisdom >= 18)
                {
                    if (Globals.attribute_points > 2) { Globals.wisdom++; Globals.attribute_points -= 3; }
                }
                else
                {
                    Globals.wisdom++;
                    Globals.attribute_points--;
                }
                Globals.mana += 1;
                f05_text_mana.Text = "Mana: " + Globals.mana;
                f05_value_wisdom.Text = Convert.ToString(Globals.wisdom);
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_wisdom_sub_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
            if (Globals.attribute_points < 20)
            {
                if (Globals.race_active == 1 && Globals.wisdom > 10)
                {
                    if (Globals.wisdom > 14)
                    {
                        Globals.wisdom--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.wisdom > 18)
                    {
                        Globals.wisdom--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.wisdom--;
                        Globals.attribute_points++;
                    }
                    Globals.mana -= 1;
                }
                if (Globals.race_active == 2 && Globals.wisdom > 10)
                {
                    if (Globals.wisdom > 14)
                    {
                        Globals.wisdom--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.wisdom > 18)
                    {
                        Globals.wisdom--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.wisdom--;
                        Globals.attribute_points++;
                    }
                    Globals.mana -= 1;
                }
                if (Globals.race_active == 3 && Globals.wisdom > 8)
                {
                    if (Globals.wisdom > 14)
                    {
                        Globals.wisdom--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.wisdom > 18)
                    {
                        Globals.wisdom--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.wisdom--;
                        Globals.attribute_points++;
                    }
                    Globals.mana -= 1;
                }
                if (Globals.race_active == 4 && Globals.wisdom > 9)
                {
                    if (Globals.wisdom > 14)
                    {
                        Globals.wisdom--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.wisdom > 18)
                    {
                        Globals.wisdom--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.wisdom--;
                        Globals.attribute_points++;
                    }
                    Globals.mana -= 1;
                }
                f05_text_mana.Text = "Mana: " + Globals.mana;
                f05_value_wisdom.Text = Convert.ToString(Globals.wisdom);
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_charisma_add_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (Globals.attribute_points > 0)
            {
                if (Globals.charisma >= 14)
                {
                    if (Globals.attribute_points > 1) { Globals.charisma++; Globals.attribute_points -= 2; }
                }
                else if (Globals.charisma >= 18)
                {
                    if (Globals.attribute_points > 2) { Globals.charisma++; Globals.attribute_points -= 3; }
                }
                else
                {
                    Globals.charisma++;
                    Globals.attribute_points--;
                }
                f05_value_charisma.Text = Convert.ToString(Globals.charisma);
                f05_text_reputation.Text = "Reputation: " + Convert.ToString(5 + (Globals.charisma - 10) * 2);
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_charisma_sub_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
            if (Globals.attribute_points < 20)
            {
                if (Globals.race_active == 1 && Globals.charisma > 10)
                {
                    if (Globals.charisma > 14)
                    {
                        Globals.charisma--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.charisma > 18)
                    {
                        Globals.charisma--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.charisma--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 2 && Globals.charisma > 11)
                {
                    if (Globals.charisma > 14)
                    {
                        Globals.charisma--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.charisma > 18)
                    {
                        Globals.charisma--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.charisma--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 3 && Globals.charisma > 9)
                {
                    if (Globals.charisma > 14)
                    {
                        Globals.charisma--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.charisma > 18)
                    {
                        Globals.charisma--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.charisma--;
                        Globals.attribute_points++;
                    }
                }
                if (Globals.race_active == 4 && Globals.charisma > 10)
                {
                    if (Globals.charisma > 14)
                    {
                        Globals.charisma--;
                        Globals.attribute_points += 2;
                    }
                    else if (Globals.charisma > 18)
                    {
                        Globals.charisma--;
                        Globals.attribute_points += 3;
                    }
                    else
                    {
                        Globals.charisma--;
                        Globals.attribute_points++;
                    }
                }
                f05_value_charisma.Text = Convert.ToString(Globals.charisma);
                f05_text_reputation.Text = "Reputation: " + Convert.ToString(5 + (Globals.charisma - 10) * 2);
                f05_remaining_points.Text = Convert.ToString(Globals.attribute_points);
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_button_formback_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            Forms.f05_back = 1;
            this.Close();
        }

        private void f05_text_sword_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_sword == true && weaponpoint > 0 && sword < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (sword == 0)
                {
                    f05_text_sword.Font = new Font(f05_text_sword.Font, FontStyle.Bold);
                    f05_text_sword.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_sword_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (sword == 1)
                {
                    f05_sword_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                sword++;
            }
            else if ((f05_sword_01.Visible == true && f05_sword_02.Visible == true) || (f05_sword_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_sword_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_sword_01.Visible = false;
                f05_sword_02.Visible = false;
                sword = 0;
                f05_text_sword.Font = new Font(f05_text_sword.Font, FontStyle.Regular);
                f05_text_sword.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_axe_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_axe == true && weaponpoint > 0 && axe < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (axe == 0)
                {
                    f05_text_axe.Font = new Font(f05_text_axe.Font, FontStyle.Bold);
                    f05_text_axe.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_axe_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (axe == 1)
                {
                    f05_axe_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                axe++;
            }
            else if ((f05_axe_01.Visible == true && f05_axe_02.Visible == true) || (f05_axe_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_axe_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_axe_01.Visible = false;
                f05_axe_02.Visible = false;
                axe = 0;
                f05_text_axe.Font = new Font(f05_text_axe.Font, FontStyle.Regular);
                f05_text_axe.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_mace_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_mace == true && weaponpoint > 0 && mace < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (mace == 0)
                {
                    f05_text_mace.Font = new Font(f05_text_mace.Font, FontStyle.Bold);
                    f05_text_mace.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_mace_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (mace == 1)
                {
                    f05_mace_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                mace++;
            }
            else if ((f05_mace_01.Visible == true && f05_mace_02.Visible == true) || (f05_mace_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_mace_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_mace_01.Visible = false;
                f05_mace_02.Visible = false;
                mace = 0;
                f05_text_mace.Font = new Font(f05_text_mace.Font, FontStyle.Regular);
                f05_text_mace.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_claymore_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_claymore == true && weaponpoint > 0 && claymore < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (claymore == 0)
                {
                    f05_text_claymore.Font = new Font(f05_text_claymore.Font, FontStyle.Bold);
                    f05_text_claymore.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_claymore_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (claymore == 1)
                {
                    f05_claymore_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                claymore++;
            }
            else if ((f05_claymore_01.Visible == true && f05_claymore_02.Visible == true) || (f05_claymore_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_claymore_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_claymore_01.Visible = false;
                f05_claymore_02.Visible = false;
                claymore = 0;
                f05_text_claymore.Font = new Font(f05_text_claymore.Font, FontStyle.Regular);
                f05_text_claymore.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_halberd_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_halberd == true && weaponpoint > 0 && halberd < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (halberd == 0)
                {
                    f05_text_halberd.Font = new Font(f05_text_halberd.Font, FontStyle.Bold);
                    f05_text_halberd.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_halberd_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (halberd == 1)
                {
                    f05_halberd_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                halberd++;
            }
            else if ((f05_halberd_01.Visible == true && f05_halberd_02.Visible == true) || (f05_halberd_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_halberd_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_halberd_01.Visible = false;
                f05_halberd_02.Visible = false;
                halberd = 0;
                f05_text_halberd.Font = new Font(f05_text_halberd.Font, FontStyle.Regular);
                f05_text_halberd.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_hammer_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_hammer == true && weaponpoint > 0 && hammer < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (hammer == 0)
                {
                    f05_text_hammer.Font = new Font(f05_text_hammer.Font, FontStyle.Bold);
                    f05_text_hammer.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_hammer_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (hammer == 1)
                {
                    f05_hammer_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                hammer++;
            }
            else if ((f05_hammer_01.Visible == true && f05_hammer_02.Visible == true) || (f05_hammer_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_hammer_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_hammer_01.Visible = false;
                f05_hammer_02.Visible = false;
                hammer = 0;
                f05_text_hammer.Font = new Font(f05_text_hammer.Font, FontStyle.Regular);
                f05_text_hammer.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_spear_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_spear == true && weaponpoint > 0 && spear < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (spear == 0)
                {
                    f05_text_spear.Font = new Font(f05_text_spear.Font, FontStyle.Bold);
                    f05_text_spear.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_spear_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (spear == 1)
                {
                    f05_spear_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                spear++;
            }
            else if ((f05_spear_01.Visible == true && f05_spear_02.Visible == true) || (f05_spear_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_spear_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_spear_01.Visible = false;
                f05_spear_02.Visible = false;
                spear = 0;
                f05_text_spear.Font = new Font(f05_text_spear.Font, FontStyle.Regular);
                f05_text_spear.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_dagger_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_dagger == true && weaponpoint > 0 && dagger < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (dagger == 0)
                {
                    f05_text_dagger.Font = new Font(f05_text_dagger.Font, FontStyle.Bold);
                    f05_text_dagger.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_dagger_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (dagger == 1)
                {
                    f05_dagger_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                dagger++;
            }
            else if ((f05_dagger_01.Visible == true && f05_dagger_02.Visible == true) || (f05_dagger_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_dagger_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_dagger_01.Visible = false;
                f05_dagger_02.Visible = false;
                dagger = 0;
                f05_text_dagger.Font = new Font(f05_text_dagger.Font, FontStyle.Regular);
                f05_text_dagger.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_quarterstaff_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_quarterstaff == true && weaponpoint > 0 && quarterstaff < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (quarterstaff == 0)
                {
                    f05_text_quarterstaff.Font = new Font(f05_text_quarterstaff.Font, FontStyle.Bold);
                    f05_text_quarterstaff.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_quarterstaff_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (quarterstaff == 1)
                {
                    f05_quarterstaff_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                quarterstaff++;
            }
            else if ((f05_quarterstaff_01.Visible == true && f05_quarterstaff_02.Visible == true) || (f05_quarterstaff_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_quarterstaff_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_quarterstaff_01.Visible = false;
                f05_quarterstaff_02.Visible = false;
                quarterstaff = 0;
                f05_text_quarterstaff.Font = new Font(f05_text_quarterstaff.Font, FontStyle.Regular);
                f05_text_quarterstaff.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_shortbow_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_shortbow == true && weaponpoint > 0 && shortbow < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (shortbow == 0)
                {
                    f05_text_shortbow.Font = new Font(f05_text_shortbow.Font, FontStyle.Bold);
                    f05_text_shortbow.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_shortbow_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (shortbow == 1)
                {
                    f05_shortbow_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                shortbow++;
            }
            else if ((f05_shortbow_01.Visible == true && f05_shortbow_02.Visible == true) || (f05_shortbow_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_shortbow_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_shortbow_01.Visible = false;
                f05_shortbow_02.Visible = false;
                shortbow = 0;
                f05_text_shortbow.Font = new Font(f05_text_shortbow.Font, FontStyle.Regular);
                f05_text_shortbow.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_longbow_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_longbow == true && weaponpoint > 0 && longbow < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (longbow == 0)
                {
                    f05_text_longbow.Font = new Font(f05_text_longbow.Font, FontStyle.Bold);
                    f05_text_longbow.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_longbow_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (longbow == 1)
                {
                    f05_longbow_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                longbow++;
            }
            else if ((f05_longbow_01.Visible == true && f05_longbow_02.Visible == true) || (f05_longbow_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_longbow_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_longbow_01.Visible = false;
                f05_longbow_02.Visible = false;
                longbow = 0;
                f05_text_longbow.Font = new Font(f05_text_longbow.Font, FontStyle.Regular);
                f05_text_longbow.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_shield_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_shield == true && weaponpoint > 0 && shield < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (shield == 0)
                {
                    f05_text_shield.Font = new Font(f05_text_shield.Font, FontStyle.Bold);
                    f05_text_shield.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_shield_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (shield == 1)
                {
                    f05_shield_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                shield++;
            }
            else if ((f05_shield_01.Visible == true && f05_shield_02.Visible == true) || (f05_shield_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_shield_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_shield_01.Visible = false;
                f05_shield_02.Visible = false;
                shield = 0;
                f05_text_shield.Font = new Font(f05_text_shield.Font, FontStyle.Regular);
                f05_text_shield.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_dualwield_Click(object sender, EventArgs e)
        {
            if (Weapons.skill_dualwield == true && weaponpoint > 0 && dualwield < 2)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                if (dualwield == 0)
                {
                    f05_text_dualwield.Font = new Font(f05_text_dualwield.Font, FontStyle.Bold);
                    f05_text_dualwield.ForeColor = Color.FromArgb(255, 100, 225, 100);
                    f05_dualwield_01.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                if (dualwield == 1)
                {
                    f05_dualwield_02.Visible = true;
                    weaponpoint--; f05_wpoints.Text = "Weapon Points: " + weaponpoint;
                }
                dualwield++;
            }
            else if ((f05_dualwield_01.Visible == true && f05_dualwield_02.Visible == true) || (f05_dualwield_01.Visible == true && weaponpoint == 0))
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                if (f05_dualwield_02.Visible == true) weaponpoint += 2;
                else weaponpoint += 1;
                f05_dualwield_01.Visible = false;
                f05_dualwield_02.Visible = false;
                dualwield = 0;
                f05_text_dualwield.Font = new Font(f05_text_dualwield.Font, FontStyle.Regular);
                f05_text_dualwield.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_wpoints.Text = "Weapon Points: " + weaponpoint;
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_sword_Move(object sender, MouseEventArgs e)
        {
            if (sword == 0 && Weapons.skill_sword == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_sword.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_sword_Leave(object sender, EventArgs e)
        {
            if (sword == 0 && Weapons.skill_sword == true)
            {
                Buttons.soundfx = true;
                f05_text_sword.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_axe_Move(object sender, MouseEventArgs e)
        {
            if (axe == 0 && Weapons.skill_axe == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_axe.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_axe_Leave(object sender, EventArgs e)
        {
            if (axe == 0 && Weapons.skill_axe == true)
            {
                Buttons.soundfx = true;
                f05_text_axe.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_mace_Move(object sender, MouseEventArgs e)
        {
            if (mace == 0 && Weapons.skill_mace == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_mace.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_mace_Leave(object sender, EventArgs e)
        {
            if (mace == 0 && Weapons.skill_mace == true)
            {
                Buttons.soundfx = true;
                f05_text_mace.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_claymore_Move(object sender, MouseEventArgs e)
        {
            if (claymore == 0 && Weapons.skill_claymore == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_claymore.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_claymore_Leave(object sender, EventArgs e)
        {
            if (claymore == 0 && Weapons.skill_claymore == true)
            {
                Buttons.soundfx = true;
                f05_text_claymore.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_halberd_Move(object sender, MouseEventArgs e)
        {
            if (halberd == 0 && Weapons.skill_halberd == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_halberd.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_halberd_Leave(object sender, EventArgs e)
        {
            if (halberd == 0 && Weapons.skill_halberd == true)
            {
                Buttons.soundfx = true;
                f05_text_halberd.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_hammer_Move(object sender, MouseEventArgs e)
        {
            if (hammer == 0 && Weapons.skill_hammer == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_hammer.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_hammer_Leave(object sender, EventArgs e)
        {
            if (hammer == 0 && Weapons.skill_hammer == true)
            {
                Buttons.soundfx = true;
                f05_text_hammer.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_spear_Move(object sender, MouseEventArgs e)
        {
            if (spear == 0 && Weapons.skill_spear == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_spear.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_spear_Leave(object sender, EventArgs e)
        {
            if (spear == 0 && Weapons.skill_spear == true)
            {
                Buttons.soundfx = true;
                f05_text_spear.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_dagger_Move(object sender, MouseEventArgs e)
        {
            if (dagger == 0 && Weapons.skill_dagger == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_dagger.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_dagger_Leave(object sender, EventArgs e)
        {
            if (dagger == 0 && Weapons.skill_dagger == true)
            {
                Buttons.soundfx = true;
                f05_text_dagger.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_quarterstaff_Move(object sender, MouseEventArgs e)
        {
            if (quarterstaff == 0 && Weapons.skill_quarterstaff == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_quarterstaff.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_quarterstaff_Leave(object sender, EventArgs e)
        {
            if (quarterstaff == 0 && Weapons.skill_quarterstaff == true)
            {
                Buttons.soundfx = true;
                f05_text_quarterstaff.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_shortbow_Move(object sender, MouseEventArgs e)
        {
            if (shortbow == 0 && Weapons.skill_shortbow == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_shortbow.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_shortbow_Leave(object sender, EventArgs e)
        {
            if (shortbow == 0 && Weapons.skill_shortbow == true)
            {
                Buttons.soundfx = true;
                f05_text_shortbow.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_longbow_Move(object sender, MouseEventArgs e)
        {
            if (longbow == 0 && Weapons.skill_longbow == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_longbow.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_longbow_Leave(object sender, EventArgs e)
        {
            if (longbow == 0 && Weapons.skill_longbow == true)
            {
                Buttons.soundfx = true;
                f05_text_longbow.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_shield_Move(object sender, MouseEventArgs e)
        {
            if (shield == 0 && Weapons.skill_shield == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_shield.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_shield_Leave(object sender, EventArgs e)
        {
            if (shield == 0 && Weapons.skill_shield == true)
            {
                Buttons.soundfx = true;
                f05_text_shield.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_dualwield_Move(object sender, MouseEventArgs e)
        {
            if (dualwield == 0 && Weapons.skill_dualwield == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_dualwield.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_dualwield_Leave(object sender, EventArgs e)
        {
            if (dualwield == 0 && Weapons.skill_dualwield == true)
            {
                Buttons.soundfx = true;
                f05_text_dualwield.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_text_spell01_Click(object sender, EventArgs e)
        {
            if (Globals.class_active != 5)
            {
                if (Spellbook.slot_01 != "" && spellpoint > 0 && spell01 == false)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell01.ForeColor = Color.RoyalBlue;
                    f05_text_spell01.Font = new Font(f05_text_spell01.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell01 = true;
                }
                else if (spell01 == true)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell01.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell01.Font = new Font(f05_text_spell01.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell01 = false;
                }
            }
            else
            {
                if (wolf == false && spellpoint > 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell01.ForeColor = Color.LimeGreen;
                    f05_text_spell01.Font = new Font(f05_text_spell01.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Pet Chosen";
                    wolf = true;
                }
                else if (wolf == true && spellpoint == 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell01.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell01.Font = new Font(f05_text_spell01.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Choose Your Pet";
                    wolf = false;
                }
                else
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell01.ForeColor = Color.LimeGreen;
                    f05_text_spell01.Font = new Font(f05_text_spell01.Font, FontStyle.Bold);
                    wolf = true;
                    bear = false;
                    drake = false;
                    raven = false;
                    scorpion = false;
                    moth = false;
                    f05_text_spell02.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell02.Font = new Font(f05_text_spell02.Font, FontStyle.Regular);
                    f05_text_spell03.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell03.Font = new Font(f05_text_spell03.Font, FontStyle.Regular);
                    f05_text_spell04.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell04.Font = new Font(f05_text_spell04.Font, FontStyle.Regular);
                    f05_text_spell05.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell05.Font = new Font(f05_text_spell05.Font, FontStyle.Regular);
                    f05_text_spell06.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Regular);
                }
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_spell02_Click(object sender, EventArgs e)
        {
            if (Globals.class_active != 5)
            {
                if (Spellbook.slot_02 != "" && spellpoint > 0 && spell02 == false)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell02.ForeColor = Color.RoyalBlue;
                    f05_text_spell02.Font = new Font(f05_text_spell02.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell02 = true;
                }
                else if (spell02 == true)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell02.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell02.Font = new Font(f05_text_spell02.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell02 = false;
                }
            }
            else
            {
                if (bear == false && spellpoint > 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell02.ForeColor = Color.LimeGreen;
                    f05_text_spell02.Font = new Font(f05_text_spell02.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Pet Chosen";
                    bear = true;
                }
                else if (bear == true && spellpoint == 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell02.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell02.Font = new Font(f05_text_spell02.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Choose Your Pet";
                    bear = false;
                }
                else
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell02.ForeColor = Color.LimeGreen;
                    f05_text_spell02.Font = new Font(f05_text_spell02.Font, FontStyle.Bold);
                    bear = true;
                    wolf = false;
                    drake = false;
                    raven = false;
                    scorpion = false;
                    moth = false;
                    f05_text_spell01.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell01.Font = new Font(f05_text_spell02.Font, FontStyle.Regular);
                    f05_text_spell03.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell03.Font = new Font(f05_text_spell03.Font, FontStyle.Regular);
                    f05_text_spell04.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell04.Font = new Font(f05_text_spell04.Font, FontStyle.Regular);
                    f05_text_spell05.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell05.Font = new Font(f05_text_spell05.Font, FontStyle.Regular);
                    f05_text_spell06.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Regular);
                }
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_spell03_Click(object sender, EventArgs e)
        {
            if (Globals.class_active != 5)
            {
                if (Spellbook.slot_03 != "" && spellpoint > 0 && spell03 == false)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell03.ForeColor = Color.RoyalBlue;
                    f05_text_spell03.Font = new Font(f05_text_spell03.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell03 = true;
                }
                else if (spell03 == true)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell03.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell03.Font = new Font(f05_text_spell03.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell03 = false;
                }
            }
            else
            {
                if (drake == false && spellpoint > 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell03.ForeColor = Color.LimeGreen;
                    f05_text_spell03.Font = new Font(f05_text_spell03.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Pet Chosen";
                    drake = true;
                }
                else if (drake == true && spellpoint == 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell03.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell03.Font = new Font(f05_text_spell03.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Choose Your Pet";
                    drake = false;
                }
                else
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell03.ForeColor = Color.LimeGreen;
                    f05_text_spell03.Font = new Font(f05_text_spell03.Font, FontStyle.Bold);
                    drake = true;
                    wolf = false;
                    bear = false;
                    raven = false;
                    scorpion = false;
                    moth = false;
                    f05_text_spell01.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell01.Font = new Font(f05_text_spell02.Font, FontStyle.Regular);
                    f05_text_spell02.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell02.Font = new Font(f05_text_spell03.Font, FontStyle.Regular);
                    f05_text_spell04.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell04.Font = new Font(f05_text_spell04.Font, FontStyle.Regular);
                    f05_text_spell05.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell05.Font = new Font(f05_text_spell05.Font, FontStyle.Regular);
                    f05_text_spell06.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Regular);
                }
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_spell04_Click(object sender, EventArgs e)
        {
            if (Globals.class_active != 5)
            {
                if (Spellbook.slot_04 != "" && spellpoint > 0 && spell04 == false)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell04.ForeColor = Color.RoyalBlue;
                    f05_text_spell04.Font = new Font(f05_text_spell04.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell04 = true;
                }
                else if (spell04 == true)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell04.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell04.Font = new Font(f05_text_spell04.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell04 = false;
                }
            }
            else
            {
                if (raven == false && spellpoint > 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell04.ForeColor = Color.LimeGreen;
                    f05_text_spell04.Font = new Font(f05_text_spell04.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Pet Chosen";
                    raven = true;
                }
                else if (raven == true && spellpoint == 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell04.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell04.Font = new Font(f05_text_spell04.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Choose Your Pet";
                    raven = false;
                }
                else
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell04.ForeColor = Color.LimeGreen;
                    f05_text_spell04.Font = new Font(f05_text_spell04.Font, FontStyle.Bold);
                    raven = true;
                    wolf = false;
                    bear = false;
                    drake = false;
                    scorpion = false;
                    moth = false;
                    f05_text_spell01.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell01.Font = new Font(f05_text_spell02.Font, FontStyle.Regular);
                    f05_text_spell02.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell02.Font = new Font(f05_text_spell03.Font, FontStyle.Regular);
                    f05_text_spell03.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell03.Font = new Font(f05_text_spell04.Font, FontStyle.Regular);
                    f05_text_spell05.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell05.Font = new Font(f05_text_spell05.Font, FontStyle.Regular);
                    f05_text_spell06.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Regular);
                }
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_spell05_Click(object sender, EventArgs e)
        {
            if (Globals.class_active != 5)
            {
                if (Spellbook.slot_05 != "" && spellpoint > 0 && spell05 == false)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell05.ForeColor = Color.RoyalBlue;
                    f05_text_spell05.Font = new Font(f05_text_spell05.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell05 = true;
                }
                else if (spell05 == true)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell05.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell05.Font = new Font(f05_text_spell05.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell05 = false;
                }
            }
            else
            {
                if (scorpion == false && spellpoint > 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell05.ForeColor = Color.LimeGreen;
                    f05_text_spell05.Font = new Font(f05_text_spell05.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Pet Chosen";
                    scorpion = true;
                }
                else if (scorpion == true && spellpoint == 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell05.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell05.Font = new Font(f05_text_spell05.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Choose Your Pet";
                    scorpion = false;
                }
                else
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell05.ForeColor = Color.LimeGreen;
                    f05_text_spell05.Font = new Font(f05_text_spell05.Font, FontStyle.Bold);
                    scorpion = true;
                    wolf = false;
                    bear = false;
                    drake = false;
                    raven = false;
                    moth = false;
                    f05_text_spell01.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell01.Font = new Font(f05_text_spell02.Font, FontStyle.Regular);
                    f05_text_spell02.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell02.Font = new Font(f05_text_spell03.Font, FontStyle.Regular);
                    f05_text_spell03.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell03.Font = new Font(f05_text_spell04.Font, FontStyle.Regular);
                    f05_text_spell04.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell04.Font = new Font(f05_text_spell05.Font, FontStyle.Regular);
                    f05_text_spell06.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Regular);
                }
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_spell06_Click(object sender, EventArgs e)
        {
            if (Globals.class_active != 5)
            {
                if (Spellbook.slot_06 != "" && spellpoint > 0 && spell06 == false)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell06.ForeColor = Color.RoyalBlue;
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell06 = true;
                }
                else if (spell06 == true)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell06.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Spell Points: " + spellpoint;
                    spell06 = false;
                }
            }
            else
            {
                if (moth == false && spellpoint > 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell06.ForeColor = Color.LimeGreen;
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Bold);
                    spellpoint--;
                    f05_spoints.Text = "Pet Chosen";
                    moth = true;
                }
                else if (moth == true && spellpoint == 0)
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                    f05_text_spell06.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Regular);
                    spellpoint++;
                    f05_spoints.Text = "Choose Your Pet";
                    moth = false;
                }
                else
                {
                    Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                    f05_text_spell06.ForeColor = Color.LimeGreen;
                    f05_text_spell06.Font = new Font(f05_text_spell06.Font, FontStyle.Bold);
                    moth = true;
                    wolf = false;
                    bear = false;
                    drake = false;
                    raven = false;
                    scorpion = false;
                    f05_text_spell01.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell01.Font = new Font(f05_text_spell02.Font, FontStyle.Regular);
                    f05_text_spell02.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell02.Font = new Font(f05_text_spell03.Font, FontStyle.Regular);
                    f05_text_spell03.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell03.Font = new Font(f05_text_spell04.Font, FontStyle.Regular);
                    f05_text_spell04.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell04.Font = new Font(f05_text_spell05.Font, FontStyle.Regular);
                    f05_text_spell05.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    f05_text_spell05.Font = new Font(f05_text_spell06.Font, FontStyle.Regular);
                }
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_spell01_Move(object sender, MouseEventArgs e)
        {
            if (f05_text_spell01.Text != "" && spell01 == false && wolf == false)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_spell01.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_spell01_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (f05_text_spell01.Text != "" && spell01 == false && wolf == false)
            {
                f05_text_spell01.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_spell02_Move(object sender, MouseEventArgs e)
        {
            if (f05_text_spell02.Text != "" && spell02 == false && bear == false)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_spell02.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_spell02_Leave(object sender, EventArgs e)
        {
            if (f05_text_spell02.Text != "" && spell02 == false && bear == false)
            {
                Buttons.soundfx = true;
                f05_text_spell02.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_spell03_Move(object sender, MouseEventArgs e)
        {
            if (f05_text_spell03.Text != "" && spell03 == false && drake == false)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_spell03.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_spell03_Leave(object sender, EventArgs e)
        {
            if (f05_text_spell03.Text != "" && spell03 == false && drake == false)
            {
                Buttons.soundfx = true;
                f05_text_spell03.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_spell04_Move(object sender, MouseEventArgs e)
        {
            if (f05_text_spell04.Text != "" && spell04 == false && raven == false)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_spell04.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_spell04_Leave(object sender, EventArgs e)
        {
            if (f05_text_spell04.Text != "" && spell04 == false && raven == false)
            {
                Buttons.soundfx = true;
                f05_text_spell04.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_spell05_Move(object sender, MouseEventArgs e)
        {
            if (f05_text_spell05.Text != "" && spell05 == false && scorpion == false)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_spell05.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_spell05_Leave(object sender, EventArgs e)
        {
            if (f05_text_spell05.Text != "" && spell05 == false && scorpion == false)
            {
                Buttons.soundfx = true;
                f05_text_spell05.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_spell06_Move(object sender, MouseEventArgs e)
        {
            if (f05_text_spell06.Text != "" && spell06 == false && moth == false)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_spell06.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_spell06_Leave(object sender, EventArgs e)
        {
            if (f05_text_spell06.Text != "" && spell06 == false && moth == false)
            {
                Buttons.soundfx = true;
                f05_text_spell06.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }
        private void f05_skill01_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_active == 4 && skill01 == 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_skill01.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_skill01_Leave(object sender, EventArgs e)
        {
            if (Globals.class_active == 4 && skill01 == 0)
            {
                Buttons.soundfx = true;
                f05_text_skill01.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }
        private void f05_skill02_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_active == 4 && skill02 == 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_skill02.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_skill02_Leave(object sender, EventArgs e)
        {
            if (Globals.class_active == 4 && skill02 == 0)
            {
                Buttons.soundfx = true;
                f05_text_skill02.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }
        private void f05_skill03_Move(object sender, MouseEventArgs e)
        {
            if (Globals.class_active == 4 && skill03 == 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                    Buttons.soundfx = false;
                }
                f05_text_skill03.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }

        private void f05_skill03_Leave(object sender, EventArgs e)
        {
            if (Globals.class_active == 4 && skill03 == 0)
            {
                Buttons.soundfx = true;
                f05_text_skill03.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
        }

        private void f05_text_skill01_Click(object sender, EventArgs e)
        {
            if (spellpoint > 0 && skill01 >= 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                f05_text_skill01.ForeColor = Color.DarkOrange;
                f05_text_skill01.Font = new Font(f05_text_skill01.Font, FontStyle.Bold);
                spellpoint -= 10;
                f05_spoints.Text = "Skill Points: " + spellpoint;
                skill01 += 10;
                f05_text_skill01.Text = "Locksmith: " + skill01 + "/100";
            }
            else if (skill01 == 60 || spellpoint == 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f05_text_skill01.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_text_skill01.Font = new Font(f05_text_skill01.Font, FontStyle.Regular);
                spellpoint += skill01;
                f05_spoints.Text = "Skill Points: " + spellpoint;
                skill01 = 0;
                f05_text_skill01.Text = "Locksmith: " + skill01 + "/100";
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_skill02_Click(object sender, EventArgs e)
        {
            if (spellpoint > 0 && skill02 >= 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                f05_text_skill02.ForeColor = Color.DarkOrange;
                f05_text_skill02.Font = new Font(f05_text_skill01.Font, FontStyle.Bold);
                spellpoint -= 10;
                f05_spoints.Text = "Skill Points: " + spellpoint;
                skill02 += 10;
                f05_text_skill02.Text = "Pickpocketing: " + skill02 + "/100";
            }
            else if (skill02 == 60 || spellpoint == 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f05_text_skill02.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_text_skill02.Font = new Font(f05_text_skill01.Font, FontStyle.Regular);
                spellpoint += skill02;
                f05_spoints.Text = "Skill Points: " + spellpoint;
                skill02 = 0;
                f05_text_skill02.Text = "Pickpocketing: " + skill02 + "/100";
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_text_skill03_Click(object sender, EventArgs e)
        {
            if (spellpoint > 0 && skill03 >= 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                f05_text_skill03.ForeColor = Color.DarkOrange;
                f05_text_skill03.Font = new Font(f05_text_skill03.Font, FontStyle.Bold);
                spellpoint -= 10;
                f05_spoints.Text = "Skill Points: " + spellpoint;
                skill03 += 10;
                f05_text_skill03.Text = "Sneaking: " + skill03 + "/100";
            }
            else if (skill01 == 60 || spellpoint == 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                f05_text_skill03.ForeColor = Color.FromArgb(255, 255, 192, 128);
                f05_text_skill03.Font = new Font(f05_text_skill01.Font, FontStyle.Regular);
                spellpoint += skill03;
                f05_spoints.Text = "Skill Points: " + spellpoint;
                skill03 = 0;
                f05_text_skill03.Text = "Sneaking: " + skill03 + "/100";
            }
            if (Globals.attribute_points == 0 && weaponpoint == 0 && spellpoint == 0)
            {
                Forms.f05_confirm = 1;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
            }
            else
            {
                Forms.f05_confirm = 0;
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmStatic;
            }
        }

        private void f05_button_abilities_Click(object sender, EventArgs e)
        {
            if (button_abilities == false)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                button_abilities = true;
                button_background = false;
                f05_panel_abilities.Visible = true;
                f05_text_background.Visible = false;
                f05_title_background.Visible = false;
                f05_button_abilities.Image = Amethar.Properties.Resources.ButtonAbilitiesActive;
                f05_button_background.Image = Amethar.Properties.Resources.ButtonBackgroundStatic;
            }
        }

        private void f05_button_background_Click(object sender, EventArgs e)
        {
            if (button_background == false)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                button_background = true;
                button_abilities = false;
                f05_panel_abilities.Visible = false;
                f05_text_background.Location = new Point(348, 173);
                f05_title_background.Location = new Point(348, 153);
                f05_text_background.Visible = true;
                f05_title_background.Visible = true;
                f05_button_background.Image = Amethar.Properties.Resources.ButtonBackgroundActive;
                f05_button_abilities.Image = Amethar.Properties.Resources.ButtonAbilitiesStatic;
            }
        }

        private void f05_background_Move(object sender, MouseEventArgs e)
        {
            if (button_background == false)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f05_button_background.Image = Amethar.Properties.Resources.ButtonBackgroundHover;
            }
        }

        private void f05_background_Leave(object sender, EventArgs e)
        {
            if (button_background == false)
            {
                Buttons.soundfx = true;
                f05_button_background.Image = Amethar.Properties.Resources.ButtonBackgroundStatic;
            }
        }

        private void f05_abilities_Move(object sender, MouseEventArgs e)
        {
            if (button_abilities == false)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f05_button_abilities.Image = Amethar.Properties.Resources.ButtonAbilitiesHover;
            }
        }

        private void f05_abilities_Leave(object sender, EventArgs e)
        {
            if (button_abilities == false)
            {
                Buttons.soundfx = true;
                f05_button_abilities.Image = Amethar.Properties.Resources.ButtonAbilitiesStatic;
            }
        }

        private void f05_button_confirm_Move(object sender, MouseEventArgs e)
        {
            if (Forms.f05_confirm == 1)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmHover;
            }
        }

        private void f05_button_confirm_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (Forms.f05_confirm == 1) f05_button_confirm.Image = Amethar.Properties.Resources.ButtonsConfirmPressed;
        }

        private void f05_button_confirm_Click(object sender, EventArgs e)
        {
            if (Forms.f05_confirm == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                Weapons.level_sword = sword;
                Weapons.level_axe = axe;
                Weapons.level_mace = mace;
                Weapons.level_claymore = claymore;
                Weapons.level_halberd = halberd;
                Weapons.level_hammer = hammer;
                Weapons.level_spear = spear;
                Weapons.level_dagger = dagger;
                Weapons.level_quarterstaff = quarterstaff;
                Weapons.level_shortbow = shortbow;
                Weapons.level_longbow = longbow;
                Weapons.level_shield = shield;
                Weapons.level_dualwield = dualwield;
                Globals.fire_resistance = 10 + (Globals.intelligence - 10) * 5;
                Globals.ice_resistance = 10 + (Globals.intelligence - 10) * 5;
                Globals.lightning_resistance = 10 + (Globals.intelligence - 10) * 5;
                Globals.melee_bonus = Globals.strength - 10;
                Globals.ranged_bonus = Globals.dexterity - 10;
                Globals.magic_bonus = Globals.intelligence - 10;
                if (Globals.class_active == 2)
                {
                    if (spell01 == true) Spellbook.detectevil = 1;
                    if (spell02 == true) Spellbook.aegis = 1;
                }
                if (Globals.class_active == 3)
                {
                    if (spell01 == true) Spellbook.smite = 1;
                    if (spell02 == true) Spellbook.detectevil = 1;
                }
                if (Globals.class_active == 6)
                {
                    if (spell01 == true) Spellbook.moonblast = 1;
                    if (spell02 == true) Spellbook.lightningbolt = 1;
                    if (spell03 == true) Spellbook.entangle = 1;
                    if (spell04 == true) Spellbook.rejuvenation = 1;
                }
                if (Globals.class_active == 7)
                {
                    if (spell01 == true) Spellbook.detectevil = 1;
                    if (spell02 == true) Spellbook.smite = 1;
                    if (spell03 == true) Spellbook.aegis = 1;
                    if (spell04 == true) Spellbook.identify = 1;
                }
                if (Globals.class_active == 8)
                {
                    if (spell01 == true) Spellbook.lightningbolt = 1;
                    if (spell02 == true) Spellbook.frostbolt = 1;
                    if (spell03 == true) Spellbook.magicmissile = 1;
                    if (spell04 == true) Spellbook.detectinvisibility = 1;
                    if (spell05 == true) Spellbook.flamestrike = 1;
                    if (spell06 == true) Spellbook.identify = 1;
                }
                Storyline.progress_main = 1;
                Int32 index = 0;
                string path = Application.StartupPath + Path.DirectorySeparatorChar + "characters" + Path.DirectorySeparatorChar;
                if (Directory.Exists(path) == false) Directory.CreateDirectory(path);
                foreach (string s in Directory.GetDirectories(path)) index++;
                String I;
                if (index < 10) I = "0" + index;
                else I = Convert.ToString(index);
                String S = Application.StartupPath + Path.DirectorySeparatorChar + "characters" + Path.DirectorySeparatorChar + I + "_" + Globals.player_name + Globals.player_surname;
                Directory.CreateDirectory(S);
                StreamWriter SW = new StreamWriter(S + Path.DirectorySeparatorChar + "character.ame");
                Globals.portrait_active.Image.Save(S + Path.DirectorySeparatorChar + "portrait.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                {
                    //Main
                    SW.WriteLine("<Main>");
                    SW.WriteLine(Convert.ToString(Globals.player_name));
                    SW.WriteLine(Convert.ToString(Globals.player_surname));
                    SW.WriteLine(Convert.ToString(Globals.gender_active));
                    SW.WriteLine(Convert.ToString(Globals.race_active));
                    SW.WriteLine(Convert.ToString(Globals.class_active));
                    SW.WriteLine(Convert.ToString(Globals.goodevil_points));
                    SW.WriteLine(Convert.ToString(Globals.lawchaos_points));
                    SW.WriteLine(Convert.ToString(Globals.level));
                    SW.WriteLine(Convert.ToString(Globals.origin_human_commoner));
                    SW.WriteLine(Convert.ToString(Globals.origin_human_nobility));
                    SW.WriteLine(Convert.ToString(Globals.origin_moonelf_commoner));
                    SW.WriteLine(Convert.ToString(Globals.origin_moonelf_nobility));
                    SW.WriteLine(Convert.ToString(Globals.origin_sandelf_commoner));
                    SW.WriteLine(Convert.ToString(Globals.origin_sandelf_nobility));
                    SW.WriteLine(Convert.ToString(Globals.origin_dwarf_commoner));
                    SW.WriteLine(Convert.ToString(Globals.origin_dwarf_nobility));
                    //Attributes
                    SW.WriteLine("<Attributes>");
                    SW.WriteLine(Convert.ToString(Globals.strength));
                    SW.WriteLine(Convert.ToString(Globals.dexterity));
                    SW.WriteLine(Convert.ToString(Globals.intelligence));
                    SW.WriteLine(Convert.ToString(Globals.constitution));
                    SW.WriteLine(Convert.ToString(Globals.wisdom));
                    SW.WriteLine(Convert.ToString(Globals.charisma));
                    //Stats
                    SW.WriteLine("<Stats>");
                    SW.WriteLine(Convert.ToString(Globals.health));
                    SW.WriteLine(Convert.ToString(Globals.mana));
                    SW.WriteLine(Convert.ToString(Globals.melee_bonus));
                    SW.WriteLine(Convert.ToString(Globals.ranged_bonus));
                    SW.WriteLine(Convert.ToString(Globals.magic_bonus));
                    SW.WriteLine(Convert.ToString(Globals.armor_class));
                    SW.WriteLine(Convert.ToString(Globals.armor));
                    SW.WriteLine(Convert.ToString(Globals.fire_resistance));
                    SW.WriteLine(Convert.ToString(Globals.ice_resistance));
                    SW.WriteLine(Convert.ToString(Globals.lightning_resistance));
                    SW.WriteLine(Convert.ToString(Globals.poison_resistance));
                    SW.WriteLine(Convert.ToString(Globals.disease_resistance));
                    SW.WriteLine(Convert.ToString(Globals.reputation));
                    //Weapons
                    SW.WriteLine("<Weapons>");
                    SW.WriteLine(Convert.ToString(Weapons.skill_sword));
                    SW.WriteLine(Convert.ToString(Weapons.tier_sword));
                    SW.WriteLine(Convert.ToString(Weapons.level_sword));
                    SW.WriteLine(Convert.ToString(Weapons.skill_axe));
                    SW.WriteLine(Convert.ToString(Weapons.tier_axe));
                    SW.WriteLine(Convert.ToString(Weapons.level_axe));
                    SW.WriteLine(Convert.ToString(Weapons.skill_mace));
                    SW.WriteLine(Convert.ToString(Weapons.tier_mace));
                    SW.WriteLine(Convert.ToString(Weapons.level_mace));
                    SW.WriteLine(Convert.ToString(Weapons.skill_claymore));
                    SW.WriteLine(Convert.ToString(Weapons.tier_claymore));
                    SW.WriteLine(Convert.ToString(Weapons.level_claymore));
                    SW.WriteLine(Convert.ToString(Weapons.skill_halberd));
                    SW.WriteLine(Convert.ToString(Weapons.tier_halberd));
                    SW.WriteLine(Convert.ToString(Weapons.level_halberd));
                    SW.WriteLine(Convert.ToString(Weapons.skill_hammer));
                    SW.WriteLine(Convert.ToString(Weapons.tier_hammer));
                    SW.WriteLine(Convert.ToString(Weapons.level_hammer));
                    SW.WriteLine(Convert.ToString(Weapons.skill_spear));
                    SW.WriteLine(Convert.ToString(Weapons.tier_spear));
                    SW.WriteLine(Convert.ToString(Weapons.level_spear));
                    SW.WriteLine(Convert.ToString(Weapons.skill_dagger));
                    SW.WriteLine(Convert.ToString(Weapons.tier_dagger));
                    SW.WriteLine(Convert.ToString(Weapons.level_dagger));
                    SW.WriteLine(Convert.ToString(Weapons.skill_quarterstaff));
                    SW.WriteLine(Convert.ToString(Weapons.tier_quarterstaff));
                    SW.WriteLine(Convert.ToString(Weapons.level_quarterstaff));
                    SW.WriteLine(Convert.ToString(Weapons.skill_shortbow));
                    SW.WriteLine(Convert.ToString(Weapons.tier_shortbow));
                    SW.WriteLine(Convert.ToString(Weapons.level_shortbow));
                    SW.WriteLine(Convert.ToString(Weapons.skill_longbow));
                    SW.WriteLine(Convert.ToString(Weapons.tier_longbow));
                    SW.WriteLine(Convert.ToString(Weapons.level_longbow));
                    SW.WriteLine(Convert.ToString(Weapons.skill_shield));
                    SW.WriteLine(Convert.ToString(Weapons.tier_shield));
                    SW.WriteLine(Convert.ToString(Weapons.level_shield));
                    SW.WriteLine(Convert.ToString(Weapons.skill_dualwield));
                    SW.WriteLine(Convert.ToString(Weapons.tier_dualwield));
                    SW.WriteLine(Convert.ToString(Weapons.level_dualwield));
                    //Spellbook
                    SW.WriteLine("<Invocation>");
                    SW.WriteLine(Convert.ToString(Spellbook.smite_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.smite));
                    SW.WriteLine(Convert.ToString(Spellbook.moonblast_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.moonblast));
                    SW.WriteLine(Convert.ToString(Spellbook.lightningbolt_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.lightningbolt));
                    SW.WriteLine(Convert.ToString(Spellbook.frostbolt_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.frostbolt));
                    SW.WriteLine(Convert.ToString(Spellbook.magicmissile_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.magicmissile));
                    SW.WriteLine(Convert.ToString(Spellbook.flamestrike_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.flamestrike));
                    SW.WriteLine(Convert.ToString(Spellbook.entangle_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.entangle));
                    SW.WriteLine(Convert.ToString(Spellbook.purge_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.purge));
                    SW.WriteLine(Convert.ToString(Spellbook.venom_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.venom));
                    SW.WriteLine(Convert.ToString(Spellbook.freeze_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.freeze));
                    SW.WriteLine(Convert.ToString(Spellbook.scorch_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.scorch));
                    SW.WriteLine(Convert.ToString(Spellbook.bane_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.bane));
                    SW.WriteLine(Convert.ToString(Spellbook.chainlightning_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.chainlightning));
                    SW.WriteLine(Convert.ToString(Spellbook.firestorm_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.firestorm));
                    SW.WriteLine("<Divination>");
                    SW.WriteLine(Convert.ToString(Spellbook.identify_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.identify));
                    SW.WriteLine(Convert.ToString(Spellbook.detectevil_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.detectevil));
                    SW.WriteLine(Convert.ToString(Spellbook.detectinvisibility_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.detectinvisibility));
                    SW.WriteLine(Convert.ToString(Spellbook.detectchaos_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.detectchaos));
                    SW.WriteLine(Convert.ToString(Spellbook.detectalignment_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.detectalignment));
                    SW.WriteLine(Convert.ToString(Spellbook.detectthoughts_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.detectthoughts));
                    SW.WriteLine(Convert.ToString(Spellbook.farsight_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.farsight));
                    SW.WriteLine("<Evocation>");
                    SW.WriteLine(Convert.ToString(Spellbook.leech_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.leech));
                    SW.WriteLine(Convert.ToString(Spellbook.spellworm_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.spellworm));
                    SW.WriteLine(Convert.ToString(Spellbook.insanity_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.insanity));
                    SW.WriteLine(Convert.ToString(Spellbook.fingerofdeath_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.fingerofdeath));
                    SW.WriteLine("<Alteration>");
                    SW.WriteLine(Convert.ToString(Spellbook.aegis_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.aegis));
                    SW.WriteLine(Convert.ToString(Spellbook.flameshield_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.flameshield));
                    SW.WriteLine(Convert.ToString(Spellbook.telekinesis_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.telekinesis));
                    SW.WriteLine(Convert.ToString(Spellbook.levitate_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.levitate));
                    SW.WriteLine(Convert.ToString(Spellbook.resistfear_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.resistfear));
                    SW.WriteLine(Convert.ToString(Spellbook.haste_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.haste));
                    SW.WriteLine(Convert.ToString(Spellbook.ironbark_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.ironbark));
                    SW.WriteLine(Convert.ToString(Spellbook.truestrike_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.truestrike));
                    SW.WriteLine(Convert.ToString(Spellbook.bladebarrier_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.bladebarrier));
                    SW.WriteLine(Convert.ToString(Spellbook.deathward_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.deathward));
                    SW.WriteLine("<Restoration>");
                    SW.WriteLine(Convert.ToString(Spellbook.heal_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.heal));
                    SW.WriteLine(Convert.ToString(Spellbook.rejuvenation_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.rejuvenation));
                    SW.WriteLine(Convert.ToString(Spellbook.greaterheal_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.greaterheal));
                    SW.WriteLine(Convert.ToString(Spellbook.healingsurge_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.healingsurge));
                    SW.WriteLine(Convert.ToString(Spellbook.removepoison_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.removepoison));
                    SW.WriteLine(Convert.ToString(Spellbook.removedisease_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.removedisease));
                    SW.WriteLine(Convert.ToString(Spellbook.massheal_enabled));
                    SW.WriteLine(Convert.ToString(Spellbook.massheal));
                }
                SW.Close();
                StreamWriter SL = new StreamWriter(S + Path.DirectorySeparatorChar + "location.ame");
                SL.WriteLine("Town of Bitterleaf");
                SL.WriteLine(Convert.ToString(Storyline.progress_main));
                SL.Close();
                if (Globals.race_active == 1)
                {
                    Storyline.convo_race = "human";
                    Storyline.convo_race_sp = "Human";
                }
                if (Globals.race_active == 2)
                {
                    Storyline.convo_race = "moon elf";
                    Storyline.convo_race_sp = "Moon elf";
                }
                if (Globals.race_active == 3)
                {
                    Storyline.convo_race = "sand elf";
                    Storyline.convo_race_sp = "Sand elf";
                }
                if (Globals.race_active == 4)
                {
                    Storyline.convo_race = "dwarf";
                    Storyline.convo_race_sp = "Dwarf";
                }
                if (Globals.class_active == 1) Storyline.convo_class = "fighter";
                if (Globals.class_active == 2) Storyline.convo_class = "paladin";
                if (Globals.class_active == 3) Storyline.convo_class = "inquisitor";
                if (Globals.class_active == 4) Storyline.convo_class = "thief";
                if (Globals.class_active == 5) Storyline.convo_class = "ranger";
                if (Globals.class_active == 6) Storyline.convo_class = "druid";
                if (Globals.class_active == 7) Storyline.convo_class = "cleric";
                if (Globals.class_active == 8) Storyline.convo_class = "mage";
                this.Close();
            }
        }

        private void f05_strength_Value_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_strength.Image = Amethar.Properties.Resources.AttributeStrengthHover;
            f05_text_melee.ForeColor = Color.Gold;
        }

        private void f05_strength_Value_Leave(object sender, EventArgs e)
        {
            f05_strength.Image = Amethar.Properties.Resources.AttributeStrengthStatic;
            f05_text_melee.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }
        private void f05_dexterity_Value_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_dexterity.Image = Amethar.Properties.Resources.AttributeDexterityHover;
            f05_text_armor.ForeColor = Color.Gold;
            if (Globals.class_active == 1 || Globals.class_active == 4 || Globals.class_active == 5) f05_text_ranged.ForeColor = Color.Gold;
        }

        private void f05_dexterity_Value_Leave(object sender, EventArgs e)
        {
            f05_dexterity.Image = Amethar.Properties.Resources.AttributeDexterityStatic;
            f05_text_armor.ForeColor = Color.FromArgb(255, 255, 192, 128);
            if (Globals.class_active == 1 || Globals.class_active == 4 || Globals.class_active == 5) f05_text_ranged.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }
        private void f05_intelligence_Value_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_intelligence.Image = Amethar.Properties.Resources.AttributeIntelligenceHover;
            f05_text_resistance.ForeColor = Color.Gold;
            if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8) f05_text_ranged.ForeColor = Color.Gold;
        }

        private void f05_intelligence_Value_Leave(object sender, EventArgs e)
        {
            f05_intelligence.Image = Amethar.Properties.Resources.AttributeIntelligenceStatic;
            f05_text_resistance.ForeColor = Color.FromArgb(255, 255, 192, 128);
            if (Globals.class_active == 2 || Globals.class_active == 3 || Globals.class_active == 6 || Globals.class_active == 7 || Globals.class_active == 8) f05_text_ranged.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }
        private void f05_constitution_Value_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_constitution.Image = Amethar.Properties.Resources.AttributeConstitutionHover;
            f05_text_health.ForeColor = Color.Gold;
        }

        private void f05_constitution_Value_Leave(object sender, EventArgs e)
        {
            f05_constitution.Image = Amethar.Properties.Resources.AttributeConstitutionStatic;
            f05_text_health.ForeColor = Color.Crimson;
        }
        private void f05_wisdom_Value_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_wisdom.Image = Amethar.Properties.Resources.AttributeWisdomHover;
            f05_text_mana.ForeColor = Color.Gold;
        }

        private void f05_wisdom_Value_Leave(object sender, EventArgs e)
        {
            f05_wisdom.Image = Amethar.Properties.Resources.AttributeWisdomStatic;
            f05_text_mana.ForeColor = Color.DodgerBlue;
        }
        private void f05_charisma_Value_Move(object sender, MouseEventArgs e)
        {
            Buttons.soundfx = false;
            f05_charisma.Image = Amethar.Properties.Resources.AttributeCharismaHover;
            f05_text_reputation.ForeColor = Color.Gold;
        }

        private void f05_charisma_Value_Leave(object sender, EventArgs e)
        {
            f05_charisma.Image = Amethar.Properties.Resources.AttributeCharismaStatic;
            f05_text_reputation.ForeColor = Color.FromArgb(255, 255, 192, 128);
        }
    }
}
