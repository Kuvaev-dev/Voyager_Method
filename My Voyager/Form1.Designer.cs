using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

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
            this.step2 = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.progName = new System.Windows.Forms.Label();
            this.methodName = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.pathName = new System.Windows.Forms.Label();
            this.stepName = new System.Windows.Forms.Label();
            this.di = new System.Windows.Forms.Label();
            this.dj = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.step3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // myMatrix
            // 
            this.myMatrix.AllowUserToAddRows = false;
            this.myMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.myMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myMatrix.Location = new System.Drawing.Point(43, 119);
            this.myMatrix.Name = "myMatrix";
            this.myMatrix.Size = new System.Drawing.Size(443, 282);
            this.myMatrix.TabIndex = 0;
            // 
            // pushCount
            // 
            this.pushCount.Location = new System.Drawing.Point(337, 545);
            this.pushCount.Name = "pushCount";
            this.pushCount.Size = new System.Drawing.Size(115, 23);
            this.pushCount.TabIndex = 1;
            this.pushCount.Text = "Push count";
            this.pushCount.UseVisualStyleBackColor = true;
            this.pushCount.Click += new System.EventHandler(this.pushCount_Click);
            // 
            // step2
            // 
            this.step2.Location = new System.Drawing.Point(337, 585);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(115, 23);
            this.step2.TabIndex = 2;
            this.step2.Text = "Make a step 2";
            this.step2.UseVisualStyleBackColor = true;
            this.step2.Click += new System.EventHandler(this.step_Click);
            // 
            // counter
            // 
            this.counter.Location = new System.Drawing.Point(473, 472);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(169, 20);
            this.counter.TabIndex = 3;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.White;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(584, 119);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(243, 282);
            this.info.TabIndex = 13;
            // 
            // progName
            // 
            this.progName.AutoSize = true;
            this.progName.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progName.ForeColor = System.Drawing.Color.White;
            this.progName.Location = new System.Drawing.Point(347, 28);
            this.progName.Name = "progName";
            this.progName.Size = new System.Drawing.Size(241, 25);
            this.progName.TabIndex = 4;
            this.progName.Text = "МЕТОД ГІЛОК ТА МЕЖ";
            // 
            // methodName
            // 
            this.methodName.AutoSize = true;
            this.methodName.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodName.ForeColor = System.Drawing.Color.White;
            this.methodName.Location = new System.Drawing.Point(385, 53);
            this.methodName.Name = "methodName";
            this.methodName.Size = new System.Drawing.Size(164, 18);
            this.methodName.TabIndex = 5;
            this.methodName.Text = "ЗАДАЧА КОМІВОЯЖЕРА";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(275, 476);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(168, 16);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "Кількість міст у матриці:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathLabel.ForeColor = System.Drawing.Color.White;
            this.pathLabel.Location = new System.Drawing.Point(334, 502);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(109, 16);
            this.pathLabel.TabIndex = 8;
            this.pathLabel.Text = "Кінцевий шлях:";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(473, 502);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(169, 20);
            this.path.TabIndex = 9;
            // 
            // pathName
            // 
            this.pathName.AutoSize = true;
            this.pathName.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathName.ForeColor = System.Drawing.Color.White;
            this.pathName.Location = new System.Drawing.Point(181, 90);
            this.pathName.Name = "pathName";
            this.pathName.Size = new System.Drawing.Size(161, 16);
            this.pathName.TabIndex = 11;
            this.pathName.Text = "ПОБУДОВАНИЙ ШЛЯХ:";
            // 
            // stepName
            // 
            this.stepName.AutoSize = true;
            this.stepName.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepName.ForeColor = System.Drawing.Color.White;
            this.stepName.Location = new System.Drawing.Point(608, 90);
            this.stepName.Name = "stepName";
            this.stepName.Size = new System.Drawing.Size(204, 16);
            this.stepName.TabIndex = 12;
            this.stepName.Text = "ОПИС КРОКІВ РОЗВ\'ЯЗАННЯ:";
            // 
            // di
            // 
            this.di.AutoSize = true;
            this.di.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.di.ForeColor = System.Drawing.Color.White;
            this.di.Location = new System.Drawing.Point(499, 103);
            this.di.Name = "di";
            this.di.Size = new System.Drawing.Size(17, 13);
            this.di.TabIndex = 34;
            this.di.Text = "di";
            // 
            // dj
            // 
            this.dj.AutoSize = true;
            this.dj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dj.ForeColor = System.Drawing.Color.White;
            this.dj.Location = new System.Drawing.Point(50, 414);
            this.dj.Name = "dj";
            this.dj.Size = new System.Drawing.Size(17, 13);
            this.dj.TabIndex = 35;
            this.dj.Text = "dj";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(473, 545);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(115, 23);
            this.Clear.TabIndex = 36;
            this.Clear.Text = "Clear All";
            this.Clear.UseCompatibleTextRendering = true;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // step3
            // 
            this.step3.Location = new System.Drawing.Point(473, 585);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(115, 23);
            this.step3.TabIndex = 37;
            this.step3.Text = "Make a step 3";
            this.step3.UseVisualStyleBackColor = true;
            this.step3.Click += new System.EventHandler(this.step3_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(44)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(867, 634);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.dj);
            this.Controls.Add(this.di);
            this.Controls.Add(this.stepName);
            this.Controls.Add(this.pathName);
            this.Controls.Add(this.path);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.methodName);
            this.Controls.Add(this.progName);
            this.Controls.Add(this.info);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.pushCount);
            this.Controls.Add(this.myMatrix);
            this.MaximizeBox = false;
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
        private Button step2;
        private TextBox counter;
        private Label info;
        private Label progName;
        private Label methodName;
        private Label cityLabel;
        private Label pathLabel;
        private TextBox path;
        private Label pathName;
        private Label stepName;
        private Label di;
        private Label dj;
        private Button Clear;
        private Button step3;
    }
}

