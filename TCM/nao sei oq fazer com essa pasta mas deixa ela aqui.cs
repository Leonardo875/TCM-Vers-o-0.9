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
    public partial class menu_cadastro_hotel : Form
    {
        public menu_cadastro_hotel()
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

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            menu_cadastro mn = new menu_cadastro();
            mn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            agendamento mn = new agendamento();
            mn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagamento mn = new pagamento();
            mn.Show();
        }

        private void menu_cadastro_hotel_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagamento pg = new pagamento();
            pg.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Têm Certeza que quer Cancelar?", "???",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                this.Hide();
                menu_cadastro mncada = new menu_cadastro();
                mncada.Show();
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
        }
    }
}
