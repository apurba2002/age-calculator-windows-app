using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int current_day = DateTime.Today.Day;
            int current_month = DateTime.Today.Month;
            int current_year=DateTime.Today.Year;
            int birth_day = dateTimePicker1.Value.Day;
            int birth_month = dateTimePicker1.Value.Month;
            int birth_year = dateTimePicker1.Value.Year;
            int day_in_month = DateTime.DaysInMonth(current_year, current_month);
            if (birth_day> current_day)
            {
                current_month = current_month - 1;
                current_day= current_day+day_in_month;

            }
            if (birth_month> current_month)
            {
                birth_month = current_month-1;
                current_month= current_month+12;
            }
            int calculated_day = current_day-birth_day;
            int calculated_month = current_month-birth_month;
            int calculated_year = current_year-birth_year;
            //string show = "Your age is " + calculated_year.ToString() + " years " + calculated_month.ToString() + " months " + calculated_day.ToString() + " days ";

            textBox1.Text=calculated_year.ToString();
            textBox3.Text = calculated_month.ToString();
            textBox2.Text= calculated_day.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
