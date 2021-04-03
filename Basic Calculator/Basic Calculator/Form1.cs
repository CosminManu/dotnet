using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// a basic calculator
        /// </summary>

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        #region Clearing func 

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event argument</param>
        /// 
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Clear();     // <=> " "
            this.UserInputText.Focus();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var selecST = this.UserInputText.SelectionStart;
            
            if((this.UserInputText.SelectionStart != 0) && (this.UserInputText.SelectionStart <= this.UserInputText.TextLength))
            {
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart -1, 1);
                this.UserInputText.SelectionStart = selecST - 1;
            }

            this.UserInputText.SelectionLength = 0;
            this.UserInputText.Focus();
        }
        #endregion


        #region Operator Methods
        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
            CalculateEquation();
        }

        #endregion


        #region Num Func

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void EightButoon_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue((sender as Button).Text);        
        }
        #endregion


        #region Private methods helpers
        /// <summary>
        /// Focuses the user input text
        /// </summary>
        /*private void FocusInputText()
        {
            this.UserInputText.Focus();     implementare la fiecare(o linie cod)
        }*/

        /// <summary>
        /// Inserts the input txt into the user input txt
        /// </summary>
        /// <param name="value"></param>
        private void InsertTextValue(string value)
        {
            //se retine pozitia cursorului
            var selecSt = this.UserInputText.SelectionStart;

            //inserezi param de la pozit cursorului
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            //muta cursorul de la pozit init + lungime param introdus 
            this.UserInputText.SelectionStart = selecSt + value.Length;

            //deselecteaza (afis doar cursorul)
            this.UserInputText.SelectionLength = 0;

            //Focuses the user input text
            this.UserInputText.Focus();
        }
            
        /// <summary>
        /// Calculates the given input  
        /// and outputs result
        /// </summary>
        private void CalculateEquation()
        {
            this.CalculationResultTest.Text = ParseOperation();
            this.UserInputText.Focus();
        }


        /// <summary>
        /// Preia input de la user si calculeaza ecuatia
        /// </summary>  DE TERMINAT
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                //get the users input
                string input = this.UserInputText.Text;

                //remove all spaces
                input = input.Replace(" ", "");

                //create a new operation(add, multiply etc)
                Operation op = new Operation();

                return string.Empty;
            }
            catch(Exception e)
            {
                return $"Invalid equation. {e.Message}";
            }
        }

        #endregion


    }
}
