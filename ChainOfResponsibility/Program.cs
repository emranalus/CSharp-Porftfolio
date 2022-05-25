using ChainOfResponsibility.Abstract;
using ChainOfResponsibility.Concrete;
using ChainOfResponsibility.Lab2.Concrete;
using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab1
            //// To connect the chain together...
            //PlayerHandler mp3player = new MP3Player();
            //PlayerHandler mp4 = new MP4Player();
            //PlayerHandler avi = new AviPlayer();

            //// Connect the cirles of chain
            //mp3player.NextHandler = avi;
            //avi.NextHandler = mp4;

            //// Execute!
            //mp3player.Player("video.avi");
            //mp3player.Player("video.mp3");
            //mp3player.Player("video.mp4");
            //mp3player.Player("video.xxx");
            #endregion

            #region Lab2

            Executive exec = new Executive();
            GeneralManager gm = new GeneralManager();
            CEO ceo = new CEO();

            exec.CostCenter(gm);
            gm.CostCenter(ceo);

            List<Cost> costs = new List<Cost>
            {
                new Cost{Amount=70},
                new Cost{Amount=250},
                new Cost{Amount=4000},
                new Cost{Amount=50070}
            };

            foreach (Cost cost in costs)
            {
                exec.ManageCosts(cost);
            }

            #endregion

        }
    }
}
