using AppWpThiagoDaMatta.Controller;
using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppWpThiagoDaMatta.Visao.CidadesVisistadas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Add : Page
    {
        public Add()
        {
            this.InitializeComponent();
        }

        private async void AdicionarButton_Click(object sender,
          RoutedEventArgs e)
        {
            if (NomeTextBox.Text != "")
            {
                new CidadesVisitadasControlador().Salvar(new CidadesVisitadas() {
                    Nome=NomeTextBox.Text
                });
                Frame.Navigate(typeof(MainPage));
            }
            else
            {
                MessageDialog messageDialog = new MessageDialog
                    ("Prencher os campos");
                await messageDialog.ShowAsync();
            }
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
