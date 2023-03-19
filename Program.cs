namespace Game 
{
    class Program
    {    
        static void Main()
        {
            VirtualScreen gameScreen = new VirtualScreen(21, 21, ' ');
            Snake snake = new Snake(ref gameScreen);

            gameScreen.render();
            snake.render();
        } 
    }
}
