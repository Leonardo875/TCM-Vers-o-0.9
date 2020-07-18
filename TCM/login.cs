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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-3RHEA9C\SQLEXPRESS;integrated security=SSPI;initial Catalog=bd_horizon");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dados;
        
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro_destino fm3 = new menu_cadastro_destino();
            fm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username" && textBox2.Text == "Password")
            {
                MessageBox.Show("obrigatório informar o campo usuário e senha !!", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                try
                {
                    cn.Open();
                    cmd.CommandText = "select * from tbl_funcionario where ds_Login = ('" + textBox1.Text + "') and senha_login = ('" + textBox2.Text + "')";
                    cmd.Connection = cn;
                    dados = cmd.ExecuteReader();

                    if (dados.HasRows)
                    {
                        menu tela = new menu();
                        tela.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha invalidos !!!");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }
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

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
