﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SurveyMonkeyApiV3Standard.Models
{
    public class Group
    {
        public long id { get; set; }
        public string name { get; set; }
        public string href { get; set; }
    }

    public class GroupDetail 
    {
        public long id { get; set; }
        public string name { get; set; }
        public string href { get; set; }
        public int member_count { get; set; }
        public int max_invites { get; set; }
        public string date_created { get; set; }
        public string owner_email { get; set; }
    }
}
