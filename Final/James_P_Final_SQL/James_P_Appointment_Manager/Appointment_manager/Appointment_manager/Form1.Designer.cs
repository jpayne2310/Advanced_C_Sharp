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
            this.labAppointmentWith = new System.Windows.Forms.Label();
            this.labLocation = new System.Windows.Forms.Label();
            this.labComments = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.labFeedback = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labFeedback2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.labLocation_ID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labSTD = new System.Windows.Forms.Label();
            this.labETD = new System.Windows.Forms.Label();
            this.dtpStartDT = new System.Windows.Forms.DateTimePicker();
            this.dtpEndingDT = new System.Windows.Forms.DateTimePicker();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // labAppointmentWith
            // 
            this.labAppointmentWith.AutoSize = true;
            this.labAppointmentWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAppointmentWith.Location = new System.Drawing.Point(268, 211);
            this.labAppointmentWith.Name = "labAppointmentWith";
            this.labAppointmentWith.Size = new System.Drawing.Size(136, 20);
            this.labAppointmentWith.TabIndex = 0;
            this.labAppointmentWith.Text = "Appointment With";
            // 
            // labLocation
            // 
            this.labLocation.AutoSize = true;
            this.labLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLocation.Location = new System.Drawing.Point(268, 254);
            this.labLocation.Name = "labLocation";
            this.labLocation.Size = new System.Drawing.Size(70, 20);
            this.labLocation.TabIndex = 0;
            this.labLocation.Text = "Location";
            // 
            // labComments
            // 
            this.labComments.AutoSize = true;
            this.labComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labComments.Location = new System.Drawing.Point(16, 342);
            this.labComments.Name = "labComments";
            this.labComments.Size = new System.Drawing.Size(86, 20);
            this.labComments.TabIndex = 0;
            this.labComments.Text = "Comments";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(344, 254);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(274, 67);
            this.txtLocation.TabIndex = 6;
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(20, 372);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(598, 124);
            this.txtComments.TabIndex = 7;
            // 
            // labFeedback
            // 
            this.labFeedback.AutoSize = true;
            this.labFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFeedback.Location = new System.Drawing.Point(355, 316);
            this.labFeedback.Name = "labFeedback";
            this.labFeedback.Size = new System.Drawing.Size(0, 20);
            this.labFeedback.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSubmit.Location = new System.Drawing.Point(34, 502);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 62);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnClear.Location = new System.Drawing.Point(174, 502);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 62);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 175);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labFeedback2
            // 
            this.labFeedback2.AutoSize = true;
            this.labFeedback2.Location = new System.Drawing.Point(102, 323);
            this.labFeedback2.Name = "labFeedback2";
            this.labFeedback2.Size = new System.Drawing.Size(0, 13);
            this.labFeedback2.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Location = new System.Drawing.Point(412, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 26);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDelete.Location = new System.Drawing.Point(514, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 26);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(109, 323);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 13;
            // 
            // labLocation_ID
            // 
            this.labLocation_ID.AutoSize = true;
            this.labLocation_ID.Location = new System.Drawing.Point(31, 308);
            this.labLocation_ID.Name = "labLocation_ID";
            this.labLocation_ID.Size = new System.Drawing.Size(0, 13);
            this.labLocation_ID.TabIndex = 14;
            this.labLocation_ID.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(412, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(179, 159);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // labSTD
            // 
            this.labSTD.AutoSize = true;
            this.labSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSTD.Location = new System.Drawing.Point(16, 29);
            this.labSTD.Name = "labSTD";
            this.labSTD.Size = new System.Drawing.Size(139, 20);
            this.labSTD.TabIndex = 21;
            this.labSTD.Text = "Appointment Start";
            // 
            // labETD
            // 
            this.labETD.AutoSize = true;
            this.labETD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labETD.Location = new System.Drawing.Point(16, 77);
            this.labETD.Name = "labETD";
            this.labETD.Size = new System.Drawing.Size(133, 20);
            this.labETD.TabIndex = 22;
            this.labETD.Text = "Appointment End";
            // 
            // dtpStartDT
            // 
            this.dtpStartDT.CustomFormat = "MM-d-yyyy  HH:mm";
            this.dtpStartDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDT.Location = new System.Drawing.Point(155, 29);
            this.dtpStartDT.Name = "dtpStartDT";
            this.dtpStartDT.Size = new System.Drawing.Size(183, 20);
            this.dtpStartDT.TabIndex = 23;
            // 
            // dtpEndingDT
            // 
            this.dtpEndingDT.CustomFormat = "MM-d-yyyy  HH:mm";
            this.dtpEndingDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndingDT.Location = new System.Drawing.Point(155, 76);
            this.dtpEndingDT.Name = "dtpEndingDT";
            this.dtpEndingDT.Size = new System.Drawing.Size(183, 20);
            this.dtpEndingDT.TabIndex = 24;
            // 
            // cmbClient
            // 
            this.cmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(412, 208);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(179, 28);
            this.cmbClient.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnClose.Location = new System.Drawing.Point(314, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 62);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(630, 592);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.dtpEndingDT);
            this.Controls.Add(this.dtpStartDT);
            this.Controls.Add(this.labETD);
            this.Controls.Add(this.labSTD);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labLocation_ID);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labFeedback2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labFeedback);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.labComments);
            this.Controls.Add(this.labLocation);
            this.Controls.Add(this.labAppointmentWith);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Appointment Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAppointmentWith;
        private System.Windows.Forms.Label labLocation;
        private System.Windows.Forms.Label labComments;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label labFeedback;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labFeedback2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label labLocation_ID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labSTD;
        private System.Windows.Forms.Label labETD;
        private System.Windows.Forms.DateTimePicker dtpStartDT;
        private System.Windows.Forms.DateTimePicker dtpEndingDT;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Button btnClose;
    }
}

