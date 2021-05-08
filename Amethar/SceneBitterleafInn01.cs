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
    public partial class SceneBitterleafInn01 : Form
    {
        int scene_progress = 1; int choice = 0;
        public SceneBitterleafInn01()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.SceneBitterleafInn01_FormClosing);
        }
        private void SceneBitterleafInn01_FormClosing(object sender, FormClosedEventArgs e)
        {
            Forms.f00.Show();
            Music.mainmenu = true;
            Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Tainted.mp3";
            Forms.f00.MusicPlayer.settings.setMode("loop", true);
            Forms.f00.MusicPlayer.Ctlcontrols.play();
        }

        private void SceneBitterleafInn01_Load(object sender, EventArgs e)
        {
            Forms.f00.MusicPlayer.URL = Application.StartupPath + @"/music/Bitterleaves.mp3";
            Forms.f00.MusicPlayer.settings.setMode("loop", true);
            f08_playername.Font = Fonts.title;
            f08_npc_name.Font = Fonts.dialogue;
            f08_text_dialogue.Font = Fonts.dialogue;
            f08_choice_a.Font = Fonts.dialogue;
            f08_choice_b.Font = Fonts.dialogue;
            f08_choice_c.Font = Fonts.dialogue;
            f08_choice_d.Font = Fonts.dialogue;
            f08_choice_sp.Font = Fonts.dialogue;
            f08_text_hint.Font = Fonts.dialogue;
            f08_playername.Text = Globals.player_name;
            if (Globals.race_active == 1) f08_choice_sp.Text = "Hold a moment, that's racist!";
            if (Globals.race_active == 2) f08_choice_sp.Text = "Can't be worse than the swill they served in the Moonlands.";
            if (Globals.race_active == 4) f08_choice_sp.Text = "Nothing beats dwarven ale.";
        }

        private void f08_button_continue_Move(object sender, MouseEventArgs e)
        {
            if (f08_button_continue.Visible == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinueHover;
            }
        }

        private void f08_button_continue_Leave(object sender, EventArgs e)
        {
            Buttons.soundfx = true;
            if (f08_button_continue.Visible == true) f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
        }

        private void f08_button_continue_Click(object sender, EventArgs e)
        {
            if (scene_progress == 1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                scene_progress++;
                f08_button_continue.Visible = false;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf02;
                f08_text_dialogue.Visible = true;
                f08_npc_name.Visible = true;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_d.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_sp.Visible = true;
            }
            if (scene_progress == 8)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 14;
                if (Globals.class_active != 3) Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf09;
                else Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf14;
                f08_button_continue.Visible = false;
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Magrina";
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_a.Height = 36;
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                f08_choice_a.Text = "Well, there was this rather odd stranger who wouldn't stop bothering me - a sand elf, might he be who you're searching for?";
                f08_choice_b.Text = "No, stop bothering me already.";
                if (Globals.class_active == 3)
                {
                    f08_choice_c.Visible = true;
                    f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367 + 17);
                    f08_choice_c.Text = "Hail, lady inquisitor! I presume you are on the hunt for Methen?";
                }
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Magrina;
                f08_text_dialogue.Text = "(As you try to resume your evening uninterrupted, a stout dwarven woman walks towards you in heavy footsteps.)" + Environment.NewLine + Environment.NewLine + "You there, " + Storyline.convo_race + "! I am Magrina Stonewater, inquisitor of the Order. I am under the belief that there is a dangerous individual lurking in this tavern. Have you seen him?";
            }
            if (scene_progress == 12)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 13;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_text_dialogue.Visible = true;
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Gylve";
                f08_npc_portrait.Visible = true;
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Gylve;
                f08_text_dialogue.Text = "(Suddenly your conversation is interrupted by a half-tipsy dwarf.)" + Environment.NewLine + Environment.NewLine + "Valak! Have you found us a partner? Or is your luck with people the same as your luck in drinks?";
            }
            else if (scene_progress == 13)
            {
                string s = "";
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 15;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_text_dialogue.Visible = true;
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.Visible = true;
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                if (choice == 1) s = "a famed mercenary known to many taverns of Lakewall";
                if (choice == 2) s = "a paladin who is also interested in dwarven ruins of the isle";
                if (choice == 3) s = "the inquisitor who is on the hunt for Jarak Baleth";
                if (choice == 4) s = "a member of, well... a freelancer rogue actually";
                if (choice == 5) s = "a fellow ranger mad enough to hunt a Belestani";
                if (choice == 6) s = "a druid apprentice of the Moonlands";
                if (choice == 7) s = "a cleric who prefers adventure to sermons";
                if (choice == 8) s = "a talented graduate from the University of Xuren";
                if (choice == 9) s = "whose heart also yearns for adventure";
                if (choice == 10) s = "a noble hailing from Eastmarch";
                if (choice == 11) s = "a survivor of Yreen's siege";
                if (choice == 12) s = "the scion of a once mighty family";
                if (choice == 13) s = "a refugee of the Empire and of the Pale Legion";
                if (choice == 14) s = "who was once important to the Empire, but now a refugee";
                if (choice == 15) s = "a dwarf of many strengths, yet also ashamed of failures";
                if (choice == 16) s = "hailing from the cutthroat life of dwarven nobility";
                if (choice != 0) f08_text_dialogue.Text = "I think not, Gylve! Allow me to introduce you " + Globals.player_name + ", " + s + ".";
                else f08_text_dialogue.Text = "I think not, Gylve! Allow me to introduce you " + Globals.player_name + ".";
            }
            else if (scene_progress == 15)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 16;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf06;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Well met, " + Globals.player_name + "." + Environment.NewLine + Environment.NewLine + "So... you are to be our new partner, then?";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Gylve";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Gylve;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 36;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367 + 17);
                f08_choice_a.Text = "Partner? Partner of what?";
                f08_choice_b.Text = "Surely you must be mistaken, dwarf. I would never willingly walk into a partnership without knowing the details.";
                f08_choice_c.Text = "I am to be nothing until you tell me what's this all about.";
            }
            else if (scene_progress == 17)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 18;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf04;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Right. As you may have guessed it, I did not approach you randomly.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "(Sarcastic) You don't say.";
                f08_choice_b.Text = "Then why did you approach me?";
                f08_choice_c.Text = "And here I thought you bothered people by chance...";
            }
            else if (scene_progress == 21)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 22;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf04;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "I am glad we are of the same mind on this." + Environment.NewLine + Environment.NewLine + "From what I've gathered - I'm not sure whether our employer is a man or a woman. The paladin goes by the name of Methen - not much else is known.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "Curious.";
                f08_choice_b.Text = "How can you *not* be sure? Are you blind?";
                f08_choice_c.Text = "The only interesting part of an employer is his coinpurse.";
            }
            else if (scene_progress == 24)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 25;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf24;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Get out of my way, you autistic pile of worms! I refused you once, I will refuse you again.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Gylve";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Gylve;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 25)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 26;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf26;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Truly you are lesser, foul dwarf. One day your kind will litter my fiery prisons! I, Trevan of Ironreach, do swear upon it!" + Environment.NewLine + Environment.NewLine + "But you, " + Storyline.convo_race + ". Surely your mind is open to the truth. Are you lesser? Are you greater? Reveal your true self to me!" + Environment.NewLine + Environment.NewLine + "(You get the odd feeling there is more to this man than his bizarre act.)"; 
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Trevan";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Trevan;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 36;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367 + 17);
                if (Globals.race_active != 1) f08_choice_a.Text = "(Humorously) I am greater than all, petty human. Not even magic compares to my base potentials - for I am mighty.";
                else f08_choice_a.Text = "(Humorously) I am greater than all, petty mage. Not even magic compares to my base potentials - for I am mighty.";
                if (Globals.class_active == 1 || Globals.class_active == 2 || Globals.class_active == 4 || Globals.class_active == 5) f08_choice_b.Text = "Ask me again and I'll flay you on the spot.";
                else f08_choice_b.Text = "Ask me again and I'll flay you with my mind.";
                if (Globals.class_active == 1 && Globals.class_active == 4 && Globals.class_active == 5) f08_choice_c.Text = "Apparently, I am lesser.";
                else f08_choice_c.Text = "I have magic talents, if that's what you're asking.";
            }
            else if (scene_progress == 27)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 28;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Surely you need my aid, fairest lady, er, sir... This is a delicate matter you're handling and I'm best known for my lips, after all.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Hagral";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Hagral;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 28)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 29;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "No.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 29)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 30;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "But, fairest lady, surely you...";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Hagral";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Hagral;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 30)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 31;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "I said no. Are you deaf? If not, do you want to be?";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 31)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 32;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Your lips, however grand they may be, are not the problem here - the words coming from them are." + Environment.NewLine + Environment.NewLine + "Those who follow the word of Halius have no place on this quest.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 32)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 33;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "I... I understand." + Environment.NewLine + Environment.NewLine + "(The grizzled human leaves the table begrudgingly as Methen eyes you up from a distance.)";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Hagral";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Hagral;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 33)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 34;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Approach.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 34)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 35;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf35;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Here for adventure and gold?";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "That I am.";
                f08_choice_b.Text = "Frankly, I'm mostly here out of curiosity.";
                f08_choice_c.Text = "I'm here for work. What is your offer?";
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 37)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 38;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "I greet you, " + Storyline.convo_class + ".";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Akrilia";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Akrilia;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 38)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 39;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Now - you all know about Jarak Baleth, I presume?";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 39)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 40;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Yes, yes - leader of the Blackblade Mercenaries and a known warlock.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 40)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 41;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "From what I’ve gathered here, it appears the local miners delved too greedily into the depths of the earth. Their wild tales spoke of a chamber made of gold.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 41)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 42;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Normally I wouldn’t believe their foolish nonsense, but it seems there may be some truth in it." + Environment.NewLine + Environment.NewLine + "The Blackblade Mercenaries have taken over the mines and I’d hate for the treasure to fall into their hands – I’d rather it fell into mine, and by mine I meant ours.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 42)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 43;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "And naturally you need us to wipe them out for you.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 43)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 44;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Naturally.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 44)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 45;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "(Suddenly, a stout dwarf woman marches towards your table.)" + Environment.NewLine + Environment.NewLine + "Methen, I have come to claim your bounty. Justice demands your head.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Magrina";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Magrina;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 45)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 46;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "And which Inquisitor has the Order sent for me this time?";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 46)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 47;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Magrina." + Environment.NewLine + Environment.NewLine + "You have caused great ire to the Order, Methen. Many of my friends perished for your selfish goals.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Magrina";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Magrina;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 47)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 48;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "You’ve got the wrong paladin.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 48)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 49;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Do not even think of considering yourself one of us, fiend." + Environment.NewLine + Environment.NewLine + "You betrayed every principle of the Order and crippled it beyond repair.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Magrina";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Magrina;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 49)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 50;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "I am guilty of nothing. The man you seek, the real threat is preying upon all of us in the Witherlands and I aim to put him to the sword and restore my name. You can either join me or join the rest of your agents in death.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
        }

        private void f08_choice_a_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                Buttons.soundfx = false;
            }
            if (scene_progress != 1) f08_choice_a.ForeColor = Color.Khaki;
            if (scene_progress == 11)
            {
                f08_text_hint.ForeColor = Color.SteelBlue;
                f08_text_hint.Text = "Hint: Some responses are moral by nature and bring you closer towards the good alignment. They are highlighted in blue.";
                f08_text_hint.Visible = true;
            }
        }

        private void f08_choice_a_Leave(object sender, EventArgs e)
        {
            if (scene_progress != 1) f08_choice_a.ForeColor = Color.White;
            if (scene_progress == 11) f08_text_hint.Visible = false;
            Buttons.soundfx = true;
        }
        private void f08_choice_b_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                Buttons.soundfx = false;
            }
            if (scene_progress != 1) f08_choice_b.ForeColor = Color.Khaki;
            if (scene_progress == 3)
            {
                f08_text_hint.ForeColor = Color.MediumOrchid;
                f08_text_hint.Text = "Hint: Some responses are lawful by nature and bring you closer towards the lawful aligment. They are highlighted in violet.";
                f08_text_hint.Visible = true;
            }
            if (scene_progress == 11)
            {
                f08_text_hint.ForeColor = Color.IndianRed;
                f08_text_hint.Text = "Hint: Some responses are immoral by nature and bring you closer towards the evil alignment. They are highlighted in red.";
                f08_text_hint.Visible = true;
            }
        }

        private void f08_choice_b_Leave(object sender, EventArgs e)
        {
            if (scene_progress != 1) f08_choice_b.ForeColor = Color.White;
            if (scene_progress == 3) f08_text_hint.Visible = false;
            if (scene_progress == 11) f08_text_hint.Visible = false;
            Buttons.soundfx = true;
        }
        private void f08_choice_c_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                Buttons.soundfx = false;
            }
            if (scene_progress != 1) f08_choice_c.ForeColor = Color.Khaki;
            if (scene_progress == 3)
            {
                f08_text_hint.ForeColor = Color.FromArgb(255, 128, 32);
                f08_text_hint.Text = "Hint: Some responses are lawless by nature and bring you closer towards the chaotic aligment. They are highlighted in orange.";
                f08_text_hint.Visible = true;
            }
        }

        private void f08_choice_c_Leave(object sender, EventArgs e)
        {
            if (scene_progress != 1) f08_choice_c.ForeColor = Color.White;
            if (scene_progress == 3) f08_text_hint.Visible = false;
            Buttons.soundfx = true;
        }
        private void f08_choice_d_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                Buttons.soundfx = false;
            }
            if (scene_progress != 1) f08_choice_d.ForeColor = Color.Khaki;
            if (scene_progress == 6 && Globals.gender_active == 2)
            {
                f08_text_hint.ForeColor = Color.Pink;
                f08_text_hint.Text = "Hint: You can flirt with certain NPCs and commit to a romance later on, but some are not available to certain races or gender.";
                f08_text_hint.Visible = true;
            }
        }

        private void f08_choice_d_Leave(object sender, EventArgs e)
        {
            if (scene_progress != 1) f08_choice_d.ForeColor = Color.White;
            if (scene_progress == 6 && Globals.gender_active == 2)
            {
                f08_text_hint.Visible = false;
                Buttons.soundfx = true;
            }
        }
        private void f08_choice_sp_Move(object sender, MouseEventArgs e)
        {
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/text.wav";
                Buttons.soundfx = false;
            }
            if (scene_progress != 1) f08_choice_sp.ForeColor = Color.Khaki;
            if (scene_progress == 2) 
            {
                f08_text_hint.ForeColor = Color.Khaki;
                f08_text_hint.Text = "Hint: Some responses are restricted to a certain race, class or gender. They are highlighted in yellow.";
                f08_text_hint.Visible = true;
            }
        }

        private void f08_choice_sp_Leave(object sender, EventArgs e)
        {
            if (scene_progress != 1) f08_choice_sp.ForeColor = Color.White;
            if (scene_progress == 2)
            {
                f08_text_hint.Visible = false;
                Buttons.soundfx = true;
            }
        }

        private void f08_choice_a_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (scene_progress == 2)
            {
                scene_progress++;
                f08_text_dialogue.Text = "It’s practically incomparable to the glorious taste of rum I’ve shared back in the Empire." + Environment.NewLine + Environment.NewLine + "Speaking of rum... I don’t suppose you’d like a bottle of fine Nurakian Black? I’ve got some tucked away in my satchel. I’m sure Grunwald won’t mind.";
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf03;
                f08_choice_sp.Visible = false;
                f08_choice_a.Text = "Isn’t it illegal outside Korakk?";
                f08_choice_b.Text = "I’d rather not. In fact, I should report you for smuggling.";
                f08_choice_c.Text = "If the price is right, sure.";
                f08_choice_d.Height = 36;
                if (Globals.origin_dwarf_nobility == true || Globals.origin_sandelf_nobility == true || Globals.origin_moonelf_nobility == true || Globals.origin_human_nobility == true) f08_choice_d.Text = "Do I look like I care, peasant? Stop bothering me with your paltry offers and leave.";
                else f08_choice_d.Text = "Do I look like someone who cares, elf? Stop bothering me with your paltry offers and leave.";
            }
            else if (scene_progress == 3)
            {
                scene_progress = 4;
                f08_text_dialogue.Text = "Well, yes... but seeing as I can’t honestly return to the Empire in the best of terms - one can’t help but appreciate a small taste of home.";
                if (Globals.race_active != 3) Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf04;
                else Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf04_se;
                f08_choice_sp.Visible = false;
                if (Globals.race_active != 3) f08_choice_d.Visible = false;
                else f08_choice_d.Visible = true;
                f08_choice_a.Text = "You're a deserter of the Legion, aren't you?";
                f08_choice_b.Text = "Pff... a deserter and a poor salesman. I can't even pity that.";
                f08_choice_c.Text = "On the bright side, you get to enjoy actual freedom.";
                f08_choice_d.Text = "I know what you mean, kinsman. I can't say my graces with the Empire fare any better.";
            }
            else if (scene_progress == 4 || scene_progress == 6)
            {
                string s = "";
                if (scene_progress == 4)
                {
                    s = "Not my proudest moment, but yes, you're right. I was once part of the Pale Legion.";
                    f08_choice_c.Location = new Point(f08_choice_c.Location.X, f08_choice_c.Location.Y + 17);
                    f08_choice_d.Location = new Point(f08_choice_d.Location.X, f08_choice_d.Location.Y + 17);
                }
                else if (scene_progress == 6) s = "What can I say? My time spent outside the Empire has mellowed me.";
                scene_progress = 7;
                f08_text_dialogue.Text = s + Environment.NewLine + Environment.NewLine + "What is your name?";
                if (Globals.origin_human_nobility == true || Globals.origin_dwarf_nobility == true) Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf07;
                else Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf06;
                f08_choice_sp.Visible = false;
                if (Globals.origin_human_nobility == true || Globals.origin_dwarf_nobility == true) f08_choice_d.Visible = true;
                else f08_choice_d.Visible = false;
                f08_choice_b.Height = 36;
                f08_choice_c.Height = 16;
                f08_choice_a.Text = "You can call me " + Globals.player_name + ".";
                f08_choice_b.Text = "(Lie) I am Meraan, ruler of the braals in the Far North. Cover before my might and despair!";
                f08_choice_c.Text = "I'd rather not say.";
                if (Globals.origin_human_nobility == true)
                {
                    if (Globals.gender_active == 1) f08_choice_d.Text = "I am Lord " + Globals.player_name + " " + Globals.player_surname + " of Eastmarch.";
                    else f08_choice_d.Text = "I am Lady " + Globals.player_name + " " + Globals.player_surname + " of Eastmarch.";
                }
                else if (Globals.origin_dwarf_nobility == true)
                {
                    if (Globals.gender_active == 1) f08_choice_d.Text = "I am " + Globals.player_name + ", son of House " + Globals.player_surname + ".";
                    else f08_choice_d.Text = "I am " + Globals.player_name + ", daughter of House " + Globals.player_surname + ".";
                }
            }
            else if (scene_progress == 5)
            {
                scene_progress = 8;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
                f08_button_continue.Visible = true;
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
                f08_playername.Visible = false;
                f08_text_dialogue.Text = "You know what - I don't need this. I wish you a terrible evening, goodbye.";
            }
            else if (scene_progress == 7)
            {
                scene_progress = 10;
                f08_text_dialogue.Text = "And you can call me Valak, formerly of House Norashi. What brings you all the way out here?";
                f08_choice_a.Height = 16;
                if (Globals.gender_active == 1) f08_choice_c.Text = "Can't a man have some privacy these days?";
                else f08_choice_c.Text = "Can't a lady have some privacy these days?";
                f08_choice_b.Text = "(Lie) I'm visiting some distant relatives in the city.";
                f08_choice_c.Visible = true;
                f08_choice_d.Visible = true;
                if (Globals.class_active == 4 || Globals.class_active == 5 || Globals.class_active == 3)
                {
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf10a;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                    f08_choice_c.Location = new Point(f08_choice_b.Location.X, 367);
                    f08_choice_d.Location = new Point(f08_choice_b.Location.X, 390);
                }
                else if (Globals.class_active == 6)
                {
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf10c;
                    f08_choice_a.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    f08_choice_c.Location = new Point(f08_choice_b.Location.X, 367 + 34);
                    f08_choice_d.Location = new Point(f08_choice_b.Location.X, 390 + 34);
                }
                else
                {
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf10b;
                    f08_choice_a.Height = 36;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    f08_choice_c.Location = new Point(f08_choice_b.Location.X, 367 + 17);
                    f08_choice_d.Location = new Point(f08_choice_b.Location.X, 390 + 17);
                }
                if (Globals.class_active == 1) f08_choice_a.Text = "I'm a mercenary looking for work. Bitterleaf is merely a resting point before I set sail to the Mithril Island.";
                if (Globals.class_active == 2) f08_choice_a.Text = "My master sent me here in search of a relic that once belonged to the ancient dwarves.";
                if (Globals.class_active == 3) f08_choice_a.Text = "I'm hunting a known warlock who took refuge here - Jarak Baleth.";
                if (Globals.class_active == 4) f08_choice_a.Text = "Let's just say that I'm not the safest person to be around with.";
                if (Globals.class_active == 5) f08_choice_a.Text = "I don't suppose you've ever hunted a Belestani before?";
                if (Globals.class_active == 6) f08_choice_a.Text = "The druid who taught me is dying from a strange sickness. I've heard of a rare herb growing beneath the soil here. It is my only chance of discovering its origins.";
                if (Globals.class_active == 7) f08_choice_a.Text = "I'm searching for a way to sever a divine bond. Easier said than done, I guess.";
                if (Globals.class_active == 8) f08_choice_a.Text = "A colleague of mine and myself are merely passing through. We are academics from the University of Xuren, you see.";
                if (Globals.origin_human_commoner == true) f08_choice_d.Text = "Ever since I was young, I've wanted to see more of the world. Bitterleaf may not be the grandest of places, but it's a start.";
                if (Globals.origin_human_nobility == true) f08_choice_d.Text = "I'm the fourth child, Valak. Noble or not, I can't do much in my position without my elder siblings lording it over me. Hence I left - and now I'm here.";
                if (Globals.origin_moonelf_commoner == true) f08_choice_d.Text = "Your precious Empire left me without family and without home. Thankfully, I found to be capable enough to live on my own.";
                if (Globals.origin_moonelf_nobility == true) f08_choice_d.Text = "My parents want me to restore our family to its former glory. Sometimes the burdens of reputation can be a bit stressful.";
                if (Globals.origin_sandelf_commoner == true) f08_choice_d.Text = "To put it bluntly - people I once considered friends have ensured my exile from the Pale Legion over petty jealousy.";
                if (Globals.origin_sandelf_nobility == true) f08_choice_d.Text = "What if I told you I was once royalty? That the might of the Empire was to be my birthright - would you believe me? Would you care?";
                if (Globals.origin_dwarf_commoner == true) f08_choice_d.Text = "Since we're all being honest here, I'm interested in staying as far away from my homeland as possible. Only disgrace awaits me there.";
                if (Globals.origin_dwarf_nobility == true) f08_choice_d.Text = "Us Grayhills were always a traditionalistic lot - my elder brother, he handles the formalities. I'm merely the spare.";
            }
            else if (scene_progress == 9)
            {
                scene_progress = 8;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
                f08_button_continue.Visible = true;
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
                f08_playername.Visible = false;
                f08_text_dialogue.Text = "You know what - I don't need this. I wish you a terrible evening, goodbye.";
            }
            else if (scene_progress == 10)
            {
                scene_progress = 11;
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
                if (Globals.class_active == 1)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11c;
                    choice = 1;
                    f08_text_dialogue.Text = "I see a lot of mercenaries in here of late - figures you'd be one of them. Do you belong to a company or are you a freelancer?";
                    f08_choice_a.Text = "Freelancer. I've helped a lot of people during my stay in the Argent Dale. People there know me as the White Raven, much to dear Mhaira's insistence.";
                    f08_choice_b.Text = "I've always worked alone. Perhaps you've heard of Blackclaw, Breaker of the Ridge? I've wiped out nearly half the mountain clans south of Ironreach.";
                }
                if (Globals.class_active == 2 && Globals.race_active != 3)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11c;
                    choice = 2;
                    f08_text_dialogue.Text = "You're one of those paladins, aren't you? If that's true, then you're the first one I saw in person.";
                    f08_choice_a.Text = "Sadly, I'm not quite a proper paladin. My master works outside the Order - the training is there, even the code of valor - but the Order still rejects me.";
                    f08_choice_b.Text = "A paladin in skill only - my master left the Order and is therefore not bound by their dogmatic views. There is no place for such idealism in the world.";
                }
                if (Globals.class_active == 2 && Globals.race_active == 3)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11c;
                    choice = 2;
                    f08_text_dialogue.Text = "Your master sent you to investigate dwarven ruins? That would mean... A sand elf in service to the Order? You, my friend, are quite the oddity and also the first paladin that I've ever met, to be precise.";
                    f08_choice_a.Text = "To be precise, I'm not a proper paladin. My master works outside the Order - the training is there, even the code of valor - but the Order still rejects me.";
                    f08_choice_b.Text = "I am a paladin in skill only - my master left the Order and is therefore not bound by their dogmatic views. There is no place for such idealism in the world.";
                }
                if (Globals.class_active == 3)
                {
                    f08_choice_a.Height = 36;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11b;
                    choice = 3;
                    f08_text_dialogue.Text = "Jarak Baleth? I... I think you should go upstairs at some point.";
                    f08_choice_a.Text = "So the rumors are true... Jarak the Pale stays in Bitterleaf. That bastard will meet swift justice - by living the rest of his life in prison.";
                    f08_choice_b.Text = "He is here, isn't he? That coward deserves no trial; not even the headsman's axe. My justice will be both swift and painful - he deserves no less.";
                }
                if (Globals.class_active == 4)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11c;
                    choice = 4;
                    f08_text_dialogue.Text = "Hmm... you're not one of those Disciples are you? A friend told me they have quite the reputation in the southern Mithril Island.";
                    f08_choice_a.Text = "You choose your own morals in the Temple of Korvus. When I had no one else, they took me in; gave me a home - not repaying such an act would be blasphemy.";
                    f08_choice_b.Text = "Your friend is correct. In Silvervale, we are feared for plenty of good reasons. Years spent inside their temple were years well spent in the honing of my skills.";
                }
                if (Globals.class_active == 5)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11c;
                    choice = 5;
                    f08_text_dialogue.Text = "A Belestani? Say no more - at least I've got half a sense not to spend my entire life chasing a legend.";
                    f08_choice_a.Text = "It is not a legend. Entire villages in the Addarian Highlands have gone silent, with naught but devastation in their remains - and a trail that never ends.";
                    f08_choice_b.Text = "I will catch the beast; no matter how long it has eluded me. No other ranger, not even Khadmun the Tall, was ever closer than I to hunting it down.";
                }
                if (Globals.class_active == 6)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11c;
                    choice = 6;
                    f08_text_dialogue.Text = "I am sorry to hear about your master. Tell me, how dangerous is this sickness?";
                    f08_choice_a.Text = "Very dangerous. If an antidote is not concocted soon, then I fear we may be facing a new plague rising in the Moonlands and not even death can stem its progress.";
                    f08_choice_b.Text = "Its lethality is not what concerns me, but its effect - it can travel through the bodies of the dead - imagine if we could harness it in a controlled state.";
                }
                if (Globals.class_active == 7)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11c;
                    choice = 7;
                    f08_text_dialogue.Text = "A divine bond? Do I even want to know?";
                    f08_choice_a.Text = "No, you really don't. I will say this however - long ago I made a pact with a powerful spirit. Yet our alliance has always been on shaky grounds.";
                    f08_choice_b.Text = "What you want is irrelevant, what I need is to regain control over my soul and potentially swallow the essence of a god - wouldn't that be something?";
                }
                if (Globals.class_active == 8)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11c;
                    choice = 8;
                    f08_text_dialogue.Text = "A bunch of agitators, you mean. I never did trust those crazed wizards or their agenda. No organization alone should be in control of that many arcane secrets.";
                    f08_choice_a.Text = "Actually, Kaavys and I agree wholeheartedly - knowledge should be shared with the rest of the world - at least with those capable of safely putting it to use.";
                    f08_choice_b.Text = "We have access to those secrets because we are the only ones deserving of it. Would you put a sword in a child's hand, certain he would use it rightly?";
                }
            }
            else if (scene_progress == 11)
            {
                scene_progress = 12;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_button_continue.Visible = true;
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
                if (choice == 1)
                {
                    f08_text_dialogue.Text = "The White Raven? I might have heard something about that - the name is familiar, but the deeds escape me.";
                }
                if (choice == 2)
                {
                    f08_text_dialogue.Text = "Oh, I see. I won't pry, then. For what it's worth - I think that as long as you follow the ideals themselves - you're a paladin in my eyes.";
                }
                if (choice == 3)
                {
                    f08_text_dialogue.Text = "He deserves that, without doubt. In actuality, what comes next is, in fact, tied to Jarak's fate.";
                }
                if (choice == 4)
                {
                    f08_text_dialogue.Text = "A rogue with a heart of gold? People like you are quite popular amongst human bards, I've noticed. I respect your choice, however.";
                }
                if (choice == 5)
                {
                    f08_text_dialogue.Text = "Then what are you doing in Bitterleaf of all places? Wait, I know why. You went to the Hunter's Guild here to resupply, I bet. Must have been.";
                }
                if (choice == 6)
                {
                    f08_text_dialogue.Text = "Can't say news of a plague on the horizon excites me. I sincerely hope you find the cure for your master - this is bigger than I initially believed.";
                }
                if (choice == 7)
                {
                    f08_text_dialogue.Text = "Never trust spirits and elder deities - but I have a feeling you had little choice in the matter. Magic is an evil few can control and I trust neither one of them.";
                }
                if (choice == 8)
                {
                    f08_text_dialogue.Text = "I'm not sure secrets like those should be in anyone's hands, mortal or divine. The wills of magic are too unpredictable to control.";
                }
                if (choice == 9)
                {
                    f08_text_dialogue.Text = "Well you're certainly not going to find it here, unless your standards are rather low - in which case, I can help you.";
                }
                if (choice == 10)
                {
                    f08_text_dialogue.Text = "Ah, the bonds of family. Be it boon or shackle, only time will tell, but a strong bond it is.";
                }
                if (choice == 11)
                {
                    f08_text_dialogue.Text = "War is the cradle of monsters, a tall stranger once said to me. No life is left unscarred, no man left unchanged.";
                }
                if (choice == 12)
                {
                    f08_text_dialogue.Text = "I've always found that when you're left with naught but yourself, your motives are the purest.";
                }
                if (choice == 13)
                {
                    f08_text_dialogue.Text = "Betrayal is not a thing forgiven lightly, but forgetting about it is even harder.";
                }
                if (choice == 14)
                {
                    f08_text_dialogue.Text = "You are the lost heir... I can't believe it. You will have my help on this " + Globals.player_name + " " + Globals.player_surname + ", have no doubt about it.";
                }
                if (choice == 15)
                {
                    f08_text_dialogue.Text = "Then I apologize for intruding. Problems like these - I should know you can't fix them in a single night, or even a single year.";
                }
                if (choice == 16)
                {
                    f08_text_dialogue.Text = "Your brother is a good man. Mayhaps you'll even see him in the near future.";
                }
                f08_text_hint.Visible = false;
            }
            else if (scene_progress == 16)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 17;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "You've not told him about us, Valak? Such a lazy bastard you always have been.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Gylve";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Gylve;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 18)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 19;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf09;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Gylve and I - we seek earn some coin during our stay here in Bitterleaf. Yet the job offered requires more than just the expertise of two." + Environment.NewLine + Environment.NewLine + "This is where you come in.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 36;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "What's the job? I mean, you can't reasonably expect me to walk blindly into potential danger.";
                f08_choice_b.Text = "What if I refused?";
            }
            else if (scene_progress == 19)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 20;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf20;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Well, there's a table upstairs where the most peculiar of paladins was looking for a couple of adventurers with promise of great treasure. Sounds enticing, no?";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 36;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "Yee.";
                f08_choice_b.Text = "I suppose a " + Storyline.convo_race + " like me would be useful. Who is this man?";
                f08_choice_c.Text = "No, this is ridiculous. I'll not besmirch my honor by working with some deranged zealot - I'm sorry, but I refuse.";
            }
            else if (scene_progress == 20)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 21;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Yee.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 36;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 22)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 23;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf23;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "However, now that all is said and done - do you wish to join us upstairs? It could be lucrative for both of us.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 36;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "Sure - seems like it will be an interesting evening, at least.";
                f08_choice_b.Text = "Well, I am short on coin...";
                f08_choice_c.Text = "I'm not doing this for profit - something is amiss here and I want to find out what.";
            }
            else if (scene_progress == 23)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 24;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf24;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "(As you walk towards the stairs leading to the second floor, you are intercepted by a strange man.)" + Environment.NewLine + Environment.NewLine + "Hear me, fellow patrons! Cast off your petty comrades of lesser blood - rise as the paragons of power you were meant to be! We mageborn are the Master Race!";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Trevan";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Trevan;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 26)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 27;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf24;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Good! Your confidence is your strength - but only if you possess magic! Otherwise - your arrogance will be your downfall, lowborn filth!" + Environment.NewLine + Environment.NewLine + "(Ultimately, you all decide to ignore the man and proceed to Methen's table where several adventurers are seated.)";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Trevan";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Trevan;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 35)
            {
                string s = "";
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 36;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf36;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Good. State your name and profession.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 36;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                if (Globals.origin_human_commoner == true) s = "Auren";
                if (Globals.origin_human_nobility == true) s = "Eastmarch";
                if (Globals.origin_moonelf_commoner == true) s = "Yreen";
                if (Globals.origin_moonelf_nobility == true) s = "Zalai";
                if (Globals.origin_sandelf_commoner == true) s = "Arakal";
                if (Globals.origin_sandelf_nobility == true) s = "Bagramor";
                if (Globals.origin_dwarf_commoner == true) s = "Orekin";
                if (Globals.origin_dwarf_nobility == true) s = "Hormith";
                f08_choice_a.Text = "I'm a " + Storyline.convo_class + " hailing from the city of " + s + ". My name is hardly important here.";
                f08_choice_b.Text = Globals.player_name + ", " + Storyline.convo_class + " of " + s + ".";
            }
            else if (scene_progress == 36)
            {
                string s = "";
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 37;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                if (Globals.origin_human_commoner == true) s = "Close to the Paladin Order... I see.";
                if (Globals.origin_human_nobility == true) s = "I once travelled to Eastmarch - a city of imposing walls, I thought.";
                if (Globals.origin_moonelf_commoner == true) s = "From the wreckage of Yreen you rise. Curious.";
                if (Globals.origin_moonelf_nobility == true) s = "Myself, I preferred Myricor over Zalai, but that's beside the point.";
                if (Globals.origin_sandelf_commoner == true) s = "The Pale Legion, correct? Good, I always liked discipline.";
                if (Globals.origin_sandelf_nobility == true) s = "The imperial capital? Color me intrigued.";
                if (Globals.origin_dwarf_commoner == true) s = "The city of alchemy and frankly... of not much else.";
                if (Globals.origin_dwarf_nobility == true) s = "The heart of mithril trade - also of good alchohol, I'm told.";
                f08_text_dialogue.Text = s + Environment.NewLine + Environment.NewLine + "Take a seat near Akrilia here and I'll tell you the details.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
        }

        private void f08_choice_b_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (scene_progress == 2)
            {
                scene_progress++;
                f08_text_dialogue.Text = "Well you'll have to forgive me if I won't follow your advice. Myself, I prefer the glorious rum of my homeland." + Environment.NewLine + Environment.NewLine + "Speaking of rum... I don’t suppose you’d like a bottle of fine Nurakian Black? I’ve got some tucked away in my satchel. I’m sure Grunwald won’t mind.";
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf03;
                f08_choice_sp.Visible = false;
                f08_choice_a.Text = "Isn’t it illegal outside Korakk?";
                f08_choice_b.Text = "I’d rather not. In fact, I should report you for smuggling.";
                f08_choice_c.Text = "If the price is right, sure.";
                f08_choice_d.Height = 36;
                if (Globals.origin_dwarf_nobility == true || Globals.origin_sandelf_nobility == true || Globals.origin_moonelf_nobility == true || Globals.origin_human_nobility == true) f08_choice_d.Text = "Do I look like I care, peasant? Stop bothering me with your paltry offers and leave.";
                else f08_choice_d.Text = "Do I look like someone who cares, elf? Stop bothering me with your paltry offers and leave.";
            }
            else if (scene_progress == 3)
            {
                scene_progress = 5;
                if (Globals.race_active != 3) f08_text_dialogue.Text = "I sincerely hope you are joking, " + Storyline.convo_race + ". Surely you realize that not even the city guard cares for the... suspicious origins of my bottle here.";
                else if (Globals.gender_active == 1) f08_text_dialogue.Text = "I sincerely hope you are joking, kinsman. Surely you realize that not even the city guard cares for the... suspicious origins of my bottle here.";
                else f08_text_dialogue.Text = "I sincerely hope you are joking, sister of the Empire. Surely you realize that not even the city guard cares for the... suspicious origins of my bottle here.";
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf05;
                f08_text_hint.Visible = false;
                f08_choice_sp.Visible = false;
                f08_choice_d.Visible = false;
                f08_choice_c.Height = 36;
                f08_choice_a.Text = "Yes, well - I've no interest in talking to outlaws. Goodbye.";
                f08_choice_b.Text = "Relax, it was a simple jest.";
                f08_choice_c.Text = "Have you approached me for something worthwhile? Or are you just professionally wasting my time?";
            }
            else if (scene_progress == 4 || scene_progress == 5 || scene_progress == 6)
            {
                string s = "";
                if (scene_progress == 4)
                {
                    s = "Am I really that bad of a salesman? Should have stayed with archery, I suppose.";
                    f08_choice_c.Location = new Point(f08_choice_c.Location.X, f08_choice_c.Location.Y + 17);
                    f08_choice_d.Location = new Point(f08_choice_d.Location.X, f08_choice_d.Location.Y + 17);
                }
                else if (scene_progress == 5)
                {
                    s = "You have an odd humor - and this is coming from me.";
                    f08_choice_c.Location = new Point(f08_choice_c.Location.X, f08_choice_c.Location.Y + 17);
                    f08_choice_d.Location = new Point(f08_choice_d.Location.X, f08_choice_d.Location.Y + 17);
                }
                else if (scene_progress == 6) s = "Seems awfully practical, but I'd prefer you kept a sober mind for the next hour or so.";
                scene_progress = 7;
                f08_text_dialogue.Text = s + Environment.NewLine + Environment.NewLine + "What is your name?";
                if (Globals.origin_human_nobility == true || Globals.origin_dwarf_nobility == true) Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf07;
                else Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf06;
                f08_choice_sp.Visible = false;
                if (Globals.origin_human_nobility == true || Globals.origin_dwarf_nobility == true) f08_choice_d.Visible = true;
                else f08_choice_d.Visible = false;
                f08_choice_b.Height = 36;
                f08_choice_c.Height = 16;
                f08_choice_a.Text = "You can call me " + Globals.player_name + ".";
                f08_choice_b.Text = "(Lie) I am Meraan, ruler of the braals in the Far North. Cover before my might and despair!";
                f08_choice_c.Text = "I'd rather not say.";
                if (Globals.origin_human_nobility == true)
                {
                    if (Globals.gender_active == 1) f08_choice_d.Text = "I am Lord " + Globals.player_name + " " + Globals.player_surname + " of Eastmarch.";
                    else f08_choice_d.Text = "I am Lady " + Globals.player_name + " " + Globals.player_surname + " of Eastmarch.";
                }
                else if (Globals.origin_dwarf_nobility == true)
                {
                    if (Globals.gender_active == 1) f08_choice_d.Text = "I am " + Globals.player_name + ", son of House " + Globals.player_surname + ".";
                    else f08_choice_d.Text = "I am " + Globals.player_name + ", daughter of House " + Globals.player_surname + ".";
                }
            }
            else if (scene_progress == 7)
            {
                scene_progress = 9;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf09;
                f08_choice_a.Height = 36;
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, f08_choice_b.Location.Y + 17);
                f08_text_dialogue.Text = "Hah! I was half-expecting something like this, to be honest... But really, though - what should I call you?";
                f08_choice_a.Text = "You should call me your better, scum. I'm not giving out my name to some vagabond.";
                f08_choice_b.Text = Globals.player_name + ".";
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
            }
            else if (scene_progress == 9)
            {
                scene_progress = 10;
                f08_text_dialogue.Text = "There - that wasn't so hard, now was it? I am Valak, formerly of House Norashi. What brings you all the way out here?";
                f08_choice_a.Height = 16;
                if (Globals.gender_active == 1) f08_choice_c.Text = "Can't a man have some privacy these days?";
                else f08_choice_c.Text = "Can't a lady have some privacy these days?";
                f08_choice_b.Text = "(Lie) I'm visiting some distant relatives in the city.";
                f08_choice_c.Visible = true;
                f08_choice_d.Visible = true;
                if (Globals.class_active == 4 || Globals.class_active == 5)
                {
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf10a;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                    f08_choice_c.Location = new Point(f08_choice_b.Location.X, 367);
                    f08_choice_d.Location = new Point(f08_choice_b.Location.X, 390);
                }
                else if (Globals.class_active == 6)
                {
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf10c;
                    f08_choice_a.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    f08_choice_c.Location = new Point(f08_choice_b.Location.X, 367 + 34);
                    f08_choice_d.Location = new Point(f08_choice_b.Location.X, 390 + 34);
                }
                else
                {
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf10b;
                    f08_choice_a.Height = 36;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    f08_choice_c.Location = new Point(f08_choice_b.Location.X, 367 + 17);
                    f08_choice_d.Location = new Point(f08_choice_b.Location.X, 390 + 17);
                }
                if (Globals.class_active == 1) f08_choice_a.Text = "I'm a mercenary looking for work. Bitterleaf is merely a resting point before I set sail to the Mithril Island.";
                if (Globals.class_active == 2) f08_choice_a.Text = "My master sent me here in search of a relic that once belonged to the ancient dwarves.";
                if (Globals.class_active == 3) f08_choice_a.Text = "I'm hunting a known warlock who took refuge here - Jarak Baleth.";
                if (Globals.class_active == 4) f08_choice_a.Text = "Let's just say that I'm not the safest person to be around with.";
                if (Globals.class_active == 5) f08_choice_a.Text = "I don't suppose you've ever hunted a Belestani before?";
                if (Globals.class_active == 6) f08_choice_a.Text = "The druid who taught me is dying from a strange sickness. I've heard of a rare herb growing beneath the soil here. It is my only chance of discovering its origins.";
                if (Globals.class_active == 7) f08_choice_a.Text = "I'm searching for a way to sever a divine bond. Easier said than done, I guess.";
                if (Globals.class_active == 8) f08_choice_a.Text = "A colleague of mine and myself are merely passing through. We are academics from the University of Xuren, you see.";
                if (Globals.origin_human_commoner == true) f08_choice_d.Text = "Ever since I was young, I've wanted to see more of the world. Bitterleaf may not be the grandest of places, but it's a start.";
                if (Globals.origin_human_nobility == true) f08_choice_d.Text = "I'm the fourth child, Valak. Noble or not, I can't do much in my position without my elder siblings lording it over me. Hence I left - and now I'm here.";
                if (Globals.origin_moonelf_commoner == true) f08_choice_d.Text = "Your precious Empire left me without family and without home. Thankfully, I found to be capable enough to live on my own.";
                if (Globals.origin_moonelf_nobility == true) f08_choice_d.Text = "My parents want me to restore our family to its former glory. Sometimes the burdens of reputation can be a bit stressful.";
                if (Globals.origin_sandelf_commoner == true) f08_choice_d.Text = "To put it bluntly - people I once considered friends have ensured my exile from the Dread Legion over petty jealousy.";
                if (Globals.origin_sandelf_nobility == true) f08_choice_d.Text = "What if I told you I was once royalty? That the might of the Empire was to be my birthright - would you believe me? Would you care?";
                if (Globals.origin_dwarf_commoner == true) f08_choice_d.Text = "Since we're all being honest here, I'm interested in staying as far away from my homeland as possible. Only disgrace awaits me there.";
                if (Globals.origin_dwarf_nobility == true) f08_choice_d.Text = "Us Grayhills were always a traditionalistic lot - my elder brother, he handles the formalities. I'm merely the spare.";
            }
            else if (scene_progress == 10)
            {
                scene_progress = 12;
                f08_text_dialogue.Text = "How distant? Second cousin once removed distant? Or merely distant from the truth? Ah, I won't pry - you can keep to yourself if that's what you'd really like.";
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_button_continue.Visible = true;
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
            }
            else if (scene_progress == 11)
            {
                scene_progress = 12;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_button_continue.Visible = true;
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
                if (choice == 1)
                {
                    f08_text_dialogue.Text = "No, no, I've heard of you - the bane of Drakeridge, the folk would say. Mountain roads have never been safer - and bloodier, if the rumors are true.";
                }
                if (choice == 2)
                {
                    f08_text_dialogue.Text = "Practical, unrestricted - I guess one should respect that. Still, it is interesting to meet one possessing paladin skills at last, even if you're anything but.";
                }
                if (choice == 3)
                {
                    f08_text_dialogue.Text = "Remind me never to get on your bad side - I have a feeling Jarak is going to regret it tonight.";
                }
                if (choice == 4)
                {
                    f08_text_dialogue.Text = "Dedication like that is rare to find, the company you keep even rarer I'd wager.";
                }
                if (choice == 5)
                {
                    f08_text_dialogue.Text = "Well, at least you're determined. Khadmun's final hunting years have left him but a pale shadow of what he once was. Be careful not to end up like him.";
                }
                if (choice == 6)
                {
                    f08_text_dialogue.Text = "That's... a disconcerting thought, to be honest. There are so many things that could easily go wrong with this plan of yours. If it were up to me, I'd leave well enough alone.";
                }
                if (choice == 7)
                {
                    f08_text_dialogue.Text = "Indeed it would - though I'm not sure if that something would be of the good - or bad kind.";
                }
                if (choice == 8)
                {
                    f08_text_dialogue.Text = "I suppose not, but that sort of arrogance is exactly the reason the Archons stripped Xuren from all its political power in the Moonlands, was it not?";
                }
                if (choice == 9)
                {
                    f08_text_dialogue.Text = "Well you're certainly not going to find it here, unless your standards are rather low - though come to think of it, with power you usually start at the bottom.";
                }
                if (choice == 10)
                {
                    f08_text_dialogue.Text = "Nothing quite like the shackles of family on the way to ambition.";
                }
                if (choice == 11)
                {
                    f08_text_dialogue.Text = "War is the cradle of monsters, a tall stranger once said to me. No life is left unscarred, no man left unchanged.";
                }
                if (choice == 12)
                {
                    f08_text_dialogue.Text = "I've always found that when you're left with naught but yourself, your motives are the purest.";
                }
                if (choice == 13)
                {
                    f08_text_dialogue.Text = "Betrayal is not a thing forgiven lightly, but forgetting about it is even harder.";
                }
                if (choice == 14)
                {
                    f08_text_dialogue.Text = "You are the lost heir... I can't believe it. You will have my help on this " + Globals.player_name + " " + Globals.player_surname + ", have no doubt about it.";
                }
                if (choice == 15)
                {
                    f08_text_dialogue.Text = "Looking for opportunities in Bitterleaf is like fishing for sharks in a pond.";
                }
                if (choice == 16)
                {
                    f08_text_dialogue.Text = "Nothing quite like dwarven politics, right?";
                }
                f08_text_hint.Visible = false;
            }
            else if (scene_progress == 16)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 17;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "You've not told him about us, Valak? Such a lazy bastard you always have been.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Gylve";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Gylve;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 18)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 19;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf09;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Gylve and I - we seek earn some coin during our stay here in Bitterleaf. Yet the job offered requires more than just the expertise of two." + Environment.NewLine + Environment.NewLine + "This is where you come in.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 36;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "What's the job? I mean, you can't reasonably expect me to walk blindly into potential danger.";
                f08_choice_b.Text = "What if I refused?";
            }
            else if (scene_progress == 19)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 20;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf20;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Then we'd all go our own separate ways - but I'm hoping you'll want more than that." + Environment.NewLine + Environment.NewLine + "There's a table upstairs where the most peculiar of paladins was looking for a couple of adventurers with promise of great treasure. Sounds enticing, no?";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 36;
                f08_choice_a.Location = new Point(f08_choice_a.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "Yee.";
                f08_choice_b.Text = "I suppose a " + Storyline.convo_race + " like me would be useful. Who is this man?";
                f08_choice_c.Text = "No, this is ridiculous. I'll not besmirch my honor by working with some deranged zealot - I'm sorry, but I refuse.";
            }
            else if (scene_progress == 20)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 22;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf04;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "That's the thing - I'm not sure whether our employer is a man or a woman. The paladin goes by the name of Methen - not much else is known.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "Curious.";
                f08_choice_b.Text = "How can you *not* be sure? Are you blind?";
                f08_choice_c.Text = "The only interesting part of an employer is his coinpurse.";
            }
            else if (scene_progress == 22)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 23;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf23;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Of course I'm not blind! It's just that... you know what, you'll see it for yourself. Will you join us upstairs or not?";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 36;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "Sure - seems like it will be an interesting evening, at least.";
                f08_choice_b.Text = "Well, I am short on coin...";
                f08_choice_c.Text = "I'm not doing this for profit - something is amiss here and I want to find out what.";
            }
            else if (scene_progress == 23)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 24;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf24;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "(As you walk towards the stairs leading to the second floor, you are intercepted by a strange man.)" + Environment.NewLine + Environment.NewLine + "Hear me, fellow patrons! Cast off your petty comrades of lesser blood - rise as the paragons of power you were meant to be! We mageborn are the Master Race!";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Trevan";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Trevan;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 26)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 27;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf24;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Whelp! You dare speak with such audacity to the highest of races!? You will pay for your insolence! At some point..." + Environment.NewLine + Environment.NewLine + "(Ultimately, you all decide to ignore the man and proceed to Methen's table where several adventurers are seated.)";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Trevan";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Trevan;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 35)
            {
                string s = "";
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 36;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf36;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "As long as it gets the job done. State your name and profession.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 36;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                if (Globals.origin_human_commoner == true) s = "Auren";
                if (Globals.origin_human_nobility == true) s = "Eastmarch";
                if (Globals.origin_moonelf_commoner == true) s = "Yreen";
                if (Globals.origin_moonelf_nobility == true) s = "Zalai";
                if (Globals.origin_sandelf_commoner == true) s = "Arakal";
                if (Globals.origin_sandelf_nobility == true) s = "Bagramor";
                if (Globals.origin_dwarf_commoner == true) s = "Orekin";
                if (Globals.origin_dwarf_nobility == true) s = "Hormith";
                f08_choice_a.Text = "I'm a " + Storyline.convo_class + " hailing from the city of " + s + ". My name is hardly important here.";
                f08_choice_b.Text = Globals.player_name + ", " + Storyline.convo_class + " of " + s + ".";
            }
            else if (scene_progress == 36)
            {
                string s = "";
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 37;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                if (Globals.origin_human_commoner == true) s = "Close to the Paladin Order... I see.";
                if (Globals.origin_human_nobility == true) s = "I once travelled to Eastmarch - a city of imposing walls, I thought.";
                if (Globals.origin_moonelf_commoner == true) s = "From the wreckage of Yreen you rise. Curious.";
                if (Globals.origin_moonelf_nobility == true) s = "Myself, I preferred Myricor over Zalai, but that's beside the point.";
                if (Globals.origin_sandelf_commoner == true) s = "The Pale Legion, correct? Good, I always liked discipline.";
                if (Globals.origin_sandelf_nobility == true) s = "The imperial capital? Color me intrigued.";
                if (Globals.origin_dwarf_commoner == true) s = "The city of alchemy and frankly... of not much else.";
                if (Globals.origin_dwarf_nobility == true) s = "The heart of mithril trade - also of good alchohol, I'm told.";
                f08_text_dialogue.Text = s + Environment.NewLine + Environment.NewLine + "Take a seat near Akrilia here and I'll tell you the details.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
        }

        private void f08_choice_c_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (scene_progress == 2)
            {
                scene_progress++;
                f08_text_dialogue.Text = "To each their own, I guess. Myself, I prefer rum, as any proper Sand Elf should." + Environment.NewLine + Environment.NewLine + "Even though you say you're not a drinker, I feel the need to ask - I don’t suppose you’d like a bottle of fine Nurakian Black rum? I’ve got some tucked away in my satchel. I’m sure Grunwald won’t mind.";
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf03;
                f08_choice_sp.Visible = false;
                f08_choice_a.Text = "Isn’t it illegal outside Korakk?";
                f08_choice_b.Text = "I’d rather not. In fact, I should report you for smuggling.";
                f08_choice_c.Text = "If the price is right, sure.";
                f08_choice_d.Height = 36;
                if (Globals.origin_dwarf_nobility == true || Globals.origin_sandelf_nobility == true || Globals.origin_moonelf_nobility == true || Globals.origin_human_nobility == true) f08_choice_d.Text = "Do I look like I care, peasant? Stop bothering me with your paltry offers and leave.";
                else f08_choice_d.Text = "Do I look like someone who cares, elf? Stop bothering me with your paltry offers and leave.";
            }
            else if (scene_progress == 3)
            {
                scene_progress = 6;
                if (Globals.race_active != 3) f08_text_dialogue.Text = "Tell you what, " + Storyline.convo_race + ", this time it's free of charge. I'm sure my company is price enough.";
                else if (Globals.gender_active == 1) f08_text_dialogue.Text = "Tell you what, kinsman, this time it's free of charge. I'm sure my company is price enough.";
                else f08_text_dialogue.Text = "Tell you what, m'lady, this time it's free of charge. I'm sure my company is price enough.";
                if (Globals.gender_active == 1) Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf06;
                else Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf06_f;
                if (Globals.gender_active == 1) f08_choice_d.Visible = false;
                else f08_choice_d.Visible = true;
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, f08_choice_c.Location.Y + 17);
                f08_choice_d.Location = new Point(f08_choice_d.Location.X, f08_choice_d.Location.Y + 17);
                f08_text_hint.Visible = false;
                f08_choice_sp.Visible = false;
                f08_choice_b.Height = 36;
                f08_choice_c.Height = 16;
                f08_choice_a.Text = "(Sarcastic) Wow. I am amazed by your generosity.";
                f08_choice_b.Text = "As long as I get to continue pouring stuff in the thing where stuff goes in, I'm happy.";
                f08_choice_c.Text = "Well, thanks.";
                f08_choice_d.Text = "I could do with worse company.";
            }
            else if (scene_progress == 4 || scene_progress == 5 || scene_progress == 6)
            {
                string s = "";
                if (scene_progress == 4)
                {
                    s = "While I am a patron of freedom, truly - there are far too many things I've left behind. Good things too.";
                    f08_choice_c.Location = new Point(f08_choice_c.Location.X, f08_choice_c.Location.Y + 17);
                    f08_choice_d.Location = new Point(f08_choice_d.Location.X, f08_choice_d.Location.Y + 17);
                }
                else if (scene_progress == 5)
                {
                    s = "Relax, we're getting to that part. I've never been called a professional before, though.";
                    f08_choice_c.Location = new Point(f08_choice_c.Location.X, f08_choice_c.Location.Y + 17);
                    f08_choice_d.Location = new Point(f08_choice_d.Location.X, f08_choice_d.Location.Y + 17);
                }
                else if (scene_progress == 6) s = "Kindness from a sand elf is so rare, isn't it?";
                scene_progress = 7;
                f08_text_dialogue.Text = s + Environment.NewLine + Environment.NewLine + "What is your name?";
                if (Globals.origin_human_nobility == true || Globals.origin_dwarf_nobility == true) Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf07;
                else Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf06;
                f08_choice_sp.Visible = false;
                if (Globals.origin_human_nobility == true || Globals.origin_dwarf_nobility == true) f08_choice_d.Visible = true;
                else f08_choice_d.Visible = false;
                f08_choice_b.Height = 36;
                f08_choice_c.Height = 16;
                f08_choice_a.Text = "You can call me " + Globals.player_name + ".";
                f08_choice_b.Text = "(Lie) I am Meraan, ruler of the braals in the Far North. Cover before my might and despair!";
                f08_choice_c.Text = "I'd rather not say.";
                if (Globals.origin_human_nobility == true)
                {
                    if (Globals.gender_active == 1) f08_choice_d.Text = "I am Lord " + Globals.player_name + " " + Globals.player_surname + " of Eastmarch.";
                    else f08_choice_d.Text = "I am Lady " + Globals.player_name + " " + Globals.player_surname + " of Eastmarch.";
                }
                else if (Globals.origin_dwarf_nobility == true)
                {
                    if (Globals.gender_active == 1) f08_choice_d.Text = "I am " + Globals.player_name + ", son of House " + Globals.player_surname + ".";
                    else f08_choice_d.Text = "I am " + Globals.player_name + ", daughter of House " + Globals.player_surname + ".";
                }
            }
            else if (scene_progress == 7)
            {
                scene_progress = 9;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf09;
                f08_choice_a.Height = 36;
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, f08_choice_b.Location.Y + 17);
                f08_text_dialogue.Text = "Oh, be reasonable. It's not like I'm asking you your deepest secrets... yet. That one usually comes after a couple of shots.";
                f08_choice_a.Text = "I think not. If you keep asking me these questions, then I'm afraid you'll have to leave.";
                f08_choice_b.Text = Globals.player_name + " is my name.";
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
            }
            else if (scene_progress == 10)
            {
                scene_progress = 12;
                f08_text_dialogue.Text = "Alright, alright. You have some profound trust issues " + Globals.player_name + ", I hope you're at least aware of that.";
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_button_continue.Visible = true;
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
            }
            else if (scene_progress == 16)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 17;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "You've not told him about us, Valak? Such a lazy bastard you always have been.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Gylve";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Gylve;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 18)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 19;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf09;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "Gylve and I - we seek earn some coin during our stay here in Bitterleaf. Yet the job offered requires more than just the expertise of two." + Environment.NewLine + Environment.NewLine + "This is where you come in.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 36;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "What's the job? I mean, you can't reasonably expect me to walk blindly into potential danger.";
                f08_choice_b.Text = "What if I refused?";
            }
            else if (scene_progress == 20)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 8;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "That's a shame. Well, I won't bother you again, " + Globals.player_name + "." + Environment.NewLine + Environment.NewLine + "Let us return upstairs, Gylve. Maybe someone new arrived.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 22)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 23;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf23;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "With a stance like that, there's no reason you'd refuse to join us upstairs, right?";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Valak";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Valak;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = true;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 36;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_choice_a.Text = "None whatsoever - seems like it will be an interesting evening, at least.";
                f08_choice_b.Text = "Well, I am short on coin...";
                f08_choice_c.Text = "I'm not doing this for profit - something is amiss here and I want to find out what.";
            }
            else if (scene_progress == 23)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 24;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf24;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "(As you walk towards the stairs leading to the second floor, you are intercepted by a strange man.)" + Environment.NewLine + Environment.NewLine + "Hear me, fellow patrons! Cast off your petty comrades of lesser blood - rise as the paragons of power you were meant to be! We mageborn are the Master Race!";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Trevan";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Trevan;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 26)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 27;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf24;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                if (Globals.class_active == 1 && Globals.class_active == 4 && Globals.class_active == 5) f08_text_dialogue.Text = "Good! You recognize your inferiority! You know your place, inferior one - this pleases the great Trevan. When the time comes, you will be granted a painless death." + Environment.NewLine + Environment.NewLine + "(Ultimately, you all decide to ignore the man and proceed to Methen's table where several adventurers are seated.)";
                else f08_text_dialogue.Text = "Excellent, fellow ally! Only together can be ascend and take up our rightful place as the One True Race. None below shall question our supremacy!" + Environment.NewLine + Environment.NewLine + "(Ultimately, you all decide to ignore the man and proceed to Methen's table where several adventurers are seated.)";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Trevan";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Trevan;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
            else if (scene_progress == 35)
            {
                string s = "";
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 36;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf36;
                f08_button_continue.Visible = false;
                f08_text_dialogue.Visible = true;
                f08_text_dialogue.Text = "What I offer will be discussed when you state your name and profession.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = true;
                f08_choice_a.Visible = true;
                f08_choice_b.Visible = true;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 36;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                if (Globals.origin_human_commoner == true) s = "Auren";
                if (Globals.origin_human_nobility == true) s = "Eastmarch";
                if (Globals.origin_moonelf_commoner == true) s = "Yreen";
                if (Globals.origin_moonelf_nobility == true) s = "Zalai";
                if (Globals.origin_sandelf_commoner == true) s = "Arakal";
                if (Globals.origin_sandelf_nobility == true) s = "Bagramor";
                if (Globals.origin_dwarf_commoner == true) s = "Orekin";
                if (Globals.origin_dwarf_nobility == true) s = "Hormith";
                f08_choice_a.Text = "I'm a " + Storyline.convo_class + " hailing from the city of " + s + ". My name is hardly important here.";
                f08_choice_b.Text = Globals.player_name + ", " + Storyline.convo_class + " of " + s + ".";
            }
            else if (scene_progress == 36)
            {
                string s = "";
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                scene_progress = 37;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf28;
                f08_button_continue.Visible = true;
                f08_text_dialogue.Visible = true;
                if (Globals.origin_human_commoner == true) s = "Close to the Paladin Order... I see.";
                if (Globals.origin_human_nobility == true) s = "I once travelled to Eastmarch - a city of imposing walls, I thought.";
                if (Globals.origin_moonelf_commoner == true) s = "From the wreckage of Yreen you rise. Curious.";
                if (Globals.origin_moonelf_nobility == true) s = "Myself, I preferred Myricor over Zalai, but that's beside the point.";
                if (Globals.origin_sandelf_commoner == true) s = "The Pale Legion, correct? Good, I always liked discipline.";
                if (Globals.origin_sandelf_nobility == true) s = "The imperial capital? Color me intrigued.";
                if (Globals.origin_dwarf_commoner == true) s = "The city of alchemy and frankly... of not much else.";
                if (Globals.origin_dwarf_nobility == true) s = "The heart of mithril trade - also of good alchohol, I'm told.";
                f08_text_dialogue.Text = s + Environment.NewLine + Environment.NewLine + "Take a seat near Akrilia here and I'll tell you the details.";
                f08_npc_name.Visible = true;
                f08_npc_name.Text = "Methen";
                f08_npc_portrait.BackgroundImage = Amethar.Properties.Resources.Methen;
                f08_npc_portrait.Visible = true;
                f08_playername.Visible = false;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_a.Height = 18;
                f08_choice_b.Height = 18;
                f08_choice_c.Height = 18;
                f08_choice_a.Location = new Point(f08_choice_b.Location.X, 321);
                f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                f08_choice_c.Location = new Point(f08_choice_c.Location.X, 367);
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
            }
        }

        private void f08_choice_d_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (scene_progress == 2)
            {
                scene_progress++;
                f08_text_dialogue.Text = "Hold your steel, friend. I bear no ill will towards you. In fact, I come with an offer." + Environment.NewLine + Environment.NewLine + "I don’t suppose you’d like a bottle of some fine Nurakian Black rum? I’ve got some tucked away in my satchel. I’m sure Grunwald won’t mind.";
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf03;
                f08_choice_sp.Visible = false;
                f08_choice_a.Text = "Isn’t it illegal outside Korakk?";
                f08_choice_b.Text = "I’d rather not. In fact, I should report you for smuggling.";
                f08_choice_c.Text = "If the price is right, sure.";
                f08_choice_d.Height = 36;
                if (Globals.origin_dwarf_nobility == true || Globals.origin_sandelf_nobility == true || Globals.origin_moonelf_nobility == true || Globals.origin_human_nobility == true) f08_choice_d.Text = "Do I look like I care, peasant? Stop bothering me with your paltry offers and leave.";
                else f08_choice_d.Text = "Do I look like someone who cares, elf? Stop bothering me with your paltry offers and leave.";
            }
            else if (scene_progress == 3)
            {
                scene_progress = 8;
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf08;
                f08_choice_a.Visible = false;
                f08_choice_b.Visible = false;
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
                f08_button_continue.Visible = true;
                f08_button_continue.Image = Amethar.Properties.Resources.ButtonContinuePressed;
                f08_playername.Visible = false;
                f08_text_dialogue.Text = "Paltry!? No one calls me paltry and gets away with it!" + Environment.NewLine + Environment.NewLine + "You know what - I don't need this. I wish you a terrible evening, goodbye.";
            }
            else if (scene_progress == 4 || scene_progress == 6)
            {
                string s = "";
                if (scene_progress == 4)
                {
                    s = "We're comrades by trade, then. The Black Empire may be the strongest force in the world right now, but it's not a place for all to enjoy.";
                    f08_choice_c.Location = new Point(f08_choice_c.Location.X, f08_choice_c.Location.Y + 17);
                    f08_choice_d.Location = new Point(f08_choice_d.Location.X, f08_choice_d.Location.Y + 17);
                }
                else if (scene_progress == 6) s = "Funny you should mention that... You'll regret it in a couple of moments, trust me.";
                scene_progress = 7;
                f08_text_hint.Visible = false;
                f08_text_dialogue.Text = s + Environment.NewLine + Environment.NewLine + "What is your name?";
                if (Globals.origin_human_nobility == true || Globals.origin_dwarf_nobility == true) Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf07;
                else Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf06;
                f08_choice_sp.Visible = false;
                if (Globals.origin_human_nobility == true || Globals.origin_dwarf_nobility == true) f08_choice_d.Visible = true;
                else f08_choice_d.Visible = false;
                f08_choice_b.Height = 36;
                f08_choice_c.Height = 16;
                f08_choice_a.Text = "You can call me " + Globals.player_name + ".";
                f08_choice_b.Text = "(Lie) I am Meraan, ruler of the braals in the Far North. Cover before my might and despair!";
                f08_choice_c.Text = "I'd rather not say.";
                if (Globals.origin_human_nobility == true)
                {
                    if (Globals.gender_active == 1) f08_choice_d.Text = "I am Lord " + Globals.player_name + " " + Globals.player_surname + " of Eastmarch.";
                    else f08_choice_d.Text = "I am Lady " + Globals.player_name + " " + Globals.player_surname + " of Eastmarch.";
                }
                else if (Globals.origin_dwarf_nobility == true)
                {
                    if (Globals.gender_active == 1) f08_choice_d.Text = "I am " + Globals.player_name + ", son of House " + Globals.player_surname + ".";
                    else f08_choice_d.Text = "I am " + Globals.player_name + ", daughter of House " + Globals.player_surname + ".";
                }
            }
            else if (scene_progress == 7)
            {
                scene_progress = 10;
                if (Globals.origin_human_nobility == true) f08_text_dialogue.Text = "Human nobility? In Bitterleaf? Color me surprised." + Environment.NewLine + Environment.NewLine + "I, on the other hand, am Valak, formerly of House Norashi. What brings such an esteemed noble all the way out here?";
                else if (Globals.origin_dwarf_nobility == true) f08_text_dialogue.Text = "Uh... dwarven politics aren't my strongest point, I'm sorry." + Environment.NewLine + Environment.NewLine + "Still, I owe you an introduction. I am Valak, formerly of House Norashi. What brings dwarven nobility all the way out here, may I ask?";
                f08_choice_a.Height = 16;
                if (Globals.gender_active == 1) f08_choice_c.Text = "Can't a man have some privacy these days?";
                else f08_choice_c.Text = "Can't a lady have some privacy these days?";
                f08_choice_b.Text = "(Lie) I'm visiting some distant relatives in the city.";
                f08_choice_c.Visible = true;
                f08_choice_d.Visible = true;
                if (Globals.class_active == 4 || Globals.class_active == 5 || Globals.class_active == 3)
                {
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf10a;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344);
                    f08_choice_c.Location = new Point(f08_choice_b.Location.X, 367);
                    f08_choice_d.Location = new Point(f08_choice_b.Location.X, 390);
                }
                else if (Globals.class_active == 6)
                {
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf10c;
                    f08_choice_a.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    f08_choice_c.Location = new Point(f08_choice_b.Location.X, 367 + 34);
                    f08_choice_d.Location = new Point(f08_choice_b.Location.X, 390 + 34);
                }
                else
                {
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf10b;
                    f08_choice_a.Height = 36;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    f08_choice_c.Location = new Point(f08_choice_b.Location.X, 367 + 17);
                    f08_choice_d.Location = new Point(f08_choice_b.Location.X, 390 + 17);
                }
                if (Globals.class_active == 1) f08_choice_a.Text = "I'm a mercenary looking for work. Bitterleaf is merely a resting point before I set sail to the Mithril Island.";
                if (Globals.class_active == 2) f08_choice_a.Text = "My master sent me here in search of a relic that once belonged to the ancient dwarves.";
                if (Globals.class_active == 3) f08_choice_a.Text = "I'm hunting a known warlock who took refuge here - Jarak Baleth.";
                if (Globals.class_active == 4) f08_choice_a.Text = "Let's just say that I'm not the safest person to be around with.";
                if (Globals.class_active == 5) f08_choice_a.Text = "I don't suppose you've ever hunted a Belestani before?";
                if (Globals.class_active == 6) f08_choice_a.Text = "The druid who taught me is dying from a strange sickness. I've heard of a rare herb growing beneath the soil here. It is my only chance of discovering its origins.";
                if (Globals.class_active == 7) f08_choice_a.Text = "I'm searching for a way to sever a divine bond. Easier said than done, I guess.";
                if (Globals.class_active == 8) f08_choice_a.Text = "A colleague of mine and myself are merely passing through. We are academics from the University of Xuren, you see.";
                if (Globals.origin_human_commoner == true) f08_choice_d.Text = "Ever since I was young, I've wanted to see more of the world. Bitterleaf may not be the grandest of places, but it's a start.";
                if (Globals.origin_human_nobility == true) f08_choice_d.Text = "I'm the fourth child, Valak. Noble or not, I can't do much in my position without my elder siblings lording it over me. Hence I left - and now I'm here.";
                if (Globals.origin_moonelf_commoner == true) f08_choice_d.Text = "Your precious Empire left me without family and without home. Thankfully, I found to be capable enough to live on my own.";
                if (Globals.origin_moonelf_nobility == true) f08_choice_d.Text = "My parents want me to restore our family to its former glory. Sometimes the burdens of reputation can be a bit stressful.";
                if (Globals.origin_sandelf_commoner == true) f08_choice_d.Text = "To put it bluntly - people I once considered friends have ensured my exile from the Dread Legion over petty jealousy.";
                if (Globals.origin_sandelf_nobility == true) f08_choice_d.Text = "What if I told you I was once royalty? That the might of the Empire was to be my birthright - would you believe me? Would you care?";
                if (Globals.origin_dwarf_commoner == true) f08_choice_d.Text = "Since we're all being honest here, I'm interested in staying as far away from my homeland as possible. Only disgrace awaits me there.";
                if (Globals.origin_dwarf_nobility == true) f08_choice_d.Text = "Us Grayhills were always a traditionalistic lot - my elder brother, he handles the formalities. I'm merely the spare.";
            }
            else if (scene_progress == 10)
            {
                scene_progress = 11;
                f08_choice_c.Visible = false;
                f08_choice_d.Visible = false;
                if (Globals.origin_human_commoner == true)
                {
                    f08_choice_a.Height = 36;
                    f08_choice_b.Height = 36;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11;
                    choice = 9;
                    f08_text_dialogue.Text = "I see. And from what humble place do you hail from that you would seek adventure in Bitterleaf?";
                    f08_choice_a.Text = "Auren. The paladins of the Order inspired me in my youth to rise to the occassion and take up the call of adventure.";
                    f08_choice_b.Text = "I hail from Auren. I saw the local paladins; I envied their power and knew that in time, I would claim it as well.";
                }
                if (Globals.origin_human_nobility == true)
                {
                    f08_choice_a.Height = 36;
                    f08_choice_b.Height = 36;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11;
                    choice = 10;
                    f08_text_dialogue.Text = "Can't say I envy you. Apparently even nobles are chained by the shackles of society. But, you do love your family, don't you?";
                    f08_choice_a.Text = "Of course. We may have our disagreements, but at the end of the day - this is for the best.";
                    f08_choice_b.Text = "What? That's a foolish notion. I have no love for those who dampen my potentials and keep me from ambitions.";
                }
                if (Globals.origin_moonelf_commoner == true)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 36;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11a;
                    choice = 11;
                    f08_text_dialogue.Text = "Oh... I am truly sorry. I doubt any words I say will excuse the actions of the Storm Legion and their vanguard upon the Moonlands. It wasn't Yreen, was it?";
                    f08_choice_a.Text = "It was. I will never forget the day I was forced to leave everything behind as the Imperials wrought ruin upon my home, but the journey made me stronger in the end.";
                    f08_choice_b.Text = "I wanted to butcher every single Imperial that night - and I knew I couldn't. I promised myself that would never happen again.";
                }
                if (Globals.origin_moonelf_nobility == true)
                {
                    f08_choice_a.Height = 36;
                    f08_choice_b.Height = 36;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11;
                    choice = 12;
                    f08_text_dialogue.Text = "And how do you feel about that?";
                    f08_choice_a.Text = "I think they're chasing something that no longer exists; striving for some false sense of happiness that is material in nature.";
                    f08_choice_b.Text = "I will bear the burden proudly and I will claw our way back to the very top. I promised nothing less than an Archon's seat.";
                }
                if (Globals.origin_sandelf_commoner == true)
                {
                    f08_choice_a.Height = 36;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11b;
                    choice = 13;
                    f08_text_dialogue.Text = "The Dread Legion I've found to be an accomplished army - it is lesser for your departure and for your former friends.";
                    f08_choice_a.Text = "There are nights when I miss them; the camaraderie we shared. But in the mornings I remember - and their deeds I do not forget.";
                    f08_choice_b.Text = "One day I will have my vengeance. It is a path paved in blood but a path I know well. Before they die, they will know me as their better, one last time.";
                }
                if (Globals.origin_sandelf_nobility == true)
                {
                    f08_choice_a.Height = 36;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11b;
                    choice = 14;
                    f08_text_dialogue.Text = "You can't be who you claim to be. Surely you must be joking...";
                    f08_choice_a.Text = "I am not. The Black Throne belongs to murderers and traitors, as you well know, but I hope that one day it will be a symbol of honor again.";
                    f08_choice_b.Text = "The usurpers in power are the only joke here. They will know my wrath and regret letting me escape. Harbor no doubts - I will reclaim my birthright.";
                }
                if (Globals.origin_dwarf_commoner == true)
                {
                    f08_choice_a.Height = 36;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 17);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11b;
                    choice = 15;
                    f08_text_dialogue.Text = "Shame is something I understand far too well," + Globals.player_name + ". Facing one's shame takes courage I don't quite possess yet.";
                    f08_choice_a.Text = "You may be right. But I cannot condemn my family any further because of my misdeeds. I had a chance to make our lives better - and I failed.";
                    f08_choice_b.Text = "I don't care about my shame. I had a chance to rise - I failed. The Mithril Island isn't the only land of opportunities and I am no longer bound by family.";
                }
                if (Globals.origin_dwarf_nobility == true)
                {
                    f08_choice_a.Height = 54;
                    f08_choice_b.Height = 54;
                    f08_choice_b.Location = new Point(f08_choice_b.Location.X, 344 + 34);
                    Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf11c;
                    choice = 16;
                    f08_text_dialogue.Text = "I'm wondering if you left of your own accord or by the will of your House.";
                    f08_choice_a.Text = "My father willed it - and trust me, I would not be here by choice. Luckily, my brother always stood beside me and guided me as best he could - I miss him.";
                    f08_choice_b.Text = "I left those traditionalistic sycophants behind a long time ago. My brother may not yet know it, but the seat of our House will be mine in the end.";
                }
            }
        }

        private void f08_choice_sp_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
            if (scene_progress == 2)
            {
                scene_progress++;
                f08_text_hint.Visible = false;
                if (Globals.race_active == 1) f08_text_dialogue.Text = "Me? A racist!? Preposterous. I'll have you know I've met many good humans in the mainland - out here however I find poor company and poorer drinks." + Environment.NewLine + Environment.NewLine + "However, I can fix that for you - I don’t suppose you’d like a bottle of fine Nurakian Black Rum, straight from the Empire? I’ve got some tucked away in my satchel. I’m sure Grunwald won’t mind.";
                if (Globals.race_active == 2) f08_text_dialogue.Text = "Please. The strongest drink the Moon Elves have is milk. And that milk is actually of a good quality." + Environment.NewLine + Environment.NewLine + "However, seeing as this is a tavern - I don’t suppose you’d like a bottle of fine Nurakian Black rum, straight from the Empire? I’ve got some tucked away in my satchel. I’m sure Grunwald won’t mind.";
                if (Globals.race_active == 3) f08_text_dialogue.Text = "Well of course you miss it, you're a Sand Elf." + Environment.NewLine + Environment.NewLine + "With that said - I don’t suppose you’d like a bottle of fine Nurakian Black, straight from the homeland? I’ve got some tucked away in my satchel. I’m sure Grunwald won’t mind.";
                if (Globals.race_active == 4) f08_text_dialogue.Text = "If my dwarven friend, Gylve, were here - the two of you would bicker endlessly." + Environment.NewLine + Environment.NewLine + "It's no Grayle, but I don’t suppose you’d like a bottle of fine Nurakian Black rum, straight from the Empire? I’ve got some tucked away in my satchel. I’m sure Grunwald won’t mind.";
                Forms.f08.BackgroundImage = Amethar.Properties.Resources.SceneBitterleaf03;
                f08_choice_sp.Visible = false;
                f08_choice_a.Text = "Isn’t it illegal outside Korakk?";
                f08_choice_b.Text = "I’d rather not. In fact, I should report you for smuggling.";
                f08_choice_c.Text = "If the price is right, sure.";
                f08_choice_d.Height = 36;
                if (Globals.origin_dwarf_nobility == true || Globals.origin_sandelf_nobility == true || Globals.origin_moonelf_nobility == true || Globals.origin_human_nobility == true) f08_choice_d.Text = "Do I look like I care, peasant? Stop bothering me with your paltry offers and leave.";
                else f08_choice_d.Text = "Do I look like someone who cares, elf? Stop bothering me with your paltry offers and leave.";
            }
        }
    }
}
