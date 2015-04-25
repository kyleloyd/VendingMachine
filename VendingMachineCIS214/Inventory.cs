using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineCIS214
{
    class Inventory
    {
        private int quarters = 40;
        private int dimes = 100;
        private int nickels = 200;

        public static Slot A1 = new Slot(10, "Big Red");
        public static Slot A2 = new Slot(10, "Double Mint");
        public static Slot A3 = new Slot(10, "Fruit Stripe");
        public static Slot A4 = new Slot(10, "Lifesavers");
        public static Slot A5 = new Slot(10, "Juicy Fruit");

        public static Slot B1 = new Slot(10, "Crunch");
        public static Slot B2 = new Slot(10, "Hershey's");
        public static Slot B3 = new Slot(10, "Milky Way");
        public static Slot B4 = new Slot(10, "Snickers");
        public static Slot B5 = new Slot(10, "Three Musketeers");

        public static Slot C1 = new Slot(10, "Fritos");
        public static Slot C2 = new Slot(10, "Doritos: Cool Ranch");
        public static Slot C3 = new Slot(10, "Lays");
        public static Slot C4 = new Slot(10, "Flamin' Hot Cheetos");
        public static Slot C5 = new Slot(10, "Doritos: Nacho Cheese");

        public static Slot D1 = new Slot(10, "Coffee Cake");
        public static Slot D2 = new Slot(10, "Cupcakes");
        public static Slot D3 = new Slot(10, "Fruit Pie");
        public static Slot D4 = new Slot(10, "Honey Bun");
        public static Slot D5 = new Slot(10, "Swiss Cake Roll");
    }
}
