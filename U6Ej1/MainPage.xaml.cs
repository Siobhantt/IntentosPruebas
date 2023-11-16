namespace U6Ej1
{
    public partial class MainPage : ContentPage
    {
        Boolean btexiste = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (btexiste==false)
            {
                Button bt3 = new Button
                {

                    Text = "Boton 3",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    BackgroundColor = Color.FromArgb("#0000FF"),
                    BorderColor = Color.FromArgb("#FFFF00"),
                    WidthRequest = 200,
                    HeightRequest = 70,
                    FontFamily = "Verdana",
                    BorderWidth = 5,
                    IsEnabled = true,
                    
                };
                btexiste=true;
                layout.Add(bt3);
                bt3.Clicked += funcionalidad;
            }
            
        }

        public void funcionalidad(object sender, EventArgs e)
        {
            layout.Remove(bt1);
            bt2.Text = "Crear controles en tiempo de ejecución mola";
        }
    }
}