using MudBlazor;

namespace afya_admin.Data;

public record Kpi(string Titulo, string Valor, string Variacao, bool Positivo, string Icone, Color Cor, string CorHex, double[] Tendencia);

public record SegmentoCliente(string Nome, int Percentual, Color Cor, string CorHex);

public record ProjetoPerformance(string Nome, string Icone, Color Cor, int Percentual, int TarefasConcluidas, int TarefasTotal);

public record Atividade(string Nome, string Acao, string Tempo, string Icone, Color Cor);

public record ProjetoRecente(string Nome, string Icone, Color Cor, string Cliente, string Responsavel, string Status, Color StatusCor, int Progresso, string Prazo);

public static class DashboardData
{
		public static readonly string[] Periodos = { "Últimos 7 dias", "Últimos 30 dias", "Últimos 90 dias", "Personalizado" };
		
		public static List<Kpi> ObterKpisPorPeriodo(string periodo)
		{
			return periodo switch
			{
				"Últimos 7 dias" => new List<Kpi>
				{
					new("Receita", "R$ 82.833", "+4,1%", true, Icons.Material.Filled.AttachMoney, Color.Success, "#10B981", new double[] { 3, 6, 5, 9, 8, 11, 9, 12, 11, 15 }),
					new("Usuários Ativos", "4.280", "+2,7%", true, Icons.Material.Filled.Groups, Color.Secondary, "#7C3AED", new double[] { 2, 5, 6, 8, 7, 9, 8, 10, 9, 8 }),
					new("Novos Clientes", "128", "+5,53%", true, Icons.Material.Filled.PeopleAlt, Color.Info, "#3B82F6", new double[] { 2, 3, 4, 6, 7, 7, 8, 8, 9, 9 }),
					new("Projetos Ativos", "9", "-0,8%", false, Icons.Material.Filled.Folder, Color.Warning, "#F97316", new double[] { 6, 7, 9, 8, 9, 8, 9, 7, 8, 7 }),
				},
				"Últimos 30 dias" => new List<Kpi>
				{
					new("Receita", "R$ 248.500", "+12,5%", true, Icons.Material.Filled.AttachMoney, Color.Success, "#10B981", new double[] { 10, 14, 12, 18, 16, 21, 19, 24, 23, 29 }),
					new("Usuários Ativos", "12.842", "+8,2%", true, Icons.Material.Filled.Groups, Color.Secondary, "#7C3AED", new double[] { 8, 11, 9, 14, 12, 17, 15, 21, 18, 16 }),
					new("Novos Clientes", "384", "+16,6%", true, Icons.Material.Filled.PeopleAlt, Color.Info, "#3B82F6", new double[] { 6, 9, 8, 12, 14, 13, 17, 16, 19, 18 }),
					new("Projetos Ativos", "27", "-2,4%", false, Icons.Material.Filled.Folder, Color.Warning, "#F97316", new double[] { 12, 15, 19, 16, 18, 15, 17, 14, 15, 12 }),
				},
				"Últimos 90 dias" => new List<Kpi>
				{
					new("Receita", "R$ 745.500", "+37,5%", true, Icons.Material.Filled.AttachMoney, Color.Success, "#10B981", new double[] { 20, 28, 24, 36, 32, 24, 38, 48, 46, 48 }),
					new("Usuários Ativos", "38.526", "+24,6%", true, Icons.Material.Filled.Groups, Color.Secondary, "#7C3AED", new double[] { 16, 22, 18, 24, 26, 34, 30, 42, 36, 32 }),
					new("Novos Clientes", "1.152", "+49,8%", true, Icons.Material.Filled.PeopleAlt, Color.Info, "#3B82F6", new double[] { 12, 18, 16, 24, 28, 26, 34, 32, 38, 36 }),
					new("Projetos Ativos", "81", "+2,4%", true, Icons.Material.Filled.Folder, Color.Warning, "#F97316", new double[] { 24, 31, 40, 30, 35, 33, 35, 26, 25, 29 }),
				},
				_ => new List<Kpi>()
			};
		}
		
		public static readonly string[] Meses = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set" };
		public static readonly double[] ReceitaMensal = { 70000, 117000, 112000, 135000, 165000, 168000, 182000, 212000, 248500 };
		public static readonly double[] MetaMensal = { 25000, 45000, 52000, 68000, 95000, 97000, 118000, 152000, 185000 };
		
		public const int TotalClientes = 1842;
		
		public static readonly List<SegmentoCliente> SegmentosClientes = new()
		{
			new("Empresas", 42, Color.Primary, "#de3162"),
			new("Business", 31, Color.Secondary, "#7C3AED"),
			new("Startup", 18, Color.Success, "#10B981"),
			new("Outros", 9, Color.Warning, "#F97316"),
		};
		
		public static readonly List<ProjetoPerformance> Performance = new()
		{
			new("Website Corporativo", Icons.Material.Outlined.DesktopWindows, Color.Primary, 83, 34, 41),
			new("App Mobile", Icons.Material.Outlined.PhoneIphone, Color.Secondary, 68, 27, 41),
			new("Migração Cloud", Icons.Material.Outlined.Cloud, Color.Success, 92, 46, 50),
			new("Sistema ERP", Icons.Material.Outlined.Storage, Color.Warning, 54, 27, 50),
		};
		
		public static readonly List<Atividade> Atividades = new()
		{
			new("Mariana Souza", "adicionou um novo cliente", "há 5 minutos", Icons.Material.Filled.ArrowUpward, Color.Primary),
			new("Carlos Lima", "finalizou a revisão Website Corporativo", "há 18 minutos", Icons.Material.Filled.Check, Color.Success),
			new("Ana Martins", "publicou um novo relatório", "há 45 minutos", Icons.Material.Filled.Description, Color.Secondary),
			new("João Silva", "atualizou as permissões do sistema", "há 1 hora", Icons.Material.Filled.Settings, Color.Warning),
		};

		public static readonly List<ProjetoRecente> ProjetosRecentes = new()
		{
			new("Portal Institucional", Icons.Material.Outlined.DesktopWindows, Color.Primary, "TechCorp", "Mariana Souza", "Em andamento", Color.Info, 67, "31 Out"),
			new("Aplicativo Mobile", Icons.Material.Outlined.PhoneIphone, Color.Secondary, "Nova Digital", "Carlos Lima", "Em revisão", Color.Warning, 50, "07 Nov"),
			new("Migração Cloud", Icons.Material.Outlined.Cloud, Color.Success, "CloudSystems", "Ana Martins", "Concluído", Color.Success, 100, "20 Set"),
			new("Sistema ERP", Icons.Material.Outlined.Storage, Color.Warning, "Alpha Group", "João Silva", "Em andamento", Color.Info, 48, "15 Out")
		};
}