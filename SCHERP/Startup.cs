using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SCHERP.Models;

[assembly: OwinStartupAttribute(typeof(SCHERP.Startup))]
namespace SCHERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }
        // In this method we will create default User roles and Admin user for login   
        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup i am creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("Super Admin"))
            {

                // first we create Admin rool   
                var role = new IdentityRole
                {
                    Name = "Super Admin"
                };
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser
                {
                    UserName = "Phemware Solutions",
                    Email = "phemwaresolutions@gmail.com"
                };

                string userPWD = "Folukemi79@";

                var chkUser = userManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Super Admin");

                }
            }

            // creating Creating Manager role    
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole
                {
                    Name = "Admin"
                };
                roleManager.Create(role);

            }

            // creating Creating Employee role    
            if (!roleManager.RoleExists("Teaching Staff"))
            {
                var role = new IdentityRole
                {
                    Name = "Teaching Staff"
                };
                roleManager.Create(role);

            }
        }
    }
}
