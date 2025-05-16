namespace eguamanExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        
        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Envuelve vLogin dentro de NavigationPage para habilitar navegación con PushAsync
            return new Window(new NavigationPage(new Views.vLogin()));
        }


    }
}