﻿using Portal.CMS.Entities.Entities.Authentication;
using System.Collections.Generic;
using System.Linq;

namespace Portal.CMS.Entities.Seed
{
    public static class RoleSeed
    {
        public static void Seed(PortalEntityModel context)
        {
            var roleList = context.Roles.ToList();

            var newRoles = new List<Role>();

            if (!roleList.Any(x => x.RoleName == "Admin"))
                newRoles.Add(new Role { RoleName = "Admin" });

            if (!roleList.Any(x => x.RoleName == "Authenticated"))
                newRoles.Add(new Role { RoleName = "Authenticated" });

            if (!roleList.Any(x => x.RoleName == "Editor"))
                newRoles.Add(new Role { RoleName = "Editor" });

            if (newRoles.Any())
                context.Roles.AddRange(newRoles);
        }
    }
}