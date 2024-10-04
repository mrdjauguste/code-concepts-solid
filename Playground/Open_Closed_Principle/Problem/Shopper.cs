namespace Open_Closed_Principle.Problem
{
    public class Shopper
    {
        private List<string> _purchased = new();
        public List<string> Shop()
        {
            List<string> shoppingList =
            [
                "apples",
                "bananas",
                "playstation 5 pro",
                "apple vision pro",
                "tictacs",
            ];

            Store walmart = new();

            foreach (string shopping in shoppingList)
            {
                if (walmart.HasItem(shopping))
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
