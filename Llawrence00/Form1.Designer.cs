
namespace EASCAN
{
    partial class Form1
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
            this.bttn_Clear = new System.Windows.Forms.Button();
            this.bttn_Login = new System.Windows.Forms.Button();
            this.chk_Show = new System.Windows.Forms.CheckBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_Clear
            // 
            this.bttn_Clear.BackColor = System.Drawing.Color.White;
            this.bttn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Clear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bttn_Clear.Location = new System.Drawing.Point(28, 306);
            this.bttn_Clear.Name = "bttn_Clear";
            this.bttn_Clear.Size = new System.Drawing.Size(216, 35);
            this.bttn_Clear.TabIndex = 31;
            this.bttn_Clear.Text = "CLEAR";
            this.bttn_Clear.UseVisualStyleBackColor = false;
            this.bttn_Clear.Click += new System.EventHandler(this.bttn_Clear_Click);
            // 
            // bttn_Login
            // 
            this.bttn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bttn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_Login.FlatAppearance.BorderSize = 0;
            this.bttn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Login.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Login.ForeColor = System.Drawing.Color.White;
            this.bttn_Login.Location = new System.Drawing.Point(28, 265);
            this.bttn_Login.Name = "bttn_Login";
            this.bttn_Login.Size = new System.Drawing.Size(216, 35);
            this.bttn_Login.TabIndex = 30;
            this.bttn_Login.Text = "ENTER";
            this.bttn_Login.UseVisualStyleBackColor = false;
            this.bttn_Login.Click += new System.EventHandler(this.bttn_Login_Click);
            // 
            // chk_Show
            // 
            this.chk_Show.AutoSize = true;
            this.chk_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Show.Location = new System.Drawing.Point(122, 219);
            this.chk_Show.Name = "chk_Show";
            this.chk_Show.Size = new System.Drawing.Size(125, 21);
            this.chk_Show.TabIndex = 29;
            this.chk_Show.Text = "Show Password";
            this.chk_Show.UseVisualStyleBackColor = true;
            this.chk_Show.CheckedChanged += new System.EventHandler(this.chk_Show_CheckedChanged);
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(25, 185);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '•';
            this.txt_Pass.Size = new System.Drawing.Size(216, 28);
            this.txt_Pass.TabIndex = 28;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(25, 119);
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(216, 28);
            this.txt_User.TabIndex = 26;
            this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(25, 119);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(79, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(269, 394);
            this.Controls.Add(this.bttn_Clear);
            this.Controls.Add(this.bttn_Login);
            this.Controls.Add(this.chk_Show);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Clear;
        private System.Windows.Forms.Button bttn_Login;
        private System.Windows.Forms.CheckBox chk_Show;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}