using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PCBuilder.Model;

namespace PCBuilder.Context
{
    public class DatabaseSeeder
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DatabaseSeeder (DatabaseContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            await _context.Database.MigrateAsync();
            if (!_context.Users.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
                await _roleManager.CreateAsync(new IdentityRole("Customer"));

                var adminEmail = "admin@builder.com";
                var adminPassword = "Builder@123";

                var admin = new User
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    Name = "Admin",
                    Gender = "Male",
                };

                await _userManager.CreateAsync(admin, adminPassword);
                await _userManager.AddToRoleAsync(admin, "Admin");
            }
            if (!_context.Components.Any())
            {
                var component = GetComponents();
                _context.Components.AddRange(component);
                await _context!.SaveChangesAsync();
            }
        }

        private List<Component> GetComponents()
        {
            return 
                [
                    new Component { Id = 1, Name = "Ryzen 5 5600X", Brand = "AMD", Price = 199.99f, Rating = 5, ImageUrl = "ryzen5600x.png" },
                    new Component { Id = 2, Name = "Core i5-12600K", Brand = "Intel", Price = 299.99f, Rating = 5, ImageUrl = "i512600k.png" },
                    new Component { Id = 3, Name = "GeForce RTX 3060 Ti", Brand = "NVIDIA", Price = 399.99f, Rating = 5, ImageUrl = "rtx3060ti.png" },
                    new Component { Id = 4, Name = "Radeon RX 6700 XT", Brand = "AMD", Price = 479.99f, Rating = 5, ImageUrl = "rx6700xt.png" },
                    new Component { Id = 5, Name = "Vengeance LPX 16GB", Brand = "Corsair", Price = 79.99f, Rating = 4, ImageUrl = "vengeancelpx.png" },
                    new Component { Id = 6, Name = "Ripjaws V 16GB", Brand = "G.SKILL", Price = 74.99f, Rating = 4, ImageUrl = "ripjawsv.png" },
                    new Component { Id = 7, Name = "970 EVO Plus 1TB", Brand = "Samsung", Price = 109.99f, Rating = 5, ImageUrl = "970evo.png" },
                    new Component { Id = 8, Name = "Barracuda 4TB HDD", Brand = "Seagate", Price = 89.99f, Rating = 4, ImageUrl = "barracuda.png" },
                    new Component { Id = 9, Name = "NH-D15", Brand = "Noctua", Price = 99.99f, Rating = 5, ImageUrl = "nhd15.png" },
                    new Component { Id = 10, Name = "Hyper 212 Black Edition", Brand = "Cooler Master", Price = 39.99f, Rating = 4, ImageUrl = "hyper212.png" },
                    new Component { Id = 11, Name = "RM750x", Brand = "Corsair", Price = 124.99f, Rating = 5, ImageUrl = "rm750x.png" },
                    new Component { Id = 12, Name = "SuperNOVA 750 G5", Brand = "EVGA", Price = 129.99f, Rating = 5, ImageUrl = "supernova750.png" },
                    new Component { Id = 13, Name = "NZXT H510", Brand = "NZXT", Price = 79.99f, Rating = 5, ImageUrl = "nzxth510.png" },
                    new Component { Id = 14, Name = "Meshify C", Brand = "Fractal Design", Price = 99.99f, Rating = 5, ImageUrl = "meshifyc.png" },
                    new Component { Id = 15, Name = "MAG B550 TOMAHAWK", Brand = "MSI", Price = 179.99f, Rating = 5, ImageUrl = "magb550.png" },
                    new Component { Id = 16, Name = "ROG STRIX Z690-E", Brand = "ASUS", Price = 399.99f, Rating = 5, ImageUrl = "rogstrixz690.png" },
                    new Component { Id = 17, Name = "U28E590D", Brand = "Samsung", Price = 299.99f, Rating = 4, ImageUrl = "u28e590d.png" },
                    new Component { Id = 18, Name = "VG248QG", Brand = "ASUS", Price = 209.99f, Rating = 4, ImageUrl = "vg248qg.png" },
                    new Component { Id = 19, Name = "G PRO X Superlight", Brand = "Logitech", Price = 149.99f, Rating = 5, ImageUrl = "gprosuperlight.png" },
                    new Component { Id = 20, Name = "DeathAdder V2", Brand = "Razer", Price = 69.99f, Rating = 4, ImageUrl = "deathadderv2.png" }
                ];
        }
    }
}
