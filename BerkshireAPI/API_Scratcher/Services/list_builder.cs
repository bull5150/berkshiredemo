using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Scratcher.Services
{
    public class list_builder
    {
        public List<Models.reasons_list> buildList(List<Models.reasons_list> list)
        {
            Models.reasons_list reason = new Models.reasons_list
            {
                id = 1,
                reason_Name = "Learn New Skills"
            };
            list.Add(reason);
            reason = new Models.reasons_list
            {
                id = 2,
                reason_Name = "Stability"
            };
            list.Add(reason);
            reason = new Models.reasons_list
            {
                id = 3,
                reason_Name = "New Sector, New Opprotunities"
            };
            list.Add(reason);       
            return list;
        }
    }
}