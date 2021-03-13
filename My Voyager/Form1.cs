using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace My_Voyager
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            

        }
        public int c;
        
        public void pushCount_Click(object sender, EventArgs e)
        {
            // инициализация и заполнение матрицы
            myMatrix.Enabled = true;
            
            info.Text = "Step 1. Заполнение матрицы городами.\nПоле с матрицей заполняется городами по главной диагонали. Количество городов введено пользователем. Заполните значения матрицы вручную. Максимальное количество городов - 10.";
            c = Convert.ToInt32(counter.Text);
            if (c > 10)
            {
                MessageBox.Show("Error counter.");
                this.Dispose();
                Application.Exit();
            }
            Random rand = new Random();
            myMatrix.ColumnCount = c;
            myMatrix.RowCount = c;
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    myMatrix.Rows[i].Cells[j].Value = rand.Next(1, 100);
                }
            }

            for (int i = 0; i < c; i++)
            {
                myMatrix.Rows.Add();
                for (int j = 0; j < c; j++)
                {
                    myMatrix.Rows[i].Cells[i].Style.BackColor = Color.DarkGreen;
                    myMatrix.Rows[i].Cells[i].Style.ForeColor = Color.White;
                    myMatrix.Rows[i].Cells[i].Value = 0;
                    myMatrix.Rows[i].Cells[i].ReadOnly = true;
                    
                }
            }
          
            // заполнение по индексу. Поместить значение в переменную и взаимодействовать!!!
            // myMatrix.Rows[1].Cells[1].Value = 123;
        }

        private void step_Click(object sender, EventArgs e)
        {
            List<TextBox> lst = new List<TextBox>()
            {
                new TextBox() {Location = new Point(502, 119), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(502, 145), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(502, 171), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(502, 197), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(502, 223), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(502, 249), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(502, 275), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(502, 301), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(502, 327), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(502, 353), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(107, 407), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(141, 407), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(175, 407), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(209, 407), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(243, 407), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(278, 407), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(312, 407), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(346, 407), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(380, 407), Size = new Size(28, 20)},
                new TextBox() {Location = new Point(73, 407), Size = new Size(28, 20)},
            };

            foreach (var item in lst)
            {
                Controls.Add(item);
            }

            info.Text = "Step 2. Поиск минимального элемента в каждой строке и столбце матрицы." + "Каждый элемент будет выведен в отдельное поле.";
            int[,] a = new int[c, c];
            
            for (int i = 0; i < c; i++)
            {
                int min = 0;
                for (int j = 0; j < c; j++)
                {
                    if (j == 0)
                        min = (int)myMatrix.Rows[i].Cells[j].Value;
                    if ((int)myMatrix.Rows[i].Cells[j].Value < min)
                        min = (int)myMatrix.Rows[i].Cells[j].Value;
                }

                if (i == 0)
                    lst[0].Text = min.ToString();
                if (i == 1)
                    lst[1].Text = min.ToString();
                if (i == 2)
                    lst[2].Text = min.ToString();
                if (i == 3)
                    lst[3].Text = min.ToString();
                if (i == 4)
                    lst[4].Text = min.ToString();
                if (i == 5)
                    lst[5].Text = min.ToString();
                if (i == 6)
                    lst[6].Text = min.ToString();
                if (i == 7)
                    lst[7].Text = min.ToString();
                if (i == 8)
                    lst[8].Text = min.ToString();
                if (i == 9)
                    lst[9].Text = min.ToString();
            }
            for (int j = 0; j < c; j++)
            {
                int min = int.MaxValue;
                for (int i = 0; i < c; i++)
                {
                    if (min > a[i, j])
                    {
                        min = a[i, j];
                    }

                }

                if (j == 0)
                    lst[10].Text = min.ToString();
                if (j == 1)
                    lst[11].Text = min.ToString();
                if (j == 2)
                    lst[12].Text = min.ToString();
                if (j == 3)
                    lst[13].Text = min.ToString();
                if (j == 4)
                    lst[14].Text = min.ToString();
                if (j == 5)
                    lst[15].Text = min.ToString();
                if (j == 6)
                    lst[16].Text = min.ToString();
                if (j == 7)
                    lst[17].Text = min.ToString();
                if (j == 8)
                    lst[18].Text = min.ToString();
                if (j == 9)
                    lst[19].Text = min.ToString();
                if (j == 10)
                    lst[20].Text = min.ToString();
            }
        }
        
    }
}
