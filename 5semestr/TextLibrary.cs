using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5semestr
{
    class TestLibrary
    {
        public static string[] Title =
        {
            "Вопрос 1",
            "Вопрос 2",
            "Вопрос 3",
            "Вопрос 4",
            "Вопрос 5",
            "Вопрос 6",
            "Вопрос 7",
            "Вопрос 8",
            "Вопрос 9",
            "Вопрос 10"
        };
        public static Image[] Question =
        {
            Properties.Resources.Test1,
            Properties.Resources.Test2,
            Properties.Resources.Test3,
            Properties.Resources.Test4,
            Properties.Resources.Test5,
            Properties.Resources.Test6,
            Properties.Resources.Test7,
            Properties.Resources.Test8,
            Properties.Resources.Test9,
            Properties.Resources.Test10
        };
        public static string[] Answer = {"4", "2", "2", "4", "0", "8 8 9", "13 7 10 7", "17 16 16 5", "19 16 2", "2 5 7" };
    }
    class TheoryLibrary
    {
        public static string[] Title = {
            //1
            "Динамическое программирование",
            //2
            "Динамическое программирование",
            //3
            "Задачи динамического программирования",
            //4
            "Задача о дилижансе",
            //5
            "Задача о дилижансе",
            //6
            "Алгоритм решения задачи о дилижансе",
            //7
            "Алгоритм решения задачи о дилижансе",
            //8
            "Алгоритм решения задачи о дилижансе"
        };

        public static Image[] Paragraph = {
            Properties.Resources.Theory1,
            Properties.Resources.Theory2,
            Properties.Resources.Theory3,
            Properties.Resources.Theory4,
            Properties.Resources.Theory5,
            Properties.Resources.Theory6,
            Properties.Resources.Theory7,
            Properties.Resources.Theory8
        };
       
    }
    class ExampleLibrary
    {
        public static Image[] Paragraph = {
            Properties.Resources.Example1,
            Properties.Resources.Example2,
            Properties.Resources.Example3,
            Properties.Resources.Example5,
            Properties.Resources.Example6
        };
        public static string[] Title = {
            //1
            "Условие задачи",
            //2
            "Разделение на этапы",
            //3
            "Алгоритм обратной прогонки",
            //4
            "Алгоритм обратной прогонки",
            //5
            "Алгоритм прямой прогонки"
        };
    }
}
