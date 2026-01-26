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
            textBox1 = new TextBox();
            label1 = new Label();
            lblContactForm = new Label();
            listBox1 = new ListBox();
            gbContact.SuspendLayout();
            SuspendLayout();
            // 
            // gbContact
            // 
            gbContact.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbContact.Controls.Add(textBox1);
            gbContact.Controls.Add(label1);
            gbContact.Dock = DockStyle.Top;
            gbContact.Location = new Point(0, 0);
            gbContact.Name = "gbContact";
            gbContact.Size = new Size(482, 206);
            gbContact.TabIndex = 0;
            gbContact.TabStop = false;
            gbContact.Text = "Contact Form";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(53, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblContactForm
            // 
            lblContactForm.AutoSize = true;
            lblContactForm.Location = new Point(18, 209);
            lblContactForm.Name = "lblContactForm";
            lblContactForm.Size = new Size(0, 20);
            lblContactForm.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 237);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(458, 204);
            listBox1.TabIndex = 2;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
    }
}
