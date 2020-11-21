using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repo
{
    public class StreamingContentRepositroy
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        //Create 
        public void AddContentToList(StreamingContent content)
        {   
            //adding _ makes it a field instead of property so all methods can use the list
            _listOfContent.Add(content);
        }
        //Read
        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }

        //Update
        public bool UpadateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //Find the content 
            StreamingContent oldContent = GetContentByTitle(originalTitle);


            //Update the content 
            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFreindly = newContent.IsFamilyFreindly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
                
            }
            else
            {
                return false;
            }
        }



        //Delete
        public bool RemoveConentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }






        //Helper method
        public StreamingContent GetContentByTitle(string title)
            
        {
            foreach (StreamingContent content in _listOfContent)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }


    }
}
