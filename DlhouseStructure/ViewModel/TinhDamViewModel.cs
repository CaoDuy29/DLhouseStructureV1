using System;
using System.Windows;
using System.Windows.Input;

namespace DlhouseStructure.ViewModel
{
    public class TinhDamViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand TinhToanDamCommand { get; set; }
        public ICommand CanelDamCommand { get; set; }

        private double _ChieuRongDam;
        public double ChieuRongDam
        {
            get => _ChieuRongDam;
            set
            {
                _ChieuRongDam = value;
                OnPropertyChanged();
            }
        }

        public void SettingData()
        {
            ChieuRongDam = 300;

        }

        public TinhDamViewModel()
        {
            SettingData();

            TinhToanDamCommand = new RelayCommand(ExecuteTinhToanDamCommand);
            // Initialize other commands as needed, e.g., CanelDamCommand
            // CanelDamCommand = new RelayCommand(ExecuteCanelDamCommand, CanExecuteCanelDamCommand);
        }

        private void ExecuteTinhToanDamCommand()
        {
            // Implement the action to display "Hello"
            MessageBox.Show("Đã pick vào tính toán  ");
        }

    }
}
