namespace Playground
{
    public class ClassExample
    {
        public string? Foo { get; set; }
        public string? Bar { get; set; }
        public string Baz { get; set; }

        public ClassExample()
        {
            Baz = Bar!;

            Bar!.ToArray();
        }
    }
}
