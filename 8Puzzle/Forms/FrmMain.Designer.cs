namespace _8Puzzle.Forms
{
    partial class FrmMain
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
            this.btn_Ids = new System.Windows.Forms.Button();
            this.btn_Accidental = new System.Windows.Forms.Button();
            this.btn_BFS = new System.Windows.Forms.Button();
            this.btn_AStar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ids
            // 
            this.btn_Ids.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ids.Location = new System.Drawing.Point(12, 25);
            this.btn_Ids.Name = "btn_Ids";
            this.btn_Ids.Size = new System.Drawing.Size(368, 49);
            this.btn_Ids.TabIndex = 0;
            this.btn_Ids.Text = "Ids";
            this.btn_Ids.UseVisualStyleBackColor = true;
            this.btn_Ids.Click += new System.EventHandler(this.btn_Ids_Click);
            // 
            // btn_Accidental
            // 
            this.btn_Accidental.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accidental.Location = new System.Drawing.Point(12, 80);
            this.btn_Accidental.Name = "btn_Accidental";
            this.btn_Accidental.Size = new System.Drawing.Size(368, 49);
            this.btn_Accidental.TabIndex = 1;
            this.btn_Accidental.Text = "Accidental";
            this.btn_Accidental.UseVisualStyleBackColor = true;
            this.btn_Accidental.Click += new System.EventHandler(this.btn_Accidental_Click);
            // 
            // btn_BFS
            // 
            this.btn_BFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BFS.Location = new System.Drawing.Point(12, 135);
            this.btn_BFS.Name = "btn_BFS";
            this.btn_BFS.Size = new System.Drawing.Size(368, 49);
            this.btn_BFS.TabIndex = 2;
            this.btn_BFS.Text = "BFS";
            this.btn_BFS.UseVisualStyleBackColor = true;
            this.btn_BFS.Click += new System.EventHandler(this.btn_BFS_Click);
            // 
            // btn_AStar
            // 
            this.btn_AStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AStar.Location = new System.Drawing.Point(12, 190);
            this.btn_AStar.Name = "btn_AStar";
            this.btn_AStar.Size = new System.Drawing.Size(368, 49);
            this.btn_AStar.TabIndex = 3;
            this.btn_AStar.Text = "AStar";
            this.btn_AStar.UseVisualStyleBackColor = true;
            this.btn_AStar.Click += new System.EventHandler(this.btn_AStar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 257);
            this.Controls.Add(this.btn_AStar);
            this.Controls.Add(this.btn_BFS);
            this.Controls.Add(this.btn_Accidental);
            this.Controls.Add(this.btn_Ids);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ids;
        private System.Windows.Forms.Button btn_Accidental;
        private System.Windows.Forms.Button btn_BFS;
        private System.Windows.Forms.Button btn_AStar;
    }
}