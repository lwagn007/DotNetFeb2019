using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_RepositoryPattern
{
    class ProgramUI
    {
        //Challenge Write a method that shows all streaming content of one user selected genre, Write a method that parses a float 
        private StreamingContentRepository _showRepo;
        private List<StreamingContent> _shows;

        public ProgramUI()
        {
            _showRepo = new StreamingContentRepository();
            _shows = _showRepo.GetContentList();
        }

        public void Run()
        {
            while (RunMenu()) { }
        }

        private bool RunMenu()
        {
            Console.Clear();
            Console.WriteLine($"What do you want to do?\n" +
                $"1. See all shows\n" +
                $"2. Add new show to list\n" +
                $"3. Exit");
            while (true)
            {
                switch (ParseIntput())
                {
                    case 1:
                        PrintAllShows();
                        return true;
                    case 2:
                        CreateNewShow();
                        return true;
                    case 3:
                        return false;
                    default:
                        return true;
                }
            }
        }

        private void PrintAllShows()
        {
            foreach (StreamingContent content in _shows)
            {
                Console.WriteLine($"{content.ContentTitle} {content.Genre} {content.IsMature} {content.StarRating}");
            }
            Console.ReadLine();
        }

        private void CreateNewShow()
        {
            Console.WriteLine("Enter new show title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter genre number:\n" +
                "1. Science Fiction\n" +
                "2. Romance\n" +
                "3. Action");
            int genreInput = ParseIntput();

            Genre genre;
            switch (genreInput)
            {
                case 1:
                    genre = Genre.ScienceFiction;
                    break;
                case 2:
                    genre = Genre.Romance;
                    break;
                default:
                    genre = Genre.Action;
                    break;
            }

            Console.WriteLine("Enter show runtime in minutes: ");
            float length = ParseFloatPut();

            StreamingContent newShow = new StreamingContent(title, genre, length);
            _showRepo.AddContentToList(newShow);
            Console.WriteLine($"\"{title}\" added to list.");
            Console.ReadLine();
        }

        private int ParseIntput()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        private float ParseFloatPut()
        {
            float input = float.Parse(Console.ReadLine());
            return input;
        }
    }
}