public class OrdemServico
{
    public string data_abertura { set; get; }
    public string data_fechamento { set; get; }
    public string status_servico { get; set; }
    public string descricao { get; set; }
    public string observacoes { get; set; }
    public string idos { get; set; }
    public string cpf { get; set; }
    public string idmaterial { get; set; }
    public string idtec { get; set; }

    public Cliente Cliente { get; set; }
    public Material Material { get; set; }
    public Tecnico Tecnico { get; set; }

    public List<Material> Materiais { get; set; }
    public List<Tecnico> Tecnicos{ get; set; }



}