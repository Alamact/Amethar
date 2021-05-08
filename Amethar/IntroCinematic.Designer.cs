namespace Amethar
{
    partial class IntroCinematic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroCinematic));
            this.CinematicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Cinematic = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CinematicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // CinematicPlayer
            // 
            this.CinematicPlayer.Enabled = true;
            this.CinematicPlayer.Location = new System.Drawing.Point(0, 0);
            this.CinematicPlayer.Name = "CinematicPlayer";
            this.CinematicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("CinematicPlayer.OcxState")));
            this.CinematicPlayer.Size = new System.Drawing.Size(784, 563);
            this.CinematicPlayer.TabIndex = 0;
            // 
            // Cinematic
            // 
            this.Cinematic.Interval = 170000;
            this.Cinematic.Tick += new System.EventHandler(this.Cinematic_Tick);
            // 
            // IntroCinematic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.CinematicPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntroCinematic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amethar";
            this.Load += new System.EventHandler(this.IntroCinematic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CinematicPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer CinematicPlayer;
        private System.Windows.Forms.Timer Cinematic;

    }
}