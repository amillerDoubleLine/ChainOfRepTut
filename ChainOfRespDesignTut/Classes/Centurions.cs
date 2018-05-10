using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespDesignTut.AbstractClasses;
using ChainOfRespDesignTut.Enums;

namespace ChainOfRespDesignTut.Classes
{
    internal class Centurions : ALegionary
    {
        public Centurions(string file)
        {
            rank = LegionaryRankOrder.Centurions.ToString();
            this.file = file;
        }

        public override void giveOrders(ALegionary orderTaker)
        {
            Console.WriteLine("Your Rank is: {0} of File: {1}", rank, file);
            if(checkIfRankIsHigher(orderTaker.rank) || checkIfRankIsEqual(orderTaker.rank))
            {
                if(checkIfFileIsHigher(orderTaker.file))
                {
                    Console.WriteLine("Order were taken by Rank: {0} of File: {1}", orderTaker.rank, orderTaker.file);
                    return;
                }
            }


            Console.WriteLine(
                "Your order fell on silent ears.\nYou wander to people with lower ranks or files than the previous ones.");

            if(checkIfRankIsEqual(orderTaker.rank))
            {
                int orderTakerFileNumber =
                    (int) (CenturionFileRank) Enum.Parse(typeof(CenturionFileRank), orderTaker.file);
                int orderGiverFileNumber =
                    (int) (CenturionFileRank) Enum.Parse(typeof(CenturionFileRank), this.file);

                if(orderGiverFileNumber <= orderTakerFileNumber)
                {
                    //TODO: ADD LOWER OF CEN RANK TO LOWER RANKS
                    if(orderTakerFileNumber == 1)
                    {
                        int orderTakerRankNumber =
                            (int) (LegionaryRankOrder) Enum.Parse(typeof(CenturionFileRank), orderTaker.rank);
                        orderTaker.rank = ((LegionaryRankOrder) (orderTakerFileNumber - 1)).ToString();
                    }

                    orderTaker.file = ((CenturionFileRank) (orderTakerFileNumber - 1)).ToString();
                    giveOrders(orderTaker);
                }
            }
            else
            {
                //TODO:Add ranking down from Senior Officers to Centurion
                //int orderTakerRankNumber = 
            }
        }

        public override void takeOrders()
        {
            throw new NotImplementedException();
        }

        public override bool checkIfRankIsHigher(string comparingRank)
        {
            var orderComparingRankNumber =
                (int) (LegionaryRankOrder) Enum.Parse(typeof(LegionaryRankOrder), comparingRank);
            var orderGiverRankNumber = (int) (LegionaryRankOrder) Enum.Parse(typeof(LegionaryRankOrder), rank);

            return orderGiverRankNumber > orderComparingRankNumber;
        }

        public override bool checkIfRankIsEqual(string comparingRank)
        {
            var orderComparingRankNumber =
                (int) (LegionaryRankOrder) Enum.Parse(typeof(LegionaryRankOrder), comparingRank);
            var orderGiverRankNumber = (int) (LegionaryRankOrder) Enum.Parse(typeof(LegionaryRankOrder), rank);

            return orderGiverRankNumber == orderComparingRankNumber;
        }


        public override bool checkIfFileIsHigher(string comparingFile)
        {
            var orderTakerFileNumber = (int) (CenturionFileRank) Enum.Parse(typeof(CenturionFileRank), comparingFile);
            var orderGiverFileNumber = (int) (CenturionFileRank) Enum.Parse(typeof(CenturionFileRank), file);
            return orderGiverFileNumber > orderTakerFileNumber;
        }

        public override bool checkIfFileIsEqual(string comparingFile)
        {
            var orderTakerFileNumber = (int) (CenturionFileRank) Enum.Parse(typeof(CenturionFileRank), comparingFile);
            var orderGiverFileNumber = (int) (CenturionFileRank) Enum.Parse(typeof(CenturionFileRank), file);
            return orderGiverFileNumber == orderTakerFileNumber;
        }
    }
}