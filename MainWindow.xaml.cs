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

namespace Smoplzick
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string s;
        string a;
        int key;
        string[] subs;
        string text;
        string shifr;
        const string alf = ("abcdefghijklmnopqrstuvwxyz");
        const string ralf = ("zyxwvutsrqponmlkjihgfedcba");
        const string alfR = ("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
        const string ralfR = ("яюэьыъщшчцхфутсрпонмлкйизжёедгвба");      
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            a = textBox_Copy.Text;
            try
            {
                a = textBox_Copy.Text;
                key = Convert.ToInt32(a);
                s = textBox.Text;
                subs = s.Split(' ');
                text = subs[2];
            }
            catch 
            {
                Console.WriteLine("Error.Вы ввели ключ неправильно");
            }
            var rfulalf1 = ralfR + ralfR.ToUpper();
            var fulalf1 = alfR + alfR.ToUpper();
            var rfulalf = ralf + ralf.ToUpper();
            var fulalf = alf + alf.ToUpper();
            try
            {
                for (int i = 0; i < subs[2].Length; i++)
                    for (int j = 0; j < fulalf.Length; j++)
                        if (text[i] == fulalf[j])
                        {
                            shifr = shifr + fulalf[(j + key) % fulalf.Length];
                        }
                shifr = shifr + "\n";
                for (int i = 0; i < subs[2].Length; i++)
                    for (int j = 0; j < rfulalf.Length; j++)
                        if (text[i] == rfulalf[j])
                        {
                            shifr = shifr + rfulalf[(j + key) % rfulalf.Length];
                        }
                for (int i = 0; i < subs[2].Length; i++)
                    for (int j = 0; j < fulalf1.Length; j++)
                        if (text[i] == fulalf1[j])
                        {
                            shifr = shifr + fulalf1[(j + key) % fulalf1.Length];
                        }
                shifr = shifr + "\n";
                for (int i = 0; i < subs[2].Length; i++)
                    for (int j = 0; j < rfulalf1.Length; j++)
                        if (text[i] == rfulalf1[j])
                        {
                            shifr = shifr + rfulalf1[(j + key) % rfulalf1.Length];
                        }
                MessageBox.Show(shifr);
                shifr = "";
            }
            catch
            {
                Console.WriteLine("Вы неправильно ввели");
                throw;
            }
        }
    }
}
