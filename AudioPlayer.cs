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
    public int timeDuration { get; private set; }

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
            timeDuration = (int) _reader.TotalTime.TotalSeconds;
            _player.Stop();
            _player.Init(_reader);
            _player.Play();
        }
    }

    public void Pause()
    {
        if (_player.PlaybackState == PlaybackState.Playing)
        {
            _player.Pause();
            IsPlaying = false;
        }
        else if (_player.PlaybackState == PlaybackState.Stopped) _player.Play();
    }
    public int GetCurrentTime() => (int)_reader.CurrentTime.TotalSeconds;

    public void SetCurrentTime(int newCurrentTime)
    {
        if (_currentAudio != null)
        {
            _reader.CurrentTime = TimeSpan.FromSeconds(newCurrentTime);
        }
    }

    public float GetVolume() => _player.Volume;
    public void SetVolume(int newVolume) => _player.Volume = (float)newVolume / 100;
}
