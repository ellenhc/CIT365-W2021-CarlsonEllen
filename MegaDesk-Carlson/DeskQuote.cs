using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Carlson
{
    public class DeskQuote
    {
        const double BASE_PRICE = 200;
        const double PRICE_PER_DRAWER = 50;
        const double OAK_PRICE = 200;
        const double LAMINATE_PRICE = 100;
        const double PINE_PRICE = 50;
        const double ROSEWOOD_PRICE = 300;
        const double VENEER_PRICE = 125;

        //Constructor
        private string customerName;
        public string CustomerName{
            get { return customerName; } //get method
        }

        private int rushDays;
        public int RushDays
        {
            get { return rushDays; }
        }

        private Desk Desk;
        private DateTime quoteDate;
        public DateTime QuoteDate
        {
            get { return quoteDate; }
        }

        public DeskQuote(Desk newDesk, string customerName, int rushDays, DateTime quoteDate)
        {
            //to do
            this.customerName = customerName;
            this.Desk = newDesk;
            this.rushDays = rushDays;
            this.quoteDate = quoteDate;
        }

        public int getDeskWidth()
        {
            return Desk.Width;
        }

        public int getDeskDepth()
        {
            return Desk.Depth;
        }

        public int getDeskDrawers()
        {
            return Desk.Drawers;
        }

        public string getDeskMaterial()
        {
            return Desk.SurfaceMaterial.ToString();
        }

        private double getMaterialCost(DesktopMaterial surfaceMaterial)
        {
            switch (surfaceMaterial)
            {
                case DesktopMaterial.Oak:
                    return OAK_PRICE;
                case DesktopMaterial.Laminate:
                    return LAMINATE_PRICE;
                case DesktopMaterial.Pine:
                    return PINE_PRICE;
                case DesktopMaterial.Rosewood:
                    return ROSEWOOD_PRICE;
                case DesktopMaterial.Veneer:
                    return VENEER_PRICE;
                default:
                    return 0;
            }
        }

        private double getRushCost(int rushDays)
        {
            if (Desk.surfaceArea() < 1000)
            {
                switch (rushDays){
                    case 3:
                        return 60;
                    case 5:
                        return 40;
                    case 7:
                        return 30;
                    default:
                        return 0;
                }
            }
            else if (Desk.surfaceArea() > 1000 && Desk.surfaceArea() < 2000)
            {
                switch (rushDays)
                {
                    case 3:
                        return 70;
                    case 5:
                        return 50;
                    case 7:
                        return 35;
                    default:
                        return 0;
                }
            }
            else
            {
                switch (rushDays)
                {
                    case 3:
                        return 80;
                    case 5:
                        return 60;
                    case 7:
                        return 40;
                    default:
                        return 0;
                }
            }
        }


        public double calculateQuote()
        {
            //Set total to base price
            double total = BASE_PRICE;

            //Add the drawer costs to total
            total += Desk.Drawers * PRICE_PER_DRAWER;

            if (Desk.surfaceArea() > 1000) //if area is greater than 1000, we add to the base price
            {
                total += Desk.surfaceArea() * 1; //$1 per square inch
            }

            //surface material
            total += getMaterialCost(Desk.SurfaceMaterial);

            //rush order
            total += getRushCost(rushDays);

            return total;
        }
    }
}
