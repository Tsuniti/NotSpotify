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
}
