﻿using System.Data.SQLite;
using System.IO;

namespace AmicsDeLaMusicaClassLibrary.Src.DataBase
{
    class DataBaseService
    {

        public SQLiteConnection connection;

        public DataBaseService()
        {

            connection = new SQLiteConnection($"Data Source={Path.GetFullPath(@"..\..\")}AmicsDeLaMusica.db;New=False;");

        }
    }
}
