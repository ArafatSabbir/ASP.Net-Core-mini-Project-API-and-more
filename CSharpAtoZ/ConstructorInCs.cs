using System;

namespace CSharpAtoZ
{
    class ConstructorInCs
    {
        static void Main(string[] args)
        {
            var object1 = new Customer("Sabbir Ahmed", 33, true);

            Console.WriteLine($"Customer name is {object1.name}");
            
        }


    }

    class Customer
    {
        public string name;
        public int id;
        public bool IsHappy;

        public Customer(string cName, int cId, bool cIsHappy)
        {
            name = cName;
            id = cId;
            IsHappy = cIsHappy;  
        }


    }
}


//Sample output

//Student name is Sabbir








