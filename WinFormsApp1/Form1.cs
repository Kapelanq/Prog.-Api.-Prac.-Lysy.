using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
       
        static Random rnd = new Random();
        int randomNumber = rnd.Next(1, 10);

        int iloscProb = 0;

      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void counter_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(input.Text);

            if (randomNumber > x)
            {
                label2.Text = "Większa!";
                iloscProb++;
            }else if(randomNumber < x)
            {
                label2.Text = "Mniejsza!";
                iloscProb++;
            }else if(randomNumber == x)
            {
                label2.Text = "Zgadłeś!";
            }
            counter.Text = $"Ilość prób: {iloscProb}";
        }
    }
}
