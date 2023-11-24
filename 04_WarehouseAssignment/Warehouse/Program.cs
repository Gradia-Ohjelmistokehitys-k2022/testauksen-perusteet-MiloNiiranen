
using Warehouse;

namespace WareHouse

{
    internal class Program
    {
        // Tee ohjelmaan yksikkötestit.
        static void Main(string[] args)
        {
          
            WareHouseMethods wareHouse = new();
            wareHouse.WareHouseSimulator();
        }
    }
}