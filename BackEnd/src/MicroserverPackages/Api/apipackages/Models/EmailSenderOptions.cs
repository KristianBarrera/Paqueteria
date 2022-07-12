
namespace apipackages.Models;


public class EmailSenderOptions
{
  public int Port { get; set; }
  public string Email { get; set; }
  public string Password { get; set; }
  public bool EnableSsl { get; set; }
  public string Host { get; set; }
}