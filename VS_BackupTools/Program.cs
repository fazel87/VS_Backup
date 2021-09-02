using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace VS_BackupTools
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime thisDay = DateTime.Now;
            if (args.Length >= 3)
            {
                if (Directory.Exists(args[0].BackSlashPath2SlashPath()) && !File.Exists(args[1].BackSlashPath2SlashPath()) && Directory.Exists(Path.GetDirectoryName(args[1].BackSlashPath2SlashPath())))
                {
                    ZipFile.CreateFromDirectory(args[0].BackSlashPath2SlashPath(), args[1].BackSlashPath2SlashPath() + "-" + args[2] + "-" + thisDay.ToString("yyyy-MM-dd hh.mm.ss") + ".zip");
                }
            }
        }
    }
}
