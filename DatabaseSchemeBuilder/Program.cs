using System;
using System.Linq;
using DatabaseSchemeBuilder.DB;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DatabaseSchemeBuilder.Encryption;


namespace DatabaseSchemeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {


            database db = new database();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();


            db.Add(new PrefixList
            {
                Prefix = "!"
            });
            db.SaveChanges();
            var DefaultPrefix = db.PrefixLists.AsQueryable().Where(p => p.Prefix == "!").FirstOrDefault();
            db.Add(new Guild
            {

                prefixList = DefaultPrefix

            });
            db.SaveChanges();
            var guild = db.Guilds.Include(l => l.logSettings).ThenInclude(l => l.Logs).FirstOrDefault();
            var logs = guild.logSettings.Logs;
            var MessageAndIv = Encryption.SymmetricEncryption.Encrypt("haha his ip is 192.169.2.2", "Yp3s6v9y$B&E)H@McQfTjWnZq4t7w!z%");
            logs.Add(new Logs
            {
                ServerCaseID = 1,

                PunishedUserId = 1,
                PunishedUserName = "Kasper",
                TypeOfForbiddenMessage = "IP",
                MessagePosted = MessageAndIv.Message,
                IV = MessageAndIv.IV,
                TimePosted = DateTime.Now,
                TimeOfPunishment = DateTime.Now,
                TypeOfPunishment = "Ban",



            });
            db.SaveChanges();
            var MessageAndIv2 = Encryption.SymmetricEncryption.Encrypt("HAHA RandomEmail@gmail.com", "Yp3s6v9y$B&E)H@McQfTjWnZq4t7w!z%");
            logs.Add(new Logs
            {
                ServerCaseID = 2,

                PunishedUserName = "JASON",
                TypeOfForbiddenMessage = "EMAIL",
                MessagePosted = MessageAndIv2.Message,
                IV = MessageAndIv2.IV,
                TimePosted = DateTime.Now,
                TimeOfPunishment = DateTime.Now,
                TypeOfPunishment = "MUTE",



            });
            db.SaveChanges();
            var guild1 = db.Guilds.Include(e => e.EmailSettings).Include(l => l.logSettings).ThenInclude(l => l.Logs).FirstOrDefault();
            var logs1 = guild1.logSettings.Logs;
            foreach (Logs log in logs1)
            {
                Console.WriteLine(Encryption.SymmetricEncryption.Decrypt(log.MessagePosted, "Yp3s6v9y$B&E)H@McQfTjWnZq4t7w!z%", log.IV));
            }



        }
    }
}

