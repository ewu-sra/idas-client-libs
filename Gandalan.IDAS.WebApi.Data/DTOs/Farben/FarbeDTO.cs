﻿using System;
using System.Collections.Generic;

namespace Gandalan.IDAS.WebApi.DTO
{
    public class FarbeDTO
    {
        public Guid FarbItemGuid { get; set; }
        public string Bezeichnung { get; set; }
        public string BildDateiname { get; set; }
        public string FarbCode { get; set; }
        public string Farbe { get; set; }
        public string ArtikelFarbKuerzel { get; set; }
        public DateTime ChangedDate { get; set; }
        public long Version { get; set; }
        public DateTime? GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
    }
}