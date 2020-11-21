using _06_RepositoryPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepositroy _contentRepo = new StreamingContentRepositroy();
        //method that runs/starts UI part of application
        public void Run()
        {
            SeeContentList();
            Menu();

        }
        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display our options to user
                Console.WriteLine("Select a menu option:\n" +
                 "1. Creat New Content\n" +
                 "2. View All Content\n" +
                 "3. View Content By Title\n" +
                 "4. Update Existing Content\n" +
                 "5. Delete Existing Content\n" +
                 "6. Exit");





                //Get the users input
                string input = Console.ReadLine();

                //Evaluate users input and act accordingly 
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //View all content
                        DisplayAllContent();
                        break;
                    case "3":
                        // View conent by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update existing content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //Delete existing content
                        DeleteExistingContent();
                        break;
                    case "6":
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue");

                Console.Clear();
            }
        }
        //Create new streaming content
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();
            //Title
            Console.WriteLine("Enter the title for the contenet");
            newContent.Title = Console.ReadLine();
            //Description
            Console.WriteLine("Enter a description for the content");
            newContent.Description = Console.ReadLine();
            // Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, R, etc.");
            newContent.MaturityRating = Console.ReadLine();
            // Star Rating
            Console.WriteLine("Enter the star count for the content (3, 3.5, 4.7, 5");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);
            //Is Family Friendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFreindly = true;
            }
            else
            {
                newContent.IsFamilyFreindly = false;
            }
            //Genre Type
            Console.WriteLine("Enter the genre number\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            //Parse turns int into string
            int genreAsList = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsList;

            _contentRepo.AddContentToList(newContent);


            /*
             Horror = 1,
             RomCom,
             SciFi,
             Documentary,
             Bromance,
             Drama,
             Action,
            */

        }

        //View current streaming content that is saved 
        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _contentRepo.GetContentList();

            foreach (StreamingContent content in listOfContent) ;
        }
        //View existing content by title
        private void DisplayContentByTitle()
        {
            Console.Clear();
            //Prompt the user to give the title 
            Console.WriteLine("Enter the title of the content you would like to see");


            //Get the users input 
            string title = Console.ReadLine();

            // Find the content  by the title 
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            //Display said content if it is not null
            if (content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Maturity Rating:{content.MaturityRating}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Is Family Friendly: {content.IsFamilyFreindly}\n" +
                    $"Genre: {content.TypeOfGenre}");


            }
            else
            {
                Console.WriteLine("No content by that title");
            }

        }
        //Udpdate existing content
        private void UpdateExistingContent()
        {
            //Display all content
            DisplayAllContent();

            //Ask for the title of the content to update
            Console.WriteLine("Enter the title of the content you would like to update");


            //Get that title
            string oldTitle = Console.ReadLine();

            //We will build a new object
            StreamingContent newContent = new StreamingContent();
            //Title
            Console.WriteLine("Enter the title for the contenet");
            newContent.Title = Console.ReadLine();
            //Description
            Console.WriteLine("Enter a description for the content");
            newContent.Description = Console.ReadLine();
            // Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, R, etc.");
            newContent.MaturityRating = Console.ReadLine();
            // Star Rating
            Console.WriteLine("Enter the star count for the content (3, 3.5, 4.7, 5");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);
            //Is Family Friendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFreindly = true;
            }
            else
            {
                newContent.IsFamilyFreindly = false;
            }
            //Genre Type
            Console.WriteLine("Enter the genre number\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            //Parse turns int into string
            int genreAsList = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsList;

            //Verify update works
            bool wasUpdated = _contentRepo.UpadateExistingContent(oldTitle, newContent);

            if (wasUpdated)
            {
                Console.WriteLine("Content was successfully updated.");


            }
            else
            {
                Console.WriteLine("Could not updated content.");
            }
        }

        //Delete existing content 
        private void DeleteExistingContent()
        {

            DisplayAllContent();

            //Prompt user title to be deleted
            Console.WriteLine("\nEnter title of content you want to be removed");

            string input = Console.ReadLine();

            //Call the deleted  method 
            bool wasDeleted = _contentRepo.RemoveConentFromList(input);

            //If the content was deleted, say so
            //Otherwise stateif the could not be deleted 
            if (wasDeleted)
            {
                Console.WriteLine("Content was deleted");
            }
            else
            {
                Console.WriteLine("Content could not be deleted");
            }



        }

        //See Method
        private void SeeContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks.", " TV-14", 3.3, true, GenreType.Action);
            StreamingContent TheRoom = new StreamingContent("The Room", "Banker's life gets turned upside down", "R", 3.7, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on killing spree.", "R", 5.8, false, GenreType.Documentary);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(TheRoom);
            _contentRepo.AddContentToList(rubber);


        }

    }
}






