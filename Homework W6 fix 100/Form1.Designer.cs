namespace Homework_W6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nyawa = new System.Windows.Forms.TextBox();
            this.play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "WORDLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set How Much You Can Guess!";
            // 
            // nyawa
            // 
            this.nyawa.Location = new System.Drawing.Point(147, 119);
            this.nyawa.Name = "nyawa";
            this.nyawa.Size = new System.Drawing.Size(146, 26);
            this.nyawa.TabIndex = 2;
            this.nyawa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nyawa_KeyPress);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(177, 168);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 31);
            this.play.TabIndex = 3;
            this.play.Text = "Play!!!";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 221);
            this.Controls.Add(this.play);
            this.Controls.Add(this.nyawa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WORDLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nyawa;
        private System.Windows.Forms.Button play;
    }
}

