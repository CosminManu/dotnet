using System;
using System.Linq;
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
        /// Clears the user input text from right to left
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
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart-1, 1);
                this.UserInputText.SelectionStart = selecST - 1;
            }

            this.UserInputText.SelectionLength = 0;
            this.UserInputText.Focus();
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
            InsertTextValue("=");
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
        /// Preia input de la user si imparte ecuatia pe bucati
        /// </summary>  DE TERMINAT
        /// <returns></returns>
        private string ParseOperation()
        {
            //AddNumberPart("4.4", '.');   te arunca in throw new InvalidOperationException
            //era o exceptie netratata (nu avea cine sa o prinda cu catch(Rxcetion e))

            OperationType tip = new OperationType();
            Operation op = new Operation();

            try
            {
                //get the users input from keyboard
                string input = this.UserInputText.Text;

                //remove all spaces
                input = input.Replace(" ", "");

                //create a new operation (add, multiply etc)
                bool st = true;

                // Handle order priority
                // 4 + 5 * 2
                // 5 * 2 intai, apoi 4 + 
                //--------
                //5 * 2 + 4
                for (int i = 0; i < input.Length; i++)
                {
                    //verif daca el curent este o cifra sau punct
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (st)
                            op.LeftSide = AddNumberPart(op.LeftSide, input[i]);
                        else
                            op.RightSide = AddNumberPart(op.RightSide, input[i]);
                    }
                    //daca nu e o cifra, verif daca e operator si seteaza
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        //sunt pe partea dreapta, det tipul de operatie
                        //si setez rezultatul
                        if (!st)
                        {
                            //get the op type
                            tip = GetOperationType(input[i]);

                            //verif daca nu am nr pe partea dreapta
                            if (op.RightSide.Length == 0)
                            {
                                // check the operator is not a minus (negative number)
                                if (tip != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator (+ - * or /) specified without a right side number");
                                }
                                op.RightSide += input[i];
                            }
                            else
                            {
                                op.LeftSide = CalculateOperation(op);   //calc ec 
                                op.OperationType = tip;                 // atribuie noul operator
                                op.RightSide = string.Empty;    
                            }


                        }
                        else // sunt pe stanga
                        {
                            //get the op type
                            tip = GetOperationType(input[i]);

                           //daca nu am un nr
                            if(op.LeftSide.Length == 0)
                            {
                                // check the operator is not a minus (negative number)
                                if (tip != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator (+ - * or /) specified without a left side number");
                                }

                                op.LeftSide += input[i];
                            }
                            else 
                            {
                                // setez tipul de operatie
                                op.OperationType = tip;

                                //mut pe partea dreapta
                                st = false;
                            }
                        }

                    }
                }

                //if we are done parsing without exceptions
                //calculate the operation
                return CalculateOperation(op);

            }
            catch(Exception e)
            {
                return $"Invalid equation. {e.Message}";
            }
        }


        /// <summary>
        /// Calculate a <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="op"></param>
        private string CalculateOperation(Operation op)
        {
            decimal left = 0;       // mai precis decat double
            decimal right = 0;

            //check if we have a blank space or it is not a valid number
            if (string.IsNullOrEmpty(op.LeftSide) || !decimal.TryParse(op.LeftSide, out left))
            {
                throw new InvalidOperationException($"Left side of the operation was not a number. {op.LeftSide}");
            }

            if (string.IsNullOrEmpty(op.RightSide) || !decimal.TryParse(op.RightSide, out right))
            {
                throw new InvalidOperationException($"Right side of the operation was not a number. {op.RightSide}");
            }

            try
            {
                switch (op.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    case OperationType.Divide:
                        if (double.IsNaN ((double)(left / right)) || (double.IsInfinity((double)(left / right))))  // 0 / 0 => exception
                        {
                            throw new InvalidOperationException($", attempted to divide by zero. ");
                        }else
                            return (left / right).ToString(); 
                    default:
                        throw new InvalidOperationException($", unknown operator type when " +
                            $"calculating operation {op.OperationType}. ");
                }
            }
            catch(Exception e)
            {
                throw new InvalidOperationException($"Failed to calculate" +
                    $" operation {op.LeftSide} {op.OperationType} {op.RightSide}{e.Message}");
                                // 4                +               5
            }
        }

        /// <summary>
        /// accepts a parameter and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"Unknown operator type { character }");
            }
        }

        /// <summary>
        /// add a charact, check if valid (contains another dot)
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <param name="newCharacter"></param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // verif daca e deja punct(.) in string
            if (currentNumber.Contains('.') && newCharacter == '.') 
            {
                throw new InvalidOperationException($"number {currentNumber} already contains a . and another cannot be added.");
            }
            return currentNumber + newCharacter;        // tip string??
        }

         
        #endregion
       
    }
}
