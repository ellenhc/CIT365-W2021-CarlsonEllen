using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Carlson
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote quote;
        public DisplayQuote(DeskQuote new_quote)
        {
            InitializeComponent();
            quote = new_quote;
            Console.WriteLine(quote.ToString());
            //double price = new_quote.CalculateQuote();
            CustomerName.Text = new_quote.GetCustomerName();
            deskWidth.Text = new_quote.GetDeskWidth().ToString();
            deskDepth.Text = new_quote.GetDeskDepth().ToString();
        }
    }
}
