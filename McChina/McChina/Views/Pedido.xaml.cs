﻿using System;
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
using Modelos;

namespace McChina
{
    /// <summary>
    /// Lógica interna para Pedido.xaml
    /// </summary>
    public partial class Pedido : Window
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {


        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
           
            NomeCampo.Clear();
            DataCampo.Clear();
            TipoPedido.SelectedIndex = -1;


        }

        private void SairButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
