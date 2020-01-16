namespace Million
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
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bntFiftyFifty = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLevel
            // 
            this.lstLevel.CausesValidation = false;
            this.lstLevel.Enabled = false;
            this.lstLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 29;
            this.lstLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "   800 000",
            "   400 000",
            "   200 000",
            "   100 000",
            "     50 000",
            "     25 000",
            "     15 000",
            "     10 000",
            "       5 000",
            "       3 000",
            "       2 000",
            "       1 000",
            "          500"});
            this.lstLevel.Location = new System.Drawing.Point(641, 16);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(120, 439);
            this.lstLevel.TabIndex = 0;
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Location = new System.Drawing.Point(178, 386);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(183, 35);
            this.btnAnswerA.TabIndex = 1;
            this.btnAnswerA.Tag = "1";
            this.btnAnswerA.Text = "btnAnswerA";
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Location = new System.Drawing.Point(445, 386);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(170, 35);
            this.btnAnswerB.TabIndex = 1;
            this.btnAnswerB.Tag = "2";
            this.btnAnswerB.Text = "btnAnswerB";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Location = new System.Drawing.Point(178, 430);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(183, 35);
            this.btnAnswerC.TabIndex = 1;
            this.btnAnswerC.Tag = "3";
            this.btnAnswerC.Text = "btnAnswerC";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Location = new System.Drawing.Point(445, 430);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(170, 35);
            this.btnAnswerD.TabIndex = 1;
            this.btnAnswerD.Tag = "4";
            this.btnAnswerD.Text = "btnAnswerD";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Million.Properties.Resources.picture;
            this.pictureBox.Location = new System.Drawing.Point(178, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(437, 282);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // bntFiftyFifty
            // 
            this.bntFiftyFifty.Location = new System.Drawing.Point(12, 16);
            this.bntFiftyFifty.Name = "bntFiftyFifty";
            this.bntFiftyFifty.Size = new System.Drawing.Size(142, 36);
            this.bntFiftyFifty.TabIndex = 3;
            this.bntFiftyFifty.Text = "50/50";
            this.bntFiftyFifty.UseVisualStyleBackColor = true;
            this.bntFiftyFifty.Click += new System.EventHandler(this.bntFiftyFifty_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(181, 317);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(433, 59);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "lblQuestion";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 70);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(142, 36);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Помощь зала";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.bntFiftyFifty);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.lstLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Кто хочет стать миллионером?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button bntFiftyFifty;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnHelp;
    }
}

