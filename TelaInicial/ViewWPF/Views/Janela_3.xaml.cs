using ClassLibrary1;
using Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ViewWPF.Views
{
    /// <summary>
    /// Lógica interna para Janela_3.xaml
    /// </summary>
    public partial class Janela_3 : Window
    {
        public Janela_3()
        {
            InitializeComponent();
        }

        private void cancela_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegistrarNovo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UsuarioController cont = new UsuarioController();
                IEnumerable<TextBox> txts = this.gridComponentes.Children.OfType<TextBox>();

                foreach (var textos in txts)
                {
                    if (textos.Equals(null))
                    {
                        throw new NullReferenceException("Todos os Campos são obrigatorios!");
                    }
                }
                UsuariosModelo usuario = new UsuariosModelo();

                usuario.Usuario = RegistrarLogin.Text;
                usuario.Senha = senha.Password;

                cont.Adicionar(usuario);

                MessageBox.Show("Usuário salvo com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar (" + ex.Message + ")");
            }
            this.Close();
        }
    }
}