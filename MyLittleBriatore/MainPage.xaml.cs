using System;
using System.Collections;
using System.Collections.Generic;
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

// Il modello di elemento per la pagina vuota è documentato all'indirizzo http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace MyLittleBriatore
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                image.Visibility = Visibility.Visible;
                ComboBoxItem selezionato = (ComboBoxItem)comboBox_bibite.SelectedItem;
                string lettura = selezionato.Content.ToString();
                string[] splitted = lettura.Split('-');
                splitted[1] = splitted[1].Replace('€', ' ');
                splitted[1] = splitted[1].Trim();
                int costa = Int32.Parse(splitted[1]);
                int qnt = Int32.Parse(textBox_bibite.Text);
                Sommatoria.somma = Sommatoria.somma + (qnt * costa);
                listBox_riepilogo.Items.Add(textBox_bibite.Text + "x \t" + selezionato.Content);
                await Task.Delay(TimeSpan.FromSeconds(0.1));
                image.Visibility = Visibility.Collapsed;
            }
            catch (Exception)
            {

                
            }
           
        }

        private async void button_Stuzzicheria_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                image.Visibility = Visibility.Visible;
                ComboBoxItem selezionato = (ComboBoxItem)comboBox_Stuzzicheria.SelectedItem;
                string lettura = selezionato.Content.ToString();
                string[] splitted = lettura.Split('-');
                splitted[1] = splitted[1].Replace('€', ' ');
                splitted[1] = splitted[1].Trim();
                int costa = Int32.Parse(splitted[1]);
                int qnt = Int32.Parse(textBox_Stuzzicheria.Text);
                Sommatoria.somma = Sommatoria.somma + (qnt * costa);
                listBox_riepilogo.Items.Add(textBox_Stuzzicheria.Text + "x \t" + selezionato.Content);
                await Task.Delay(TimeSpan.FromSeconds(0.1));
                image.Visibility = Visibility.Collapsed;
            }
            catch (Exception)
            {

            }

        }

        private async void button_Caffetteria_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                image.Visibility = Visibility.Visible;
                ComboBoxItem selezionato = (ComboBoxItem)comboBox_Caffetteria.SelectedItem;
                string lettura = selezionato.Content.ToString();
                string[] splitted = lettura.Split('-');
                splitted[1] = splitted[1].Replace('€', ' ');
                splitted[1] = splitted[1].Trim();
                int costa = Int32.Parse(splitted[1]);
                int qnt = Int32.Parse(textBox_Caffetteria.Text);
                Sommatoria.somma = Sommatoria.somma + (qnt * costa);
                listBox_riepilogo.Items.Add(textBox_Caffetteria.Text + "x \t" + selezionato.Content);
                await Task.Delay(TimeSpan.FromSeconds(0.1));
                image.Visibility = Visibility.Collapsed;
            }
            catch (Exception)
            {

              
            }

        }

        private async void button_Super_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                image.Visibility = Visibility.Visible;
                ComboBoxItem selezionato = (ComboBoxItem)comboBox_Super.SelectedItem;
                string lettura = selezionato.Content.ToString();
                string[] splitted = lettura.Split('-');
                splitted[1] = splitted[1].Replace('€', ' ');
                splitted[1] = splitted[1].Trim();
                int costa = Int32.Parse(splitted[1]);
                int qnt = Int32.Parse(textBox_Super.Text);
                Sommatoria.somma = Sommatoria.somma + (qnt * costa);
                listBox_riepilogo.Items.Add(textBox_Super.Text + "x \t" + selezionato.Content);
                await Task.Delay(TimeSpan.FromSeconds(0.1));
                image.Visibility = Visibility.Collapsed;
            }
            catch (Exception)
            {

           
            }

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            ArrayList passaValore = new ArrayList();
            for (int i = 0; i < listBox_riepilogo.Items.Count; i++)
            {
                var temp = listBox_riepilogo.Items[i];
                passaValore.Add(temp);
            }

            Frame.Navigate(typeof(ConfermaOrdine), passaValore);
        }
    }
}
