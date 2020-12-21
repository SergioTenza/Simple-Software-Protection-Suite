using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Funphotos_Protection_Suite
{
    public static class ComputerData
    {        
        [Required,Range(1,100)]
        public static List<string> CPU { get; set; }

        [Required, Range(1, 100)]
        public static List<string> HDD { get; set; }

        [Required, Range(1, 100)]
        public static List<string> BIOS { get; set; }

        [Required,Range(25,25)]
        public static string PRIVATE_KEY { get; set; }

    }
}
