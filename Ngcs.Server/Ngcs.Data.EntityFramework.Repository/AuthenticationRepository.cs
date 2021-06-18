using System;
using System.Linq;
using System.Threading.Tasks;
using LogoFX.Web.DAL.DbContext;
using LogoFX.Web.DAL.Entities;
using LogoFX.Web.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LogoFX.Web.DAL.Repository
{
    public interface IAuthenticationRepository : IDisposable
    {
        Task<IIdentityResult> RegisterUserAsync(UserModel userModel);
        IdentityUser FindUserByName(string userName);
        Task<IdentityUser> FindUserAsync(string userName, string password);
        Task<IdentityUser> FindUserByIdAsync(Guid userId);
        Task<IdentityRole> FindRoleByIdAsync(string roleId);
        Task<IdentityRole> FindRoleByNameAsync(string roleName);
        Task<IdentityUser[]> GetUsers();
        Task<IIdentityResult> AddRoleAsync(string roleName);
    }

    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly IAuthenticationDbContext _ctx;

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthenticationRepository(IAuthenticationDbContext authenticationDbContext)
        {
            _ctx = authenticationDbContext;
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx.Context));
            _roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_ctx.Context));
        }

        public async Task<IIdentityResult> RegisterUserAsync(UserModel userModel)
        {
            var user = new IdentityUser
            {
                UserName = userModel.UserName
            };           

            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (result.Succeeded)
            {
                var userData = await _userManager.FindByNameAsync(user.UserName);
                var rolesManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_ctx.Context));
                var role = await rolesManager.FindByNameAsync(userModel.IsAdmin ? "administrators" : "users");
                if (role != null)
                {
                    await _userManager.AddToRoleAsync(userData.Id, role.Name);
                }
            }
           
            return new Identity.IdentityResult(result);
        }

        public IdentityUser FindUserByName(string userName)
        {
            return _userManager.Users.SingleOrDefault(t => t.UserName == userName);           
        }

        public async Task<IdentityUser> FindUserAsync(string userName, string password)
        {
            var user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public async Task<IdentityUser> FindUserByIdAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            return user;
        }

        public async Task<IdentityRole> FindRoleByIdAsync(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            return role;
        }

        public async Task<IdentityRole> FindRoleByNameAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            return role;
        }

        public Task<IdentityUser[]> GetUsers()
        {
            var users = _userManager.Users.ToArray();
            return Task.FromResult(users);
        }

        public async Task<IIdentityResult> AddRoleAsync(string roleName)
        {
            var role = new IdentityRole(roleName) {Id = roleName};
            var result = await _roleManager.CreateAsync(role);
            return new Identity.IdentityResult(result);
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();
            _roleManager.Dispose();

        }
    }

    public interface IAuthenticationRepositoryFactory
    {
        IAuthenticationRepository CreateRepository();
    }
}