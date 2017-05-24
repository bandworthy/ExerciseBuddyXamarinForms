using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

using System;
using SQLite.Net.Attributes;

namespace ExerciseAppMay.Model
{
    class RoutineItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
