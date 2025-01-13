using System;
using System.Media;
using System.Runtime.InteropServices;

class Program{
    static void Main(){
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(Assets.menuimg);

        Music.MusicPlayer();

        Console.ReadKey();
    }
}