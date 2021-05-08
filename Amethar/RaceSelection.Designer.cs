namespace Amethar
{
    partial class RaceSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceSelection));
            this.f02_button_human = new System.Windows.Forms.PictureBox();
            this.f02_button_moonelf = new System.Windows.Forms.PictureBox();
            this.f02_button_sandelf = new System.Windows.Forms.PictureBox();
            this.f02_button_dwarf = new System.Windows.Forms.PictureBox();
            this.f02_button_confirm = new System.Windows.Forms.PictureBox();
            this.playername = new System.Windows.Forms.Label();
            this.tooltip_race = new System.Windows.Forms.PictureBox();
            this.f02_portrait = new System.Windows.Forms.PictureBox();
            this.tooltip_timer = new System.Windows.Forms.Timer(this.components);
            this.hide_timer = new System.Windows.Forms.Timer(this.components);
            this.f02_button_previous = new System.Windows.Forms.PictureBox();
            this.f02_button_next = new System.Windows.Forms.PictureBox();
            this.f02_button_formback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_human)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_moonelf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_sandelf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_dwarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_confirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tooltip_race)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_portrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_formback)).BeginInit();
            this.SuspendLayout();
            // 
            // f02_button_human
            // 
            this.f02_button_human.Image = global::Amethar.Properties.Resources.ButtonHumanStatic;
            this.f02_button_human.Location = new System.Drawing.Point(97, 105);
            this.f02_button_human.Name = "f02_button_human";
            this.f02_button_human.Size = new System.Drawing.Size(151, 39);
            this.f02_button_human.TabIndex = 0;
            this.f02_button_human.TabStop = false;
            this.f02_button_human.Click += new System.EventHandler(this.f02_button_human_Click);
            this.f02_button_human.MouseLeave += new System.EventHandler(this.f02_button_human_leave);
            this.f02_button_human.MouseHover += new System.EventHandler(this.f02_button_human_tooltip);
            this.f02_button_human.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f02_button_human_move);
            // 
            // f02_button_moonelf
            // 
            this.f02_button_moonelf.Image = global::Amethar.Properties.Resources.ButtonMoonElfStatic;
            this.f02_button_moonelf.Location = new System.Drawing.Point(249, 105);
            this.f02_button_moonelf.Name = "f02_button_moonelf";
            this.f02_button_moonelf.Size = new System.Drawing.Size(151, 39);
            this.f02_button_moonelf.TabIndex = 1;
            this.f02_button_moonelf.TabStop = false;
            this.f02_button_moonelf.Click += new System.EventHandler(this.f02_button_moonelf_Click);
            this.f02_button_moonelf.MouseLeave += new System.EventHandler(this.f02_button_moonelf_leave);
            this.f02_button_moonelf.MouseHover += new System.EventHandler(this.f02_button_moonelf_tooltip);
            this.f02_button_moonelf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f02_button_moonelf_move);
            // 
            // f02_button_sandelf
            // 
            this.f02_button_sandelf.Image = global::Amethar.Properties.Resources.ButtonSandElfStatic;
            this.f02_button_sandelf.Location = new System.Drawing.Point(401, 105);
            this.f02_button_sandelf.Name = "f02_button_sandelf";
            this.f02_button_sandelf.Size = new System.Drawing.Size(151, 39);
            this.f02_button_sandelf.TabIndex = 2;
            this.f02_button_sandelf.TabStop = false;
            this.f02_button_sandelf.Click += new System.EventHandler(this.f02_button_sandelf_Click);
            this.f02_button_sandelf.MouseLeave += new System.EventHandler(this.f02_button_sandelf_leave);
            this.f02_button_sandelf.MouseHover += new System.EventHandler(this.f02_button_sandelf_tooltip);
            this.f02_button_sandelf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f02_button_sandelf_move);
            // 
            // f02_button_dwarf
            // 
            this.f02_button_dwarf.Image = global::Amethar.Properties.Resources.ButtonDwarfStatic;
            this.f02_button_dwarf.Location = new System.Drawing.Point(553, 105);
            this.f02_button_dwarf.Name = "f02_button_dwarf";
            this.f02_button_dwarf.Size = new System.Drawing.Size(151, 39);
            this.f02_button_dwarf.TabIndex = 3;
            this.f02_button_dwarf.TabStop = false;
            this.f02_button_dwarf.Click += new System.EventHandler(this.f02_button_dwarf_Click);
            this.f02_button_dwarf.MouseLeave += new System.EventHandler(this.f02_button_dwarf_leave);
            this.f02_button_dwarf.MouseHover += new System.EventHandler(this.f02_button_dwarf_tooltip);
            this.f02_button_dwarf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f02_button_dwarf_move);
            // 
            // f02_button_confirm
            // 
            this.f02_button_confirm.Image = global::Amethar.Properties.Resources.ButtonsConfirmStatic;
            this.f02_button_confirm.Location = new System.Drawing.Point(324, 469);
            this.f02_button_confirm.Name = "f02_button_confirm";
            this.f02_button_confirm.Size = new System.Drawing.Size(151, 39);
            this.f02_button_confirm.TabIndex = 4;
            this.f02_button_confirm.TabStop = false;
            this.f02_button_confirm.Click += new System.EventHandler(this.f02_button_confirm_Click);
            this.f02_button_confirm.MouseLeave += new System.EventHandler(this.f02_button_confirm_Leave);
            this.f02_button_confirm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f02_button_confirm_Move);
            // 
            // playername
            // 
            this.playername.BackColor = System.Drawing.Color.Transparent;
            this.playername.Cursor = System.Windows.Forms.Cursors.Default;
            this.playername.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.playername.Location = new System.Drawing.Point(299, 408);
            this.playername.Name = "playername";
            this.playername.Size = new System.Drawing.Size(201, 25);
            this.playername.TabIndex = 5;
            this.playername.Text = "Character";
            this.playername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tooltip_race
            // 
            this.tooltip_race.BackColor = System.Drawing.Color.Transparent;
            this.tooltip_race.Image = global::Amethar.Properties.Resources.HumanTooltip;
            this.tooltip_race.Location = new System.Drawing.Point(43, 209);
            this.tooltip_race.Name = "tooltip_race";
            this.tooltip_race.Size = new System.Drawing.Size(200, 150);
            this.tooltip_race.TabIndex = 6;
            this.tooltip_race.TabStop = false;
            // 
            // f02_portrait
            // 
            this.f02_portrait.BackColor = System.Drawing.Color.Transparent;
            this.f02_portrait.Image = global::Amethar.Properties.Resources.PMDefault;
            this.f02_portrait.Location = new System.Drawing.Point(336, 189);
            this.f02_portrait.Name = "f02_portrait";
            this.f02_portrait.Size = new System.Drawing.Size(124, 192);
            this.f02_portrait.TabIndex = 7;
            this.f02_portrait.TabStop = false;
            // 
            // tooltip_timer
            // 
            this.tooltip_timer.Interval = 1000;
            this.tooltip_timer.Tick += new System.EventHandler(this.tooltip_timer_Tick);
            // 
            // hide_timer
            // 
            this.hide_timer.Interval = 12000;
            this.hide_timer.Tick += new System.EventHandler(this.hide_timer_Tick);
            // 
            // f02_button_previous
            // 
            this.f02_button_previous.BackColor = System.Drawing.Color.Transparent;
            this.f02_button_previous.Image = global::Amethar.Properties.Resources.ButtonPrevious;
            this.f02_button_previous.Location = new System.Drawing.Point(249, 261);
            this.f02_button_previous.Name = "f02_button_previous";
            this.f02_button_previous.Size = new System.Drawing.Size(41, 41);
            this.f02_button_previous.TabIndex = 8;
            this.f02_button_previous.TabStop = false;
            this.f02_button_previous.Click += new System.EventHandler(this.f02_button_previous_Click);
            this.f02_button_previous.MouseLeave += new System.EventHandler(this.f02_button_previous_Leave);
            this.f02_button_previous.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f02_button_previous_Move);
            // 
            // f02_button_next
            // 
            this.f02_button_next.BackColor = System.Drawing.Color.Transparent;
            this.f02_button_next.Image = global::Amethar.Properties.Resources.ButtonNext;
            this.f02_button_next.Location = new System.Drawing.Point(505, 261);
            this.f02_button_next.Name = "f02_button_next";
            this.f02_button_next.Size = new System.Drawing.Size(41, 41);
            this.f02_button_next.TabIndex = 9;
            this.f02_button_next.TabStop = false;
            this.f02_button_next.Click += new System.EventHandler(this.f02_button_next_Click);
            this.f02_button_next.MouseLeave += new System.EventHandler(this.f02_button_next_Leave);
            this.f02_button_next.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f02_button_next_Move);
            // 
            // f02_button_formback
            // 
            this.f02_button_formback.BackColor = System.Drawing.Color.Transparent;
            this.f02_button_formback.Image = global::Amethar.Properties.Resources.ButtonFormBack;
            this.f02_button_formback.Location = new System.Drawing.Point(182, 469);
            this.f02_button_formback.Name = "f02_button_formback";
            this.f02_button_formback.Size = new System.Drawing.Size(108, 35);
            this.f02_button_formback.TabIndex = 10;
            this.f02_button_formback.TabStop = false;
            this.f02_button_formback.Click += new System.EventHandler(this.f02_button_formback_Click);
            this.f02_button_formback.MouseLeave += new System.EventHandler(this.f02_button_formback_Leave);
            this.f02_button_formback.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f02_button_formback_Move);
            // 
            // RaceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amethar.Properties.Resources.RaceSelectionBackground;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.f02_button_formback);
            this.Controls.Add(this.f02_button_next);
            this.Controls.Add(this.f02_button_previous);
            this.Controls.Add(this.f02_portrait);
            this.Controls.Add(this.tooltip_race);
            this.Controls.Add(this.playername);
            this.Controls.Add(this.f02_button_confirm);
            this.Controls.Add(this.f02_button_dwarf);
            this.Controls.Add(this.f02_button_sandelf);
            this.Controls.Add(this.f02_button_moonelf);
            this.Controls.Add(this.f02_button_human);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RaceSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amethar";
            this.Load += new System.EventHandler(this.RaceSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_human)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_moonelf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_sandelf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_dwarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_confirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tooltip_race)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_portrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f02_button_formback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox f02_button_human;
        private System.Windows.Forms.PictureBox f02_button_moonelf;
        private System.Windows.Forms.PictureBox f02_button_sandelf;
        private System.Windows.Forms.PictureBox f02_button_dwarf;
        private System.Windows.Forms.PictureBox f02_button_confirm;
        private System.Windows.Forms.Label playername;
        private System.Windows.Forms.PictureBox tooltip_race;
        private System.Windows.Forms.PictureBox f02_portrait;
        private System.Windows.Forms.Timer tooltip_timer;
        private System.Windows.Forms.Timer hide_timer;
        private System.Windows.Forms.PictureBox f02_button_previous;
        private System.Windows.Forms.PictureBox f02_button_next;
        private System.Windows.Forms.PictureBox f02_button_formback;
    }
}