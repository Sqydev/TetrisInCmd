class Game {
    public static void game() {
        bool running = true;

        while (running = true) {
            WriteFrame();

            Thread.Sleep(3);
        }
    }

    public static void WriteFrame() {
        Console.Clear();
        Console.WriteLine(Assets.GuiTemple);
    }

    public static void LossBlockGroup() {
        Random random = new Random();
    }
}