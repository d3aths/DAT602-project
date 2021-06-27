
namespace datconnection
{
    partial class CharManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharManagement));
            this.titleLabel = new System.Windows.Forms.Label();
            this.playerinfoLabel = new System.Windows.Forms.Label();
            this.playernameLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.playerList = new System.Windows.Forms.ListBox();
            this.playerActionsLabel = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.RadioButton();
            this.deleteBtn = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.RadioButton();
            this.killBtn = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("ROG Fonts", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(300, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(176, 52);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Game";
            // 
            // playerinfoLabel
            // 
            this.playerinfoLabel.AutoSize = true;
            this.playerinfoLabel.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerinfoLabel.ForeColor = System.Drawing.Color.White;
            this.playerinfoLabel.Location = new System.Drawing.Point(255, 123);
            this.playerinfoLabel.Name = "playerinfoLabel";
            this.playerinfoLabel.Size = new System.Drawing.Size(261, 20);
            this.playerinfoLabel.TabIndex = 1;
            this.playerinfoLabel.Text = "You are logged in as:";
            this.playerinfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playernameLabel
            // 
            this.playernameLabel.AutoSize = true;
            this.playernameLabel.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playernameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.playernameLabel.Location = new System.Drawing.Point(310, 143);
            this.playernameLabel.Name = "playernameLabel";
            this.playernameLabel.Size = new System.Drawing.Size(166, 20);
            this.playernameLabel.TabIndex = 2;
            this.playernameLabel.Text = "placeholder";
            this.playernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Black;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(120, 108);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(61, 55);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            this.logoutBtn.MouseEnter += new System.EventHandler(this.logoutBtn_MouseEnter);
            this.logoutBtn.MouseLeave += new System.EventHandler(this.logoutBtn_MouseLeave);
            // 
            // playerList
            // 
            this.playerList.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.FormattingEnabled = true;
            this.playerList.ItemHeight = 21;
            this.playerList.Location = new System.Drawing.Point(212, 197);
            this.playerList.Name = "playerList";
            this.playerList.ScrollAlwaysVisible = true;
            this.playerList.Size = new System.Drawing.Size(401, 88);
            this.playerList.TabIndex = 4;
            // 
            // playerActionsLabel
            // 
            this.playerActionsLabel.BackColor = System.Drawing.Color.White;
            this.playerActionsLabel.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerActionsLabel.Location = new System.Drawing.Point(212, 288);
            this.playerActionsLabel.Name = "playerActionsLabel";
            this.playerActionsLabel.Size = new System.Drawing.Size(401, 108);
            this.playerActionsLabel.TabIndex = 5;
            this.playerActionsLabel.Text = "Actions:";
            // 
            // playBtn
            // 
            this.playBtn.AutoSize = true;
            this.playBtn.BackColor = System.Drawing.Color.White;
            this.playBtn.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(234, 321);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(71, 25);
            this.playBtn.TabIndex = 6;
            this.playBtn.TabStop = true;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(340, 321);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(91, 25);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.TabStop = true;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.okBtn.Font = new System.Drawing.Font("Fira Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.Location = new System.Drawing.Point(531, 352);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(72, 40);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.AutoSize = true;
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(234, 352);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(71, 25);
            this.editBtn.TabIndex = 9;
            this.editBtn.TabStop = true;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // killBtn
            // 
            this.killBtn.AutoSize = true;
            this.killBtn.BackColor = System.Drawing.Color.White;
            this.killBtn.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killBtn.Location = new System.Drawing.Point(340, 352);
            this.killBtn.Name = "killBtn";
            this.killBtn.Size = new System.Drawing.Size(151, 25);
            this.killBtn.TabIndex = 10;
            this.killBtn.TabStop = true;
            this.killBtn.Text = "Kill Session";
            this.killBtn.UseVisualStyleBackColor = false;
            // 
            // CharManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.killBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.playerActionsLabel);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.playernameLabel);
            this.Controls.Add(this.playerinfoLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "CharManagement";
            this.Text = "Chararacter Management";
            this.Shown += new System.EventHandler(this.CharManagement_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label playerinfoLabel;
        private System.Windows.Forms.Label playernameLabel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.Label playerActionsLabel;
        private System.Windows.Forms.RadioButton playBtn;
        private System.Windows.Forms.RadioButton deleteBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.RadioButton editBtn;
        private System.Windows.Forms.RadioButton killBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}