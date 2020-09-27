using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВзломПентагона
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int i = 0;
        int k = 0;
        int j = 0;
        int y = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            switch (k)
            {
                case 0:
                    if (j == 0)
                    {
                        label2.Text = ("Подбор ip адреса: " + i).ToString();
                        if (i == 195)
                        {
                            j = 1;
                            i = 0;
                        }
                    }
                    if (j == 1)
                    {
                        label2.Text = ("Подбор ip адреса: 195." + i).ToString();
                            if (i == 243)
                            {
                                j = 2;
                                i = 0;
                            }
                    }
                    if (j == 2)
                    {
                        label2.Text = ("Подбор ip адреса: 195.243." + i).ToString();
                        if (i == 248)
                        {
                            j = 3;
                            i = 0;
                        }
                    }
                    if (j == 3)
                    {
                        label2.Text = ("Подбор ip адреса: 195.243.248." + i).ToString();
                        if (i == 192)
                        {
                            k = 1;
                            i = 0;
                        }
                    }

                    break;
                case 1:
                    timer1.Interval = 150;
                    if (y == 0) 
                    {
                        label3.Text = ("Подбор пороля:\n") + i + "*******";
                        if (i == 8)
                        {
                            i = 0;
                            y = 1;
                        }    
                    }
                    if (y == 1)
                    {
                        label3.Text = ("Подбор пороля:\n8") + i + "******";
                        if (i == 9)
                        {
                            i = 0;
                            y = 2;
                        }
                    }
                    if (y == 2)
                    {
                        label3.Text = ("Подбор пороля:\n89") + i + "*****";
                        if (i == 4)
                        {
                            i = 0;
                            y = 3;
                        }
                    }
                    if (y == 3)
                    {
                        label3.Text = ("Подбор пороля:\n894") + i + "****";
                        if (i == 0)
                        {
                            i = 0;
                            y = 4;
                        }
                    }
                    if (y == 4)
                    {
                        label3.Text = ("Подбор пороля:\n8940") + i + "***";
                        if (i == 7)
                        {
                            i = 0;
                            y = 5;
                        }
                    }
                    if (y == 5)
                    {
                        label3.Text = ("Подбор пороля:\n89407") + i + "**";
                        if (i == 3)
                        {
                            i = 0;
                            y = 6;
                        }
                    }
                    if (y == 6)
                    {
                        label3.Text = ("Подбор пороля:\n894073") + i + "*";
                        if (i == 5)
                        {
                            i = 0;
                            label3.Text = "Подбор пороля:\n8940735";
                            k = 2;
                        }
                    }
                    break;
                case 2:
                    progressBar2.Visible = true;
                    progressBar2.Value += 1;
                    label4.Text = "Процесс взлома: " + i + "%";
                    if (i == 100)
                    {
                        i = 0;
                        k = 3;
                    }
                    break;
                case 3:
                    timer1.Interval = 50;
                    progressBar1.Visible = true;
                    progressBar1.Value += 1;
                    label5.Text = "Скачивание данных: " + i + "%";
                    if (i == 100)
                    {
                        i = 0;
                        k = 4;
                    }
                    break;
                case 4:
                    timer1.Interval = 1000;
                    label6.Text = "Полученные данные:\nИСИП - 15 тупа лучшие хацкеры";
                    break;
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
