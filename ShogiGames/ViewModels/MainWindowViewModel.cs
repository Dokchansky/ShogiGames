using ShogiGames.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShogiGames.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Сёги 将棋";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);          
        }
        #endregion
    }
}
