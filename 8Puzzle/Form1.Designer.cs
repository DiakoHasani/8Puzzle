namespace _8Puzzle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_21 = new System.Windows.Forms.Button();
            this.btn_22 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_iterations = new System.Windows.Forms.Label();
            this.lbl_nodesGenerated = new System.Windows.Forms.Label();
            this.lbl_depth = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btn_22);
            this.groupBox1.Controls.Add(this.btn_21);
            this.groupBox1.Controls.Add(this.btn_20);
            this.groupBox1.Controls.Add(this.btn_12);
            this.groupBox1.Controls.Add(this.btn_11);
            this.groupBox1.Controls.Add(this.btn_10);
            this.groupBox1.Controls.Add(this.btn_02);
            this.groupBox1.Controls.Add(this.btn_01);
            this.groupBox1.Controls.Add(this.btn_00);
            this.groupBox1.Location = new System.Drawing.Point(62, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_00
            // 
            this.btn_00.BackColor = System.Drawing.SystemColors.Control;
            this.btn_00.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_00.FlatAppearance.BorderSize = 0;
            this.btn_00.Location = new System.Drawing.Point(0, 0);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(100, 100);
            this.btn_00.TabIndex = 0;
            this.btn_00.Text = "1";
            this.btn_00.UseVisualStyleBackColor = false;
            // 
            // btn_01
            // 
            this.btn_01.BackColor = System.Drawing.SystemColors.Control;
            this.btn_01.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_01.FlatAppearance.BorderSize = 0;
            this.btn_01.Location = new System.Drawing.Point(99, 0);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(100, 100);
            this.btn_01.TabIndex = 1;
            this.btn_01.Text = "2";
            this.btn_01.UseVisualStyleBackColor = false;
            // 
            // btn_02
            // 
            this.btn_02.BackColor = System.Drawing.SystemColors.Control;
            this.btn_02.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_02.FlatAppearance.BorderSize = 0;
            this.btn_02.Location = new System.Drawing.Point(199, 0);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(100, 100);
            this.btn_02.TabIndex = 2;
            this.btn_02.Text = "3";
            this.btn_02.UseVisualStyleBackColor = false;
            // 
            // btn_12
            // 
            this.btn_12.BackColor = System.Drawing.SystemColors.Control;
            this.btn_12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_12.FlatAppearance.BorderSize = 0;
            this.btn_12.Location = new System.Drawing.Point(199, 100);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(100, 100);
            this.btn_12.TabIndex = 5;
            this.btn_12.Text = "5";
            this.btn_12.UseVisualStyleBackColor = false;
            // 
            // btn_11
            // 
            this.btn_11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_11.FlatAppearance.BorderSize = 0;
            this.btn_11.Location = new System.Drawing.Point(99, 100);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(100, 100);
            this.btn_11.TabIndex = 4;
            this.btn_11.Text = "0";
            this.btn_11.UseVisualStyleBackColor = false;
            // 
            // btn_10
            // 
            this.btn_10.BackColor = System.Drawing.SystemColors.Control;
            this.btn_10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_10.FlatAppearance.BorderSize = 0;
            this.btn_10.Location = new System.Drawing.Point(0, 100);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(100, 100);
            this.btn_10.TabIndex = 3;
            this.btn_10.Text = "4";
            this.btn_10.UseVisualStyleBackColor = false;
            // 
            // btn_20
            // 
            this.btn_20.BackColor = System.Drawing.SystemColors.Control;
            this.btn_20.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_20.FlatAppearance.BorderSize = 0;
            this.btn_20.Location = new System.Drawing.Point(0, 200);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(100, 100);
            this.btn_20.TabIndex = 6;
            this.btn_20.Text = "6";
            this.btn_20.UseVisualStyleBackColor = false;
            // 
            // btn_21
            // 
            this.btn_21.BackColor = System.Drawing.SystemColors.Control;
            this.btn_21.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_21.FlatAppearance.BorderSize = 0;
            this.btn_21.Location = new System.Drawing.Point(99, 200);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(100, 100);
            this.btn_21.TabIndex = 7;
            this.btn_21.Text = "7";
            this.btn_21.UseVisualStyleBackColor = false;
            // 
            // btn_22
            // 
            this.btn_22.BackColor = System.Drawing.SystemColors.Control;
            this.btn_22.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_22.FlatAppearance.BorderSize = 0;
            this.btn_22.Location = new System.Drawing.Point(199, 200);
            this.btn_22.Name = "btn_22";
            this.btn_22.Size = new System.Drawing.Size(100, 100);
            this.btn_22.TabIndex = 8;
            this.btn_22.Text = "8";
            this.btn_22.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of iterations:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of generated nodes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Depth:";
            // 
            // lbl_iterations
            // 
            this.lbl_iterations.AutoSize = true;
            this.lbl_iterations.Location = new System.Drawing.Point(239, 13);
            this.lbl_iterations.Name = "lbl_iterations";
            this.lbl_iterations.Size = new System.Drawing.Size(13, 13);
            this.lbl_iterations.TabIndex = 4;
            this.lbl_iterations.Text = "0";
            // 
            // lbl_nodesGenerated
            // 
            this.lbl_nodesGenerated.AutoSize = true;
            this.lbl_nodesGenerated.Location = new System.Drawing.Point(239, 46);
            this.lbl_nodesGenerated.Name = "lbl_nodesGenerated";
            this.lbl_nodesGenerated.Size = new System.Drawing.Size(13, 13);
            this.lbl_nodesGenerated.TabIndex = 5;
            this.lbl_nodesGenerated.Text = "0";
            // 
            // lbl_depth
            // 
            this.lbl_depth.AutoSize = true;
            this.lbl_depth.Location = new System.Drawing.Point(239, 78);
            this.lbl_depth.Name = "lbl_depth";
            this.lbl_depth.Size = new System.Drawing.Size(13, 13);
            this.lbl_depth.TabIndex = 6;
            this.lbl_depth.Text = "0";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(338, 8);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 429);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_depth);
            this.Controls.Add(this.lbl_nodesGenerated);
            this.Controls.Add(this.lbl_iterations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_22;
        private System.Windows.Forms.Button btn_21;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_iterations;
        private System.Windows.Forms.Label lbl_nodesGenerated;
        private System.Windows.Forms.Label lbl_depth;
        private System.Windows.Forms.Button btn_refresh;
    }
}

