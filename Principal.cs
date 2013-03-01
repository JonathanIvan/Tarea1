using System;

namespace Practica3
{
	public class Principal
	{
		public Principal ()
		{

		}
		public static void Main (string[] args)
		{
			persona persona=new persona();
			
			Console.WriteLine("Introduzca su Nombre:");
			persona.nombre =Console.ReadLine(); 

			Console.WriteLine("Introduzca su Domicilio");
			persona.domicilio =Console.ReadLine(); 
			
			Console.WriteLine("Introduzca su Telefono:");
			persona.telefono =Console.ReadLine(); 

			Console.WriteLine("Introduzca su Email:");
			persona.email =Console.ReadLine(); 
			
			Console.Clear();

			
			Console.WriteLine();
			Console.WriteLine("Nombre: "+persona.nombre);
			Console.WriteLine();
			Console.WriteLine("Domicilio: "+persona.domicilio);
			Console.WriteLine();
			Console.WriteLine("Telefono: "+persona.telefono);
			Console.WriteLine();
			Console.WriteLine("Email: "+persona.email);
			Console.WriteLine();

		}
	}
}

