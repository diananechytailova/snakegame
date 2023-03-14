namespace Game 
{
    class Program
    {    
        static void Main()
        {
            VirtualScreen gameScreen = new VirtualScreen(25, 80, ' ');
            gameScreen.render();
        } 
    }
}
