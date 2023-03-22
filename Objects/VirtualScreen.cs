namespace snakegame.Objects;

using Utilities;

public class VirtualScreen
{
    public VirtualScreen(int sizeX, int sizeY, char symbol = ' ')
    {
        _screen = new char[sizeX, sizeY];
        _fill(symbol);
    }

    private readonly char[,] _screen;

    private void _fill(char symbol)
    {
        for (int x = 0; x <= _screen.GetLength(0) - 1; x++)
        {
            for (int y = 0; y <= _screen.GetLength(1) - 1; y++)
            {
                _screen[x, y] = symbol;
            }
        }
    }

    public void Render()
    {
        for(int x = 0; x < _screen.GetLength(0); x++)
        {
            _screen[0, x] = '★';
            _screen[_screen.GetLength(1) - 1, x] = '★';
        }

        for(int y = 0; y < _screen.GetLength(1); y++)
        {
            _screen[y, 0] = '★';
            _screen[y, _screen.GetLength(0) - 1] = '★';
        }

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