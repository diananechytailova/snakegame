namespace snakegame;

using Objects;
using System.Threading;

class Program
{
    static void Main()
    {
        VirtualScreen gameScreen = new VirtualScreen(21, 21);
        Snake snake = new Snake(gameScreen);

        while(true)
        {   
            gameScreen.Clear();
            snake.Move();
            snake.Render();
            gameScreen.Render();

            Thread.Sleep(1000);
        }
    }
}