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
    static private readonly string DIR_UP = "dir up";
    static private readonly string DIR_DOWN = "dir down";
    static private readonly string DIR_LEFT = "dir left";
    static private readonly string DIR_RIGHT = "dir right";

    private string _direction = DIR_UP;

    public void Render()
    {
        foreach (Point item in _body)
        {
            if (item.Equals(_body.Last()))
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

        if(_direction == DIR_UP)
        {
            _body.Add(new Point(head.X, head.Y - 1));
        }
        else if(_direction == DIR_DOWN)
        {
            _body.Add(new Point(head.X, head.Y + 1));
        }
        
         else if(_direction == DIR_LEFT)
        {
            _body.Add(new Point(head.X - 1, head.Y));
        }
        
         else if(_direction == DIR_RIGHT)
        {
            _body.Add(new Point(head.X + 1, head.Y));
        }   
    }
}
    