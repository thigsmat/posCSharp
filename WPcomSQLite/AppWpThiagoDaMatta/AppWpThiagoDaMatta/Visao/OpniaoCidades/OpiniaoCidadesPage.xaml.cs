using AppWpThiagoDaMatta.Controlador;
using AppWpThiagoDaMatta.Controller;
using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AppWpThiagoDaMatta.Visao.OpniaoCidades
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OpiniaoCidadesPage : Page
    {
        public CidadesVisitadas Cidade { get; set; }
        private ObservableCollection<OpiniaoCidades> DB_OpiniaoList = new ObservableCollection<OpiniaoCidades>();

        public OpiniaoCidadesPage()
        {
            this.InitializeComponent();
            this.Loaded += ReadOpiniaoList_Loaded;
        }

        private void ReadOpiniaoList_Loaded(object sender, RoutedEventArgs e)
        {
            if (Cidade != null)
            {
                DB_OpiniaoList = new OpiniaoCidadesControlador().ListaTodosPorCidade(Cidade.Id);
                listBoxobj.ItemsSource = DB_OpiniaoList.OrderByDescending(i => i.Id).ToList();
            }
        }

        private void listBoxobj_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxobj.SelectedIndex != -1)
            {
                var opniao = listBoxobj.SelectedItem as OpiniaoCidades;//Get slected listbox item Pessoa ID

                List<IDados> dadosParametros = new List<IDados>();
                dadosParametros.Add(Cidade);
                dadosParametros.Add(opniao);
                Frame.Navigate(typeof(AddOpiniao), dadosParametros);
            }
        }

        private async void AdicionarOpiniaoButton_Click(object sender,
          RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddOpiniao), Cidade);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                Cidade = e.Parameter as CidadesVisitadas;
                CidadeTextBox.Text = Cidade.Nome;
                WebViewCidades.Source = new Uri("https://www.google.com.br/maps?q="+ Cidade.Nome);
            }
        }

        private void VoltarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
