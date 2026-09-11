namespace Academia;

public class Aluno
{
    public int Id {get; set;}

    public string Nome {get; set;} = string.Empty;  //Nome dO Aluno = string.Empty quer dizer nome vazio 

    public DateTime DataNascimento {get; set;} //mensalidade do plano

     public string? UserId {get; set;} // Id do usuário associado ao profissional (opcional)

    public List<Matricula>? Matriculas {get; set;}  //lista de matriculas associadas ao aluno
    public List<AvaliacaoFisica>? Avaliacoes {get; set;}  //lista de avaliações físicas associadas ao aluno
    public List<Inscricao>? Inscricoes {get; set;}  //lista de inscrições associadas ao aluno

    
}