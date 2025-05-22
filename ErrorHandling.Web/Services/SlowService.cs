using System.Threading.Tasks;

namespace ErrorHandling.Web.Services;

public class SlowService
{
    public async Task DoSlowWork()
    {
        await Task.Delay(3000);
    }
}
