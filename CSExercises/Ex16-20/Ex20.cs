using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int TV_discount = 0, TV_realprice=0;
            int DVD_discount = 0, DVD_realprice = 0;
       
            int total_orderprice = 0;
            int total_orderquantity = 0;

            int tv_price = 900;
            int dvd_price = 500;
            int mp3_price = 700;

            System.Console.WriteLine("Hello Customer! \n Please Enter your Quantity for each TV , DVD, MP3:\t");

            System.Console.Write("Enter quantity for TV:\t");
            int TV_quantity=Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter quantity for DVD:\t");
            int DVD_quantity=Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter quantity for MP3:\t");
            int MP3_quantity=Convert.ToInt32(Console.ReadLine());

            int TVtotal_price = tv_price * TV_quantity;
            int DVDtotal_price = dvd_price * DVD_quantity;
            int MP3total_price =  mp3_price * MP3_quantity;

            if (TVtotal_price > 0)
            {
                if (TVtotal_price > 5000 && TVtotal_price <= 10000)
                {
                    TV_discount = (TVtotal_price * 10) / 100;
                    TV_realprice = TVtotal_price - TV_discount;
                    System.Console.WriteLine("\nGet 10% discount for TV :\t " + TV_realprice);
                }
                if (TVtotal_price > 10000)
                {
                    TV_discount = (TVtotal_price * 15) / 100;
                    TV_realprice = TVtotal_price - TV_discount;
                    System.Console.WriteLine("\nGet 15% discount for TV :\t "+TV_realprice);
                }
                if (TVtotal_price < 5000)
                {
                    TV_realprice = TVtotal_price;
                    System.Console.WriteLine("\nNo discount for TV coz total price is less than 5000:\t " + TV_realprice);
                }
            }
            if (DVDtotal_price > 0)
            {
                if (DVDtotal_price > 5000 && DVDtotal_price <= 10000)
                {
                    DVD_discount = (DVDtotal_price * 10) / 100;
                    DVD_realprice =DVDtotal_price - DVD_discount;
                    System.Console.WriteLine("\nGet 10% discount for DVD :\t " + DVD_realprice);
                }
                if (DVDtotal_price > 10000)
                {
                    DVD_discount = (DVDtotal_price * 15) / 100;
                    DVD_realprice =DVDtotal_price - DVD_discount;
                    System.Console.WriteLine("\nGet 15% discount for DVD :\t " + DVD_realprice);
                }
                if (DVDtotal_price < 5000)
                {
                    DVD_realprice = DVDtotal_price;
                    System.Console.WriteLine("\nNo discount for DVD coz total price is less than 5000:\t " + DVD_realprice);
                }
            }
         
            System.Console.WriteLine("\nNo discount for MP3:\t " + MP3total_price);

            total_orderprice = TV_realprice + DVD_realprice + MP3total_price;
            total_orderquantity = TV_quantity + DVD_quantity + MP3_quantity;


            System.Console.Write("\nTotal quantity for this order is \t" + total_orderquantity+"\n");
            System.Console.Write("****************************************************************\n\nTotal price for this order is \t" + total_orderprice + "\n\n");
        }
    }
}