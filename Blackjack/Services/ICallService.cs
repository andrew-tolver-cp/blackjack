using Blackjack.Models;

namespace Blackjack.BL.Services
{
  public interface ICallService
  {
    NetworkCall GetCall(int id);
  }
}
