namespace DependencyInjectionSample
{
    public class MyHelloService : IHelloService
    {
        public string Hello(string name) => $"Hello, {name}";

    }
}
