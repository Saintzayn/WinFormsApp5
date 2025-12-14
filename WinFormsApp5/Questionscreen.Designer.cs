using System.Windows.Forms;
using System.Xml.Linq;
// using static System.Windows.Forms.VisualStyles.VisualStyleElement; // <-- Bu satırı kaldırın veya yorum satırı yapın// using static System.Windows.Forms.VisualStyles.VisualStyleElement; // <-- Bu satırı kaldırın veya yorum satırı yapın      
//using static System.Net.Mime.MediaTypeNames;

namespace RollandKnow
{
    partial class Questionscreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questionscreen));
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            richTextBoxSorumetni = new RichTextBox();
            pictureBox50joker = new PictureBox();
            pictureBoxquestionchangejoker = new PictureBox();
            pictureBoxspectatorjoker = new PictureBox();
            labelpoint = new Label();
            labelcheckpointpoint = new Label();
            buttonwithdraw = new Button();
            RollDice = new Button();
            labeldifficulty = new Label();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            labelD = new Label();
            labelApercent = new Label();
            labelBpercent = new Label();
            labelCpercent = new Label();
            labelDpercent = new Label();
            progressBarA = new ProgressBar();
            progressBarB = new ProgressBar();
            progressBarC = new ProgressBar();
            progressBarD = new ProgressBar();
            rollingdicetimer = new System.Windows.Forms.Timer(components);
            pictureBoxdice = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox50joker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxquestionchangejoker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxspectatorjoker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxdice).BeginInit();
            SuspendLayout();
            // 
            // buttonA
            // 
            buttonA.BackColor = Color.Khaki;
            buttonA.Location = new Point(247, 613);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(200, 29);
            buttonA.TabIndex = 0;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = false;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.BackColor = Color.Khaki;
            buttonB.Location = new Point(554, 613);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(206, 29);
            buttonB.TabIndex = 1;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = false;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.Khaki;
            buttonC.Location = new Point(247, 686);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(200, 29);
            buttonC.TabIndex = 2;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.BackColor = Color.Khaki;
            buttonD.Location = new Point(554, 686);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(206, 29);
            buttonD.TabIndex = 3;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = false;
            buttonD.Click += buttonD_Click;
            // 
            // richTextBoxSorumetni
            // 
            richTextBoxSorumetni.BackColor = SystemColors.InactiveCaptionText;
            richTextBoxSorumetni.ForeColor = SystemColors.ControlLightLight;
            richTextBoxSorumetni.Location = new Point(151, 504);
            richTextBoxSorumetni.Name = "richTextBoxSorumetni";
            richTextBoxSorumetni.Size = new Size(668, 76);
            richTextBoxSorumetni.TabIndex = 4;
            richTextBoxSorumetni.Text = "";
            richTextBoxSorumetni.TextChanged += richTextBoxSorumetni_TextChanged;
            // 
            // pictureBox50joker
            // 
            pictureBox50joker.BackColor = SystemColors.ControlText;
            pictureBox50joker.BackgroundImage = (Image)resources.GetObject("pictureBox50joker.BackgroundImage");
            pictureBox50joker.Location = new Point(810, 364);
            pictureBox50joker.Name = "pictureBox50joker";
            pictureBox50joker.Size = new Size(108, 104);
            pictureBox50joker.TabIndex = 5;
            pictureBox50joker.TabStop = false;
            pictureBox50joker.Click += pictureBox50joker_Click;
            pictureBox50joker.MouseEnter += pictureBox1_MouseEnter;
            pictureBox50joker.MouseLeave += pictureBox1_MouseLeave;
            // 
            // pictureBoxquestionchangejoker
            // 
            pictureBoxquestionchangejoker.BackColor = SystemColors.Desktop;
            pictureBoxquestionchangejoker.BackgroundImage = (Image)resources.GetObject("pictureBoxquestionchangejoker.BackgroundImage");
            pictureBoxquestionchangejoker.BackgroundImageLayout = ImageLayout.None;
            pictureBoxquestionchangejoker.Location = new Point(810, 236);
            pictureBoxquestionchangejoker.Name = "pictureBoxquestionchangejoker";
            pictureBoxquestionchangejoker.Size = new Size(108, 107);
            pictureBoxquestionchangejoker.TabIndex = 6;
            pictureBoxquestionchangejoker.TabStop = false;
            pictureBoxquestionchangejoker.Click += pictureBoxquestionchangejoker_Click;
            pictureBoxquestionchangejoker.MouseEnter += pictureBox2_MouseEnter;
            pictureBoxquestionchangejoker.MouseLeave += pictureBox2_MouseLeave;
            // 
            // pictureBoxspectatorjoker
            // 
            pictureBoxspectatorjoker.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxspectatorjoker.BackgroundImage = (Image)resources.GetObject("pictureBoxspectatorjoker.BackgroundImage");
            pictureBoxspectatorjoker.Location = new Point(810, 107);
            pictureBoxspectatorjoker.Name = "pictureBoxspectatorjoker";
            pictureBoxspectatorjoker.Size = new Size(108, 110);
            pictureBoxspectatorjoker.TabIndex = 7;
            pictureBoxspectatorjoker.TabStop = false;
            pictureBoxspectatorjoker.Click += pictureBoxspectatorjoker_Click;
            pictureBoxspectatorjoker.MouseEnter += pictureBox3_MouseEnter;
            pictureBoxspectatorjoker.MouseLeave += pictureBox3_MouseLeave;
            // 
            // labelpoint
            // 
            labelpoint.AutoSize = true;
            labelpoint.BackColor = SystemColors.Desktop;
            labelpoint.ForeColor = SystemColors.ControlLightLight;
            labelpoint.Location = new Point(27, 33);
            labelpoint.Name = "labelpoint";
            labelpoint.Size = new Size(42, 20);
            labelpoint.TabIndex = 8;
            labelpoint.Text = "Point";
            labelpoint.Click += labelpoint_Click;
            // 
            // labelcheckpointpoint
            // 
            labelcheckpointpoint.AutoSize = true;
            labelcheckpointpoint.BackColor = SystemColors.Desktop;
            labelcheckpointpoint.ForeColor = SystemColors.ControlLightLight;
            labelcheckpointpoint.Location = new Point(207, 33);
            labelcheckpointpoint.Name = "labelcheckpointpoint";
            labelcheckpointpoint.Size = new Size(120, 20);
            labelcheckpointpoint.TabIndex = 9;
            labelcheckpointpoint.Text = "Checkpoint Point";
            labelcheckpointpoint.Click += labelcheckpointpoint_Click;
            // 
            // buttonwithdraw
            // 
            buttonwithdraw.BackColor = Color.White;
            buttonwithdraw.Location = new Point(843, 686);
            buttonwithdraw.Name = "buttonwithdraw";
            buttonwithdraw.Size = new Size(94, 29);
            buttonwithdraw.TabIndex = 10;
            buttonwithdraw.Text = "Withdraw";
            buttonwithdraw.UseVisualStyleBackColor = false;
            buttonwithdraw.Click += buttonwithdraw_Click;
            // 
            // RollDice
            // 
            RollDice.BackColor = SystemColors.ControlLightLight;
            RollDice.ForeColor = SystemColors.ActiveCaptionText;
            RollDice.Location = new Point(36, 251);
            RollDice.Name = "RollDice";
            RollDice.Size = new Size(94, 29);
            RollDice.TabIndex = 12;
            RollDice.Text = "Roll Dice";
            RollDice.UseVisualStyleBackColor = false;
            RollDice.Click += RollDice_Click;
            // 
            // labeldifficulty
            // 
            labeldifficulty.AutoSize = true;
            labeldifficulty.BackColor = SystemColors.Desktop;
            labeldifficulty.ForeColor = SystemColors.ControlLightLight;
            labeldifficulty.Location = new Point(47, 314);
            labeldifficulty.Name = "labeldifficulty";
            labeldifficulty.Size = new Size(69, 20);
            labeldifficulty.TabIndex = 13;
            labeldifficulty.Text = "Difficulty";
            labeldifficulty.Click += labeldifficulty_Click;
            // 
            // labelA
            // 
            labelA.BackColor = Color.Gold;
            labelA.Location = new Point(230, 250);
            labelA.Name = "labelA";
            labelA.Size = new Size(206, 49);
            labelA.TabIndex = 19;
            labelA.Text = "A";
            labelA.TextAlign = ContentAlignment.MiddleCenter;
            labelA.Visible = false;
            // 
            // labelB
            // 
            labelB.BackColor = Color.Gold;
            labelB.Location = new Point(230, 305);
            labelB.Name = "labelB";
            labelB.Size = new Size(206, 51);
            labelB.TabIndex = 20;
            labelB.Text = "B";
            labelB.TextAlign = ContentAlignment.MiddleCenter;
            labelB.Visible = false;
            // 
            // labelC
            // 
            labelC.BackColor = Color.Gold;
            labelC.Location = new Point(230, 363);
            labelC.Name = "labelC";
            labelC.Size = new Size(206, 54);
            labelC.TabIndex = 21;
            labelC.Text = "C";
            labelC.TextAlign = ContentAlignment.MiddleCenter;
            labelC.Visible = false;
            // 
            // labelD
            // 
            labelD.BackColor = Color.Gold;
            labelD.Location = new Point(230, 423);
            labelD.Name = "labelD";
            labelD.Size = new Size(206, 51);
            labelD.TabIndex = 22;
            labelD.Text = "D";
            labelD.TextAlign = ContentAlignment.MiddleCenter;
            labelD.Visible = false;
            // 
            // labelApercent
            // 
            labelApercent.BackColor = Color.Khaki;
            labelApercent.Location = new Point(467, 250);
            labelApercent.Name = "labelApercent";
            labelApercent.Size = new Size(58, 49);
            labelApercent.TabIndex = 23;
            labelApercent.Text = "labelApercent";
            labelApercent.TextAlign = ContentAlignment.MiddleCenter;
            labelApercent.Visible = false;
            // 
            // labelBpercent
            // 
            labelBpercent.BackColor = Color.Khaki;
            labelBpercent.Location = new Point(467, 307);
            labelBpercent.Name = "labelBpercent";
            labelBpercent.Size = new Size(58, 51);
            labelBpercent.TabIndex = 24;
            labelBpercent.Text = "labelBpercent";
            labelBpercent.TextAlign = ContentAlignment.MiddleCenter;
            labelBpercent.Visible = false;
            // 
            // labelCpercent
            // 
            labelCpercent.BackColor = Color.Khaki;
            labelCpercent.Location = new Point(467, 364);
            labelCpercent.Name = "labelCpercent";
            labelCpercent.Size = new Size(58, 54);
            labelCpercent.TabIndex = 25;
            labelCpercent.Text = "labelCpercent";
            labelCpercent.TextAlign = ContentAlignment.MiddleCenter;
            labelCpercent.Visible = false;
            // 
            // labelDpercent
            // 
            labelDpercent.BackColor = Color.Khaki;
            labelDpercent.Location = new Point(467, 423);
            labelDpercent.Name = "labelDpercent";
            labelDpercent.Size = new Size(58, 51);
            labelDpercent.TabIndex = 26;
            labelDpercent.Text = "labelDpercent";
            labelDpercent.TextAlign = ContentAlignment.MiddleCenter;
            labelDpercent.Visible = false;
            // 
            // progressBarA
            // 
            progressBarA.BackColor = Color.FromArgb(255, 255, 128);
            progressBarA.Location = new Point(531, 250);
            progressBarA.Name = "progressBarA";
            progressBarA.Size = new Size(206, 49);
            progressBarA.TabIndex = 15;
            progressBarA.Visible = false;
            // 
            // progressBarB
            // 
            progressBarB.BackColor = Color.FromArgb(255, 255, 128);
            progressBarB.Location = new Point(531, 305);
            progressBarB.Name = "progressBarB";
            progressBarB.Size = new Size(206, 51);
            progressBarB.TabIndex = 16;
            progressBarB.Visible = false;
            // 
            // progressBarC
            // 
            progressBarC.BackColor = Color.FromArgb(255, 255, 128);
            progressBarC.Location = new Point(531, 363);
            progressBarC.Name = "progressBarC";
            progressBarC.Size = new Size(206, 54);
            progressBarC.TabIndex = 17;
            progressBarC.Visible = false;
            // 
            // progressBarD
            // 
            progressBarD.BackColor = Color.FromArgb(255, 255, 128);
            progressBarD.ForeColor = Color.FromArgb(255, 255, 128);
            progressBarD.Location = new Point(531, 423);
            progressBarD.Name = "progressBarD";
            progressBarD.Size = new Size(206, 51);
            progressBarD.TabIndex = 18;
            progressBarD.Visible = false;
            // 
            // rollingdicetimer
            // 
            rollingdicetimer.Tick += rollingdicetimer_Tick;
            // 
            // pictureBoxdice
            // 
            pictureBoxdice.Image = Image.FromFile("jokerler/rollthedice.jpg");
            pictureBoxdice.Location = new Point(366, 251);
            pictureBoxdice.Name = "pictureBoxdice";
            pictureBoxdice.Size = new Size(238, 223);
            pictureBoxdice.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxdice.TabIndex = 14;
            pictureBoxdice.TabStop = false;
            // 
            // Questionscreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 775);
            Controls.Add(progressBarD);
            Controls.Add(progressBarC);
            Controls.Add(progressBarB);
            Controls.Add(progressBarA);
            Controls.Add(labelDpercent);
            Controls.Add(labelCpercent);
            Controls.Add(labelBpercent);
            Controls.Add(labelApercent);
            Controls.Add(labelD);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(pictureBoxspectatorjoker);
            Controls.Add(pictureBoxquestionchangejoker);
            Controls.Add(pictureBox50joker);
            Controls.Add(labeldifficulty);
            Controls.Add(RollDice);
            Controls.Add(buttonwithdraw);
            Controls.Add(labelcheckpointpoint);
            Controls.Add(labelpoint);
            Controls.Add(richTextBoxSorumetni);
            Controls.Add(buttonD);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Controls.Add(pictureBoxdice);
            DoubleBuffered = true;
            Name = "Questionscreen";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox50joker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxquestionchangejoker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxspectatorjoker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxdice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
        private RichTextBox richTextBoxSorumetni;
        private PictureBox pictureBox50joker;
        private PictureBox pictureBoxquestionchangejoker;
        private PictureBox pictureBoxspectatorjoker;
        private Label labelpoint;
        private Label labelcheckpointpoint;
        private Button buttonwithdraw;
        private Button RollDice;
        private Label labeldifficulty;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label labelD;
        private Label labelApercent;
        private Label labelBpercent;
        private Label labelCpercent;
        private Label labelDpercent;
        private ProgressBar progressBarA;
        private ProgressBar progressBarB;
        private ProgressBar progressBarC;
        private ProgressBar progressBarD;
        private System.Windows.Forms.Timer rollingdicetimer;
        private PictureBox pictureBoxdice;
    }
}