using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string FirstName;
    public string LastName;
    public int id;

   
}
public class Student : Person
{
    public float GPA;
    public void PrintInformation()
    {
        Console.WriteLine(FirstName + " " + LastName + " " + id + " " + GPA);
    }
}


    class Program
    {
        public static void Main()
        {
        Student S1 = new Student();
        S1.FirstName = Console.ReadLine();
        S1.LastName = Console.ReadLine();
        S1.id = 1337;
        S1.GPA = float.Parse(Console.ReadLine());
        S1.PrintInformation();
        Console.ReadLine();

        }
    }

