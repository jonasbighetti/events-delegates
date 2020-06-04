using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;
        //or
        private event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding {video.Title}...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }

        public void RegisterEvent(EventHandler<VideoEventArgs> videoEncodedEvent)
        {
            VideoEncoded += videoEncodedEvent;
        }
    }
}
