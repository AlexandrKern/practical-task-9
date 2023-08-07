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
using System.Drawing;
using System.Reflection.Emit;


namespace practical_task_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            string[] arrayOfWords = textBox.Text.Split(' ');
            foreach (string word in arrayOfWords) listBox.Items.Add(word);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            listBox.Items.Clear();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string[] arrayOfWords = textBox1.Text.Split(' ');
            string textLabel = null;
            for (int i = arrayOfWords.Length - 1; i >= 0; i--)
                textLabel += $"{arrayOfWords[i]} {" "}";
            textBlok.Text = textLabel;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBlok.Text = null;
        }
    }
}