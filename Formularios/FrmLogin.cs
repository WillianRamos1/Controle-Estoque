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



namespace CapaApresentacao
{
    public partial class FrmLogin : Form
    {

        SqlConnection conectar = new SqlConnection();
        SqlCommand conectando = new SqlCommand();

        public FrmLogin()
        {
            InitializeComponent();
            conectar.ConnectionString = @"Data Source=DESKTOP-79R9K1O\SQLEXPRESS;Initial Catalog=ESTOQUE_PRODUTOS;Integrated Security=True";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            conectar.Open();
            conectando.Connection = conectar;
            conectando.CommandText = "SELECT * FROM AUTENTICACAO";
            SqlDataReader dr = conectando.ExecuteReader();
            if (dr.Read())
            {

                if (txtUsuario.Text.Equals(dr["usuario"].ToString()) && txtSenha.Text.Equals(dr["password"].ToString()))
                {

                    MessageBox.Show("Login feito com sucesso");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Verifique os dados digitado");
            }
            conectar.Close();
        }
                
        }
    }
