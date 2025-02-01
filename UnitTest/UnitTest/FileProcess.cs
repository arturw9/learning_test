﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitTest
{
    public class FileProcess
    {
        public bool FileExist(string fileName) 
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }
            return File.Exists(fileName);
        }
    }
}
