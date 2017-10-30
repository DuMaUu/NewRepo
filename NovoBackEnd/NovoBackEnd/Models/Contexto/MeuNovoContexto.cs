using System.Data.Entity;

namespace NovoBackEnd.Models.Contexto
{
	public class MeuNovoContexto : DbContext
	{
		public MeuNovoContexto() : base("strConn")
		{

		}

		public System.Data.Entity.DbSet<NovoBackEnd.Models.Dados> Dados { get; set; }
	}
}