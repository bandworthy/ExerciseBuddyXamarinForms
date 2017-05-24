using System;
using System.Collections.Generic;
using System.Text;

using System;
using SQLite.Net.Attributes;

namespace ExerciseAppMay.Model
{
    class MusicItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
