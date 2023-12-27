//1
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое значение времени (в формате ЧЧ:ММ:СС): ");
        string time1Input = Console.ReadLine();
        DateTime time1 = DateTime.ParseExact(time1Input, "HH:mm:ss", null);

        Console.Write("Введите второе значение времени (в формате ЧЧ:ММ:СС): ");
        string time2Input = Console.ReadLine();
        DateTime time2 = DateTime.ParseExact(time2Input, "HH:mm:ss", null);

        TimeSpan timeDifference = time2 - time1;
        int hours = timeDifference.Hours;

        Console.WriteLine("Между указанными временами прошло {0} часов", hours);
    }
}
//2
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите дату (в формате ДДММГГГГ): ");
        string dateInput = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dateInput, "ddMMyyyy", null);

        string month = date.ToString("MMMM");

        int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

        Console.WriteLine("Дата с замененным месяцем: {0}", date.ToString("dd ") + month + date.ToString(" yyyy"));
        Console.WriteLine("Количество дней в этом месяце: {0}", daysInMonth);
    }
}
