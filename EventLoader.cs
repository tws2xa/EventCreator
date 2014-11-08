using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace EventCreator
{
    static class EventLoader
    {

        public static string status = "";

        /// <summary>
        /// Returns an event read from the text file provided.
        /// If an error occurs, access "status" to get error message.
        /// </summary>
        /// <param name="fileAddr">Complete file address of the text file to load.</param>
        /// <returns>Event from file, or null if an error occured.</returns>
        public static Event GetEventFromFile(string fileAddr)
        {
            string fromFile = ReadFile(fileAddr);
            if (fromFile == "") return null;

            Dictionary<string, object> eventDictionary = GetDictionaryFromJSONString(fromFile);
            if (eventDictionary == null) return null;

            Event theEvent = GetEventFromDictionary(eventDictionary);

            return theEvent;
        }

        /// <summary>
        /// Provides the text contained in the file at location fileAddr.
        /// </summary>
        /// <param name="fileAddr">Complete file address of the file to read.</param>
        private static string ReadFile(string fileAddr)
        {
            try
            {
                using (FileStream fileStream = File.OpenRead(fileAddr))
                {
                    using (StreamReader writer = new StreamReader(fileStream))
                    {
                        string toRet = writer.ReadToEnd();
                        return toRet;
                    }
                }
            }
            catch (Exception e)
            {
                status = "Error reading file: " + fileAddr + "\n" + e.Message;
                return "";
            }
        }

        /// <summary>
        /// Translates the given json string into a Dictionary.
        /// </summary>
        /// <param name="json">Json string to translate.</param>
        /// <returns>Dictionary[string, object] or null if an error occured.</returns>
        private static Dictionary<string, object> GetDictionaryFromJSONString(string json)
        {
            try
            {
                Dictionary<string, object> toRet = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                return toRet;
            }
            catch (Exception e)
            {
                status = "Error translating JSON:\n" + e.Message;
                return null;
            }
        }


        private static Event GetEventFromDictionary(Dictionary<string, object> eventDictionary)
        {
            Event toRet = new Event(eventDictionary);
            return toRet;
        }

    }
}
