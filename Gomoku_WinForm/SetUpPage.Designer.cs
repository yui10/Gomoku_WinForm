namespace Gomoku_WinForm
{
    partial class SetUpPage
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
            this.numeric_mapsize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_putsize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.modeChange_checkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mapsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_putsize)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric_mapsize
            // 
            this.numeric_mapsize.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numeric_mapsize.Location = new System.Drawing.Point(117, 26);
            this.numeric_mapsize.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numeric_mapsize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeric_mapsize.Name = "numeric_mapsize";
            this.numeric_mapsize.Size = new System.Drawing.Size(59, 29);
            this.numeric_mapsize.TabIndex = 0;
            this.numeric_mapsize.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "盤面のサイズ";
            // 
            // numeric_putsize
            // 
            this.numeric_putsize.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numeric_putsize.Location = new System.Drawing.Point(117, 61);
            this.numeric_putsize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_putsize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeric_putsize.Name = "numeric_putsize";
            this.numeric_putsize.Size = new System.Drawing.Size(59, 29);
            this.numeric_putsize.TabIndex = 2;
            this.numeric_putsize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "揃える数";
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OK_button.Location = new System.Drawing.Point(266, 326);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 4;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Cancel_button.Location = new System.Drawing.Point(347, 326);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "キャンセル";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Reset_button
            // 
            this.Reset_button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reset_button.Location = new System.Drawing.Point(185, 326);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(75, 23);
            this.Reset_button.TabIndex = 6;
            this.Reset_button.Text = "初期化";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // modeChange_checkBox
            // 
            this.modeChange_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.modeChange_checkBox.AutoSize = true;
            this.modeChange_checkBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.modeChange_checkBox.Location = new System.Drawing.Point(117, 96);
            this.modeChange_checkBox.Name = "modeChange_checkBox";
            this.modeChange_checkBox.Size = new System.Drawing.Size(67, 31);
            this.modeChange_checkBox.TabIndex = 7;
            this.modeChange_checkBox.Text = "Nomal";
            this.modeChange_checkBox.UseVisualStyleBackColor = true;
            this.modeChange_checkBox.CheckedChanged += new System.EventHandler(this.ModeChange_checkBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "モード";
            // 
            // SetUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modeChange_checkBox);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_putsize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_mapsize);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 400);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "SetUpPage";
            this.Text = "Gomoku with Gravity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetUpPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mapsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_putsize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeric_mapsize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_putsize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.CheckBox modeChange_checkBox;
        private System.Windows.Forms.Label label3;
    }
}