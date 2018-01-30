using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyMonkeyApiV3Standard.Models; 
using SurveyMonkeyApiV3Standard.Networking;

namespace SurveyMonkeyApiV3Standard
{
    public class Groups
    {
        public static async Task<List<Group>> GetGroups()
        {
            BaseResponse<Group> response = await SurveyMonkeyRequest.GetRequest<BaseResponse<Group>>("/groups");
            return response.data;
        }

        public static async Task<GroupDetail> GetGroupDetails(long groupId)
        {
            GroupDetail response = await SurveyMonkeyRequest.GetRequest<GroupDetail>(string.Format("/groups/{0}", groupId));
            return response;
        } 

        public static async Task<List<Member>> GetGroupMembers(long groupId)
        {
            BaseResponse<Member> response = await SurveyMonkeyRequest.GetRequest<BaseResponse<Member>>("/groups/{0}/members");
            return response.data;
        }

        public static async Task<MemberDetail> GetGroupMemberDetails(long groupId, long memberId)
        {
            MemberDetail response = await SurveyMonkeyRequest.GetRequest<MemberDetail>(string.Format("/groups/{0}/members/{1}", groupId, memberId));
            return response;
        } 
    }
}
