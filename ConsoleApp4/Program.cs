using System;

namespace Lesson4_
{

    // Task 1
    class WebSite
    {
        public string Name { get; set; }

        public string Path { get; set; }

        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                if (value != "")
                {
                    description = value;
                }
                else
                {
                    throw new Exception("Description is empty");
                }
            }
        }

        private string ipAddress;

        public string IpAddress
        {
            get { return ipAddress; }
            set
            {
                ipAddress = value;
            }
        }

        public void Input()
        {
            Console.Write("Saytin adi: ");
            Name = Console.ReadLine();

            Console.Write("Sayta geden yol (path): ");
            Path = Console.ReadLine();

            Console.Write("Saytin tesviri: ");
            Description = Console.ReadLine();

            Console.Write("Saytin IP unvani: ");
            IpAddress = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"Saytin adi: {Name}");
            Console.WriteLine($"Path: {Path}");
            Console.WriteLine($"Tesvir: {Description}");
            Console.WriteLine($"IP unvani: {IpAddress}");
        }

        public void ShowName()
        {
            Console.WriteLine($"Saytin adi: {Name}");
        }

        public void ShowPath()
        {
            Console.WriteLine($"Path: {Path}");
        }

        public void ShowDescription()
        {
            Console.WriteLine($"Tesvir: {Description}");
        }

        public void ShowIpAddress()
        {
            Console.WriteLine($"IP unvani: {IpAddress}");
        }
    }


    //Task 2

    class Magazine
    {
        public string Name { get; set; }
        public int FoundationYear { get; set; }
        private string information;

        public string Information
        {
            get { return information; }
            set
            {
                if (value != "")
                {
                    information = value;
                }
                else
                {
                    throw new Exception("Information is empty");
                }
            }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("Wrong email");
                }
            }
        }

        public void Input()
        {
            Console.Write("Jurnalin adi: ");
            Name = Console.ReadLine();

            Console.Write("Esaslandirilma ili: ");
            FoundationYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Jurnalin melumati: ");
            Information = Console.ReadLine();

            Console.Write("Telefon nomresi: ");
            PhoneNumber = Console.ReadLine();

            Console.Write("E-poct: ");
            Email = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"Jurnalin adi: {Name}");
            Console.WriteLine($"Esaslandirilma ili: {FoundationYear}");
            Console.WriteLine($"Jurnalin melumati: {Information}");
            Console.WriteLine($"Telefon nomresi: {PhoneNumber}");
            Console.WriteLine($"E-poct: {Email}");
        }

        public void ShowName()
        {
            Console.WriteLine($"Jurnalin adi: {Name}");
        }

        public void ShowFoundationYear()
        {
            Console.WriteLine($"Esaslandirilma ili: {FoundationYear}");
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Jurnalin melumati: {Information}");
        }

        public void ShowPhoneNumber()
        {
            Console.WriteLine($"Telefon nomresi: {PhoneNumber}");
        }

        public void ShowEmail()
        {
            Console.WriteLine($"E-poct: {Email}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            WebSite site = new WebSite();

            site.Input();

            Console.WriteLine("\n--- Butun melumatlar ---");
            site.Output();

            Console.WriteLine("\n--- Ayrica melumatlar ---");
            site.ShowName();
            site.ShowPath();
            site.ShowDescription();
            site.ShowIpAddress();


            // Task 2

            Magazine magazine = new Magazine();

            magazine.Input();

            Console.WriteLine("\n--- Butun melumatlar ---");
            magazine.Output();

            Console.WriteLine("\n--- Ayrica melumatlar ---");
            magazine.ShowName();
            magazine.ShowFoundationYear();
            magazine.ShowInformation();
            magazine.ShowPhoneNumber();
            magazine.ShowEmail();
        }
    }
}