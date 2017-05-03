using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RecipeCreator
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> fileNameAndContentIngredientCollector;
        Dictionary<string, List<string>> fileNameAndContentRecipeCollector;
     
        public Form1()
        {
            InitializeComponent();
            FileOp fileOp = new FileOp();
            string[] filesInfoIngredients = fileOp.getIngredientsInfo();
            string[] filesInfoRecipes = fileOp.getRecipesInfo();

            fileNameAndContentIngredientCollector = fileOp.getIngredientsFileContents(filesInfoIngredients);
            fileNameAndContentRecipeCollector = fileOp.getRecipesFileContents(filesInfoRecipes);
            List<string> keyList = new List<string>(fileNameAndContentIngredientCollector.Keys);
           

            foreach (string key in keyList)
            {

                lstSoup.Items.Add(key);
            }


        }

        private void lstSoup_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoupIngredients.Clear();
            txtSoupRecipes.Clear();
            txtImgSoupList.Clear();
            string ingredients = "";
            string recipe = "";
            int sentenceCounterIngredient = fileNameAndContentIngredientCollector[lstSoup.SelectedItem.ToString()].Count;
            int sentenceCounterRecipe = fileNameAndContentRecipeCollector[lstSoup.SelectedItem.ToString()].Count;

           
            for (int i = 0; i < sentenceCounterIngredient; ++i)
            {
                ingredients += fileNameAndContentIngredientCollector[lstSoup.SelectedItem.ToString()][i];
               
            }

            for(int j=0; j < sentenceCounterRecipe; ++j )
            {
                recipe += fileNameAndContentRecipeCollector[lstSoup.SelectedItem.ToString()][j];
            }

               
            txtSoupIngredients.Text = ingredients;
            txtSoupRecipes.Text = recipe;
            DataFormats.Format dataFormat = DataFormats.GetFormat(DataFormats.Bitmap);
           Clipboard.SetImage(Image.FromFile(@"..\..\Menu\Soups\Img\" + lstSoup.SelectedItem.ToString() + ".jpg"));
            txtImgSoupList.Paste(dataFormat);


            
            



        }
    }
}
