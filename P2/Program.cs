//using System;
//using System.IO;

//Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
//    "MyAnd"));



//DriveInfo[] drives = DriveInfo.GetDrives();

//foreach (DriveInfo drive in drives)
//{
//    Console.WriteLine($"Название: {drive.Name}");
//    Console.WriteLine($"Тип: {drive.DriveType}");
//    if (drive.IsReady)
//    {
//        Console.WriteLine($"Объем диска: {drive.TotalSize}");
//        Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
//        Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
//    }
//    Console.WriteLine();
//}

using System;
using System.Collections.Generic;
using System.IO;

namespace TestConcole
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //string catalog = @"E:";//Диск поиска
            //string fileName = "*.mp?";//Шаблон поиска

            ////проводим поиск в выбранном каталоге и во всех его подкаталогах
            //foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName, SearchOption.AllDirectories))

            //{
            //    FileInfo FI;
            //    try
            //    {
            //        //по полному пути к файлу создаём объект класса FileInfo
            //        FI = new FileInfo(findedFile);
            //        //найденный результат выводим в консоль (имя, путь, размер, дата создания файла)
            //        Console.WriteLine(FI.Name + " " + FI.FullName + " " + FI.Length + "_байт" +
            //            " Создан: " + FI.CreationTime);
            //    }
            //    catch //слишком длинное имя файла
            //    {
            //        continue;
            //    }
            //}



            //Directory.CreateDirectory(Path.Combine(@"E:\", "MyAnd"));
            ////Directory.CreateDirectory(Path.Combine(@"E:\", "pfr"));

            //System.IO.Directory.Move(@"E:\pfr\*", @"E:\");




            //string path = @"E:\";
            //Directory.CreateDirectory(Path.Combine(@"E:\", "pfr"));
            //string newPath = @"E:\pfr\";
            //FileInfo fileInf = new FileInfo(path);
            //if (fileInf.Exists)
            //{

            //    fileInf.MoveTo(newPath);
            //    //    // альтернатива с помощью класса File
            //    //     //File.Move(path, newPath);
            //}



            //DriveInfo[] drives = DriveInfo.GetDrives();

            //foreach (DriveInfo drive in drives)
            //{
            //    Console.WriteLine($"Название: {drive.Name}");
            //    Console.WriteLine($"Тип: {drive.DriveType}");

            //    if (drive.IsReady)
            //    {
            //        Console.WriteLine($"Объем диска: {drive.TotalSize}");
            //        Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
            //        Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
            //    }
            //    Console.WriteLine();
            //}













            //string directory = project.Directory;
            //string directoryTmp = project.Directory + @"\tmp\";

            //DirectoryInfo source = new DirectoryInfo(directoryTmp);
            //DirectoryInfo destin = new DirectoryInfo(directory);







            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                var driveDriveType1 = Convert.ToString(drive.DriveType);//Приобразование типов в строку

                if (driveDriveType1 == "Removable")//Проверка диска на фактор флешки через переменную
                {
                    //Создание папки
                    string f = "drav";
                    Directory.CreateDirectory(Path.Combine(drive.RootDirectory + @"\" + f));


                    foreach (var item in drive.RootDirectory.GetDirectories())
                    {
                        //Перемещение в папку
                      //  item.MoveTo(drive.RootDirectory + @"\" + f + @"\" + item.Name);
                        
                    }



                    string catalog = @"E:";//Диск поиска
                    string fileName = "*.mp?";//Шаблон поиска

                    //проводим поиск в выбранном каталоге и во всех его подкаталогах
                    foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName, SearchOption.AllDirectories))

                    {
                        FileInfo FI;
                        try
                        {
                            var g = Convert.ToString(drive.RootDirectory);

                            //по полному пути к файлу создаём объект класса FileInfo
                            FI = new FileInfo(findedFile);
                            FI.MoveTo(g + @"\" + FI.Name);
                            //Console.WriteLine(FI + $" {findedFile}");
                            //Console.ReadLine();
                        }
                        catch //слишком длинное имя файла
                        {
                            continue;
                        }
                    }



                    foreach (var item in drive.RootDirectory.GetDirectories())
                    {
                        Console.WriteLine($"Метка диска: {item}");
                        //item.CopyTo(directory + @"\" + item.Name, true);
                    }

                    foreach (var item in drive.RootDirectory.GetFiles())
                    {
                        Console.WriteLine($"Метка диска: {item}");
                        //item.CopyTo(directory + @"\" + item.Name, true);
                    }

                }
            }
        }

    }
}