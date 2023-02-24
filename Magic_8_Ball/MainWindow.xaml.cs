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
using System.Windows.Threading;

namespace Magic_8_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //stores question type choice box's index
        int questionTypeSelection = -1;
        Random random = new Random();
        Answers answer;
        DispatcherTimer localDispatch = new DispatcherTimer();

        /// <summary>
        /// initializes the window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            FillComboBox();
            answer = new Answers();
        }

        public object Window { get; private set; }

        /// <summary>
        /// Populates the combo box
        /// </summary>
        private void FillComboBox()
        {
            QuestionTypeComboBox.Items.Add("Yes/No/Maybe");
            QuestionTypeComboBox.Items.Add("Open Ended");
        }

        /// <summary>
        /// Accesses the class with the text and gets the answer needed to populate the answer text block
        /// </summary>
        /// <param name="questionType"></param>
        /// <param name="randomNumber"></param>
        /// <returns></returns>
        private string GetAnswer(int questionType, int randomNumber)
        {
            string answerString = "";
            answerString = answer.GetAnswer(randomNumber, questionType);
            return answerString;
        }

        /// <summary>
        /// rolls the 8 ball, shakes screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShakeErUpButton_Click(object sender, RoutedEventArgs e)
        {
            //ShakeWindow();
            int num = random.Next(0, 8);
            questionTypeSelection = QuestionTypeComboBox.SelectedIndex;
            string check = GetAnswer(questionTypeSelection, num);

            //if (check == "I haven't got a clue, actually.")
            //{
            //    //bounce application right until it goes off the screen
            //
            //}

            AnswerTxtBlock.Text = check;
        }

        /// <summary>
        /// shakes the window for the 8 ball app
        /// </summary>
        private void ShakeWindow()
        {
           
        }

        /// <summary>
        /// Exits application
        /// </summary>
        private void Quit()
        {

        }
    }
}
