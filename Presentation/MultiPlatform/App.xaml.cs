namespace MultiPlatform
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new AppShell());
        //}
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "Presentation" };
        }
    }
}
