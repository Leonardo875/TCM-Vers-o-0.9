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
    public partial class menu_cadastro : Form
    {
        public menu_cadastro()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro_ciente mncliente = new menu_cadastro_ciente();
            mncliente.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro_destino fm3 = new menu_cadastro_destino();
            fm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta fm4 = new consulta();
            fm4.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_passaporte mnpass = new menu_passaporte();
            mnpass.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            agendamento fm5 = new agendamento();
            fm5.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagamento mnpaga = new pagamento();
            mnpaga.Show();

        }

        private void menu_cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
