namespace ContactApp
{
    partial class ContactControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFullNameLabel = new Label();
            lblFullName = new Label();
            lblPhoneNumber = new Label();
            lblPhoneLabel = new Label();
            lblAddress = new Label();
            lblAddressLabel = new Label();
            btnMarkContacted = new Button();
            SuspendLayout();
            // 
            // lblFullNameLabel
            // 
            lblFullNameLabel.AutoSize = true;
            lblFullNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullNameLabel.Location = new Point(13, 11);
            lblFullNameLabel.Name = "lblFullNameLabel";
            lblFullNameLabel.Size = new Size(89, 31);
            lblFullNameLabel.TabIndex = 0;
            lblFullNameLabel.Text = "Name: ";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(90, 11);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(108, 31);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "John Doe";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(192, 42);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(163, 31);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "(000) 000-0000";
            // 
            // lblPhoneLabel
            // 
            lblPhoneLabel.AutoSize = true;
            lblPhoneLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneLabel.Location = new Point(13, 42);
            lblPhoneLabel.Name = "lblPhoneLabel";
            lblPhoneLabel.Size = new Size(183, 31);
            lblPhoneLabel.TabIndex = 2;
            lblPhoneLabel.Text = "Phone Number:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(124, 73);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(197, 31);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "email@email.com";
            // 
            // lblAddressLabel
            // 
            lblAddressLabel.AutoSize = true;
            lblAddressLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressLabel.Location = new Point(13, 73);
            lblAddressLabel.Name = "lblAddressLabel";
            lblAddressLabel.Size = new Size(105, 31);
            lblAddressLabel.TabIndex = 4;
            lblAddressLabel.Text = "Address:";
            // 
            // btnMarkContacted
            // 
            btnMarkContacted.Location = new Point(363, 11);
            btnMarkContacted.Name = "btnMarkContacted";
            btnMarkContacted.Size = new Size(94, 29);
            btnMarkContacted.TabIndex = 6;
            btnMarkContacted.Text = "Contact";
            btnMarkContacted.UseVisualStyleBackColor = true;
            btnMarkContacted.Click += btnMarkContacted_Click;
            // 
            // ContactControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnMarkContacted);
            Controls.Add(lblAddress);
            Controls.Add(lblAddressLabel);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblPhoneLabel);
            Controls.Add(lblFullName);
            Controls.Add(lblFullNameLabel);
            Name = "ContactControl";
            Size = new Size(468, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullNameLabel;
        private Label lblFullName;
        private Label lblPhoneNumber;
        private Label lblPhoneLabel;
        private Label lblAddress;
        private Label lblAddressLabel;
        private Button btnMarkContacted;
    }
}
