using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNew
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ImagePost() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        { 
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            //member of ImagePost, doesn't exist in Post class
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }

    }
}
