namespace SMO_Efficiency_Calculator
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
            this.labelLambda = new System.Windows.Forms.Label();
            this.textBoxLambda = new System.Windows.Forms.TextBox();
            this.labelMu = new System.Windows.Forms.Label();
            this.textBoxMu = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.labelPotk = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLambda.Location = new System.Drawing.Point(419, 66);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(182, 21);
            this.labelLambda.TabIndex = 0;
            this.labelLambda.Text = "λ (Инт. поступления):";
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(432, 105);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(100, 20);
            this.textBoxLambda.TabIndex = 1;
            // 
            // labelMu
            // 
            this.labelMu.AutoSize = true;
            this.labelMu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMu.Location = new System.Drawing.Point(419, 169);
            this.labelMu.Name = "labelMu";
            this.labelMu.Size = new System.Drawing.Size(197, 21);
            this.labelMu.TabIndex = 2;
            this.labelMu.Text = "μ (Инт. обслуживания):";
            // 
            // textBoxMu
            // 
            this.textBoxMu.Location = new System.Drawing.Point(422, 201);
            this.textBoxMu.Name = "textBoxMu";
            this.textBoxMu.Size = new System.Drawing.Size(100, 20);
            this.textBoxMu.TabIndex = 3;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(429, 256);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(136, 21);
            this.labelN.TabIndex = 4;
            this.labelN.Text = "N (Число мест):";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(432, 302);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(447, 361);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(85, 29);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // labelPotk
            // 
            this.labelPotk.AutoSize = true;
            this.labelPotk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPotk.Location = new System.Drawing.Point(99, 414);
            this.labelPotk.Name = "labelPotk";
            this.labelPotk.Size = new System.Drawing.Size(173, 21);
            this.labelPotk.TabIndex = 7;
            this.labelPotk.Text = "Вероятность отказа:";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQ.Location = new System.Drawing.Point(99, 470);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(169, 21);
            this.labelQ.TabIndex = 8;
            this.labelQ.Text = "Отн. пропускная Q:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(99, 525);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(167, 21);
            this.labelA.TabIndex = 9;
            this.labelA.Text = "Абс. пропускная A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 726);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelPotk);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.textBoxMu);
            this.Controls.Add(this.labelMu);
            this.Controls.Add(this.textBoxLambda);
            this.Controls.Add(this.labelLambda);
            this.Name = "Form1";
            this.Text = "Почта СМО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLambda;
        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.Label labelMu;
        private System.Windows.Forms.TextBox textBoxMu;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label labelPotk;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelA;
    }
}

