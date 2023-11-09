using MovilApp.Vistas;

namespace MovilApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("home", typeof(HomePage));
            Routing.RegisterRoute("cliente", typeof(ClientesPage));
            Routing.RegisterRoute("salir", typeof(LogoutPage));
        }
    }
}