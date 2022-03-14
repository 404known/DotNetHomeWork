using System;

namespace Week4
{
    public class Test
    {
        public static void Main()
        {
            Person p = new Person("Tom");
            DateTime beforeDT = DateTime.Now;
            p.setAlarm(7, 30,() => Console.WriteLine($"{p.Name} wakes up"));
            for(int i = 0; i < 60; i++)
            {
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforeDT);
                while(ts.Seconds < 1)
                {
                    afterDT = System.DateTime.Now;
                    ts = afterDT.Subtract(beforeDT);
                }
                p.clock.Tick(7, i);
                beforeDT = System.DateTime.Now;
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
        public void setAlarm(int hour, int min, Action act)
        {
            clock.OnAlarm += (sender, time) => { if (time.Hour == hour && time.Minute == min) { Console.WriteLine($"It is almost {time.Hour}:{time.Minute}!"); act(); } };
        }
    }
}