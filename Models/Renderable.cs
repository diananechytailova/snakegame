namespace Game
{ 
    public class Renderable
    {
        public Renderable(ref VirtualScreen screen)
        {
            this.screen = screen;
        }
        
        public VirtualScreen screen;

        public void render()
        {
            // 
        }
    }
}
  