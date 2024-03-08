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
        audioListBox = new ListBox();
        audioNameLabel = new Label();
        audioProgressBar = new ProgressBar();
        previousAudioButton = new Button();
        nextAudioButton = new Button();
        playAudioButton = new Button();
        trackTimer = new System.Windows.Forms.Timer(components);
        trackStartLabel = new Label();
        trackEndLabel = new Label();
        SuspendLayout();
        // 
        // audioListBox
        // 
        audioListBox.BackColor = Color.FromArgb(26, 26, 26);
        audioListBox.ForeColor = SystemColors.Control;
        audioListBox.FormattingEnabled = true;
        audioListBox.Location = new Point(12, 172);
        audioListBox.Name = "audioListBox";
        audioListBox.Size = new Size(325, 324);
        audioListBox.TabIndex = 0;
        audioListBox.SelectedIndexChanged += audioListBox_SelectedIndexChanged;
        // 
        // audioNameLabel
        // 
        audioNameLabel.AutoSize = true;
        audioNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        audioNameLabel.ForeColor = Color.FromArgb(30, 215, 96);
        audioNameLabel.Location = new Point(12, 9);
        audioNameLabel.Name = "audioNameLabel";
        audioNameLabel.Size = new Size(141, 25);
        audioNameLabel.TabIndex = 1;
        audioNameLabel.Text = "Pick an audio...";
        // 
        // audioProgressBar
        // 
        audioProgressBar.BackColor = Color.FromArgb(18, 18, 18);
        audioProgressBar.Location = new Point(12, 156);
        audioProgressBar.Name = "audioProgressBar";
        audioProgressBar.Size = new Size(325, 10);
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
        previousAudioButton.Location = new Point(12, 54);
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
        nextAudioButton.Location = new Point(258, 54);
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
        playAudioButton.Location = new Point(121, 54);
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
        trackStartLabel.Location = new Point(12, 133);
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
        trackEndLabel.Location = new Point(293, 133);
        trackEndLabel.Name = "trackEndLabel";
        trackEndLabel.Size = new Size(45, 20);
        trackEndLabel.TabIndex = 7;
        trackEndLabel.Text = "00:00";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(18, 18, 18);
        ClientSize = new Size(349, 508);
        Controls.Add(trackEndLabel);
        Controls.Add(trackStartLabel);
        Controls.Add(playAudioButton);
        Controls.Add(nextAudioButton);
        Controls.Add(previousAudioButton);
        Controls.Add(audioProgressBar);
        Controls.Add(audioNameLabel);
        Controls.Add(audioListBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "MainForm";
        Text = "NotSpotify";
        Load += MainForm_Load;
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
}
