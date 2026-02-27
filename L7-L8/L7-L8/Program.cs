namespace L7_L8
{
    internal class Program
    {
        static void PrintHighAchievers(List<Student> students)
        {
            Console.WriteLine("Студенты с оценкой >= 4:");
            foreach (var student in students)
            {
                if (student.Grade >= 4)
                {
                    Console.WriteLine($"- {student.Name} (ID: {student.Id}, Оценка: {student.Grade})");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Exercise 1
            var person = new Person();
            person.Name = "Vasya";
            person.BirthDate = new DateTime(2000, 6, 25);
            Console.WriteLine($"{person.Name}: {person.GetAge()}");

            // Exercise 2
            var workSession = new WorkSession();
            workSession.StartTime = DateTime.Now;
            workSession.EndTime = workSession.StartTime.AddHours(20).AddMinutes(40);

            Console.WriteLine(workSession.GetRawDuration());
            workSession.PrintFormattedDuration();

            // Exercise 3
            List<Student> students =
            [
                new("Vasya", 5),
                new("Sanya", 3),
                new("Vanya", 4),
                new("Manya", 2),
                new("Zhenya", 10)
            ];

            PrintHighAchievers(students);

            // Exercise 4
            var books = new Dictionary<int, Book>();
            books.TryAdd(1, new Book());
            books.TryAdd(1, new Book { Id = 1, Author = "Tolstoy", Title = "Anna Karenina" });
            books.TryAdd(2, new Book { Id = 2, Author = "Tolstoy", Title = "War and Piece" });
            books.TryAdd(3, new Book { Id = 3, Author = "Dostoevsky", Title = "Crime and Punishment" });
            Console.WriteLine(string.Join("\n", books.Select(b => b.ToString())));

            Console.Write("Введите ID книги для поиска: ");
            if (int.TryParse(Console.ReadLine(), out int searchId))
            {
                if (books.TryGetValue(searchId, out Book foundBook))
                {
                    Console.WriteLine($"Найдено: {foundBook}");
                }
                else
                {
                    Console.WriteLine("Книга с таким ID не найдена.");
                }
            }
            Console.WriteLine();

            // Exercise 5
            Dictionary<int, List<Employee>> departments = new Dictionary<int, List<Employee>>();

            var devDepartmentKey = 100;
            var hrDepartmentKey = 200;
            departments[devDepartmentKey] = new List<Employee>
            {
                new Employee { Id = 1, Name = "Lekha (Front-end)" },
                new Employee { Id = 2, Name = "Pasha (DevOps)" }
            };

            departments[hrDepartmentKey] = new List<Employee>
            {
                new Employee { Id = 3, Name = "Masha (HR)" }
            };

            Console.Write("Введите ID отдела: ");
            if (int.TryParse(Console.ReadLine(), out int departId))
            {
                if (departments.ContainsKey(departId))
                {
                    Console.WriteLine($"Сотрудники отдела {departId}:");
                    foreach (var emp in departments[departId])
                    {
                        Console.WriteLine($"- ID: {emp.Id}, Имя: {emp.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Отдел не найден.");
                }
            }
        }
    }
}
