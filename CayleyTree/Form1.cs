using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;


        static double th1;
        static double th2;
        static double per1;
        static double per2;
        static int i = 0;
        Pen p = Pens.Black;
        Pen[] ps = { Pens.Red,Pens.Blue,Pens.Yellow};
        
        

        void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(ps[i],(int)x0,(int)y0,(int)x1,(int)y1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (graphics == null) graphics = this.CreateGraphics();
                DrawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //inth1=double.Parse(textBox1.Text);
            th1 = (double.Parse(textBox1.Text)) * Math.PI / 180;
            th2 = (double.Parse(textBox2.Text)) * Math.PI / 180;
            per1 = (double.Parse(textBox3.Text));
            per2 = (double.Parse(textBox4.Text));
            MessageBox.Show("提交成功！现在可以点击绘制按钮进行绘制了！");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i= comboBox1.SelectedIndex;
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    int s=comboBox1.SelectedIndex;
        //    i = s;
        //}

    }
}
