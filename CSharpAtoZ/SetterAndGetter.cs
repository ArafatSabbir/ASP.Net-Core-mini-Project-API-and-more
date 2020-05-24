using System;

namespace CSharpAtoZ
{
    class SetterAndGetter
    {
        static void Main(string[] args)
        {
            var obj = new Book("Hello World!", 33, 10);

            Console.WriteLine($"Book Ratting is {obj.Ratting}");
            
        }


    }

    class Book
    {
        public string name;
        public int id;
        private double ratting;

        public Book(string cName, int cId, double cRatting)
        {
            name = cName;
            id = cId;
            Ratting = cRatting;  
        }

        public double Ratting
        {
            get { return ratting; }

            set { 
                if(value <= 5 && value >= 0)
                {
                    ratting = value;
                }
                else
                {
                    ratting = -1;
                }
            
            
            }
        }


    }
}


//Sample output

//Student name is Sabbir








