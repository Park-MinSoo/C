namespace MorphemeParserLib
{
    public class Morpheme
    {
        public int RefCount { get; set; }
        public string Name { get; private set; }
        public Morpheme(string name, int rcnt)
        {
            Name = name;
            RefCount = rcnt;
        }
        public void Merge(Morpheme other)
        {
            RefCount += other.RefCount;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}