﻿using DataLayer.Database;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Helpers;

namespace DataLayer.Services
{
    public class DatabaseUserService
    {
        private readonly DatabaseContext context;

        public DatabaseUserService(DatabaseContext context)
        {
            this.context = context;
        }

        public List<DatabaseUser> GetAll()
        {
            return context.Users.ToList();
        }

        public void PrintAll(List<DatabaseUser> users)
        {
            foreach(DatabaseUser user in users)
            {
                Console.WriteLine(user.ConvertToString());
            }
        }
    }
}