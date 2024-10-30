using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var date = DateTime.Today;
Console.WriteLine(GetDayOfWeekBySwitch(date));
Console.WriteLine(GetDayOfWeekByIfElse(date));

int?[] arrByHundred = new int?[100];
for (int i = 0; i < arrByHundred.Length; i++)
{
    Console.Write($"Input number of element {i + 1}: ");
    var inputValue = Console.ReadLine();
    if (int.TryParse(inputValue, out int result))
    {
        if (result == -1)
        {
            break;
        }
        arrByHundred[i] = result;
    };
}

foreach (int? i in arrByHundred)
{
    if (i.HasValue)
    {
        Console.WriteLine(i);
    }
}


#region Functions
string GetDayOfWeekBySwitch(DateTime date)
{
    var dayOfWeek = date.DayOfWeek switch
    {
        DayOfWeek.Monday => "Երկուշաբթի",
        DayOfWeek.Tuesday => "Երեքշաբթի",
        DayOfWeek.Wednesday => "Չորեքշաբթի",
        DayOfWeek.Thursday => "Հինգշաբթի",
        DayOfWeek.Friday => "Ուրբաթ",
        DayOfWeek.Saturday => "Շաբաթ",
        DayOfWeek.Sunday => "Կիրակի"
    };
    return dayOfWeek;
}

string GetDayOfWeekByIfElse(DateTime date)
{
    var dayOfWeek = date.DayOfWeek;

    if (dayOfWeek == DayOfWeek.Monday)
    {
        return "Երկուշաբթի";
    }
    else
    {
        if (dayOfWeek == DayOfWeek.Tuesday)
        {
            return "Երեքշաբթի";
        }
        else
        {
            if (dayOfWeek == DayOfWeek.Wednesday)
            {
                return "Չորեքշաբթի";
            }
            else
            {
                if (dayOfWeek == DayOfWeek.Thursday)
                {
                    return "Հինգշաբթի";
                }
                else
                {
                    if (dayOfWeek == DayOfWeek.Friday)
                    {
                        return "Ուրբաթ";
                    }
                    else
                    {
                        if (dayOfWeek == DayOfWeek.Saturday)
                        {
                            return "Շաբաթ";
                        }
                        else
                        {
                            if (dayOfWeek == DayOfWeek.Sunday)
                            {
                                return "Կիրակի";
                            }
                            else
                            {
                                throw new Exception("Invalid day of week");
                            }
                        }
                    }
                }
            }
        }
    }
}

#endregion