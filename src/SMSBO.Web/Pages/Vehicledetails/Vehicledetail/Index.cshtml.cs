using System.Threading.Tasks;

namespace SMSBO.Web.Pages.Vehicledetails.Vehicledetail
{
    public class IndexModel : SMSBOPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
