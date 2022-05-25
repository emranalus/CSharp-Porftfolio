using ChainOfResponsibility.Abstract;
using System;

namespace ChainOfResponsibility.Concrete
{
    class MP4Player : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".mp4"))
            {
                Console.WriteLine($"{fileType} tipinde medya oynatiliyor...");
            }
            else
            {
                if (_nextHandler != null)
                {
                    //_nextHandler.Player(fileType);
                    Console.WriteLine("Geçersiz dosya bicimi!");
                }
            }
        }
    }
}
