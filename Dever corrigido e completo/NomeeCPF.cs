using System;
using System.Threading;


namespace OBJETOS04_09
{
    class Pessoa
    {
        //Atributos
        private string nome;
        private int idade;
        private double peso;
        private double altura;
        private string cpf;

        //Metodo Construtor (Não é função e nem procedimento, ele da vida a classe)
        public Pessoa()
        {
            this.nome = "";
            this.idade = 0;
            this.peso = 0.0;
            this.altura = 0.0;
            this.cpf = "";

        } //Fim do método construtor

        public Pessoa(string cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;

        } //Fim da classe Pessoa

        public string NomeCPF()
        {
            return this.nome + "-" + this.cpf;
        }

    } //Fim da classe Pessoa
}//Fim do namespace OBJETOS04_09

//CODIGO CENTRAL;



namespace OBJETOS04_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa("000000000000", "Richard Dawson");
            Console.WriteLine(pessoa2.NomeCPF());
            Console.WriteLine("\n\n\n Pressione qualquer tecla para sair...");
            Console.ReadKey(true);

        } //Fim do método main
    } // Fim da classe Program
} // Fim do OBJETOS04-09 
