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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            // создает список из 8 пар эмодзи
            {
               "♥", "♥",
               "👍", "👍",
               "😁", "😁",
               "🤷", "🤷",
               "👏", "👏",
               "😉", "😉",
               "😘", "😘",
               "🎉", "🎉",
            };
            Random random = new Random();
            // создает новый генератор случайных чисел

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            // находит каждый элемент TextBlock в сетке и повторяет следующие команды для каждого элемента
            {
                int index = random.Next(animalEmoji.Count);
                // выбирает случайное число от 0 до количества эмодзи в списке и назначает ему индекс "index"

                string nextEmoji = animalEmoji[index];
                // использует случайное число с именем "index" для получения случайного эмодзи из списка

                textBlock.Text = nextEmoji;
                // обновляет TextBlock случайным эмодзи из списка

                animalEmoji.RemoveAt(index);
                // удаляет случайный эмодзи из списка
            };
        }
    }
}
