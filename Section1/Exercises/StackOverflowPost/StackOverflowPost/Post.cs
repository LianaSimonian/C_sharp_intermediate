using System;

namespace StackOverflowPost
{
    internal class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        private int _voteValue;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            CreatedAt = DateTime.Now;
            _voteValue = 0;
        }
        public int VoteValue
        {
            get { return _voteValue; }
        }
        public void UpVote()
        {
            _voteValue++;
        }
        public void DownVote()
        {
            _voteValue--;
        }
    }
}
