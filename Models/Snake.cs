using Utilities;

namespace Game 
{
    public class Snake : Renderable
    {
        public Snake(ref VirtualScreen screen) 
            : base(ref screen)
        {
        
        }

        private char symbol = '@';
        private Point[] body = {new Point(3, 3), new Point(3, 4), new Point(3, 5)};
        public new void render()
        {
            foreach(Point item in this.body){
                base.screen.setPoint(item, this.symbol);
            }
        }
    }
}