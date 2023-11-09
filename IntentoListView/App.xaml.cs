using IntentoListView.Views;

namespace IntentoListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EjemploCollectionView();
        }
    }
}