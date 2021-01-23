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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            AddQuote ButtonAddNew = new AddQuote();
            ButtonAddNew.Tag = this;
            ButtonAddNew.Show(this);
            this.Hide();
        }

        private void ButtonViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ButtonViewAll = new ViewAllQuotes();
            ButtonViewAll.Show(this);
            Hide();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchQuotes ButtonSearchQuotes = new SearchQuotes();
            ButtonSearchQuotes.Show(this);
            Hide();
        }
    }
}
