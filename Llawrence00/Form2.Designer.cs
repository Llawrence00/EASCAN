
namespace EASCAN
{
    partial class Form2
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
            this.panel_navigation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttn_settings = new System.Windows.Forms.Button();
            this.bttn_profile = new System.Windows.Forms.Button();
            this.bttn_dashboard = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_navigation
            // 
            this.panel_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.panel_navigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_navigation.Controls.Add(this.button1);
            this.panel_navigation.Controls.Add(this.label2);
            this.panel_navigation.Controls.Add(this.pictureBox1);
            this.panel_navigation.Controls.Add(this.bttn_settings);
            this.panel_navigation.Controls.Add(this.bttn_profile);
            this.panel_navigation.Controls.Add(this.bttn_dashboard);
            this.panel_navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navigation.Location = new System.Drawing.Point(0, 61);
            this.panel_navigation.Name = "panel_navigation";
            this.panel_navigation.Size = new System.Drawing.Size(199, 451);
            this.panel_navigation.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(216)))), ((int)(((byte)(209)))));
            this.button1.Location = new System.Drawing.Point(0, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bttn_logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.label2.Location = new System.Drawing.Point(78, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bttn_settings
            // 
            this.bttn_settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttn_settings.FlatAppearance.BorderSize = 0;
            this.bttn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_settings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(216)))), ((int)(((byte)(209)))));
            this.bttn_settings.Location = new System.Drawing.Point(0, 194);
            this.bttn_settings.Name = "bttn_settings";
            this.bttn_settings.Size = new System.Drawing.Size(199, 55);
            this.bttn_settings.TabIndex = 0;
            this.bttn_settings.Text = "Settings";
            this.bttn_settings.UseVisualStyleBackColor = true;
            this.bttn_settings.Click += new System.EventHandler(this.bttn_settings_Click);
            // 
            // bttn_profile
            // 
            this.bttn_profile.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttn_profile.FlatAppearance.BorderSize = 0;
            this.bttn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_profile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(216)))), ((int)(((byte)(209)))));
            this.bttn_profile.Location = new System.Drawing.Point(0, 133);
            this.bttn_profile.Name = "bttn_profile";
            this.bttn_profile.Size = new System.Drawing.Size(199, 55);
            this.bttn_profile.TabIndex = 0;
            this.bttn_profile.Text = "Profile";
            this.bttn_profile.UseVisualStyleBackColor = true;
            this.bttn_profile.Click += new System.EventHandler(this.bttn_profile_Click);
            // 
            // bttn_dashboard
            // 
            this.bttn_dashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttn_dashboard.FlatAppearance.BorderSize = 0;
            this.bttn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(216)))), ((int)(((byte)(209)))));
            this.bttn_dashboard.Location = new System.Drawing.Point(0, 72);
            this.bttn_dashboard.Name = "bttn_dashboard";
            this.bttn_dashboard.Size = new System.Drawing.Size(199, 55);
            this.bttn_dashboard.TabIndex = 0;
            this.bttn_dashboard.Text = "Dashboard";
            this.bttn_dashboard.UseVisualStyleBackColor = true;
            this.bttn_dashboard.Click += new System.EventHandler(this.bttn_dashboard_Click);
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(199, 61);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(953, 451);
            this.panel_body.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEMPERATURE FACE CONTACT TRACING";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.panel_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1152, 61);
            this.panel_header.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 512);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_navigation);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "EASCAN";
            this.panel_navigation.ResumeLayout(false);
            this.panel_navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_navigation;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button bttn_dashboard;
        private System.Windows.Forms.Button bttn_settings;
        private System.Windows.Forms.Button bttn_profile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button bttn_logout;
        private System.Windows.Forms.Button button1;
    }
}

