using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    //Define a class that holds information about a mobile phone device: model, manufacturer, price, owner,
    //battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).

    //Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
    //Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

    //Add a method in the GSM class for displaying all information about it.
    //Try to override ToString().
        
    //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
    //Ensure all fields hold correct data at any given time.
    
    //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        
    //Add a property CallHistory in the GSM class to hold a list of the performed calls.
    //Try to use the system class List<Call>.
        
    //Add a property CallHistory in the GSM class to hold a list of the performed calls.
    //Try to use the system class List<Call>.
        
    //Add methods in the GSM class for adding and deleting calls from the calls history.
    //Add a method to clear the call history.
        
    //Add a method that calculates the total price of the calls in the call history.
    //Assume the price per minute is fixed and is provided as a parameter.
            
    public class GSM
    {
        public const double minPrice = 20;
        public const double maxPrice = 2000;
        private const double pricePerSec = 0.37;

        public const string defaultOwner = "N/A";
        public Battery defaultBattery = new Battery("Samsung", Battery.minHoursIdle, Battery.minHoursTalk, BatteryType.Default);
        public Display defaultDisplay = new Display(Display.minSize, Display.minNumberOfColors);

        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        //private List<Call> callHistory;
        private List<Call> callHistory;

        private static GSM iphone4S = new GSM("IPhone4S", "Apple");


        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = minPrice;
            this.Owner = defaultOwner;
            this.Battery = defaultBattery;
            this.Display = defaultDisplay;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public double Price
        {
            get { return this.price; }
            set 
            {
                if (value < minPrice || value > maxPrice)
                {
                    throw new ArgumentOutOfRangeException("The price must be between 20 and 2000 lv!");
                }
                this.price = value; 
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        //public List<Call> CallHistory
        //{
        //    get { return this.callHistory; }
        //    set { this.callHistory = value; }
        //}
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }
        public static GSM IPhone4S     
        {
            get 
            { return iphone4S; }
        }

        public override string ToString()
        {
            return string.Format(@"
            Model: {0}
            Manufacturer: {1}
            Price: {2} lv
            Owner: {3}
            Battery: Model {4}, Hours idle {5}, Hours talk {6}
            Display: Size {7} inches, Number of colors {8}",
            this.Model, this.Manufacturer, this.Price, this.Owner, 
            this.Battery.Model, this.Battery.HoursIdle, this.Battery.HoursTalk,
            this.Display.Size, this.Display.NumberOfColors);
        }

        public void AddCall(Call newCall)
        {
            this.CallHistory.Add(newCall);
        }
        //public void DelCall(Call oldCall)
        //{
        //    this.CallHistory.Remove(oldCall);
        //}
        //public void ClearHistory()
        //{
        //    this.CallHistory.Clear();
        //}
        //public double CallPriceCalc()
        //{
        //    double price = 0;
        //    foreach (var call in this.CallHistory)
        //    {
        //        price += (call.Duration * pricePerSec);
        //    }
        //    return price;
        //}

    }
}
