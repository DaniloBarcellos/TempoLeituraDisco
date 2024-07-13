
namespace TempoDisco
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            const int height = 800;
            const int width = 1000;

            window.Width = window.MaximumWidth = window.MinimumWidth = width;
            window.Height = window.MaximumHeight = window.MinimumHeight = height;

            return window;
        }
    }
}
