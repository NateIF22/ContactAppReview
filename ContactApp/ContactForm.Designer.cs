namespace ContactApp
{
    partial class ContactForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbContact = new GroupBox();
            btnSave = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            lblContactForm = new Label();
            lbContacts = new ListBox();
            gbContact.SuspendLayout();
            SuspendLayout();
            // 
            // gbContact
            // 
            gbContact.AutoSize = true;
            gbContact.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbContact.Controls.Add(btnSave);
            gbContact.Controls.Add(txtEmail);
            gbContact.Controls.Add(lblEmail);
            gbContact.Controls.Add(txtPhone);
            gbContact.Controls.Add(lblPhone);
            gbContact.Controls.Add(txtLastName);
            gbContact.Controls.Add(lblLastName);
            gbContact.Controls.Add(txtFirstName);
            gbContact.Controls.Add(lblFirstName);
            gbContact.Location = new Point(0, 3);
            gbContact.Name = "gbContact";
            gbContact.Size = new Size(482, 214);
            gbContact.TabIndex = 0;
            gbContact.TabStop = false;
            gbContact.Text = "Contact Form";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(376, 159);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(86, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(390, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 129);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(86, 93);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(390, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(12, 96);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone#";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(86, 59);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(390, 27);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(3, 62);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(86, 26);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(390, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(3, 29);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblContactForm
            // 
            lblContactForm.AutoSize = true;
            lblContactForm.Location = new Point(18, 209);
            lblContactForm.Name = "lblContactForm";
            lblContactForm.Size = new Size(0, 20);
            lblContactForm.TabIndex = 1;
            // 
            // lbContacts
            // 
            lbContacts.FormattingEnabled = true;
            lbContacts.Location = new Point(12, 237);
            lbContacts.Name = "lbContacts";
            lbContacts.Size = new Size(458, 204);
            lbContacts.TabIndex = 2;
            lbContacts.Click += lbContacts_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(lbContacts);
            Controls.Add(lblContactForm);
            Controls.Add(gbContact);
            Name = "ContactForm";
            Text = "Contacts";
            Load += ContactForm_Load;
            gbContact.ResumeLayout(false);
            gbContact.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbContact;
        private Label lblContactForm;
        private ListBox lbContacts;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label lblLastName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhone;
        private Label lblPhone;
        private Button btnSave;
    }
}
