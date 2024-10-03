namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string inputValue;
        private int clickCount = 0;
        private int seriesIndex = 1;
        private string firstNum = "";
        private string secondNum = "";
        private string currentNum = "";
        private string currentOp = "";
        private int result = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                inputValue = textBox1.Text;
            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(inputValue) % 3 == 0)
            {
                MessageBox.Show(inputValue + " делится на 3");
            }

            else
            {
                MessageBox.Show(inputValue + " не делится на 3");
            }
        }

        private void colorsCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < colorsCheckList.Items.Count; i++)
            {
                if (colorsCheckList.SelectedIndex != i)
                {
                    colorsCheckList.SetItemChecked(i, false);
                }

                switch (colorsCheckList.SelectedIndex)
                {
                    case 0:
                        labelToColorChange.BackColor = Color.Black;
                        break;
                    case 1:
                        labelToColorChange.BackColor = Color.Red;
                        break;
                    case 2:
                        labelToColorChange.BackColor = Color.Blue;
                        break;
                    case 3:
                        labelToColorChange.BackColor = Color.Yellow;
                        break;
                }
            }
            if (colorsCheckList.CheckedItems.Count == 0)
            {
                this.labelToColorChange.BackColor = Color.White;
            }
        }

        private void clickCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            clickCount++;
            clickCountLabel.Text = $"Количество кликов: {clickCount}";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (clickCount > 0)
            {
                chart.Series["Clicks"].Points.AddXY($"Серия {seriesIndex}", clickCount);
                seriesIndex++;
                clickCount = 0;
                clickCountLabel.Text = "Количество кликов: 0";
            }
            else
            {
                MessageBox.Show("Пожалуйста, кликните хотя бы один раз перед записью результата.");
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonText = clickedButton.Text;
                if (int.TryParse(buttonText, out int text))
                {
                    currentNum += buttonText;
                    numTextBox.Text += buttonText;

                    if (currentOperationLabel.Text != "" & firstNum == "" & secondNum == "")
                    {
                        currentOperationLabel.Text = "";
                    }
                }

                else
                {
                    if (currentNum != "")
                    {
                        if (firstNum == "")
                        {
                            firstNum = currentNum;
                        }

                        else if (secondNum == "")
                        {
                            secondNum = currentNum;
                            currentOperationLabel.Text += currentNum + " ";
                        }
                        
                    }

                    if (buttonText == "=" & secondNum != "")
                    {
                        int firstN = int.Parse(firstNum);
                        int secondN = int.Parse(secondNum);

                        switch (currentOp)
                        {

                            case "+":
                                result = firstN + secondN;
                                break;

                            case "-":
                                result = firstN - secondN;
                                break;
                            case "*":
                                result = secondN * firstN;
                                break;
                            case "/":
                                result = secondN / firstN;
                                break;
                        }

                        currentOperationLabel.Text += "= " + result;

                        firstNum = "";
                        secondNum = "";
                        result = 0;

                    }

                    else if (buttonText == "CE")
                    {
                        firstNum = "";
                        secondNum = "";
                        currentOperationLabel.Text = "";
                    }

                    else if (buttonText == "C")
                    {
                        if (secondNum != "")
                        {
                            currentOperationLabel.Text = currentOperationLabel.Text.Replace(secondNum, "");
                            secondNum = "";
                        }

                        else
                        {
                            currentOperationLabel.Text = "";
                            firstNum = "";
                        }
                    }

                    else if (secondNum == "")
                    {
                        currentOp = buttonText;
                        currentOperationLabel.Text = firstNum + " " + buttonText + " ";
                    }

                    currentNum = "";
                    numTextBox.Text = "";
                }
            }
        }
    }
}

