using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab4;

public class ClassCounter
{
    public delegate void MessageWrite();
    public event MessageWrite onCount;

    public void Count()
    {
        for (int i=0; i<25; i++)
        {
            if (i == 15)
            {
                onCount();
            }
        }
    }
}


class Time_I 
{
    public void Message()
    {
        Console.WriteLine("15 секунд до старту");
    }
}
class Time_II
{
    public void Message()
    {
        Console.WriteLine("5 секунд до старту");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        ClassCounter Counter = new ClassCounter();
        Time_I Time1 = new Time_I();
        Time_II Time2 = new Time_II();

        Counter.onCount += Time1.Message;
        Counter.onCount -= Time2.Message;

        Counter.Count();
    }
}
