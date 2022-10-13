Делегат Д = new Делегат();

Делегат.ПерДел П = new Делегат.ПерДел(Д.Zap);
П += Д.RGB;
П();
Делегат Л = new Делегат();
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Массив кратный семи->>");
Л.LambdaMas(x => (x % 7 == 0));
Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("\nКоличество положительных чисел->>" + Л.LambdaMas(x => (x >= 0)));
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("Массив отрицательных чисел->>");
Л.LambdaMas(x => (x < 0));
Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Л.print();
Console.WriteLine("\nМассив отрицательных уникальных чисел->>");
Л.LambdaMas2(x => (x < 0));
Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Делегат F = new Делегат();
Console.WriteLine("\nВведите искомое слово");
string sl;
sl = Console.ReadLine();
sl = sl.ToLower();
F.LambdaStr(x =>x == sl, sl);
Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
F.РюкзакЗап();
class Делегат
{
    string a;
    public delegate void ПерДел();
    public void Zap()
    {
        Console.WriteLine("Введите какой-то цвет радуги->");
        a = Console.ReadLine();
    }
    public void RGB()
    {
        string b = a;
        a = a.ToLower();
        if(a=="желтый"||a=="yellow")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(b);
            Console.ResetColor();
        }
        if (a == "красный" || a == "red")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(b);
            Console.ResetColor();
        }
        if (a == "оранжевый" || a == "orange")
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(b);
            Console.ResetColor();
        }
        if (a == "зеленый" || a == "green" || a=="зелёный")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(b);
            Console.ResetColor();
        }
        if (a == "голубой" || a == "blue")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(b);
            Console.ResetColor();
        }
        if (a == "синий" || a == "lightblue")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(b);
            Console.ResetColor();
        }
        if (a == "фиолетовый" || a == "magneta")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(b);
            Console.ResetColor();
        }
    }
    public void РюкзакЗап()
    {
        string color;
        string firm;
        double obem;
        string[] mas;
        Console.WriteLine("Рюкзак заполнен, приходите завтра. Он усталь.");
    }
    public int[] mas = new int[15];
    public string str;
    public delegate bool IsEqual(int x);
    public int LambdaMas(IsEqual func)
    {
        int kol =0;
        Console.WriteLine("Зыс из масиу->>");
        Random random = new Random();
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            mas[i] = random.Next(-21, 22);
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine("\nМассив соответствующий условиям->>");
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            if (func(mas[i]))
            {
                Console.Write(mas[i] + " ");
                kol++;
            }
        }
        return kol;
    }
    public void LambdaMas2(IsEqual func)
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            bool b = true;
            for (int j = 0; j < mas.GetLength(0); j++)
            {
                if (mas[i] == mas[j] && i!=j)
                {
                    b = false;
                    break;
                }
            }
            if(b==true)
            {
                if (func(mas[i]))
                {
                    Console.Write(mas[i] + " ");
                }
            }
        }
    }
    public void print()
    {
        Random random = new Random();
        Console.WriteLine("Зыс из масиу->>");
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            mas[i] = random.Next(-21, 22);
            Console.Write(mas[i]+" ");
        }
    }
    public delegate bool IsEqual2(string x);
    public void LambdaStr(IsEqual2 func, string sl)
    {
        bool b = true;
        Console.WriteLine("Введите строку");
        string str = Console.ReadLine();
        //sl = sl.ToLower();
        str = str.ToLower();
        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
           
            //Console.WriteLine("Word = " + words[i]);
            //Console.WriteLine("SL = " + sl);
            if (func(words[i]))
            {

                Console.WriteLine("Найдено");
                b = false;
                break;
            }
        }
        if (b == true)
        {
            Console.WriteLine("Не найдено");
        }
        //if(Array.IndexOf(words, sl)!=-1)
        //{
        //    Console.WriteLine("Найдено");
        //}
        //else
        //{
        //    Console.WriteLine("Не найдено");
        //}
    }
}
