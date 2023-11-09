using IntentoListView.Model;

namespace IntentoListView.Views;

public partial class EjemploCollectionView : ContentPage
{
	public EjemploCollectionView()
	{
		InitializeComponent();
		collectionView.ItemsSource = GetCitas();
	}
	private List<Citas> GetCitas()
	{
		return new List<Citas>
		{
			new Citas {Direccion = "Calle Frias 9 "},
			new Citas {Direccion = "Calle Madrid 20 "},
			new Citas {Direccion = "Calle Avion 1 "},
			new Citas {Direccion = "Calle Trapichito 8 "},
			new Citas {Direccion = "Calle Aguila 5 "},
            new Citas {Direccion = "Calle Frias 9 "},
            new Citas {Direccion = "Calle Madrid 20 "},
            new Citas {Direccion = "Calle Avion 1 "},
            new Citas {Direccion = "Calle Trapichito 8 "},
            new Citas {Direccion = "Calle Aguila 5 "}
        };
	}
}