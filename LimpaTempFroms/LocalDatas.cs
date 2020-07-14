using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LimpaTempFroms
{
    class LocalDatas
    {
        static public string Language()
        {
            return System.Globalization.CultureInfo.CurrentCulture.NativeName;
        }

        static public List<string> TempDirectory()
        {
            List<string> locals = new List<string>();
            locals.Add(Environment.GetLogicalDrives()[0] + "\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\");
            locals.Add(Environment.GetLogicalDrives()[0] + "\\Windows\\Temp");
            locals.Add(Environment.GetLogicalDrives()[0] + "\\Windows\\Prefetch");

            return locals;
        }

        static public int QtdTempFiles()
        {
            int total = 0;
            foreach (string s in TempDirectory())
            {
                if (Directory.Exists(s))
                {
                    total += Directory.GetFiles(s).Length +
                        Directory.GetDirectories(s).Length;
                }
            }

            return total;
        }

        static public int QtdTempFiles(string local)
        {
            if (Directory.Exists(local))
            {
                return Directory.GetFiles(local).Length +
                    Directory.GetDirectories(local).Length;
            }

            return 0;
        }

    }
}
