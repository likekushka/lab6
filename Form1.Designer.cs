using System.Windows.Forms.DataVisualization.Charting;
namespace lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            colorsCheckBoxLabel = new Label();
            colorsCheckList = new CheckedListBox();
            labelToColorChange = new Label();
            tabPage3 = new TabPage();
            addButton = new Button();
            clickButton = new Button();
            clickCountLabel = new Label();
            tabPage4 = new TabPage();
            currentOperationLabel = new Label();
            numTextBox = new TextBox();
            deleteButton = new Button();
            deleteAllButton = new Button();
            divideButton = new Button();
            multiplyButton = new Button();
            minusButton = new Button();
            plusButton = new Button();
            equalButton = new Button();
            num0Button = new Button();
            num9Button = new Button();
            num8Button = new Button();
            num7Button = new Button();
            num6Button = new Button();
            num5Button = new Button();
            num4Button = new Button();
            num3Button = new Button();
            num2Button = new Button();
            num1Button = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1159, 710);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1143, 656);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(4, 183);
            button1.Name = "button1";
            button1.Size = new Size(257, 90);
            button1.TabIndex = 2;
            button1.Text = "Проверить делимость на 3";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 30);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 1;
            label1.Text = "Введите число";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(colorsCheckBoxLabel);
            tabPage2.Controls.Add(colorsCheckList);
            tabPage2.Controls.Add(labelToColorChange);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1143, 656);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // colorsCheckBoxLabel
            // 
            colorsCheckBoxLabel.AutoSize = true;
            colorsCheckBoxLabel.Location = new Point(58, 175);
            colorsCheckBoxLabel.Name = "colorsCheckBoxLabel";
            colorsCheckBoxLabel.Size = new Size(180, 32);
            colorsCheckBoxLabel.TabIndex = 2;
            colorsCheckBoxLabel.Text = "Выберите цвет";
            // 
            // colorsCheckList
            // 
            colorsCheckList.CheckOnClick = true;
            colorsCheckList.FormattingEnabled = true;
            colorsCheckList.Items.AddRange(new object[] { "Черный", "Красный", "Синий", "Желтый" });
            colorsCheckList.Location = new Point(58, 210);
            colorsCheckList.Name = "colorsCheckList";
            colorsCheckList.Size = new Size(240, 184);
            colorsCheckList.TabIndex = 1;
            colorsCheckList.SelectedIndexChanged += colorsCheckList_SelectedIndexChanged;
            // 
            // labelToColorChange
            // 
            labelToColorChange.AutoSize = true;
            labelToColorChange.Location = new Point(58, 61);
            labelToColorChange.Name = "labelToColorChange";
            labelToColorChange.Size = new Size(102, 32);
            labelToColorChange.TabIndex = 0;
            labelToColorChange.Text = "Черный";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(addButton);
            tabPage3.Controls.Add(clickButton);
            tabPage3.Controls.Add(clickCountLabel);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1143, 656);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(239, 128);
            addButton.Name = "addButton";
            addButton.Size = new Size(291, 46);
            addButton.TabIndex = 2;
            addButton.Text = "Добавить результат";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // clickButton
            // 
            clickButton.Location = new Point(50, 128);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(150, 46);
            clickButton.TabIndex = 1;
            clickButton.Text = "Кликни";
            clickButton.UseVisualStyleBackColor = true;
            clickButton.Click += clickButton_Click;
            // 
            // clickCountLabel
            // 
            clickCountLabel.AutoSize = true;
            clickCountLabel.Location = new Point(33, 36);
            clickCountLabel.Name = "clickCountLabel";
            clickCountLabel.Size = new Size(254, 32);
            clickCountLabel.TabIndex = 0;
            clickCountLabel.Text = "Количество кликов: 0";
            clickCountLabel.Click += clickCountLabel_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(currentOperationLabel);
            tabPage4.Controls.Add(numTextBox);
            tabPage4.Controls.Add(deleteButton);
            tabPage4.Controls.Add(deleteAllButton);
            tabPage4.Controls.Add(divideButton);
            tabPage4.Controls.Add(multiplyButton);
            tabPage4.Controls.Add(minusButton);
            tabPage4.Controls.Add(plusButton);
            tabPage4.Controls.Add(equalButton);
            tabPage4.Controls.Add(num0Button);
            tabPage4.Controls.Add(num9Button);
            tabPage4.Controls.Add(num8Button);
            tabPage4.Controls.Add(num7Button);
            tabPage4.Controls.Add(num6Button);
            tabPage4.Controls.Add(num5Button);
            tabPage4.Controls.Add(num4Button);
            tabPage4.Controls.Add(num3Button);
            tabPage4.Controls.Add(num2Button);
            tabPage4.Controls.Add(num1Button);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1143, 656);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // currentOperationLabel
            // 
            currentOperationLabel.AutoSize = true;
            currentOperationLabel.Location = new Point(371, 16);
            currentOperationLabel.Name = "currentOperationLabel";
            currentOperationLabel.Size = new Size(0, 32);
            currentOperationLabel.TabIndex = 17;
            // 
            // numTextBox
            // 
            numTextBox.Location = new Point(369, 59);
            numTextBox.Name = "numTextBox";
            numTextBox.Size = new Size(418, 39);
            numTextBox.TabIndex = 16;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(581, 115);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(206, 100);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "C";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += calcButton_Click;
            // 
            // deleteAllButton
            // 
            deleteAllButton.Location = new Point(369, 115);
            deleteAllButton.Name = "deleteAllButton";
            deleteAllButton.Size = new Size(206, 100);
            deleteAllButton.TabIndex = 15;
            deleteAllButton.Text = "CE";
            deleteAllButton.UseVisualStyleBackColor = true;
            deleteAllButton.Click += calcButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(687, 539);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(100, 100);
            divideButton.TabIndex = 14;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += calcButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(687, 433);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(100, 100);
            multiplyButton.TabIndex = 13;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += calcButton_Click;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(687, 327);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(100, 100);
            minusButton.TabIndex = 12;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += calcButton_Click;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(687, 221);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(100, 100);
            plusButton.TabIndex = 11;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += calcButton_Click;
            // 
            // equalButton
            // 
            equalButton.Location = new Point(475, 539);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(206, 100);
            equalButton.TabIndex = 10;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = true;
            equalButton.Click += calcButton_Click;
            // 
            // num0Button
            // 
            num0Button.Location = new Point(369, 539);
            num0Button.Name = "num0Button";
            num0Button.Size = new Size(100, 100);
            num0Button.TabIndex = 9;
            num0Button.Text = "0";
            num0Button.UseVisualStyleBackColor = true;
            num0Button.Click += calcButton_Click;
            // 
            // num9Button
            // 
            num9Button.Location = new Point(581, 433);
            num9Button.Name = "num9Button";
            num9Button.Size = new Size(100, 100);
            num9Button.TabIndex = 8;
            num9Button.Text = "9";
            num9Button.UseVisualStyleBackColor = true;
            num9Button.Click += calcButton_Click;
            // 
            // num8Button
            // 
            num8Button.Location = new Point(475, 433);
            num8Button.Name = "num8Button";
            num8Button.Size = new Size(100, 100);
            num8Button.TabIndex = 7;
            num8Button.Text = "8";
            num8Button.UseVisualStyleBackColor = true;
            num8Button.Click += calcButton_Click;
            // 
            // num7Button
            // 
            num7Button.Location = new Point(369, 433);
            num7Button.Name = "num7Button";
            num7Button.Size = new Size(100, 100);
            num7Button.TabIndex = 6;
            num7Button.Text = "7";
            num7Button.UseVisualStyleBackColor = true;
            num7Button.Click += calcButton_Click;
            // 
            // num6Button
            // 
            num6Button.Location = new Point(581, 327);
            num6Button.Name = "num6Button";
            num6Button.Size = new Size(100, 100);
            num6Button.TabIndex = 5;
            num6Button.Text = "6";
            num6Button.UseVisualStyleBackColor = true;
            num6Button.Click += calcButton_Click;
            // 
            // num5Button
            // 
            num5Button.Location = new Point(475, 327);
            num5Button.Name = "num5Button";
            num5Button.Size = new Size(100, 100);
            num5Button.TabIndex = 4;
            num5Button.Text = "5";
            num5Button.UseVisualStyleBackColor = true;
            num5Button.Click += calcButton_Click;
            // 
            // num4Button
            // 
            num4Button.Location = new Point(369, 327);
            num4Button.Name = "num4Button";
            num4Button.Size = new Size(100, 100);
            num4Button.TabIndex = 4;
            num4Button.Text = "4";
            num4Button.UseVisualStyleBackColor = true;
            num4Button.Click += calcButton_Click;
            // 
            // num3Button
            // 
            num3Button.Location = new Point(581, 221);
            num3Button.Name = "num3Button";
            num3Button.Size = new Size(100, 100);
            num3Button.TabIndex = 2;
            num3Button.Text = "3";
            num3Button.UseVisualStyleBackColor = true;
            num3Button.Click += calcButton_Click;
            // 
            // num2Button
            // 
            num2Button.Location = new Point(475, 221);
            num2Button.Name = "num2Button";
            num2Button.Size = new Size(100, 100);
            num2Button.TabIndex = 1;
            num2Button.Text = "2";
            num2Button.UseVisualStyleBackColor = true;
            num2Button.Click += calcButton_Click;
            // 
            // num1Button
            // 
            num1Button.Location = new Point(369, 221);
            num1Button.Name = "num1Button";
            num1Button.Size = new Size(100, 100);
            num1Button.TabIndex = 0;
            num1Button.Text = "1";
            num1Button.UseVisualStyleBackColor = true;
            num1Button.Click += calcButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 729);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label colorsCheckBoxLabel;
        private CheckedListBox colorsCheckList;
        private Label labelToColorChange;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label clickCountLabel;
        private Button addButton;
        private Button clickButton;
        private Chart chart;
        private Button num1Button;
        private Button num9Button;
        private Button num8Button;
        private Button num7Button;
        private Button num6Button;
        private Button num5Button;
        private Button num4Button;
        private Button num3Button;
        private Button num2Button;
        private Button num0Button;
        private Button divideButton;
        private Button multiplyButton;
        private Button minusButton;
        private Button plusButton;
        private Button equalButton;
        private Button deleteAllButton;
        private TextBox numTextBox;
        private Button deleteButton;
        private Label currentOperationLabel;
    }
}
