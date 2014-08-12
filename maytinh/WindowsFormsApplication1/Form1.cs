using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        const int base10 = 10;
        char[] cHexa = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
        int[] iHexaNumeric = new int[] { 10, 11, 12, 13, 14, 15 };
        int[] iHexaIndices = new int[] { 0, 1, 2, 3, 4, 5 };
        const int asciiDiff = 48;
        string DecimalToBase(int iDec, int numbase)
        {
            string strBin = "";
            int[] result = new int[32];
            int MaxBit = 32;
            for (; iDec > 0; iDec /= numbase)
            {
                int rem = iDec % numbase;
                result[--MaxBit] = rem;
            }
            for (int i = 0; i < result.Length; i++)
                if ((int)result.GetValue(i) >= base10)
                    strBin += cHexa[(int)result.GetValue(i) % base10];
                else
                    strBin += result.GetValue(i);
            strBin = strBin.TrimStart(new char[] { '0' });
            return strBin;
        }
        int BaseToDecimal(string sBase, int numbase)
        {
            int dec = 0;
            int b;
            int iProduct = 1;
            string sHexa = "";
            if (numbase > base10)
                for (int i = 0; i < cHexa.Length; i++)
                    sHexa += cHexa.GetValue(i).ToString();
            for (int i = sBase.Length - 1; i >= 0; i--, iProduct *= numbase)
            {
                string sValue = sBase[i].ToString();
                if (sValue.IndexOfAny(cHexa) >= 0)
                    b = iHexaNumeric[sHexa.IndexOf(sBase[i])];
                else
                    b = (int)sBase[i] - asciiDiff;
                dec += (b * iProduct);
            }
            return dec;
        }
        
        string tempSign;
        Double a, r, a1,b1;
        


        private bool kiemtra;
        private string ptoan, lastvalue;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            kkq.Clear();
        }

        private void s0_Click(object sender, EventArgs e)
        {
            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "0";
            kiemtra = false;

        }

        private void s1_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "1";
            kiemtra = false;
        }

        private void s2_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "2";
            kiemtra = false;
        }

        private void s3_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "3";
            kiemtra = false;
        }

        private void s4_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "4";
            kiemtra = false;
        }

        private void s5_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "5";
            kiemtra = false;
        }

        private void s6_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "6";
            kiemtra = false;
        }

        private void s7_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "7";
            kiemtra = false;
        }

        private void s8_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "8";
            kiemtra = false;
        }

        private void s9_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "9";
            kiemtra = false;
        }

        private void cong_Click(object sender, EventArgs e)
        {
            lastvalue = kkq.Text;
            kiemtra = true;
            ptoan = "+";
        }

        private void tru_Click(object sender, EventArgs e)
        {
            lastvalue = kkq.Text;
            kiemtra = true;
            ptoan = "-";
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            lastvalue = kkq.Text;
            kiemtra = true;
            ptoan = "*";
        }

        private void chia_Click(object sender, EventArgs e)
        {
            lastvalue = kkq.Text;
            kiemtra = true;
            ptoan = ":";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(lastvalue);
            b = Convert.ToDouble(kkq.Text);


            if (ptoan == "+") kkq.Text = Convert.ToString(a + b);
            if (ptoan == "-") kkq.Text = Convert.ToString(a - b);
            if (ptoan == "*") kkq.Text = Convert.ToString(a * b);
            if (ptoan == "/") kkq.Text = Convert.ToString(a / b);
        }

        private void xbinh_Click(object sender, EventArgs e)
        {

            if (kkq.Text == "")
            { return; }
            else
            {
                kkq.Tag = kkq.Text;
                double dec = Convert.ToDouble(kkq.Tag) * Convert.ToDouble(kkq.Tag);
                kkq.Text = dec.ToString();
            }
        }

        private void xmuba_Click(object sender, EventArgs e)
        {
            if (kkq.Text == "")
            { return; }
            else
            {
                kkq.Tag = kkq.Text;
                double dec = Convert.ToDouble(kkq.Tag) * Convert.ToDouble(kkq.Tag) * Convert.ToDouble(kkq.Tag);
                kkq.Text = dec.ToString();
            }
        }

        private void canbachai_Click(object sender, EventArgs e)
        {
            if (kkq.Text == "")
            { return; }
            else
            {
                kkq.Tag = kkq.Text;
                double dec = System.Math.Sqrt(Convert.ToDouble(kkq.Tag));
                kkq.Text = dec.ToString();
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            if (radian.Checked == true)
            {
                if (kkq.Text == "")
                { return; }
                else
                {
                    kkq.Tag = kkq.Text;
                    double dec = System.Math.Sin((Convert.ToDouble(kkq.Tag) * Convert.ToDouble(System.Math.PI)) / 180);
                    kkq.Text = dec.ToString();
                }

            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            if (radian.Checked == true)
            {
                if (kkq.Text == "")
                { return; }
                else
                {
                    kkq.Tag = kkq.Text;
                    double dec = System.Math.Cos((Convert.ToDouble(kkq.Tag) * Convert.ToDouble(System.Math.PI)) / 180);
                    kkq.Text = dec.ToString();
                }
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            if (radian.Checked == true)
                if (kkq.Text == "")
                { return; }
                else
                {
                    kkq.Tag = kkq.Text;
                    double dec = System.Math.Tan((Convert.ToDouble(kkq.Tag) * Convert.ToDouble(System.Math.PI)) / 180);
                    kkq.Text = dec.ToString();
                }
        }

        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(kkq.Text);
                r = System.Math.Log10(a);
                kkq.Text = r.ToString();
            }
            catch (Exception)
            {
                kkq.Text = "Invalid use";
            }
        }

        private void mux_Click(object sender, EventArgs e)
        {
            if (kkq.Text == "")
            { return; }
            else
            {
                kkq.Tag = kkq.Text;
                double dec = System.Math.Pow(10, Convert.ToDouble(kkq.Tag));
                kkq.Text = dec.ToString();
            }
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            if (kkq.Text == "")
            { return; }
            else
            {
                kkq.Tag = kkq.Text;
                double dec = System.Math.Sinh(Convert.ToDouble(kkq.Tag));
                kkq.Text = dec.ToString();
            }
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            if (kkq.Text == "")
            { return; }
            else
            {
                kkq.Tag = kkq.Text;
                double dec = System.Math.Cosh(Convert.ToDouble(kkq.Tag));
                kkq.Text = dec.ToString();
            }
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            if (kkq.Text == "")
            { return; }
            else
            {
                kkq.Tag = kkq.Text;
                double dec = System.Math.Tanh(Convert.ToDouble(kkq.Tag));
                kkq.Text = dec.ToString();
            }
        }

        private void pi_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(System.Math.PI);
            kkq.Text = dec.ToString();
        }

        private void xoadan_Click(object sender, EventArgs e)
        {
            try
            {
                kkq.Text = kkq.Text.Remove(kkq.Text.Length - 1, 1); ;
            }
            catch (Exception)
            { kkq.Text = ""; }

        }

        private void doicongtru_Click(object sender, EventArgs e)
        {
            if (kkq.Text.Contains("-"))
            {
                kkq.Text = kkq.Text.Remove(0, 1);
            }
            else kkq.Text = "-" + kkq.Text;
        }

        private void nluythua_Click(object sender, EventArgs e)
        {
            if (kkq.Text == "")
            { return; }
            else
            {
                kkq.Tag = kkq.Text;
                float dec = 1;
                for (int i = 1; i <= Convert.ToDecimal(kkq.Tag); i++)
                {
                    dec *= i;
                }
                kkq.Text = dec.ToString();
            }
        }

        private void phantram_Click(object sender, EventArgs e)
        {
            
        }

        private void C_Click(object sender, EventArgs e)
        {
            try
            {
                //a1 = Convert.ToDouble(textBox_output.Text);
                kkq.Text = "0";
                b1 = Convert.ToDouble(kkq.Text);
            }
            catch (Exception)
            {
                kkq.Text = "Invalid use";
            }
        }

        private void scham_Click(object sender, EventArgs e)
        {
            if (kkq.Text.Contains("."))
            {
                return;
            }
            else
                kkq.Text = kkq.Text + ".";
        }

        private void phanx_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(kkq.Text);
                r = 1 / a;
                kkq.Text = r.ToString();
            }
            catch (Exception)
            {
                kkq.Text = "Invalid use";
            }
        }
        
        private void xmuy_Click(object sender, EventArgs e)
        {
            try
            {
                a1 = Convert.ToDouble(kkq.Text);
                tempSign = "Pow";
                kkq.Text = "";
            }
            catch (Exception)
            {
                kkq.Text = "Invalid use";
            }
        }

        private void ln_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(kkq.Text);
                r = System.Math.Log(a);
                kkq.Text = r.ToString();
            }
            catch (Exception)
            {
                kkq.Text = "Invalid use";
            }
        }

        private void degrees_CheckedChanged(object sender, EventArgs e)
        {
            
        }
       }
}