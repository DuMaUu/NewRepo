using System.ComponentModel.DataAnnotations;

namespace NovoBackEnd.Models
{
	public class Dados
	{
		[Key]
		public int DadosID { get; set; }

		public string Nome  { get; set; }

		public string Descricao  { get; set; }

		public int Poligonos { get; set; }
	}
}