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

    public const string DIR_UP = "dir up";
    public const string DIR_DOWN = "dir down";
    public const string DIR_LEFT = "dir left";
    public const string DIR_RIGHT = "dir right";

    public string Direction = DIR_DOWN;

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
        Point nextPoint = GetNextPoint(head);

        Validate(nextPoint);
        _body.Add(nextPoint);
        DeleteTail();
    }

    public Point GetNextPoint(Point head)
    { 
        if (Direction == DIR_UP)
        {
            return new Point(head.X, head.Y - 1);
        }
        else if (Direction == DIR_DOWN)
        {
            return new Point(head.X, head.Y + 1);
        }
        else if (Direction == DIR_LEFT)
        {
            return new Point(head.X - 1, head.Y);
        }
        else if (Direction == DIR_RIGHT)
        {
            return new Point(head.X + 1, head.Y);
        }
        
        return new Point(1, 1);
    }

    public void DeleteTail()
    {
       _body.RemoveAt(0); 
    }
    
    public void Validate(Point next)
    {
        Screen.ValidateBorder(next);
        ValidateBody(next);
    }

    public void ValidateBody(Point next)
    {
        foreach (Point item in _body)
        {
            if(item.X == next.X && item.Y == next.Y)
            {
                throw new Exception("The snake crashed into itself \n:(");
            }
        }
    }
}
  