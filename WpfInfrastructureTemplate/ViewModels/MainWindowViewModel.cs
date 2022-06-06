using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfInfrastructureTemplate.ViewModels.Base;

namespace WpfInfrastructureTemplate.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region Заголовок окна
        private string _title;
        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get =>  _title;
            set =>  Set(ref _title, value);
        }
        #endregion
    }
}
