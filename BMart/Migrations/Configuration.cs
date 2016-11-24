using BMart.Models;

namespace BMart.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.IO;

    internal sealed class Configuration : DbMigrationsConfiguration<BMart.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        //Open file into a filestream and read data in a byte array.
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open,
            FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to 

            //supply number of bytes to read from file.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        protected override void Seed(BMart.Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(x => x.Id,
                new Product()
                {
                    Id = 1,
                    Name = "Red Apple",
                    Description = "Great apple that is red, juicy and organic",
                    Image =
                        ReadFile("C:\\Code\\BMart\\BMart\\Content\\Fruits\\f1p.jpg"),
                    Quantity = "100",
                    Cost = 2.99D,
                    CategoryId = 26
                },
                new Product()
                {
                    Id = 2,
                    Name = "Granny Smith Apple",
                    Description = "An awesome Granny Smith Apple",
                    Image =
                        ReadFile("C:\\Code\\BMart\\BMart\\Content\\Fruits\\f2p.jpg"),
                    Quantity = "100",
                    Cost = 3.20D,
                    CategoryId = 26
                },
                new Product()
                {
                    Id = 3,
                    Name = "Jackfruit",
                    Description = "What can be better than Jackfruit?",
                    Image =
                        ReadFile("C:\\Code\\BMart\\BMart\\Content\\Fruits\\f3p.jpg"),
                    Quantity = "100",
                    Cost = 5.20D,
                    CategoryId = 26
                },
                new Product()
                {
                    Id = 4,
                    Name = "Kiwi",
                    Description = "Yummy Kiwi",
                    Image =
                        ReadFile("C:\\Code\\BMart\\BMart\\Content\\Fruits\\f4p.jpg"),
                    Quantity = "100",
                    Cost = 2.20D,
                    CategoryId = 26
                },
                new Product()
                {
                    Id = 5,
                    Name = "Lemon",
                    Description = "Make your foods taste even better",
                    Image =
                        ReadFile("C:\\Code\\BMart\\BMart\\Content\\Fruits\\f5p.jpg"),
                    Quantity = "100",
                    Cost = 3.20D,
                    CategoryId = 26
                }
                );



        }
    }
}
