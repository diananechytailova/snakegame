namespace snakegame 
{
    public class VirtualScreen 
    {
        public VirtualScreen(int height, int width, char symbol)
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

        public char[,] getScreen() 
        {
            return this.screen;
        }
    }
}
