using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sumador
{
	static class Program
	{
		/* 
            Un segundo Main para que pruebes con el form que hice.
        */
		[STAThread]
		static void Main()
		{
			int a, b;
			int suma;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			ResultForm formulario = new ResultForm(a, b);
			suma = formulario.show_get_result();    //Esta funcion muestra el form y espera a que se cierre y devuelve la suma
		}



        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main_disabled() //Le cambie el nombre para que el otro sea llamado por defecto
		{
			int a;
			int b;
			int sumaab;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1(5, 9, &sumaab));
		}
	}
}
