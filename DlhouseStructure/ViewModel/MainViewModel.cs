using DlhouseStructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DlhouseStructure.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }

        public ICommand TinhDamDonGianCmd { get; set; }

        public ICommand TinhDamChiuUonCmd { get; set; }

        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                Isloaded = true;
                LoginWindow loginWindow = new LoginWindow();
                //loginWindow.ShowDialog();
            });

            TinhDamDonGianCmd = new RelayCommand<object>((p) => { return true; }, (p) => { DamDonGianView wd = new DamDonGianView(); wd.ShowDialog(); });
           
        }

    }
}