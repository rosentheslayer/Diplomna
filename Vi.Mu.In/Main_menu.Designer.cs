
namespace Vi.Mu.In
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pianobtn = new System.Windows.Forms.Button();
            this.drumpadbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Title.Location = new System.Drawing.Point(174, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(636, 34);
            this.Title.TabIndex = 0;
            this.Title.Text = "Virtual Musical Instruments for Education";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 475);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pianobtn
            // 
            this.pianobtn.BackColor = System.Drawing.Color.DarkGray;
            this.pianobtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pianobtn.Location = new System.Drawing.Point(302, 112);
            this.pianobtn.Name = "pianobtn";
            this.pianobtn.Size = new System.Drawing.Size(366, 71);
            this.pianobtn.TabIndex = 2;
            this.pianobtn.Text = "Piano";
            this.pianobtn.UseVisualStyleBackColor = false;
            this.pianobtn.Click += new System.EventHandler(this.pianobtn_Click);
            // 
            // drumpadbtn
            // 
            this.drumpadbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drumpadbtn.Location = new System.Drawing.Point(302, 189);
            this.drumpadbtn.Name = "drumpadbtn";
            this.drumpadbtn.Size = new System.Drawing.Size(366, 71);
            this.drumpadbtn.TabIndex = 2;
            this.drumpadbtn.Text = "Drum Pad";
            this.drumpadbtn.UseVisualStyleBackColor = true;
            this.drumpadbtn.Click += new System.EventHandler(this.drumpadbtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(302, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(366, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "Piano";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(302, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(366, 71);
            this.button3.TabIndex = 2;
            this.button3.Text = "Piano";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 475);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.drumpadbtn);
            this.Controls.Add(this.pianobtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main_Menu";
            this.Text = "V.M.I.E";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pianobtn;
        private System.Windows.Forms.Button drumpadbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}