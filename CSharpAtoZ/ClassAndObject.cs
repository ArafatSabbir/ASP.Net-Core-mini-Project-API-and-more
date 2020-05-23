using System;

namespace CSharpAtoZ
{
    class ClassAndObject
    {
        static void Main(string[] args)
        {
            var object1 = new Student();

            object1.name = "Sabbir";
            object1.id = 1;
            object1.IsHappy = true;

            Console.WriteLine($"Student name is {object1.name}");
            

        }


    }

    class Student
    {
        public string name;
        public int id;
        public bool IsHappy;

    }
}


//Sample output

//Student name is Sabbir








