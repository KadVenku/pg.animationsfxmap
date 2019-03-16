namespace pg.animationsfxmap.enums
{
    public class SurfaceFxTrigger
    {
        public string Name { get; }
        public int Id { get; }
        internal SurfaceFxTrigger(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}