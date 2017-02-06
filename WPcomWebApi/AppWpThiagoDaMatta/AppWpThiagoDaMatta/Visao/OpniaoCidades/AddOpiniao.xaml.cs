using AppWpThiagoDaMatta.Controlador;
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

namespace AppWpThiagoDaMatta.Visao.OpniaoCidades
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddOpiniao : Page
    {
        public CidadesVisitadas Cidade { get; set; }
        public OpiniaoCidades Opiniao { get; set; }
        public AddOpiniao()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                if (e.Parameter is CidadesVisitadas)
                {
                    Cidade = e.Parameter as CidadesVisitadas;
                    Opiniao = new OpiniaoCidades();
                }
                else
                {
                    List<IDados> list = (List<IDados>)e.Parameter;
                    foreach (var item in list)
                    {
                        if (item is CidadesVisitadas)
                            Cidade = item as CidadesVisitadas;

                        if (item is OpiniaoCidades)
                            Opiniao = item as OpiniaoCidades;
                    }
                    OpiniaoTextBox.Text = Opiniao.Opiniao;
                }
            }
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OpiniaoCidadesPage), Cidade);
        }

        private async void AdicionarButton_Click(object sender,
         RoutedEventArgs e)
        {
            if (OpiniaoTextBox.Text !="" )
            {
                Opiniao.IdCidade = Cidade.Id;
                Opiniao.Opiniao = OpiniaoTextBox.Text.Trim();
                await new OpiniaoCidadesControlador().Salvar(Opiniao);
                Frame.Navigate(typeof(OpiniaoCidadesPage), Cidade);
            }
            else
            {
                var messageDialog = new MessageDialog
                    ("Prencher os campos");
                await messageDialog.ShowAsync();
            }
        }

        
    }
}
