namespace Gomoku_WinForm
{
    partial class GameController
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
            this.button1 = new System.Windows.Forms.Button();
            this.turn_label = new System.Windows.Forms.Label();
            this.Rematch_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(695, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "リタイア";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // turn_label
            // 
            this.turn_label.AutoSize = true;
            this.turn_label.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.turn_label.Location = new System.Drawing.Point(1, 9);
            this.turn_label.Name = "turn_label";
            this.turn_label.Size = new System.Drawing.Size(89, 32);
            this.turn_label.TabIndex = 1;
            this.turn_label.Text = "01手目";
            // 
            // Rematch_button
            // 
            this.Rematch_button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Rematch_button.Location = new System.Drawing.Point(614, 415);
            this.Rematch_button.Name = "Rematch_button";
            this.Rematch_button.Size = new System.Drawing.Size(75, 23);
            this.Rematch_button.TabIndex = 2;
            this.Rematch_button.Text = "再戦";
            this.Rematch_button.UseVisualStyleBackColor = true;
            this.Rematch_button.Click += new System.EventHandler(this.Rematch_button_Click);
            // 
            // GameController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rematch_button);
            this.Controls.Add(this.turn_label);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "GameController";
            this.Text = "Gomoku with Gravity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameController_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label turn_label;
        private System.Windows.Forms.Button Rematch_button;
    }
}