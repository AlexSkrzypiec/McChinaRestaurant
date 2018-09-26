using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace ViewWPF.Views
{
    /// <summary>
    /// Lógica interna para Janela_2.xaml
    /// </summary>
    public partial class Janela_2 : Window
    {
        public Janela_2()
        {
            InitializeComponent();
        }

        private void cancela_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void entrar_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B9FOF0O;Initial Catalog=McChinaBD;Integrated Security=True");   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Usuarios WHERE Usuario='" + login.Text + "' AND Senha='" + senha.Password + "'", con);
            
            DataTable dt = new DataTable();   
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
               
                Janela_1 janela1 = new Janela_1();
                janela1.Show();
                this.Hide();
              
            }   
            else

                MessageBox.Show("Usuário ou senha inválidos");
        }
    }
}
