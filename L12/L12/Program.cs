namespace L12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "Kolya", Age = 1, Email = "cmndfkjfn", IsStudent = false };
            ReflectionTest.PrintProperties(person);

            var inputPath = "input.txt";
            var outputPath = "output.txt";

            var lineCount = 0;
            var charCount = 0;
            var content = "";

            using (StreamReader reader = new StreamReader(inputPath))
            {
                var line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;
                    content += line + Environment.NewLine;
                }
            }

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine($"Количество строк: {lineCount}");
                writer.WriteLine($"Количество символов: {charCount}");
                writer.WriteLine("--- Содержимое файла ---");
                writer.Write(content);
            }

        }
    }
}
