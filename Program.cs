public class Program
{
    public static void Main(string[] args)
    {
        Playlist<string> playlist = new Playlist<string>();
        playlist.AddItem("Canción 1");
        playlist.AddItem("Canción 2");
        playlist.AddItem("Canción 3");

        IIterator<string> iterator = playlist.CreateIterator();
        Console.WriteLine("Recorrido Ascendente:");
        while (iterator.HasNext())
        {
            string item = iterator.Next();
            Console.WriteLine(item);
        }

        IIterator<string> reverseIterator = playlist.CreateReverseIterator();
        Console.WriteLine("\nRecorrido Descendente:");
        while (reverseIterator.HasNext())
        {
            string item = reverseIterator.Next();
            Console.WriteLine(item);
        }
    }
}
