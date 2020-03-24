using System;
using System.Globalization;

namespace Membros_Estasticos
{
    class Program
    {

       
        static void Main(string[] args)
        {
            /*Também chamado de membros de classe
             •Oposição de membros e instância
             •São membros que fazem sentido independente de objetos.Não precisa de objeto para serem chamados.São chamados apartir do proprio nome da classe.
             •Aplicação comum:
             -Classes utilitarias
             -Declaração constante
             •Uma classe que só possui membros estasticos pode ser uma classe estatica também.Essa classe não podera ser instanciada.
             
            →Fazer um Programa para ler um valor númerico qualquer,e daí mostrar quanto seria o valor de uma circunferência e do volume de uma esfera para o raio daquele valor.
            Informa também o valor de Pi COM DUAS CASAS DECIMAIS*/


            //Na classe calculadora coloquei o static no caso não precisei instanciar um objeto

           

            Console.WriteLine("Entre com o Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência:" + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor Pi:" + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        
        }

        
    }
}
