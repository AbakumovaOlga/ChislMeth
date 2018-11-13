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
    public partial class Form1 : Form
    {
        double A;
        double B;
        double C;
        string f = "(ab-4c)/(ln(a)+b)";
        string fK = "(b+cosC)/(b+2a)";

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



        public Form1()
        {
            InitializeComponent();
            F_a.Text = "0,13487";
            F_b.Text = "14,025";
            F_c.Text="3,00129";
        }

        private void F_Res_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(F_a.Text);
            B = Convert.ToDouble(F_b.Text);
            C = Convert.ToDouble(F_c.Text);
            

            CountDelta();  //считаем дельта

            CountBorder(); //считаем границы a, b, c
            


            double Up_2a=2*UpA;
            double Dw_2a = 2 * DwA;

            double cosC_Upc = Math.Cos(UpC);
            double cosC_Dwc = Math.Cos(DwC);

            double b_pl_cosC_Up = UpB + cosC_Upc;
            double b_pl_cosC_Dw = DwB + cosC_Dwc;

            double b_pl_2a_Up = UpB + Up_2a;
            double b_pl_2a_Dw = DwB + Dw_2a;

            double ZUp = b_pl_cosC_Up / b_pl_2a_Dw;
            double ZDw = b_pl_cosC_Dw / b_pl_2a_Up;

            ZUp = Math.Round(ZUp, 4);
            ZDw = Math.Round(ZDw, 4);

            F_otvet.Text = ZDw + " < Z < " + ZUp;

        }
        

        private void Umnoj(double x, double y)
        {
            
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

            int c= 0;
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
