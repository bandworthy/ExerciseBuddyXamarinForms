
//using System.Collections.Generic;
//using System.Text;
using System;
using SQLite.Net.Attributes;

namespace ExerciseAppMay
{
    public class ExerciseItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  int Accessory { get; set; }
        public int Time { get; set; }
        public int Intensity { get; set; }

    }
}
