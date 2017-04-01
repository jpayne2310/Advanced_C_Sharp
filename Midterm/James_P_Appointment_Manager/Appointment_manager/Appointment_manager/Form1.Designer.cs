namespace Appointment_manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labStartDT = new System.Windows.Forms.Label();
            this.labEndingDT = new System.Windows.Forms.Label();
            this.labAppointmentWith = new System.Windows.Forms.Label();
            this.labLocation = new System.Windows.Forms.Label();
            this.labComments = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.dtpStartDT = new System.Windows.Forms.DateTimePicker();
            this.dtpEndingDT = new System.Windows.Forms.DateTimePicker();
            this.labFeedback = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labFeedback2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labStartDT
            // 
            this.labStartDT.AutoSize = true;
            this.labStartDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStartDT.Location = new System.Drawing.Point(27, 23);
            this.labStartDT.Name = "labStartDT";
            this.labStartDT.Size = new System.Drawing.Size(152, 20);
            this.labStartDT.TabIndex = 0;
            this.labStartDT.Text = "Start Date and Time";
            // 
            // labEndingDT
            // 
            this.labEndingDT.AutoSize = true;
            this.labEndingDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEndingDT.Location = new System.Drawing.Point(27, 66);
            this.labEndingDT.Name = "labEndingDT";
            this.labEndingDT.Size = new System.Drawing.Size(167, 20);
            this.labEndingDT.TabIndex = 0;
            this.labEndingDT.Text = "Ending Date and Time";
            // 
            // labAppointmentWith
            // 
            this.labAppointmentWith.AutoSize = true;
            this.labAppointmentWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAppointmentWith.Location = new System.Drawing.Point(27, 111);
            this.labAppointmentWith.Name = "labAppointmentWith";
            this.labAppointmentWith.Size = new System.Drawing.Size(136, 20);
            this.labAppointmentWith.TabIndex = 0;
            this.labAppointmentWith.Text = "Appointment With";
            // 
            // labLocation
            // 
            this.labLocation.AutoSize = true;
            this.labLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLocation.Location = new System.Drawing.Point(27, 155);
            this.labLocation.Name = "labLocation";
            this.labLocation.Size = new System.Drawing.Size(70, 20);
            this.labLocation.TabIndex = 0;
            this.labLocation.Text = "Location";
            // 
            // labComments
            // 
            this.labComments.AutoSize = true;
            this.labComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labComments.Location = new System.Drawing.Point(27, 239);
            this.labComments.Name = "labComments";
            this.labComments.Size = new System.Drawing.Size(73, 20);
            this.labComments.TabIndex = 0;
            this.labComments.Text = "Coments";
            // 
            // txtClient
            // 
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(166, 108);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(162, 26);
            this.txtClient.TabIndex = 3;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(166, 152);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(162, 67);
            this.txtLocation.TabIndex = 4;
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(106, 241);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(512, 119);
            this.txtComments.TabIndex = 5;
            // 
            // dtpStartDT
            // 
            this.dtpStartDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDT.Location = new System.Drawing.Point(200, 23);
            this.dtpStartDT.Name = "dtpStartDT";
            this.dtpStartDT.Size = new System.Drawing.Size(173, 26);
            this.dtpStartDT.TabIndex = 1;
            // 
            // dtpEndingDT
            // 
            this.dtpEndingDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndingDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndingDT.Location = new System.Drawing.Point(200, 61);
            this.dtpEndingDT.Name = "dtpEndingDT";
            this.dtpEndingDT.Size = new System.Drawing.Size(173, 26);
            this.dtpEndingDT.TabIndex = 2;
            // 
            // labFeedback
            // 
            this.labFeedback.AutoSize = true;
            this.labFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFeedback.Location = new System.Drawing.Point(355, 213);
            this.labFeedback.Name = "labFeedback";
            this.labFeedback.Size = new System.Drawing.Size(0, 20);
            this.labFeedback.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(219)))), ((int)(((byte)(48)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(105, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 62);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(289, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 62);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Appointment_manager.Properties.Resources.running_late_pic1;
            this.pictureBox2.Location = new System.Drawing.Point(474, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 84);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Appointment_manager.Properties.Resources.ImportantDateCalendar2;
            this.pictureBox1.Location = new System.Drawing.Point(412, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 181);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labFeedback2
            // 
            this.labFeedback2.AutoSize = true;
            this.labFeedback2.Location = new System.Drawing.Point(102, 220);
            this.labFeedback2.Name = "labFeedback2";
            this.labFeedback2.Size = new System.Drawing.Size(0, 13);
            this.labFeedback2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 449);
            this.Controls.Add(this.labFeedback2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labFeedback);
            this.Controls.Add(this.dtpEndingDT);
            this.Controls.Add(this.dtpStartDT);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.labComments);
            this.Controls.Add(this.labLocation);
            this.Controls.Add(this.labAppointmentWith);
            this.Controls.Add(this.labEndingDT);
            this.Controls.Add(this.labStartDT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Appointment Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStartDT;
        private System.Windows.Forms.Label labEndingDT;
        private System.Windows.Forms.Label labAppointmentWith;
        private System.Windows.Forms.Label labLocation;
        private System.Windows.Forms.Label labComments;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.DateTimePicker dtpStartDT;
        private System.Windows.Forms.DateTimePicker dtpEndingDT;
        private System.Windows.Forms.Label labFeedback;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labFeedback2;
    }
}

