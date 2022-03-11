using System;

namespace Week4
{
    public class Test
    {
        public static void Main()
        {
            Person p = new Person("Tom");
            p.setAlarm(7, 30);
            for(int i = 0; i < 60; i++)
            {
                p.clock.Tick(7, i);
            }
        }
    }
    public delegate void TickHandler(object sender, Time time);
    public delegate void AlarmHandler(object sender, Time time);
    public class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

    }
    public class Clock
    {
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;
        public void Tick(int thour, int tmin)
        {
            Time time = new Time() { Hour = thour, Minute = tmin };
            OnTick(this, time);
            Alarm(thour, tmin);
        }
        public void Alarm(int Ahour, int Amin)
        {
            Time time = new Time() { Hour = Ahour, Minute = Amin };
            OnAlarm(this, time);
        }
    }

    public class Person
    {
        public Clock clock = new Clock();
        public string Name { get; set; }
        public Person(string n)
        {
            Name = n;
            clock.OnTick += (sender, time) => { Console.WriteLine($"Time is flying, it is {time.Hour}:{time.Minute} now.");  };
        }
        public void WakeUp()
        {
            Console.WriteLine($"{Name} wakes up");
        }
        public void setAlarm(int hour, int min)
        {
            clock.OnAlarm += (sender, time) => { if (time.Hour == hour && time.Minute == min) { Console.WriteLine($"It is almost {time.Hour}:{time.Minute}!"); WakeUp(); } };
        }
    }
}