using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PR7_Converts.Models
{
    public class Deposit : INotifyPropertyChanged
    {
        private string _clientName = "";
        public string ClientName
        {
            get => _clientName;
            set
            {
                if (_clientName != value)
                {
                    _clientName = value;
                    OnPropertyChanged();
                }
            }
        }

        private float _amount;
        public float Amount
        {
            get => _amount;
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Income));
                }
            }
        }

        private float _annualRate;
        public float AnnualRate
        {
            get => _annualRate;
            set
            {
                if (_annualRate != value)
                {
                    _annualRate = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Income));
                }
            }
        }

        private int _months;
        public int Months
        {
            get => _months;
            set
            {
                if (_months != value)
                {
                    _months = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Income));
                }
            }
        }

        public float Income
        {
            get
            {
                var income = Amount * AnnualRate * Months / 12f;
                return income;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
