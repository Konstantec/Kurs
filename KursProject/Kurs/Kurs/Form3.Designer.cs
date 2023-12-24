namespace Kurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.NumberOfCard = new System.Windows.Forms.Label();
            this.CvvOfCard = new System.Windows.Forms.Label();
            this.BalanceOfCard = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ChoiceOfMoney = new System.Windows.Forms.TextBox();
            this.ChoiceOfNumber = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ChoiceOfCard = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 42);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Continue_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(42, 23);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(320, 184);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // NumberOfCard
            // 
            this.NumberOfCard.AutoSize = true;
            this.NumberOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NumberOfCard.ForeColor = System.Drawing.SystemColors.Control;
            this.NumberOfCard.Image = global::Kurs.Properties.Resources.Group_15;
            this.NumberOfCard.Location = new System.Drawing.Point(69, 74);
            this.NumberOfCard.MinimumSize = new System.Drawing.Size(233, 22);
            this.NumberOfCard.Name = "NumberOfCard";
            this.NumberOfCard.Size = new System.Drawing.Size(233, 22);
            this.NumberOfCard.TabIndex = 19;
            this.NumberOfCard.Text = "label3";
            // 
            // CvvOfCard
            // 
            this.CvvOfCard.BackColor = System.Drawing.Color.Transparent;
            this.CvvOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CvvOfCard.ForeColor = System.Drawing.Color.Red;
            this.CvvOfCard.Image = ((System.Drawing.Image)(resources.GetObject("CvvOfCard.Image")));
            this.CvvOfCard.Location = new System.Drawing.Point(124, 111);
            this.CvvOfCard.MaximumSize = new System.Drawing.Size(110, 100);
            this.CvvOfCard.MinimumSize = new System.Drawing.Size(10, 10);
            this.CvvOfCard.Name = "CvvOfCard";
            this.CvvOfCard.Size = new System.Drawing.Size(61, 21);
            this.CvvOfCard.TabIndex = 20;
            this.CvvOfCard.Text = "label2";
            this.CvvOfCard.Click += new System.EventHandler(this.CvvCard_Click);
            // 
            // BalanceOfCard
            // 
            this.BalanceOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BalanceOfCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BalanceOfCard.Image = ((System.Drawing.Image)(resources.GetObject("BalanceOfCard.Image")));
            this.BalanceOfCard.Location = new System.Drawing.Point(69, 149);
            this.BalanceOfCard.Name = "BalanceOfCard";
            this.BalanceOfCard.Size = new System.Drawing.Size(111, 22);
            this.BalanceOfCard.TabIndex = 21;
            this.BalanceOfCard.Text = "label1";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(44, 278);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(328, 56);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(44, 472);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(328, 56);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 56);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 66);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // ChoiceOfMoney
            // 
            this.ChoiceOfMoney.BackColor = System.Drawing.Color.LightGray;
            this.ChoiceOfMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChoiceOfMoney.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceOfMoney.Location = new System.Drawing.Point(132, 492);
            this.ChoiceOfMoney.MinimumSize = new System.Drawing.Size(0, 20);
            this.ChoiceOfMoney.Name = "ChoiceOfMoney";
            this.ChoiceOfMoney.Size = new System.Drawing.Size(228, 14);
            this.ChoiceOfMoney.TabIndex = 4;
            // 
            // ChoiceOfNumber
            // 
            this.ChoiceOfNumber.BackColor = System.Drawing.Color.LightGray;
            this.ChoiceOfNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChoiceOfNumber.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceOfNumber.Location = new System.Drawing.Point(132, 396);
            this.ChoiceOfNumber.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.ChoiceOfNumber.MinimumSize = new System.Drawing.Size(0, 20);
            this.ChoiceOfNumber.Name = "ChoiceOfNumber";
            this.ChoiceOfNumber.Size = new System.Drawing.Size(223, 15);
            this.ChoiceOfNumber.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(44, 375);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 56);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(44, 472);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 66);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // ChoiceOfCard
            // 
            this.ChoiceOfCard.BackColor = System.Drawing.Color.LightGray;
            this.ChoiceOfCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceOfCard.ForeColor = System.Drawing.Color.Black;
            this.ChoiceOfCard.FormattingEnabled = true;
            this.ChoiceOfCard.Location = new System.Drawing.Point(127, 295);
            this.ChoiceOfCard.Name = "ChoiceOfCard";
            this.ChoiceOfCard.Size = new System.Drawing.Size(233, 21);
            this.ChoiceOfCard.TabIndex = 6;
            this.ChoiceOfCard.Click += new System.EventHandler(this.ChoiceOfCard_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 682);
            this.Controls.Add(this.BalanceOfCard);
            this.Controls.Add(this.CvvOfCard);
            this.Controls.Add(this.NumberOfCard);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChoiceOfCard);
            this.Controls.Add(this.ChoiceOfNumber);
            this.Controls.Add(this.ChoiceOfMoney);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Name = "Form3";
            this.Text = "Переказ на картку";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label NumberOfCard;
        private System.Windows.Forms.Label CvvOfCard;
        private System.Windows.Forms.Label BalanceOfCard;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ChoiceOfMoney;
        private System.Windows.Forms.TextBox ChoiceOfNumber;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox ChoiceOfCard;
    }
}