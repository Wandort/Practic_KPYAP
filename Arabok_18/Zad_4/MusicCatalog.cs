using System.Collections;

class MusicCatalog
{
    private Hashtable catalog;

    public MusicCatalog()
    {
        catalog = new Hashtable();
    }

    public void AddDisk(string diskName)
    {
        if (!catalog.ContainsKey(diskName))
        {
            catalog.Add(diskName, new ArrayList());
        }
    }
    public void RemoveDisk(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            catalog.Remove(diskName);
        }
    }

    public void AddSong(string diskName, string songName)
    {
        if (catalog.ContainsKey(diskName))
        {
            ArrayList songs = (ArrayList)catalog[diskName];
            songs.Add(songName);
        }
    }

    public void RemoveSong(string diskName, string songName)
    {
        if (catalog.ContainsKey(diskName))
        {
            ArrayList songs = (ArrayList)catalog[diskName];
            songs.Remove(songName);
        }
    }

    public void ViewDiskContents(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            ArrayList songs = (ArrayList)catalog[diskName];
            Console.WriteLine($"Содержимое диска \"{diskName}\":");
            foreach (string song in songs)
            {
                Console.WriteLine(song);
            }
        }
        else
        {
            Console.WriteLine($"Диск \"{diskName}\" не найден в каталоге.");
        }
    }

    public void ViewCatalogContents()
    {
        Console.WriteLine("Содержимое всего каталога:");
        foreach (DictionaryEntry entry in catalog)
        {
            string diskName = (string)entry.Key;
            ArrayList songs = (ArrayList)entry.Value;
            Console.WriteLine($"Диск \"{diskName}\":");
            foreach (string song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}