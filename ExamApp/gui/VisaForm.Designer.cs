namespace ExamApp.gui
{
    partial class VisaForm
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
            this.visaRateBox = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.visaExpirationBox = new System.Windows.Forms.DateTimePicker();
            this.visaIssueBox = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.visaNumberBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // visaRateBox
            // 
            this.visaRateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visaRateBox.FormattingEnabled = true;
            this.visaRateBox.Location = new System.Drawing.Point(151, 256);
            this.visaRateBox.Name = "visaRateBox";
            this.visaRateBox.Size = new System.Drawing.Size(229, 32);
            this.visaRateBox.TabIndex = 45;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(18, 256);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(127, 35);
            this.textBox5.TabIndex = 44;
            this.textBox5.Text = "Тариф";
            // 
            // visaExpirationBox
            // 
            this.visaExpirationBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visaExpirationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visaExpirationBox.Location = new System.Drawing.Point(151, 181);
            this.visaExpirationBox.Name = "visaExpirationBox";
            this.visaExpirationBox.Size = new System.Drawing.Size(229, 29);
            this.visaExpirationBox.TabIndex = 43;
            // 
            // visaIssueBox
            // 
            this.visaIssueBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visaIssueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visaIssueBox.Location = new System.Drawing.Point(151, 106);
            this.visaIssueBox.Name = "visaIssueBox";
            this.visaIssueBox.Size = new System.Drawing.Size(229, 29);
            this.visaIssueBox.TabIndex = 42;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(18, 181);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(127, 59);
            this.textBox4.TabIndex = 41;
            this.textBox4.Text = "Дата окончания";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(18, 106);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(127, 59);
            this.textBox3.TabIndex = 40;
            this.textBox3.Text = "Дата получения";
            // 
            // visaNumberBox
            // 
            this.visaNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visaNumberBox.Location = new System.Drawing.Point(151, 59);
            this.visaNumberBox.Multiline = true;
            this.visaNumberBox.Name = "visaNumberBox";
            this.visaNumberBox.Size = new System.Drawing.Size(229, 29);
            this.visaNumberBox.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(18, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(127, 31);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 37;
            this.label2.Text = "Виза";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::ExamApp.Properties.Resources.logo;
            this.pictureBox.Location = new System.Drawing.Point(564, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(224, 208);
            this.pictureBox.TabIndex = 46;
            this.pictureBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(657, 378);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 60);
            this.saveButton.TabIndex = 47;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // VisaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.visaRateBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.visaExpirationBox);
            this.Controls.Add(this.visaIssueBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.visaNumberBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "VisaForm";
            this.Text = "VisaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox visaRateBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker visaExpirationBox;
        private System.Windows.Forms.DateTimePicker visaIssueBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox visaNumberBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button saveButton;
    }
}