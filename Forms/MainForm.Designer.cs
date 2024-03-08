namespace NotSpotify.MainForm;

partial class MainForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        audioListBox = new ListBox();
        audioNameLabel = new Label();
        audioProgressBar = new ProgressBar();
        previousAudioButton = new Button();
        nextAudioButton = new Button();
        playAudioButton = new Button();
        trackTimer = new System.Windows.Forms.Timer(components);
        trackStartLabel = new Label();
        trackEndLabel = new Label();
        volumeTrackBar = new TrackBar();
        volumeMaxPictureBox = new PictureBox();
        volumeMinPictureBox = new PictureBox();
        autoScrollPanel = new Panel();
        labelAutoScrollTimer = new System.Windows.Forms.Timer(components);
        titleBarPanel = new Panel();
        MinimizeButton = new Button();
        closeButton = new Button();
        ((System.ComponentModel.ISupportInitialize)volumeTrackBar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)volumeMaxPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)volumeMinPictureBox).BeginInit();
        autoScrollPanel.SuspendLayout();
        titleBarPanel.SuspendLayout();
        SuspendLayout();
        // 
        // audioListBox
        // 
        audioListBox.BackColor = Color.FromArgb(26, 26, 26);
        audioListBox.ForeColor = SystemColors.Control;
        audioListBox.FormattingEnabled = true;
        audioListBox.Location = new Point(12, 200);
        audioListBox.Name = "audioListBox";
        audioListBox.Size = new Size(338, 324);
        audioListBox.TabIndex = 0;
        audioListBox.SelectedIndexChanged += audioListBox_SelectedIndexChanged;
        // 
        // audioNameLabel
        // 
        audioNameLabel.AutoSize = true;
        audioNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        audioNameLabel.ForeColor = Color.FromArgb(30, 215, 96);
        audioNameLabel.Location = new Point(0, 0);
        audioNameLabel.Name = "audioNameLabel";
        audioNameLabel.Size = new Size(141, 25);
        audioNameLabel.TabIndex = 1;
        audioNameLabel.Text = "Pick an audio...";
        // 
        // audioProgressBar
        // 
        audioProgressBar.BackColor = Color.FromArgb(18, 18, 18);
        audioProgressBar.Location = new Point(12, 184);
        audioProgressBar.Name = "audioProgressBar";
        audioProgressBar.Size = new Size(338, 10);
        audioProgressBar.Style = ProgressBarStyle.Continuous;
        audioProgressBar.TabIndex = 2;
        audioProgressBar.MouseDown += audioProgressBar_MouseDown;
        // 
        // previousAudioButton
        // 
        previousAudioButton.BackColor = Color.FromArgb(64, 64, 64);
        previousAudioButton.FlatAppearance.BorderColor = Color.Black;
        previousAudioButton.FlatAppearance.BorderSize = 0;
        previousAudioButton.FlatAppearance.MouseOverBackColor = Color.Gray;
        previousAudioButton.FlatStyle = FlatStyle.Flat;
        previousAudioButton.Image = Properties.Resources.previous_button;
        previousAudioButton.Location = new Point(12, 82);
        previousAudioButton.Name = "previousAudioButton";
        previousAudioButton.RightToLeft = RightToLeft.No;
        previousAudioButton.Size = new Size(79, 60);
        previousAudioButton.TabIndex = 3;
        previousAudioButton.UseVisualStyleBackColor = false;
        previousAudioButton.Click += previousAudioButton_Click;
        // 
        // nextAudioButton
        // 
        nextAudioButton.BackColor = Color.FromArgb(64, 64, 64);
        nextAudioButton.FlatAppearance.BorderColor = Color.Black;
        nextAudioButton.FlatAppearance.BorderSize = 0;
        nextAudioButton.FlatAppearance.MouseOverBackColor = Color.Gray;
        nextAudioButton.FlatStyle = FlatStyle.Flat;
        nextAudioButton.Image = Properties.Resources.next_button;
        nextAudioButton.Location = new Point(204, 82);
        nextAudioButton.Name = "nextAudioButton";
        nextAudioButton.Size = new Size(79, 60);
        nextAudioButton.TabIndex = 4;
        nextAudioButton.UseVisualStyleBackColor = false;
        nextAudioButton.Click += nextAudioButton_Click;
        // 
        // playAudioButton
        // 
        playAudioButton.BackColor = Color.FromArgb(64, 64, 64);
        playAudioButton.FlatAppearance.BorderColor = Color.Black;
        playAudioButton.FlatAppearance.BorderSize = 0;
        playAudioButton.FlatAppearance.MouseOverBackColor = Color.Gray;
        playAudioButton.FlatStyle = FlatStyle.Flat;
        playAudioButton.Image = Properties.Resources.play_and_pause_button;
        playAudioButton.Location = new Point(97, 82);
        playAudioButton.Name = "playAudioButton";
        playAudioButton.Size = new Size(101, 60);
        playAudioButton.TabIndex = 5;
        playAudioButton.UseVisualStyleBackColor = false;
        playAudioButton.Click += playAudioButton_Click;
        // 
        // trackTimer
        // 
        trackTimer.Enabled = true;
        trackTimer.Tick += trackTimer_Tick;
        // 
        // trackStartLabel
        // 
        trackStartLabel.AutoSize = true;
        trackStartLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        trackStartLabel.ForeColor = Color.FromArgb(83, 83, 83);
        trackStartLabel.Location = new Point(12, 161);
        trackStartLabel.Name = "trackStartLabel";
        trackStartLabel.Size = new Size(45, 20);
        trackStartLabel.TabIndex = 6;
        trackStartLabel.Text = "00:00";
        // 
        // trackEndLabel
        // 
        trackEndLabel.AutoSize = true;
        trackEndLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        trackEndLabel.ForeColor = Color.FromArgb(83, 83, 83);
        trackEndLabel.Location = new Point(305, 161);
        trackEndLabel.Name = "trackEndLabel";
        trackEndLabel.Size = new Size(45, 20);
        trackEndLabel.TabIndex = 7;
        trackEndLabel.Text = "00:00";
        // 
        // volumeTrackBar
        // 
        volumeTrackBar.Location = new Point(294, 40);
        volumeTrackBar.Maximum = 100;
        volumeTrackBar.Name = "volumeTrackBar";
        volumeTrackBar.Orientation = Orientation.Vertical;
        volumeTrackBar.Size = new Size(56, 102);
        volumeTrackBar.TabIndex = 8;
        volumeTrackBar.Scroll += volumeTrackBar_Scroll;
        // 
        // volumeMaxPictureBox
        // 
        volumeMaxPictureBox.Image = Properties.Resources.volume;
        volumeMaxPictureBox.Location = new Point(326, 40);
        volumeMaxPictureBox.Name = "volumeMaxPictureBox";
        volumeMaxPictureBox.Size = new Size(24, 24);
        volumeMaxPictureBox.TabIndex = 9;
        volumeMaxPictureBox.TabStop = false;
        // 
        // volumeMinPictureBox
        // 
        volumeMinPictureBox.Image = Properties.Resources.mute;
        volumeMinPictureBox.Location = new Point(326, 118);
        volumeMinPictureBox.Name = "volumeMinPictureBox";
        volumeMinPictureBox.Size = new Size(24, 24);
        volumeMinPictureBox.TabIndex = 10;
        volumeMinPictureBox.TabStop = false;
        // 
        // autoScrollPanel
        // 
        autoScrollPanel.Controls.Add(audioNameLabel);
        autoScrollPanel.Location = new Point(12, 40);
        autoScrollPanel.Name = "autoScrollPanel";
        autoScrollPanel.Size = new Size(271, 36);
        autoScrollPanel.TabIndex = 11;
        // 
        // labelAutoScrollTimer
        // 
        labelAutoScrollTimer.Interval = 50;
        labelAutoScrollTimer.Tick += labelAutoScrollTimer_Tick;
        // 
        // titleBarPanel
        // 
        titleBarPanel.BackColor = Color.FromArgb(9, 9, 9);
        titleBarPanel.Controls.Add(MinimizeButton);
        titleBarPanel.Controls.Add(closeButton);
        titleBarPanel.Dock = DockStyle.Top;
        titleBarPanel.Location = new Point(0, 0);
        titleBarPanel.Name = "titleBarPanel";
        titleBarPanel.Size = new Size(362, 34);
        titleBarPanel.TabIndex = 12;
        titleBarPanel.MouseDown += titleBarPanel_MouseDown;
        // 
        // MinimizeButton
        // 
        MinimizeButton.BackColor = Color.FromArgb(9, 9, 9);
        MinimizeButton.FlatAppearance.BorderSize = 0;
        MinimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 58, 58);
        MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
        MinimizeButton.FlatStyle = FlatStyle.Flat;
        MinimizeButton.ForeColor = Color.White;
        MinimizeButton.Image = (Image)resources.GetObject("MinimizeButton.Image");
        MinimizeButton.Location = new Point(248, 0);
        MinimizeButton.Name = "MinimizeButton";
        MinimizeButton.Size = new Size(57, 33);
        MinimizeButton.TabIndex = 1;
        MinimizeButton.UseVisualStyleBackColor = false;
        MinimizeButton.Click += MinimizeButton_Click;
        // 
        // closeButton
        // 
        closeButton.BackColor = Color.FromArgb(9, 9, 9);
        closeButton.FlatAppearance.BorderSize = 0;
        closeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 19, 32);
        closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 26, 43);
        closeButton.FlatStyle = FlatStyle.Flat;
        closeButton.ForeColor = Color.White;
        closeButton.Image = (Image)resources.GetObject("closeButton.Image");
        closeButton.Location = new Point(305, 0);
        closeButton.Name = "closeButton";
        closeButton.Size = new Size(57, 33);
        closeButton.TabIndex = 0;
        closeButton.UseVisualStyleBackColor = false;
        closeButton.Click += closeButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(18, 18, 18);
        BackgroundImageLayout = ImageLayout.Center;
        ClientSize = new Size(362, 537);
        Controls.Add(titleBarPanel);
        Controls.Add(autoScrollPanel);
        Controls.Add(volumeMinPictureBox);
        Controls.Add(volumeMaxPictureBox);
        Controls.Add(volumeTrackBar);
        Controls.Add(trackEndLabel);
        Controls.Add(trackStartLabel);
        Controls.Add(playAudioButton);
        Controls.Add(nextAudioButton);
        Controls.Add(previousAudioButton);
        Controls.Add(audioProgressBar);
        Controls.Add(audioListBox);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MainForm";
        Text = "NotSpotify";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)volumeTrackBar).EndInit();
        ((System.ComponentModel.ISupportInitialize)volumeMaxPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)volumeMinPictureBox).EndInit();
        autoScrollPanel.ResumeLayout(false);
        autoScrollPanel.PerformLayout();
        titleBarPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox audioListBox;
    private Label audioNameLabel;
    private ProgressBar audioProgressBar;
    private Button previousAudioButton;
    private Button nextAudioButton;
    private Button playAudioButton;
    private System.Windows.Forms.Timer trackTimer;
    private Label trackStartLabel;
    private Label trackEndLabel;
    private TrackBar volumeTrackBar;
    private PictureBox volumeMaxPictureBox;
    private PictureBox volumeMinPictureBox;
    private Panel autoScrollPanel;
    private System.Windows.Forms.Timer labelAutoScrollTimer;
    private Panel titleBarPanel;
    private Button closeButton;
    private Button MinimizeButton;
}
