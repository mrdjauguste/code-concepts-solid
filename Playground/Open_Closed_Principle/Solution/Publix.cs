namespace Open_Closed_Principle.Solution
{
    public class Publix : IStore
    {
        private List<string> _items;
        public Publix()
        {
            _items = new List<string>()
            { 
                "apples",
                "bananas",
                "tictacs",
                "kiwis",
                "milk",
                "eggs",
                "gum",
                "eggnog"
            };
        }

        public bool HasItem(string name)
        {
            return _items.Contains(name);
        }
    }
}
