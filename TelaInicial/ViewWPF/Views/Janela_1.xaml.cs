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

namespace ViewWPF.Views
{
    /// <summary>
    /// Lógica interna para Janela_1.xaml
    /// </summary>
    public partial class Janela_1 : Window
    {
        public Janela_1()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.Ham1.IsChecked = this.Ham2.IsChecked = this.Ham3.IsChecked = this.Ham4.IsChecked = this.Ham5.IsChecked =
                this.Frie1.IsChecked = this.Frie2.IsChecked = this.Frie3.IsChecked = this.Frie4.IsChecked = this.Frie5.IsChecked =
                    this.Drin1.IsChecked = this.Drin2.IsChecked = this.Drin3.IsChecked = this.Drin4.IsChecked = this.Drin5.IsChecked =
                        this.deser1.IsChecked = this.deser2.IsChecked = this.deser3.IsChecked = this.deser4.IsChecked = this.deser5.IsChecked =
                            this.food1.IsChecked = this.food2.IsChecked = this.food3.IsChecked = this.food4.IsChecked = this.food5.IsChecked = false;

            NomeCampo.Clear();
            DataCampo.Clear();


        }

        private void SairButton_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }
    }
}
