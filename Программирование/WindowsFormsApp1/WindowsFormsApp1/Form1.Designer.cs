namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbQuestionText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.listLevels = new System.Windows.Forms.ListBox();
            this.btnFiftyFifty = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnFriendly = new System.Windows.Forms.Button();
            this.btnMarginError = new System.Windows.Forms.Button();
            this.btnReplaceQuest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuestionText
            // 
            this.lbQuestionText.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuestionText.Location = new System.Drawing.Point(291, 298);
            this.lbQuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuestionText.Name = "lbQuestionText";
            this.lbQuestionText.Size = new System.Drawing.Size(500, 101);
            this.lbQuestionText.TabIndex = 1;
            this.lbQuestionText.Text = "lbQuestionText";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(291, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerB.Location = new System.Drawing.Point(291, 451);
            this.btnAnswerB.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(500, 45);
            this.btnAnswerB.TabIndex = 3;
            this.btnAnswerB.Tag = "2";
            this.btnAnswerB.Text = "btnAnswerB";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerA.Location = new System.Drawing.Point(291, 398);
            this.btnAnswerA.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(500, 45);
            this.btnAnswerA.TabIndex = 4;
            this.btnAnswerA.Tag = "1";
            this.btnAnswerA.Text = "btnAnswerA";
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerC.Location = new System.Drawing.Point(291, 504);
            this.btnAnswerC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(500, 45);
            this.btnAnswerC.TabIndex = 4;
            this.btnAnswerC.Tag = "3";
            this.btnAnswerC.Text = "btnAnswerC";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerD.Location = new System.Drawing.Point(291, 557);
            this.btnAnswerD.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(500, 45);
            this.btnAnswerD.TabIndex = 3;
            this.btnAnswerD.Tag = "4";
            this.btnAnswerD.Text = "btnAnswerD";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // listLevels
            // 
            this.listLevels.Enabled = false;
            this.listLevels.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listLevels.FormattingEnabled = true;
            this.listLevels.ItemHeight = 32;
            this.listLevels.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "800 000",
            "400 000",
            "200 000",
            "100 000",
            "50 000",
            "25 000",
            "15 000",
            "10 000",
            "5 000",
            "3 000",
            "2 000",
            "1 000",
            "500"});
            this.listLevels.Location = new System.Drawing.Point(842, 13);
            this.listLevels.Name = "listLevels";
            this.listLevels.Size = new System.Drawing.Size(273, 484);
            this.listLevels.TabIndex = 5;
            // 
            // btnFiftyFifty
            // 
            this.btnFiftyFifty.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFiftyFifty.Location = new System.Drawing.Point(13, 115);
            this.btnFiftyFifty.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiftyFifty.Name = "btnFiftyFifty";
            this.btnFiftyFifty.Size = new System.Drawing.Size(221, 87);
            this.btnFiftyFifty.TabIndex = 4;
            this.btnFiftyFifty.Tag = "";
            this.btnFiftyFifty.Text = "50/50";
            this.btnFiftyFifty.UseVisualStyleBackColor = true;
            this.btnFiftyFifty.Click += new System.EventHandler(this.bntFiftyFifty_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(13, 13);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(221, 87);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Tag = "";
            this.btnHelp.Text = "Помощь зала";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnFriendly
            // 
            this.btnFriendly.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFriendly.Location = new System.Drawing.Point(13, 214);
            this.btnFriendly.Margin = new System.Windows.Forms.Padding(4);
            this.btnFriendly.Name = "btnFriendly";
            this.btnFriendly.Size = new System.Drawing.Size(221, 87);
            this.btnFriendly.TabIndex = 4;
            this.btnFriendly.Tag = "";
            this.btnFriendly.Text = "Звонок другу";
            this.btnFriendly.UseVisualStyleBackColor = true;
            this.btnFriendly.Click += new System.EventHandler(this.btnFriendly_Click);
            // 
            // btnMarginError
            // 
            this.btnMarginError.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMarginError.Location = new System.Drawing.Point(13, 312);
            this.btnMarginError.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarginError.Name = "btnMarginError";
            this.btnMarginError.Size = new System.Drawing.Size(221, 87);
            this.btnMarginError.TabIndex = 4;
            this.btnMarginError.Tag = "";
            this.btnMarginError.Text = "Право на ошибку";
            this.btnMarginError.UseVisualStyleBackColor = true;
            this.btnMarginError.Click += new System.EventHandler(this.btnMarginError_Click);
            // 
            // btnReplaceQuest
            // 
            this.btnReplaceQuest.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReplaceQuest.Location = new System.Drawing.Point(13, 410);
            this.btnReplaceQuest.Margin = new System.Windows.Forms.Padding(4);
            this.btnReplaceQuest.Name = "btnReplaceQuest";
            this.btnReplaceQuest.Size = new System.Drawing.Size(221, 87);
            this.btnReplaceQuest.TabIndex = 4;
            this.btnReplaceQuest.Tag = "";
            this.btnReplaceQuest.Text = "Заменить вопрос";
            this.btnReplaceQuest.UseVisualStyleBackColor = true;
            this.btnReplaceQuest.Click += new System.EventHandler(this.btnReplaceQuest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 621);
            this.Controls.Add(this.listLevels);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnReplaceQuest);
            this.Controls.Add(this.btnMarginError);
            this.Controls.Add(this.btnFriendly);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnFiftyFifty);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbQuestionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Кто хочет стать миллионером?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbQuestionText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.ListBox listLevels;
        private System.Windows.Forms.Button btnFiftyFifty;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnFriendly;
        private System.Windows.Forms.Button btnMarginError;
        private System.Windows.Forms.Button btnReplaceQuest;
    }
}

