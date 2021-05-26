
namespace DBConnect
{
    partial class frmDBConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBConnect));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxRegNumber = new System.Windows.Forms.TextBox();
            this.labelRegNumber = new System.Windows.Forms.Label();
            this.labelMake = new System.Windows.Forms.Label();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.labelEngineSize = new System.Windows.Forms.Label();
            this.textBoxEngineSize = new System.Windows.Forms.TextBox();
            this.labelDateRegistered = new System.Windows.Forms.Label();
            this.textBoxDateRegistered = new System.Windows.Forms.TextBox();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.labelRentalPerDay = new System.Windows.Forms.Label();
            this.textBoxRentalPerDay = new System.Windows.Forms.TextBox();
            this.ButtonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bowman Car Hire";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(901, 297);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(213, 58);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(901, 467);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(213, 58);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(901, 379);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(213, 58);
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.Text = "&Add";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxRegNumber
            // 
            this.textBoxRegNumber.Location = new System.Drawing.Point(265, 292);
            this.textBoxRegNumber.Name = "textBoxRegNumber";
            this.textBoxRegNumber.Size = new System.Drawing.Size(347, 31);
            this.textBoxRegNumber.TabIndex = 6;
            // 
            // labelRegNumber
            // 
            this.labelRegNumber.AutoSize = true;
            this.labelRegNumber.Location = new System.Drawing.Point(43, 297);
            this.labelRegNumber.Name = "labelRegNumber";
            this.labelRegNumber.Size = new System.Drawing.Size(198, 25);
            this.labelRegNumber.TabIndex = 7;
            this.labelRegNumber.Text = "Vehicle reg number";
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(43, 357);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(65, 25);
            this.labelMake.TabIndex = 9;
            this.labelMake.Text = "Make";
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(265, 352);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(347, 31);
            this.textBoxMake.TabIndex = 8;
            // 
            // labelEngineSize
            // 
            this.labelEngineSize.AutoSize = true;
            this.labelEngineSize.Location = new System.Drawing.Point(43, 428);
            this.labelEngineSize.Name = "labelEngineSize";
            this.labelEngineSize.Size = new System.Drawing.Size(124, 25);
            this.labelEngineSize.TabIndex = 11;
            this.labelEngineSize.Text = "Engine size";
            // 
            // textBoxEngineSize
            // 
            this.textBoxEngineSize.Location = new System.Drawing.Point(265, 423);
            this.textBoxEngineSize.Name = "textBoxEngineSize";
            this.textBoxEngineSize.Size = new System.Drawing.Size(347, 31);
            this.textBoxEngineSize.TabIndex = 10;
            // 
            // labelDateRegistered
            // 
            this.labelDateRegistered.AutoSize = true;
            this.labelDateRegistered.Location = new System.Drawing.Point(43, 500);
            this.labelDateRegistered.Name = "labelDateRegistered";
            this.labelDateRegistered.Size = new System.Drawing.Size(159, 25);
            this.labelDateRegistered.TabIndex = 13;
            this.labelDateRegistered.Text = "Date registered";
            // 
            // textBoxDateRegistered
            // 
            this.textBoxDateRegistered.Location = new System.Drawing.Point(265, 495);
            this.textBoxDateRegistered.Name = "textBoxDateRegistered";
            this.textBoxDateRegistered.Size = new System.Drawing.Size(347, 31);
            this.textBoxDateRegistered.TabIndex = 12;
            // 
            // labelAvailable
            // 
            this.labelAvailable.Location = new System.Drawing.Point(43, 643);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(198, 25);
            this.labelAvailable.TabIndex = 14;
            this.labelAvailable.Text = "Available";
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.Location = new System.Drawing.Point(265, 641);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(28, 27);
            this.checkBoxAvailable.TabIndex = 15;
            this.checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // labelRentalPerDay
            // 
            this.labelRentalPerDay.AutoSize = true;
            this.labelRentalPerDay.Location = new System.Drawing.Point(43, 563);
            this.labelRentalPerDay.Name = "labelRentalPerDay";
            this.labelRentalPerDay.Size = new System.Drawing.Size(152, 25);
            this.labelRentalPerDay.TabIndex = 17;
            this.labelRentalPerDay.Text = "Rental per day";
            // 
            // textBoxRentalPerDay
            // 
            this.textBoxRentalPerDay.Location = new System.Drawing.Point(265, 558);
            this.textBoxRentalPerDay.Name = "textBoxRentalPerDay";
            this.textBoxRentalPerDay.Size = new System.Drawing.Size(347, 31);
            this.textBoxRentalPerDay.TabIndex = 16;
            this.textBoxRentalPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.Location = new System.Drawing.Point(26, 803);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(168, 58);
            this.ButtonFirst.TabIndex = 18;
            this.ButtonFirst.Text = "&First";
            this.ButtonFirst.UseVisualStyleBackColor = true;
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(200, 803);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(168, 58);
            this.buttonPrevious.TabIndex = 19;
            this.buttonPrevious.Text = "&Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(592, 803);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(168, 58);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = "&Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(766, 803);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(168, 58);
            this.buttonLast.TabIndex = 21;
            this.buttonLast.Text = "&Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(374, 817);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.ReadOnly = true;
            this.textBoxRange.Size = new System.Drawing.Size(212, 31);
            this.textBoxRange.TabIndex = 22;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(901, 626);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(213, 58);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(901, 713);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(213, 58);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(901, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFormat
            // 
            this.buttonFormat.Location = new System.Drawing.Point(26, 23);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(215, 58);
            this.buttonFormat.TabIndex = 26;
            this.buttonFormat.Text = "Format";
            this.buttonFormat.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(901, 546);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(213, 58);
            this.buttonPrint.TabIndex = 27;
            this.buttonPrint.Text = "&Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // frmDBConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1126, 871);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonFormat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxRange);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.ButtonFirst);
            this.Controls.Add(this.labelRentalPerDay);
            this.Controls.Add(this.textBoxRentalPerDay);
            this.Controls.Add(this.checkBoxAvailable);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.labelDateRegistered);
            this.Controls.Add(this.textBoxDateRegistered);
            this.Controls.Add(this.labelEngineSize);
            this.Controls.Add(this.textBoxEngineSize);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.labelRegNumber);
            this.Controls.Add(this.textBoxRegNumber);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Name = "frmDBConnect";
            this.Text = "Task A Timofeeva Anna 28/04/2021";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConnect_FormClosing);
            this.Load += new System.EventHandler(this.DBConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxRegNumber;
        private System.Windows.Forms.Label labelRegNumber;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.Label labelEngineSize;
        private System.Windows.Forms.TextBox textBoxEngineSize;
        private System.Windows.Forms.Label labelDateRegistered;
        private System.Windows.Forms.TextBox textBoxDateRegistered;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.Label labelRentalPerDay;
        private System.Windows.Forms.TextBox textBoxRentalPerDay;
        private System.Windows.Forms.Button ButtonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.Button buttonPrint;
    }
}

