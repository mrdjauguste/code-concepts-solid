namespace Open_Closed_Principle.Solution
{
    public class Walmart : IStore
    {
        private List<string> _items;
        public Walmart()
        {
            _items = new List<string>()
            { 
                "apples",
                "bananas",
                "playstation 5 pro",
                "apple vision pro",
                "tictacs",
                "kiwis",
                "toys",
                "macbook",
                "ipad",
                "xbox",
                "catan",
                "pc"
            };
        }

        public bool AmIAwesome()
        {
            return false;
        }

        public bool HasItem(string name)
        {
            return _items.Contains(name);
        }
    }
}
