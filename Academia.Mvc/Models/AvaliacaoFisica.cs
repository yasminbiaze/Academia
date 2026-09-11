namespace Academia;

public class AvaliacaoFisica
{
    public int Id {get; set;}
    public DateTime DataInicio {get; set;} // Data de avaliação física
    public decimal Peso {get; set;} // Peso do aluno na avaliação física
    public string? Observacoes {get; set;} // Observações adicionais da avaliação física

    public string? AlunoId {get; set;} // Id do aluno associado à matricula
    public Aluno? Aluno {get; set;} // Referência do aluno associado à matricula (opcional)
}
