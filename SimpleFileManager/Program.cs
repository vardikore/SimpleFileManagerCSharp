using System;
using System.IO;

class FileManager
{
        FileManager manager = new FileManager();
        manager.LoadState();
        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            string[] command = input.Split(' ');
            switch (command[0])
            {
                case "ls":
                    manager.ListFiles();
                    break;
                case "cd":
                    manager.ChangeDirectory(command[1]);
                    break;
                case "cp":
                    manager.CopyFile(command[1], command[2]);
                    break;
                case "rm":
                    manager.DeleteFile(command[1]);
                    break;
                case "info":
                    manager.GetFileInfo(command[1]);
                    break;
                case "exit":
                    manager.SaveState();
                    return;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }