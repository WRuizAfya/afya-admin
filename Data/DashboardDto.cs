using System.Text.Json.Serialization;
using MudBlazor;

namespace afya_admin.Data;

public class KpiDto
{
    public string Titulo { get; set; } = "";
    public string Valor { get; set; } = "";
    public string Variacao { get; set; } = "";
    public bool Positivo { get; set; }
    
    [JsonPropertyName("icone")]
    public string IconeTexto { get; set; } = "";
    
    public string CorHex { get; set; } = "";
    public double[] Tendencia { get; set; } = Array.Empty<double>();

    public Color Cor => CorHex.ToUpper() switch
    {
        "#10B981" => Color.Success,
        "#7C3AED" => Color.Secondary,
        "#3B82F6" => Color.Info,
        "#F97316" => Color.Warning,
        "#DE3162" => Color.Primary,
        _ => Color.Default
    };
	
    public string Icone => IconeTexto switch
    {
        "AttachMoney" => Icons.Material.Filled.AttachMoney,
        "Groups" => Icons.Material.Filled.Groups,
        "PeopleAlt" => Icons.Material.Filled.PeopleAlt,
        "Folder" => Icons.Material.Filled.Folder,
        _ => Icons.Material.Filled.Help
    };
}

public class SegmentoClienteDto
{
    public string Nome { get; set; } = "";
    public int Percentual { get; set; }
    public string CorHex { get; set; } = "";
	
	public Color Cor => CorHex.ToUpper() switch
    {
        "#10B981" => Color.Success,
        "#7C3AED" => Color.Secondary,
        "#3B82F6" => Color.Info,
        "#F97316" => Color.Warning,
        "#DE3162" => Color.Primary,
        _ => Color.Default
    };
}

public class ProjetoPerformanceDto
{
    public string Nome { get; set; } = "";
    public string Icone { get; set; } = "";
    public int Percentual { get; set; }
    public int TarefasConcluidas { get; set; }
    public int TarefasTotal { get; set; }
    public string CorHex { get; set; } = "";
	
	public Color Cor => CorHex.ToUpper() switch
    {
        "#10B981" => Color.Success,
        "#7C3AED" => Color.Secondary,
        "#3B82F6" => Color.Info,
        "#F97316" => Color.Warning,
        "#DE3162" => Color.Primary,
        _ => Color.Default
    };
}

public class AtividadeDto
{
    public string Nome { get; set; } = "";
    public string Acao { get; set; } = "";
    public string Tempo { get; set; } = "";
    public string Icone { get; set; } = "";
    public string CorHex { get; set; } = "";
	
	public Color Cor => CorHex.ToUpper() switch
    {
        "#10B981" => Color.Success,
        "#7C3AED" => Color.Secondary,
        "#3B82F6" => Color.Info,
        "#F97316" => Color.Warning,
        "#DE3162" => Color.Primary,
        _ => Color.Default
    };
}

public class ProjetoRecenteDto
{
    public string Nome { get; set; } = "";
    public string Icone { get; set; } = "";
    public string Cliente { get; set; } = "";
    public string Responsavel { get; set; } = "";
    public string Status { get; set; } = "";
    public int Progresso { get; set; }
    public string Prazo { get; set; } = "";
    public string CorHex { get; set; } = "";
	
	public Color Cor => CorHex.ToUpper() switch
    {
        "#10B981" => Color.Success,
        "#7C3AED" => Color.Secondary,
        "#3B82F6" => Color.Info,
        "#F97316" => Color.Warning,
        "#DE3162" => Color.Primary,
        _ => Color.Default
    };
}

public class DashboardDto
{
    public List<string> Periodos { get; set; } = new();
    public Dictionary<string, List<KpiDto>> KpisPorPeriodo { get; set; } = new();
    public string[] Meses { get; set; } = Array.Empty<String>();
    public double[] ReceitaMensal { get; set; } = Array.Empty<double>();
    public double[] MetaMensal { get; set; } = Array.Empty<double>();
    public int TotalClientes { get; set; } = 1842;
    public List<SegmentoClienteDto> SegmentosClientes { get; set; } = new();
    public List<ProjetoPerformanceDto> Performance { get; set; } = new();
    public List<AtividadeDto> Atividades { get; set; } = new();
    public List<ProjetoRecenteDto> ProjetosRecentes { get; set; } = new();
}