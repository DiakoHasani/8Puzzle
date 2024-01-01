namespace _8Puzzle.Forms
{
    partial class FrmBFS
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
            this.btn_22 = new System.Windows.Forms.Button();
            this.btn_21 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_depth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_22
            // 
            this.btn_22.BackColor = System.Drawing.SystemColors.Control;
            this.btn_22.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_22.FlatAppearance.BorderSize = 0;
            this.btn_22.Location = new System.Drawing.Point(261, 314);
            this.btn_22.Name = "btn_22";
            this.btn_22.Size = new System.Drawing.Size(100, 100);
            this.btn_22.TabIndex = 17;
            this.btn_22.Text = "8";
            this.btn_22.UseVisualStyleBackColor = false;
            // 
            // btn_21
            // 
            this.btn_21.BackColor = System.Drawing.SystemColors.Control;
            this.btn_21.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_21.FlatAppearance.BorderSize = 0;
            this.btn_21.Location = new System.Drawing.Point(161, 314);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(100, 100);
            this.btn_21.TabIndex = 16;
            this.btn_21.Text = "7";
            this.btn_21.UseVisualStyleBackColor = false;
            // 
            // btn_20
            // 
            this.btn_20.BackColor = System.Drawing.SystemColors.Control;
            this.btn_20.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_20.FlatAppearance.BorderSize = 0;
            this.btn_20.Location = new System.Drawing.Point(62, 314);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(100, 100);
            this.btn_20.TabIndex = 15;
            this.btn_20.Text = "6";
            this.btn_20.UseVisualStyleBackColor = false;
            // 
            // btn_12
            // 
            this.btn_12.BackColor = System.Drawing.SystemColors.Control;
            this.btn_12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_12.FlatAppearance.BorderSize = 0;
            this.btn_12.Location = new System.Drawing.Point(261, 214);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(100, 100);
            this.btn_12.TabIndex = 14;
            this.btn_12.Text = "5";
            this.btn_12.UseVisualStyleBackColor = false;
            // 
            // btn_11
            // 
            this.btn_11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_11.FlatAppearance.BorderSize = 0;
            this.btn_11.Location = new System.Drawing.Point(161, 214);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(100, 100);
            this.btn_11.TabIndex = 13;
            this.btn_11.Text = "0";
            this.btn_11.UseVisualStyleBackColor = false;
            // 
            // btn_10
            // 
            this.btn_10.BackColor = System.Drawing.SystemColors.Control;
            this.btn_10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_10.FlatAppearance.BorderSize = 0;
            this.btn_10.Location = new System.Drawing.Point(62, 214);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(100, 100);
            this.btn_10.TabIndex = 12;
            this.btn_10.Text = "4";
            this.btn_10.UseVisualStyleBackColor = false;
            // 
            // btn_02
            // 
            this.btn_02.BackColor = System.Drawing.SystemColors.Control;
            this.btn_02.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_02.FlatAppearance.BorderSize = 0;
            this.btn_02.Location = new System.Drawing.Point(261, 114);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(100, 100);
            this.btn_02.TabIndex = 11;
            this.btn_02.Text = "3";
            this.btn_02.UseVisualStyleBackColor = false;
            // 
            // btn_01
            // 
            this.btn_01.BackColor = System.Drawing.SystemColors.Control;
            this.btn_01.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_01.FlatAppearance.BorderSize = 0;
            this.btn_01.Location = new System.Drawing.Point(161, 114);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(100, 100);
            this.btn_01.TabIndex = 10;
            this.btn_01.Text = "2";
            this.btn_01.UseVisualStyleBackColor = false;
            // 
            // btn_00
            // 
            this.btn_00.BackColor = System.Drawing.SystemColors.Control;
            this.btn_00.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_00.FlatAppearance.BorderSize = 0;
            this.btn_00.Location = new System.Drawing.Point(62, 114);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(100, 100);
            this.btn_00.TabIndex = 9;
            this.btn_00.Text = "1";
            this.btn_00.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Depth:";
            // 
            // lbl_depth
            // 
            this.lbl_depth.AutoSize = true;
            this.lbl_depth.Location = new System.Drawing.Point(124, 55);
            this.lbl_depth.Name = "lbl_depth";
            this.lbl_depth.Size = new System.Drawing.Size(13, 13);
            this.lbl_depth.TabIndex = 19;
            this.lbl_depth.Text = "0";
            // 
            // FrmBFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_depth);
            this.Controls.Add(this.btn_22);
            this.Controls.Add(this.btn_21);
            this.Controls.Add(this.btn_20);
            this.Controls.Add(this.btn_12);
            this.Controls.Add(this.btn_11);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.btn_01);
            this.Controls.Add(this.btn_00);
            this.Name = "FrmBFS";
            this.Text = "FrmBFS";
            this.Load += new System.EventHandler(this.FrmBFS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_22;
        private System.Windows.Forms.Button btn_21;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_depth;
    }
}