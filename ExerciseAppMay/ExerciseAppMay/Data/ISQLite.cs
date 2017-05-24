using System;
using SQLite.Net;

namespace ExerciseAppMay.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
