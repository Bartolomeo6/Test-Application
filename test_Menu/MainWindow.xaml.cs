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

namespace test_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnteringTheTest(object sender, RoutedEventArgs e)
        {
            Window testPanel = new TestWindow();
            testPanel.ShowDialog();
        }

        private void AddTheNewQuestion(object sender, RoutedEventArgs e)
        {
            Window questionPanel = new AddQuestion();
            //questionPanel.Show(); <-- zazwyczaj niemodalne, pozwala na dzialanie w poprzednim oknie
            questionPanel.ShowDialog(); // <-- zazwyczaj modalne, przeciwieństwo /\/\/\
        }
    }
}
