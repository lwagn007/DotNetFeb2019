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
    }
}
