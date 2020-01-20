using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Scratcher.Services
{
    public class reason_builder
    {
        public Models.reasons_discription descriptionBuilder(int id)
        {
            Models.reasons_discription modelDescription = new Models.reasons_discription();
            switch (id)
            {
                case 1:
                    modelDescription.id = 1;
                    modelDescription.reason_Description = @"Working for Berkshire Hathaway will "
                    + "give me options to develop code working on the Microsoft Azure Platform"
                    + ", in addition to being able to possiably develope .NetCore and Blazer Applications."
                    + "  Both are high on my list of skills I would like to pursue in the future.";
                    return modelDescription;
                case 2:
                    modelDescription.id = 2;
                    modelDescription.reason_Description = @"Working for Berkshire Hathaway will"
                    + " allow me to have a stable career.  I was with Ameritrade for 12 years and would like to have a "
                    + "equally long term home for my next job.";
                    return modelDescription;
                case 3:
                    modelDescription.id = 3;
                    modelDescription.reason_Description = "I have been in the Financial Service industry since I started coding "
                    + "which means I have been solving a lot of the same puzzles.  I am looking foward to being somewhere new "
                    + "and finding new puzzles for me to solve.";
                    return modelDescription;
                default:
                    modelDescription.id = 999;
                    modelDescription.reason_Description = "Please enter a number between 1-3.";
                    return modelDescription;
            }
        }
    }
}