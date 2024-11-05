using AdministratorWydarzen.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AdministratorWydarzen.Models
{
    public class WydarzenieRepository : IWydarzenieRepository
    {
        private List<Wydarzenie> _repositoryList;
        public WydarzenieRepository()
        {
            _repositoryList = new List<Wydarzenie>();
        }

        public void Add(Wydarzenie wydarzenie)
        {
            _repositoryList.Add(wydarzenie);
        }

        public void Delete(int index)
        {
            _repositoryList.RemoveAt(index);
        }

        public void Clear()
        {
            _repositoryList.Clear();
        }

        public void Serialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Wydarzenie>));

            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, _repositoryList);
            }
        }

        public IEnumerable<Wydarzenie> Deserialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Wydarzenie>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return (List<Wydarzenie>)serializer.Deserialize(fs);
            }
        }

        public IEnumerable<Wydarzenie> SortByType(string type)
        {

            if (type == "Po typie")
            {
                return _repositoryList.OrderBy(wydarzenie => wydarzenie.Type).ToList();
            }
            else if (type == "Po priorytecie")
            {
                return _repositoryList.OrderBy(wydarzenie => wydarzenie.Priority).ToList();
            }
            else
            {
                return _repositoryList.OrderBy(wydarzenie => wydarzenie.Date).ToList();
            }
        }
        /*
        public IEnumerable<Wydarzenie> Filter(string key)
        {
            //string pattern = @"[0-9]{2}\.[0-9]{2}\.[0-9]{4}";
            if (key == "Niski" || key == "Średni" || key == "Wysoki")
            {
                return _repositoryList.Where(ev => ev.Priority == key).ToList();
            }
            else if (key == "Praca" || key == "Rodzina" || key == "Przyjaciele" || key == "Rozrywka" || key == "Zdrowie" || key == "Sport" || key == "Inne")
            {
                return _repositoryList.Where(ev => ev.Type == key).ToList();
            }
            else if (Regex.IsMatch(key, @"[0-9]{2}\.[0-9]{2}\.[0-9]{4}"))
            {
                return _repositoryList.Where(ev => ev.Date.ToShortDateString() == key).ToList();
            }
            else
            {
                return _repositoryList.ToList();
            }
        }
        /*
        public IEnumerable<Wydarzenie> FiltrByType(string filteredBy, string filter)
        {
            if (filteredBy == "Po typie")
            {
                if (filter == "Rodzina")
                {
                    return _repositoryList.Where(w => w.Type == "Rodzina").OrderBy(w => w.Type).ToList();
                }
                else if (filter == "Rozrywka")
                {
                    return _repositoryList.Where(w => w.Type == "Rozrywka").OrderBy(w => w.Type).ToList();
                }
                else if (filter == "Praca")
                {
                    return _repositoryList.Where(w => w.Type == "Praca").OrderBy(w => w.Type).ToList();
                }
                else if (filter == "Sport")
                {
                    return _repositoryList.Where(w => w.Type == "Sport").OrderBy(w => w.Type).ToList();
                }
                
            }
            else if (filteredBy == "Po priorytecie")
            {
                int priorityFilter = 0;
                if (filter == "Niski")
                {
                    priorityFilter = 1;
                }
                else if (filter == "Średni")
                {
                    priorityFilter = 2;
                }
                else if (filter == "Wysoki")
                {
                    priorityFilter = 3;
                }

                return _repositoryList.Where(w => w.Priority == priorityFilter.ToString()).OrderBy(w => w.Priority).ToList();
            }

            // Zwróć pustą listę jeśli nie spełniono żadnego warunku
            return new List<Wydarzenie>();
        }

        public IEnumerable<Wydarzenie> FiltrByType(object filterType, object filterValue)
        {
            throw new NotImplementedException();
        }
    }*/

    }
}
