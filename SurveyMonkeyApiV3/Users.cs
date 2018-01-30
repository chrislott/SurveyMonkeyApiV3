using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyMonkeyApiV3Standard.Models;
using SurveyMonkeyApiV3Standard.Networking;

namespace SurveyMonkeyApiV3Standard
{
    public class Users
    {
        public static async Task<Me> GetSurveys()
        {
            Me response = await SurveyMonkeyRequest.GetRequest<Me>("/users/me");
            return response;
        }
    }
}
