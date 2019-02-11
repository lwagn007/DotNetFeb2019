using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_RepositoryPattern
{
    public enum Genre { Comedy = 1, Horror, Action, ScienceFiction, Bromance, Romance }

    public class StreamingContent
    {
        public string ContentTitle { get; set; }
        public Genre Genre { get; set; }
        //What if I wanted only movies of a certain type. What if we were the owners of streaming content and only had the genres comedy, horror, action, ScienceFiction?
        //switch to enum after typing in genres
        public float Length { get; set; }
        public bool IsMature { get; set; }
        public bool HasWatched { get; set; }
        public int StarRating { get; set; }

        //Discuss constructors after they have declared, initialized and tested the object in the test runner.
        //This is our Cookie cutter. Why would we want to have to type more if we can create a cookie cutter or stamp?
        public StreamingContent(string title, Genre genre, bool isMature, bool hasWatched, int starRating)
        {
            ContentTitle = title;
            Genre = genre;
            IsMature = isMature;
            HasWatched = hasWatched;
            StarRating = starRating;
        }

        public StreamingContent(string title, Genre genre, float length)
        {
            ContentTitle = title;
            Genre = genre;
            Length = length;
        }

        //This is default to the class if there is no constructor declared. Show after trying to initializing some values with constructor and not passing all values in.
        public StreamingContent()
        {

        }
    }
}
