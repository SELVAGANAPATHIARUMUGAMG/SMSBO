using System.Threading.Tasks;

namespace SMSBO.Web.Pages.Students.Student
{
    public class IndexModel : SMSBOPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
