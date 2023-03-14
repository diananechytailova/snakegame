namespace Game 
{
    public class VirtualScreen 
    {
        public VirtualScreen(int height, int width, char symbol = ' ')
        {
            this.screen = new char[height, width];
            this.fill(symbol);
        }   

        private char[,] screen;

        public void fill(char symbol)
        {
            for(int height = 0; height <= this.screen.GetLength(0)-1; height++){
                for (int width = 0; width <= this.screen.GetLength(1)-1; width++){
                    this.screen[height, width] = symbol;
                }
            }
        }
        
        public void render()
        {
            for(int height = 0; height <= this.screen.GetLength(0)-1; height++){
                for (int width = 0; width <= this.screen.GetLength(1)-1; width++){
                    Console.Write(this.screen[height, width]);
                } 
                Console.Write("\n");
            }
        }
        
        public char[,] getScreen() 
        {
            return this.screen;
        }
    }
}
