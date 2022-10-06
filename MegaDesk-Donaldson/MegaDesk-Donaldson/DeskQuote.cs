using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Donaldson
{

    [Serializable]
    public class DeskQuote
    {
        //prepare random number for quoteId
        Random random = new Random();

        // setting size constants for desks.
        private const int MIN_WIDTH = 24;
        private const int MAX_WIDTH = 96;
        private const int MIN_HEIGHT = 30;
        private const int MIN_DEPTH = 12;
        private const int MAX_DEPTH = 48;
        private const int MIN_NUM_DRAWERS = 0;
        private const int MAX_DRAWERS = 7;
        private const float DRAWER_PRICE = 50;
        private const float BASE_PRICE = 200;
        private const float INCREASE_RATE_SIZE = 1000;
        private const float INCREASED_RATE = 1;

        // class attributes
        private Desk desk;
        private int numDesks;
        private String firstName;
        private String lastName;
        private int quoteId;
        private DateTime date;
        private float total;
        private int _shipping;

        // This map will be used to get shipping price depening on size of desk.
        Dictionary<int, Dictionary<String, int>> shipping = new Dictionary<int, Dictionary<String, int>>
        {
            { 3, new Dictionary<String, int>() },
            { 5, new Dictionary<String, int>() },
            { 7, new Dictionary<String, int>() } };
            

public DeskQuote()
        {
            this.desk = new Desk();
            quoteId = random.Next(10000,100000);
            date = DateTime.Now;
            dataRW txtRW = new dataRW("rushOrderPrices.txt");
            String[] shippingPrices = txtRW.readTxtData();
            int increment = 0;
            try
            {
                foreach (KeyValuePair<int, Dictionary<String, int>> pair in shipping)
                {
                    pair.Value.Add("small", int.Parse(shippingPrices[0 + increment]));
                    pair.Value.Add("medium", int.Parse(shippingPrices[1 + increment]));
                    pair.Value.Add("large", int.Parse(shippingPrices[2 + increment]));
                    increment += 3;
                }
            }
            catch
            {

            }
        }


        public void createDesks(int desks)
        {
            this.numDesks = desks;
        }

        /*
         * This method is a little messy to calculate the total we need to charge the customer, perhaps in the future we can break this up into other private methods.
         * This method will be called by every other method so we want this method so we want it to be capable of running everytime it is called; this will allow us to
         * see how much it will cost our customer for the configuration of desired desks.
         * We calculate the total price for materials, how much to add for shipping, how much for each drawer added, and how many desks are requested.
         * */
        public float calculateTotal()
        {
            total = BASE_PRICE;
            int totalMaterials;
            try
            {
                totalMaterials = desk.getTotalMaterials();
            }
            catch(Exception e)
            {
                return total;
            }

            
            // If the we are too large then start to charge the additional cost per inch squared.
            if (totalMaterials > INCREASE_RATE_SIZE)
            {
                total += (totalMaterials - INCREASE_RATE_SIZE) * INCREASED_RATE;
            }

            // Find the type of material to charge material.
            switch (desk.Material)
            {
                case "pine":
                    total += (float)Material.Pine;
                    break;

                case "oak":
                    total += (float)Material.Oak;
                    break;

                case "Rosewood":
                    total += (float)Material.Rosewood;
                    break;

                case "Laminate":
                    total += (float)Material.Laminate;
                    break;

                case "veneer":
                    total += (float)Material.Veneer;
                    break;
            }

            // Find size of desk to calculate how much to charge for shipping.
            if((_shipping == 3 || _shipping == 5 || _shipping == 7))
            {
                String size;
                if(totalMaterials < 1000)
                {
                    size = "small";
                }
                else if(totalMaterials < 2000){
                    size = "medium";
                }
                else
                {
                    size = "large";
                }
                total += shipping[_shipping][size];
            }

            // Add to price for number of Drawers.
            if (desk.NumDrawers < MAX_DRAWERS && desk.NumDrawers > MIN_NUM_DRAWERS)
            {
                total += desk.NumDrawers * DRAWER_PRICE;
            }

            // return total cost for number of desks requested.
            if (numDesks < 0)
            {
                total = total * numDesks;
            }
            return total;
        }
        public void addAttributes(String firstName, String lastName, float height, float width, float depth, int drawers, String material, int shipping, int quantity)
        {
            desk.setDepth(depth).setHeight(height).setWidth(width).setDrawers(drawers).setMaterial(material);
            this._shipping = shipping;
            this.numDesks = quantity;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void addAttributes(float height, float width, float depth, int drawers, String material, int shipping, int quantity)
        {
            desk.setDepth(depth).setHeight(height).setWidth(width).setDrawers(drawers).setMaterial(material);
            this._shipping = shipping;
            this.numDesks = quantity;
        }

        public Dictionary<String, float> getDeskDetails()
        {
            Dictionary<String, float> dimensions = new Dictionary<String, float>();
            dimensions.Add("Height", desk.Height);
            dimensions.Add("Width", desk.Width);
            dimensions.Add("Depth", desk.Depth);
            dimensions.Add("Drawers", desk.NumDrawers);
            return dimensions;
        }

        public bool validWidth(float width)
        {
            return width > MIN_WIDTH && width < MAX_WIDTH;
        }

        public bool validDepth(float depth)
        {
            return depth > MIN_DEPTH && depth < MAX_DEPTH;
        }

        public bool validHeight(float height)
        {
            return height > MIN_HEIGHT;
        }

        public String getMaterial { 
            get { return desk.Material; } }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime Date
        {
            set { date = value; }
            get { return date; }   
        }

        public int Shipping
        {
            set { _shipping = value; }
            get { return _shipping; }
        }

        public int NumDesks
        {
            set { numDesks = value; }
            get { return numDesks; }
        }
        public int QuoteId
        {
            set { quoteId = value; }
            get { return quoteId; }
        }
        public float maxWidth
        {
            get { return MAX_WIDTH; }
        }
        public float minWidth
        {
            get { return MIN_WIDTH; }
        }
        public float maxDepth
        {
            get { return MAX_DEPTH; }
        }
        public float minDepth
        {
            get { return MIN_DEPTH; }
        }
        public float minHeight
        {
            get { return MIN_HEIGHT; }
        }
        public Desk Desk
        {
            set { desk = value; }
            get { return desk; }
        }
    }
}
