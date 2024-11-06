class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите x и y (True or False): ");
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        if (bool.TryParse(x, out bool x1))
        {
            if (bool.TryParse(x, out bool y2))
            {
                logic a = new logic(x1, y2);
                string res = a.kon() ? "да" : "нет";
                Console.WriteLine("отрицание конъюнкции");
                Console.WriteLine(res);

                Console.WriteLine("Перегруз");
                Console.WriteLine(a.ToString());
                
                       
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода");
        }


        Console.WriteLine("\nВведите Имя");
        string name = Console.ReadLine();
        Console.WriteLine("Введите опыт: 1 - Джун. 2- Мидл. 3- Сеньер");
        
        string time = Console.ReadLine();
        if (int.TryParse(time, out int time1))
            if ((1 <= time1) && (time1 <= 3))
            {
                
                
                Console.WriteLine("Знает C++: (True or False)");
                string c = Console.ReadLine();
                if (bool.TryParse(c, out bool c1))
                {
                    Console.WriteLine("Знает Java: (True or False)");
                    string j = Console.ReadLine();
                    if (bool.TryParse(j, out bool j2))
                    {
                        Nextlogic person1 = new Nextlogic(name, time1, c1, j2);
                        person1.PredictFuture();
                        person1.ShowSkills();

                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }

                

            }


            
        


        

    }
}
