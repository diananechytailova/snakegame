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
        for (int height = 0; height <= _screen.GetLength(0) - 1; height++)
        {
            for (int width = 0; width <= _screen.GetLength(1) - 1; width++)
            {
                Console.Write(_screen[height, width] + " ");
            }

            Console.Write("\n");
        }
    }

    public void SetPoint(Point coords, char symbol)
    {
        _screen[coords.Y, coords.X] = symbol;
    }
}