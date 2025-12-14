using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace Achievements
{
    public partial class AchievementEarnedPopup : Form
    {
        private readonly Timer _displayTimer;
        private readonly Timer _fadeTimer;
        private bool _fadingOut;
        private const int DisplayMilliseconds = 3000;
        private const int FadeInterval = 40;
        private const double FadeStep = 0.08;

        private readonly Label _titleLabel;
        private readonly Label _descLabel;

        public AchievementEarnedPopup(string title, string desc)
        {
            // Form basics
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            BackColor = Color.FromArgb(34, 34, 34);
            Opacity = 0;
            Padding = new Padding(8);

            // Title label
            _titleLabel = new Label
            {
                Text = title,
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 22,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.Gold,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Description label
            _descLabel = new Label
            {
                Text = desc,
                AutoSize = false,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Container panel
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = BackColor,
            };

            panel.Controls.Add(_descLabel);
            panel.Controls.Add(_titleLabel);
            Controls.Add(panel);

            // Determine size based on text (simple measurement)
            using (var g = CreateGraphics())
            {
                var titleSize = g.MeasureString(title, _titleLabel.Font, 320);
                var descSize = g.MeasureString(desc, _descLabel.Font, 320);
                Width = Math.Clamp(320, 200, 420);
                Height = (int)Math.Ceiling(titleSize.Height + descSize.Height) + Padding.Vertical + 12;
                Height = Math.Clamp(Height, 60, 140);
            }

            // Timers
            _displayTimer = new Timer { Interval = DisplayMilliseconds };
            _displayTimer.Tick += (s, e) =>
            {
                _displayTimer.Stop();
                StartFadeOut();
            };

            _fadeTimer = new Timer { Interval = FadeInterval };
            _fadeTimer.Tick += (s, e) =>
            {
                if (!_fadingOut)
                {
                    Opacity = Math.Min(1.0, Opacity + FadeStep);
                    if (Opacity >= 1.0)
                    {
                        _fadeTimer.Stop();
                        _displayTimer.Start();
                    }
                }
                else
                {
                    Opacity = Math.Max(0.0, Opacity - FadeStep);
                    if (Opacity <= 0.0)
                    {
                        _fadeTimer.Stop();
                        Close();
                    }
                }
            };

            // Close on click
            Click += (s, e) => StartFadeOut();
            _titleLabel.Click += (s, e) => StartFadeOut();
            _descLabel.Click += (s, e) => StartFadeOut();
        }

        private void StartFadeOut()
        {
            if (_fadingOut) return;
            _fadingOut = true;
            // ensure fade timer is running
            if (!_fadeTimer.Enabled) _fadeTimer.Start();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _fadingOut = false;
            _fadeTimer.Start(); // fade in
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _displayTimer?.Stop();
            _fadeTimer?.Stop();
            _displayTimer?.Dispose();
            _fadeTimer?.Dispose();
            base.OnFormClosed(e);
        }

        // Prevent stealing focus
        protected override bool ShowWithoutActivation => true;

        // Also add WS_EX_NOACTIVATE to CreateParams as a fallback
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_NOACTIVATE = 0x08000000;
                const int WS_EX_TOOLWINDOW = 0x00000080;
                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW;
                return cp;
            }
        }

        /// <summary>
        /// Create and show the popup bottom-left of the owner's working area.
        /// </summary>
        public static void ShowPopup(Form owner, string title, string desc)
        {
            var popup = new AchievementEarnedPopup(title, desc);

            const int margin = 12;

            // If the owner exists and is visible, position relative to the owner's window (bottom-left)
            if (owner != null && owner.Visible)
            {
                // owner.PointToScreen converts owner's client (0,0) to screen coordinates
                Point ownerScreenTopLeft = owner.PointToScreen(Point.Empty);
                int x = ownerScreenTopLeft.X + margin;
                int y = ownerScreenTopLeft.Y + owner.Height - popup.Height - margin;

                // ensure the popup stays inside working area of the screen that contains the owner
                Rectangle workArea = Screen.FromControl(owner).WorkingArea;
                x = Math.Max(workArea.Left + margin, Math.Min(x, workArea.Right - popup.Width - margin));
                y = Math.Max(workArea.Top + margin, Math.Min(y, workArea.Bottom - popup.Height - margin));

                popup.Location = new Point(x, y);
                popup.Show(owner);
                return;
            }

            // Fallback: bottom-left of the primary screen working area
            Rectangle primaryWork = Screen.PrimaryScreen.WorkingArea;
            popup.Location = new Point(primaryWork.Left + margin, primaryWork.Bottom - popup.Height - margin);
            popup.Show();
        }
    }
}
