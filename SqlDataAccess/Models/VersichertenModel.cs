﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SqlVersicherteDataAccessLib.Models
{
    public class VersichertenModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }

        public string StraßenHausNummer { get; set; }

        public string PlzNummer { get; set; }

        public string TelefonNummer { get; set; }

        public int FaxNummer { get; set; }

        public string EmailAdresse { get; set; }

        public string Bemerkung { get; set; }

        public DateTime VertagserstenDatum { get; set; }

        public string BankverbindungIban { get; set; }

        enum Typ 
        {  Schule, 
                
        Kindergarten,
                
        Sonstige 
        
        }


    }
}
