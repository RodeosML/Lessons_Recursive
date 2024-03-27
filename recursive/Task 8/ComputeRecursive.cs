using System;
using System.Linq;

namespace recursive.Task8
{
    //8. Поиск всех файлов в заданном каталоге, включая файлы, расположенные в подкаталогах произвольной вложенности
    public class Recursive_EighthTask
    {
        public static void folderTraversal(string path)
        {
            DirectoryInfo folder = new DirectoryInfo(path);
            if (folder.Exists)
            {
                printTraversal(folder);
            }
        }

        private static void printTraversal(DirectoryInfo folder)
        {
            foreach (var file in folder.GetFiles())
            {
                Console.WriteLine("Имя файла:");
                Console.WriteLine(file.Name);
                Console.WriteLine("Его каталог:");
                Console.WriteLine(file.DirectoryName);
            }

            foreach (var subFolder in folder.GetDirectories())
                recursiveTraversal(subFolder);
        }

    }

}

