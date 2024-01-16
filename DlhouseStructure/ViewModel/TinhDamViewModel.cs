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

        private double _chieuRongDam;
        public double ChieuRongDam
        {
            get => _chieuRongDam;
            set
            {
                _chieuRongDam = value;
                OnPropertyChanged();
            }
        }

        private double _chieuCaoDam;
        public double ChieuCaoDam
        {
            get => _chieuCaoDam;
            set
            {
                _chieuCaoDam = value;
                OnPropertyChanged();
            }
        }

        private double _daiSanLd;
        public double DaiSanLd
        {
            get => _daiSanLd;
            set
            {
                _daiSanLd = value;
                OnPropertyChanged();
            }
        }


        public void SettingData()
        {
            ChieuRongDam = 300;

            ChieuCaoDam = 500;
            DaiSanLd = 2000;

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

            DaiSanLd = ChieuCaoDam * 50;
            //MessageBox.Show("Đã pick vào tính toán  ");
        }

    }
}
