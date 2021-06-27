
namespace datconnection
{
    partial class UserInput
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
            this.title = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.newuserBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("ROG Fonts", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(347, 48);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(178, 53);
            this.title.TabIndex = 0;
            this.title.Text = "Game";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("ROG Fonts", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(155, 161);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(57, 242);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(213, 34);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInput.Font = new System.Drawing.Font("Fira Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(312, 154);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(326, 44);
            this.usernameInput.TabIndex = 3;
            // 
            // passInput
            // 
            this.passInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passInput.Font = new System.Drawing.Font("Fira Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.Location = new System.Drawing.Point(312, 231);
            this.passInput.Name = "passInput";
            this.passInput.PasswordChar = '*';
            this.passInput.Size = new System.Drawing.Size(326, 44);
            this.passInput.TabIndex = 4;
            this.passInput.UseSystemPasswordChar = true;
            // 
            // newuserBtn
            // 
            this.newuserBtn.BackColor = System.Drawing.Color.Black;
            this.newuserBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.newuserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newuserBtn.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newuserBtn.ForeColor = System.Drawing.Color.White;
            this.newuserBtn.Location = new System.Drawing.Point(312, 333);
            this.newuserBtn.Name = "newuserBtn";
            this.newuserBtn.Size = new System.Drawing.Size(151, 70);
            this.newuserBtn.TabIndex = 5;
            this.newuserBtn.Text = "Create User";
            this.newuserBtn.UseVisualStyleBackColor = false;
            this.newuserBtn.Click += new System.EventHandler(this.newuserBtn_Click);
            this.newuserBtn.MouseEnter += new System.EventHandler(this.newuserBtn_MouseEnter);
            this.newuserBtn.MouseLeave += new System.EventHandler(this.newuserBtn_MouseLeave);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Black;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(480, 333);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(158, 70);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Login Existing";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 361);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 11;
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(753, 475);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.newuserBtn);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UserInput";
            this.Text = "Login or Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button newuserBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}