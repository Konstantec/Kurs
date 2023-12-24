namespace Kurs
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.NumberOfCard = new System.Windows.Forms.Label();
            this.CvvOfCard = new System.Windows.Forms.Label();
            this.BalanceOfCard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ChoiceOfCard2 = new System.Windows.Forms.TextBox();
            this.ChoiceOfMoney = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ChoiceOfCard = new System.Windows.Forms.ComboBox();
            this.Continue = new System.Windows.Forms.Button();
            this.BackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfCard
            // 
            this.NumberOfCard.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.NumberOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NumberOfCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NumberOfCard.Image = ((System.Drawing.Image)(resources.GetObject("NumberOfCard.Image")));
            this.NumberOfCard.Location = new System.Drawing.Point(67, 56);
            this.NumberOfCard.Name = "NumberOfCard";
            this.NumberOfCard.Size = new System.Drawing.Size(233, 22);
            this.NumberOfCard.TabIndex = 14;
            this.NumberOfCard.Text = "label3";
            // 
            // CvvOfCard
            // 
            this.CvvOfCard.BackColor = System.Drawing.Color.Transparent;
            this.CvvOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CvvOfCard.ForeColor = System.Drawing.Color.Red;
            this.CvvOfCard.Image = ((System.Drawing.Image)(resources.GetObject("CvvOfCard.Image")));
            this.CvvOfCard.Location = new System.Drawing.Point(117, 101);
            this.CvvOfCard.MaximumSize = new System.Drawing.Size(110, 100);
            this.CvvOfCard.MinimumSize = new System.Drawing.Size(10, 10);
            this.CvvOfCard.Name = "CvvOfCard";
            this.CvvOfCard.Size = new System.Drawing.Size(61, 21);
            this.CvvOfCard.TabIndex = 13;
            this.CvvOfCard.Text = "label2";
            this.CvvOfCard.Click += new System.EventHandler(this.CvvCard_click);
            // 
            // BalanceOfCard
            // 
            this.BalanceOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BalanceOfCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BalanceOfCard.Image = ((System.Drawing.Image)(resources.GetObject("BalanceOfCard.Image")));
            this.BalanceOfCard.Location = new System.Drawing.Point(67, 143);
            this.BalanceOfCard.Name = "BalanceOfCard";
            this.BalanceOfCard.Size = new System.Drawing.Size(111, 22);
            this.BalanceOfCard.TabIndex = 12;
            this.BalanceOfCard.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(47, 326);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 56);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(47, 423);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 66);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // ChoiceOfCard2
            // 
            this.ChoiceOfCard2.BackColor = System.Drawing.Color.LightGray;
            this.ChoiceOfCard2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChoiceOfCard2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceOfCard2.Location = new System.Drawing.Point(135, 347);
            this.ChoiceOfCard2.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.ChoiceOfCard2.MinimumSize = new System.Drawing.Size(0, 20);
            this.ChoiceOfCard2.Name = "ChoiceOfCard2";
            this.ChoiceOfCard2.Size = new System.Drawing.Size(223, 15);
            this.ChoiceOfCard2.TabIndex = 18;
            // 
            // ChoiceOfMoney
            // 
            this.ChoiceOfMoney.BackColor = System.Drawing.Color.LightGray;
            this.ChoiceOfMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChoiceOfMoney.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceOfMoney.Location = new System.Drawing.Point(135, 443);
            this.ChoiceOfMoney.MinimumSize = new System.Drawing.Size(0, 20);
            this.ChoiceOfMoney.Name = "ChoiceOfMoney";
            this.ChoiceOfMoney.Size = new System.Drawing.Size(228, 14);
            this.ChoiceOfMoney.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 66);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(47, 326);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(328, 56);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(47, 423);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(328, 56);
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(47, 229);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(328, 56);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // ChoiceOfCard
            // 
            this.ChoiceOfCard.BackColor = System.Drawing.Color.LightGray;
            this.ChoiceOfCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceOfCard.ForeColor = System.Drawing.Color.Black;
            this.ChoiceOfCard.FormattingEnabled = true;
            this.ChoiceOfCard.Location = new System.Drawing.Point(130, 246);
            this.ChoiceOfCard.Name = "ChoiceOfCard";
            this.ChoiceOfCard.Size = new System.Drawing.Size(233, 21);
            this.ChoiceOfCard.TabIndex = 19;
            this.ChoiceOfCard.Click += new System.EventHandler(this.ChoiceOfCard_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.ForeColor = System.Drawing.Color.Transparent;
            this.Continue.Image = ((System.Drawing.Image)(resources.GetObject("Continue.Image")));
            this.Continue.Location = new System.Drawing.Point(-3, 529);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(443, 41);
            this.Continue.TabIndex = 26;
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // BackToMain
            // 
            this.BackToMain.BackColor = System.Drawing.Color.Transparent;
            this.BackToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackToMain.FlatAppearance.BorderSize = 0;
            this.BackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMain.Image = ((System.Drawing.Image)(resources.GetObject("BackToMain.Image")));
            this.BackToMain.Location = new System.Drawing.Point(12, 12);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(24, 23);
            this.BackToMain.TabIndex = 27;
            this.BackToMain.UseVisualStyleBackColor = false;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 682);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ChoiceOfCard);
            this.Controls.Add(this.ChoiceOfCard2);
            this.Controls.Add(this.ChoiceOfMoney);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.NumberOfCard);
            this.Controls.Add(this.CvvOfCard);
            this.Controls.Add(this.BalanceOfCard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Поповнення мобільного";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NumberOfCard;
        private System.Windows.Forms.Label CvvOfCard;
        private System.Windows.Forms.Label BalanceOfCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox ChoiceOfCard2;
        private System.Windows.Forms.TextBox ChoiceOfMoney;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox ChoiceOfCard;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button BackToMain;
    }
}