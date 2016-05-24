using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// Il modello di elemento Pagina vuota è documentato all'indirizzo http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyLittleBriatore
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class ConfermaOrdine : Page
    {
        public ConfermaOrdine()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            textBlock_Totale.Text =  Sommatoria.somma.ToString() + " €";

            // ListBox ciao = (ListBox)e.Parameter;
            ArrayList scarica = new ArrayList();
            scarica = (ArrayList)e.Parameter;

            for (int i = 0; i < scarica.Count; i++)
            {
                try
                {
                    listBox.Items.Add(scarica[i]);
                }
                catch (Exception)
                {

                    //spaghetti code extreme make edition
                }
               
            }
            
        }

        private void button_Indietro_Click(object sender, RoutedEventArgs e)
        {
            Sommatoria.somma = 0;
            Frame.GoBack();
        }

        private async void button_Indietro_Copy_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Ok! Briatore Approved", "Ok");
            await dialog.ShowAsync();
        }
    }
}
