using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen.Models
{
    public class Wydarzenie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }

        public Wydarzenie(string title, DateTime date, string typ, string priority, string description)
        {
            Title = title;
            Description = description;
            Date = date;
            Type = typ;
            Priority = priority;
        }
        public Wydarzenie() { }
        public override string ToString()
        {
            return $"{Title}, {Date.ToShortDateString()}, {Type}, {Priority}, {Description}";
        }
    }
}