using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Puerta
{
    int ancho;
    int alto;
    int color;
    bool abierta;
    public void Abrir()
    {
        abierta = true;
    }
    public void Cerrar()
    {
        abierta = false;
    }
    public int GetAncho()
    {
        return ancho;

    }
    public void SetAncho(int nuevoValor)
    {
        ancho = nuevoValor;
    }
    public void MostrarEstado()
    {
        Console.WriteLine("Ancho:{0}", ancho);
        Console.WriteLine("Alto:{0}", alto);
        Console.WriteLine("Color:{0}", color);
        Console.WriteLine("Abierta:{0}", abierta);

    }

}
namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Puerta p = new Puerta();

            Console.WriteLine("Valores iniciales...");
            p.MostrarEstado();

            Console.WriteLine();

            Console.WriteLine("Vamos a abrir...");
            p.Abrir();
            p.SetAncho(65);
            p.MostrarEstado();

            Console.ReadLine();
        }
    }
}
