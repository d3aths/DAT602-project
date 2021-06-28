
namespace datconnection
{
    partial class ClassPick
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zerkBtn = new System.Windows.Forms.Button();
            this.ninBtn = new System.Windows.Forms.Button();
            this.tankBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 161);
            this.label1.TabIndex = 0;
            this.label1.Text = "When first creating your character, you can select from 3 different builds that d" +
    "efine your starting stats.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Berserker: 100 STR, 20 HP, 20 STAM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ninja: 20 STR, 20 HP, 50 STAM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tank: 20 STR, 100 HP, 20 STAM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zerkBtn
            // 
            this.zerkBtn.BackColor = System.Drawing.Color.Black;
            this.zerkBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.zerkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zerkBtn.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zerkBtn.ForeColor = System.Drawing.Color.White;
            this.zerkBtn.Location = new System.Drawing.Point(34, 325);
            this.zerkBtn.Name = "zerkBtn";
            this.zerkBtn.Size = new System.Drawing.Size(175, 37);
            this.zerkBtn.TabIndex = 4;
            this.zerkBtn.Text = "Berserker";
            this.zerkBtn.UseVisualStyleBackColor = false;
            this.zerkBtn.Click += new System.EventHandler(this.zerkBtn_Click);
            // 
            // ninBtn
            // 
            this.ninBtn.BackColor = System.Drawing.Color.Black;
            this.ninBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ninBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ninBtn.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninBtn.ForeColor = System.Drawing.Color.White;
            this.ninBtn.Location = new System.Drawing.Point(229, 325);
            this.ninBtn.Name = "ninBtn";
            this.ninBtn.Size = new System.Drawing.Size(175, 37);
            this.ninBtn.TabIndex = 5;
            this.ninBtn.Text = "Ninja";
            this.ninBtn.UseVisualStyleBackColor = false;
            this.ninBtn.Click += new System.EventHandler(this.ninBtn_Click);
            // 
            // tankBtn
            // 
            this.tankBtn.BackColor = System.Drawing.Color.Black;
            this.tankBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tankBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tankBtn.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tankBtn.ForeColor = System.Drawing.Color.White;
            this.tankBtn.Location = new System.Drawing.Point(422, 325);
            this.tankBtn.Name = "tankBtn";
            this.tankBtn.Size = new System.Drawing.Size(175, 37);
            this.tankBtn.TabIndex = 6;
            this.tankBtn.Text = "Tank";
            this.tankBtn.UseVisualStyleBackColor = false;
            this.tankBtn.Click += new System.EventHandler(this.tankBtn_Click);
            // 
            // ClassPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(631, 411);
            this.ControlBox = false;
            this.Controls.Add(this.tankBtn);
            this.Controls.Add(this.ninBtn);
            this.Controls.Add(this.zerkBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClassPick";
            this.Text = "ClassPick";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button zerkBtn;
        private System.Windows.Forms.Button ninBtn;
        private System.Windows.Forms.Button tankBtn;
    }
}