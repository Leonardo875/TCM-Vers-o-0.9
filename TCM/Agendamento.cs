using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCM
{
    public partial class agendamento : Form
    {
        public agendamento()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-3RHEA9C\SQLEXPRESS;integrated security=SSPI;initial Catalog=bd_horizon");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dados;


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
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
            menu_cadastro fm5 = new menu_cadastro();
            fm5.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta fm3 = new consulta();
            fm3.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagamento mnpaga = new pagamento();
            mnpaga.Show();

        }

       

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if(textBox4.Text == "")
            {
                textBox4.Text = "Nº do Passaporte";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if(textBox4.Text == "Nº do Passaporte")
            {
                textBox4.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
             if (TextBox1.Text == "Data de Ida")
            {
                MessageBox.Show("É Necessário Informar a data de ida", "!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                
                string ida = TextBox1.Text;
                string volta = TextBox2.Text;

                try
                {
                    cn.Open();
                    cmd.CommandText = "insert into tbl_agenda(dt_ida,dt_volta,diarias_agenda)values('" + ida + "','" + volta + "')";


                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data registrada", "Gravação Concluida", MessageBoxButtons.OK);

                    /** cn.Close();
                    this.Hide();
                    pagamento pg = new pagamento();
                    pg.Show();*/
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
           
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "N° do Passaporte")
            {
                MessageBox.Show("É Necessário Informar o número do passaporte para realizar procura", "!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
