namespace eguamanExamen.Views;

public partial class vLogin : ContentPage
{
    private readonly string[,] credenciales = new string[2, 2] {
            { "estudiante", "moviles" }, 
            { "uisrael", "2024" }        
        };

    public vLogin()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var user = entryUsuario.Text?.Trim();
        var pass = entryContrasena.Text?.Trim();

        for (int i = 0; i < 2; i++)
        {
            if (credenciales[i, 0] == user && credenciales[i, 1] == pass)
            {
               

                DisplayAlert("Bienvenido:", user, "",  "OK");
                Application.Current.OpenWindow(new Window(new vRegistrar(user)));



                return;
            }
        }

        DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");


    }
}