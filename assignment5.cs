//Author: Sudan Krishna Dhakal   ID: C0901145

using System;
using System.Collections.Generic;

namespace Post
{
    /// <summary>
    /// Abstract class representing a mail item.
    /// </summary>
    public abstract class Mail
    {
        protected double weight;  // in grams
        protected bool isExpress;
        protected string destinationAddress;

        /// <summary>
        /// Constructor for creating a Mail object.
        /// </summary>
        /// <param name="weight">The weight of the mail item in grams.</param>
        /// <param name="isExpress">Indicates if the mail item is sent via express shipping.</param>
        /// <param name="destinationAddress">The destination address of the mail item.</param>
        public Mail(double weight, bool isExpress, string destinationAddress)
        {
            this.weight = weight;
            this.isExpress = isExpress;
            this.destinationAddress = destinationAddress;
            CalculateStampAmount(); // Ensure the stamp amount is calculated on creation
        }

        protected abstract void CalculateStampAmount();

        public virtual bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(destinationAddress);
        }

        public virtual void Display()
        {
            string validity = IsValid() ? "" : "\n(Invalid courier)";
            Console.WriteLine($"{this.GetType().Name}{validity}\nWeight: {weight} grams\nExpress: {(isExpress ? "yes" : "no")}\nDestination: {destinationAddress}\nPrice: ${StampAmount}");
        }

        public double StampAmount { get; protected set; }
    }

    /// <summary>
    /// Represents a letter mail item.
    /// </summary>
    public class Lettre : Mail
    {
        private string format;

        public Lettre(double weight, bool isExpress, string destinationAddress, string format)
            : base(weight, isExpress, destinationAddress)
        {
            this.format = format;
        }

        protected override void CalculateStampAmount()
        {
            double baseFare = format == "A4" ? 2.5 : 3.5;
            StampAmount = baseFare + (weight / 1000.0); // Convert grams to kilograms
            if (isExpress) StampAmount *= 2;
        }

        public override void Display()
        {
            string validity = IsValid() ? "" : "\n\t(Invalid courier)";
            string expressStatus = isExpress ? "Express: yes" : "Express: no";
            string priceDisplay = IsValid() ? $"Price: ${StampAmount:0.0}" : "Price: 0.0";
            Console.WriteLine($"Letter{validity}\n\tWeight: {weight} grams\n\t{expressStatus}\n\tDestination: {destinationAddress}\n\t{priceDisplay}\n\tFormat: {format}\n");
        }
    }

    /// <summary>
    /// Represents an advertisement mail item.
    /// </summary>
    public class Advertisement : Mail
    {
        public Advertisement(double weight, bool isExpress, string destinationAddress)
            : base(weight, isExpress, destinationAddress)
        {
        }

        protected override void CalculateStampAmount()
        {
            StampAmount = 5.0 * (weight / 1000.0); // Convert grams to kilograms
            if (isExpress) StampAmount *= 2;
        }

        public override void Display()
        {
            string validity = IsValid() ? "" : "\n\t(Invalid courier)";
            string expressStatus = isExpress ? "Express: yes" : "Express: no";
            string priceDisplay = IsValid() ? $"Price: ${StampAmount:0.0}" : "Price: 0.0";
            Console.WriteLine($"Advertisement{validity}\n\tWeight: {weight} grams\n\t{expressStatus}\n\tDestination: {destinationAddress}\n\t{priceDisplay}\n");
        }
    }

    /// <summary>
    /// Represents a parcel mail item.
    /// </summary>
    public class Parcel : Mail
    {
        private double volume;

        public Parcel(double weight, bool isExpress, string destinationAddress, double volume)
            : base(weight, isExpress, destinationAddress)
        {
            this.volume = volume;

            if (volume > 50)
            {
                StampAmount = 0; // Invalid, no stamp cost
            }
            else
            {
                StampAmount = 0.25 * volume + (weight / 1000.0); // Convert grams to kilograms
                if (isExpress) StampAmount *= 2;
            }
        }

        protected override void CalculateStampAmount()
        {
            // No need to implement for Parcel as the calculation is done in the constructor.
        }

        public override bool IsValid()
        {
            return base.IsValid() && volume <= 50;
        }

        public override void Display()
        {
            string validity = IsValid() ? "" : "\n\t(Invalid courier)";
            string expressStatus = isExpress ? "Express: yes" : "Express: no";
            string priceDisplay = IsValid() ? $"Price: ${StampAmount:0.0}" : "Price: 0.0";
            string volumeDisplay = IsValid() ? $"Volume: {volume} liters" : $"Volume: {volume} liters";
            Console.WriteLine($"Parcel{validity}\n\tWeight: {weight} grams\n\t{expressStatus}\n\tDestination: {destinationAddress}\n\t{priceDisplay} \n\t{volumeDisplay}\n");
        }
    }

    /// <summary>
    /// Represents a mailbox.
    /// </summary>
    // Class to represent a mailbox that can contain a collection of mail items
    public class Box
    {
        private List<Mail> mails = new List<Mail>(); // Collection to hold mail items
        private int maxSize; // Maximum number of mail items the box can contain

        // Constructor to initialize the maximum size of the box
        public Box(int maxSize)
        {
            this.maxSize = maxSize;
        }

        // Method to add a mail item to the box
        public void addMail(Mail mail)
        {
            // Check if the box is not full
            if (mails.Count < maxSize)
            {
                mails.Add(mail); // Add the mail item to the collection
            }
            else
            {
                Console.WriteLine("Cannot add more mails: Box is full"); // Display error message if the box is full
            }
        }

        // Method to calculate the total stamp cost of all valid mail items in the box
        public double stamp()
        {
            double total = 0; // Initialize total stamp cost
            foreach (Mail mail in mails)
            {
                // If the mail item is valid, add its stamp amount to the total
                if (mail.IsValid())
                {
                    total += mail.StampAmount;
                }
            }
            return total; // Return the total stamp cost
        }

        // Method to display details of all mail items in the box
        public void display()
        {
            foreach (Mail mail in mails)
            {
                mail.Display(); // Display details of each mail item
            }
        }

        // Method to count the number of invalid mail items in the box
        public int mailIsInvalid()
        {
            int invalidCount = 0; // Initialize count of invalid mail items
            foreach (Mail mail in mails)
            {
                // If the mail item is invalid, increment the count
                if (!mail.IsValid())
                {
                    invalidCount++;
                }
            }
            return invalidCount; // Return the count of invalid mail items
        }
    }


    class Post
    {
        public static void Main(string[] args)
        {
            Box box = new Box(30);

            Lettre lettre1 = new Lettre(200, true, "Chemin des Acacias 28, 1009 Pully", "A3");
            Lettre lettre2 = new Lettre(800, false, "", "A4"); // invalid

            Advertisement adv1 = new Advertisement(1500, true, "Les Moilles  13A, 1913 Saillon");
            Advertisement adv2 = new Advertisement(3000, false, ""); // invalid

            Parcel parcel1 = new Parcel(5000, true, "Grand rue 18, 1950 Sion", 30);
            Parcel parcel2 = new Parcel(3000, true, "Chemin des fleurs 48, 2800 Delemont", 70); // invalid parcel


            box.addMail(lettre1);
            box.addMail(lettre2);
            box.addMail(adv1);
            box.addMail(adv2);
            box.addMail(parcel1);
            box.addMail(parcel2);

            Console.WriteLine("The total amount of stamp is " +
                              box.stamp());
            box.display();

            Console.WriteLine("The box contains " + box.mailIsInvalid() +
                               " invalid mails");
        }
    }
}
