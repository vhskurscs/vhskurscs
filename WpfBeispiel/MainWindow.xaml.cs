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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBeispiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rechteck rechteck;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SeiteATextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(SeiteATextBox.Text))
            {
                rechteck.A = Convert.ToDouble(SeiteATextBox.Text);

                UmfangTextBox.Text = rechteck.Umfang().ToString();
                InhaltTextBox.Text = rechteck.Flaecheninhalt().ToString();
            }
        }

        private void SeiteBTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SeiteBTextBox.Text))
            {
                rechteck.B = Convert.ToDouble(SeiteBTextBox.Text);

                UmfangTextBox.Text = rechteck.Umfang().ToString();
                InhaltTextBox.Text = rechteck.Flaecheninhalt().ToString();
            }
        }

        private void BeendenButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rechteck = new Rechteck();
            rechteck.A = Convert.ToDouble(SeiteATextBox.Text);
            rechteck.B = Convert.ToDouble(SeiteBTextBox.Text);

            UmfangTextBox.Text = rechteck.Umfang().ToString();
            InhaltTextBox.Text = rechteck.Flaecheninhalt().ToString();
        }
    }
}
