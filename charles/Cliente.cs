namespace charles;

public class Cliente
{
String Nome;
Int64 Id;
Int64 Telefone;
String CPF;
public void SetNome(string Nome)

{
    this.Nome = Nome;
}
public string GetNome()
{
    return Nome;
}
public void SetCPF(string CPF)

{
    this.CPF = CPF;
}
public string GetCPF()
{
    return CPF;
}


}