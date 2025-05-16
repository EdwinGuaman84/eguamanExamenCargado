namespace eguamanExamen.Views;

public partial class vDetalleRegistros : ContentPage
{
    public vDetalleRegistros(Estudiante estudiante)
    {
        InitializeComponent();

        lblUsuario.Text = $"Usuario conectado: {estudiante.Usuario}";
        lblNombre.Text = estudiante.Nombre;
        lblApellido.Text = estudiante.Apellido;
        lblEdad.Text = estudiante.Edad.ToString();
        lblFecha.Text = estudiante.Fecha.ToShortDateString();
        lblCiudad.Text = estudiante.Ciudad;
        lblPais.Text = estudiante.Pais;
        lblInicial.Text = estudiante.MontoInicial.ToString("C2");
        lblMensual.Text = estudiante.PagoMensual.ToString("C2");
        lblTotal.Text = estudiante.PagoTotal.ToString("C2");
    }
}