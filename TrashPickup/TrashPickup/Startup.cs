using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TrashPickup.Models;

[assembly: OwinStartupAttribute(typeof(TrashPickup.Startup))]
namespace TrashPickup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }
        //Create default User roles and Admin user for login
        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //if (!roleManager.RoleExists("Admin"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Admin";
            //    roleManager.Create(role);

            //    var user = new ApplicationUser();
            //    user.UserName = "Angie";
            //    user.Email = "angiealters@ymail.com";
            //    string userPassword = "@ngie15";

            //    var checkUser = userManager.Create(user, userPassword);

            //    if (checkUser.Succeeded)
            //    {
            //        var result1 = userManager.AddToRole(user.Id, "Admin");
            //    }            
            //}

            if (!roleManager.RoleExists("Customer"))
            {
                var role = new IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Employee"))
            {
                var role = new IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);
            }

        }
    }
}
