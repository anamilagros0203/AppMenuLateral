using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPageMenuFlyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPageMenuFlyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutPageMenuFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class FlyoutPageMenuFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutPageMenuFlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPageMenuFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPageMenuFlyoutMenuItem>(new[]
                {
                    new FlyoutPageMenuFlyoutMenuItem { Id = 0, Title = "HOME",IconSource="home.png", TargetType = typeof(Home)},
                    new FlyoutPageMenuFlyoutMenuItem { Id = 1, Title = "UBICACION",IconSource="placeholder.png", TargetType = typeof(Ubicacion)},
                    new FlyoutPageMenuFlyoutMenuItem { Id = 2, Title = "INFO",IconSource="info.png", TargetType = typeof(Info)},
                    new FlyoutPageMenuFlyoutMenuItem { Id = 3, Title = "EMAIL",IconSource="email.png", TargetType = typeof(Email)},
                    new FlyoutPageMenuFlyoutMenuItem { Id = 4, Title = "CONTACT",IconSource="contact-book.png", TargetType = typeof(Contact)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}