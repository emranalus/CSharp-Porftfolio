using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Abstract
{
    abstract class PlayerHandler
    {

        protected PlayerHandler _nextHandler;

        public PlayerHandler NextHandler { set => _nextHandler = value; }

        public abstract void Player(string fileType);

    }
}
