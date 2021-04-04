namespace Bridge
{
    public abstract class Shape
    {
        protected readonly IRenderer renderer;

        // a bridge between the shape that's being drawn an
        // the component which actually draws it
        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}