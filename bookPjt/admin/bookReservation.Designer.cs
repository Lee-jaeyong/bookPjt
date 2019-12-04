namespace bookPjt.admin
{
    partial class BookReservation
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnReservation = new System.Windows.Forms.Button();
            this.bookName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("굴림", 15F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(55, 100);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(162, 36);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(253, 94);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(141, 58);
            this.btnReservation.TabIndex = 1;
            this.btnReservation.Text = "예 약";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("굴림", 13F);
            this.bookName.Location = new System.Drawing.Point(25, 34);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(0, 22);
            this.bookName.TabIndex = 2;
            // 
            // BookReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 181);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "BookReservation";
            this.Text = "bookReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Label bookName;
    }
}