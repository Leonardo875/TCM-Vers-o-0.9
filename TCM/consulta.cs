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
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-3RHEA9C\SQLEXPRESS;integrated security=SSPI;initial Catalog=bd_horizon");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dados;

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

        private void textBox4_Enter(object sender, EventArgs e)
        {

            if (textBox4.Text == "Nº do Passaporte")
            {
                textBox4.Text = "";
            }


        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

            if (textBox4.Text == "")
            {
                textBox4.Text = "Nº do Passaporte";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro_ciente fm3 = new menu_cadastro_ciente();
            fm3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaLinha();
           
        }
        private void carregaLinha()
        {
            char sexo;

            if (radioButton1.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'M';
            }

            textBox2.Text = dgvDados.SelectRows[0].Cells[0].Value.ToString();
            textBox1.Text = dgvDados.SelectRows[0].Cells[1].Value.ToString();
            textBox3.Text = dgvDados.SelectRows[0].Cells[2].Value.ToString();
            sexo = dgvDados.SelectRows[0].Cells[3].Value.ToString();
            textBox5.Text = dgvDados.SelectRows[0].Cells[4].Value.ToString();
            textBox4.Text = dgvDados.SelectRows[0].Cells[5].Value.ToString();
            textBox8.Text = dgvDados.SelectRows[0].Cells[6].Value.ToString();
            textBox9.Text = dgvDados.SelectRows[0].Cells[7].Value.ToString();
            textBox10.Text = dgvDados.SelectRows[0].Cells[7].Value.ToString();
            textBox7.Text = dgvDados.SelectRows[0].Cells[7].Value.ToString();

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                try
                {
                    cn.Open();

                    cmd.CommandText = "select * from tbl_cliente where nm_cliente('" + textBox6.Text + "%')";

                    cmd.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    dgvDados.DataSource = dt;

                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

                finally
                {
                    cn.Close();
                }
            } 
              
            else
            {
                dgvDados.DataSource = null;
            }
  
            
        }
    }
}
