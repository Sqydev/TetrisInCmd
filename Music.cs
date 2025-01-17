using System.Media;
using System.Runtime.InteropServices;
using LibVLCSharp.Shared;

public static class Music {

    public static void MusicPlayer() {
        string musicPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Music", "Theme.mp3");

        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            SoundPlayer gamemusic = new SoundPlayer(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Music", "Theme.wav"));
            gamemusic.Load();
            gamemusic.PlayLooping();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
            Core.Initialize();
            using var libVLC = new LibVLC();
            var mediaPlayer = new MediaPlayer(libVLC);
            var media = new Media(libVLC, musicPath, FromType.FromPath);
            mediaPlayer.Play(media);
            mediaPlayer.EndReached += (sender, e) => {
                mediaPlayer.Stop();
                mediaPlayer.Play(media);
            };
        }
    }
}