using System;
using System.Collections.Generic;
using System.Linq;


namespace day9
{
    public class HTMLElementClass
    {

        public string Type { get; set; }
        public string Value { get; set; }
        public HTMLElementClass(string value, string type) 
        {
            Type = type;
            Value = value;
        }
        public  virtual void render()
        {
            Console.WriteLine($"{Type}- {Value}");
        }
 


        

    }
}
