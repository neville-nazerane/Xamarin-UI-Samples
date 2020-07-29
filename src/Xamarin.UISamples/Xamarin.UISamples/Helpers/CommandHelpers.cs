using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.UISamples.Helpers
{
    public static class CommandHelpers
    {

        public static ICommand Build(Func<Task> asyncAction)
        {
            bool canExecute = true;
            Command cmd = null;
            async void cmdAction() 
            {
                canExecute = false;
                cmd.ChangeCanExecute();
                await asyncAction();
                canExecute = true;
                cmd.ChangeCanExecute();
            }
            cmd = new Command(cmdAction, () => canExecute);
            return cmd;
        }

        public static ICommand PushPageCommand<TPage>()
            where TPage : Page, new()
        {
            return Build(async () => {
                await Application.Current.MainPage.Navigation.PushModalAsync(new TPage());
            });
        }

    }
}
