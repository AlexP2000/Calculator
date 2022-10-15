using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string operation= "";
        int value=0;
        int value2=0;
        bool operation_pressed= false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buton_reset_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void buton_iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buton_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
            {
                result.Clear();
            }
            Button a=(Button)sender;
            value=Convert.ToInt32(a.Text);
            result.Text = result.Text + a.Text;
           
            
        }
        
        private void operator_click(object sender, EventArgs e)// Generic event handler
        {
            
            Button c = (Button)sender;
            value2 = Convert.ToInt32(result.Text);
            operation = c.Text;
            result.Text = result.Text + operation;
           
            operation_pressed = true;
        }
        private int ridicarelaputere(int a, int b)
        {
            result.Clear();
            int j = b;
            int rezultat=0;
            for(int i=0;i<j;i++)
            {
                rezultat = rezultat * a;
               
            }
            return rezultat;
        }
        
        private void buton_egal_Click(object sender, EventArgs e)
        {
            result.Clear();
            switch (operation)
            {
                case "+":

                    result.Text = Convert.ToString(value + value2);
                    break;
                case "-":
                    result.Text = Convert.ToString(value - value2);
                    break;
                case "*":
                    result.Text = Convert.ToString(value * value2);
                    break;
                case "/":
                    result.Text = Convert.ToString(value / value2);
                    break;
                default:
                    break;
            }

        }

        private void buton_ridicare_la_putere_Click(object sender, EventArgs e)
        {
            result.Clear();
            result.Text=Convert.ToString(ridicarelaputere(value , value2));
        }
    }
}
