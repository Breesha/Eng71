using System;
using System.IO;
using System.Text;

namespace Lab_13_FileOperations_Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            //////File Operations////
            // set path
            string path1 = Directory.GetCurrentDirectory();
            string path2 = Path.GetFullPath(Path.Combine(path1, @"..\..\..\\lyrics\"));
            //// readalltext(string) method: opens text file, reads all text, closes file
            //string lyrics = File.ReadAllText(path2 + "/Wonderwall.txt");
            //Console.WriteLine(lyrics);

            ////writealltext(string, string), creates a new file which writes a specific string to said file
            //File.WriteAllText(path2 + "ChampagneSupernova.txt", "In Champagne Supernova in the sky!");

            ////writealltext(string, string[]), creates a new file which writes an array as lines
            //string[] lyrics = { "So", "Sally", "Can", "Wait" };
            //File.WriteAllLines(path2 + "/DontLookBackInAnger.txt", lyrics);

            //Exists(string) checks if file exists
            var path3 = path2 + @"\myLyrics.txt";
            //if (!File.Exists(path3))
            //{
            //    //create a file to write too
            //    string[] createText = { "Hello", "I'm", "Nish" };
            //    File.WriteAllLines(path3, createText);
            //}

            ////Open the file to read from
            //string[] readText = File.ReadAllLines(path3);

            //foreach (var item in readText)
            //{
            //    Console.WriteLine(item);
            //}

            //Append text
            //string appendText = "And I'm happy" + Environment.NewLine;
            //File.AppendAllText(path3, appendText);

            //copy(string, string, bool)
            //File.WriteAllText(path2 + @"/oldLyrics.txt", "Hey now, I'm  an Allstar");

            ////Copy newlyrics.txt into oldLyrics.txt and overwrite if oldLyrics.txt already exists
            //string oldLyrics = path2 + @"/oldLyrics.txt";
            //string newLyrics = path2 + @"/newLyrics.txt";
            //File.Copy(oldLyrics, newLyrics, false);

            ////Delete(string)
            //File.Delete(path2 + @"/oldLyrics.txt");

            ////info about our files
            //DateTime lastWriteTime = File.GetLastWriteTime(path3);
            //DateTime creationTime = File.GetCreationTime(path3);
            //var fileinfo = new FileInfo(path3);
            //Console.WriteLine("Last write time: "+ lastWriteTime + "Creation Time: " + creationTime);
            //Console.WriteLine(fileinfo.DirectoryName, fileinfo.Extension);



            /////Folder Operations////
            ///
            ////Put all files in directory in an array
            //var fileArray = Directory.GetFiles(path2);
            //foreach (var item in fileArray)
            //{
            //    Console.WriteLine(item);
            //}

            ////Create directory
            //Directory.CreateDirectory(path2 + "/FolderA");
            //Directory.Delete(path2 + "/FolderA");

        }
    }
}
