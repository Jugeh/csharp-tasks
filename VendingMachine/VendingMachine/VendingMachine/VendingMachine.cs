
namespace VendingMachine
{
    /// <summary>
    /// The class <CODE>VendingMachine</CODE> represents vending machines
    /// which sell bottles of soda.Each vending machine has a (changeable)
    /// price per bottle, and is operated by first inserting cash into the
    /// machine(method<CODE> InsertMoney</CODE>; the method can be called
    /// multiple times to incrementally add money) and then finishing the
    /// purchase with the method<CODE> buyBottle</CODE>. A vending machine
    /// object keeps track of the amount of money that it has "earned" from
    /// bottle sales.
    /// <P> 
    /// For the purposes of this class, all bottles are assumed to be
    /// identical, and the machine is supposed to contain an endless supply
    /// of coins to give as change to users.
    /// </summary>
    public class VendingMachine
    {
        private int bottleCount;
        private double bottlePrice;
        private double earnedCash;
        private double insertedCash;

        /// <summary>
        /// Creates a new vending machine with the given number of bottles in it,
        /// the given price per bottle, and no cash. 
        /// </summary>
        /// <param name="initialBottleCount">The amount of bottles when a new
        /// machine is created (int).</param>
        /// <param name="bottlePrice">The price of one bottle (double).</param>
        public VendingMachine(int initialBottleCount, double bottlePrice)
        {
            bottleCount = initialBottleCount;
            this.bottlePrice = bottlePrice;

        }

        /// <summary>
        /// Gets and Sets the price per bottle of soda for this machine.
        /// </summary>
        public double BottlePrice
        {
            get
            {
                return bottlePrice;
            }
            set
            {
                bottlePrice = value;
            }
        }

        /// <summary>
        /// Determines if the machine is sold out. I.e., determines if
        /// there are no more bottles in the machine.
        /// </summary>
        /// <returns>Returns a boolean value indicating if there are no 
        /// bottles in the machine (bool).</returns>
        public bool IsSoldOut()
        {
            if (bottleCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Inserts a sum of money into the machine. This corresponds to the user 
        /// putting coins in the machine. The inserted money is not considered
        /// part of the machine's earnings yet; instead, it can be used to
        /// make a bottle purchase. It is possible to insert more money into the
        /// machine than is required for making a purchase.
        /// </summary>
        /// <param name="insertedSum">A (positive) sum of money to insert.</param>
        ////
        public void InsertMoney(double insertedSum)
        {
            insertedCash = insertedCash + insertedSum;
        }


        /// <summary>
        /// Adds a number of bottles to the machine.
        /// <summary>
        /// <param name="numberOfNewBottles">A positive number indicating how 
        /// many bottles to add (int).</param>
        public void AddBottles(int numberOfNewBottles)
        {
            bottleCount = bottleCount + numberOfNewBottles;
        }


        /// <summary>
        /// Empties the machine's cashbox. That is, returns the amount of money
        /// the machine has earned so far from bottle sales and resets the 
        /// earnings counter to zero.
        /// <summary>
        /// <returns>The amount of money that was in the cashbox before emptying (double).</returns>
        ////
        public double EmptyCashbox()
        {
            return earnedCash;
        }


        /// <summary>
        /// Buys a bottle from the machine, assuming there is enough money inserted,
        /// and all bottles have not yet been sold. Buying a bottle causes money to
        /// be added to the machine's earnings and a bottle to be removed from stock. 
        /// <summary>
        /// <returns>The change given to the buyer (inserted money minus bottle price), 
        /// or a negative value in case the bottle could not be bought (double).</returns> 
        public double BuyBottle()
        {
            if (insertedCash > bottlePrice)
            {
                earnedCash += bottlePrice;
                bottleCount -= 1;
                //johki tähä insertedCashin nollaus
                return insertedCash - bottlePrice;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Returns the status of the machine. The string contains the number of bottles left,
        /// bottle price and earned money in the form:
        /// 
        /// Bottles left: 3
        /// Bottle price: 1,45 euroa
        /// Money earned: 205,25 euroa
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Bottles left: {0}\nBottle price: {1} euroa\nMoney earned: {2} euroa", bottleCount, bottlePrice, earnedCash);
        }
    }
}



