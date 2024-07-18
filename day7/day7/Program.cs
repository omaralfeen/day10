using System;
namespace day7{
    class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine(" enter number person");
            int i = int.Parse(Console.ReadLine());
           
            string[] ar1={ "omar","ali","ahmed","oka","sayed"};
            int[] ar2 = {20,21,22,23,24};


            for (; i<ar1.Length;i++)
            {
                Console.WriteLine(ar1[i]);
                Console.WriteLine(ar2[i]);

            }
            */
            //----------

            Console.WriteLine("enter array");
            string input = (Console.ReadLine());

            var names = input.Split(",");
            int[] arr = new int[names.Length];
           
            for (int i = 0; i < names.Length; i++)
            {
                int res = 1;
                for (int j = 0; j < names.Length; j++)
                {
                    if (i != j)
                    {
                        res = res *int.Parse(names[j]);

                    }
                    arr[i]= res;

                }
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
          





        }

    }
}
