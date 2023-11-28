using System.Threading.Tasks;
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
        public void AddItemToList_AddsTwoSameTasks_WithSameDecription()
        {
            //Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Siivoa huone");
            TodoTask task2 = new TodoTask("Siivoa huone");

            //Act
            todoList.AddItemToList(task);
            todoList.AddItemToList(task2);

            //Assert
            Assert.AreEqual(2, todoList._TodoItems.Count);
        }
        [TestMethod]
        public void AddItemToList_AddsTaskWithNoDecription()
        {
            //Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("");

            //Act
            todoList.AddItemToList(task);

            //Assert
            Assert.AreEqual(1, todoList._TodoItems.Count);
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
        public void RemoveTaskFromList_RemovestaskFrom_EmptyList()
        {
            // Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Siivoa huone");

            // Act
            todoList.RemoveItemFromList(task);

            // Assert
            Assert.AreEqual(0, todoList._TodoItems.Count);
        }

        [TestMethod]
        public void RemoveTaskFromList_RevomesSpecificTask_FromList()
        {
            // Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Siivoa huone");
            TodoTask task2 = new TodoTask("Siivoa keittiö");
            TodoTask task3 = new TodoTask("Pese pyykki");
            todoList.AddItemToList(task);
            todoList.AddItemToList(task2);
            todoList.AddItemToList(task3);

            // Act
            todoList.RemoveItemFromList(task2);

            // Assert
            Assert.AreEqual(2, todoList._TodoItems.Count);
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
            
            Assert.IsNull(todoList);
        }

        [TestMethod]
        public void CompleteItem_CompleteItemThatDoesNTExist_InTheList()
        {
            //Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Siivoa huone");

            // Act
            todoList.CompleteItem(task.Id);

            // Assert

            Assert.IsNull(todoList);
        }
    }
}