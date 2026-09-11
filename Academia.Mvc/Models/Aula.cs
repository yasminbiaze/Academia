namespace Academia;

public class Aula
{
    public int Id {get; set;}
    public string Nome {get; set;} = string.Empty; // Nome de Profissional = string.Empty quer dizer valor vazio 
    public DayOfWeek DiaDaSemana {get; set;} // Dia da semana da aula
    public TimeSpan Horario {get; set;} // Horário da aula
    public int VagasTotais {get; set;} // Número total de vagas disponíveis na aula

    public int ProfissionalId {get; set;} // Id do profissional associado à aula 
    public Profissional? Profissional {get; set;} // Referência ao profissional associado à matricula (opcional)
    
    public List<Inscricao>? Inscricoes {get; set;}  //lista de inscrições associadas ao aluno

}
