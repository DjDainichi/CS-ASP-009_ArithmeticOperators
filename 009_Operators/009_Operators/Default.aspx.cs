using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _009_Operators
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int i = 1;
            int j = 2;

            //int result = i + j;
            //int result = i - j;
            //int result = i * j;
            //int result = i / j;

           // i = i + 1; // 
           // i += 1; // shorthand for previous operation
           // i++; // increment by 1
           // i--; // decrement by 1

            // basic order of operations () * / + -
            // int myInteger = 5 + 1 * 7; // => output: 12
            // int myInteger = (5 + 1)*7; // => output: 42
            // resultLabel.Text = myInteger.ToString();

            // double myDouble = 5.5;
            // int myInteger = 7;
            // int myOtherInteger = 4;


            //double myResult = myDouble + myInteger; // => output: 12.5 (Implicit Cast)
            //int myResult = (int)myDouble + myInteger; // => output: 12 (Explicit Cast)

           // int myResult = myInteger / myOtherInteger; // => output: 1 (Truncated)
           // double myResult = (double)myInteger / (double)myOtherInteger; // => output: 1.75 (Upcast)
           // resultLabel.Text = myResult.ToString();  

            // int firstNumber = 2000000000; 
            // int secondNumber = 2000000000;
            // int result = firstNumber * secondNumber; // => output: -1651507200

            // resultLabel.Text = result.ToString(); // causing an int to 'OVERFLOW'

            int firstNumber = 2000000000;
            int secondNumber = 2000000000;

            long resultNumber; // declared outside checked scope

            checked 
            {
                resultNumber = firstNumber*secondNumber;
            }

            resultLabel.Text = resultNumber.ToString(); // exposes an overflow exception
        }
    }
}