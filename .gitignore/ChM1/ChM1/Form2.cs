using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChM1
{
    public partial class Form2 : Form
    {

        double A;
        double B;
        double C;
        string f = "(ab-4c)/(ln(a)+b)";
        string fK = "(b+cosC)/(b+2a)";
        string fz= "((b - c) ^ 2) / (2a+b)";

        string da = "0,";
        string db = "0,";
        string dc = "0,";

        double dA;
        double dB;
        double dC;

        double UpA;
        double DwA;
        double UpB;
        double DwB;
        double UpC;
        double DwC;


        public Form2()
        {
            InitializeComponent();

            // F_a.Text = "1,105";
            // F_b.Text = "6,453";
            // F_c.Text = "3,54";
            F_formula.Text = fz;
        }

        private void F_Res_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(F_a.Text);
            B = Convert.ToDouble(F_b.Text);
            C = Convert.ToDouble(F_c.Text);


            CountDelta();  //считаем дельта

            CountBorder(); //считаем границы a, b, c

            double b_min_C_Up = UpB - DwC;
            F_resh.Text += "\n верхняя b-c =" + b_min_C_Up;
            double b_min_C_Dw = DwB - UpC;
            F_resh.Text += "\n нижняя b-c =" + b_min_C_Dw;

            double sqr_Up = Math.Pow(b_min_C_Up, 2);
            F_resh.Text += "\n верхняя (b-c)^2 =" + Math.Round(sqr_Up,4);
            double sqr_Dw = Math.Pow(b_min_C_Dw, 2);
            F_resh.Text += "\n нижняя (b-c)^2 =" + Math.Round(sqr_Dw,4);

            double Up_2a = 2 * UpA;
            F_resh.Text += "\n верхняя 2а =" + Up_2a;
            double Dw_2a = 2 * DwA;
            F_resh.Text += "\n нижняя 2а =" + Dw_2a;
            
            double b_pl_2a_Up = UpB + Up_2a;
            F_resh.Text += "\n верхняя b+2a =" + b_pl_2a_Up;
            double b_pl_2a_Dw = DwB + Dw_2a;
            F_resh.Text += "\n нижняя b+2a =" + b_pl_2a_Dw;

            

            double ZUp = sqr_Up / b_pl_2a_Dw;
            double ZDw = sqr_Dw / b_pl_2a_Up;

            ZUp = Math.Round(ZUp, 4);
            ZDw = Math.Round(ZDw, 4);

            F_otvet.Text = ZDw + " < Z < " + ZUp;
        }

        private void CountBorder()
        {
            UpA = A + dA;
            DwA = A - dA;

            UpB = B + dB;
            DwB = B - dB;

            UpC = C + dC;
            DwC = C - dC;

        }

        private void CountDelta()   /* дельта=сколько знаков после запятой, столько нулей, +5*/
        {
            int a = 0;
            while (A * Math.Pow(10, 1 + a) % 10 != 0)
            {
                a++;//чисел после ,
                da += "0";
            }
            da += "5";
            dA = Convert.ToDouble(da);


            int b = 0;
            while (B * Math.Pow(10, 1 + b) % 10 != 0)
            {
                b++;//чисел после ,
                db += "0";
            }
            db += "5";
            dB = Convert.ToDouble(db);

            int c = 0;
            while (C * Math.Pow(10, 1 + c) % 10 != 0)
            {
                c++;//чисел после ,
                dc += "0";
            }
            dc += "5";
            dC = Convert.ToDouble(dc);
        }
    }
}
