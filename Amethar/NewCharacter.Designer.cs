namespace Amethar
{
    partial class NewCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCharacter));
            this.f01_icon_male = new System.Windows.Forms.PictureBox();
            this.f01_icon_female = new System.Windows.Forms.PictureBox();
            this.f01_textbox_playername = new System.Windows.Forms.TextBox();
            this.f01_button_confirm = new System.Windows.Forms.PictureBox();
            this.f01_button_formback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.f01_icon_male)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f01_icon_female)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f01_button_confirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f01_button_formback)).BeginInit();
            this.SuspendLayout();
            // 
            // f01_icon_male
            // 
            this.f01_icon_male.BackgroundImage = global::Amethar.Properties.Resources.GenderMaleStatic;
            this.f01_icon_male.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.f01_icon_male.Location = new System.Drawing.Point(233, 272);
            this.f01_icon_male.Name = "f01_icon_male";
            this.f01_icon_male.Size = new System.Drawing.Size(114, 113);
            this.f01_icon_male.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f01_icon_male.TabIndex = 3;
            this.f01_icon_male.TabStop = false;
            this.f01_icon_male.Click += new System.EventHandler(this.f01_icon_male_Click);
            this.f01_icon_male.MouseLeave += new System.EventHandler(this.f01_icon_male_Leave);
            this.f01_icon_male.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f01_icon_male_Move);
            // 
            // f01_icon_female
            // 
            this.f01_icon_female.BackgroundImage = global::Amethar.Properties.Resources.GenderFemaleStatic;
            this.f01_icon_female.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.f01_icon_female.Location = new System.Drawing.Point(451, 272);
            this.f01_icon_female.Name = "f01_icon_female";
            this.f01_icon_female.Size = new System.Drawing.Size(114, 113);
            this.f01_icon_female.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f01_icon_female.TabIndex = 4;
            this.f01_icon_female.TabStop = false;
            this.f01_icon_female.Click += new System.EventHandler(this.f01_icon_female_Click);
            this.f01_icon_female.MouseLeave += new System.EventHandler(this.f01_icon_female_Leave);
            this.f01_icon_female.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f01_icon_female_Move);
            // 
            // f01_textbox_playername
            // 
            this.f01_textbox_playername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.f01_textbox_playername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.f01_textbox_playername.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f01_textbox_playername.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.f01_textbox_playername.Location = new System.Drawing.Point(311, 150);
            this.f01_textbox_playername.MaxLength = 12;
            this.f01_textbox_playername.Name = "f01_textbox_playername";
            this.f01_textbox_playername.ShortcutsEnabled = false;
            this.f01_textbox_playername.Size = new System.Drawing.Size(177, 20);
            this.f01_textbox_playername.TabIndex = 7;
            this.f01_textbox_playername.TextChanged += new System.EventHandler(this.f01_textbox_playername_TextChanged);
            this.f01_textbox_playername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f01_textbox_playername_KeyPress);
            // 
            // f01_button_confirm
            // 
            this.f01_button_confirm.Image = global::Amethar.Properties.Resources.ButtonsConfirmStatic;
            this.f01_button_confirm.Location = new System.Drawing.Point(324, 468);
            this.f01_button_confirm.Name = "f01_button_confirm";
            this.f01_button_confirm.Size = new System.Drawing.Size(151, 39);
            this.f01_button_confirm.TabIndex = 8;
            this.f01_button_confirm.TabStop = false;
            this.f01_button_confirm.Click += new System.EventHandler(this.f01_button_confirm_Click);
            this.f01_button_confirm.MouseLeave += new System.EventHandler(this.f01_button_confirm_Leave);
            this.f01_button_confirm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f01_button_confirm_Move);
            // 
            // f01_button_formback
            // 
            this.f01_button_formback.BackColor = System.Drawing.Color.Transparent;
            this.f01_button_formback.Image = global::Amethar.Properties.Resources.ButtonFormBack;
            this.f01_button_formback.Location = new System.Drawing.Point(182, 468);
            this.f01_button_formback.Name = "f01_button_formback";
            this.f01_button_formback.Size = new System.Drawing.Size(108, 35);
            this.f01_button_formback.TabIndex = 11;
            this.f01_button_formback.TabStop = false;
            this.f01_button_formback.Click += new System.EventHandler(this.f01_button_formback_Click);
            this.f01_button_formback.MouseLeave += new System.EventHandler(this.f01_button_formback_Leave);
            this.f01_button_formback.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f01_button_formback_Move);
            // 
            // NewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amethar.Properties.Resources.NewCharacterBackground;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.f01_button_formback);
            this.Controls.Add(this.f01_button_confirm);
            this.Controls.Add(this.f01_textbox_playername);
            this.Controls.Add(this.f01_icon_female);
            this.Controls.Add(this.f01_icon_male);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "NewCharacter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amethar";
            this.Load += new System.EventHandler(this.NewCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f01_icon_male)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f01_icon_female)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f01_button_confirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f01_button_formback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox f01_icon_male;
        private System.Windows.Forms.PictureBox f01_icon_female;
        private System.Windows.Forms.TextBox f01_textbox_playername;
        private System.Windows.Forms.PictureBox f01_button_confirm;
        private System.Windows.Forms.PictureBox f01_button_formback;
    }
}