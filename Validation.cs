using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Validation for New Client Form
/// </summary>
namespace WindowsFormsApp1
{
    class Validation
    {
        public static void IsAlpha(KeyPressEventArgs e)
        {
            string strToCheck = Convert.ToString(e.KeyChar);
            Regex ObjAlphaPattern = new Regex("^[a-zA-z]|[\b]|[ \t ]|[.]");
            if (!ObjAlphaPattern.IsMatch(strToCheck))
            {

                MessageBox.Show("Please enter only Alphabets");
                e.Handled = true;

            }

        }
        /*****************************(EMAIL VALIDATION)*****************/

        public static void IsEmailId(KeyPressEventArgs e)
        {
            string strToCheck = Convert.ToString(e.KeyChar);
            Regex ObjAlphaPattern = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!ObjAlphaPattern.IsMatch(strToCheck))
            {

                MessageBox.Show("Invalid Email Id");
                e.Handled = true;

            }
        }


        public static void IsInteger(KeyPressEventArgs e)
        {
            string strToCheck = Convert.ToString(e.KeyChar);
            Regex ObjIntPattern = new Regex("^[0-9]|[\b]|[ \t]|[+]");
            if (!ObjIntPattern.IsMatch(strToCheck))
            {

                MessageBox.Show("Please enter only number");
                e.Handled = true;

            }
        }

        public static void IsProductName(KeyPressEventArgs e)
        {
            string strToCheck = Convert.ToString(e.KeyChar);
            Regex ObjAlphaPattern = new Regex("^[a-zA-z0-9]|[\b]|[ \t]|[()]|[-]");
            if (!ObjAlphaPattern.IsMatch(strToCheck))
            {

                MessageBox.Show("Please write in correct format");
                e.Handled = true;

            }
        }



        public static void IsAlphaNumeric(KeyPressEventArgs e)
        {
            string strToCheck = Convert.ToString(e.KeyChar);
            Regex ObjAlphaPattern = new Regex("^[a-zA-z0-9]|[\b]|[ \t]");
            if (!ObjAlphaPattern.IsMatch(strToCheck))
            {

                MessageBox.Show("Please write in correct format");
                e.Handled = true;

            }
        }



        public static void IsQuantity(KeyPressEventArgs e)
        {
            string strToCheck = Convert.ToString(e.KeyChar);
            Regex ObjAlphaPattern = new Regex("^[0-9]|[.]|[\b]");
            if (!ObjAlphaPattern.IsMatch(strToCheck))
            {

                MessageBox.Show("Please write in correct format");
                e.Handled = true;

            }
        }

    }
    
}
