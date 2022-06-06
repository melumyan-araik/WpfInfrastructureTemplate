using WpfInfrastructureTemplateMVVM.ViewModels.Base;

namespace WpfInfrastructureTemplateMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region Заголовок окна
        private string _title = "Заголовок окна";
        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get =>  _title;
            set =>  Set(ref _title, value);
        }
        #endregion
    }
}
