using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace UtitCalc
{
    
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Menu();
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Ты ввел хуйню дружище, наверное опять жмакнул Enter {0}", e);
            }

            Console.ReadLine();
        }

        //Составьте программы перевода старинных русских мер длины, торгового и аптекарского веса(счетчик цикла от 1 до 10)
        //* саженей в метры(1 сажень равна 2,1366 м)
        //* из дюймов в сантиметры(1 дюйм равен 2,5 см)
        //* футов в метры(1 фут равен 0,3048 м)
        //* драхм в граммы(1 драхма равна 3,7325 г)
        //* унций в граммы(1 унция равна 29,86 г)
        //* фунтов в килограммы(1 фунт равен 0,40951 кг)
        //* аршинов в метры(1 аршин равен 0,7112 м)
        //* золотников в граммы(1 золотник равен 4,2657 г)
        //* дюймов в миллиметры(1 дюйм равен 25,3995 мм)

        public static void Menu()
        {
            
            // Переменная с индексом позиции меню и счетчик
            short curItem = 0, c;
            // Объект для чтения кнопки
            ConsoleKeyInfo key;
            // Массив пунктов меню

            //string[] menuItems = { "Сажени", "Метры", "Дюймы", "Сантиметры", "Миллиметры", "Футы", "Аршины" };
            string[] menuItems = { "Сажени", "Метры", "Дюймы" };

            do
            {
                Console.Clear();
                Console.WriteLine("Что конвертируем? \n");

                //Логика отрисовки
                for (c = 0; c < menuItems.Length; c++)
                {
                    //если текущий элемент равен выбранному элементу, то добавляем звездочку
                    if (curItem == c)
                    {
                        Console.Write(" * ");
                        Console.WriteLine(menuItems[c]);
                    }
                    else if (key.Key.ToString() == "Enter")
                    {
                        //Console.Clear();
                        //Console.WriteLine(menuItems[c]);
                        SwitcherLogic(curItem);

                    }
                    //Выводим элемент, но без звездочки
                    else
                    {
                        Console.WriteLine(menuItems[c]);
                    }
                }

                //логика переключения
                key = Console.ReadKey(true);

                if (key.Key.ToString() == "DownArrow")
                {
                    curItem++;
                    //если текущий индекс больше чем длинна меню -1, то перевести курсор в начало
                    if (curItem == menuItems.Length) curItem = 0;
                }
                else if (key.Key.ToString() == "UpArrow")
                {
                    curItem--;
                    if (curItem < 0) curItem = Convert.ToInt16(menuItems.Length - 1);
                }
                // Выходим из цикла если юзер нажал Enter
            } 
            while (key.KeyChar != 13);
            Console.Clear();

            //how can i make it so if i press enter on one of these it will do a command like
        }

        //Логика выбора
        public static void SwitcherLogic(short curItem)
        {
            switch (curItem)
            {
                case 0:

                    Console.Clear();
                    SagenCalc();

                    break;

                case 1:
                    
                    Console.Clear();
                    MeterCalc();

                    break;
                
                case 2:

                    Console.Clear();
                    InchCalc();

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Это мы пока считать не умеем");
                    break;
            }
        }

        public static void SagenCalc()
        {

            UnitCalcLogic sagenCalc = new UnitCalcLogic();

            Console.WriteLine("Введи количество саженей и я тебе их посчитаю во всем сразу\n");

            Console.Clear();

            Console.WriteLine("Результат: \n");

            Console.WriteLine("Метрическая система \n");
            Console.WriteLine("Миллиметров: {0}", sagenCalc.sagenInMilimeter);
            Console.WriteLine("Сантиметров: {0}", sagenCalc.sagenInSantimeter);
            Console.WriteLine("Метров: {0}", sagenCalc.sagenInMeter);
            Console.WriteLine("Километров: {0}\n", sagenCalc.sagenInKilometer);

            Console.WriteLine("Империческая система \n");
            Console.WriteLine("Дюймов: {0}", sagenCalc.sagenInInch);
            Console.WriteLine("Футов: {0}", sagenCalc.sagenInFoot);
            Console.WriteLine("Ярдов: {0}", sagenCalc.sagenInYard);
            Console.WriteLine("Миль: {0}\n", sagenCalc.sagenInMile);

            Console.WriteLine("Старославянская система \n");
            Console.WriteLine("Вершков: {0}", sagenCalc.sagenInVershok);
            Console.WriteLine("Пядей: {0}", sagenCalc.sagenInPyad);
            Console.WriteLine("Аршинов: {0}", sagenCalc.sagenInArshin);
            Console.WriteLine("Верст: {0}", sagenCalc.sagenInVersta);

        }

        public static void MeterCalc()
        {

            UnitCalcLogic meterCalc = new UnitCalcLogic();

            Console.WriteLine("Введи количество метров и я тебе их посчитаю во всем сразу\n");

            Console.Clear();

            Console.WriteLine("Результат: \n");

            Console.WriteLine("Метрическая система \n");
            Console.WriteLine("Миллиметров: {0}", meterCalc.meterInMilimeter);
            Console.WriteLine("Сантиметров: {0}", meterCalc.meterInSantimeter);
            Console.WriteLine("Километров: {0}\n", meterCalc.meterInKilometer);

            Console.WriteLine("Империческая система \n");
            Console.WriteLine("Дюймов: {0}", meterCalc.meterInInch);
            Console.WriteLine("Футов: {0}", meterCalc.meterInFoot);
            Console.WriteLine("Ярдов: {0}", meterCalc.meterInYard);
            Console.WriteLine("Миль: {0}\n", meterCalc.meterInMile);

            Console.WriteLine("Старославянская система \n");
            Console.WriteLine("Вершков: {0}", meterCalc.meterInVershok);
            Console.WriteLine("Пядей: {0}", meterCalc.meterInPyad);
            Console.WriteLine("Аршинов: {0}", meterCalc.meterInArshin);
            Console.WriteLine("Верст: {0}", meterCalc.meterInVersta);
        }

        public static void InchCalc()
        {
            
            UnitCalcLogic inchCalc = new UnitCalcLogic();

            Console.WriteLine("Введи количество дюймов и я тебе их посчитаю во всем сразу\n");

            Console.Clear();

            Console.WriteLine("Результат: \n");

            //Console.WriteLine("Метрическая система \n");
            //Console.WriteLine("Миллиметров: {0}", meterCalc.meterInMilimeter);
            //Console.WriteLine("Сантиметров: {0}", meterCalc.meterInSantimeter);
            //Console.WriteLine("Километров: {0}\n", meterCalc.meterInKilometer);

            Console.WriteLine("Империческая система \n");
            Console.WriteLine("Футов: {0}", inchCalc.meterInFoot);
            Console.WriteLine("Ярдов: {0}", inchCalc.meterInYard);
            Console.WriteLine("Миль: {0}\n", inchCalc.meterInMile);

            //Console.WriteLine("Старославянская система \n");
            //Console.WriteLine("Вершков: {0}", meterCalc.meterInVershok);
            //Console.WriteLine("Пядей: {0}", meterCalc.meterInPyad);
            //Console.WriteLine("Аршинов: {0}", meterCalc.meterInArshin);
            //Console.WriteLine("Верст: {0}", meterCalc.meterInVersta);
        }
    }
}