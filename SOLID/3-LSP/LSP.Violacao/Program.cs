using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.LSP.Violacao
{
	class Program
	{
		static void Main(string[] args)
		{
			var quadrado = new Quadrado()
			{
				Altura = 10,
				Largura = 5
			};

			ObterAreaRetangulo(quadrado);
		}

		private static void ObterAreaRetangulo(Retangulo retangulo)
		{
			Console.WriteLine("Calculo da área do Retangulo");
			Console.WriteLine(retangulo.Altura.ToString() + " * " + retangulo.Largura.ToString());
			Console.WriteLine(retangulo.Area);
			Console.ReadKey();
		}
	}
}
