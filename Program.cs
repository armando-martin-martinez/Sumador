using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sumador
{
	static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			int a;
			int b;
			int sumaab;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1(5, 9, &sumaab));
		}

		/* 
            Un segundo Main para que pruebes con el form que hice.
            Para que inicie por aca le puedes intercambiar el nombre con el otro main
            o llamar a este directo si estas llamando desde C++
        */
		[STAThread]
		static void _Main()
		{
			int a, b;
			int suma;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			ResultForm formulario = new ResultForm(a, b);
			suma = formulario.show_get_result();    //Esta funcion muestra el form y espera a que se cierre y devuelve la suma
		}
	}
}
