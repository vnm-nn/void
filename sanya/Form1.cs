using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanya
{
    public partial class Form1 : MaterialForm
    {
        private object items;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var helper = new ClassWord("bonk.docx");

            var item = new Dictionary<string, string>
            {
                { "<date>", dateTimePicker1.Value.ToString("dd.mm.yyyy") },
                { "<name>", textBox1.Text },
                { "<date1>", dateTimePicker2.Value.ToString("dd.mm.yyyy") },
                { "<upr>", textBox2.Text },
                { "<tect>", textBox3.Text }
            };

            helper.Process(item);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
