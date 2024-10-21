using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VerificaGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Biblioteca biblioteca = new Biblioteca("malatesta", "Cesena", "10:00", "18:00");
        }


        private void CreaLibro_Click(object sender, RoutedEventArgs e)
        {
            
            Libro libro = new Libro(Titolo.Text, Autore.Text, Pubblicazione.Text, Editore.Text, Pagine.Text);
            AddLibro(libro);
        }

        private void VerificaTitolo_Click(object sender, RoutedEventArgs e)
        {
            if (FindByTitle(Titolo.Text))
            {
                Result.Text = "Presente";
            }
            else
            {
                Result.Text = "Non Presente";
            }
        }

        private void RicercaAutore_Click(object sender, RoutedEventArgs e)
        {
            Result_Copia.Text = FindByAuthor(Autore.Text);
        }

        private void VerificaLibri_Click(object sender, RoutedEventArgs e)
        {
            Reult_Copia1.Text = Count().ToString();
        }
    }
}