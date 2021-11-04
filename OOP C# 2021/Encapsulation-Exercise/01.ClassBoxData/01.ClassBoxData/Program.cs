using System;

namespace _01.ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(lenght,width,height);
                Console.WriteLine(box.GetSurfaceArea(lenght, width, height));
                Console.WriteLine(box.GetLateralSurfaceArea(lenght, width, height));
                Console.WriteLine(box.GetVolume(lenght, width, height));
                
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
