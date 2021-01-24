using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Carlson
{
    public class DeskQuote
    {
        //Constructor
        private string customerName;
        private Desk Desk;
        public DeskQuote(Desk newDesk, string customerName, int rushDays, DateTime quoteDate)
        {
            //to do
            this.customerName = customerName;
            this.Desk = newDesk;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public int GetDeskDepth()
        {
            return Desk.GetDeskDepth();
        }

        public int GetDeskWidth()
        {
            return Desk.GetDeskWidth();
        }
    }
}
