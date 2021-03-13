using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_Voyager
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
        }
        public int c;
        private void pushCount_Click(object sender, EventArgs e)
        {
            // инициализация и заполнение матрицы
            myMatrix.Enabled = true;
            
            info.Text = "Step 1. Enter cyties.";
            c = Convert.ToInt32(counter.Text);
            myMatrix.ColumnCount = c;
            
            for (int i = 0; i < c; i++)
            {
                myMatrix.Rows.Add();
                for (int j = 0; j < c; j++)
                {
                    myMatrix.Rows[i].Cells[i].Value = i;

                }
            }
            // окрашивание городов
            for (int i = 0; i < c; i++)
            {
                myMatrix.Rows[i].Cells[i].Style.BackColor = Color.DarkGreen;
                myMatrix.Rows[i].Cells[i].Style.ForeColor = Color.White;
                myMatrix.Rows[i].Cells[i].Value = "Г";
                myMatrix.Rows[i].Cells[i].ReadOnly = true;
            }
        }

        private void step_Click(object sender, EventArgs e)
        {
            
        }
    }
}
