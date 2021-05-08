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
    public partial class LoadGame : Form
    {
        bool save01 = false, save02 = false, save03 = false, save04 = false, save05 = false, save06 = false;
        static string path = Application.StartupPath + Path.DirectorySeparatorChar + "characters" + Path.DirectorySeparatorChar;
        string[] saves = new string[Directory.GetDirectories(path).Length];
        string[] names = new string[Directory.GetDirectories(path).Length];
        int i = 0, selected_i = -1;
        public LoadGame()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.LoadGame_FormClosing);
        }
        private void LoadGame_FormClosing(object sender, FormClosedEventArgs e)
        {
            if (Forms.f06_confirm == 0) Forms.f00.Show();
            else Forms.f06_confirm = 0;
        }

        private void f06_save01_Click(object sender, EventArgs e)
        {
            string S1 = "", S2 = "";
            string racetext = "", classtext = "";
            int level = 0, raceval = 0, classval = 0;
            if (save01 == false)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                save02 = false;
                f06_save02.ForeColor = Color.Khaki;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Static;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Regular);
                save03 = false;
                f06_save03.ForeColor = Color.Khaki;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Static;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Regular);
                save04 = false;
                f06_save04.ForeColor = Color.Khaki;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Static;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Regular);
                save05 = false;
                f06_save05.ForeColor = Color.Khaki;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Static;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Regular);
                save06 = false;
                f06_save06.ForeColor = Color.Khaki;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Static;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Regular);
                save01 = true;
                f06_save01.ForeColor = Color.Linen;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Active;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Bold);
                f06_portrait.Image = Image.FromFile(saves[i] + Path.DirectorySeparatorChar + "portrait.jpg");
                StreamReader SR = new StreamReader(saves[i] + Path.DirectorySeparatorChar + "character.ame");
                SR.ReadLine();
                S1 = SR.ReadLine();
                S2 = SR.ReadLine();
                f06_name.Text = S1 + " " + S2;
                SR.ReadLine();
                raceval = Convert.ToInt32(SR.ReadLine());
                classval = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                SR.ReadLine();
                level = Convert.ToInt32(SR.ReadLine());
                if (raceval == 1) racetext = "Human";
                else if (raceval == 2) racetext = "Moon Elf";
                else if (raceval == 3) racetext = "Sand Elf";
                else if (raceval == 4) racetext = "Dwarf";
                if (classval == 1) classtext = "Fighter";
                else if (classval == 2) classtext = "Paladin";
                else if (classval == 3) classtext = "Inquisitor";
                else if (classval == 4) classtext = "Thief";
                else if (classval == 5) classtext = "Ranger";
                else if (classval == 6) classtext = "Druid";
                else if (classval == 7) classtext = "Cleric";
                else if (classval == 8) classtext = "Mage";
                f06_details.Text = "Level " + level + " " + racetext + " " + classtext;
                f06_name.Visible = true;
                f06_details.Visible = true;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGamePressed;
                selected_i = i;
            }
            else if (save01 == true)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                f06_save01.ForeColor = Color.Khaki;
                save01 = false;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Static;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Regular);
                f06_name.Visible = false;
                f06_details.Visible = false;
                f06_portrait.Image = Amethar.Properties.Resources.PMDefault;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGameStatic;
                selected_i = -1;
            }
        }

        private void f06_save02_Click(object sender, EventArgs e)
        {
            string S1 = "", S2 = "";
            string racetext = "", classtext = "";
            int level = 0, raceval = 0, classval = 0;
            if (save02 == false)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                save01 = false;
                f06_save01.ForeColor = Color.Khaki;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Static;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Regular);
                save03 = false;
                f06_save03.ForeColor = Color.Khaki;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Static;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Regular);
                save04 = false;
                f06_save04.ForeColor = Color.Khaki;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Static;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Regular);
                save05 = false;
                f06_save05.ForeColor = Color.Khaki;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Static;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Regular);
                save06 = false;
                f06_save06.ForeColor = Color.Khaki;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Static;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Regular);
                save02 = true;
                f06_save02.ForeColor = Color.Linen;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Active;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Bold);
                f06_portrait.Image = Image.FromFile(saves[i + 1] + Path.DirectorySeparatorChar + "portrait.jpg");
                StreamReader SR = new StreamReader(saves[i + 1] + Path.DirectorySeparatorChar + "character.ame");
                SR.ReadLine();
                S1 = SR.ReadLine();
                S2 = SR.ReadLine();
                f06_name.Text = S1 + " " + S2;
                SR.ReadLine();
                raceval = Convert.ToInt32(SR.ReadLine());
                classval = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                SR.ReadLine();
                level = Convert.ToInt32(SR.ReadLine());
                if (raceval == 1) racetext = "Human";
                else if (raceval == 2) racetext = "Moon Elf";
                else if (raceval == 3) racetext = "Sand Elf";
                else if (raceval == 4) racetext = "Dwarf";
                if (classval == 1) classtext = "Fighter";
                else if (classval == 2) classtext = "Paladin";
                else if (classval == 3) classtext = "Inquisitor";
                else if (classval == 4) classtext = "Thief";
                else if (classval == 5) classtext = "Ranger";
                else if (classval == 6) classtext = "Druid";
                else if (classval == 7) classtext = "Cleric";
                else if (classval == 8) classtext = "Mage";
                f06_details.Text = "Level " + level + " " + racetext + " " + classtext;
                f06_name.Visible = true;
                f06_details.Visible = true;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGamePressed;
                selected_i = i + 1;
            }
            else if (save02 == true)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                f06_save02.ForeColor = Color.Khaki;
                save02 = false;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Static;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Regular);
                f06_name.Visible = false;
                f06_details.Visible = false;
                f06_portrait.Image = Amethar.Properties.Resources.PMDefault;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGameStatic;
                selected_i = -1;
            }
        }

        private void f06_save03_Click(object sender, EventArgs e)
        {
            string S1 = "", S2 = "";
            string racetext = "", classtext = "";
            int level = 0, raceval = 0, classval = 0;
            if (save03 == false)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                save01 = false;
                f06_save01.ForeColor = Color.Khaki;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Static;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Regular);
                save02 = false;
                f06_save02.ForeColor = Color.Khaki;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Static;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Regular);
                save04 = false;
                f06_save04.ForeColor = Color.Khaki;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Static;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Regular);
                save05 = false;
                f06_save05.ForeColor = Color.Khaki;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Static;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Regular);
                save06 = false;
                f06_save06.ForeColor = Color.Khaki;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Static;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Regular);
                save03 = true;
                f06_save03.ForeColor = Color.Linen;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Active;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Bold);
                f06_portrait.Image = Image.FromFile(saves[i + 2] + Path.DirectorySeparatorChar + "portrait.jpg");
                StreamReader SR = new StreamReader(saves[i + 2] + Path.DirectorySeparatorChar + "character.ame");
                SR.ReadLine();
                S1 = SR.ReadLine();
                S2 = SR.ReadLine();
                f06_name.Text = S1 + " " + S2;
                SR.ReadLine();
                raceval = Convert.ToInt32(SR.ReadLine());
                classval = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                SR.ReadLine();
                level = Convert.ToInt32(SR.ReadLine());
                if (raceval == 1) racetext = "Human";
                else if (raceval == 2) racetext = "Moon Elf";
                else if (raceval == 3) racetext = "Sand Elf";
                else if (raceval == 4) racetext = "Dwarf";
                if (classval == 1) classtext = "Fighter";
                else if (classval == 2) classtext = "Paladin";
                else if (classval == 3) classtext = "Inquisitor";
                else if (classval == 4) classtext = "Thief";
                else if (classval == 5) classtext = "Ranger";
                else if (classval == 6) classtext = "Druid";
                else if (classval == 7) classtext = "Cleric";
                else if (classval == 8) classtext = "Mage";
                f06_details.Text = "Level " + level + " " + racetext + " " + classtext;
                f06_name.Visible = true;
                f06_details.Visible = true;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGamePressed;
                selected_i = i + 2;
            }
            else if (save03 == true)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                f06_save03.ForeColor = Color.Khaki;
                save03 = false;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Static;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Regular);
                f06_name.Visible = false;
                f06_details.Visible = false;
                f06_portrait.Image = Amethar.Properties.Resources.PMDefault;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGameStatic;
                selected_i = -1;
            }
        }

        private void LoadGame_Load(object sender, EventArgs e)
        {
            Int32 index = 0;
            if (Directory.Exists(path) == false) Directory.CreateDirectory(path);
            foreach (string s in Directory.GetDirectories(path)) index++;
            saves = Directory.GetDirectories(path);
            StreamReader SR;
            //Name Loading
            for (int k = 0; k < saves.Count(); k++)
            {
                SR = new StreamReader(saves[k] + Path.DirectorySeparatorChar + "character.ame");
                SR.ReadLine();
                names[k] = SR.ReadLine();
                names[k] = names[k] + " " + SR.ReadLine();
                SR.ReadLine();
                SR.ReadLine();
                SR.ReadLine();
                SR.ReadLine();
                SR.ReadLine();
                names[k] = names[k] + " - Level " + SR.ReadLine();
                SR.Close();
                SR = new StreamReader(saves[k] + Path.DirectorySeparatorChar + "location.ame");
                names[k] = names[k] + " - " + SR.ReadLine();
                SR.Close();
            }
            if (index == 0)
            {
                f06_save01.Visible = false;
                f06_save02.Visible = false;
                f06_save03.Visible = false;
                f06_save04.Visible = false;
                f06_save05.Visible = false;
                f06_save06.Visible = false;
            }
            else if (index == 1)
            {
                f06_save01.Visible = true;
                f06_save01.Text = names[i];
                f06_save02.Visible = false;
                f06_save03.Visible = false;
                f06_save04.Visible = false;
                f06_save05.Visible = false;
                f06_save06.Visible = false;
            }
            else if (index == 2)
            {
                f06_save01.Visible = true;
                f06_save01.Text = names[i];
                f06_save02.Visible = true;
                f06_save02.Text = names[i + 1];
                f06_save03.Visible = false;
                f06_save04.Visible = false;
                f06_save05.Visible = false;
                f06_save06.Visible = false;
            }
            else if (index == 3)
            {
                f06_save01.Visible = true;
                f06_save01.Text = names[i];
                f06_save02.Visible = true;
                f06_save02.Text = names[i + 1];
                f06_save03.Visible = true;
                f06_save03.Text = names[i + 2];
                f06_save04.Visible = false;
                f06_save05.Visible = false;
                f06_save06.Visible = false;
            }
            else if (index == 4)
            {
                f06_save01.Visible = true;
                f06_save01.Text = names[i];
                f06_save02.Visible = true;
                f06_save02.Text = names[i + 1];
                f06_save03.Visible = true;
                f06_save03.Text = names[i + 2];
                f06_save04.Visible = true;
                f06_save04.Text = names[i + 3];
                f06_save05.Visible = false;
                f06_save06.Visible = false;
            }
            else if (index == 5)
            {
                f06_save01.Visible = true;
                f06_save01.Text = names[i];
                f06_save02.Visible = true;
                f06_save02.Text = names[i + 1];
                f06_save03.Visible = true;
                f06_save03.Text = names[i + 2];
                f06_save04.Visible = true;
                f06_save04.Text = names[i + 3];
                f06_save05.Visible = true;
                f06_save05.Text = names[i + 4];
                f06_save06.Visible = false;
            }
            else
            {
                f06_save01.Visible = true;
                f06_save01.Text = names[i + 0];
                f06_save02.Visible = true;
                f06_save02.Text = names[i + 1];
                f06_save03.Visible = true;
                f06_save03.Text = names[i + 2];
                f06_save04.Visible = true;
                f06_save04.Text = names[i + 3];
                f06_save05.Visible = true;
                f06_save05.Text = names[i + 4];
                f06_save06.Visible = true;
                f06_save06.Text = names[i + 5];
            }
        }

        private void f06_save01_Move(object sender, MouseEventArgs e)
        {
            if (save01 == false) f06_save01.ForeColor = Color.Linen;
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
        }

        private void f06_save01_Leave(object sender, EventArgs e)
        {
            if (save01 == false) f06_save01.ForeColor = Color.Khaki;
            Buttons.soundfx = true;
        }
        private void f06_save02_Move(object sender, MouseEventArgs e)
        {
            if (save02 == false) f06_save02.ForeColor = Color.Linen;
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
        }

        private void f06_save02_Leave(object sender, EventArgs e)
        {
            if (save02 == false) f06_save02.ForeColor = Color.Khaki;
            Buttons.soundfx = true;
        }
        private void f06_save03_Move(object sender, MouseEventArgs e)
        {
            if (save03 == false) f06_save03.ForeColor = Color.Linen;
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
        }

        private void f06_save03_Leave(object sender, EventArgs e)
        {
            if (save03 == false) f06_save03.ForeColor = Color.Khaki;
            Buttons.soundfx = true;
        }
        private void f06_save04_Move(object sender, MouseEventArgs e)
        {
            if (save04 == false) f06_save04.ForeColor = Color.Linen;
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
        }

        private void f06_save04_Leave(object sender, EventArgs e)
        {
            if (save04 == false) f06_save04.ForeColor = Color.Khaki;
            Buttons.soundfx = true;
        }
        private void f06_save05_Move(object sender, MouseEventArgs e)
        {
            if (save05 == false) f06_save05.ForeColor = Color.Linen;
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
        }

        private void f05_save05_Leave(object sender, EventArgs e)
        {
            if (save05 == false) f06_save05.ForeColor = Color.Khaki;
            Buttons.soundfx = true;
        }
        private void f06_save06_Move(object sender, MouseEventArgs e)
        {
            if (save06 == false) f06_save06.ForeColor = Color.Linen;
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
        }

        private void f06_save06_Leave(object sender, EventArgs e)
        {
            if (save06 == false) f06_save06.ForeColor = Color.Khaki;
            Buttons.soundfx = true;
        }

        private void f06_load_Move(object sender, MouseEventArgs e)
        {
            if (save01 == true || save02 == true || save03 == true || save04 == true || save05 == true || save06 == true)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGameHover;
            }
        }

        private void f06_load_Leave(object sender, EventArgs e)
        {
            if (save01 == true || save02 == true || save03 == true || save04 == true || save05 == true || save06 == true) f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGamePressed;
            Buttons.soundfx = true;
        }
        private void f06_button_formback_Move(object sender, MouseEventArgs e)
        {
            f06_button_formback.Image = Amethar.Properties.Resources.ButtonFormBackHover;
            if (Buttons.soundfx == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                Buttons.soundfx = false;
            }
        }

        private void f06_button_formback_Leave(object sender, EventArgs e)
        {
            f06_button_formback.Image = Amethar.Properties.Resources.ButtonFormBack;
            Buttons.soundfx = true;
        }
        private void f06_button_formback_Click(object sender, EventArgs e)
        {
            Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
            Forms.f06_back = 1;
            this.Close();
        }

        private void f06_save04_Click(object sender, EventArgs e)
        {
            string S1 = "", S2 = "";
            string racetext = "", classtext = "";
            int level = 0, raceval = 0, classval = 0;
            if (save04 == false)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                save01 = false;
                f06_save01.ForeColor = Color.Khaki;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Static;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Regular);
                save02 = false;
                f06_save02.ForeColor = Color.Khaki;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Static;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Regular);
                save03 = false;
                f06_save03.ForeColor = Color.Khaki;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Static;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Regular);
                save05 = false;
                f06_save05.ForeColor = Color.Khaki;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Static;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Regular);
                save06 = false;
                f06_save06.ForeColor = Color.Khaki;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Static;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Regular);
                save04 = true;
                f06_save04.ForeColor = Color.Linen;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Active;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Bold);
                f06_portrait.Image = Image.FromFile(saves[i + 3] + Path.DirectorySeparatorChar + "portrait.jpg");
                StreamReader SR = new StreamReader(saves[i + 3] + Path.DirectorySeparatorChar + "character.ame");
                SR.ReadLine();
                S1 = SR.ReadLine();
                S2 = SR.ReadLine();
                f06_name.Text = S1 + " " + S2;
                SR.ReadLine();
                raceval = Convert.ToInt32(SR.ReadLine());
                classval = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                SR.ReadLine();
                level = Convert.ToInt32(SR.ReadLine());
                if (raceval == 1) racetext = "Human";
                else if (raceval == 2) racetext = "Moon Elf";
                else if (raceval == 3) racetext = "Sand Elf";
                else if (raceval == 4) racetext = "Dwarf";
                if (classval == 1) classtext = "Fighter";
                else if (classval == 2) classtext = "Paladin";
                else if (classval == 3) classtext = "Inquisitor";
                else if (classval == 4) classtext = "Thief";
                else if (classval == 5) classtext = "Ranger";
                else if (classval == 6) classtext = "Druid";
                else if (classval == 7) classtext = "Cleric";
                else if (classval == 8) classtext = "Mage";
                f06_details.Text = "Level " + level + " " + racetext + " " + classtext;
                f06_name.Visible = true;
                f06_details.Visible = true;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGamePressed;
                selected_i = i + 3;
            }
            else if (save04 == true)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                f06_save04.ForeColor = Color.Khaki;
                save04 = false;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Static;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Regular);
                f06_name.Visible = false;
                f06_details.Visible = false;
                f06_portrait.Image = Amethar.Properties.Resources.PMDefault;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGameStatic;
                selected_i = -1;
            }
        }

        private void f06_save05_Click(object sender, EventArgs e)
        {
            string S1 = "", S2 = "";
            string racetext = "", classtext = "";
            int level = 0, raceval = 0, classval = 0;
            if (save05 == false)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                save01 = false;
                f06_save01.ForeColor = Color.Khaki;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Static;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Regular);
                save02 = false;
                f06_save02.ForeColor = Color.Khaki;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Static;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Regular);
                save04 = false;
                f06_save04.ForeColor = Color.Khaki;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Static;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Regular);
                save03 = false;
                f06_save03.ForeColor = Color.Khaki;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Static;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Regular);
                save06 = false;
                f06_save06.ForeColor = Color.Khaki;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Static;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Regular);
                save05 = true;
                f06_save05.ForeColor = Color.Linen;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Active;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Bold);
                f06_portrait.Image = Image.FromFile(saves[i + 4] + Path.DirectorySeparatorChar + "portrait.jpg");
                StreamReader SR = new StreamReader(saves[i + 4] + Path.DirectorySeparatorChar + "character.ame");
                SR.ReadLine();
                S1 = SR.ReadLine();
                S2 = SR.ReadLine();
                f06_name.Text = S1 + " " + S2;
                SR.ReadLine();
                raceval = Convert.ToInt32(SR.ReadLine());
                classval = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                SR.ReadLine();
                level = Convert.ToInt32(SR.ReadLine());
                if (raceval == 1) racetext = "Human";
                else if (raceval == 2) racetext = "Moon Elf";
                else if (raceval == 3) racetext = "Sand Elf";
                else if (raceval == 4) racetext = "Dwarf";
                if (classval == 1) classtext = "Fighter";
                else if (classval == 2) classtext = "Paladin";
                else if (classval == 3) classtext = "Inquisitor";
                else if (classval == 4) classtext = "Thief";
                else if (classval == 5) classtext = "Ranger";
                else if (classval == 6) classtext = "Druid";
                else if (classval == 7) classtext = "Cleric";
                else if (classval == 8) classtext = "Mage";
                f06_details.Text = "Level " + level + " " + racetext + " " + classtext;
                f06_name.Visible = true;
                f06_details.Visible = true;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGamePressed;
                selected_i = i + 4;
            }
            else if (save05 == true)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                f06_save05.ForeColor = Color.Khaki;
                save05 = false;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Static;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Regular);
                f06_name.Visible = false;
                f06_details.Visible = false;
                f06_portrait.Image = Amethar.Properties.Resources.PMDefault;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGameStatic;
                selected_i = -1;
            }
        }

        private void f06_save06_Click(object sender, EventArgs e)
        {
            string S1 = "", S2 = "";
            string racetext = "", classtext = "";
            int level = 0, raceval = 0, classval = 0;
            if (save06 == false)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/unclick.wav";
                save01 = false;
                f06_save01.ForeColor = Color.Khaki;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Static;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Regular);
                save02 = false;
                f06_save02.ForeColor = Color.Khaki;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Static;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Regular);
                save03 = false;
                f06_save03.ForeColor = Color.Khaki;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Static;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Regular);
                save04 = false;
                f06_save04.ForeColor = Color.Khaki;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Static;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Regular);
                save05 = false;
                f06_save05.ForeColor = Color.Khaki;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Static;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Regular);
                save06 = true;
                f06_save06.ForeColor = Color.Linen;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Active;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Bold);
                f06_portrait.Image = Image.FromFile(saves[i + 5] + Path.DirectorySeparatorChar + "portrait.jpg");
                StreamReader SR = new StreamReader(saves[i + 5] + Path.DirectorySeparatorChar + "character.ame");
                SR.ReadLine();
                S1 = SR.ReadLine();
                S2 = SR.ReadLine();
                f06_name.Text = S1 + " " + S2;
                SR.ReadLine();
                raceval = Convert.ToInt32(SR.ReadLine());
                classval = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                SR.ReadLine();
                level = Convert.ToInt32(SR.ReadLine());
                if (raceval == 1) racetext = "Human";
                else if (raceval == 2) racetext = "Moon Elf";
                else if (raceval == 3) racetext = "Sand Elf";
                else if (raceval == 4) racetext = "Dwarf";
                if (classval == 1) classtext = "Fighter";
                else if (classval == 2) classtext = "Paladin";
                else if (classval == 3) classtext = "Inquisitor";
                else if (classval == 4) classtext = "Thief";
                else if (classval == 5) classtext = "Ranger";
                else if (classval == 6) classtext = "Druid";
                else if (classval == 7) classtext = "Cleric";
                else if (classval == 8) classtext = "Mage";
                f06_details.Text = "Level " + level + " " + racetext + " " + classtext;
                f06_name.Visible = true;
                f06_details.Visible = true;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGamePressed;
                selected_i = i + 5;
            }
            else if (save06 == true)
            {
                Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/deselect.wav";
                f06_save06.ForeColor = Color.Khaki;
                save06 = false;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Static;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Regular);
                f06_name.Visible = false;
                f06_details.Visible = false;
                f06_portrait.Image = Amethar.Properties.Resources.PMDefault;
                f06_button_load.Image = Amethar.Properties.Resources.ButtonLoadGameStatic;
                selected_i = -1;
            }
        }

        private void f06_button_up_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                i--;
                f06_save01.Text = names[i];
                if (i + 1 < saves.Length) { f06_save02.Text = names[i + 1]; f06_save02.Visible = true; }
                if (i + 2 < saves.Length) { f06_save03.Text = names[i + 2]; f06_save03.Visible = true; }
                if (i + 3 < saves.Length) { f06_save04.Text = names[i + 3]; f06_save04.Visible = true; }
                if (i + 4 < saves.Length) { f06_save05.Text = names[i + 4]; f06_save05.Visible = true; }
                if (i + 5 < saves.Length) { f06_save06.Text = names[i + 5]; f06_save06.Visible = true; }
                save01 = false;
                f06_save01.ForeColor = Color.Khaki;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Static;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Regular);
                save02 = false;
                f06_save02.ForeColor = Color.Khaki;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Static;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Regular);
                save03 = false;
                f06_save03.ForeColor = Color.Khaki;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Static;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Regular);
                save04 = false;
                f06_save04.ForeColor = Color.Khaki;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Static;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Regular);
                save05 = false;
                f06_save05.ForeColor = Color.Khaki;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Static;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Regular);
                save06 = false;
                f06_save06.ForeColor = Color.Khaki;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Static;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Regular);
            }
            if (i == 0) f06_button_up.Image = Amethar.Properties.Resources.ButtonUpStatic;
            if (selected_i == i)
            {
                save01 = true;
                f06_save01.ForeColor = Color.Linen;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Active;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Bold);
            }
            if (selected_i == i + 1)
            {
                save02 = true;
                f06_save02.ForeColor = Color.Linen;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Active;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Bold);
            }
            if (selected_i == i + 2)
            {
                save03 = true;
                f06_save03.ForeColor = Color.Linen;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Active;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Bold);
            }
            if (selected_i == i + 3)
            {
                save04 = true;
                f06_save04.ForeColor = Color.Linen;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Active;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Bold);
            }
            if (selected_i == i + 4)
            {
                save05 = true;
                f06_save05.ForeColor = Color.Linen;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Active;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Bold);
            }
            if (selected_i == i + 5)
            {
                save06 = true;
                f06_save06.ForeColor = Color.Linen;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Active;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Bold);
            }
        }

        private void f06_button_down_Click(object sender, EventArgs e)
        {
            if (i + 1 < saves.Length)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/select.wav";
                i++;
                f06_save01.Text = names[i];
                if (i + 1 < saves.Length) f06_save02.Text = names[i + 1];
                else f06_save02.Visible = false;
                if (i + 2 < saves.Length) f06_save03.Text = names[i + 2];
                else f06_save03.Visible = false;
                if (i + 3 < saves.Length) f06_save04.Text = names[i + 3];
                else f06_save04.Visible = false;
                if (i + 4 < saves.Length) f06_save05.Text = names[i + 4];
                else f06_save05.Visible = false;
                if (i + 5 < saves.Length) f06_save06.Text = names[i + 5];
                else f06_save06.Visible = false;
                save01 = false;
                f06_save01.ForeColor = Color.Khaki;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Static;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Regular);
                save02 = false;
                f06_save02.ForeColor = Color.Khaki;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Static;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Regular);
                save03 = false;
                f06_save03.ForeColor = Color.Khaki;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Static;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Regular);
                save04 = false;
                f06_save04.ForeColor = Color.Khaki;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Static;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Regular);
                save05 = false;
                f06_save05.ForeColor = Color.Khaki;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Static;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Regular);
                save06 = false;
                f06_save06.ForeColor = Color.Khaki;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Static;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Regular);
            }
            if (i + 1 == saves.Length) f06_button_down.Image = Amethar.Properties.Resources.ButtonDownStatic;
            if (selected_i == i)
            {
                save01 = true;
                f06_save01.ForeColor = Color.Linen;
                f06_save01.Image = Amethar.Properties.Resources.HighlightSave01Active;
                f06_save01.Font = new Font(f06_save01.Font, FontStyle.Bold);
            }
            if (selected_i == i + 1)
            {
                save02 = true;
                f06_save02.ForeColor = Color.Linen;
                f06_save02.Image = Amethar.Properties.Resources.HighlightSave02Active;
                f06_save02.Font = new Font(f06_save02.Font, FontStyle.Bold);
            }
            if (selected_i == i + 2)
            {
                save03 = true;
                f06_save03.ForeColor = Color.Linen;
                f06_save03.Image = Amethar.Properties.Resources.HighlightSave03Active;
                f06_save03.Font = new Font(f06_save03.Font, FontStyle.Bold);
            }
            if (selected_i == i + 3)
            {
                save04 = true;
                f06_save04.ForeColor = Color.Linen;
                f06_save04.Image = Amethar.Properties.Resources.HighlightSave04Active;
                f06_save04.Font = new Font(f06_save04.Font, FontStyle.Bold);
            }
            if (selected_i == i + 4)
            {
                save05 = true;
                f06_save05.ForeColor = Color.Linen;
                f06_save05.Image = Amethar.Properties.Resources.HighlightSave05Active;
                f06_save05.Font = new Font(f06_save05.Font, FontStyle.Bold);
            }
            if (selected_i == i + 5)
            {
                save06 = true;
                f06_save06.ForeColor = Color.Linen;
                f06_save06.Image = Amethar.Properties.Resources.HighlightSave06Active;
                f06_save06.Font = new Font(f06_save06.Font, FontStyle.Bold);
            }
        }

        private void f06_button_down_Move(object sender, MouseEventArgs e)
        {
            if (i + 1 < saves.Length)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f06_button_down.Image = Amethar.Properties.Resources.ButtonDownHover1;
            }
        }

        private void f06_button_down_Leave(object sender, EventArgs e)
        {
            if (i + 1 < saves.Length) f06_button_down.Image = Amethar.Properties.Resources.ButtonDownStatic;
            Buttons.soundfx = true;
        }

        private void f06_button_up_Move(object sender, MouseEventArgs e)
        {
            if (i > 0)
            {
                if (Buttons.soundfx == true)
                {
                    Forms.f00.SecondaryEffects.URL = Application.StartupPath + @"/sounds/hover.wav";
                    Buttons.soundfx = false;
                }
                f06_button_up.Image = Amethar.Properties.Resources.ButtonUpHover1;
            }
        }

        private void f06_button_up_Leave(object sender, EventArgs e)
        {
            if (i > 0) f06_button_up.Image = Amethar.Properties.Resources.ButtonUpStatic;
            Buttons.soundfx = true;
        }

        private void f06_button_load_Click(object sender, EventArgs e)
        {
            if (selected_i > -1)
            {
                Forms.f00.SoundEffects.URL = Application.StartupPath + @"/sounds/click.wav";
                StreamReader SR;
                SR = new StreamReader(saves[selected_i] + Path.DirectorySeparatorChar + "character.ame");
                SR.ReadLine();
                Globals.player_name = SR.ReadLine();
                Globals.player_surname = SR.ReadLine();
                Globals.gender_active = Convert.ToInt32(SR.ReadLine());
                Globals.race_active = Convert.ToInt32(SR.ReadLine());
                Globals.class_active = Convert.ToInt32(SR.ReadLine());
                Globals.goodevil_points = Convert.ToInt32(SR.ReadLine());
                Globals.lawchaos_points = Convert.ToInt32(SR.ReadLine());
                Globals.level = Convert.ToInt32(SR.ReadLine());
                Globals.origin_human_commoner = Convert.ToBoolean(SR.ReadLine());
                Globals.origin_human_nobility = Convert.ToBoolean(SR.ReadLine());
                Globals.origin_moonelf_commoner = Convert.ToBoolean(SR.ReadLine());
                Globals.origin_moonelf_nobility = Convert.ToBoolean(SR.ReadLine());
                Globals.origin_sandelf_commoner = Convert.ToBoolean(SR.ReadLine());
                Globals.origin_sandelf_nobility = Convert.ToBoolean(SR.ReadLine());
                Globals.origin_dwarf_commoner = Convert.ToBoolean(SR.ReadLine());
                Globals.origin_dwarf_nobility = Convert.ToBoolean(SR.ReadLine());
                SR.ReadLine();
                Globals.strength = Convert.ToInt32(SR.ReadLine());
                Globals.dexterity = Convert.ToInt32(SR.ReadLine());
                Globals.intelligence = Convert.ToInt32(SR.ReadLine());
                Globals.constitution = Convert.ToInt32(SR.ReadLine());
                Globals.wisdom = Convert.ToInt32(SR.ReadLine());
                Globals.charisma = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                Globals.health = Convert.ToInt32(SR.ReadLine());
                Globals.mana = Convert.ToInt32(SR.ReadLine());
                Globals.melee_bonus = Convert.ToInt32(SR.ReadLine());
                Globals.ranged_bonus = Convert.ToInt32(SR.ReadLine());
                Globals.magic_bonus = Convert.ToInt32(SR.ReadLine());
                Globals.armor_class = SR.ReadLine();
                Globals.armor = Convert.ToInt32(SR.ReadLine());
                Globals.fire_resistance = Convert.ToInt32(SR.ReadLine());
                Globals.ice_resistance = Convert.ToInt32(SR.ReadLine());
                Globals.lightning_resistance = Convert.ToInt32(SR.ReadLine());
                Globals.poison_resistance = Convert.ToInt32(SR.ReadLine());
                Globals.disease_resistance = Convert.ToInt32(SR.ReadLine());
                Globals.reputation = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                Weapons.skill_sword = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_sword = Convert.ToInt32(SR.ReadLine());
                Weapons.level_sword = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_axe = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_axe = Convert.ToInt32(SR.ReadLine());
                Weapons.level_axe = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_mace = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_mace = Convert.ToInt32(SR.ReadLine());
                Weapons.level_mace = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_claymore = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_claymore = Convert.ToInt32(SR.ReadLine());
                Weapons.level_claymore = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_halberd = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_halberd = Convert.ToInt32(SR.ReadLine());
                Weapons.level_halberd = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_hammer = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_hammer = Convert.ToInt32(SR.ReadLine());
                Weapons.level_hammer = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_spear = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_spear = Convert.ToInt32(SR.ReadLine());
                Weapons.level_spear = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_dagger = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_dagger = Convert.ToInt32(SR.ReadLine());
                Weapons.level_dagger = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_quarterstaff = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_quarterstaff = Convert.ToInt32(SR.ReadLine());
                Weapons.level_quarterstaff = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_shortbow = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_shortbow = Convert.ToInt32(SR.ReadLine());
                Weapons.level_shortbow = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_longbow = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_longbow = Convert.ToInt32(SR.ReadLine());
                Weapons.level_longbow = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_shield = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_shield = Convert.ToInt32(SR.ReadLine());
                Weapons.level_shield = Convert.ToInt32(SR.ReadLine());
                Weapons.skill_dualwield = Convert.ToBoolean(SR.ReadLine());
                Weapons.tier_dualwield = Convert.ToInt32(SR.ReadLine());
                Weapons.level_dualwield = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                Spellbook.smite_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.smite = Convert.ToInt32(SR.ReadLine());
                Spellbook.moonblast_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.moonblast = Convert.ToInt32(SR.ReadLine());
                Spellbook.lightningbolt_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.lightningbolt = Convert.ToInt32(SR.ReadLine());
                Spellbook.frostbolt_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.frostbolt = Convert.ToInt32(SR.ReadLine());
                Spellbook.magicmissile_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.magicmissile = Convert.ToInt32(SR.ReadLine());
                Spellbook.flamestrike_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.flamestrike = Convert.ToInt32(SR.ReadLine());
                Spellbook.entangle_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.entangle = Convert.ToInt32(SR.ReadLine());
                Spellbook.purge_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.purge = Convert.ToInt32(SR.ReadLine());
                Spellbook.venom_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.venom = Convert.ToInt32(SR.ReadLine());
                Spellbook.freeze_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.freeze = Convert.ToInt32(SR.ReadLine());
                Spellbook.scorch_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.scorch = Convert.ToInt32(SR.ReadLine());
                Spellbook.bane_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.bane = Convert.ToInt32(SR.ReadLine());
                Spellbook.chainlightning_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.chainlightning = Convert.ToInt32(SR.ReadLine());
                Spellbook.firestorm_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.firestorm = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                Spellbook.identify_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.identify = Convert.ToInt32(SR.ReadLine());
                Spellbook.detectevil_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.detectevil = Convert.ToInt32(SR.ReadLine());
                Spellbook.detectinvisibility_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.detectinvisibility = Convert.ToInt32(SR.ReadLine());
                Spellbook.detectchaos_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.detectchaos = Convert.ToInt32(SR.ReadLine());
                Spellbook.detectalignment_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.detectalignment = Convert.ToInt32(SR.ReadLine());
                Spellbook.detectthoughts_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.detectthoughts = Convert.ToInt32(SR.ReadLine());
                Spellbook.farsight_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.farsight = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                Spellbook.leech_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.leech = Convert.ToInt32(SR.ReadLine());
                Spellbook.spellworm_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.spellworm = Convert.ToInt32(SR.ReadLine());
                Spellbook.insanity_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.insanity = Convert.ToInt32(SR.ReadLine());
                Spellbook.fingerofdeath_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.fingerofdeath = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                Spellbook.aegis_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.aegis = Convert.ToInt32(SR.ReadLine());
                Spellbook.flameshield_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.flameshield = Convert.ToInt32(SR.ReadLine());
                Spellbook.telekinesis_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.telekinesis = Convert.ToInt32(SR.ReadLine());
                Spellbook.levitate_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.levitate = Convert.ToInt32(SR.ReadLine());
                Spellbook.resistfear_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.resistfear = Convert.ToInt32(SR.ReadLine());
                Spellbook.haste_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.haste = Convert.ToInt32(SR.ReadLine());
                Spellbook.ironbark_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.ironbark = Convert.ToInt32(SR.ReadLine());
                Spellbook.truestrike_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.truestrike = Convert.ToInt32(SR.ReadLine());
                Spellbook.bladebarrier_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.bladebarrier = Convert.ToInt32(SR.ReadLine());
                Spellbook.deathward_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.deathward = Convert.ToInt32(SR.ReadLine());
                SR.ReadLine();
                Spellbook.heal_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.heal = Convert.ToInt32(SR.ReadLine());
                Spellbook.rejuvenation_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.rejuvenation = Convert.ToInt32(SR.ReadLine());
                Spellbook.greaterheal_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.greaterheal = Convert.ToInt32(SR.ReadLine());
                Spellbook.healingsurge_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.healingsurge = Convert.ToInt32(SR.ReadLine());
                Spellbook.removepoison_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.removepoison = Convert.ToInt32(SR.ReadLine());
                Spellbook.removedisease_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.removedisease = Convert.ToInt32(SR.ReadLine());
                Spellbook.massheal_enabled = Convert.ToBoolean(SR.ReadLine());
                Spellbook.massheal = Convert.ToInt32(SR.ReadLine());
                SR.Close();
                SR = new StreamReader(saves[selected_i] + Path.DirectorySeparatorChar + "location.ame");
                SR.ReadLine();
                Storyline.progress_main = Convert.ToInt32(SR.ReadLine());
                SR.Close();
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
                if (Storyline.progress_main == 1)
                {
                    Forms.f06_confirm = 1;
                    Forms.f08 = new SceneBitterleafInn01();
                    Forms.f08.Show();
                    this.Close();
                }
            }
        }
    }
}
