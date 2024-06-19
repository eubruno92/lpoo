public class Autor
{
    public string Nome;
    public string Nacionalidade;
    public Autor(string nome, string Nacionalidade)
    {
        Nome = nome;
        this.Nacionalidade = Nacionalidade;
    }
     public void MostrarInfo()
        {
            Console.WriteLine($"Autor: {Nome}, Nacionalidade: {Nacionalidade}");
        }
}
















// Classe Autor:

// Atributos: Nome (string), Nacionalidade (string).
// Construtor para inicializar Nome e Nacionalidade.
// Método MostrarInfo para exibir as informações do autor.