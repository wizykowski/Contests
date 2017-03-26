using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadline
{
    public class IOClient
    {
        public void LearnState(GameState game)
        {
            // TODO: Console.Readline();
            throw new NotImplementedException();
        }

        public bool TakeAction(Result r)
        {
            // TODO: Console.WriteLine();
            throw new NotImplementedException();
        }

        public void SaveResult(Result r)
        {
            // take name from executing file
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = Path.GetDirectoryName(location);
            var fileName = Path.GetFileNameWithoutExtension(location);

            // create folder if not exist
            var resultDirectory = Path.Combine(directory, "Output", fileName);
            Directory.CreateDirectory(resultDirectory);

            // find txt file 
            var files = Directory.EnumerateFiles(resultDirectory, "*.txt");
            var file = files.Any() ? Path.GetFileNameWithoutExtension(files.First()) : null;
            var oldFilePath = file == null ? null : Path.Combine(resultDirectory, file + ".txt");

            if (file != null)
                File.Delete(oldFilePath);

            var newFilePath = Path.Combine(resultDirectory, $"{GameState.LevelNumber}-{r.State.CaseNumber}.txt");
            var stdout = Console.Out;
            using (var writer = new StreamWriter(newFilePath))
            {
                Console.SetOut(writer);
                TakeAction(r);
            }
            Console.SetOut(stdout);
        }
    }
}
