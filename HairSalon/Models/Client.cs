namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Pronouns { get; set; }
    public Stylist Stylist { get; set; }
  }
}