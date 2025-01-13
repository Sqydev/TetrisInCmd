using System;
using System.Media;
using System.Runtime.InteropServices;
using LibVLCSharp.Shared;

public static class Music {

    public static void MusicPlayer() {
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            SoundPlayer gamemusic = new SoundPlayer("Music/Theme.mp3");
            gamemusic.Load();
            gamemusic.PlayLooping();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
            Core.Initialize();
            using var libVLC = new LibVLC();
            using var mediaPlayer = new MediaPlayer(libVLC);
            var media = new Media(libVLC, "/home/sqyd/projekty/C#/TetrisInCmd/Music/Theme.mp3", FromType.FromPath);
            mediaPlayer.Play(media);
            mediaPlayer.EndReached += (sender, e) => mediaPlayer.Play(media);
            Console.ReadLine();
        }
    }
}