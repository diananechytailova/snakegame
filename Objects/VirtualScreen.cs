namespace snakegame.Objects;

using Utilities;

public class VirtualScreen
{
    public VirtualScreen(int height, int width, char symbol = ' ')
    {
        _screen = new char[height, width];
        _fill(symbol);
    }

    private readonly char[,] _screen;

    private void _fill(char symbol)
    {
        for (int height = 0; height <= _screen.GetLength(0) - 1; height++)
        {
            for (int width = 0; width <= _screen.GetLength(1) - 1; width++)
            {
                _screen[height, width] = symbol;
            }
        }
    }

    public void Render()
    {
        for (int x = 0; x <= _screen.GetLength(0) - 1; x++)
        {
            for (int y = 0; y <= _screen.GetLength(1) - 1; y++)
            {
                Console.Write(_screen[y, x] + " ");
            }

            Console.Write("\n");
        }
    }

    public void Clear()
    {
        _fill(' ');
        Console.Clear();
    }

    public void SetPoint(Point coords, char symbol)
    {
        _screen[coords.X - 1, coords.Y - 1] = symbol;
    }
}