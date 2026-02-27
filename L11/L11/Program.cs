namespace L11
{
    internal class Program
    {
        public record Employee(string Name, int Id, string Department, decimal Salary);

        public static Employee Promote(Employee emp, decimal bonus)
        {
            return emp with { Salary = emp.Salary + bonus };
        }

        public static async Task<string> GetDataAsync(string sourceName, int delayMs)
        {
            await Task.Delay(delayMs);
            return $"Данные от {sourceName}";
        }

        static async Task Main(string[] args)
        {
            // Exercise 1
            var emp1 = new Employee("Vasya", 101, "IT", 1000);
            var emp2 = new Employee("Vasya", 101, "IT", 1000);
            Console.WriteLine($"Сравнение через ==: {emp1 == emp2}");
            Console.WriteLine($"Сравнение через .Equals(): {emp1.Equals(emp2)}");
            Console.WriteLine();

            // Exercise 2
            var promotedEmp = Promote(emp1, 300);
            Console.WriteLine($"Сравнение через .Equals(): {promotedEmp.Equals(emp2)}");
            Console.WriteLine();

            // Exercise 3
            CancellationTokenSource cts = new CancellationTokenSource();
            var taskA = GetDataAsync("А (медленный)", 3000);
            var taskB = GetDataAsync("Б (быстрый)", 1000);

            Task<string> winnerTask = await Task.WhenAny(taskA, taskB);
            string result = await winnerTask;
            cts.Cancel();
            Console.WriteLine($"Результат победителя: {result}");
        }
    }
}
