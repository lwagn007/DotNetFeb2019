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
            SeedData();
            while (_response != 4)
            {
                Console.Clear();
                PrintMenu();
                switch (_response)
                {
                    case 1:
                        SeeAllContent();
                        break;
                    case 2:
                        GetUserInput();
                        break;
                    case 3:
                        RemoveContent();
                        break;
                    case 4:
                        Console.WriteLine("Have a nice day!");
                        break;
                    default:
                        Console.WriteLine("Please enter an appropriate number.");
                        break;
                }
            }
            Console.ReadLine();
        }

        private void RemoveContent()
        {
            SeeAllContent();

            Console.WriteLine("Enter the name of the content you would like to remove:");
            string desiredName = Console.ReadLine();

            foreach(StreamingContent content in _listOfContent)
            {
                if(desiredName == content.Name)
                {
                    _contentRepo.RemoveContentFromList(content);
                    break;
                }
            }
        }

        private void SeedData()
        {
            //Different ways to initialize values for our POCO's (Plain Old Csharp Object)
            StreamingContent contentTwo = new StreamingContent("Bob's Burgers", 0.5, GenreType.Comedy, false);

            StreamingContent contentThree = new StreamingContent();
            contentThree.Name = "Transformers";
            contentThree.Duration = 2.4;
            contentThree.TypeOfGenre = GenreType.Action;
            contentThree.IsMovie = true;

            StreamingContent contentFour = new StreamingContent()
            {
                Name = "American Horror Story",
                Duration = 1,
                TypeOfGenre = GenreType.Thriller,
                IsMovie = false
            };

            //Even though the values are not set this is still a instance of StreamingContent
            StreamingContent contentFive = new StreamingContent();
        
            _contentRepo.AddContentToList(new StreamingContent("Star Wars", 2.1, GenreType.Action, true));
            _contentRepo.AddContentToList(contentTwo);
            _contentRepo.AddContentToList(contentThree);
            _contentRepo.AddContentToList(contentFour);
            _contentRepo.AddContentToList(contentFive);
        }

        private void SeeAllContent()
        {
            Console.WriteLine("Content Name\tContent Duration\tGenre\tIs it a Movie");
            foreach (StreamingContent content in _listOfContent)
            {
                Console.WriteLine($"{content.Name}\t{content.Duration} Hours\t\t{content.TypeOfGenre}\t{content.IsMovie}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
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