using DataAccessLibrary;
using NPOI.SS.Formula.Functions;
using SqlVersicherteDataAccessLib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlVersicherteDataAccessLib
{
    public class versichertenData : IversichertenData
    {
        private readonly ISqlVersichertenDataAccess _db;

        public versichertenData(ISqlVersichertenDataAccess db)
        {
            _db = db;
        }

        public Task<List<VersichertenModel>> GetVersicherten()
        {
            string sql = "select * from dbo.versicherten";

            return _db.LoadData<VersichertenModel, dynamic>(sql, new { });
        }

        public Task InsertVersicherter(VersichertenModel versicherter)
        {
            string sql = @"insert into dbo.versicherten (FullName,StraßenHausNummer, PlzNummer, TelefonNummer, FaxNummer, EmailAdresse,  Bemerkung, VertagserstenDatum, BankverbindungIban)
                              values (@FullName, @StraßenHausNummer, @PlzNummer, @TelefonNummer, @FaxNummer,@EmailAdresse, @Bemerkung, @VertagserstenDatum,@BankverbindungIban);";
                                 
            return _db.SaveData(sql, versicherter);
        }
    }
}

