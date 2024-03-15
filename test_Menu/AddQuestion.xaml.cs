using System;
using System.Collections.Generic;
using System.IO;
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

namespace test_Menu
{
    /// <summary>
    /// Logika interakcji dla klasy AddQuestion.xaml
    /// </summary>
    public partial class AddQuestion : Window
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void AddingQuestButton_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter WritingStream = new StreamWriter("../../../questionsForTest.txt", true);
            if (ansNo.IsChecked == true)
            {
                WritingStream.WriteLine(newQuestField.Text);
                WritingStream.WriteLine("nie");
            }
            if(ansYes.IsChecked == true)
            {
                WritingStream.WriteLine(newQuestField.Text);
                WritingStream.WriteLine("tak");
            }
            WritingStream.WriteLine();
            WritingStream.Close();


        }

    }
}
