﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeQrScanner.Models
{
    public class DTOPet
    {
        public int petId { get; set; }
        public string ownerName { get; set; }
        public string ci { get; set; }
        public string petName { get; set; }
        public string specie { get; set; }
        public string breed { get; set; }
        public string gender { get; set; }
        public string description { get; set; }

        public List<string>? photos { get; set; }

    }
}
