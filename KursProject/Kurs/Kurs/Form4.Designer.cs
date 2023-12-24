namespace Kurs
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.BalanceOfCard = new System.Windows.Forms.Label();
            this.CvvOfCard = new System.Windows.Forms.Label();
            this.NumberOfCard = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ChoiceOfCard = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateOfSufent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BalanceOfCard
            // 
            this.BalanceOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BalanceOfCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BalanceOfCard.Image = ((System.Drawing.Image)(resources.GetObject("BalanceOfCard.Image")));
            this.BalanceOfCard.Location = new System.Drawing.Point(63, 138);
            this.BalanceOfCard.Name = "BalanceOfCard";
            this.BalanceOfCard.Size = new System.Drawing.Size(111, 22);
            this.BalanceOfCard.TabIndex = 26;
            this.BalanceOfCard.Text = "label1";
            // 
            // CvvOfCard
            // 
            this.CvvOfCard.BackColor = System.Drawing.Color.Transparent;
            this.CvvOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CvvOfCard.ForeColor = System.Drawing.Color.Red;
            this.CvvOfCard.Image = ((System.Drawing.Image)(resources.GetObject("CvvOfCard.Image")));
            this.CvvOfCard.Location = new System.Drawing.Point(118, 100);
            this.CvvOfCard.MaximumSize = new System.Drawing.Size(110, 100);
            this.CvvOfCard.MinimumSize = new System.Drawing.Size(10, 10);
            this.CvvOfCard.Name = "CvvOfCard";
            this.CvvOfCard.Size = new System.Drawing.Size(61, 21);
            this.CvvOfCard.TabIndex = 25;
            this.CvvOfCard.Text = "label2";
            this.CvvOfCard.Click += new System.EventHandler(this.CvvCard_Click);
            // 
            // NumberOfCard
            // 
            this.NumberOfCard.AutoSize = true;
            this.NumberOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NumberOfCard.ForeColor = System.Drawing.SystemColors.Control;
            this.NumberOfCard.Image = global::Kurs.Properties.Resources.Group_15;
            this.NumberOfCard.Location = new System.Drawing.Point(63, 63);
            this.NumberOfCard.MinimumSize = new System.Drawing.Size(233, 22);
            this.NumberOfCard.Name = "NumberOfCard";
            this.NumberOfCard.Size = new System.Drawing.Size(233, 22);
            this.NumberOfCard.TabIndex = 24;
            this.NumberOfCard.Text = "label3";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(36, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(320, 184);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(6, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // ChoiceOfCard
            // 
            this.ChoiceOfCard.BackColor = System.Drawing.Color.LightGray;
            this.ChoiceOfCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceOfCard.ForeColor = System.Drawing.Color.Black;
            this.ChoiceOfCard.FormattingEnabled = true;
            this.ChoiceOfCard.Location = new System.Drawing.Point(123, 517);
            this.ChoiceOfCard.Name = "ChoiceOfCard";
            this.ChoiceOfCard.Size = new System.Drawing.Size(233, 21);
            this.ChoiceOfCard.TabIndex = 27;
            this.ChoiceOfCard.Click += new System.EventHandler(this.ChoiceOfCard_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 66);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 56);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // DateOfSufent
            // 
            this.DateOfSufent.AutoSize = true;
            this.DateOfSufent.Location = new System.Drawing.Point(33, 208);
            this.DateOfSufent.MinimumSize = new System.Drawing.Size(350, 240);
            this.DateOfSufent.Name = "DateOfSufent";
            this.DateOfSufent.Size = new System.Drawing.Size(350, 240);
            this.DateOfSufent.TabIndex = 31;
            this.DateOfSufent.Text = "label4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(36, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 42);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateOfSufent);
            this.Controls.Add(this.ChoiceOfCard);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BalanceOfCard);
            this.Controls.Add(this.CvvOfCard);
            this.Controls.Add(this.NumberOfCard);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.button2);
            this.Name = "Form4";
            this.Text = "Спалата за навчання";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BalanceOfCard;
        private System.Windows.Forms.Label CvvOfCard;
        private System.Windows.Forms.Label NumberOfCard;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ChoiceOfCard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DateOfSufent;
        private System.Windows.Forms.Button button1;
    }
}