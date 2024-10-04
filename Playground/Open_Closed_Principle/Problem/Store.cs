using System.Collections.Concurrent;

namespace Open_Closed_Principle.Problem
{
    public class Store
    {
        private List<string> _items;
        private ConcurrentBag<string> ff;

        public Store()
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
        public bool HasItem(string name)
        {
            return _items.Contains(name);
        }

    }
}
