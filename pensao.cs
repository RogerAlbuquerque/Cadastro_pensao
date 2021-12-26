using System;


public class estudante
{

    public string nome { get; private set; }
    public string email { get; private set; }
    public int dormitorio { get; set; }





    public estudante(string nome, string email, int quarto)
    {
        this.nome = nome;
        this.email = email;
        dormitorio = quarto;
    }

}




class principal
{

    static void Main(string[] args)
    {

        Random numQuarto = new Random();     
        
        int qrtsVazios = quartos;

        Console.WriteLine("Quantos cadastros serão feitos ? ");
        int n = int.Parse(Console.ReadLine());           
        estudante[] aluno = new estudante[n];


        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Qual o nome do Inquilino/aluno ? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o email do Inquilino/aluno ? ");
            string email = Console.ReadLine();

            int dormitorio = numQuarto.Next(1, 10);          

            aluno[i] = new estudante(nome, email, dormitorio);
            
            qrtsVazios -= 1;
            Console.WriteLine("-----------------------------------------------------------\n");

        }


        Console.WriteLine("\n***********************************************************");
        Console.WriteLine("Dados Dos inquilinos informados anteriormente");
        Console.WriteLine("***********************************************************\n");



        for (int i = 0; i < n; i++)
        {

            Console.WriteLine("Dados do inquilino:");

            Console.WriteLine("Nome: {0} \nEmail: {1} \nQuarto: {2}", aluno[i].nome, aluno[i].email, aluno[i].dormitorio);

            Console.WriteLine("-----------------------------------------------------------\n");


        }

        Console.WriteLine("Número de quartos disponíveis:\n{0}", qrtsVazios);
    }

}