namespace Intento2Examen
{
    public partial class MainPage : ContentPage
    {
        int acierto = 0;
        int fallo = 0;
        public MainPage()
        {
            InitializeComponent();

        }

        private void acierto_Clicked(object sender, EventArgs e)
        {   
            //Necesito entender el sender
            Button bt = (Button)sender;
            //Cuando se toque el boton se establece la propiedad de opacity a 1
            bt.Opacity = 1;
            //Se aumentan los aciertos
            acierto++;
            //Se muestran en pantalla
            tvacierto.Text = "Aciertos" + acierto.ToString();
        }

        public void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            fallo++;
            tvfallo.Text = "Fallos" + fallo.ToString(); 
        }
    }
}