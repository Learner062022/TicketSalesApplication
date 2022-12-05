using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaAssessment2
{
    public partial class frm_ticket_sales_application : Form
    {
        public frm_ticket_sales_application()
        {
            InitializeComponent();
        }

        const double ADULT_TICKET = 50.00D, CHILD_TICKET = 30.50D;
        double dbl_ticket_cost = 0, dbl_amount_from_customer = 0, dbl_customer_change = 0;
        uint uint_number_adult_tickets = 0, uint_number_child_tickets = 0;

        private void btn_calculate_change_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_amount_from_customer.Text, out dbl_amount_from_customer))
            {
                MessageBox.Show("Enter a positive number");
                txt_amount_from_customer.Clear();
                txt_amount_from_customer.Focus();
            }

            else if (double.TryParse(txt_amount_from_customer.Text, out dbl_amount_from_customer))
            {
                if (dbl_amount_from_customer < dbl_ticket_cost)
                {
                    MessageBox.Show("The amount cannot be less than ticket cost");
                    txt_amount_from_customer.Clear();
                    txt_amount_from_customer.Focus();
                }
                else
                {
                    dbl_customer_change = dbl_amount_from_customer - dbl_ticket_cost;
                    txt_customer_change.Text = dbl_customer_change.ToString("C");
                    txt_amount_from_customer.Text = dbl_amount_from_customer.ToString("C");
                }
            }

        }

        private void btn_calculate_ticket_cost_Click(object sender, EventArgs e)
        {
            if (!uint.TryParse(txt_number_child_tickets.Text, out uint_number_child_tickets))
            {
                MessageBox.Show("Enter a positive number"); 
                txt_number_child_tickets.Focus();
            }

            else if (!uint.TryParse(txt_number_adult_tickets.Text, out uint_number_adult_tickets))
            {
                MessageBox.Show("Enter a positive number");
                txt_number_adult_tickets.Focus();
            }
            
            else
            {
                dbl_ticket_cost = ((ADULT_TICKET * uint_number_adult_tickets) + (CHILD_TICKET * uint_number_child_tickets));
                txt_number_adult_tickets.Text = uint_number_adult_tickets.ToString();
                txt_number_child_tickets.Text = uint_number_child_tickets.ToString();
                txt_ticket_cost.Text = dbl_ticket_cost.ToString("C");
            }
        }
    }
}
