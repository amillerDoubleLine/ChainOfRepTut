﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfRespDesignTut.Classes;
using ChainOfRespDesignTut.Enums;

namespace ChainOfRespDesignTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Centurions newCent = new Centurions(CenturionFileRank.ForwardHastati.ToString());
            Centurions orderCent = new Centurions(CenturionFileRank.RearHastati.ToString());

            
            newCent.giveOrders(orderCent);

            newCent = new Centurions(CenturionFileRank.ForwardTriarii.ToString());
            orderCent = new Centurions(CenturionFileRank.ForwardHastati.ToString());

            newCent.giveOrders(orderCent);

            Console.WriteLine("Testing Auto Build on TeamCity");

            Console.WriteLine("Ef The Police Coming Straight From THe Underground Hate A Person Because He Is Brown");

            Console.Read();
        }
    }
}
