namespace grundførløbs_eksamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //making the varibles for my arrays and setting them so i can make 30 users totel
            string[] names = new string[30];
            string[] phoneNumbers = new string[30];
            string[] emails = new string[30];
            string[] cities = new string[30];
            int[] ages = new int[30];
            string[] lastNames = new string[30];
            string[] addresses = new string[30];
            string[] postcodes = new string[30];


            int nameCount = 20;
            int phoneNumberCount = 20;
            int emailCount = 20;
            int cityCount = 20;
            int ageCount = 20;
            int lastNameCount = 20;
            int addressCount = 20;
            int postcodeCount = 20;
            // making the useres in the system using arrays
            names[0] = "Bo jensen";
            names[1] = "karl Hansen";
            names[2] = "sander Løvsteen";
            names[3] = "lukas Nielsen";
            names[4] = "Aurora Pedersen";
            names[5] = "Caleb Hammerkvist";
            names[6] = "Freya Sørensen";
            names[7] = "Donovan Larsen";
            names[8] = "Isabella Christensen";
            names[9] = "Jasper Hannibal";
            names[10] = "Luna Bokvist";
            names[11] = "Gabriel Rasmussen";
            names[12] = "Selene Jørgensen";
            names[13] = "Orion Hansen";
            names[14] = "Nova Toft";
            names[15] = "Dante Hansen";
            names[16] = "Seraphina Pedersen";
            names[17] = "Phoenix Nielsen";
            names[18] = "Rowan jiping";
            names[19] = "Willow wong";
            // making the phoneNumbers for each person
            phoneNumbers[0] = "12 34 56 78";
            phoneNumbers[1] = "23 45 67 89";
            phoneNumbers[2] = "34 56 78 90";
            phoneNumbers[3] = "45 67 89 01";
            phoneNumbers[4] = "56 78 90 12";
            phoneNumbers[5] = "67 89 01 23";
            phoneNumbers[6] = "78 90 12 34";
            phoneNumbers[7] = "89 01 23 45";
            phoneNumbers[8] = "90 12 34 56";
            phoneNumbers[9] = "01 23 45 67";
            phoneNumbers[10] = "98 76 54 32";
            phoneNumbers[11] = "87 65 43 21";
            phoneNumbers[12] = "76 54 32 10";
            phoneNumbers[13] = "65 43 21 09";
            phoneNumbers[14] = "54 32 10 98";
            phoneNumbers[15] = " 43 21 09 87";
            phoneNumbers[16] = "32 10 98 76";
            phoneNumbers[17] = "21 09 87 65";
            phoneNumbers[18] = "10 98 76 54";
            phoneNumbers[19] = "09 87 65 43";
            //making the email for each user 
            emails[0] = "johndoe123@gmail.com";
            emails[1] = "sarahsmith456@yahoo.com";
            emails[2] = "emilyjones789@hotmail.com";
            emails[3] = "davidbrown321@outlook.com";
            emails[4] = "lisawilson654@icloud.com";
            emails[5] = "alexturner987@aol.com";
            emails[6] = "sophieclark234@protonmail.com";
            emails[7] = "markroberts789@live.com";
            emails[8] = "amycarter123@yandex.com";
            emails[9] = "kevinlewis456@mail.com";
            emails[10] = "chloewhite789@inbox.com";
            emails[11] = "ryangreen123@fastmail.com";
            emails[12] = "mariagarcia456@gmx.com";
            emails[13] = "andrewscott789@zoho.com";
            emails[14] = "laurawright123@rocketmail.com";
            emails[15] = "benjaminmartin456@tutanota.com";
            emails[16] = "sandralee789@rediffmail.com";
            emails[17] = "williamjackson123@yopmail.com";
            emails[18] = "victoriahill456@mailinator.com";
            emails[19] = "matthewwilson789@protonmail.ch";
            // making the city for each person
            cities[0] = "Copenhagen";
            cities[1] = "Aarhus";
            cities[2] = "Odense";
            cities[3] = "Aalborg";
            cities[4] = "Esbjerg";
            cities[5] = "Randers";
            cities[6] = "Kolding";
            cities[7] = "Horsens";
            cities[8] = "Vejle";
            cities[9] = "Roskilde";
            cities[10] = "Herning";
            cities[11] = "Hørsholm";
            cities[12] = "Helsingør";
            cities[13] = "Silkeborg";
            cities[14] = "Næstved";
            cities[15] = "Fredericia";
            cities[16] = "Viborg";
            cities[17] = "Køge";
            cities[18] = "Holstebro";
            cities[19] = "Slagelse";
            // setting the age for each person
            ages[0] = 19;
            ages[1] = 20;
            ages[2] = 21;
            ages[3] = 22;
            ages[4] = 23;
            ages[5] = 24;
            ages[6] = 25;
            ages[7] = 26;
            ages[8] = 27;
            ages[9] = 28;
            ages[10] = 29;
            ages[11] = 30;
            ages[12] = 31;
            ages[13] = 32;
            ages[14] = 34;
            ages[15] = 35;
            ages[16] = 36;
            ages[17] = 37;
            ages[18] = 38;
            ages[19] = 39;
            //making the address for each person
            addresses[0] = "H.C. Andersens Boulevard 23";
            addresses[1] = "M.P. Bruuns Gade 25";
            addresses[2] = "Vestergade 15";
            addresses[3] = "Boulevarden 17";
            addresses[4] = "Torvegade 21";
            addresses[5] = "Østervold 11";
            addresses[6] = "Haderslevvej 5";
            addresses[7] = "Søndergade 30";
            addresses[8] = "Nørregade 9";
            addresses[9] = "Algade 33";
            addresses[10] = "Østergade 7";
            addresses[11] = "Rungstedvej 18";
            addresses[12] = "Stengade 50";
            addresses[13] = "Vestergade 6";
            addresses[14] = "Ringstedgade 12";
            addresses[15] = "Gothersgade 4";
            addresses[16] = "Sct. Mathias Gade 20";
            addresses[17] = "Torvet 2";
            addresses[18] = "Nørregade 42";
            addresses[19] = "Bredegade 19";
            // making the postel code for each person
            postcodes[0] = "1553";
            postcodes[1] = "8000";
            postcodes[2] = "5000";
            postcodes[3] = "9000";
            postcodes[4] = "6700";
            postcodes[5] = "8900";
            postcodes[6] = "6000";
            postcodes[7] = "8700";
            postcodes[8] = "7100";
            postcodes[9] = "4000";
            postcodes[10] = "7400";
            postcodes[11] = "2970";
            postcodes[12] = "3000";
            postcodes[13] = "8600";
            postcodes[14] = " 4700";
            postcodes[15] = "7000";
            postcodes[16] = " 8800";
            postcodes[17] = "4600";
            postcodes[18] = "7500";
            postcodes[19] = " 4200";

            // making a while true loop to keep to code running


            string brugernavn = "admin";
            string password = "";

            Console.Clear();

            Console.WriteLine("indtast dit brugernavn");
            string username = Console.ReadLine();

            Console.WriteLine("indtast din adgangskode");
            string password1 = Console.ReadLine();

            if (username == brugernavn && password == password1)

                while (true)
                {




                    Console.Clear();
                    Console.WriteLine("Velkommen til informationsstanderen");
                    Console.WriteLine("1. Opret en ny bruger");
                    Console.WriteLine("2. Søg efter en bruger");
                    Console.WriteLine("3. regn gemmensnistlader");
                    Console.WriteLine("4. Afslut");

                    // Get user choice
                    Console.Write("Vælg en handling: ");
                    string choice = Console.ReadLine();

                    Console.Clear(); // Clear screen before executing action
                                     // making a switch case so you can type 1 2 or 3 dependign on the action you wanna take
                    switch (choice)
                    {
                        case "1":
                            CreateUser();
                            break;
                        case "2":
                            SearchUser();
                            break;
                        case "3":
                            if (phoneNumberCount == 0)
                            {
                                Console.WriteLine("Ingen brugere i systemet.");
                                return;
                            }

                            int totalAge = 0;
                            for (int i = 0; i < phoneNumberCount; i++)
                            {
                                totalAge += ages[i];
                            }

                            double averageAge = (double)totalAge / phoneNumberCount;
                            Console.WriteLine($"Gennemsnitsalderen for alle brugere er: {averageAge:F1} år");
                            Console.WriteLine("Tryk på en tast for at fortsætte...");
                            Console.ReadKey();

                            break;
                        case "4":
                            return;








                        default:
                            Console.WriteLine("Ugyldigt valg. Vælg venligst igen.");
                            break;
                    }
                }
            // Function to create a new user
            void CreateUser()
            {
                Console.WriteLine("Opret en ny bruger:");

                // Get phone number
                Console.Write("Indtast telefonnummer: ");
                string phoneNumber = Console.ReadLine();
                // checking if phone number is alreadt in the system
                bool phoneNumberFound = false;
                for (int i = 0; i < phoneNumberCount; i++)
                {

                    if (phoneNumbers[i] == phoneNumber)
                    {
                        // if phone number found then 
                        phoneNumberFound = true;
                        break;
                    }
                }
                // if the number is not the phone nummber when creating a user  it will  ask for the login details
                if (!phoneNumberFound)
                {
                    // will want the users email
                    Console.Write("Indtast email: ");
                    string email = Console.ReadLine();
                    emails[emailCount] = email;
                    emailCount++;
                    // asks for the city
                    Console.Write("Indtast by: ");
                    string city = Console.ReadLine();
                    cities[cityCount] = city;
                    cityCount++;

                    //checking to see if your typing a number so i can check it's actully a age
                    int age;
                    bool validAge = false;
                    do
                    {
                        // getting the age of the user
                        Console.Write("Indtast alder: ");
                        string ageInput = Console.ReadLine();
                        validAge = int.TryParse(ageInput, out age);
                        if (!validAge)
                        {
                            Console.WriteLine("Ugyldig alder. Indtast venligst et gyldigt tal.");
                        }
                        // checking if it's a valid age(a number)
                    } while (!validAge);
                    ages[ageCount] = age;
                    ageCount++;

                    // gettign the user name
                    Console.Write("Indtast navn: ");
                    string name = Console.ReadLine();
                    names[nameCount] = name;
                    nameCount++;
                    // getting the users last name
                    Console.Write("Indtast efternavn: ");
                    string lastName = Console.ReadLine();
                    lastNames[lastNameCount] = lastName;
                    lastNameCount++;
                    // getting the postelcode of the user location
                    Console.Write("Indtast postnummer: ");
                    string postcode = Console.ReadLine();
                    postcodes[postcodeCount] = postcode;
                    postcodeCount++;
                    // getting the address of the user
                    Console.Write("Indtast adresse: ");
                    string address = Console.ReadLine();
                    addresses[addressCount] = address;
                    addressCount++;
                    Console.Write("tryk på en tast for at komme til menu");

                    // Add the phone number to the array
                    phoneNumbers[phoneNumberCount] = phoneNumber;
                    phoneNumberCount++;
                }
                else
                {
                    // if the number already is in the system it says number already in system
                    Console.WriteLine("Telefonnummeret findes allerede i systemet.");
                }
                Console.ReadLine();
            }

            // Function to search for a user
            // Function to search for a user by name or phone number
            void SearchUser()
            {
                Console.Clear(); // Clear screen before searching
                Console.Write("Indtast navn eller telefonnummer for at søge: ");
                string searchTerm = Console.ReadLine();

                bool found = false;
                for (int i = 0; i < nameCount; i++)
                {
                    // checking for the name or phone number
                    if (names[i] == searchTerm || phoneNumbers[i] == searchTerm)
                    {
                        DisplayUserDetails(i);
                        found = true;
                        break; // Stop searching after finding the first match
                    }
                }
                // if not found the name or the number the system says no user with the number or name
                if (!found)

                {
                    Console.WriteLine("Ingen bruger fundet med det navn eller telefonnummer.");
                }

                Console.WriteLine("Tryk på en tast for at fortsætte...");
                Console.ReadKey(); // Wait for user input before continuing
            }


            // Function to display user details
            void DisplayUserDetails(int index)
            {
                // outputting to screen all the users data
                Console.WriteLine($"Navn: {names[index]} {lastNames[index]}");
                Console.WriteLine($"Alder: {ages[index]}");
                Console.WriteLine($"Email: {emails[index]}");
                Console.WriteLine($"Telefonnummer: {phoneNumbers[index]}");
                Console.WriteLine($"Adresse: {addresses[index]}");
                Console.WriteLine($"Postnummer: {postcodes[index]}");
                Console.WriteLine($"By: {cities[index]}");
                // doing so you can go between users
                Console.WriteLine("Tryk på p for at gå til forrige bruger, n for næste bruger, eller q for at afslutte:");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();

                switch (keyInfo.KeyChar)
                {

                    case 'p':
                        // Go to the previous user
                        if (index > 0)
                        {
                            DisplayUserDetails(index - 1);
                        }
                        else
                        {
                            // outputting if your at the first user 
                            Console.WriteLine("Du er allerede ved den første bruger.");
                            Console.WriteLine("Tryk på en tast for at fortsætte...");
                            Console.ReadKey();
                            DisplayUserDetails(index);
                        }
                        break;
                    case 'n':
                        // Go to the next user
                        if (index < nameCount - 1)
                        {
                            DisplayUserDetails(index + 1);
                        }
                        else
                        {
                            // says if your at the last user
                            Console.WriteLine("Du er allerede ved den sidste bruger.");
                            Console.WriteLine("Tryk på en tast for at fortsætte...");
                            Console.ReadKey();
                            DisplayUserDetails(index);
                        }
                        break;
                    case 'q':
                        // Quit navigation
                        Console.WriteLine("Navigation afsluttet.");
                        break;
                    default:
                        // says if its a wrong input
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        DisplayUserDetails(index);
                        break;
                }
            }


            Console.WriteLine("Tryk på en tast for at fortsætte...");
            Console.ReadKey();
        }
    }
}