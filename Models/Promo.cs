namespace SebastianCruz_EjercicioCF.Models
{
    public class Promo
    {
        public int PromoID { get; set; }
        public string? Description { get; set; }
        public DateTime FechaPromo {  get; set; }

        public int Id { get; set; }
        public Burguer? Burguer { get; set; }
    }
}
