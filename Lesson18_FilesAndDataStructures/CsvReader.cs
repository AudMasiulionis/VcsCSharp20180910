using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_FilesAndDataStructures
{
    class CsvReader
    {
        public List<NileData> ReadFromFile()
        {
            var data = new List<NileData>();
            using (var reader = new StreamReader("c:/temp/nile.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] columns = reader.ReadLine().Trim().Split(',');

                    var obj = new NileData
                    {
                        Year = Convert.ToInt32(columns[0]),
                        Flood = Convert.ToDouble(columns[1])
                    };

                    data.Add(obj);
                }
            }
            return data;
        }
    }
}
