
namespace RecipeCreator
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    
    [TestFixture]
    public class RecipeCreatorTest
    {
        [Test]
        public void CheckFilesInfo()
        {
            FileOp fileOp1 = new FileOp();
            string[] result1 = fileOp1.getIngredientsInfo();

            FileOp fileOp2 = new FileOp();
            string[] result2 = fileOp2.getIngredientsInfo();

            Assert.AreEqual(result1, result2);

            FileOp fileOp3 = new FileOp();
            string[] result3 = fileOp3.getRecipesInfo();

            FileOp fileOp4 = new FileOp();
            string[] result4 = fileOp4.getRecipesInfo();
            
            Assert.AreEqual(result3, result4);

            FileOp fileOp5 = new FileOp();
            string[] result5 = fileOp3.getRecipesInfo();

            FileOp fileOp6 = new FileOp();
            string[] result6 = fileOp6.getRecipesInfo();

            Assert.AreEqual(result5, result6);

        }
        [Test]
        public void FilesInfoWithoutExtensionCheck()
        {
            FileOp fileOp1 = new FileOp();
            List<String> keys1 = fileOp1.getIngredientsFilesWithoutExtension();

            FileOp fileOp2 = new FileOp();
            List<String> keys2 = fileOp2.getIngredientsFilesWithoutExtension();


            Assert.AreEqual(keys1, keys2);

            FileOp fileOp3 = new FileOp();
            List<String> keys3 = fileOp3.getRecipesFilesWithoutExtension();

            FileOp fileOp4 = new FileOp();
            List<String> keys4 = fileOp4.getRecipesFilesWithoutExtension();

            Assert.AreEqual(keys3, keys4);





        }
        [Test]
        public void IngredientsFileContentsCheck()
        {
            FileOp fileOp1 = new FileOp();
            string[] result1 = fileOp1.getIngredientsInfo();
            Dictionary<string, List<string>> contents1 = fileOp1.getIngredientsFileContents(result1);

            FileOp fileOp2 = new FileOp();
            string[] result2 = fileOp2.getIngredientsInfo();
            Dictionary<string, List<string>> contents2 = fileOp2.getIngredientsFileContents(result2);

            Assert.AreEqual(result1, result2);

        }

        [Test]
        public void RecipesFileContentsCheck()
        {

            FileOp fileOp1 = new FileOp();
            string[] result1 = fileOp1.getRecipesInfo();
            Dictionary<string, List<string>> contents1 = fileOp1.getRecipesFileContents(result1);


            FileOp fileOp2 = new FileOp();
            string[] result2 = fileOp2.getRecipesInfo();
            Dictionary<string, List<string>> contents2 = fileOp2.getRecipesFileContents(result2);


            Assert.AreEqual(contents1, contents2);
        }


    }
}
