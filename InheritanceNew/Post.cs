using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNew
{
    class Post
    {
        private static int currentPostId;

        //protected can be used only from members of this class and mebers of the base class
        protected int ID { get; set; }
        protected string Title { get; set; }

        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //Default constructor. If a derived class does not invoke a base-class constructor explicitly
        //the default constructor is called implicitly.
        public Post()
        { 
            ID = 0;
            Title = "My title";
            IsPublic = true;
            SendByUsername = "Miroslav Todorov";
        }

        //Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
        }

        //icrease the ID by 1
        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
