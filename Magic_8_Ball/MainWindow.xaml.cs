l using System;
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

namespace Magic_8_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //stores question type choice box's index
        int questionTypeSelection = -1;

        /// <summary>
        /// initializes the window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// rolls the 8 ball, shakes screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShakeErUpButton_Click(object sender, RoutedEventArgs e)
        {
            ShakeWindow();

        }

        private void ShakeWindow()
        {

        }
    }
}
