namespace Achievements
{
    partial class AchievementControl
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
            components = new System.ComponentModel.Container();
            iconAchievementImage = new PictureBox();
            labelTitle = new Label();
            labelDescription = new Label();
            labelDateAchieved = new Label();
            badgeSelect = new ContextMenuStrip(components);
            badge1ToolStripMenuItem = new ToolStripMenuItem();
            badge2ToolStripMenuItem = new ToolStripMenuItem();
            badge3ToolStripMenuItem = new ToolStripMenuItem();
            BadgeSelectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)iconAchievementImage).BeginInit();
            badgeSelect.SuspendLayout();
            SuspendLayout();
            // 
            // iconAchievementImage
            // 
            iconAchievementImage.Location = new Point(0, 0);
            iconAchievementImage.Name = "iconAchievementImage";
            iconAchievementImage.Size = new Size(60, 60);
            iconAchievementImage.SizeMode = PictureBoxSizeMode.StretchImage;
            iconAchievementImage.TabIndex = 0;
            iconAchievementImage.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTitle.Location = new Point(66, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(58, 15);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "labelTitle";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(66, 15);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(92, 15);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "labelDescription";
            // 
            // labelDateAchieved
            // 
            labelDateAchieved.AutoSize = true;
            labelDateAchieved.Location = new Point(66, 30);
            labelDateAchieved.Name = "labelDateAchieved";
            labelDateAchieved.Size = new Size(105, 15);
            labelDateAchieved.TabIndex = 3;
            labelDateAchieved.Text = "labelDateAchieved";
            // 
            // badgeSelect
            // 
            badgeSelect.Items.AddRange(new ToolStripItem[] { badge1ToolStripMenuItem, badge2ToolStripMenuItem, badge3ToolStripMenuItem });
            badgeSelect.Name = "badgeSelect";
            badgeSelect.Size = new Size(218, 92);
            badgeSelect.Opening += badgeSelect_Opening;
            // 
            // badge1ToolStripMenuItem
            // 
            badge1ToolStripMenuItem.Name = "badge1ToolStripMenuItem";
            badge1ToolStripMenuItem.Size = new Size(217, 22);
            badge1ToolStripMenuItem.Text = "Showcase it in Badge Slot 1";
            badge1ToolStripMenuItem.Click += badge1ToolStripMenuItem_Click;
            // 
            // badge2ToolStripMenuItem
            // 
            badge2ToolStripMenuItem.Name = "badge2ToolStripMenuItem";
            badge2ToolStripMenuItem.Size = new Size(217, 22);
            badge2ToolStripMenuItem.Text = "Showcase it in Badge Slot 2";
            badge2ToolStripMenuItem.Click += badge2ToolStripMenuItem_Click;
            // 
            // badge3ToolStripMenuItem
            // 
            badge3ToolStripMenuItem.Name = "badge3ToolStripMenuItem";
            badge3ToolStripMenuItem.Size = new Size(217, 22);
            badge3ToolStripMenuItem.Text = "Showcase it in Badge Slot 3";
            badge3ToolStripMenuItem.Click += badge3ToolStripMenuItem_Click;
            // 
            // BadgeSelectButton
            // 
            BadgeSelectButton.Dock = DockStyle.Right;
            BadgeSelectButton.Location = new Point(372, 0);
            BadgeSelectButton.Name = "BadgeSelectButton";
            BadgeSelectButton.Size = new Size(28, 60);
            BadgeSelectButton.TabIndex = 4;
            BadgeSelectButton.Text = "...\r\n";
            BadgeSelectButton.UseVisualStyleBackColor = true;
            BadgeSelectButton.Click += BadgeSelectButton_Click;
            // 
            // AchievementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BadgeSelectButton);
            Controls.Add(labelDateAchieved);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            Controls.Add(iconAchievementImage);
            Name = "AchievementControl";
            Size = new Size(400, 60);
            ((System.ComponentModel.ISupportInitialize)iconAchievementImage).EndInit();
            badgeSelect.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Label labelDescription;
        private Label labelDateAchieved;
        private PictureBox iconAchievementImage;
        private ContextMenuStrip badgeSelect;
        private ToolStripMenuItem badge1ToolStripMenuItem;
        private ToolStripMenuItem badge2ToolStripMenuItem;
        private ToolStripMenuItem badge3ToolStripMenuItem;
        private Button BadgeSelectButton;
    }
}
