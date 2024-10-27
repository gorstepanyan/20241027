using _20241027;
using System.Text;


Console.WriteLine(IsTodayMonday());
bool IsTodayMonday()
{
    var dayOfWeek = DateTime.Now.DayOfWeek;
    return dayOfWeek == DayOfWeek.Monday;
}

///////////////////////////////////////////////////////////////////////////

StringBuilder stringBuildersResult = new StringBuilder();

while (true)
{
    Console.Write("Input string to append in StringBuilder (to display all result you should type 'exit'): ");
    string? inputString = Console.ReadLine();
    if (inputString == null || inputString == "") // string.IsNullOrEmpty
    {
        Console.WriteLine("InputString canot be null");
    }
    if (inputString == "exit")
    {
        Console.WriteLine(stringBuildersResult.ToString());
        break;
    }
    AddString(inputString!);
}

void AddString(string inputValue)
{
    stringBuildersResult.Append(inputValue);
}

///////////////////////////////////////////////////////////////////////////


var calc = new Calculator();
calc.RunCalculator();






