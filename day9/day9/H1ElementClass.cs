using System;


namespace day9
{
    public class H1ElementClass : TextElementClass
    {
        public string FontColor { get; set; }
        public int FontSize { get; set; }

        public H1ElementClass(string type, string value, string color, int size)
            : base(type, value, color, size)
        {

        }

        public override void render()
        {
            Console.WriteLine($"{Type} , {Value} , {FontColor} , {FontSize}");
        }
    }


}

