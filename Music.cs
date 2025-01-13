using System;
using System.Media;
using System.Runtime.InteropServices;
using LibVLCSharp.Shared;

public static class Music {

    public static void MusicPlayer() {
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            SoundPlayer gamemusic = new SoundPlayer("Music/Theme.wav");
            gamemusic.Load();
            gamemusic.PlayLooping();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
            Core.Initialize();
            using (var libVLC = new LibVLC())
            using (var mediaPlayer = new MediaPlayer(libVLC)) {
                var media = new Media(libVLC, "Music/Theme.wav", FromType.FromLocation);
                mediaPlayer.Play(media);
            }
        }
    }
}