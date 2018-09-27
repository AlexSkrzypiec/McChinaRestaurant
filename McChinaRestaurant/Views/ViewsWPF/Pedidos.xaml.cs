using Modelo;
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

namespace Views.ViewsWPF
{
    /// <summary>
    /// Lógica interna para Pedidos.xaml
    /// </summary>
    public partial class Pedidos : Window
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            Pedido ped = new Pedido();

            ped.NomePedido = NomeCampo.Text;
            ped.DataPedido = DataCampo.Text;
            ped.TipoPedido = TipoPedido.Text;

            PedidoController pednovo = new PedidoController();

            pednovo.Adicionar(ped);

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SairButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
