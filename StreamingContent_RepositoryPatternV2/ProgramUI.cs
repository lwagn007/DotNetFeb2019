using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_RepositoryPatternV2
{
    //This is the program interface where menus and console-based helper methods are housed.
    internal class ProgramUI
    {
        StreamingContentRepository _contentRepo = new StreamingContentRepository();
        List<StreamingContent> _listOfContent;
        int _response;

        internal void Run()
        {
            _listOfContent = _contentRepo.GetContentList();
            while (_response != 4)
            {
                PrintMenu();
                switch (_response)
                {
                    case 1:
                        break;
                    case 2:
                        GetUserInput();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Please enter an appropriate number.");
                        break;
                }
            }
            Console.ReadLine();
        }

        public void PrintMenu()
        {
            Console.WriteLine("What would you like to do?\n\t" +
                "1. See all content\n\t" +
                "2. Add new content\n\t" +
                "3. Remove content\n\t" +
                "4. Exit");
            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }

        public void GetUserInput()
        {
            StreamingContent newContent = new StreamingContent();

            Console.WriteLine("Enter the name of your content:");
            string name = Console.ReadLine();
            newContent.Name = name;

            Console.WriteLine("How long is the content in hours?");
            double duration = double.Parse(Console.ReadLine());
            newContent.Duration = duration;

            Console.WriteLine("Is your content a movie? y/n");
            string isMovieStr = Console.ReadLine().ToLower();
            bool isMovie;
            if (isMovieStr.Contains("y"))
                isMovie = true;
            else
                isMovie = false;
            newContent.IsMovie = isMovie;

            Console.WriteLine("What genre is your content?\n\t" +
                "1. Action\n\t" +
                "2. Comedy\n\t" +
                "3. Thriller");
            int genreInt = int.Parse(Console.ReadLine());
            GenreType genre = _contentRepo.GetGenreFromInt(genreInt);
            newContent.TypeOfGenre = genre;

            _contentRepo.AddContentToList(newContent);
        }
    }
}