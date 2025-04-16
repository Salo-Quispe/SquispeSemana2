namespace squispeS2A.Views;

public partial class vElementos : ContentPage
{
	public vElementos()
	{
		InitializeComponent();
	}

    private void btnPaises_Clicked(object sender, EventArgs e)
    {
		try
		{
			if (pkPaises.SelectedIndex == -1) {

				DisplayAlert("Error", "El dato no existe", "Cerrar");

			}
			else
            {
                string pais = pkPaises.Items[pkPaises.SelectedIndex].ToString();
                DisplayAlert("Paises", "El pais seleccionado es " + pais, "Cerrar");
            }
        }
		catch (Exception ex)
		{

			DisplayAlert("error", ex.Message, "cerrar");
		}
		
    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
		string date = fecha.Date.ToString();
        DisplayAlert("error", "La fecha es "+ date, "cerrar");
    }
} 