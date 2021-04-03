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

        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Clear();     // <=> " "
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Operator Methods
        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            //InsertTextValue("=");
            CalculateEquation();
        }

        #endregion


        #region Num Func
        private void DotButton_Click(object sender, EventArgs e)
        {

        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

        }

        private void EightButoon_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

        }
        #endregion

        #region Private methods helpers
        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the input txt into the user input txt
        /// </summary>
        /// <param name="value"></param>
        private void InsertTextValue(string value)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);
        }

        /// <summary>
        /// Calculates the given input  
        /// and outputs result
        /// </summary>
        private void CalculateEquation()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
