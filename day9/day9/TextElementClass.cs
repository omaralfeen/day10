using System;


namespace day9
{
    public class TextElementClass : HTMLElementClass
    {
        public string FontColor { get; set; }
        public int FontSize { get; set; }

        public TextElementClass(string type, string value, string color, int size)
            : base(type, value) 
        {
            FontColor = color;
            FontSize = size;
        }

        public override void render()
        {
            Console.WriteLine($"{Type} , {Value} , {FontColor} , {FontSize}");
        }
    }
}

