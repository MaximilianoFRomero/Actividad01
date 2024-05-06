using Actividad01.Models;
using Actividad01.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad01.Views
{
    public partial class Form1 : Form
    {
        Order order;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        public int GetSelectedIndex()
        {
            return comboBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(GetSelectedIndex()) 
            {
                case 0:
                    order = StaticOrder.GetOrderUS();
                    break;
                case 1:
                    order = StaticOrder.GetOrderEU();
                    break;
                case 2:
                    order = StaticOrder.GetOrderChinese();
                    break;
            }
            ShowOrderTotal();
        }

        private void ShowOrderTotal() 
        {
                label1.Text = order.getOrderTotal().ToString();
        }
    }
}
