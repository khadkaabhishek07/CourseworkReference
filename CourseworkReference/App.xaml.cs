namespace CourseworkReference
{
    public partial class App : Application
    {
        private readonly MainPage mainPage;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //MainPage = mainPage;
        }
    }
}
