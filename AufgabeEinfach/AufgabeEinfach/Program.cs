internal class Program
{
    static void Main(string[] args)
    {
        TrafficLight light = new TrafficLight();
        while (true)
        {
            light.Display();
            Console.WriteLine("Drücke eine Taste um die Ampel zu schalten.");
            Console.ReadKey();
            Console.Clear();
            light.Next();
        }
    }
}

abstract class TrafficLightState
{
    public abstract void Display();
    public abstract TrafficLightState Next();
}

class RedState : TrafficLightState
{
    public override void Display()
    {
        throw new NotImplementedException();
    }

    public override TrafficLightState Next()
    {
        throw new NotImplementedException();
    }
}

class YellowState : TrafficLightState
{
    public override void Display()
    {
        throw new NotImplementedException();
    }

    public override TrafficLightState Next()
    {
        throw new NotImplementedException();
    }
}

class GreenState : TrafficLightState
{
    public override void Display()
    {
        throw new NotImplementedException();
    }

    public override TrafficLightState Next()
    {
        throw new NotImplementedException();
    }
}

class TrafficLight
{
    private TrafficLightState _state = new RedState();

    public void Display()
    {
        _state.Display();
    }

    public void Next()
    {
        _state = _state.Next();
    }
}
