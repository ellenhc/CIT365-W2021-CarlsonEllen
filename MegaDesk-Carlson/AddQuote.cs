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
    public partial class AddQuote : Form
    {
        const int WIDTH_MIN = 24;
        const int WIDTH_MAX = 96;
        const int DEPTH_MIN = 12;
        const int DEPTH_MAX = 48;
        const int DRAWER_MIN = 0;
        const int DRAWER_MAX = 7;

        int[] days = { 3, 5, 7, 14 };

        ErrorProvider errorProvider = new System.Windows.Forms.ErrorProvider();

        public AddQuote()
        {
            InitializeComponent();
            //Populates the surface material combobox
            surfaceMaterials.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            //Populates the rush order combobox
            rushOrder.DataSource = days;
            //Sets datetimepicker to today
            quoteDate.Value = DateTime.Today;
        }

        private void Width_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            try
            {
                int width = int.Parse(deskWidth.Text);
                //Else if input is a number:
                if (!(width >= WIDTH_MIN && width <= WIDTH_MAX))
                {
                    errorMsg = "Width must be between " + WIDTH_MIN + " inches and " + WIDTH_MAX + " inches.";
                }
                else
                {
                    deskWidth.BackColor = SystemColors.Window;
                    errorProvider.Dispose(); //Removes the error provider when input is valid
                }
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                errorMsg = "Width must be a number.";
            }
            if (errorMsg.Length > 0)
            {
                e.Cancel = true; //Not completely sure what this does
                deskWidth.Text = String.Empty; //Empties the bad value
                errorProvider.SetError(deskWidth, errorMsg); //Shows error sign that flashes
            }
        }

        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            string errorMsg = "";
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && !Char.IsControl(ch))
            {
                errorMsg = "Please enter a number between 12 and 48.";
                e.Handled = true;
            }
        }

        private void ButtonSaveQuote_Click(object sender, EventArgs e)
        {
            try
            {
                int width = int.Parse(deskWidth.Text);
                int depth = int.Parse(deskDepth.Text);
                int drawers = int.Parse(numDrawers.Text);
                int rushDays = int.Parse(rushOrder.Text);
                DesktopMaterial surface;
                Enum.TryParse<DesktopMaterial>(surfaceMaterials.SelectedValue.ToString(), out surface);
                //Saves quote info into a new DeskQuote object
                Desk newDesk = new Desk(width, depth, drawers, surface);
                DeskQuote newQuote = new DeskQuote(newDesk, customerName.Text, rushDays, quoteDate.Value);
                DisplayQuote DisplayQuoteView = new DisplayQuote(newQuote);
                DisplayQuoteView.Show(this);
                Hide();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Depth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            try
            {
                int depth = int.Parse(deskDepth.Text);
                //Else if input is a number:
                if (!(depth >= DEPTH_MIN && depth <= DEPTH_MAX))
                {
                    errorMsg = "Depth must be between " + DEPTH_MIN + " inches and " + DEPTH_MAX + " inches.";
                }
                else
                {
                    deskDepth.BackColor = SystemColors.Window;
                    errorProvider.Dispose(); //Removes the error provider when input is valid
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                errorMsg = "Depth must be a number.";
            }
            if (errorMsg.Length > 0)
            {
                e.Cancel = true; //Not completely sure what this does
                deskDepth.Text = String.Empty; //Empties the bad value
                errorProvider.SetError(deskDepth, errorMsg); //Shows error sign that flashes
            }
        }

        private void numDrawers_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            try
            {
                int numOfDrawers = int.Parse(numDrawers.Text);
                //Else if input is a number:
                if (!(numOfDrawers >= DRAWER_MIN && numOfDrawers <= DRAWER_MAX))
                {
                    errorMsg = "Can only have " + DRAWER_MIN + " to " + DRAWER_MAX + " drawers.";
                }
                else
                {
                    numDrawers.BackColor = SystemColors.Window;
                    errorProvider.Dispose(); //Removes the error provider when input is valid
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                errorMsg = "Number of drawers must be a number.";
            }
            if (errorMsg.Length > 0)
            {
                e.Cancel = true; //Not completely sure what this does
                numDrawers.Text = String.Empty; //Empties the bad value
                errorProvider.SetError(numDrawers, errorMsg); //Shows error sign that flashes
            }
        }
    }
}
