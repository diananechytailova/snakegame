namespace snakegame.Objects;

public class Controller
{
    public Controller(Snake snake)
    {
        _snake = snake;
    }

    private Snake _snake;

    public void ReadKey()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.RightArrow && _snake.Direction != Snake.DIR_LEFT) 
            {
                _snake.Direction = Snake.DIR_RIGHT;
            }
            else if (key == ConsoleKey.LeftArrow && _snake.Direction != Snake.DIR_RIGHT)
            {
                _snake.Direction = Snake.DIR_LEFT;
            }
            else if (key == ConsoleKey.UpArrow && _snake.Direction != Snake.DIR_DOWN)
            {
                _snake.Direction = Snake.DIR_UP;
            }
            else if (key == ConsoleKey.DownArrow && _snake.Direction != Snake.DIR_UP)
            {
                _snake.Direction = Snake.DIR_DOWN;
            }
        }
    }
}