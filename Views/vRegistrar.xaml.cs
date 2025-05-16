namespace eguamanExamen.Views;

public partial class vRegistrar : ContentPage
{
    private string usuario;

    public vRegistrar(string usuario)
    {
        InitializeComponent();
        this.usuario = usuario;
        lblUsuario.Text = $"Usuario conectado: {usuario}";
    }

    private async void OnVerResumenClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(entryNombre.Text) ||
            string.IsNullOrWhiteSpace(entryApellido.Text) ||
            string.IsNullOrWhiteSpace(entryEdad.Text) ||
            string.IsNullOrWhiteSpace(entryInicial.Text))
        {
            await DisplayAlert("Error", "Por favor complete todos los campos", "Aceptar");
            return;
        }

         double montoInicial = double.Parse(entryInicial.Text);
        double saldo = 1500 - montoInicial;
        double cuotaMensual = (saldo / 4) + (1500 * 0.04);

        entryMensual.Text = cuotaMensual.ToString("F2");

        var estudiante = new Estudiante
        {
            Nombre = entryNombre.Text,
            Apellido = entryApellido.Text,
            Edad = int.Parse(entryEdad.Text),
            Fecha = dpFecha.Date,
            Ciudad = pickerCiudad.SelectedItem?.ToString(),
            Pais = pickerPais.SelectedItem?.ToString(),
            MontoInicial = montoInicial,
            PagoMensual = cuotaMensual,
            Usuario = usuario
        };
                 
       await Navigation.PushAsync(new Views.vDetalleRegistros(estudiante));
    }
    private void OnCalcularClicked(object sender, EventArgs e)
    {
            if (double.TryParse(entryInicial.Text, out double montoInicial))
            {
            double costoCurso = 1500;
            double restante = costoCurso - montoInicial;
            double pagoCuota = (restante / 4) * 1.04;
            entryMensual.Text = pagoCuota.ToString("F2");
        }
        else
        {
            DisplayAlert("Error", "Ingrese un monto inicial válido", "OK");
        }
    }


}