using SqlVersicherteDataAccessLib.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqlVersicherteDataAccessLib
{
    public interface IversichertenData
    {
        Task<List<VersichertenModel>> GetVersicherten();
        Task InsertVersicherter(VersichertenModel versicherter);
    }
}