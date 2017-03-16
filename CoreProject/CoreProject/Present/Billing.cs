﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreProject.Controller.HSPControllers;

namespace CoreProject.Present
{
    public partial class Billing : Form
    {
        public BillController billControl { get; }
        public Billing Type { get; set; }
        List<String> services = new List<String>();
        List<int> charges = new List<int>();
        /// <summary>
        /// This is the default constructor for the Billing GUI.
        /// </summary>
        /// <param name="billControl"></param>
        public Billing(BillController billControl)
        {
            this.billControl = billControl;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s = listBox1.SelectedItem.ToString();
            services.Add(listBox1.SelectedItem.ToString());
            s += " - $" + numericUpDown1.Value.ToString();
            charges.Add(Convert.ToInt32(numericUpDown1.Value));

            listBox2.Items.Add(s);
            listBox2.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check policy number (if not exists show error message)
            var checkPolicy = this.billControl.CheckPolicy(Convert.ToInt32(this.textBox1.Text));
            //check enrollee (if not exists show error message)
            var checkEnrollee = this.billControl.CheckEnrollee(this.textBox3.Text);
            //send each service to be processed to controller
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                Console.Write(listBox2.Items[i]);
            }

            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice invoice = new Invoice(billControl.HSPCalculate(services, charges));
            invoice.Show();
        }
    }
}
