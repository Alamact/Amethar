namespace Amethar
{
    partial class SceneBitterleafInn01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceneBitterleafInn01));
            this.f08_button_continue = new System.Windows.Forms.PictureBox();
            this.f08_text_dialogue = new System.Windows.Forms.Label();
            this.f08_choice_a = new System.Windows.Forms.Label();
            this.f08_choice_sp = new System.Windows.Forms.Label();
            this.f08_choice_c = new System.Windows.Forms.Label();
            this.f08_npc_portrait = new System.Windows.Forms.PictureBox();
            this.f08_choice_d = new System.Windows.Forms.Label();
            this.f08_choice_b = new System.Windows.Forms.Label();
            this.f08_npc_name = new System.Windows.Forms.Label();
            this.f08_playername = new System.Windows.Forms.Label();
            this.f08_text_hint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f08_button_continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f08_npc_portrait)).BeginInit();
            this.SuspendLayout();
            // 
            // f08_button_continue
            // 
            this.f08_button_continue.Image = global::Amethar.Properties.Resources.ButtonContinuePressed;
            this.f08_button_continue.Location = new System.Drawing.Point(324, 469);
            this.f08_button_continue.Name = "f08_button_continue";
            this.f08_button_continue.Size = new System.Drawing.Size(151, 39);
            this.f08_button_continue.TabIndex = 0;
            this.f08_button_continue.TabStop = false;
            this.f08_button_continue.Click += new System.EventHandler(this.f08_button_continue_Click);
            this.f08_button_continue.MouseLeave += new System.EventHandler(this.f08_button_continue_Leave);
            this.f08_button_continue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f08_button_continue_Move);
            // 
            // f08_text_dialogue
            // 
            this.f08_text_dialogue.BackColor = System.Drawing.Color.Transparent;
            this.f08_text_dialogue.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f08_text_dialogue.ForeColor = System.Drawing.Color.White;
            this.f08_text_dialogue.Location = new System.Drawing.Point(181, 54);
            this.f08_text_dialogue.Name = "f08_text_dialogue";
            this.f08_text_dialogue.Size = new System.Drawing.Size(555, 178);
            this.f08_text_dialogue.TabIndex = 1;
            this.f08_text_dialogue.Text = "These humans and their repugnant beverages sicken me.";
            this.f08_text_dialogue.Visible = false;
            // 
            // f08_choice_a
            // 
            this.f08_choice_a.BackColor = System.Drawing.Color.Transparent;
            this.f08_choice_a.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f08_choice_a.ForeColor = System.Drawing.Color.White;
            this.f08_choice_a.Location = new System.Drawing.Point(93, 321);
            this.f08_choice_a.Name = "f08_choice_a";
            this.f08_choice_a.Size = new System.Drawing.Size(611, 16);
            this.f08_choice_a.TabIndex = 2;
            this.f08_choice_a.Text = "What do you mean?";
            this.f08_choice_a.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.f08_choice_a.Visible = false;
            this.f08_choice_a.Click += new System.EventHandler(this.f08_choice_a_Click);
            this.f08_choice_a.MouseLeave += new System.EventHandler(this.f08_choice_a_Leave);
            this.f08_choice_a.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f08_choice_a_Move);
            // 
            // f08_choice_sp
            // 
            this.f08_choice_sp.BackColor = System.Drawing.Color.Transparent;
            this.f08_choice_sp.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f08_choice_sp.ForeColor = System.Drawing.Color.White;
            this.f08_choice_sp.Location = new System.Drawing.Point(93, 413);
            this.f08_choice_sp.Name = "f08_choice_sp";
            this.f08_choice_sp.Size = new System.Drawing.Size(611, 16);
            this.f08_choice_sp.TabIndex = 3;
            this.f08_choice_sp.Text = "I agree. I miss the rum of our homeland.";
            this.f08_choice_sp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.f08_choice_sp.Visible = false;
            this.f08_choice_sp.Click += new System.EventHandler(this.f08_choice_sp_Click);
            this.f08_choice_sp.MouseLeave += new System.EventHandler(this.f08_choice_sp_Leave);
            this.f08_choice_sp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f08_choice_sp_Move);
            // 
            // f08_choice_c
            // 
            this.f08_choice_c.BackColor = System.Drawing.Color.Transparent;
            this.f08_choice_c.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f08_choice_c.ForeColor = System.Drawing.Color.White;
            this.f08_choice_c.Location = new System.Drawing.Point(93, 367);
            this.f08_choice_c.Name = "f08_choice_c";
            this.f08_choice_c.Size = new System.Drawing.Size(611, 16);
            this.f08_choice_c.TabIndex = 4;
            this.f08_choice_c.Text = "I wouldn\'t know. I don\'t drink alchohol.";
            this.f08_choice_c.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.f08_choice_c.Visible = false;
            this.f08_choice_c.Click += new System.EventHandler(this.f08_choice_c_Click);
            this.f08_choice_c.MouseLeave += new System.EventHandler(this.f08_choice_c_Leave);
            this.f08_choice_c.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f08_choice_c_Move);
            // 
            // f08_npc_portrait
            // 
            this.f08_npc_portrait.BackgroundImage = global::Amethar.Properties.Resources.Valak;
            this.f08_npc_portrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f08_npc_portrait.Location = new System.Drawing.Point(47, 48);
            this.f08_npc_portrait.Name = "f08_npc_portrait";
            this.f08_npc_portrait.Size = new System.Drawing.Size(126, 198);
            this.f08_npc_portrait.TabIndex = 5;
            this.f08_npc_portrait.TabStop = false;
            this.f08_npc_portrait.Visible = false;
            // 
            // f08_choice_d
            // 
            this.f08_choice_d.BackColor = System.Drawing.Color.Transparent;
            this.f08_choice_d.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f08_choice_d.ForeColor = System.Drawing.Color.White;
            this.f08_choice_d.Location = new System.Drawing.Point(93, 390);
            this.f08_choice_d.Name = "f08_choice_d";
            this.f08_choice_d.Size = new System.Drawing.Size(611, 16);
            this.f08_choice_d.TabIndex = 6;
            this.f08_choice_d.Text = "Get away from me, drunkard!";
            this.f08_choice_d.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.f08_choice_d.Visible = false;
            this.f08_choice_d.Click += new System.EventHandler(this.f08_choice_d_Click);
            this.f08_choice_d.MouseLeave += new System.EventHandler(this.f08_choice_d_Leave);
            this.f08_choice_d.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f08_choice_d_Move);
            // 
            // f08_choice_b
            // 
            this.f08_choice_b.BackColor = System.Drawing.Color.Transparent;
            this.f08_choice_b.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f08_choice_b.ForeColor = System.Drawing.Color.White;
            this.f08_choice_b.Location = new System.Drawing.Point(93, 344);
            this.f08_choice_b.Name = "f08_choice_b";
            this.f08_choice_b.Size = new System.Drawing.Size(611, 16);
            this.f08_choice_b.TabIndex = 7;
            this.f08_choice_b.Text = "It\'s not so bad after a couple of shots.";
            this.f08_choice_b.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.f08_choice_b.Visible = false;
            this.f08_choice_b.Click += new System.EventHandler(this.f08_choice_b_Click);
            this.f08_choice_b.MouseLeave += new System.EventHandler(this.f08_choice_b_Leave);
            this.f08_choice_b.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f08_choice_b_Move);
            // 
            // f08_npc_name
            // 
            this.f08_npc_name.BackColor = System.Drawing.Color.Transparent;
            this.f08_npc_name.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f08_npc_name.ForeColor = System.Drawing.Color.Khaki;
            this.f08_npc_name.Location = new System.Drawing.Point(47, 251);
            this.f08_npc_name.Name = "f08_npc_name";
            this.f08_npc_name.Size = new System.Drawing.Size(126, 16);
            this.f08_npc_name.TabIndex = 8;
            this.f08_npc_name.Text = "Valak";
            this.f08_npc_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.f08_npc_name.Visible = false;
            // 
            // f08_playername
            // 
            this.f08_playername.BackColor = System.Drawing.Color.Transparent;
            this.f08_playername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f08_playername.ForeColor = System.Drawing.Color.Khaki;
            this.f08_playername.Location = new System.Drawing.Point(93, 294);
            this.f08_playername.Name = "f08_playername";
            this.f08_playername.Size = new System.Drawing.Size(611, 16);
            this.f08_playername.TabIndex = 9;
            this.f08_playername.Text = "Playername";
            this.f08_playername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.f08_playername.Visible = false;
            // 
            // f08_text_hint
            // 
            this.f08_text_hint.BackColor = System.Drawing.Color.Transparent;
            this.f08_text_hint.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f08_text_hint.ForeColor = System.Drawing.Color.White;
            this.f08_text_hint.Location = new System.Drawing.Point(181, 232);
            this.f08_text_hint.Name = "f08_text_hint";
            this.f08_text_hint.Size = new System.Drawing.Size(555, 42);
            this.f08_text_hint.TabIndex = 10;
            this.f08_text_hint.Text = "Hint: Some responses are restricted to a certain class, race or gender. They are " +
    "highlighted in yellow.";
            this.f08_text_hint.Visible = false;
            // 
            // SceneBitterleafInn01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(16)))));
            this.BackgroundImage = global::Amethar.Properties.Resources.SceneBitterleaf01;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.f08_text_hint);
            this.Controls.Add(this.f08_playername);
            this.Controls.Add(this.f08_npc_name);
            this.Controls.Add(this.f08_choice_b);
            this.Controls.Add(this.f08_choice_d);
            this.Controls.Add(this.f08_npc_portrait);
            this.Controls.Add(this.f08_choice_c);
            this.Controls.Add(this.f08_choice_sp);
            this.Controls.Add(this.f08_choice_a);
            this.Controls.Add(this.f08_text_dialogue);
            this.Controls.Add(this.f08_button_continue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SceneBitterleafInn01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amethar";
            this.Load += new System.EventHandler(this.SceneBitterleafInn01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f08_button_continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f08_npc_portrait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox f08_button_continue;
        private System.Windows.Forms.Label f08_text_dialogue;
        private System.Windows.Forms.Label f08_choice_a;
        private System.Windows.Forms.Label f08_choice_sp;
        private System.Windows.Forms.Label f08_choice_c;
        private System.Windows.Forms.PictureBox f08_npc_portrait;
        private System.Windows.Forms.Label f08_choice_d;
        private System.Windows.Forms.Label f08_choice_b;
        private System.Windows.Forms.Label f08_npc_name;
        private System.Windows.Forms.Label f08_playername;
        private System.Windows.Forms.Label f08_text_hint;
    }
}