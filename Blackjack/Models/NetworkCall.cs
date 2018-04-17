using System.Collections.Generic;

namespace Blackjack.Models
{
  public class NetworkCall
  {
    public string EndPoint { get; set; }
    public List<string> Parameters { get; set; }
    public List<string> Headers { get; set; }
  }
}
