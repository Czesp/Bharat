using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanTest.Models
{
    public class UserGroup
    {
        public int UserGroupId { get; set; }

        public string UserGroupName { get; set; }

        public string UserGroupCode { get; set; }

        public bool IsActive { get; set; }
    }
}
