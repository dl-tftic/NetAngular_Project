using System;
using System.Text;
using DAO.Repository;
using DTO.Models;
using System.IO;

namespace FileImportTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string fileName = @"C:\Users\lisse\Pictures\google_logo.svg";
            byte[] file = System.IO.File.ReadAllBytes(fileName);
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(fileName);
            Console.WriteLine(fileInfo.Length);
            */

            // Console.WriteLine(string.Join("", file));

            // AddressRepository aRepo = new AddressRepository();
            // Address address = aRepo.Get(1);

            /*
            FilesRepository fileRepo = new FilesRepository();
            Console.WriteLine(fileRepo.Get(1).FileName);
            Files fileWrite = fileRepo.Get(2);
            System.IO.File.WriteAllBytes(Path.Combine(@"C:\Users\lisse\Pictures\", fileWrite.FileName + "2"), fileWrite.FileByte);
            */

            /*
            string fileName2 = @"C:\Users\lisse\Pictures\google_logo2.svg";
            System.IO.FileInfo fileInfo2 = new System.IO.FileInfo(fileName2);
            Files fileTest2 = new Files();
            fileTest2.Name = "test import";
            fileTest2.FileName = fileInfo2.Name;
            fileTest2.FileExension = fileInfo2.Extension;
            fileTest2.FileByte = System.IO.File.ReadAllBytes(fileName2);
            fileTest2.FileSize = fileInfo2.Length;
            fileTest2.CreateBy = 1;
            Console.WriteLine(fileRepo.Insert(fileTest2)); 
            */

            /*
            string projectDirectory = @"C:\Users\lisse\Documents\Technofuturtic\Projet";
            string projectFilename = Path.Combine(projectDirectory, "ProjectFile.svg");
            string productFilename = Path.Combine(projectDirectory, "ProductFile.svg");
            byte[] projectByte = System.IO.File.ReadAllBytes(projectFilename);
            byte[] productByte = System.IO.File.ReadAllBytes(productFilename);
            string projectString = string.Empty;
            string productString = string.Empty;
            
            foreach (byte b in projectByte)
            {
                projectString = string.Concat(projectString, b.ToString());
                //Console.WriteLine(b.ToString()); 
            }

            foreach (byte b in productByte)
            {
                productString = string.Concat(productString, b.ToString());
                //Console.WriteLine(b.ToString()); 
            }

            Console.WriteLine(projectString); 
            */
        }
    }
}

