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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro mcada = new menu_cadastro();
            mcada.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta fm4 = new consulta();
            fm4.Show();

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
    }
}
