namespace snakegame.Objects;

using Utilities;

public class Apple : Renderable
{
    public Apple(VirtualScreen screen)
        : base(screen)
    {
        Coordinates = _generateCoordinates();
    }

    public Point Coordinates;

    private readonly char _symbol = '0';

    public bool Eaten = false;

    public bool IsEaten(Point coordinates)
    {
        if(Coordinates.X == coordinates.X && Coordinates.Y == coordinates.Y)
        {
            Eaten = true;
        }
        
        return Eaten;
    }


    
    
    public void Render()
    {
        if(!Eaten)
        {
            Screen.SetPoint(Coordinates, _symbol);
        }
    }

    private Point _generateCoordinates()
    {
        Random rand = new Random();
        Point coordinates = new Point(
            rand.Next(1, Screen.SizeX - 2), 
            rand.Next(1, Screen.SizeY - 2)
        );

        while(Screen.GetPoint(coordinates) != ' ')
        {
            coordinates.X = rand.Next(1, Screen.SizeX - 2);
            coordinates.Y = rand.Next(1, Screen.SizeY - 2); 
        }

        return coordinates;
    }

    public void Spawn()
    {
        Coordinates = _generateCoordinates();
        Eaten = false;
    }
}