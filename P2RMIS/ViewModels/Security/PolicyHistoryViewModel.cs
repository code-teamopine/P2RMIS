using Sra.P2rmis.Dal;
using Sra.P2rmis.WebModels.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sra.P2rmis.Web.UI.Models
{
    public class PolicyHistoryViewModel
    {
        public PolicyHistoryWebModel PolicyHistory { get; set; }

        public List<KeyValuePair<int, string>> ClientList { get; set; }
        public List<KeyValuePair<int, string>> PolicyHistoryTypeList { get; set; }

        public List<KeyValuePair<int, string>> PolicyHistoryRestrictionTypeList { get; set; }

        public List<KeyValuePair<int, string>> WeekDayList { get; set; }

        /// <summary>
        /// Configure the lists
        /// </summary>
        /// <param name="thePolicyHistoryTypeList">List of PolicyHistoryTypes & their indexes</param>        
        internal void ConfigureLists(List<KeyValuePair<int, string>> theClientList, List<KeyValuePair<int, string>> thePolicyHistoryTypeList, List<KeyValuePair<int, string>> thePolicyHistoryRestrictionTypeList, List<KeyValuePair<int, string>> theWeekDayList)
        {
            ClientList = theClientList;
            PolicyHistoryTypeList = thePolicyHistoryTypeList;
            PolicyHistoryRestrictionTypeList = thePolicyHistoryRestrictionTypeList;
            WeekDayList = theWeekDayList;
        }

    }
}