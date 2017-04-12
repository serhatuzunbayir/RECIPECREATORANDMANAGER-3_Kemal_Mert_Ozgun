using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCreator
{
    class FileOp
    {
        private List<FileInfo> fileListInfo;

        public List<FileInfo> getFileListInfo()
        {

            return this.fileListInfo;
        }

        public void setFileListInfo(List<FileInfo> fileListInfo)
        {

            this.fileListInfo = fileListInfo;
        }


        public string[] getIngredientsInfo()
        {

            string[] fileInfo = Directory.GetFiles(@"..\..\Menu\Soups\Ingredients");
           
            return fileInfo;
        }

        public string[] getRecipesInfo()
        {

            string[] fileInfo = Directory.GetFiles(@"..\..\Menu\Soups\Recipes");

            return fileInfo;
        }

        public List<string> getRecipesFilesWithoutExtension()
        {
            List<string> fileNameCollector = new List<string>();
            string[] fileInfo = Directory.GetFiles(@"..\..\Menu\Soups\Recipes");
            foreach (string fileName in fileInfo)
            {

                fileNameCollector.Add(Path.GetFileNameWithoutExtension(fileName));
            }
            return fileNameCollector;
        }




        public List<string> getIngredientsFilesWithoutExtension()
        {
            List<string> fileNameCollector = new List<string>();
            string[] fileInfo = Directory.GetFiles(@"..\..\Menu\Soups\Ingredients");
            foreach(string fileName in fileInfo)
            {
                
                fileNameCollector.Add(Path.GetFileNameWithoutExtension(fileName));
            }
            return fileNameCollector;
        }
        
        public Dictionary<string, List<string> > getIngredientsFileContents(string[] filesInfo)
        {

            Dictionary<string, List<string> > fileNameAndContent = new Dictionary<string, List<string> >();
            List<string> fileNameCollector = this.getIngredientsFilesWithoutExtension();

            for(int i = 0; i < filesInfo.Length; ++i)
            {
                StreamReader fileStream = new StreamReader(filesInfo[i]);
                String line = fileStream.ReadToEnd();
                string[] strArr = line.Split(',');
                List<string> tempContent = strArr.ToList();
                fileNameAndContent.Add(fileNameCollector[i], tempContent);
            }

            return fileNameAndContent;
            

        }


        public Dictionary<string, List<string>> getRecipesFileContents(string[] filesInfo)
        {

            Dictionary<string, List<string>> fileNameAndContent = new Dictionary<string, List<string>>();
            List<string> fileNameCollector = this.getRecipesFilesWithoutExtension();

            for (int i = 0; i < filesInfo.Length; ++i)
            {
                StreamReader fileStream = new StreamReader(filesInfo[i]);
                String line = fileStream.ReadToEnd();
                string[] strArr = line.Split(',');
                List<string> tempContent = strArr.ToList();
                fileNameAndContent.Add(fileNameCollector[i], tempContent);
            }

            return fileNameAndContent;


        }


    }
}
