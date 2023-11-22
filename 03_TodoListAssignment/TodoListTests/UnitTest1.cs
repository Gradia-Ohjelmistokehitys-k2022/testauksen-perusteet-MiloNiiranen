using TestingTodoListApp;
namespace TodoListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddItemToList_AddsTaskAndIncrementsId()
        {
            // Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Siivoa huone");
            TodoTask task2 = new TodoTask("Siivoa keittiö");



            // Act
            todoList.AddItemToList(task);
            todoList.AddItemToList(task2);

            // Assert
            Assert.AreEqual(2, todoList._TodoItems.Count);
        }
        [TestMethod]
        public void RemoveItemFromList_RemovesTaskFromList()
        {
            // Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Siivoa huone");
            todoList.AddItemToList(task);

            // Act
            todoList.RemoveItemFromList(task);

            // Assert
            Assert.AreEqual(0, todoList._TodoItems.Count);
        }

        [TestMethod]
        public void CompleteItem_MarksTaskAsCompleted()
        {
            // Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Siivoa huone");
            todoList.AddItemToList(task);

            // Act
            todoList.CompleteItem(task.Id);

            // Assert
            Assert.IsTrue(task.IsCompleted);
        }
    }
}