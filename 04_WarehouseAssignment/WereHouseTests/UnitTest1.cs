using Warehouse;
using WareHouse;

namespace WereHouseTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WareHouseSimulator_MakesSureThatWareHouseIsCreated()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();

            // Act
            warehouse.WareHouseSimulator();

            // Assert
            Assert.IsNotNull(warehouse);
        }

        [TestMethod]
        public void WareHouseSimulator_TestsThatCreates_RightAmountOFItems()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();

            // Act
            warehouse.WareHouseSimulator();

            // Assert
            Assert.AreEqual(2, warehouse.StockCount("Hat"));
            Assert.AreEqual(3, warehouse.StockCount("Shoes"));
            Assert.AreEqual(5, warehouse.StockCount("Jacket"));
        }

        [TestMethod]
        public void WareHouseSimulator_CreatesRightAmountOfStockTypes()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();

            // Act
            warehouse.WareHouseSimulator();

            // Assert
            Assert.AreEqual(2, warehouse.StockCount("Hat"));
            Assert.AreEqual(3, warehouse.StockCount("Shoes"));
            Assert.AreEqual(5, warehouse.StockCount("Jacket"));

            // Make sure there are no other items
            Assert.AreEqual(3, warehouse.StockCountAllDistinctItems());
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
        public void AddToStocks_AddsMenyItems_ToWareHouse()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();

            // Act
            warehouse.AddToStocks("Computer", 3);
            warehouse.AddToStocks("Mouse", 2);
            warehouse.AddToStocks("Keyboard", 4);

            // Assert
            Assert.AreEqual(3, warehouse.StockCount("Computer"));
            Assert.AreEqual(2, warehouse.StockCount("Mouse"));
            Assert.AreEqual(4, warehouse.StockCount("Keyboard"));
        }

        [TestMethod]
        public void AddToStocks_AddsZeroQuantity_ToWareHouse()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();

            // Act
            warehouse.AddToStocks("Computer", 0);

            // Assert
            Assert.AreEqual(0, warehouse.StockCount("Computer"));
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
        public void InStock_ReturnsFalse_WhenItemIsNotInStock()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();
            warehouse.AddToStocks("Computer", 3);

            // Act
            var result = warehouse.InStock("Keyboard");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InStock_IsNotNull_()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();
           

            // Act
            var result = warehouse.InStock("Hat");

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TakeFromStock_TakesItemFromStock()
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
        public void TakeFromStock_TrowsExeption_WhenThereIsNotEnoughStock()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();


            //Act and Assert
            Assert.ThrowsException<Exception>(() => warehouse.TakeFromStock("Hat", 5));
        }

        [TestMethod]
        public void TakeFromStock_TrowsExeption_WhenTakingZeroItems()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();
            
            //Act and Assert
            Assert.ThrowsException<Exception>(() => warehouse.TakeFromStock("Computer", 0));
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

        [TestMethod]
        public void StockCount_ReturnsZero_WhenWarehouseIsEmpty()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();

            // Act
            int itemCount = warehouse.StockCount("Computer");

            // Assert
            Assert.AreEqual(0, itemCount);
        }

        [TestMethod]
        public void StockCount_IsCaseInsensitive()
        {
            // Arrange
            var warehouse = new WareHouse.WareHouseMethods();
            warehouse.WareHouseSimulator();
            warehouse.AddToStocks("Computer", 3);

            // Act
            int itemCount = warehouse.StockCount("computer");

            // Assert
            Assert.AreEqual(3, itemCount);
        }
    }
}