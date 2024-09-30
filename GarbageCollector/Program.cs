namespace GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Play play = new Play("Ромео і Джульєтта", "Вільям Шекспір", "Трагедія", 1597);
            play.DisplayInfo(); 


            play.Title = "Сон в літню ніч"; 
            play.Author = "Вільям Шекспір"; 
            play.Genre = "Комедія";
            play.Year = 1595; 

            play.DisplayInfo();

            Console.WriteLine("\nTask2");
            Store store = new Store("Продуктовий Магазин", "вул. Центральна, 1", StoreType.Grocery);

            store.DisplayInfo();

            store.AddProduct("Хліб");
            store.AddProduct("Молоко");
            store.AddProduct("Яблука");

            store.DisplayInfo();
            store.Dispose();
        }
    }
}
