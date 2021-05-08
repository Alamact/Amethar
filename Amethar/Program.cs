using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Drawing;

namespace Amethar
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Forms.f00 = new MainMenu());
        }
    }
    public static class Globals
    {
        //Temporary Variables
        public static Int32 gender_selection = 0;
        public static Int32 race_selection = 0;
        public static Int32 portrait = 0;
        public static Int32 class_selection = 0;
        public static Int32 alignment_selection = 0;
        public static Int32 origin_selection = 0;
        public static Int32 attribute_points = 20;
        //Main Variables
        public static Int32 gender_active = 0;
        public static String player_name = "";
        public static String player_surname = "";
        public static Int32 race_active = 0;
        public static PictureBox portrait_active = new PictureBox();
        public static Int32 class_active = 0;
        public static Int32 goodevil_points = 50;
        public static Int32 lawchaos_points = 50;
        public static Int32 level = 1;
        //Origins
        public static Boolean origin_human_commoner = false;
        public static Boolean origin_human_nobility = false;
        public static Boolean origin_moonelf_commoner = false;
        public static Boolean origin_moonelf_nobility = false;
        public static Boolean origin_sandelf_commoner = false;
        public static Boolean origin_sandelf_nobility = false;
        public static Boolean origin_dwarf_commoner = false;
        public static Boolean origin_dwarf_nobility = false;
        //Attributes
        public static Int32 strength = 10;
        public static Int32 dexterity = 10;
        public static Int32 intelligence = 10;
        public static Int32 constitution = 10;
        public static Int32 wisdom = 10;
        public static Int32 charisma = 10;
        //Stats
        public static Int32 health = 50;
        public static Int32 mana = 5;
        public static Int32 melee_bonus = 0;
        public static Int32 ranged_bonus = 0;
        public static Int32 magic_bonus = 0;
        public static Int32 armor = 0;
        //Armor Class
        public static String armor_class = "None";
        //Resistances
        public static Int32 fire_resistance = 0;
        public static Int32 ice_resistance = 0;
        public static Int32 lightning_resistance = 0;
        public static Int32 poison_resistance = 0;
        public static Int32 disease_resistance = 0;
        //Reputation
        public static Int32 reputation = 0;
        public static String background = "";
        public static String background_origin = "";
        public static String background_class = "";
        public static String background_morality = "";
        //Thief
        public static Int32 skill_locksmith = 0;
        public static Int32 skill_pickpocketing = 0;
        public static Int32 skill_sneaking = 0;
        public static Int32 perk_crafting = 0;
        public static Int32 perk_disarm = 0;
        public static Int32 perk_evasion = 0;
    }
    public static class Forms
    {
        //Main
        public static MainMenu f00;
        public static NewCharacter f01;
        public static RaceSelection f02;
        public static ClassSelection f03;
        public static AlignmentSelection f04;
        public static SummaryScreen f05;
        public static LoadGame f06;
        public static IntroCinematic f07;
        public static SceneBitterleafInn01 f08;
        //Return Flags
        public static Int32 f01_back = 0;
        public static Int32 f02_back = 0;
        public static Int32 f03_back = 0;
        public static Int32 f04_back = 0;
        public static Int32 f05_back = 0;
        public static Int32 f06_back = 0;
        //Confirm Flags
        public static Int32 f01_confirm = 0;
        public static Int32 f02_confirm = 0;
        public static Int32 f03_confirm = 0;
        public static Int32 f04_confirm = 0;
        public static Int32 f05_confirm = 0;
        public static Int32 f06_confirm = 0;
    }
    public static class Buttons
    {
        public static Int32 button_new = 0;
        public static Int32 button_load = 0;
        public static Int32 button_exit = 0;
        public static Int32 tab_active = 0;
        public static Boolean show_tooltip = true;
        public static Boolean soundfx = true;
    }
    public static class Music
    {
        public static Boolean mainmenu = true;
        public static Boolean chargen = true;
    }
    public static class Weapons
    {
        //Skills
        public static Boolean skill_sword = false;
        public static Boolean skill_axe = false;
        public static Boolean skill_mace = false;
        public static Boolean skill_claymore = false;
        public static Boolean skill_halberd = false;
        public static Boolean skill_hammer = false;
        public static Boolean skill_spear = false;
        public static Boolean skill_dagger = false;
        public static Boolean skill_quarterstaff = false;
        public static Boolean skill_shortbow = false;
        public static Boolean skill_longbow = false;
        public static Boolean skill_shield = false;
        public static Boolean skill_dualwield = false;
        //Levels
        public static Int32 level_sword = 0;
        public static Int32 level_axe = 0;
        public static Int32 level_mace = 0;
        public static Int32 level_claymore = 0;
        public static Int32 level_halberd = 0;
        public static Int32 level_hammer = 0;
        public static Int32 level_spear = 0;
        public static Int32 level_dagger = 0;
        public static Int32 level_quarterstaff = 0;
        public static Int32 level_shortbow = 0;
        public static Int32 level_longbow = 0;
        public static Int32 level_shield = 0;
        public static Int32 level_dualwield = 0;
        //Tiers
        public static Int32 tier_sword = 0;
        public static Int32 tier_axe = 0;
        public static Int32 tier_mace = 0;
        public static Int32 tier_claymore = 0;
        public static Int32 tier_halberd = 0;
        public static Int32 tier_hammer = 0;
        public static Int32 tier_spear = 0;
        public static Int32 tier_dagger = 0;
        public static Int32 tier_quarterstaff = 0;
        public static Int32 tier_shortbow = 0;
        public static Int32 tier_longbow = 0;
        public static Int32 tier_shield = 0;
        public static Int32 tier_dualwield = 0;
    }
    public static class Spellbook
    {
        //Slots
        public static String slot_01 = "";
        public static String slot_02 = "";
        public static String slot_03 = "";
        public static String slot_04 = "";
        public static String slot_05 = "";
        public static String slot_06 = "";
        //Invocation
        public static Boolean smite_enabled = false;
        public static Int32 smite = 0;
        public static Boolean moonblast_enabled = false;
        public static Int32 moonblast = 0;
        public static Boolean lightningbolt_enabled = false;
        public static Int32 lightningbolt = 0;
        public static Boolean frostbolt_enabled = false;
        public static Int32 frostbolt = 0;
        public static Boolean magicmissile_enabled = false;
        public static Int32 magicmissile = 0;
        public static Boolean flamestrike_enabled = false;
        public static Int32 flamestrike = 0;
        public static Boolean entangle_enabled = false;
        public static Int32 entangle = 0;
        public static Boolean purge_enabled = false;
        public static Int32 purge = 0;
        public static Boolean venom_enabled = false;
        public static Int32 venom = 0;
        public static Boolean freeze_enabled = false;
        public static Int32 freeze = 0;
        public static Boolean scorch_enabled = false;
        public static Int32 scorch = 0;
        public static Boolean bane_enabled = false;
        public static Int32 bane = 0;
        public static Boolean chainlightning_enabled = false;
        public static Int32 chainlightning = 0;
        public static Boolean firestorm_enabled = false;
        public static Int32 firestorm = 0;
        //Divination
        public static Boolean identify_enabled = false;
        public static Int32 identify = 0;
        public static Boolean detectevil_enabled = false;
        public static Int32 detectevil = 0;
        public static Boolean detectinvisibility_enabled = false;
        public static Int32 detectinvisibility = 0;
        public static Boolean detectchaos_enabled = false;
        public static Int32 detectchaos = 0;
        public static Boolean detectalignment_enabled = false;
        public static Int32 detectalignment = 0;
        public static Boolean detectthoughts_enabled = false;
        public static Int32 detectthoughts = 0;
        public static Boolean farsight_enabled = false;
        public static Int32 farsight = 0;
        //Evocation
        public static Boolean leech_enabled = false;
        public static Int32 leech = 0;
        public static Boolean spellworm_enabled = false;
        public static Int32 spellworm = 0;
        public static Boolean insanity_enabled = false;
        public static Int32 insanity = 0;
        public static Boolean fingerofdeath_enabled = false;
        public static Int32 fingerofdeath = 0;
        //Alteration
        public static Boolean aegis_enabled = false;
        public static Int32 aegis = 0;
        public static Boolean flameshield_enabled = false;
        public static Int32 flameshield = 0;
        public static Boolean telekinesis_enabled = false;
        public static Int32 telekinesis = 0;
        public static Boolean levitate_enabled = false;
        public static Int32 levitate = 0;
        public static Boolean resistfear_enabled = false;
        public static Int32 resistfear = 0;
        public static Boolean haste_enabled = false;
        public static Int32 haste = 0;
        public static Boolean ironbark_enabled = false;
        public static Int32 ironbark = 0;
        public static Boolean truestrike_enabled = false;
        public static Int32 truestrike = 0;
        public static Boolean bladebarrier_enabled = false;
        public static Int32 bladebarrier = 0;
        public static Boolean deathward_enabled = false;
        public static Int32 deathward = 0;
        //Restoration
        public static Boolean heal_enabled = false;
        public static Int32 heal = 0;
        public static Boolean rejuvenation_enabled = false;
        public static Int32 rejuvenation = 0;
        public static Boolean greaterheal_enabled = false;
        public static Int32 greaterheal = 0;
        public static Boolean healingsurge_enabled = false;
        public static Int32 healingsurge = 0;
        public static Boolean removepoison_enabled = false;
        public static Int32 removepoison = 0;
        public static Boolean removedisease_enabled = false;
        public static Int32 removedisease = 0;
        public static Boolean massheal_enabled = false;
        public static Int32 massheal = 0;
    }
    public static class Storyline
    {
        public static Int32 progress_main = 0;
        public static String convo_race = "braal";
        public static String convo_race_sp = "Braal";
        public static String convo_class = "reaver";
    }
    public static class Fonts
    {
        public static PrivateFontCollection ff;
        public static Font main;
        public static Font dialogue;
        public static Font title;
    }
}
