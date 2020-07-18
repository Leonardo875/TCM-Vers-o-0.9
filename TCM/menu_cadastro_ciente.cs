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
    public partial class menu_cadastro_ciente : Form
    {
        public menu_cadastro_ciente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-3RHEA9C\SQLEXPRESS;integrated security=SSPI;initial Catalog=bd_horizon");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dados;

        private void menu_consulta_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "Nº do Passaporte")
            {
                MessageBox.Show("É Necessário Informar o Nº do Passaporte", "!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox1.Text == "Nome Completo")
            {
                MessageBox.Show("É Necessário Informar o seu Nome", "!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox4.Text == "CEP")
            {
                MessageBox.Show("É Necessário Informar o seu CEP", "!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox5.Text == "CPF(Só numéros)")
            {
                MessageBox.Show("É Necessário Informar o CPF", "!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
            else if (textBox8.Text == "Pais de Origem")
            {
                MessageBox.Show("É Necessário Informar o seu Pais de Origem", "!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox9.Text == "Data de Nascimento")
            {
                MessageBox.Show("É Necessário Informar a sua Data de nascimento", "!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (! radioButton1.Checked && ! radioButton2.Checked)
            {
                MessageBox.Show("É Necessário Informar o seu Sexo", "!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string passaport = textBox2.Text;
                string nome = textBox1.Text;
                string cpf = textBox5.Text;
                string cep = textBox4.Text;
                string pais = textBox8.Text;
                string nasc = textBox9.Text;
                string ddd = textBox10.Text;
                string tel = textBox7.Text;
                char sexo;

                if (radioButton1.Checked)
                {
                    sexo = 'F';
                }
                else
                {
                    sexo = 'M';
                }
                if (textBox5.Text == "DDD" || textBox7.Text == "nº Telefone")
                {
                    if(textBox5.Text == "DDD" || textBox7.Text == "nº Telefone")
                    {
                        ddd = null;
                        tel = null;

                    }
                    else if (textBox5.Text == "DDD")
                    {
                        ddd = null;
                    }
                    else
                    {
                        tel = null;
                    }
                }

                try
                {
                    cn.Open();
                    cmd.CommandText = "insert into tbl_cliente(no_passaport,nm_cliente,sg_sexo,no_cpf,no_cep,pais_orig,dt_nasc,ddd_tel,tel_cliente)values('" +
                        passaport + "','" + nome + "','" + sexo + "','" + cpf + "','" + cep + "','" + pais + "','" + nasc + "','" + ddd + "','" + tel + "')";

                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados inseridos com sucesso", "Gravação Concluida", MessageBoxButtons.OK);

                    cn.Close();


                    this.Hide();
                    menu_cadastro_destino fm3 = new menu_cadastro_destino();
                    fm3.Show();
                    
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
            DialogResult result = MessageBox.Show("Tem certeza que quê Cancelar?", "???",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(result == System.Windows.Forms.DialogResult.Yes){
                this.Hide();
                menu_cadastro mncadastro = new menu_cadastro();
                mncadastro.Show();
            }
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
            consulta fm4 = new consulta();
            fm4.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Nome Completo")
            {
                textBox1.Text = "";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "CPF(Só numéros)")
            {
                textBox5.Text = "";
            }

        }

        private void textBox11_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "CEP")
            {
                textBox4.Text = "";
            }

        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Pais de Origem")
            {
                textBox8.Text = "";
            }

        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Data de Nascimento")
            {
                textBox9.Text = "";
            }

        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "DDD")
            {
                textBox10.Text = "";
            }

        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "nº Telefone")
            {
                textBox7.Text = "";
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Nome Completo";
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "CPF(Só numéros)";
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "CEP";
            }

        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Pais de Origem";
            }

        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Data de Nascimento";
            }

        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "DDD";
            }

        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "nº Telefone";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nome Completo";
            textBox2.Text = "Nº do Passaporte";
            textBox4.Text = "CEP";
            textBox5.Text = "CPF(Só numéros)";
            textBox7.Text = "nº Telefone";
            textBox8.Text = "Pais de Origem";
            textBox9.Text = "Data de Nascimento";
            textBox10.Text = "DDD";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            agendamento fm5 = new agendamento();
            fm5.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro mncada = new menu_cadastro();
            mncada.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagamento mnpaga = new pagamento();
            mnpaga.Show();

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Nº do Passaporte")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Nº do Passaporte";
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;

        }
    }
}
