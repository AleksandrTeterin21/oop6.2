using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class classone = new Class();
            classone.Display();
            Class classtwo = new Class("12345578910");
            classtwo.Display();
            Class classthre = new Class("123");
            classthre.Display();
            Console.ReadKey();
        }
    }
}
class Class
{
    private string Metod;

    public Class()
    {
        Metod = "Пусcто";
    }
    public Class(string Line)
    {
        if (Line.Length > 10)
            this.Metod = "Слишком длинная строка";
        else
            this.Metod = Line;
    }
    public void Display()
    {
        Console.WriteLine(Metod);
    }
}
