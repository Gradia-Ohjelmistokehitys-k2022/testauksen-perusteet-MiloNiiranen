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
            warehouse.AddToStocks("Computer", 3);

            // Assert
            Assert.AreEqual(3, warehouse.StockCount("Computer"));
        }

        [TestMethod]
        public void InStock_ReturnsTrue_WhenItemIsInStock()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();
            warehouse.AddToStocks("Computer", 3);

            // Act
            var result = warehouse.InStock("Computer");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TakeFromStock_TakesItemFromStock_IfItemExistOrIsNotOverSold()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();
            warehouse.AddToStocks("Computer", 3);

            // Act
            warehouse.TakeFromStock("Computer", 1);

            //Assert
            Assert.AreEqual(2, warehouse.StockCount("Computer"));
        }

        [TestMethod]
        public void StockCount_Counts_Items()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();
            warehouse.AddToStocks("Computer", 3);

            // Act
            int stockCount = warehouse.StockCount("Computer");

            //Assert
            Assert.AreEqual(3, stockCount);
        }
    }
}