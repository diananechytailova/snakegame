namespace snakegame;

using Objects;
using System.Threading;

class Program
{
    static void Main()
    {
        VirtualScreen gameScreen = new VirtualScreen(21, 21);
        Snake snake = new Snake(gameScreen);

        try
        {
            while(true)
            {  
                gameScreen.Clear();

                snake.Render();
                gameScreen.Render();
                snake.Move();

                Thread.Sleep(1000);
            }
        }
        catch(Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
}
