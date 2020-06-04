using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"{args.Video.Title}: Sending an e-mail...");
        }
    }
}
