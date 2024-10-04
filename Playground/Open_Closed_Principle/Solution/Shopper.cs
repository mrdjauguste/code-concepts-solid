namespace Open_Closed_Principle.Solution
{
    public class Shopper
    {
        private List<string> _purchased = new();
        private IStore _store;

        public Shopper(IStore store)
        {
            _store = store;
        }

        public List<string> Shop(IEnumerable<string> shoppingList)
        {   
            foreach (string shopping in shoppingList)
            {
                if (_store.HasItem(shopping))
                {
                    BuyItem(shopping);
                }
            }

            return _purchased;
        }

        public void BuyItem(string item)
        {
            _purchased.Add(item);
        }
    }
}
