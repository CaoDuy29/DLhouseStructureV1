using System;
using System.Windows;
using System.Windows.Input;

namespace DlhouseStructure.ViewModel
{
    public class DamDonGianViewModel : BaseViewModel
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

        private double _rongSanLs;
        public double RongSanLs
        {
            get => _rongSanLs;
            set
            {
                _rongSanLs = value;
                OnPropertyChanged();
            }
        }

        private double _daySanHs;
        public double DaySanHs
        {
            get => _daySanHs;
            set
            {
                _daySanHs = value;
                OnPropertyChanged();
            }
        }

        private double _taiTrenSanqs;
        public double TaiTrenSanqs
        {
            get => _taiTrenSanqs;
            set
            {
                _taiTrenSanqs = value;
                OnPropertyChanged();
            }
        }

        private double _taiTrenDamqt;
        public double TaiTrenDamqt
        {
            get => _taiTrenDamqt;
            set
            {
                _taiTrenDamqt = value;
                OnPropertyChanged();
            }
        }

        private double _heSoDieuChinh;
        public double HeSoDieuChinh
        {
            get => _heSoDieuChinh;
            set
            {
                _heSoDieuChinh = value;
                OnPropertyChanged();
            }
        }

        private double _lopBaoVea;
        public double LopBaoVea
        {
            get => _lopBaoVea;
            set
            {
                _lopBaoVea = value;
                OnPropertyChanged();
            }
        }



        public void SettingData()
        {
            ChieuRongDam = 300;
            ChieuCaoDam = 500;
            DaiSanLd = 2000;
            DaySanHs = 150;
            TaiTrenSanqs = 5;
            TaiTrenDamqt = 15;
            LopBaoVea = 25;
            HeSoDieuChinh = 0.9;


        }

        public DamDonGianViewModel()
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
