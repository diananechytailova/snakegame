namespace snakegame.Objects;

using Utilities;
using System.Collections.Generic;

public class Snake : Renderable
{
    public Snake(VirtualScreen screen)
        : base(screen)
    {
        //

    }

    private readonly char _symbol = '*';

    private readonly List<Point> _body = new List<Point>()
    {
        new(3, 3),
        new(3, 4),
        new(3, 5),
    };

    private const string DIR_UP = "dir up";
    private const string DIR_DOWN = "dir down";
    private const string DIR_LEFT = "dir left";
    private const string DIR_RIGHT = "dir right";

    private string _direction = DIR_DOWN;

    public void Render()
    {
        foreach (Point item in _body)
        {
            if(item.Equals(_body.Last()))
            {
                Screen.SetPoint(item, '@');
            }
            else
            {
                Screen.SetPoint(item, _symbol);
            }
        }
    }

    public void Move()
    {
        Point head = _body.Last();
        
        _body.Add(GetNextPoint(head));
        DeleteTail();
    }

    public Point GetNextPoint(Point head)
    { 
        if (_direction == DIR_UP)
        {
            return new Point(head.X, head.Y - 1);
        }
        else if (_direction == DIR_DOWN)
        {
            return new Point(head.X, head.Y + 1);
        }
        else if (_direction == DIR_LEFT)
        {
            return new Point(head.X - 1, head.Y);
        }
        else if (_direction == DIR_RIGHT)
        {
            return new Point(head.X + 1, head.Y);
        }
        
        return new Point(1, 1);
    }

    public void DeleteTail()
    {
       _body.RemoveAt(0); 
    }
}
    