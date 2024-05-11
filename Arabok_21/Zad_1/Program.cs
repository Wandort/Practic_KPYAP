using System;

abstract class State
{
    public abstract void Handle(Context context);
}

class StateA : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("Обработка состояния StateA");
        context.State = new StateB();
    }
}

class StateB : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("Обработка состояния StateB");
        context.State = new StateA();
    }
}

class Context
{
    public State State { get; set; }

    public Context(State state)
    {
        this.State = state;
    }

    public void Request()
    {
        this.State.Handle(this);
    }
}

class Program
{
    static void Main()
    {
        Context context = new Context(new StateA());
        context.Request();
        context.Request();
    }
}
