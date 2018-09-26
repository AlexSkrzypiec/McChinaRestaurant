using Controllers;
using Modelos;
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
            Contexto contexto = new Contexto();
            InitializeComponent();
        }

        private void cancela_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
        private void RegistrarNovo_Click(object sender, RoutedEventArgs e)
        {

            Usuarios usuario = new Usuarios();

            usuario.Usuario = RegistrarLogin.Text;
            usuario.Senha = senha.Password;

            UsuarioController UsuarioController = new UsuarioController();

            UsuarioController.Adicionar(usuario);

        }
    }
}