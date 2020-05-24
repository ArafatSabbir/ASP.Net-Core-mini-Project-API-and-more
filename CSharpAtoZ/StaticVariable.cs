using System;

namespace CSharpAtoZ
{
    class StaticVariable
    {
        static void Main(string[] args)
        {
            var obj = new Song("Hello World!", 33, 5);

            Console.WriteLine($"Song Count is {Song.songCount}");


            var obj2 = new Song("Goodbye World!", 55, 3.1);

            Console.WriteLine($"Song Count is {Song.songCount}");

        }


    }

    class Song
    {
        public string name;
        public int duration;
        private double ratting;
        public static int songCount = 0;

        public Song(string cName, int cDuration, double cRatting)
        {
            name = cName;
            duration = cDuration;
            Ratting = cRatting;
            songCount++;
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








