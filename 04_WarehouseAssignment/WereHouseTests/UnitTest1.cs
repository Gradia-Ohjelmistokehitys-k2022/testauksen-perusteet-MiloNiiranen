using WareHouse;

namespace WereHouseTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WareHouseSimulator_MakesSureThatWareHouseIsInitialized()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();

            // Act
            warehouse.WareHouseSimulator();

            // Assert
            Assert.IsNotNull(warehouse);
        }

        [TestMethod]
        public void AddToStocks_AddsNewStock_ToWareHouse()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();

            // Act
            warehouse.AddToStocks("Computer", 2);

            // Assert
            Assert.AreEqual(warehouse, 2);
        }
    }
}