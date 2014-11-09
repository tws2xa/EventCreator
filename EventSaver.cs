using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace EventCreator
{
    static class EventSaver
    {

        //If something goes wrong, result is set to the error message.
        private static string result = "";

        /// <summary>
        /// Saves the event as a text file.
        /// </summary>
        /// <param name="frmMain">The completely filled out form.</param>
        /// <returns>Returns "" if all went well. Otherwise an error message.</returns>
        public static string SaveEvent(frmMain frmMain)
        {
            //Get file name, check it's valid.
            string fileName = frmMain.GetOutputFileName();
            if(fileName == null) {
                return "Invalid file name";
            }

            //Create the dictionary for the event, check it's valid.
            Dictionary<string, object> eventDictionary = MakeDictionary(frmMain);
            if (eventDictionary == null)
            {
                //If the dictionary wasn't created properly, but result wasn't set - provide a generic error.
                if(result == "") result = "An error occured creating the event dictionary.";
                return result;
            }
            
            //Export to JSON.
            MakeJSON(eventDictionary, fileName);
            
            return result;
        }

        /// <summary>
        /// Creates the dictionary for the event.
        /// </summary>
        /// <param name="frmMain">The filled out event form.</param>
        /// <returns>The dictionary for the event. Null if something goes wrong.</returns>
        private static Dictionary<string, object> MakeDictionary(frmMain frmMain)
        {
            string eventId = frmMain.getEventId();
            string type = frmMain.getEventType();
            List<string> possibleLocations = frmMain.getPossibleLocations();
            List<string> reqParty = frmMain.getRequiredParty();
            string frequency = frmMain.getFrequency();
            string introText = frmMain.getIntroText();
            List<ResponseOption> responseOptions = frmMain.getResponseOptions();
            Dictionary<string, string> advice = frmMain.generateAdviceDictionary();
            bool selectPlayer = frmMain.getSelectPlayer();

            Event theEvent = new Event(eventId, type, possibleLocations, reqParty, frequency, introText, responseOptions, advice, selectPlayer);
            
            return theEvent.myDictionary;
        }

        /// <summary>
        /// Creates the JSON for the event.
        /// </summary>
        /// <param name="eventDictionary">The Event's Dictionary</param>
        /// <param name="fileLoc">The location in which to save the file. Should really be a .txt file.</param>
        private static void MakeJSON(Dictionary<string, object> eventDictionary, string fileLoc)
        {

            string output = JsonConvert.SerializeObject(eventDictionary);

            if (String.IsNullOrWhiteSpace(output))
            {
                result = "An error occured creating the Json.";
                return;
            }

            try
            {
                if (File.Exists(fileLoc)) File.Delete(fileLoc);
            }
            catch (Exception e)
            {
                result = ("An error occured deleting the old file: " + fileLoc + ".\n" + e.Message);
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(File.Create(fileLoc)))
                {
                    writer.Write(output);
                }
            }
            catch (Exception e)
            {
                result = ("An error occured writing to the file: " + fileLoc + ".\n" + e.Message);
            }

        }

    }
}
