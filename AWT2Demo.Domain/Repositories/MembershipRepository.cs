using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.Entity;
using AWT2Demo.Domain.Contexts;
using System.Data.Objects.DataClasses;

namespace AWT2Demo.Domain.Repositories
{
    public class MembershipRepository
    {
        protected ObjectContext _context;
        protected ObjectSet<aspnet_Users> _userObjectSet;
        protected ObjectSet<aspnet_Roles> _roleObjectSet;

        public MembershipRepository()
        {
            _context = new ASPNETDBEntities();
            _userObjectSet = _context.CreateObjectSet<aspnet_Users>();
            _roleObjectSet = _context.CreateObjectSet<aspnet_Roles>();
        }

        /// <summary>
        /// Add a role to a user
        /// </summary>
        /// <param name="roleName">The ID of the Role to be added to a user</param>
        /// <param name="username">The ID of the user that will get an added role</param>
        public void AddRoleToUser(Guid RoleID, Guid UserID)
        {
            var role = _roleObjectSet.Where(r => r.RoleId == RoleID).FirstOrDefault();
            var user = _userObjectSet.Where(u => u.UserId == UserID).FirstOrDefault();
            if (null != role && null != user)
            {
                user.aspnet_Roles.Add(role);
                _context.SaveChanges();
            }
        }
        
        public IQueryable<aspnet_Roles> GetRoleNames()
        {
            return _roleObjectSet.AsQueryable();
        }

        public IQueryable<aspnet_Users> GetUserNames()
        {
            return _userObjectSet.AsQueryable();
        }
    }
}
