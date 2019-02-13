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
    }
}
