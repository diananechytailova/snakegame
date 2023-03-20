namespace snakegame.Objects;

using Utilities;

public class Snake : Renderable
{
    public Snake(VirtualScreen screen)
        : base(screen)
    {
        //
    }

    private readonly char _symbol = '@';
    private readonly Point[] _body = { new(3, 3), new(3, 4), new(3, 5) };

    public void Render()
    {
        foreach (Point item in _body)
        {
            Screen.SetPoint(item, _symbol);
        }
    }
}