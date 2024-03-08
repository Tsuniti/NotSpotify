namespace NotSpotify.MainForm;

public partial class MainForm : Form
{
    private string _folderPath = "Audio/";
    private string _selectedAudioName = string.Empty;
    private AudioPlayer _audioPlayer;
    public MainForm()
    {

        _audioPlayer = new AudioPlayer();

        InitializeComponent();


    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        FillAudioListBox();
    }

    private void audioListBox_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (audioListBox.SelectedItem is null) return;

        _selectedAudioName = audioListBox.SelectedItem.ToString();
        audioNameLabel.Text = _folderPath + _selectedAudioName;

        _audioPlayer.Play(_folderPath + _selectedAudioName);

    }
    private void FillAudioListBox()
    {
        //var audioFileNames = Directory.GetFiles(_folderPath).Select(audio => audio.Split("/")[^1]).ToArray();
        var audioFileNames = Directory.GetFiles(_folderPath);

        foreach (var audioFile in audioFileNames)
        {
            int lastSlashIndex = audioFile.LastIndexOf('/');
            string shortFileName = audioFile.Substring(lastSlashIndex + 1, audioFile.Length - lastSlashIndex - 1);
            audioListBox.Items.Add(shortFileName);

        }

    }

    private void playAudioButton_Click(object sender, EventArgs e)
    {
        if (_selectedAudioName == String.Empty) return;

        if (_audioPlayer.IsPlaying) _audioPlayer.Pause();
        else _audioPlayer.Play(_folderPath + _selectedAudioName);
    }

    private void nextAudioButton_Click(object sender, EventArgs e)
    {
        if (audioListBox.SelectedIndex < audioListBox.Items.Count - 1)
        {
            audioListBox.SelectedIndex++;
        }
    }

    private void previousAudioButton_Click(object sender, EventArgs e)
    {
        if (audioListBox.SelectedIndex > 0)
        {
            audioListBox.SelectedIndex--;
        }
    }

    private void trackTimer_Tick(object sender, EventArgs e)
    {
        if (_audioPlayer.IsPlaying)
        {
            audioProgressBar.Maximum = _audioPlayer.timeDuration;
            audioProgressBar.Value = _audioPlayer.GetCurrentTime();
            int currentTime = _audioPlayer.GetCurrentTime();

            try
            {
                int currentMinutes = audioProgressBar.Value / 60;
                int currentSeconds = audioProgressBar.Value - (currentMinutes * 60);
                trackStartLabel.Text = $"{currentMinutes}:{currentSeconds}";

                int maxMinutes = audioProgressBar.Maximum / 60;
                int maxSeconds = audioProgressBar.Maximum - (maxMinutes * 60);
                trackEndLabel.Text = $"{maxMinutes}:{maxSeconds}";
            }
            catch
            {

            }
        }
    }

    private void audioProgressBar_MouseDown(object sender, MouseEventArgs e)
    {
        _audioPlayer.SetCurrentTime(audioProgressBar.Maximum * e.X / audioProgressBar.Width);
    }
}
