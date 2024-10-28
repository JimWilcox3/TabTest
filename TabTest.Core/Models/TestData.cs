using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TabTest.Core.Models
{
    public class TestDataItem : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int? _TabNo;
        public int? TabNo
        {
            get
            {
                return _TabNo;
            }
            set
            {
                _TabNo = value;
                NotifyPropertyChanged();
            }
        }

        private string? _Description;
        public string? Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                NotifyPropertyChanged();
            }
        }
    }

    public class TestData : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string? _Title;
        public string? Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<TestDataItem>? _Items;
        public ObservableCollection<TestDataItem>? Items
        {
            get
            {
                return _Items;
            }
            set
            {
                _Items = value;
                NotifyPropertyChanged();
            }
        }
    }

}
