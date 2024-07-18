using System;

namespace day9
{
    public class ImageElementClass : HTMLElementClass
    {
        public string Source { get; set; }

        public ImageElementClass(string type, string value, string source)
            : base(type, value)
        {
            Source = source;
        }

        public override void render()
        {
            Console.WriteLine($"image:source,{Source}");
        }
    }
}