using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_RepositoryPattern
{
    public class StreamingContentRepository
    {
        List<StreamingContent> _listOfContent = new List<StreamingContent>();
        Queue<StreamingContent> _queueOfContent = new Queue<StreamingContent>();

        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        public void RemoveContentFromList(StreamingContent content)
        {
            _listOfContent.Remove(content);
        }

        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }

        public void EnqueueContent(StreamingContent content)
        {
            _queueOfContent.Enqueue(content);
        }

        public void DequeueContent()
        {
            _queueOfContent.Dequeue();
        }

        public Queue<StreamingContent> GetContentQueue()
        {
            return _queueOfContent;
        }

        public List<StreamingContent> GetStreamingContentByGenre(Genre genre)
        {
            List<StreamingContent> genreShows = new List<StreamingContent>();
            foreach (StreamingContent show in _listOfContent)
            {
                if (show.Genre == genre)
                {
                    genreShows.Add(show);
                }
            }
            return genreShows;
        }

        public bool EnqueueFromList(string title, Genre genre)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if(title == content.ContentTitle && genre == content.Genre)
                {
                    EnqueueContent(content);
                    return true;
                }
            }
            return false;
        }

        public Genre GetGenreFromInt(int genreInput)
        {
            Genre genre;
            switch (genreInput)
            {
                case 1:
                    genre = Genre.Comedy;
                    break;
                case 2:
                    genre = Genre.Horror;
                    break;
                case 3:
                    genre = Genre.Action;
                    break;
                case 4:
                    genre = Genre.ScienceFiction;
                    break;
                case 5:
                    genre = Genre.Bromance;
                    break;
                case 6:
                    genre = Genre.Romance;
                    break;
                default:
                    genre = Genre.ScienceFiction;
                    break;
            }
            return genre;
        }
    }
}
