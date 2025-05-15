namespace eguamanExamen.Views;

public partial class vRegistrar : ContentPage
{
    string usuarioConectado;
    public vRegistrar(string usuario)
	{
		InitializeComponent();
        usuarioConectado = usuario;
        lblUsuario.Text = $"Usuario Conectado: {usuarioConectado}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.OpenWindow(new Window(new vVerresumen()));

    }
}