using System.Windows;
using System.Windows.Input;
using WpfInfrastructureTemplateMVVM.Infrastructure.Commands;
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

        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion

        #endregion



        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion

        }
    }
}
