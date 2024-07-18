using System;
namespace day9
{
    class Program
    {
        static void Main()
        {
            List<HTMLElementClass> list = new List<HTMLElementClass>();
            list.Add(new ImageElementClass("img","photo","https://"));
            list.Add(new TextElementClass("text", "a", "red",21));
            list.Add(new TextElementClass("h1", "b", "blue", 20));
            list.Add(new TextElementClass("h1", "c", "black", 19));

            foreach (var item in list)
            {
                item.render();
            }

        }
    }
}