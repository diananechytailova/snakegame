namespace snakegame;

using Objects;
using System.Threading;

class Program
{
    static void Main()
    {
        VirtualScreen gameScreen = new VirtualScreen(21, 21);
        Apple apple = new Apple(gameScreen);
        Snake snake = new Snake(gameScreen, apple);
        Thread controls = new Thread(() => Controls(snake));

        controls.Start();

        try
        {
            while (true)
            {
                gameScreen.Clear();

                snake.Move();
                snake.Render();
                apple.Render();
                gameScreen.Render();
                Console.WriteLine("x: " + apple.Coordinates.X + " y: " + apple.Coordinates.Y);
                
                Thread.Sleep(500);
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            Environment.Exit(0);
        }
    }

    public static void Controls(Snake snake)
    {
        while (true)
        {
            new Controller(snake).ReadKey();
            Thread.Sleep(1);
        }
    }
}
