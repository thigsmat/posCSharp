using AppWpThiagoDaMatta.Contexto;
using AppWpThiagoDaMatta.Controller;
using AppWpThiagoDaMatta.Model;
using AppWpThiagoDaMatta.Visao.CidadesVisistadas;
using AppWpThiagoDaMatta.Visao.OpniaoCidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppWpThiagoDaMatta
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<CidadesVisitadas> DB_CidadeList = new ObservableCollection<CidadesVisitadas>();

        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += ReadCidadeList_Loaded;
        }

        private async void ReadCidadeList_Loaded(object sender, RoutedEventArgs e)
        {
            DB_CidadeList = await new CidadesVisitadasControlador().ListaTodos();
            if (DB_CidadeList.Count > 0)
            {
                ExcluirCidadeButton.IsEnabled = true;
            }
            listBoxobj.ItemsSource = DB_CidadeList.OrderByDescending(i => i.Id).ToList();
        }

        private void listBoxobj_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxobj.SelectedIndex != -1)
            {
                var listitem = listBoxobj.SelectedItem as CidadesVisitadas;//Get slected listbox item Pessoa ID
                Frame.Navigate(typeof(OpiniaoCidadesPage), listitem);
            }
        }

        private void AdicionarCidadeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Visao.CidadesVisistadas.Add));
        }

        private async void ExcluirCidadeButton_Click(object sender, RoutedEventArgs e)
        {
            await new CidadesVisitadasControlador().ExcluirTodasCidades();
        }
    }
}
