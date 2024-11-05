using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen.Models
{
    public interface IWydarzenieRepository
    {
        void Add(Wydarzenie wydarzenie);
        void Delete(int index);

        void Serialize(string path);

        void Clear();
        IEnumerable<Wydarzenie> Deserialize(string path);
        IEnumerable<Wydarzenie> SortByType(string type);
        
        //IEnumerable<Wydarzenie> FiltrByType(object filterType, object filterValue);
        // IEnumerable<Wydarzenie> FiltrByType(IEnumerable<Wydarzenie> wydarzenia, string type);

    }
}