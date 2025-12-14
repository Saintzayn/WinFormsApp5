namespace RollandKnow
{
    partial class signup
    {
     
        private System.ComponentModel.IContainer components = null;

        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            buttonsignup = new Button();
            buttoncancel = new Button();
            labelname = new Label();
            labelpassword = new Label();
            textBoxname = new TextBox();
            textBoxpassword = new TextBox();
            SuspendLayout();
            // 
            // buttonsignup
            // 
            buttonsignup.Location = new Point(128, 299);
            buttonsignup.Name = "buttonsignup";
            buttonsignup.Size = new Size(94, 29);
            buttonsignup.TabIndex = 0;
            buttonsignup.Text = "signup";
            buttonsignup.UseVisualStyleBackColor = true;
            buttonsignup.Click += buttonsignup_Click;
            // 
            // buttoncancel
            // 
            buttoncancel.Location = new Point(439, 313);
            buttoncancel.Name = "buttoncancel";
            buttoncancel.Size = new Size(94, 29);
            buttoncancel.TabIndex = 1;
            buttoncancel.Text = "cancel";
            buttoncancel.UseVisualStyleBackColor = true;
            buttoncancel.Click += buttoncancel_Click_1;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(261, 138);
            labelname.Name = "labelname";
            labelname.Size = new Size(46, 20);
            labelname.TabIndex = 2;
            labelname.Text = "name";
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.Location = new Point(261, 233);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(72, 20);
            labelpassword.TabIndex = 3;
            labelpassword.Text = "password";
            // 
            // textBoxname
            // 
            textBoxname.BackColor = Color.Khaki;
            textBoxname.Location = new Point(261, 161);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(125, 27);
            textBoxname.TabIndex = 4;
            // 
            // textBoxpassword
            // 
            textBoxpassword.BackColor = Color.Khaki;
            textBoxpassword.Location = new Point(261, 256);
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.Size = new Size(125, 27);
            textBoxpassword.TabIndex = 5;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxpassword);
            Controls.Add(textBoxname);
            Controls.Add(labelpassword);
            Controls.Add(labelname);
            Controls.Add(buttoncancel);
            Controls.Add(buttonsignup);
            DoubleBuffered = true;
            Name = "signup";
            Text = "signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonsignup;
        private Button buttoncancel;
        private Label labelname;
        private Label labelpassword;
        private TextBox textBoxname;
        private TextBox textBoxpassword;
    }
}