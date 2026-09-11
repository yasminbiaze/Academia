namespace Academia;

public class Matricula
{
    public int Id {get; set;}
    public DateTime DataInicio {get; set;} // Data de inicio da matricula
       public string? AlunoId {get; set;} // Id do aluno associado à matricula
       public string? PlanoId {get; set;} // Id do plano associado à matricula

    public Aluno? Aluno {get; set;} // Referência do aluno associado à matricula (opcional)
    public Plano? Plano {get; set;} // Referência do plano associado à matricula (opcional)
}
