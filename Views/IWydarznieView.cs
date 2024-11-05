using AdministratorWydarzen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen.Views
{
    public interface IWydarzenieView
    {
        string Title { get; set; }
        string Description { get; set; }
        DateTime Date { get; set; }
        string Type { get; set; }
        string Priority { get; }
        string SortType { get; }
        
        string FiltrType { get; }
        /*
        object FilterType { get; }
        object FilterValue { get; }
        */

        event EventHandler AddWydarzenie;
        event EventHandler DeleteWydarzenie;
        event EventHandler SerializeWydarzenie;
        event EventHandler DeserializeWydarzenie;
        event EventHandler SortWydarzenie;
        event EventHandler FiltrWydarzenie;

        bool SetErrorTitleBox();
        bool SetErrorDescrBox();
        bool SetErrorComboBox();
        bool SetErrorPriorityBox();

        bool SetErrorSortBox();
        bool SetErrorFiltrBox();

        void DataGridUpdate(Wydarzenie wydarzenie);
        void DataGridClear();
        List<int> DataGridDeleteRows();
    }
}