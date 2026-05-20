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

class TrafficLight
{
    private string _state = "red";

    public void Display()
    {
        if (_state == "red")
            Console.WriteLine("[ ] [ ] [R]\nSTOP");
        else if (_state == "yellow")
            Console.WriteLine("[ ] [Y] [ ]\nGET READY");
        else if (_state == "green")
            Console.WriteLine("[G] [ ] [ ]\nGO");
    }

    public void Next()
    {
        if (_state == "red")
            _state = "green";
        else if (_state == "yellow")
            _state = "red";
        else if (_state == "green")
            _state = "yellow";
    }
}
