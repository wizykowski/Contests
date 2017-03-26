using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Deadline;
using System.Threading;

namespace GUIs
{
    static class Program
    {
        public static SolverUI solverUI;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var client = new IOClient();

            var thread = new Thread(new ThreadStart(() =>
            {
                Deadline.Program.RunClient(client, (server) =>
                    {
                        solverUI = new SolverUI(server);
                        return solverUI;
                    });
            }));
            thread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI());
        }
    }
}
