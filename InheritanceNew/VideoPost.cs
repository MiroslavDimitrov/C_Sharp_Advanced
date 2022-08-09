using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNew
{
    class VideoPost : Post
    {
        //fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        //properties
        protected string VideoURL { get; set; }
        protected int Lenght { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public VideoPost() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public VideoPost(string title, string sendByUsername, string videoURL, int lenght, bool isPublic)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            VideoURL = videoURL;
            Lenght = lenght;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", this.ID, this.Title, this.VideoURL,this.Lenght, this.SendByUsername);
        }

        public void Play()
        {
            if (!isPlaying)
            { 
                isPlaying = true;
                Console.WriteLine("Playing.");
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
                timer = new Timer(TimerCallback, null, 0, 1000);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            }
            
        }

        private void TimerCallback(Object obj)
        {
            if (currentDuration < Lenght)
            {
                if (isPlaying)
                {
                    currentDuration++;
                    Console.WriteLine("Video is at {0}s", currentDuration);
                    GC.Collect();
                }
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            isPlaying = false;
            Console.WriteLine("Stopped at {0}s", currentDuration);
            currentDuration = 0;
            timer.Dispose();
        }
    }
}
