using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamingContent_RepositoryPattern;

namespace StreamingContent_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepository_Tests
    {
        [TestMethod]
        public void StreamingContentRepository_AddToList_ShouldReturnCorrectCount()
        {
            // Arrange
            StreamingContentRepository _contentRepo = new StreamingContentRepository();
            List<StreamingContent> contentList = _contentRepo.GetContentList();
            StreamingContent content = new StreamingContent();
            _contentRepo.AddContentToList(content);

            // Act
            int actual = contentList.Count;
            int expected = 1;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContentRepository_RemoveFromList_ShouldReturnCorrectCount()
        {
            // Arrange
            StreamingContentRepository _contentRepo = new StreamingContentRepository();
            List<StreamingContent> contentList = _contentRepo.GetContentList();

            //Two instances of the StreamingContent class, our POCO (Plain Old CSharp Object)
            StreamingContent content = new StreamingContent();
            StreamingContent contentTwo = new StreamingContent();

            _contentRepo.AddContentToList(content);
            _contentRepo.AddContentToList(contentTwo);

            _contentRepo.RemoveContentFromList(content);

            // Act
            int actual = contentList.Count;
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContentRepository_GetStreamingContentByGenre_ShouldReturnCorrectListCount()
        {
            //Testing a method that returns a new list with filtered results based on genre
            // Arrange
            StreamingContentRepository _contentRepo = new StreamingContentRepository();

            //Three instances of the StreamingContent class, our POCO (Plain Old CSharp Object) with value for the genre property. 
            StreamingContent content = new StreamingContent();
            content.Genre = Genre.Action;
            StreamingContent contentTwo = new StreamingContent();
            contentTwo.Genre = Genre.Action;
            StreamingContent contentThree = new StreamingContent();
            contentThree.Genre = Genre.Bromance;

            _contentRepo.AddContentToList(content);
            _contentRepo.AddContentToList(contentTwo);
            _contentRepo.AddContentToList(contentThree);

            // Act
            int actual = _contentRepo.GetStreamingContentByGenre(Genre.Action).Count;
            int expected = 2;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, Genre.Comedy)]
        [DataRow(3, Genre.Action)]
        [DataRow(5, Genre.Bromance)]
        public void StreamingContentRepository_GetGenreFromInt_ShouldReturnCorrectEnumValue(int x, Genre y)
        {
            // Arrange
            StreamingContentRepository _contentRepo = new StreamingContentRepository();

            // Act
            var actual = _contentRepo.GetGenreFromInt(x);

            // Assert
            Assert.AreEqual(y, actual);
        }

        [TestMethod]
        public void StreamingContentRepository_EnqueueContent_ShouldReturnCorrectCount()
        {
            // Arrange
            StreamingContentRepository _contentRepo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent();
            StreamingContent contentTwo = new StreamingContent();

            _contentRepo.EnqueueContent(content);
            _contentRepo.EnqueueContent(contentTwo);

            // Act
            int actual = _contentRepo.GetContentQueue().Count;
            int expected = 2;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContentRepository_Dequeue()
        {
            StreamingContentRepository _contentRepo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent();
            StreamingContent contentTwo = new StreamingContent();

            _contentRepo.EnqueueContent(content);
            _contentRepo.EnqueueContent(contentTwo);

            _contentRepo.DequeueContent();

            // Act
            int actual = _contentRepo.GetContentQueue().Count;
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContentRepository_EnqueueFromList_BoolShouldReturnTrue()
        {
            // Arrange
            StreamingContentRepository _contentRepo = new StreamingContentRepository();

            StreamingContent content = new StreamingContent();
            content.ContentTitle = "Star Wars";
            content.Genre = Genre.Action;
            StreamingContent contentTwo = new StreamingContent();
            contentTwo.ContentTitle = "Spider-Man";
            contentTwo.Genre = Genre.Action;

            _contentRepo.AddContentToList(content);
            _contentRepo.AddContentToList(contentTwo);

            // Act
            var actual = _contentRepo.EnqueueFromList("Spider-Man", Genre.Action);
            var expected = true;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
