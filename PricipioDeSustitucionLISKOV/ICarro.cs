namespace PrincipioDeSustitucionLISKOV
{
    public interface ICarro
    {
        int ID { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        decimal PrecioEconomico();
    }
}