using Fines.Data.Models;

namespace Fines.Data.Seed;

public static class CustomerSeedData
{
    public static List<CustomerEntity> GetSeedData()
    {
        return new List<CustomerEntity>
        {
            new CustomerEntity
            {
                Id = 1,
                FirstName = "Michael",
                LastName = "Johnson",
                Email = "michael.johnson@email.com",
                PhoneNumber = "07700900001",
                Address = "12 Oak Street",
                City = "London",
                PostCode = "SW1A 1AA",
                DateOfBirth = new DateTime(1985, 4, 12),
                DriverLicenseNumber = "JOHNS850412MJ9AB"
            },
            new CustomerEntity
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Williams",
                Email = "sarah.williams@email.com",
                PhoneNumber = "07700900002",
                Address = "45 Elm Avenue",
                City = "Manchester",
                PostCode = "M1 1AD",
                DateOfBirth = new DateTime(1990, 8, 23),
                DriverLicenseNumber = "WILLI908823SW9CD"
            },
            new CustomerEntity
            {
                Id = 3,
                FirstName = "David",
                LastName = "Brown",
                Email = "david.brown@email.com",
                PhoneNumber = "07700900003",
                Address = "78 Maple Road",
                City = "Birmingham",
                PostCode = "B1 1BB",
                DateOfBirth = new DateTime(1978, 11, 5),
                DriverLicenseNumber = "BROWN781105DB9EF"
            },
            new CustomerEntity
            {
                Id = 4,
                FirstName = "Emma",
                LastName = "Garcia",
                Email = "emma.garcia@email.com",
                PhoneNumber = "07700900004",
                Address = "23 Pine Lane",
                City = "Leeds",
                PostCode = "LS1 1UR",
                DateOfBirth = new DateTime(1992, 3, 17),
                DriverLicenseNumber = "GARCI920317EG9GH"
            },
            new CustomerEntity
            {
                Id = 5,
                FirstName = "Robert",
                LastName = "Martinez",
                Email = "robert.martinez@email.com",
                PhoneNumber = "07700900005",
                Address = "56 Cedar Close",
                City = "Liverpool",
                PostCode = "L1 8JQ",
                DateOfBirth = new DateTime(1988, 7, 29),
                DriverLicenseNumber = "MARTI880729RM9IJ"
            },
            new CustomerEntity
            {
                Id = 6,
                FirstName = "Lisa",
                LastName = "Anderson",
                Email = "lisa.anderson@email.com",
                PhoneNumber = "07700900006",
                Address = "89 Birch Way",
                City = "Bristol",
                PostCode = "BS1 5TR",
                DateOfBirth = new DateTime(1986, 12, 14),
                DriverLicenseNumber = "ANDER861214LA9KL"
            },
            new CustomerEntity
            {
                Id = 7,
                FirstName = "James",
                LastName = "Wilson",
                Email = "james.wilson@email.com",
                PhoneNumber = "07700900007",
                Address = "34 Willow Street",
                City = "Sheffield",
                PostCode = "S1 2JE",
                DateOfBirth = new DateTime(1983, 5, 8),
                DriverLicenseNumber = "WILSO830508JW9MN"
            },
            new CustomerEntity
            {
                Id = 8,
                FirstName = "Mary",
                LastName = "Thompson",
                Email = "mary.thompson@email.com",
                PhoneNumber = "07700900008",
                Address = "67 Ash Drive",
                City = "Newcastle",
                PostCode = "NE1 4XE",
                DateOfBirth = new DateTime(1995, 9, 21),
                DriverLicenseNumber = "THOMP950921MT9OP"
            },
            new CustomerEntity
            {
                Id = 9,
                FirstName = "William",
                LastName = "Davis",
                Email = "william.davis@email.com",
                PhoneNumber = "07700900009",
                Address = "12 Spruce Road",
                City = "Nottingham",
                PostCode = "NG1 5FS",
                DateOfBirth = new DateTime(1981, 2, 3),
                DriverLicenseNumber = "DAVIS810203WD9QR"
            },
            new CustomerEntity
            {
                Id = 10,
                FirstName = "Jennifer",
                LastName = "Rodriguez",
                Email = "jennifer.rodriguez@email.com",
                PhoneNumber = "07700900010",
                Address = "45 Poplar Avenue",
                City = "Leicester",
                PostCode = "LE1 6PN",
                DateOfBirth = new DateTime(1993, 6, 16),
                DriverLicenseNumber = "RODRI930616JR9ST"
            },
            new CustomerEntity
            {
                Id = 11,
                FirstName = "Richard",
                LastName = "Lee",
                Email = "richard.lee@email.com",
                PhoneNumber = "07700900011",
                Address = "78 Sycamore Lane",
                City = "Coventry",
                PostCode = "CV1 5FB",
                DateOfBirth = new DateTime(1987, 10, 27),
                DriverLicenseNumber = "LEERI871027RL9UV"
            },
            new CustomerEntity
            {
                Id = 12,
                FirstName = "Linda",
                LastName = "Harris",
                Email = "linda.harris@email.com",
                PhoneNumber = "07700900012",
                Address = "23 Chestnut Close",
                City = "Bradford",
                PostCode = "BD1 1PR",
                DateOfBirth = new DateTime(1991, 1, 11),
                DriverLicenseNumber = "HARRI910111LH9WX"
            },
            new CustomerEntity
            {
                Id = 13,
                FirstName = "Thomas",
                LastName = "Clark",
                Email = "thomas.clark@email.com",
                PhoneNumber = "07700900013",
                Address = "56 Hawthorn Street",
                City = "Edinburgh",
                PostCode = "EH1 1YZ",
                DateOfBirth = new DateTime(1984, 4, 30),
                DriverLicenseNumber = "CLARK840430TC9YZ"
            },
            new CustomerEntity
            {
                Id = 14,
                FirstName = "Patricia",
                LastName = "Walker",
                Email = "patricia.walker@email.com",
                PhoneNumber = "07700900014",
                Address = "89 Beech Road",
                City = "Cardiff",
                PostCode = "CF10 1DD",
                DateOfBirth = new DateTime(1989, 8, 7),
                DriverLicenseNumber = "WALKE890807PW9AB"
            },
            new CustomerEntity
            {
                Id = 15,
                FirstName = "Daniel",
                LastName = "Lewis",
                Email = "daniel.lewis@email.com",
                PhoneNumber = "07700900015",
                Address = "34 Rowan Avenue",
                City = "Glasgow",
                PostCode = "G1 1AA",
                DateOfBirth = new DateTime(1994, 12, 19),
                DriverLicenseNumber = "LEWIS941219DL9CD"
            },
            new CustomerEntity
            {
                Id = 16,
                FirstName = "Elizabeth",
                LastName = "Hall",
                Email = "elizabeth.hall@email.com",
                PhoneNumber = "07700900016",
                Address = "67 Holly Lane",
                City = "Plymouth",
                PostCode = "PL1 1AA",
                DateOfBirth = new DateTime(1982, 5, 24),
                DriverLicenseNumber = "HALLE820524EH9EF"
            },
            new CustomerEntity
            {
                Id = 17,
                FirstName = "Matthew",
                LastName = "Young",
                Email = "matthew.young@email.com",
                PhoneNumber = "07700900017",
                Address = "12 Laurel Drive",
                City = "Southampton",
                PostCode = "SO14 0AA",
                DateOfBirth = new DateTime(1996, 9, 2),
                DriverLicenseNumber = "YOUNG960902MY9GH"
            },
            new CustomerEntity
            {
                Id = 18,
                FirstName = "Barbara",
                LastName = "Allen",
                Email = "barbara.allen@email.com",
                PhoneNumber = "07700900018",
                Address = "45 Juniper Road",
                City = "Portsmouth",
                PostCode = "PO1 3AX",
                DateOfBirth = new DateTime(1980, 3, 13),
                DriverLicenseNumber = "ALLEN800313BA9IJ"
            },
            new CustomerEntity
            {
                Id = 19,
                FirstName = "Christopher",
                LastName = "King",
                Email = "christopher.king@email.com",
                PhoneNumber = "07700900019",
                Address = "78 Cypress Street",
                City = "Reading",
                PostCode = "RG1 1AA",
                DateOfBirth = new DateTime(1997, 7, 6),
                DriverLicenseNumber = "KINGC970706CK9KL"
            },
            new CustomerEntity
            {
                Id = 20,
                FirstName = "Susan",
                LastName = "Moore",
                Email = "susan.moore@email.com",
                PhoneNumber = "07700900020",
                Address = "23 Magnolia Close",
                City = "Cambridge",
                PostCode = "CB1 1PT",
                DateOfBirth = new DateTime(1985, 11, 28),
                DriverLicenseNumber = "MOORE851128SM9MN"
            },
            new CustomerEntity
            {
                Id = 21,
                FirstName = "Andrew",
                LastName = "Martin",
                Email = "andrew.martin@email.com",
                PhoneNumber = "07700900021",
                Address = "56 Redwood Avenue",
                City = "Oxford",
                PostCode = "OX1 1AA",
                DateOfBirth = new DateTime(1988, 2, 15),
                DriverLicenseNumber = "MARTI880215AM9OP"
            },
            new CustomerEntity
            {
                Id = 22,
                FirstName = "Jessica",
                LastName = "Taylor",
                Email = "jessica.taylor@email.com",
                PhoneNumber = "07700900022",
                Address = "89 Hickory Lane",
                City = "Brighton",
                PostCode = "BN1 1AA",
                DateOfBirth = new DateTime(1992, 6, 9),
                DriverLicenseNumber = "TAYLO920609JT9QR"
            },
            new CustomerEntity
            {
                Id = 23,
                FirstName = "Mark",
                LastName = "Jackson",
                Email = "mark.jackson@email.com",
                PhoneNumber = "07700900023",
                Address = "34 Dogwood Road",
                City = "Bournemouth",
                PostCode = "BH1 1AA",
                DateOfBirth = new DateTime(1979, 10, 22),
                DriverLicenseNumber = "JACKS791022MJ9ST"
            },
            new CustomerEntity
            {
                Id = 24,
                FirstName = "Emily",
                LastName = "White",
                Email = "emily.white@email.com",
                PhoneNumber = "07700900024",
                Address = "67 Fir Street",
                City = "York",
                PostCode = "YO1 7AA",
                DateOfBirth = new DateTime(1991, 4, 5),
                DriverLicenseNumber = "WHITE910405EW9UV"
            },
            new CustomerEntity
            {
                Id = 25,
                FirstName = "Paul",
                LastName = "Lopez",
                Email = "paul.lopez@email.com",
                PhoneNumber = "07700900025",
                Address = "12 Sequoia Drive",
                City = "Norwich",
                PostCode = "NR1 1AA",
                DateOfBirth = new DateTime(1986, 8, 18),
                DriverLicenseNumber = "LOPEZ860818PL9WX"
            }
        };
    }
}
