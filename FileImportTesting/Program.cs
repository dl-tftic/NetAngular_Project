using System;
using System.Text;
using DAO.Repository;
using DTO.Models;
using System.IO;
using System.Collections.Generic;

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

            /*
            // ************ City ***********
            CitiesRepository cityR = new CitiesRepository();
            Cities cityId = cityR.Get(1);
            IEnumerable<Cities> cityByName = cityR.GetByName("lou");
            IEnumerable<Cities> cityByPostalCode = cityR.GetByPostalCode("7110");
            IEnumerable<Cities> cityByCountry = cityR.GetCityByCountry(21);
            */

            /*
            // ************ Role ***********
            RoleRepository roleR = new RoleRepository();
            Roles role = roleR.Get(1);
            */

            /*
            // ************ Account ***********
            AccountRepository accR = new AccountRepository();
            Account account = accR.Get(1);
            Account account1 = accR.GetAccountByLogin("dave");
            Account account2 = accR.GetAccountByLogin("davde");
            */

            /*
            // ************ Supplier ***********
            SupplierRepository suppR = new SupplierRepository();
            Supplier supplier = suppR.Get(1);
            */

            // ************ Project ***********
            ProjectRepository projectR = new ProjectRepository();
            Project project = projectR.Get(1);
            IEnumerable<Project> projectAccount = projectR.GetProjectByAccountId(1);
            IEnumerable<Project> projectByName = projectR.GetProjectByName("maison");

        }
    }
}

