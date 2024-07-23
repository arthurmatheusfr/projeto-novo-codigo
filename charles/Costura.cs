namespace charles;

public class Costura
{
   String Pecas;
   bolso Bolso;
   passador Passador;
   GanchoFrontal Ganchof;
   GanchoTraseiro Ganchob;
   bocas Bocas;
   
   public void SetBolso(bolso Bolso)

{
    this.Bolso = Bolso;
}
public string GetBolso()
{
    return Bolso;
}
public void SetPassador(passador Passador)

{
    this.Passador = Passador;
}
public string GetPassador()
{
    return Passador;
}
public void SetBocas(bocas Bocas)

{
    this.Bocas = Bocas;
}
public string GetBocas()
{
    return Bocas;
}
public void SetGanchof(GanchoFrontal Ganchof)

{
    this.Ganchof = Ganchof;
}
public string GetGanchof()
{
    return Ganchof;
}
public void SetGanchob( GanchoTraseiro Ganchob)

{
    this.Ganchob = Ganchob;
}
public string GetGanchob()
{
    return Ganchob;
}


}