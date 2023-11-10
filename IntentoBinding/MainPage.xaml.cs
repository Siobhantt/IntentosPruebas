namespace IntentoBinding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {

            //Esta es la manera de bindear en codigo C#
            //Tambien se puede hacer en el XAML
            InitializeComponent();
            //label.BindingContext = slider;
            //label.SetBinding(Label.RotationProperty, "Value");
            
            //robot.BindingContext = slider;
            //robot.SetBinding(Image.RotationProperty, "Value");
                
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}