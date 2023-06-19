using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private List<Bolezni> Заболевания { get; set; }
        public Form1()
        {
            InitializeComponent();
            Заболевания = new List<Bolezni>();
            Заболевания.Add(new Bolezni("Gripp"));
            Заболевания.Add(new Bolezni("Рак"));
            Заболевания.Add(new Bolezni("Ветрянка"));
            Заболевания.Add(new Bolezni("Желтуха"));
            Заболевания.Add(new Bolezni("Гастрит"));
            Заболевания.Add(new Bolezni("Язва"));
            dataGridView1.DataSource = Заболевания.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Заболевания.Where(u => u.bolezn == textBox1.Text).ToList();
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = Заболевания.ToList();
            }
        }
    }
}
