namespace Amethar
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.f00_button_load = new System.Windows.Forms.PictureBox();
            this.f00_button_new = new System.Windows.Forms.PictureBox();
            this.f00_button_exit = new System.Windows.Forms.PictureBox();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.SoundEffects = new AxWMPLib.AxWindowsMediaPlayer();
            this.SecondaryEffects = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.f00_button_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_button_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_button_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundEffects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryEffects)).BeginInit();
            this.SuspendLayout();
            // 
            // f00_button_load
            // 
            this.f00_button_load.Image = global::Amethar.Properties.Resources.ButtonLoadStatic;
            resources.ApplyResources(this.f00_button_load, "f00_button_load");
            this.f00_button_load.Name = "f00_button_load";
            this.f00_button_load.TabStop = false;
            this.f00_button_load.Click += new System.EventHandler(this.f00_button_load_Click);
            this.f00_button_load.MouseLeave += new System.EventHandler(this.f00_button_load_Leave);
            this.f00_button_load.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f00_button_load_Move);
            // 
            // f00_button_new
            // 
            this.f00_button_new.Image = global::Amethar.Properties.Resources.ButtonNewStatic;
            resources.ApplyResources(this.f00_button_new, "f00_button_new");
            this.f00_button_new.Name = "f00_button_new";
            this.f00_button_new.TabStop = false;
            this.f00_button_new.Click += new System.EventHandler(this.f00_button_new_Click);
            this.f00_button_new.MouseLeave += new System.EventHandler(this.f00_button_new_Leave);
            this.f00_button_new.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f00_button_new_Move);
            // 
            // f00_button_exit
            // 
            this.f00_button_exit.Image = global::Amethar.Properties.Resources.ButtonExitStatic;
            resources.ApplyResources(this.f00_button_exit, "f00_button_exit");
            this.f00_button_exit.Name = "f00_button_exit";
            this.f00_button_exit.TabStop = false;
            this.f00_button_exit.Click += new System.EventHandler(this.f00_button_exit_Click);
            this.f00_button_exit.MouseLeave += new System.EventHandler(this.f00_button_exit_Leave);
            this.f00_button_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f00_button_exit_Move);
            // 
            // MusicPlayer
            // 
            resources.ApplyResources(this.MusicPlayer, "MusicPlayer");
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            // 
            // SoundEffects
            // 
            resources.ApplyResources(this.SoundEffects, "SoundEffects");
            this.SoundEffects.Name = "SoundEffects";
            this.SoundEffects.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SoundEffects.OcxState")));
            // 
            // SecondaryEffects
            // 
            resources.ApplyResources(this.SecondaryEffects, "SecondaryEffects");
            this.SecondaryEffects.Name = "SecondaryEffects";
            this.SecondaryEffects.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SecondaryEffects.OcxState")));
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amethar.Properties.Resources.MainMenuBackground;
            this.Controls.Add(this.SecondaryEffects);
            this.Controls.Add(this.SoundEffects);
            this.Controls.Add(this.MusicPlayer);
            this.Controls.Add(this.f00_button_exit);
            this.Controls.Add(this.f00_button_new);
            this.Controls.Add(this.f00_button_load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.f00_button_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_button_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_button_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundEffects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryEffects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox f00_button_load;
        private System.Windows.Forms.PictureBox f00_button_new;
        private System.Windows.Forms.PictureBox f00_button_exit;
        public AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        public AxWMPLib.AxWindowsMediaPlayer SoundEffects;
        public AxWMPLib.AxWindowsMediaPlayer SecondaryEffects;


    }
}

