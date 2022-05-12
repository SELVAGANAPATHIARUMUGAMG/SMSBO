using System.Threading.Tasks;

namespace SMSBO.Web.Pages.Teachers.Teacher
{
    public class IndexModel : SMSBOPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
