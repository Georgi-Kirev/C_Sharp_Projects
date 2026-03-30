
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

public class Program
{

    public static void Main(string[] args)
    {

        int numberOfSongs = int.Parse(Console.ReadLine());
        List<SongsClass> songsList = new List<SongsClass>(numberOfSongs);

        for (int i = 0; i < numberOfSongs; i++)
        {
            string addSong = Console.ReadLine();
            string TypeList = addSong.Split("_")[0];
            string Name = addSong.Split("_")[1];
            string Time = addSong.Split("_")[2];

            SongsClass songFromConsole = new SongsClass(TypeList, Name, Time);
            songsList.Add(songFromConsole);
        }

        string lastInput = Console.ReadLine();

        foreach (SongsClass song in songsList)
        {
            if (song.TypeList == lastInput || lastInput == "all")
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}
