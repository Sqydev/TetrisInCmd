using System;
using System.Media; //zimportuj

class Program{
    static void Main(){
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(Assets.menuimg);

        SoundPlayer gamemusic = new SoundPlayer("TetrisMusic.wav"); // zweryfikuj czy dobrze napisałeś
        gamemusic.Load();
        gamemusic.PlayLooping();//sprawdz

        Console.ReadKey();
    }
}