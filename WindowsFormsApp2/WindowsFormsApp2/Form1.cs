using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2.ServiceReference1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client _cl = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Model> a = new List<Model>();
            a =_cl.GetData(1).ToList();
        }
    }
}
