public class Livro
{
    public string Titulo;
    public Autor Autor;
    public double Preco;

    public Livro (string titulo, Autor autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
        public Livro (string titulo, Autor autor, double preco)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = preco;
    }

    public void MostrarInfo()
        {
            Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Preço {Preco}");
        }
    public void Desconto(double porcentagem)
    {
         if (porcentagem < 0 || porcentagem > 100)
         {
            Console.WriteLine ("Porcentagem de desconto Invalida!");
            return;
         }
        Preco -= Preco *(porcentagem/100);
    }
    public void Desconto(int valorFixo)
    {
        if (valorFixo < 0)
        {
            Console.WriteLine("Valor fixo de desconto invalido!");
            return;
        }
        Preco -= valorFixo;
        if (Preco < 0 )
        {
            Preco = 0;
        }
    }
}






// Classe Livro:

// Atributos: Titulo (string), Autor (Autor), Preco (double).
// Construtores:
// Um construtor que inicializa Titulo e Autor.
// Outro construtor que inicializa Titulo, Autor e Preco.
// Método MostrarInfo para exibir as informações do livro.
// Método sobrecarregado AplicarDesconto:
// Um método que aceita um double representando a porcentagem de desconto e aplica ao preço do livro.
// Outro método que aceita um int representando um valor fixo de desconto e aplica ao preço do livro.