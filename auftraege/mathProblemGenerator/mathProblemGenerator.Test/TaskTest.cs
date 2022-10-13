namespace mathProblemGenerator.Test
{
    [TestClass]
    public class NewTaskTest
    {
        [TestMethod]
        public void NewTask_GetTask()
        {
            Manager manager = new Manager();

            manager.SetupGameTesting(2, 1);
            manager.MainLoop();
            string wrongSolvedTasks = manager.EvaluationAndFinalOutput();

            Assert.AreEqual()
        }
    }
}