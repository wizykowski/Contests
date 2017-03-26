﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using Deadline;


namespace Deadline
{
    public static partial class Program
    {
        public static void RunNCases()
        {
            int num;
            var line = Console.ReadLine();
            line = line.ParseToken(out num);

            for (int i = 0; i < num; i++)
            {
                RunCase();
            }
        }

        public static void RunCase()
        {
            Solution solver = new Solution(new IOClient(), 1);
            solver.GetData();
            solver.Act();
        }

        public static void RunClient(IClient client, Func<IClient, SolutionBase> newSolver)
        {
            SolutionBase solver = newSolver(client);
            while (true)
            {
                solver.GetData();
                if (solver.Act() == false)
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.OpenStandardInput();
            Console.OpenStandardOutput();

            RunCase();
            //RunNCases();
        }
    }
}

