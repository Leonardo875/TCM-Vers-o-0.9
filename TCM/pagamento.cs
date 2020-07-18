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
    public partial class pagamento : Form
    {
        public pagamento()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro mncada = new menu_cadastro();
            mncada.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta mnconsu = new consulta();
            mnconsu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            agendamento mnage = new agendamento();
            mnage.Show();

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox4_Enter_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "Nº do Passaporte")
            {
                textBox4.Text = "";
            }

        }

        private void textBox4_Leave_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Nº do Passaporte";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro_ciente mncadacie = new menu_cadastro_ciente();
            mncadacie.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza ?", "?????", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes){
                MessageBox.Show("Concluido", "", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }


            /**essa tela vai para um bolheto nesse bolheto vai mostrar tudo (nº da passagem)
             vai ser tipo ummmmm CONSULTA**/
        }
    }
}
