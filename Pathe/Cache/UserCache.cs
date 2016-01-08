﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pathe;
using Pathe.Classes;
using Pathe.Database;


namespace Pathe.Cache
{
    public static class UserCache
    {
        //fields
        private static DatabaseHandler db = new DatabaseHandler();



        //properties 

        public static List<Users> ListOfUsers
        { get; set; }

        public static void UpdateCache()
        {
            List<Users> item = db.GetUserCache();
            ListOfUsers = item;
        }
    }
}