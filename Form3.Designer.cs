namespace WinFormApp
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.red_trackBar = new System.Windows.Forms.TrackBar();
            this.green_trackBar = new System.Windows.Forms.TrackBar();
            this.blue_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(215, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // red_trackBar
            // 
            this.red_trackBar.Location = new System.Drawing.Point(62, 344);
            this.red_trackBar.Maximum = 25;
            this.red_trackBar.Name = "red_trackBar";
            this.red_trackBar.Size = new System.Drawing.Size(549, 45);
            this.red_trackBar.TabIndex = 1;
            this.red_trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // green_trackBar
            // 
            this.green_trackBar.Location = new System.Drawing.Point(62, 404);
            this.green_trackBar.Maximum = 25;
            this.green_trackBar.Name = "green_trackBar";
            this.green_trackBar.Size = new System.Drawing.Size(549, 45);
            this.green_trackBar.TabIndex = 2;
            this.green_trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // blue_trackBar
            // 
            this.blue_trackBar.Location = new System.Drawing.Point(62, 466);
            this.blue_trackBar.Maximum = 25;
            this.blue_trackBar.Name = "blue_trackBar";
            this.blue_trackBar.Size = new System.Drawing.Size(549, 45);
            this.blue_trackBar.TabIndex = 3;
            this.blue_trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Красный:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зеленый:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Синий:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 585);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blue_trackBar);
            this.Controls.Add(this.green_trackBar);
            this.Controls.Add(this.red_trackBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Выбор цвета фигуры";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar red_trackBar;
        private System.Windows.Forms.TrackBar green_trackBar;
        private System.Windows.Forms.TrackBar blue_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}