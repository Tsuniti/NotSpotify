using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify;

public class AudioPlayer
{
    private Mp3FileReader _reader;
    private WaveOutEvent _player;
    private string? _currentAudio;

    public bool IsPlaying { get; private set; }

    public AudioPlayer()
    {
        IsPlaying = false;
        _player = new WaveOutEvent();
    }

    public void Play(string audio)
    {
        IsPlaying = true;

        if(_currentAudio  == audio)
        {
            if(_player.PlaybackState != PlaybackState.Playing)
            {
                _player.Play();
            }
        }
        else
        {
            _currentAudio = audio;
            _reader = new Mp3FileReader(_currentAudio);
            _player.Stop();
            _player.Init(_reader);
            _player.Play();
        }
    }

    public void Pause()
    {
        if(_player.PlaybackState == PlaybackState.Playing)
        {
            _player.Pause();
           IsPlaying = false;
        }
    }
}
