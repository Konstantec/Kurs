namespace Kurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button TransfareToTeach;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CvvOfCard = new System.Windows.Forms.Label();
            this.NumberOfCard = new System.Windows.Forms.Label();
            this.HistoryOfCard = new System.Windows.Forms.ListBox();
            this.BalanceOfCard = new System.Windows.Forms.Label();
            this.TransferToCard = new System.Windows.Forms.Button();
            this.TransferToMobile = new System.Windows.Forms.Button();
            TransfareToTeach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TransfareToTeach
            // 
            TransfareToTeach.FlatAppearance.BorderSize = 0;
            TransfareToTeach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            TransfareToTeach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            TransfareToTeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TransfareToTeach.Image = ((System.Drawing.Image)(resources.GetObject("TransfareToTeach.Image")));
            TransfareToTeach.Location = new System.Drawing.Point(153, 229);
            TransfareToTeach.Name = "TransfareToTeach";
            TransfareToTeach.Size = new System.Drawing.Size(106, 149);
            TransfareToTeach.TabIndex = 15;
            TransfareToTeach.UseVisualStyleBackColor = true;
            TransfareToTeach.Click += new System.EventHandler(this.TransfareToTeach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CvvOfCard
            // 
            this.CvvOfCard.BackColor = System.Drawing.Color.Transparent;
            this.CvvOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CvvOfCard.ForeColor = System.Drawing.Color.Red;
            this.CvvOfCard.Image = ((System.Drawing.Image)(resources.GetObject("CvvOfCard.Image")));
            this.CvvOfCard.Location = new System.Drawing.Point(118, 119);
            this.CvvOfCard.MaximumSize = new System.Drawing.Size(110, 100);
            this.CvvOfCard.MinimumSize = new System.Drawing.Size(10, 10);
            this.CvvOfCard.Name = "CvvOfCard";
            this.CvvOfCard.Size = new System.Drawing.Size(61, 21);
            this.CvvOfCard.TabIndex = 7;
            this.CvvOfCard.Text = "label2";
            this.CvvOfCard.Click += new System.EventHandler(this.CvvCard_Click);
            // 
            // NumberOfCard
            // 
            this.NumberOfCard.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.NumberOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NumberOfCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NumberOfCard.Image = ((System.Drawing.Image)(resources.GetObject("NumberOfCard.Image")));
            this.NumberOfCard.Location = new System.Drawing.Point(68, 74);
            this.NumberOfCard.Name = "NumberOfCard";
            this.NumberOfCard.Size = new System.Drawing.Size(233, 22);
            this.NumberOfCard.TabIndex = 10;
            this.NumberOfCard.Text = "label3";
            // 
            // HistoryOfCard
            // 
            this.HistoryOfCard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HistoryOfCard.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryOfCard.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.HistoryOfCard.FormattingEnabled = true;
            this.HistoryOfCard.ItemHeight = 19;
            this.HistoryOfCard.Location = new System.Drawing.Point(-3, 422);
            this.HistoryOfCard.Name = "HistoryOfCard";
            this.HistoryOfCard.Size = new System.Drawing.Size(443, 270);
            this.HistoryOfCard.TabIndex = 12;
            // 
            // BalanceOfCard
            // 
            this.BalanceOfCard.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BalanceOfCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BalanceOfCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BalanceOfCard.Image = ((System.Drawing.Image)(resources.GetObject("BalanceOfCard.Image")));
            this.BalanceOfCard.Location = new System.Drawing.Point(68, 161);
            this.BalanceOfCard.Name = "BalanceOfCard";
            this.BalanceOfCard.Size = new System.Drawing.Size(131, 22);
            this.BalanceOfCard.TabIndex = 13;
            this.BalanceOfCard.Text = "label1";
            // 
            // TransferToCard
            // 
            this.TransferToCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TransferToCard.BackgroundImage")));
            this.TransferToCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TransferToCard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.TransferToCard.FlatAppearance.BorderSize = 0;
            this.TransferToCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.TransferToCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TransferToCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferToCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransferToCard.Location = new System.Drawing.Point(48, 229);
            this.TransferToCard.Name = "TransferToCard";
            this.TransferToCard.Size = new System.Drawing.Size(99, 143);
            this.TransferToCard.TabIndex = 14;
            this.TransferToCard.UseVisualStyleBackColor = true;
            this.TransferToCard.Click += new System.EventHandler(this.TransferToCard_Click_1);
            // 
            // TransferToMobile
            // 
            this.TransferToMobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TransferToMobile.FlatAppearance.BorderSize = 0;
            this.TransferToMobile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TransferToMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferToMobile.ForeColor = System.Drawing.Color.Transparent;
            this.TransferToMobile.Image = ((System.Drawing.Image)(resources.GetObject("TransferToMobile.Image")));
            this.TransferToMobile.Location = new System.Drawing.Point(265, 232);
            this.TransferToMobile.Name = "TransferToMobile";
            this.TransferToMobile.Size = new System.Drawing.Size(108, 143);
            this.TransferToMobile.TabIndex = 16;
            this.TransferToMobile.UseVisualStyleBackColor = true;
            this.TransferToMobile.Click += new System.EventHandler(this.TransferToMobile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(436, 682);
            this.Controls.Add(this.TransferToMobile);
            this.Controls.Add(TransfareToTeach);
            this.Controls.Add(this.TransferToCard);
            this.Controls.Add(this.BalanceOfCard);
            this.Controls.Add(this.HistoryOfCard);
            this.Controls.Add(this.NumberOfCard);
            this.Controls.Add(this.CvvOfCard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "XXX";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CvvOfCard;
        private System.Windows.Forms.Label NumberOfCard;
        private System.Windows.Forms.ListBox HistoryOfCard;
        private System.Windows.Forms.Label BalanceOfCard;
        private System.Windows.Forms.Button TransferToCard;
        private System.Windows.Forms.Button TransferToMobile;
    }
}

