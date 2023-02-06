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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string xOrO = "X";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == "b10")
            {
                End();
            }
            else
            {
                (sender as Button).Content = xOrO;
                (sender as Button).IsEnabled = false;
                if (Winner())
                {
                    return;
                }
                Robot();
            }

        }

        private void Robot()
        {
            Button[] buttons = new Button[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            Random r = new Random();
            int jopa;
            do
            {
                jopa = r.Next(0, 9);
            } while (!(buttons[jopa].Content == "" || buttons[jopa].Content == null));
            if (xOrO == "X")
            {
            buttons[jopa].Content = "O";
            }
            else
            {
            buttons[jopa].Content = "X";
            }
            buttons[jopa].IsEnabled = false;
            if (Winner())
            {
                return;
            }
        }

        private bool Winner()
        {
            Button[] buttons = new Button[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            string[] lines = new string[]
            {
                b1.Content.ToString() + b2.Content.ToString() + b3.Content.ToString(),
                b4.Content.ToString() + b5.Content.ToString() + b6.Content.ToString(),
                b7.Content.ToString() + b8.Content.ToString() + b9.Content.ToString(),
                b1.Content.ToString() + b4.Content.ToString() + b7.Content.ToString(),
                b2.Content.ToString() + b5.Content.ToString() + b8.Content.ToString(),
                b3.Content.ToString() + b6.Content.ToString() + b9.Content.ToString(),
                b1.Content.ToString() + b5.Content.ToString() + b9.Content.ToString(),
                b3.Content.ToString() + b5.Content.ToString() + b7.Content.ToString()
            };

            foreach (var line in lines)
            {
                if (line == "XXX")
                {
                    MessageBox.Show("ХРОМОСОМА ВЫЙГРАЛА");
                    End();
                    return true;
                }
                else if (line == "OOO")
                {
                    MessageBox.Show("НОЛИК ВЫЙГРАЛ");
                    End();
                    return true;
                }
            }
            if (!buttons.Any(b => b.Content == "" || b.Content == null))
            {
                MessageBox.Show("ЗАЧЕМ ИГРАТЬ В ТАКИЕ ИГРЫ");
                End();
                return true;
            }
            return false;
        }

        private void End()
        {
            b1.Content = "";
            b1.IsEnabled = true;
            b2.Content = "";
            b2.IsEnabled = true;
            b3.Content = "";
            b3.IsEnabled = true;
            b4.Content = "";
            b4.IsEnabled = true;
            b5.Content = "";
            b5.IsEnabled = true;
            b6.Content = "";
            b6.IsEnabled = true;
            b7.Content = "";
            b7.IsEnabled = true;
            b8.Content = "";
            b8.IsEnabled = true;
            b9.Content = "";
            b9.IsEnabled = true;

            if (xOrO == "X")
            {
                xOrO = "O";
            }
            else
            {
                xOrO = "X";
            }

        }
    }
}
/*
Крестики нолики, две БЛЯДИНЫ в домике
Укатились даже шарики за ролики
ЖОПА-ЖОПА ПЕНИС ЧЛЕН, разгоняя ШЛЮШКИ
Люди обзываются, что мы две РУКОБЛУДКИ
Отпути, не путю, но кому я ХУЙ ДРОЧУ
Не путю ведь я люблю свою лучшую ЗАЛУПУ
РКОБЛЮД ПЕНИС ХЕР, ЖОПА ШЛЮХА МАЛОФЬЯ, но кому я говорю
Не путю, ведь я люблю, навсегда мы друг для друга
ГОВНО, ГОВНО, ГОВНО, ГОВНО, ХУЙ ХУЙ ХУЙ ХУЙ ХУЙ ХУЙ 

Эники-беники, в ЖОПЕ и на телеке
Мы ГОВНО доводим топы до истерики
РУКАБЛУД ВЛАГАЛИЩЕ,РУКАБЛУД МАШОНКА
Люди обзываются, ХУЙ ГАЛОВКА
Отпути, не путю, но кому я ХУЙ ДРОЧУ
Не путю ведь я люблю свою лучшую ЗАЛУПУ
РКОБЛЮД ПЕНИС ХЕР, ЖОПА ШЛЮХА МАЛОФЬЯ, но кому я говорю 
Не путю, ведь я люблю, навсегда мы друг для друга
ЯЛДА, ЯЛДА,ЯЛДА,ЯЛДА,ЯЛДА,ЯЛДААААААААААААА, ЧЛЕН, ЧЛЕН,ЧЛЕН,ЧЛЕН,ЧЛЕН
У нас с тобой свой ПЕРДУН
Нам не надо ПЕНИС ХЕР
Повсюду за мной везде 
Моя лучшая подруга
МАНДА МАНДА МАНДА МАНДААААА
РАУНД*/