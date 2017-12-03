using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FIndDupFile
{
    public class DirInfo
    {
        public string Path { get; set; }
        public DateTime Last { get; set; }

        public string LastDate { get
            {
                if (Last == DateTime.MinValue)
                    return "-";
                else
                    return Last.ToString();
            }
        }

        public DirInfo(string path, string dt = "")
        {
            Path = path;

            if (!string.IsNullOrEmpty(dt))
            {
                Last = DateTime.Parse(dt);
            }
        }
    }
}
