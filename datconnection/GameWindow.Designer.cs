
namespace datconnection
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.gameBG = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.atkBtn = new System.Windows.Forms.Button();
            this.invBtn = new System.Windows.Forms.Button();
            this.northBtn = new System.Windows.Forms.Button();
            this.westBtn = new System.Windows.Forms.Button();
            this.southBtn = new System.Windows.Forms.Button();
            this.eastBtn = new System.Windows.Forms.Button();
            this.nLabel = new System.Windows.Forms.Label();
            this.wLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.atkLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.stamLabel = new System.Windows.Forms.Label();
            this.atkText = new System.Windows.Forms.Label();
            this.hpText = new System.Windows.Forms.Label();
            this.stamText = new System.Windows.Forms.Label();
            this.coinsText = new System.Windows.Forms.Label();
            this.coinsLabel = new System.Windows.Forms.Label();
            this.chatBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sayLabel = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameBG
            // 
            this.gameBG.BackColor = System.Drawing.Color.DimGray;
            this.gameBG.Location = new System.Drawing.Point(28, 9);
            this.gameBG.Name = "gameBG";
            this.gameBG.Size = new System.Drawing.Size(578, 380);
            this.gameBG.TabIndex = 0;
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(666, 26);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(135, 56);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Player Name";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // atkBtn
            // 
            this.atkBtn.BackColor = System.Drawing.Color.Black;
            this.atkBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.atkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atkBtn.Font = new System.Drawing.Font("ROG Fonts", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atkBtn.ForeColor = System.Drawing.Color.White;
            this.atkBtn.Location = new System.Drawing.Point(626, 103);
            this.atkBtn.Name = "atkBtn";
            this.atkBtn.Size = new System.Drawing.Size(95, 40);
            this.atkBtn.TabIndex = 2;
            this.atkBtn.Text = "Attack";
            this.atkBtn.UseVisualStyleBackColor = false;
            // 
            // invBtn
            // 
            this.invBtn.BackColor = System.Drawing.Color.Black;
            this.invBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.invBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invBtn.Font = new System.Drawing.Font("ROG Fonts", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invBtn.ForeColor = System.Drawing.Color.White;
            this.invBtn.Location = new System.Drawing.Point(738, 103);
            this.invBtn.Name = "invBtn";
            this.invBtn.Size = new System.Drawing.Size(99, 40);
            this.invBtn.TabIndex = 3;
            this.invBtn.Text = "Inv";
            this.invBtn.UseVisualStyleBackColor = false;
            // 
            // northBtn
            // 
            this.northBtn.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.northBtn.FlatAppearance.BorderSize = 0;
            this.northBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.northBtn.Image = ((System.Drawing.Image)(resources.GetObject("northBtn.Image")));
            this.northBtn.Location = new System.Drawing.Point(705, 192);
            this.northBtn.Name = "northBtn";
            this.northBtn.Size = new System.Drawing.Size(45, 33);
            this.northBtn.TabIndex = 4;
            this.northBtn.UseVisualStyleBackColor = true;
            // 
            // westBtn
            // 
            this.westBtn.FlatAppearance.BorderSize = 0;
            this.westBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.westBtn.Image = ((System.Drawing.Image)(resources.GetObject("westBtn.Image")));
            this.westBtn.Location = new System.Drawing.Point(675, 230);
            this.westBtn.Name = "westBtn";
            this.westBtn.Size = new System.Drawing.Size(33, 37);
            this.westBtn.TabIndex = 5;
            this.westBtn.UseVisualStyleBackColor = true;
            // 
            // southBtn
            // 
            this.southBtn.FlatAppearance.BorderSize = 0;
            this.southBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.southBtn.Image = ((System.Drawing.Image)(resources.GetObject("southBtn.Image")));
            this.southBtn.Location = new System.Drawing.Point(706, 270);
            this.southBtn.Name = "southBtn";
            this.southBtn.Size = new System.Drawing.Size(42, 34);
            this.southBtn.TabIndex = 6;
            this.southBtn.UseVisualStyleBackColor = true;
            // 
            // eastBtn
            // 
            this.eastBtn.FlatAppearance.BorderSize = 0;
            this.eastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eastBtn.Image = ((System.Drawing.Image)(resources.GetObject("eastBtn.Image")));
            this.eastBtn.Location = new System.Drawing.Point(745, 226);
            this.eastBtn.Name = "eastBtn";
            this.eastBtn.Size = new System.Drawing.Size(35, 46);
            this.eastBtn.TabIndex = 7;
            this.eastBtn.UseVisualStyleBackColor = true;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLabel.ForeColor = System.Drawing.Color.White;
            this.nLabel.Location = new System.Drawing.Point(715, 165);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(27, 24);
            this.nLabel.TabIndex = 8;
            this.nLabel.Text = "N";
            // 
            // wLabel
            // 
            this.wLabel.AutoSize = true;
            this.wLabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wLabel.ForeColor = System.Drawing.Color.White;
            this.wLabel.Location = new System.Drawing.Point(642, 233);
            this.wLabel.Name = "wLabel";
            this.wLabel.Size = new System.Drawing.Size(29, 24);
            this.wLabel.TabIndex = 9;
            this.wLabel.Text = "W";
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel.ForeColor = System.Drawing.Color.White;
            this.sLabel.Location = new System.Drawing.Point(715, 307);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(28, 24);
            this.sLabel.TabIndex = 10;
            this.sLabel.Text = "S";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLabel.ForeColor = System.Drawing.Color.White;
            this.eLabel.Location = new System.Drawing.Point(786, 233);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(27, 24);
            this.eLabel.TabIndex = 11;
            this.eLabel.Text = "E";
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLabel.ForeColor = System.Drawing.Color.White;
            this.statsLabel.Location = new System.Drawing.Point(681, 365);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(99, 24);
            this.statsLabel.TabIndex = 12;
            this.statsLabel.Text = "Stats";
            // 
            // atkLabel
            // 
            this.atkLabel.AutoSize = true;
            this.atkLabel.Font = new System.Drawing.Font("ROG Fonts", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atkLabel.ForeColor = System.Drawing.Color.White;
            this.atkLabel.Location = new System.Drawing.Point(652, 414);
            this.atkLabel.Name = "atkLabel";
            this.atkLabel.Size = new System.Drawing.Size(48, 18);
            this.atkLabel.TabIndex = 13;
            this.atkLabel.Text = "ATK";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.ForeColor = System.Drawing.Color.White;
            this.hpLabel.Location = new System.Drawing.Point(651, 445);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(39, 20);
            this.hpLabel.TabIndex = 14;
            this.hpLabel.Text = "HP";
            // 
            // stamLabel
            // 
            this.stamLabel.AutoSize = true;
            this.stamLabel.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stamLabel.ForeColor = System.Drawing.Color.White;
            this.stamLabel.Location = new System.Drawing.Point(651, 477);
            this.stamLabel.Name = "stamLabel";
            this.stamLabel.Size = new System.Drawing.Size(70, 20);
            this.stamLabel.TabIndex = 15;
            this.stamLabel.Text = "STAM";
            // 
            // atkText
            // 
            this.atkText.AutoSize = true;
            this.atkText.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atkText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.atkText.Location = new System.Drawing.Point(748, 413);
            this.atkText.Name = "atkText";
            this.atkText.Size = new System.Drawing.Size(32, 20);
            this.atkText.TabIndex = 16;
            this.atkText.Text = "10";
            // 
            // hpText
            // 
            this.hpText.AutoSize = true;
            this.hpText.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hpText.Location = new System.Drawing.Point(748, 445);
            this.hpText.Name = "hpText";
            this.hpText.Size = new System.Drawing.Size(32, 20);
            this.hpText.TabIndex = 17;
            this.hpText.Text = "10";
            // 
            // stamText
            // 
            this.stamText.AutoSize = true;
            this.stamText.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stamText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.stamText.Location = new System.Drawing.Point(748, 477);
            this.stamText.Name = "stamText";
            this.stamText.Size = new System.Drawing.Size(32, 20);
            this.stamText.TabIndex = 18;
            this.stamText.Text = "10";
            // 
            // coinsText
            // 
            this.coinsText.AutoSize = true;
            this.coinsText.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsText.ForeColor = System.Drawing.Color.Goldenrod;
            this.coinsText.Location = new System.Drawing.Point(666, 531);
            this.coinsText.Name = "coinsText";
            this.coinsText.Size = new System.Drawing.Size(53, 20);
            this.coinsText.TabIndex = 19;
            this.coinsText.Text = "500";
            // 
            // coinsLabel
            // 
            this.coinsLabel.AutoSize = true;
            this.coinsLabel.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsLabel.ForeColor = System.Drawing.Color.White;
            this.coinsLabel.Location = new System.Drawing.Point(725, 531);
            this.coinsLabel.Name = "coinsLabel";
            this.coinsLabel.Size = new System.Drawing.Size(74, 20);
            this.coinsLabel.TabIndex = 20;
            this.coinsLabel.Text = "coins";
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.DarkGray;
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatBox.Location = new System.Drawing.Point(28, 402);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(578, 149);
            this.chatBox.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(75, 511);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(531, 35);
            this.textBox1.TabIndex = 22;
            // 
            // sayLabel
            // 
            this.sayLabel.AutoSize = true;
            this.sayLabel.BackColor = System.Drawing.Color.DarkGray;
            this.sayLabel.Font = new System.Drawing.Font("Fira Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayLabel.Location = new System.Drawing.Point(37, 525);
            this.sayLabel.Name = "sayLabel";
            this.sayLabel.Size = new System.Drawing.Size(44, 17);
            this.sayLabel.TabIndex = 23;
            this.sayLabel.Text = "Say:";
            // 
            // divider
            // 
            this.divider.Location = new System.Drawing.Point(28, 507);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(578, 1);
            this.divider.TabIndex = 24;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(849, 579);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.sayLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.coinsLabel);
            this.Controls.Add(this.coinsText);
            this.Controls.Add(this.stamText);
            this.Controls.Add(this.hpText);
            this.Controls.Add(this.atkText);
            this.Controls.Add(this.stamLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.atkLabel);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.wLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.eastBtn);
            this.Controls.Add(this.southBtn);
            this.Controls.Add(this.westBtn);
            this.Controls.Add(this.northBtn);
            this.Controls.Add(this.invBtn);
            this.Controls.Add(this.atkBtn);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.gameBG);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameBG;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button atkBtn;
        private System.Windows.Forms.Button invBtn;
        private System.Windows.Forms.Button northBtn;
        private System.Windows.Forms.Button westBtn;
        private System.Windows.Forms.Button southBtn;
        private System.Windows.Forms.Button eastBtn;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label wLabel;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Label atkLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label stamLabel;
        private System.Windows.Forms.Label atkText;
        private System.Windows.Forms.Label hpText;
        private System.Windows.Forms.Label stamText;
        private System.Windows.Forms.Label coinsText;
        private System.Windows.Forms.Label coinsLabel;
        private System.Windows.Forms.Label chatBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sayLabel;
        private System.Windows.Forms.Label divider;
    }
}