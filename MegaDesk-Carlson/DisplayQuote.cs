using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            //Console.WriteLine(quote.ToString());
            double price = new_quote.calculateQuote();
            CustomerName.Text = new_quote.CustomerName;
            deskWidth.Text = new_quote.getDeskWidth().ToString();
            deskDepth.Text = new_quote.getDeskDepth().ToString();
            deskDrawers.Text = new_quote.getDeskDrawers().ToString();
            deskMaterial.Text = new_quote.getDeskMaterial();
            orderDate.Text = new_quote.QuoteDate.ToString();
            rushOrder.Text = new_quote.RushDays.ToString();
            totalQuote.Text = price.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
