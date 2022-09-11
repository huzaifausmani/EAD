using fullAuditModel;


System.Console.WriteLine("Change Tracking Demo");

FullAuditContext db = new FullAuditContext();

User u = new User();
u.Name = "Hassan Raza";
u.Age = 21;
u.Email = "hr770735@gmail.com";
u.IsActive = true;

// db.Users.Add(u);
// db.SaveChanges();


Product p = new Product();
p.ProductName = "Dell laptop";
p.Price = 41000;
p.PType = "Electronincs";
p.IsActive = true;

db.Products.Add(p);

db.SaveChanges();

// var user = db.Users.FirstOrDefault();
// user.Name="Laptop";
// db.SaveChanges();

System.Console.WriteLine("Done");