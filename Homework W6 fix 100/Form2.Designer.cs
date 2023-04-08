namespace Homework_W6
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
            this.components = new System.ComponentModel.Container();
            this.desain = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.enter = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desain
            // 
            this.desain.AutoSize = true;
            this.desain.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desain.Location = new System.Drawing.Point(509, 131);
            this.desain.Name = "desain";
            this.desain.Size = new System.Drawing.Size(110, 163);
            this.desain.TabIndex = 28;
            this.desain.Text = ".";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(463, 542);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(108, 73);
            this.enter.TabIndex = 29;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(1156, 542);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 73);
            this.delete.TabIndex = 30;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 694);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.desain);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label desain;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button delete;
    }
}