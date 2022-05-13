using System.Threading.Tasks;

namespace SMSBO.Web.Pages.OfficeStaffs.OfficeStaff
{
    public class IndexModel : SMSBOPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
