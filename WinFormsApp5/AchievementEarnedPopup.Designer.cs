namespace Achievements
{
    partial class AchievementEarnedPopup
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
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            labelDescription = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(55, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "labelTitle";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(0, 15);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(92, 15);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "labelDescription\r\n";
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            // 
            // AchievementEarnedPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 51);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AchievementEarnedPopup";
            Text = "AchievementEarnedPopup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelDescription;
        private System.Windows.Forms.Timer timer1;
    }
}