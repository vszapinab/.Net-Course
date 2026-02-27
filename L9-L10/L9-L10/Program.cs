

namespace L9_L10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 12, 7, 20, 33, 18, 2, 40 };
            List<string> words = new() { "Artem", "Natali", "Yana", "Yulia", "Alex" };

            // Exercise 1
            List<int> task1 = numbers.Where(n => n % 2 == 0).OrderBy(n => n).Select(n => n * 3).ToList();
            task1.ForEach(n => Console.Write(n + " "));
            Console.WriteLine("\n");

            // Exercise 2
            List<Product> products = [
                new Product { Name = "Laptop", Price = 1200 },
                new Product { Name = "Mouse", Price = 25 },
                new Product { Name = "Monitor", Price = 300 },
                new Product { Name = "Cable", Price = 10 },
                new Product { Name = "Keyboard", Price = 150 }
            ];
            var highPriceNames = products.Where(p => p.Price > 100).OrderByDescending(p => p.Price).Select(p => p.Name);
            foreach (var name in highPriceNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // Exercise 3
            List<Student> students = [new Student { Grade = 5 }, new Student { Grade = 4 }, new Student { Grade = 2 }];
            Console.WriteLine("Есть ли < 3: " + students.Any(s => s.Grade < 3));
            Console.WriteLine("Все ли >= 4: " + students.All(s => s.Grade >= 4));
            Console.WriteLine("Кол-во > 4: " + students.Count(s => s.Grade > 4));
            Console.WriteLine();

            // Exercise 4
            Console.WriteLine("Сумма чётных: " + numbers.Where(n => n % 2 == 0).Sum());
            Console.WriteLine("Макс: " + numbers.Max());
            Console.WriteLine("Среднее: " + numbers.Average());
            Console.WriteLine();

            // Exercise 5
            var groups = numbers.GroupBy(n => n % 2 == 0 ? "Чётные" : "Нечётные");
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
            }
            Console.WriteLine();

            // Exercise 6
            List<Person> people = [
                new Person { Name = "Anna", Age = 17 },
                new Person { Name = "Dmitry", Age = 35 },
                new Person { Name = "Elena", Age = 20 },
                new Person { Name = "Ivan", Age = 31 },
                new Person { Name = "Oleg", Age = 24 }
            ];
            var adults = people.Where(p => p.Age > 18).OrderBy(p => p.Age).Select(p => p.Name);
            Console.WriteLine("Взрослые: " + string.Join(", ", adults));
            Console.WriteLine();

            // Exercise 7
            var firstOver30 = people.FirstOrDefault(p => p.Age > 30);
            Console.WriteLine(firstOver30?.Name ?? "Такого не существует");
            Console.WriteLine();

            // Exercise 8
            Console.WriteLine("Есть ли < 25: " + people.Any(p => p.Age < 25));
            Console.WriteLine("Все ли > 18: " + people.All(p => p.Age > 18));
            Console.WriteLine();

            // Exercise 9
            var longWords = words.Where(w => w.Length > 4).OrderBy(w => w);
            Console.WriteLine(string.Join(", ", longWords));
            Console.WriteLine();

            // Exercise 10
            var wordsWithA = words.Where(w => w.ToLower().Contains("a")).Select(w => w.ToUpper()).ToList();
            Console.WriteLine(string.Join(", ", wordsWithA));
            Console.WriteLine();

            // Exercise 11
            List<int> dupes = [1, 2, 2, 3, 4, 4, 5];
            var uniqueDesc = dupes.Distinct().OrderByDescending(n => n);
            Console.WriteLine(string.Join(", ", uniqueDesc));
            Console.WriteLine();

            // Exercise 12
            List<Order> orders = [
                new Order { Id = 1, Prices = [100, 200] },
                new Order { Id = 2, Prices = [50, 500] }
            ];
            var allPrices = orders.SelectMany(o => o.Prices).ToList();
            Console.WriteLine("Все цены: " + string.Join(", ", allPrices));
            Console.WriteLine("Макс цена: " + allPrices.Max());
            Console.WriteLine();

            // Exercise 13
            Action<User> printUser = u => Console.WriteLine($"Имя: {u.Name}, Возраст: {u.Age}");
            User testUser = new() { Name = "Artem", Age = 25 };
            printUser(testUser);
            Console.WriteLine();

            // Exercise 14
            Action<string> printUpper = s => Console.WriteLine(s.ToUpper());
            printUpper("hello linq");
            Console.WriteLine();

            // Exercise 15
            Func<double, double, double> getAverage = (a, b) => (a + b) / 2;
            Console.WriteLine("Среднее (10 и 20): " + getAverage(10, 20));
        }
    }
}

