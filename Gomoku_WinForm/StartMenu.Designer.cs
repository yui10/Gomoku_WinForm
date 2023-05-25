namespace Gomoku_WinForm
{
    partial class StartMenu
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
            this.Ver_label = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.SetUp_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ver_label
            // 
            this.Ver_label.AutoSize = true;
            this.Ver_label.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ver_label.Location = new System.Drawing.Point(5, 5);
            this.Ver_label.Name = "Ver_label";
            this.Ver_label.Size = new System.Drawing.Size(49, 15);
            this.Ver_label.TabIndex = 0;
            this.Ver_label.Text = "Ver.1.1.2";
            // 
            // Start_button
            // 
            this.Start_button.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Start_button.Location = new System.Drawing.Point(12, 227);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(410, 58);
            this.Start_button.TabIndex = 1;
            this.Start_button.Text = "開始";
            this.Start_button.UseVisualStyleBackColor = true;
            // 
            // SetUp_Button
            // 
            this.SetUp_Button.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SetUp_Button.Location = new System.Drawing.Point(12, 291);
            this.SetUp_Button.Name = "SetUp_Button";
            this.SetUp_Button.Size = new System.Drawing.Size(205, 58);
            this.SetUp_Button.TabIndex = 2;
            this.SetUp_Button.Text = "設定";
            this.SetUp_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "重力付き五目並べ";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetUp_Button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Ver_label);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 400);
            this.MinimumSize = new System.Drawing.Size(388, 328);
            this.Name = "StartMenu";
            this.Text = "Gomoku with Gravity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ver_label;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button SetUp_Button;
        private System.Windows.Forms.Label label1;
    }
}