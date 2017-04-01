namespace Appointment_manager
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.panLogin = new System.Windows.Forms.Panel();
            this.labFeedback2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panControls = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panLogin.SuspendLayout();
            this.panControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.labFeedback2);
            this.panLogin.Controls.Add(this.btnLogin);
            this.panLogin.Controls.Add(this.txtPwd);
            this.panLogin.Controls.Add(this.txtUName);
            this.panLogin.Controls.Add(this.label3);
            this.panLogin.Controls.Add(this.label2);
            this.panLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panLogin.Location = new System.Drawing.Point(121, 59);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(321, 179);
            this.panLogin.TabIndex = 0;
            // 
            // labFeedback2
            // 
            this.labFeedback2.AutoSize = true;
            this.labFeedback2.Location = new System.Drawing.Point(32, 142);
            this.labFeedback2.Name = "labFeedback2";
            this.labFeedback2.Size = new System.Drawing.Size(0, 19);
            this.labFeedback2.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(119, 104);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(107, 61);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(116, 26);
            this.txtPwd.TabIndex = 3;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(107, 17);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(116, 26);
            this.txtUName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // panControls
            // 
            this.panControls.Controls.Add(this.btnSearch);
            this.panControls.Controls.Add(this.btnAdd);
            this.panControls.Enabled = false;
            this.panControls.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panControls.Location = new System.Drawing.Point(76, 59);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(418, 224);
            this.panControls.TabIndex = 1;
            this.panControls.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSearch.Location = new System.Drawing.Point(239, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 81);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search for Exsisting Appointment";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(51)))));
            this.btnAdd.Location = new System.Drawing.Point(65, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 81);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Appointment";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payne\'s Deluxe Appointment Manager";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panControls);
            this.Controls.Add(this.panLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlPanel";
            this.Text = "Form2";
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labFeedback2;
    }
}