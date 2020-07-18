using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class menu_passaporte : Form
    {
        public menu_passaporte()
        {
            InitializeComponent();
        }

        private void menu_passaporte_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagamento pg = new pagamento();
            pg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            agendamento ag = new agendamento();
            ag.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta con = new consulta();
            con.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro mn = new menu_cadastro();
            mn.Show();


        }
    }
}
