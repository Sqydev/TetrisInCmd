class Program{
    static void Main(){
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(Assets.menuimg);

        Music.MusicPlayer();

        Console.ReadKey();

        Game.game();
    }
}