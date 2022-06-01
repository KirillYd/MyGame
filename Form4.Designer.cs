
namespace MyGame
{
    partial class Form4
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
            this.level1Button = new System.Windows.Forms.Button();
            this.level2Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // level1Button
            // 
            this.level1Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.level1Button.Font = new System.Drawing.Font("Cooper Black", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1Button.Location = new System.Drawing.Point(305, 160);
            this.level1Button.Name = "level1Button";
            this.level1Button.Size = new System.Drawing.Size(160, 45);
            this.level1Button.TabIndex = 1;
            this.level1Button.Text = "Level 1";
            this.level1Button.UseVisualStyleBackColor = false;
            this.level1Button.Click += new System.EventHandler(this.lvl1Click);
            // 
            // level2Button
            // 
            this.level2Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.level2Button.Font = new System.Drawing.Font("Cooper Black", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2Button.Location = new System.Drawing.Point(305, 254);
            this.level2Button.Name = "level2Button";
            this.level2Button.Size = new System.Drawing.Size(160, 45);
            this.level2Button.TabIndex = 2;
            this.level2Button.Text = "Level 2";
            this.level2Button.UseVisualStyleBackColor = false;
            this.level2Button.Click += new System.EventHandler(this.lvl2Clicl);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyGame.Properties.Resources.fone;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Let\'s start the game!";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.level2Button);
            this.Controls.Add(this.level1Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button level1Button;
        private System.Windows.Forms.Button level2Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}