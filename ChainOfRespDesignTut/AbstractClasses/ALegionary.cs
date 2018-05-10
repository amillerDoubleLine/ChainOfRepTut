

//You can order people in your same rank
//You can not order people in your same file
namespace ChainOfRespDesignTut.AbstractClasses
{
    public abstract class ALegionary
    {
        protected ALegionary higherUp;

        public string rank { get; set; }

        public string file { get; set; }

        public abstract void giveOrders(ALegionary orderTaker);

        public abstract void takeOrders();

        public abstract bool checkIfRankIsHigher(string comparingRank);

        public abstract bool checkIfRankIsEqual(string comparingRank);

        public abstract bool checkIfFileIsHigher(string comparingFile);

        public abstract bool checkIfFileIsEqual(string comparingFile);

    }
}