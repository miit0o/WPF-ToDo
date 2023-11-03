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

namespace WPF_ToDo
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
  
    public partial class MainWindow : Window
    {
        // Define Elements
        static TextBox addBoxElement;
        static ListBox taskBoxElement;
        static Button addBtnElement;
        static Button remBtnElement;

        public MainWindow()
        {
            InitializeComponent();

            //Initialize Elements
            addBoxElement = (TextBox)FindName("addTaskBox");
            addBoxElement.Clear();
            taskBoxElement = (ListBox)FindName("allTaskBox");
            addBtnElement = (Button)FindName("addBtn");
            remBtnElement = (Button)FindName("remBtn");
        }

        public void addTask()
        {
            taskBoxElement.Items.Add(addBoxElement.Text);
            addBoxElement.Clear();
        }

        public void remTask()
        {
            taskBoxElement.Items.Remove(taskBoxElement.SelectedItem);
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            addTask();
        }

        private void remBtn_Click(object sender, RoutedEventArgs e)
        {
            remTask();
        }

        private void addTaskBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                addTask();
            }
        }

        private void allTaskBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete || e.Key == Key.Back)
            {
                remTask();
            }
        }
    }
}
