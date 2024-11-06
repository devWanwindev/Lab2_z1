class Nextlogic : logic
{
    private string name; // Имя
    private int exp; // Уровень опыта

    //x - c++
    //y - java
    // Конструктор класса
    public Nextlogic(string name, int exp, bool x, bool y) : base(x, y)
    {
        this.name = name;
        this.exp = exp;
    }

    public void PredictFuture()
    {
        if (exp == 1)
        {
            Console.WriteLine($"{name} - Junior.");
        }
        else if (exp == 2)
        {
            Console.WriteLine($"{name} - Middle.");
        }
        else if (exp == 3)
        {
            Console.WriteLine($"{name} - Senior");
        }
    }

    public void ShowSkills()
    {
        if (_x && _y)
        {
            Console.WriteLine($"{name} хорошо разбирается в C++ и имеет опыт в Java.");
        }
        else if (_x || _y)
        {
            Console.WriteLine($"{name} Знает один из языков (С++ или Java).");
        }
        else
        {
            Console.WriteLine($"{name} Не имеет опыта в языках програмирования.");
        }
    }

    public override string ToString()
    {
        return $"{_x} | {_y} | {exp} | {name}";
    }
}
