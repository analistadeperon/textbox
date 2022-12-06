class Client
{
       public string Nome{get; set;}
       public string Telefone{get; set;}
}

dai vc cria um método numa classe d banco para ler esses dados da vc faz o método para leitura algo do tipo

public List<Client> LerClient()
{ 
     
      List<Client> lista = new List<Client>();
   
     SqlCommand cmd = new SqlCommand("select * from Clientes", ConectaBanco());
     SqlDataReader dr = cmd.ExecuteReader();
     while(dr.Read()){
        Client c = new Client();
        c.Nome = dr["nomeDaColunaNoBanco"].ToString();
        lista.Add(c);
      }
      return lista;
}


dae na pagina vc faz algo do tipo

private void teuButton_Click(object sender, EventArgs e)
{
        Client c = new Client();
        List<Client> l = c.LerClient();
        for(int i =0; i < l.Count; i++){
              TeuTextBox.Text = l[i].nome;
        }
}

 

se for util por favor não esqueça de marcar qlqr duvida posta ae

 

 

 

Att Edney Desenvolvedor C#, WindowsForms, Asp.Net WebForms, Asp.Net MVC
Sugerido como Resposta Edgar Esteves quinta-feira, 16 de dezembro de 2010 09:30
quinta-feira, 16 de dezembro de 2010 01:24
Responder|Citação
Avatar de Edney Batista Silva
Edney Batista SilvaICI(Instituto Curitiba I...1,325 Pontos
 
Question
Entrar para Votar
0
Entrar para Votar
Amigo, estou usando SQL Server mesmo....

Porém essa solução que me retorna uma lista não funcionou. Você tem alguma outra forma ?

Obrigado!!

quinta-feira, 16 de dezembro de 2010 12:07
Responder|Citação
Avatar de Saulo Pacífico
Saulo PacíficoProdados Informática10 Pontos
 
Question
Entrar para Votar
0
Entrar para Votar
Que erro está dando meu caro colega? Posta ae q eu te ajudo a resolver mas o mais prático de usar é este msmo

a outros gtos usando datatables (que eu não recomendo pq detona a performace)

posta o erro q ta dando com a lista ae ou melhor posta a estrutura do teu banco aki ou seja:

O Nome da(s) tabela(s) que vc qr fazer o select, O nome e o Tipo de cada coluna de cada tabela pertencente ao select,

e dai posta o código que vc fez assim posso analizar e te ajudamos a superar o erro

 

 

Att Edney Desenvolvedor C#, WindowsForms, Asp.Net WebForms, Asp.Net MVC
quinta-feira, 16 de dezembro de 2010 13:22
Responder|Citação
Avatar de Edney Batista Silva
Edney Batista SilvaICI(Instituto Curitiba I...1,325 Pontos
 
Question
Entrar para Votar
0
Entrar para Votar
Amigo, estou usando SQL Server mesmo....

Porém essa solução que me retorna uma lista não funcionou. Você tem alguma outra forma ?

Obrigado!!


Amigo vou mover seu post no forum asp.net.

 

Just Be Humble Malange!
quinta-feira, 16 de dezembro de 2010 13:31
Responder|Citação
Avatar de Levi Domingos
Levi Domingos50,565 Pontos
Moderador
 
Question
Entrar para Votar
0
Entrar para Votar
Estou tendo dificuldade em implementar esse método, você poderia escreve-lo de uma forma mais clara ? Obrigado!!
quinta-feira, 16 de dezembro de 2010 18:06
Responder|Citação
Avatar de Saulo Pacífico
Saulo PacíficoProdados Informática10 Pontos
 
Question
Entrar para Votar
0
Entrar para Votar
Estou tendo dificuldade em implementar esse método, você poderia escreve-lo de uma forma mais clara ? Obrigado!!
Deixa-nos ver como voce esta fazendo?

Assim fica mais facil de ajudar.

Acho que o problema esta nos conecitos basicos, deve ser por isso...

Deixa-nos ver o seu codigo e a gente diz onde tens de mudar pra funcionar. Por que o exemplo do Edney Deveria funcionar perfeitamente.

?Obrigado.

Just Be Humble Malange!
quinta-feira, 16 de dezembro de 2010 18:32
Responder|Citação
Avatar de Levi Domingos
Levi Domingos50,565 Pontos
Moderador
 
Question
Entrar para Votar
0
Entrar para Votar
<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administracao.Master" AutoEventWireup="true" CodeBehind="Promocoes.aspx.cs" Inherits="NeemiasFotografias.Admin.Promocoes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudoPorPagina" runat="server">
  <h1>Editar promoção da Página Inicial do Site</h1>
  <br />
  <asp:ScriptManager ID="ScriptManager1" runat="server">
  </asp:ScriptManager>
  <asp:UpdatePanel runat="server">
    <ContentTemplate>
      <div id="divVisualisar" runat="server">
      Título principal: 
      <br />
        <asp:Label Text="" runat="server" ID="lblTitulo" />
      <br />
      <br />
      Subtítulo: 
      <br />
        <asp:Label Text="" runat="server" ID="lblSub" />
      <br />
      <br />
      Corpo: 
      <br />
        <asp:Label Text="" runat="server" ID="lblCorpo" />
      <br />
      <br />
      Promoção válida até: 
      <br />
        <asp:Label Text="" runat="server" ID="lblData" />
      <br />
      <br />
        <asp:LinkButton Text="Alterar Promoção" runat="server" ID="btnAlterar" 
          onclick="btnAlterar_Click" /> 
      </div>
      <div id="divAlterar" runat="server">
      Título principal: 
      <br />
      <asp:TextBox runat="server" ID="txtTitulo" Width="200px" />
      <br />
      <br />
      Subtítulo: 
      <br />
      <asp:TextBox runat="server" ID="txtSub" Width="200px" />
      <br />
      <br />
      Corpo: 
      <br />
      <asp:TextBox runat="server" ID="txtCorpo" Width="200px" TextMode="MultiLine" Rows="10" />
      <br />
      <br />
      Promoção válida até: 
      <br />
      <asp:TextBox runat="server" ID="txtData" Width="200px" />
      <br />
      <br />
      <asp:Button Text="Alterar Promoção" runat="server" ID="btnGravar" 
          onclick="btnGravar_Click" /> 
        <asp:Button Text="Cancelar" runat="server" ID="btnCancelar" 
          onclick="btnCancelar_Click" />
      </div>
    </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphGeral" runat="server">
</asp:Content>

 Essa é minha Página ASPX, no código do botão "btnGravar" ele salva as alterações certinho, porém gostaria de trazer o que já está no banco e preencher os textbox e os label.

Abaixo segue o C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Text;

namespace NeemiasFotografias.Admin
{
  public partial class Promocoes : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      divAlterar.Visible = false;
      divVisualisar.Visible = true;
    }

    protected void btnAlterar_Click(object sender, EventArgs e)
    {
      divAlterar.Visible = true;
      divVisualisar.Visible = false;

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
      divAlterar.Visible = false;
      divVisualisar.Visible = true;
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
      SqlConnection conn = new SqlConnection(
        WebConfigurationManager.ConnectionStrings[
        "NeemiasFotografiasConnectionString"].ConnectionString);

      StringBuilder sql = new StringBuilder();
      sql.Append("UPDATE Promocoes SET TituloPromo=@TituloPromo, SubPromo=@SubPromo, TextoPromo=@TextoPromo, DataExpiracao=@DataExpiracao ");
      SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
      cmd.Parameters.AddWithValue("@TituloPromo", txtTitulo.Text );
      cmd.Parameters.AddWithValue("@SubPromo", txtSub.Text);
      cmd.Parameters.AddWithValue("@TextoPromo", txtCorpo.Text);
      cmd.Parameters.AddWithValue("@DataExpiracao", txtData.Text);

      conn.Open();
      cmd.ExecuteNonQuery();
      conn.Close();

    }
  }
}
