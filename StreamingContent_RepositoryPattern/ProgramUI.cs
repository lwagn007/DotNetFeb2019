using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StreamingContent_RepositoryPattern
{
    class ProgramUI
    {
        //Challenge Write a method that shows all streaming content of one user selected genre, Write a method that parses a float 
        private StreamingContentRepository _streamingContentRepo;
        private List<StreamingContent> _contentList;
        private Queue<StreamingContent> _contentQueue;

        public ProgramUI()
        {
            _streamingContentRepo = new StreamingContentRepository();
            _contentList = _streamingContentRepo.GetContentList();
            _contentQueue = _streamingContentRepo.GetContentQueue();
        }

        public void Run()
        {
            SeedData();
            while (RunMenu()) { }
        }

        private bool RunMenu()
        {
            Console.Clear();
            Console.WriteLine($"What do you want to do?\n" +
                $"1. See all shows\n" +
                $"2. Add new show to list\n" +
                $"3. Add show to queue\n" +
                $"4. See what's next\n" +
                $"5. Watch what's next\n" +
                $"6. Exit");
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
                        AddShowToQueue();
                        return true;
                    case 4:
                        PrintNextOnQueue();
                        return true;
                    case 5:
                        RemoveNextOnQueue();
                        return true;
                    case 6:
                        return false;
                    default:
                        return true;
                }
            }
        }

        private void RemoveNextOnQueue()
        {
            StreamingContent content = _contentQueue.Dequeue();
            Console.WriteLine($"{content.ContentTitle} removed");
            Thread.Sleep(3000);
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }

        private void PrintNextOnQueue()
        {
            StreamingContent content = _contentQueue.Peek();
            Console.WriteLine($"{content.ContentTitle}\t{content.Genre}\t{content.Length}");
            Thread.Sleep(3000);
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }

        private void AddShowToQueue()
        {
            PrintAllShows();

            Console.WriteLine("Please enter the title of the content to add to your queue.");
            string title = Console.ReadLine();

            Console.WriteLine("Please enter the genre of the content.");
            int input = GenreMenu();

            Genre genre = _streamingContentRepo.GetGenreFromInt(input);

            bool success = _streamingContentRepo.EnqueueFromList(title, genre);

            if(success == true)
                Console.WriteLine("Content was added to your queue.");
            else
                Console.WriteLine("Unable to add to queue at this time.");
            Thread.Sleep(3000);
        }

        private void PrintAllShows()
        {
            foreach(StreamingContent content in _contentList)
            {
                Console.WriteLine($"{content.ContentTitle} {content.Genre} {content.IsMature} {content.StarRating}");
            }
            Thread.Sleep(3000);
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }

        private void CreateNewShow()
        {
            Console.WriteLine("Enter new show title:");
            string title = Console.ReadLine();
            GenreMenu();
            int genreInput = ParseIntput();

            Genre genre = _streamingContentRepo.GetGenreFromInt(genreInput);

            Console.WriteLine("Enter show runtime in minutes: ");
            float length = ParseFloatPut();

            StreamingContent newShow = new StreamingContent(title, genre, length);
            _streamingContentRepo.AddContentToList(newShow);

            Console.WriteLine($"\"{title}\" added to list.");
            Console.ReadLine();
        }

        private int GenreMenu()
        {
            Console.WriteLine("Enter genre number:\n" +
                            "1. Comedy\n" +
                            "2. Horror\n" +
                            "3. Action\n" +
                            "4. Science Fiction\n" +
                            "5. Bromance\n" +
                            "6. Romance");
            int input = int.Parse(Console.ReadLine());
            return input;
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

        private void SeedData()
        {
            //Different ways to initialize values for our POCO's (Plain Old Csharp Object)
            StreamingContent contentTwo = new StreamingContent("Transformers", Genre.Action, false, true, 3);

            StreamingContent contentThree = new StreamingContent();
            contentThree.ContentTitle = "I Love You Man!";
            contentThree.Length = 2;
            contentThree.Genre = Genre.Bromance;
            contentThree.HasWatched = true;

            StreamingContent contentFour = new StreamingContent()
            {
                ContentTitle = "American Horror Story",
                Length = 1,
                Genre = Genre.Horror,
                HasWatched = true,
                IsMature = true,
                StarRating = 3
            };

            //Even though the values are not set this is still a instance of StreamingContent
            StreamingContent contentFive = new StreamingContent();

            _streamingContentRepo.AddContentToList(new StreamingContent("Star Wars", Genre.Action,false,true, 4));
            _streamingContentRepo.AddContentToList(contentTwo);
            _streamingContentRepo.AddContentToList(contentThree);
            _streamingContentRepo.AddContentToList(contentFour);
            _streamingContentRepo.AddContentToList(contentFive);
        }
    }
}