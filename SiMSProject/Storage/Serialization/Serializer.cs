﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SiMSProject.Storage
{
    class Serializer<T> where T : Serializable, new()
    {
        private static char DELIMITER = '|';
        public void toCSV(string fileName, List<T> objects)
        {
            using StreamWriter streamWriter = new StreamWriter(fileName);


            foreach (Serializable obj in objects)
            {
                string line = string.Join(DELIMITER.ToString(), obj.toCSV());
                streamWriter.WriteLine(line);
            }
        }

        public List<T> fromCSV(string fileName)
        {
            List<T> objects = new List<T>();

            foreach (string line in File.ReadLines(fileName))
            {
                string[] csvValues = line.Split(DELIMITER);
                T obj = new T();
                obj.fromCSV(csvValues);
                objects.Add(obj);
            }

            return objects;
        }
    }
}