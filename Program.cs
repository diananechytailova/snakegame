namespace snakegame;

using Objects;

class Program
{
    static void Main()
    {
        VirtualScreen gameScreen = new VirtualScreen(21, 21);
        Snake snake = new Snake(gameScreen);

        snake.Render();
        gameScreen.Render();
    }
}