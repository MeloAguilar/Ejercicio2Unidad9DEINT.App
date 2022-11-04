using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio2Unidad9DEINT.Models
{
	public class clsPersona : INotifyPropertyChanged
	{
		#region Atributos
		private String nombre;
		private String nombreCompleto;
		#endregion

		#region Propiedades
		public String Nombre { 
			get
			{
				return nombre; 
			} 
			set
			{
				this.nombre = value;
				NotifyPropertyChanged("NombreCompleto");
				
			}
		}
		public String  Apellidos { get; set; }

		public String NombreCompleto { get { return nombreCompleto = (Nombre + " " +Apellidos); } set {  } }
		public int Id { get; set; }

		#endregion

		#region Constructores
		public clsPersona(string nombre, string apellidos, int id)
		{
			Nombre=nombre;
			Apellidos=apellidos;
			Id=id;
		}

		public clsPersona()
		{
			Nombre = "Pepito";
			Apellidos = "Winwon";
			Id = 0;
		}
		#endregion


		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}


		private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}