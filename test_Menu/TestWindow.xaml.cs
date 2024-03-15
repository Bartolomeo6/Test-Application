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
    /// Logika interakcji dla klasy TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        List<Question> ListOfQuestions { get; set; }
        public int Counter { get; set; }
        public int Points { get; set; }
        public TestWindow()
        {
            InitializeComponent();
            prepareSomeQuestions();
            showTheQuestion(0);
        }

        private void showTheQuestion(int i)
        {
            questionNameBlock.Text = ListOfQuestions[i].Sentence;
        }

        private void prepareSomeQuestions()
        {
            ListOfQuestions = new List<Question>();
            StreamReader streamReader = new StreamReader("questionsForTest.txt"); // odczytywanie pliku w C# przez dodanie właściwości "ZAWSZE KOPIUJ" po kliknięciu na plik notatnika
            string ask = streamReader.ReadLine();
            string ans = streamReader.ReadLine();

            while(ask != null)
            {
                if(ans == "tak")
                    ListOfQuestions.Add(new Question(ask, true));
                else
                    ListOfQuestions.Add(new Question(ask, false));
                ask = streamReader.ReadLine();
                ans = streamReader.ReadLine();
            }
            streamReader.Close(); // PAMIĘTAĆ O ZAMYKANIU!
        }

        

        private void AnswerButtonYes(object sender, RoutedEventArgs e)
        {
            ButtonOperation(true);
        }

        private void AnswerButtonNo(object sender, RoutedEventArgs e)
        {
            ButtonOperation(false);
        }

        private void ButtonOperation (bool ans)
        {
            checkTheAnswer(ans, Counter);
            Counter++;

            if (Counter == ListOfQuestions.Count())
            {
                MessageBox.Show("Zakończyłeś test, Twoje punkty: " + Points);
                Close();
            }
            else
            {
                showTheQuestion(Counter);
            }

        }

        private void checkTheAnswer(bool ans, int idQuest)
        {
            if(ans == ListOfQuestions[Counter].Answer)
            {
                Points++;
            }
        }


    }
}
