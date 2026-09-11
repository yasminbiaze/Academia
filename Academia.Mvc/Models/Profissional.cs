namespace Academia;

public class Profissional
{
    public int Id {get; set;}
    public string Nome {get; set;} = string.Empty; //Nome de Profissional = string.Empty quer dizer valor vazio 
    public string Especialidade {get; set;} = string.Empty; //Especialidade (ex: Musculação, Pilates, Nutrição) = string.Empty quer dizer valor vazio
    public string? UserId {get; set;} // Id do usuário associado ao profissional (opcional)

    public List<Aula>? Aulas {get; set;}  //lista de aulas associadas ao profissional (opcional)
}