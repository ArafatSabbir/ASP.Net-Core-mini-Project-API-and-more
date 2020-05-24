using System;

namespace CSharpAtoZ
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            var worldR = new Restaurant();
            var banglaR = new BangladeshiRestaurant();

            worldR.MakeHotDrinks();
            worldR.MakeMainDish();
            worldR.BillPay();

            banglaR.MakeHotDrinks();
            banglaR.MakeMainDish();
            banglaR.BillPay();



        }


    }

   class Restaurant
    {
        public virtual void  MakeHotDrinks()
        {
            Console.WriteLine("Coffee");
        }

        public virtual void MakeMainDish()
        {
            Console.WriteLine("Burger");
        }

        public void BillPay()
        {
            Console.WriteLine("Bill Paid");
        }



    }

    class BangladeshiRestaurant : Restaurant
    {
        public override void MakeHotDrinks()
        {
            Console.WriteLine("Tea");
        }

        public override void MakeMainDish()
        {
            Console.WriteLine("Rice and Fish");
        }


    }
}

//Sample output

//Coffee
//Burger
//Bill Paid
//Tea
//Rice and Fish
//Bill Paid