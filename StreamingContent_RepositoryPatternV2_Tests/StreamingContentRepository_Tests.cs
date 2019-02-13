using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamingContent_RepositoryPatternV2;

namespace StreamingContent_RepositoryPatternV2_Tests
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

        [DataTestMethod]
        [DataRow(2, GenreType.Comedy)]
        [DataRow(1, GenreType.Action)]
        [DataRow(3, GenreType.Thriller)]
        public void StreamingContent_GetGenreFromInt_ShouldReturnCorrectEnumValue(int x, GenreType y)
        {
            // Arrange
            StreamingContentRepository _contentRepo = new StreamingContentRepository();

            // Act
            var actual = _contentRepo.GetGenreFromInt(x);

            // Assert
            Assert.AreEqual(y, actual);
        }
    }
}
