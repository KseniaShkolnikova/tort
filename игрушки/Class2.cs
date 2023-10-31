using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace игрушки
{
    internal class Menu
    {
        public string asd;
        public string asf;
        public string asg;
        public string asj;
        public string ask;
        public string asr;
        public string asw;
        public string ase;
        public string asl;
        public string asx;
        public string ash;
        public string asv;
        public string asc;
        public string desc;
        
        private static List<string> der = new List<string>() { };
        static int snma = 0;

        public static int ocnovnoe(int position)
        {
            Menu menu = new Menu();
            menu.asd = " Заказ торта в кондитерской 'Шарпы',соберите свой торт сами! ";
            menu.asf = "Выберите состав торта";
            menu.asg = "-----------------------------------------------------------------";
            menu.asj = "  Форма торта";
            menu.ask = "  Размер торта";
            menu.asr = "  Вкус торта";
            menu.asw = "  Количество коржей";
            menu.ase = "  Декор";
            menu.asl = "  Глазурь";
            menu.asx = "  Конец заказа";
            menu.ash = "";
            menu.asv = "";
            menu.asc = "Цена: ";
            menu.desc = "Ваш торт: ";

            List<Menu> menuocnov = new List<Menu>();
            menuocnov.Add(menu);
            for (int i = 0; i < menuocnov.Count; i++)
            {
                Console.WriteLine(menuocnov[i].asd);
                Console.WriteLine(menuocnov[i].asf);
                Console.WriteLine(menuocnov[i].asg);
                Console.WriteLine(menuocnov[i].asj);
                Console.WriteLine(menuocnov[i].ask);
                Console.WriteLine(menuocnov[i].asr);
                Console.WriteLine(menuocnov[i].asw);
                Console.WriteLine(menuocnov[i].ase);
                Console.WriteLine(menuocnov[i].asl);
                Console.WriteLine(menuocnov[i].asx);
                Console.WriteLine(menuocnov[i].ash);
                Console.WriteLine(menuocnov[i].asv);
                Console.WriteLine(menuocnov[i].asc + snma);
                Console.Write(menuocnov[i].desc);
            }
            foreach (var item in der)
            {
                Console.Write(item + " ");
            }
            position = Str.strelka(3, 3, 9);
            return position;
        }
        public static int dop (int position)
        {
            Console.Clear();
            if (position == 3)
            {

                Menu menu = new Menu();
                menu.asd = "Выберите:";
                menu.asf = "  Круглый ------- 100";
                menu.asg = "  Квадратный ---- 50";
                menu.asj = "  Пятиугольник -- 500";
                List<Menu> menudop = new List<Menu>();
                menudop.Add(menu);
                for (int i = 0; i < menudop.Count; i++)
                {
                    Console.WriteLine(menudop[i].asd);
                    Console.WriteLine(menudop[i].asf);
                    Console.WriteLine(menudop[i].asg);
                    Console.WriteLine(menudop[i].asj);
                } 
                position = Str.strelk(1, 1, 3);
                if (position == 1)
                {
                    der.Add("круглый");
                    snma = snma + 100;          
                }
                else if (position == 2)
                {
                    der.Add("квадратный");
                    snma = snma + 50;
                }
                else if (position == 3)
                {
                    der.Add("пятиугольный");
                    snma = snma + 500;
                }
                else 
                {
                        ocnovnoe(position); 
                }
                Console.Clear();
            }
            else if (position == 4)
            {
                Menu menu = new Menu();
                menu.asd = "Выберите:";
                menu.asf = "  Большой -------- 200";
                menu.asg = "  Очень большой -- 500";
                menu.asj = "  Маленький ------ 100";
                List<Menu> menudop = new List<Menu>();
                menudop.Add(menu);
                for (int i = 0; i < menudop.Count; i++)
                {
                    Console.WriteLine(menudop[i].asd);
                    Console.WriteLine(menudop[i].asf);
                    Console.WriteLine(menudop[i].asg);
                    Console.WriteLine(menudop[i].asj);
                }
                position = Str.strelk(1, 1, 3);
                if (position == 1 )
                {
                    der.Add("большой");
                    snma = snma + 200;
                }
                else if (position == 2 )
                {
                    der.Add("очень большой");
                    snma = snma + 500;
                }
                else if (position == 3 )
                {
                    der.Add("маленький");
                    snma = snma + 100;
                }
                else 
                {
                    ocnovnoe(position);
                }
                Console.Clear();
            }
            else if (position == 5)
            {
                Menu menu = new Menu();
                menu.asd = "Выберите:";
                menu.asf = "  Клубничный --- 250";
                menu.asg = "  Шоколадный --- 300";
                menu.asj = "  Медовый ------ 500";
                List<Menu> menudop = new List<Menu>();
                menudop.Add(menu);
                for (int i = 0; i < menudop.Count; i++)
                {
                    Console.WriteLine(menudop[i].asd);
                    Console.WriteLine(menudop[i].asf);
                    Console.WriteLine(menudop[i].asg);
                    Console.WriteLine(menudop[i].asj);
                }
                position = Str.strelk(1, 1, 3);
                if (position == 1 )
                {
                    der.Add("клубничный");
                    snma = snma + 250;
                }
                else if (position == 2)
                {
                    der.Add("шоколадный");
                    snma = snma + 300;
                }
                else if (position == 3)
                {
                    der.Add("медовый");
                    snma = snma + 500;
                }
                else 
                {
                    ocnovnoe(position);
                }
                Console.Clear();
            }
            else if (position == 6)
            {
                Menu menu = new Menu();
                menu.asd = "Выберите:";
                menu.asf = "  3 --- 50";
                menu.asg = "  4 --- 100";
                menu.asj = "  5 --- 150";
                List<Menu> menudop = new List<Menu>();
                menudop.Add(menu);
                for (int i = 0; i < menudop.Count; i++)
                {
                    Console.WriteLine(menudop[i].asd);
                    Console.WriteLine(menudop[i].asf);
                    Console.WriteLine(menudop[i].asg);
                    Console.WriteLine(menudop[i].asj);
                }
                position = Str.strelk(1, 1, 3);
                if (position == 1 )
                {
                    der.Add("3 коржа");
                    snma = snma + 50;
                }
                else if (position == 2)
                {
                    der.Add("4 коржа");
                    snma = snma + 100;
                }
                else if (position == 3)
                {
                    der.Add("5 коржей");
                    snma = snma + 150;
                }
                else 
                {
                    ocnovnoe(position);
                }
                Console.Clear();
            }
            else if (position == 7)
            {
                Menu menu = new Menu();
                menu.asd = "Выберите:";
                menu.asf = "  Букет цветов ------- 200";
                menu.asg = "  Гоночная трасса ---- 300";
                menu.asj = "  Феи ---------------- 250";
                List<Menu> menudop = new List<Menu>();
                menudop.Add(menu);
                for (int i = 0; i < menudop.Count; i++)
                {
                    Console.WriteLine(menudop[i].asd);
                    Console.WriteLine(menudop[i].asf);
                    Console.WriteLine(menudop[i].asg);
                    Console.WriteLine(menudop[i].asj);
                }
                position = Str.strelk(1, 1, 3);
                if (position == 1 )
                {
                    der.Add("букет цветов");
                    snma = snma + 200;
                }
                else if (position == 2)
                {
                    der.Add("гоночная трасса");
                    snma = snma + 300;
                }
                else if (position == 3 )
                {
                    der.Add("феи");
                    snma = snma + 250;
                }
                else 
                {
                    ocnovnoe(position);
                }
                Console.Clear();
            }
            else if (position == 8)
            {
                Menu menu = new Menu();
                menu.asd = "Выберите:";
                menu.asf = "  Голубая с ягодами --------- 300";
                menu.asg = "  Коричневая с шоколадом ---- 500";
                menu.asj = "  Зеленая с яблоком --------- 200";
                List<Menu> menudop = new List<Menu>();
                menudop.Add(menu);
                for (int i = 0; i < menudop.Count; i++)
                {
                    Console.WriteLine(menudop[i].asd);
                    Console.WriteLine(menudop[i].asf);
                    Console.WriteLine(menudop[i].asg);
                    Console.WriteLine(menudop[i].asj);
                }
                position = Str.strelk(1, 1, 3);
                if (position == 1 )
                {
                    der.Add("голубая с ягодами");
                    snma = snma + 300;
                }
                else if (position == 2 )
                {
                    der.Add("коричневая с шоколадом");
                    snma = snma + 500;
                }
                else if (position == 3 )
                {
                    der.Add("зеленая с яблоком");
                    snma = snma + 200;
                }
                else 
                {
                    ocnovnoe(position);
                }
                Console.Clear();
            
            }
            else
            {
                string er = Convert.ToString(snma);
                Console.WriteLine("Спасибо за заказ! Приятного аппетита");
                DateTime d = DateTime.Now;
                string das = Convert.ToString(d);
                File.AppendAllText("C:\\Users\\user1\\Desktop\\шарпы.txt", "\nДата: ");
                File.AppendAllText("C:\\Users\\user1\\Desktop\\шарпы.txt", das);
                File.AppendAllText("C:\\Users\\user1\\Desktop\\шарпы.txt", "\nВаш заказ ");
                File.AppendAllText("C:\\Users\\user1\\Desktop\\шарпы.txt", "\nВаш торт: ");
                File.AppendAllLines("C:\\Users\\user1\\Desktop\\шарпы.txt", der);
                File.AppendAllText("C:\\Users\\user1\\Desktop\\шарпы.txt", "Цена: ");
                File.AppendAllText("C:\\Users\\user1\\Desktop\\шарпы.txt", er);
                ConsoleKeyInfo knopk = Console.ReadKey();
                if (knopk.Key == ConsoleKey.Escape)
                {
                    Console.Clear() ;
                    der.Clear();
                    return position-1;
                    
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            return position;
        }
    }
}
