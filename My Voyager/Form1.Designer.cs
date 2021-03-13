using System;
using System.Windows.Forms;
using System.Drawing;
namespace My_Voyager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.myMatrix = new System.Windows.Forms.DataGridView();
            this.pushCount = new System.Windows.Forms.Button();
            this.step = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.progName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // myMatrix
            // 
            this.myMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.myMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myMatrix.Location = new System.Drawing.Point(43, 119);
            this.myMatrix.Name = "myMatrix";
            this.myMatrix.Size = new System.Drawing.Size(443, 282);
            this.myMatrix.TabIndex = 0;
            // 
            // pushCount
            // 
            this.pushCount.Location = new System.Drawing.Point(257, 495);
            this.pushCount.Name = "pushCount";
            this.pushCount.Size = new System.Drawing.Size(115, 23);
            this.pushCount.TabIndex = 1;
            this.pushCount.Text = "Push count";
            this.pushCount.UseVisualStyleBackColor = true;
            this.pushCount.Click += new System.EventHandler(this.pushCount_Click);
            // 
            // step
            // 
            this.step.Location = new System.Drawing.Point(389, 495);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(115, 23);
            this.step.TabIndex = 2;
            this.step.Text = "Make a step";
            this.step.UseVisualStyleBackColor = true;
            this.step.Click += new System.EventHandler(this.step_Click);
            // 
            // counter
            // 
            this.counter.Location = new System.Drawing.Point(389, 423);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(169, 20);
            this.counter.TabIndex = 3;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.White;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info.Location = new System.Drawing.Point(514, 119);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(243, 282);
            this.info.TabIndex = 13;
            // 
            // progName
            // 
            this.progName.AutoSize = true;
            this.progName.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progName.ForeColor = System.Drawing.Color.White;
            this.progName.Location = new System.Drawing.Point(273, 28);
            this.progName.Name = "progName";
            this.progName.Size = new System.Drawing.Size(241, 25);
            this.progName.TabIndex = 4;
            this.progName.Text = "МЕТОД ГІЛОК ТА МЕЖ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "МЕТОД КОМІВОЯЖЕРА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(204, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кількість міст у матриці:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(263, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кінцевий шлях:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 455);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "ПОБУДОВАНИЙ ШЛЯХ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(535, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "ОПИС КРОКІВ РОЗВ\'ЯЗАННЯ:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(44)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(794, 551);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progName);
            this.Controls.Add(this.info);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.step);
            this.Controls.Add(this.pushCount);
            this.Controls.Add(this.myMatrix);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Метод гілок та меж";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DataGridView myMatrix;
        private Button pushCount;
        private Button step;
        private TextBox counter;
        private Label info;
        private Label progName;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label2;
        private Label label6;
    }
}

