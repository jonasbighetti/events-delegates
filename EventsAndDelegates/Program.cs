using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.RegisterEvent(mailService.OnVideoEncoded);
            videoEncoder.RegisterEvent(messageService.OnVideoEncoded);

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }
}
