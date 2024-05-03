namespace ObserverPatternExample
{
    class Publisher
    {
        public delegate void MyEventHandler(string message);
        public event MyEventHandler MyEvent;

        public void DoSomething()
        {
            Console.WriteLine("Издатель что-то делает...");
            MyEvent?.Invoke("Событие, инициированное издателем");
        }
    }

    class Observer1
    {
        public void HandleEvent(string message)
        {
            Console.WriteLine($"Наблюдатель 1 получил: {message}");
        }
    }

    class Observer2
    {
        public void HandleEvent(string message)
        {
            Console.WriteLine($"Наблюдатель 2 получил: {message}");
        }
    }

    class Program
    {
        static void Main()
        {
            Publisher publisher = new Publisher();
            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            publisher.MyEvent += observer1.HandleEvent;
            publisher.MyEvent += observer2.HandleEvent;

            publisher.DoSomething();

            publisher.MyEvent -= observer1.HandleEvent;

            publisher.DoSomething();
        }
    }
}