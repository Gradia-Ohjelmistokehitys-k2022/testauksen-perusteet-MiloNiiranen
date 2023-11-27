using Warehouse;


namespace WareHouse
{

    public class WareHouseMethods
    {

        private List<Stock> _stockOfItems;
        public void WareHouseSimulator()
        {
            _stockOfItems = new();
            Stock item1 = new("Hat", 2);
            Stock item2 = new("Shoes", 3);
            Stock item3 = new("Jacket", 5);

            _stockOfItems.Add(item1);
            _stockOfItems.Add(item2);
            _stockOfItems.Add(item3);
        }

        public WareHouseMethods()
        {

        }

        public void AddToStocks(string itemName, int itemCount)
        {
            Stock stock = new(itemName, itemCount);
            _stockOfItems.Add(stock);
        }

        public bool InStock(string itemName)
        {
            return _stockOfItems.Any(item => item.ItemName == itemName && item.Quantity > 0);
        }

        public void TakeFromStock(string itemName, int quantity)
        {
            Stock stock = _stockOfItems.FirstOrDefault(item => item.ItemName == itemName && item.Quantity >= quantity); // Varmistetaan että valitaan oikea tuote ja että varastossa on tarpeeksi tuotteita.

            if (stock != null)
            {
                stock.Quantity -= quantity;
            }
            else
            {
                throw new Exception($"Not enough stock for {itemName}");
            }
        }

        public int StockCount(string itemName)
        {
            var matches = _stockOfItems.Where(item => item.ItemName == itemName);
            return matches.Sum(item => item.Quantity);
        }
        public int StockCountAllDistinctItems()
        {
            return _stockOfItems.Select(item => item.ItemName).Distinct().Count(); // Tein tämän, että voin testata että luo ne tuote tyypit
        }
    }  
}

