namespace NumeroEntero;
///<Summary>
///<Createddate>18/06/2023</Createddate>
///<Company>INDEL</Company>
///<Lastmodificationdate>18/06/2023</Lastmodificationdate>
///<Lastmodificationdescription>
///en un solo boton se calculara el cuadrado y el cubo de un número
///</Lastmodificationdescription>
///<Lastmodifierautor>Ingrid Gabriel</Lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// En el evento se calculara el cuadrado y el cubo de un número
	/// y los resultados se mostraran en un entry cada uno y se evaluará si es que
	/// se llega a introducir valores nulos
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private void CalcularNum_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(Numero.Text))
		{
			int num, cuad, cub;

			num= Convert.ToInt32(Numero.Text);

			cuad = (num * 2);
			cub= (num * num * num);

			cuadrado.Text = cuad.ToString();
			Cubo.Text = cub.ToString();
		}
		else
		{
			DisplayAlert("ERROR", "Asegurate de digitar un numero entero", "OK");
		}

    }
}

