namespace RollandKnow
{
    partial class signupandlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupandlogin));
            buttonlogin = new Button();
            buttonsignup1 = new Button();
            textBoxpassword1 = new TextBox();
            textBoxname1 = new TextBox();
            labelname1 = new Label();
            labelpassword1 = new Label();
            SuspendLayout();
            // 
            // buttonlogin
            // 
            buttonlogin.Location = new Point(179, 300);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(94, 29);
            buttonlogin.TabIndex = 0;
            buttonlogin.Text = "login";
            buttonlogin.UseVisualStyleBackColor = true;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // buttonsignup1
            // 
            buttonsignup1.Location = new Point(535, 300);
            buttonsignup1.Name = "buttonsignup1";
            buttonsignup1.Size = new Size(94, 29);
            buttonsignup1.TabIndex = 1;
            buttonsignup1.Text = "signup";
            buttonsignup1.UseVisualStyleBackColor = true;
            buttonsignup1.Click += buttonsignup1_Click;
            // 
            // textBoxpassword1
            // 
            textBoxpassword1.BackColor = Color.Khaki;
            textBoxpassword1.ForeColor = Color.Khaki;
            textBoxpassword1.Location = new Point(331, 236);
            textBoxpassword1.Name = "textBoxpassword1";
            textBoxpassword1.Size = new Size(125, 27);
            textBoxpassword1.TabIndex = 2;
            // 
            // textBoxname1
            // 
            textBoxname1.BackColor = Color.Khaki;
            textBoxname1.BorderStyle = BorderStyle.None;
            textBoxname1.Location = new Point(331, 168);
            textBoxname1.Name = "textBoxname1";
            textBoxname1.Size = new Size(125, 20);
            textBoxname1.TabIndex = 3;
            // 
            // labelname1
            // 
            labelname1.AutoSize = true;
            labelname1.Location = new Point(331, 145);
            labelname1.Name = "labelname1";
            labelname1.Size = new Size(46, 20);
            labelname1.TabIndex = 4;
            labelname1.Text = "name";
            // 
            // labelpassword1
            // 
            labelpassword1.AutoSize = true;
            labelpassword1.Location = new Point(331, 213);
            labelpassword1.Name = "labelpassword1";
            labelpassword1.Size = new Size(72, 20);
            labelpassword1.TabIndex = 5;
            labelpassword1.Text = "password";
            // 
            // signupandlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(labelpassword1);
            Controls.Add(labelname1);
            Controls.Add(textBoxname1);
            Controls.Add(textBoxpassword1);
            Controls.Add(buttonsignup1);
            Controls.Add(buttonlogin);
            DoubleBuffered = true;
            Name = "signupandlogin";
            Text = "signupandlogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonlogin;
        private Button buttonsignup1;
        private TextBox textBoxpassword1;
        private TextBox textBoxname1;
        private Label labelname1;
        private Label labelpassword1;
    }
}