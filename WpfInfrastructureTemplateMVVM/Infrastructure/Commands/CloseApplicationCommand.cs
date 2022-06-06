using System.Windows;
using WpfInfrastructureTemplateMVVM.Infrastructure.Commands.Base;

namespace WpfInfrastructureTemplateMVVM.Infrastructure.Commands
{
    internal class CloseApplicationCommand : CommandBase
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
