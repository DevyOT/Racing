namespace Racing
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
            this.GameField = new System.Windows.Forms.GroupBox();
            this.BetField = new System.Windows.Forms.GroupBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.labelstat3 = new System.Windows.Forms.Label();
            this.labelstat2 = new System.Windows.Forms.Label();
            this.labelStat1 = new System.Windows.Forms.Label();
            this.tbPlayer3 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.Money = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BetField.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.Location = new System.Drawing.Point(10, 69);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(612, 169);
            this.GameField.TabIndex = 0;
            this.GameField.TabStop = false;
            this.GameField.Enter += new System.EventHandler(this.GameField_Enter);
            // 
            // BetField
            // 
            this.BetField.Controls.Add(this.label2);
            this.BetField.Controls.Add(this.btnStart);
            this.BetField.Controls.Add(this.Player1);
            this.BetField.Controls.Add(this.btnBet);
            this.BetField.Controls.Add(this.labelstat3);
            this.BetField.Controls.Add(this.labelstat2);
            this.BetField.Controls.Add(this.labelStat1);
            this.BetField.Controls.Add(this.tbPlayer3);
            this.BetField.Controls.Add(this.tbPlayer2);
            this.BetField.Controls.Add(this.tbPlayer1);
            this.BetField.Controls.Add(this.Player3);
            this.BetField.Controls.Add(this.Player2);
            this.BetField.Controls.Add(this.label1);
            this.BetField.Location = new System.Drawing.Point(8, 255);
            this.BetField.Name = "BetField";
            this.BetField.Size = new System.Drawing.Size(622, 290);
            this.BetField.TabIndex = 1;
            this.BetField.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1.Location = new System.Drawing.Point(161, 68);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(52, 20);
            this.Player1.TabIndex = 6;
            this.Player1.Text = "Player";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.Location = new System.Drawing.Point(587, 35);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(41, 13);
            this.labelMoney.TabIndex = 5;
            this.labelMoney.Text = "label2";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(237, 261);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // labelstat3
            // 
            this.labelstat3.AutoSize = true;
            this.labelstat3.Location = new System.Drawing.Point(234, 218);
            this.labelstat3.Name = "labelstat3";
            this.labelstat3.Size = new System.Drawing.Size(35, 13);
            this.labelstat3.TabIndex = 3;
            this.labelstat3.Text = "label2";
            // 
            // labelstat2
            // 
            this.labelstat2.AutoSize = true;
            this.labelstat2.Location = new System.Drawing.Point(234, 152);
            this.labelstat2.Name = "labelstat2";
            this.labelstat2.Size = new System.Drawing.Size(35, 13);
            this.labelstat2.TabIndex = 3;
            this.labelstat2.Text = "label2";
            // 
            // labelStat1
            // 
            this.labelStat1.AutoSize = true;
            this.labelStat1.Location = new System.Drawing.Point(234, 91);
            this.labelStat1.Name = "labelStat1";
            this.labelStat1.Size = new System.Drawing.Size(35, 13);
            this.labelStat1.TabIndex = 3;
            this.labelStat1.Text = "label2";
            // 
            // tbPlayer3
            // 
            this.tbPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlayer3.Location = new System.Drawing.Point(237, 189);
            this.tbPlayer3.Name = "tbPlayer3";
            this.tbPlayer3.Size = new System.Drawing.Size(233, 26);
            this.tbPlayer3.TabIndex = 2;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlayer2.Location = new System.Drawing.Point(237, 123);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(233, 26);
            this.tbPlayer2.TabIndex = 2;
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlayer1.Location = new System.Drawing.Point(237, 62);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(233, 26);
            this.tbPlayer1.TabIndex = 2;
            this.tbPlayer1.TextChanged += new System.EventHandler(this.tbPlayer1_TextChanged);
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Money.Location = new System.Drawing.Point(539, 35);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(48, 13);
            this.Money.TabIndex = 1;
            this.Money.Text = "Money:";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player3.Location = new System.Drawing.Point(161, 192);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(56, 20);
            this.Player3.TabIndex = 1;
            this.Player3.Text = "Player ";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2.Location = new System.Drawing.Point(161, 130);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(56, 20);
            this.Player2.TabIndex = 1;
            this.Player2.Text = "Player ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BET:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(23, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "label2";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRating.Location = new System.Drawing.Point(314, 35);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(41, 13);
            this.labelRating.TabIndex = 8;
            this.labelRating.Text = "label3";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(342, 261);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Новая гонка";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 584);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.BetField);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.GameField);
            this.Controls.Add(this.Money);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BetField.ResumeLayout(false);
            this.BetField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GameField;
        private System.Windows.Forms.GroupBox BetField;
        private System.Windows.Forms.TextBox tbPlayer3;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label labelstat3;
        private System.Windows.Forms.Label labelstat2;
        private System.Windows.Forms.Label labelStat1;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
    }
}

