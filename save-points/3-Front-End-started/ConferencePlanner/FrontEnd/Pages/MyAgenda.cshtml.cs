using System.Collections.Generic;
using System.Threading.Tasks;
using ConferenceDTO;
using Microsoft.AspNetCore.Authorization;

namespace FrontEnd.Pages
{
    public class MyAgendaModel : IndexModel
    {
        public MyAgendaModel(IApiClient client, IAuthorizationService authorizationService)
            : base(client, authorizationService)
        {

        }

        protected override Task<List<SessionResponse>> GetSessionsAsync()
        {
            return _apiClient.GetSessionsByAttendeeAsync(User.Identity.Name);
        }
    }
}