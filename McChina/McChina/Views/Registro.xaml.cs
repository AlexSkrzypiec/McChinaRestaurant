using Modelos;
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
using Controllers;

namespace McChina
{
    /// <summary>
    /// Lógica interna para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void RegistrarNovo_Click(object sender, RoutedEventArgs e)
        {

            Usuario usuario = new Usuario();

            usuario.Login = RegistrarLogin.Text;
            usuario.Senha = senha.Password;

            UsuarioController UsuarioController = new UsuarioController();

            UsuarioController.Adicionar(usuario);

        }

        private void cancela_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
