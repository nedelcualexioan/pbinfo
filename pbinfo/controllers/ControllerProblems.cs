using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using pbinfo.classes;

namespace pbinfo.controllers
{
    public class ControllerProblems
    {
        private List<Problem> problems;

        public ControllerProblems()
        {
            problems = new List<Problem>();

            citire();
        }
        private void citire()
        {
            StreamReader read = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"db\database.txt");

            String line = "";

            while ((line = read.ReadLine()) != null)
            {
                problems.Add(new Problem(int.Parse(line.Split(',')[0]), line.Split(',')[1], line.Split(',')[2],
                    line.Split(',')[3]));
            }
        }
    }
}