namespace Knowledge_Check_Two_Boi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            int numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<MusicRecord>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var musicRecord = new MusicRecord();

                Console.WriteLine("Enter the Title: ");
                musicRecord.Title = Console.ReadLine();

                Console.WriteLine("Enter the Artist: ");
                musicRecord.Artist = Console.ReadLine();

                Console.WriteLine("Enter the Genre: ");
                musicRecord.Genre = Console.ReadLine();

                Console.WriteLine("Enter the Year: ");
                musicRecord.Year = int.Parse(Console.ReadLine());

                recordList.Add(musicRecord);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var record in recordList)
            {
                Console.WriteLine(record);
            }
        }
    }
}
