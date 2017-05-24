//using System;
using System.Collections.Generic;
//using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace ExerciseAppMay
{
    //this file is randomthoughtdatabase
    class ExerciseAppDatabase
    {
        /*
        readonly SQLiteAsyncConnection database;

        public ExerciseAppDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<ExerciseItem>().Wait();
        }

     
        public Task<List<ExerciseItem>> GetExerciseItemsAsync()
        {
            return database.QueryAsync<ExerciseItem>("SELECT * FROM [ExerciseItem] ");
        }

        public Task<ExerciseItem> GetExerciseItemAsync(int id)
        {
            return database.Table<ExerciseItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(ExerciseItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(ExerciseItem item)
        {
            return database.DeleteAsync(item);
        }
        */

    }
}
