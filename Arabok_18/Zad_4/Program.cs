using System.Collections;

class Program
{
    static void Main()
    {
        MusicCatalog catalog = new MusicCatalog();

        catalog.AddDisk("Rock Classics");
        catalog.AddSong("Rock Classics", "Bohemian Rhapsody");
        catalog.AddSong("Rock Classics", "Stairway to Heaven");

        catalog.AddDisk("Pop Hits");
        catalog.AddSong("Pop Hits", "Shape of You");
        catalog.AddSong("Pop Hits", "Dance Monkey");

        catalog.ViewDiskContents("Rock Classics");
        catalog.ViewDiskContents("Pop Hits");

        catalog.RemoveSong("Rock Classics", "Bohemian Rhapsody");
        catalog.RemoveSong("Pop Hits", "Shape of You");

        catalog.ViewCatalogContents();
    }
}