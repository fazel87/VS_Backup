using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_BackupTools
{
    static class PathConverter
    {
        public static string BackSlashPath2SlashPath(this string path)
        {
            return path.Replace('\\', '/');
        }
    }
}
