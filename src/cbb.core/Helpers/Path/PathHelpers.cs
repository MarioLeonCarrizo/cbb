using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    public static class PathHelpers
    {
        public static string GetFileName(string fullPath)
        {
            if(string.IsNullOrEmpty(fullPath)) 
                return string.Empty;

            var lastIndex = fullPath.LastIndexOf('\\');

            if(lastIndex <= 0)
                return fullPath;

            return Path.GetFileNameWithoutExtension(fullPath.Substring(lastIndex +1));
        }

        public static string GetFolderName(string fullPath)
        {
            if (string.IsNullOrEmpty(fullPath))
                return string.Empty;

            var lastIndex = fullPath.LastIndexOf('\\');

            if (lastIndex <= 0)
                return fullPath;

            return fullPath.Substring(lastIndex + 1);
        }
    }
}
