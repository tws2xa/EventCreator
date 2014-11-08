using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCreator
{
    public class Event
    {

        //The dictionary for the event, and all defaults.
        public Dictionary<string, object> myDictionary = new Dictionary<string, object>()
        {
            {Keys.EVENT_ID_KEY, null},
            {Keys.EVENT_TYPE_KEY, "MoveTo"},
            {Keys.POSSIBLE_LOCATIONS_KEY, new List<string>()},
            {Keys.REQ_PARTY_KEY, new List<string>()},
            {Keys.INTRO_TEXT_KEY, "Demo Intro Text!"},
            {Keys.RESPONSE_OPTIONS_KEY, new List<Dictionary<string, object>>()},
            {Keys.ADVICE_KEY, new Dictionary<string, string>()},
            {Keys.FLEE_PASS_TEXT_KEY, "You fled!"},
            {Keys.FLEE_FAIL_TEXT_KEY,"You  failed to flee!"},
            {Keys.PARTY_MEMBER_TARGETED_KEY, false}
        };

        public Event(string id)
        {
            myDictionary[Keys.EVENT_ID_KEY] = id;
        }
        public Event(string id, string type, List<string> possibleLocs, List<string> reqParty, string introText, List<ResponseOption> respOpts,
            Dictionary<string, string> advice, bool targetPartyMember)
        {
            myDictionary[Keys.EVENT_ID_KEY] = id;
            myDictionary[Keys.EVENT_TYPE_KEY] = type;
            myDictionary[Keys.POSSIBLE_LOCATIONS_KEY] = possibleLocs;
            myDictionary[Keys.REQ_PARTY_KEY] = reqParty;
            myDictionary[Keys.INTRO_TEXT_KEY] = introText;
            this.SetResponseOptions(respOpts);
            myDictionary[Keys.ADVICE_KEY] = advice;
            myDictionary[Keys.FLEE_PASS_TEXT_KEY] = "You successfully fled!";
            myDictionary[Keys.FLEE_FAIL_TEXT_KEY] = "You failed to flee!";
            myDictionary[Keys.PARTY_MEMBER_TARGETED_KEY] = targetPartyMember;
        }
        public Event(string id, string type, List<string> possibleLocs, List<string> reqParty, string introText, List<Dictionary<string, object>> respOpts,
            Dictionary<string, string> advice, bool targetPartyMember)
        {
            myDictionary[Keys.EVENT_ID_KEY] = id;
            myDictionary[Keys.EVENT_TYPE_KEY] = type;
            myDictionary[Keys.POSSIBLE_LOCATIONS_KEY] = possibleLocs;
            myDictionary[Keys.REQ_PARTY_KEY] = reqParty;
            myDictionary[Keys.INTRO_TEXT_KEY] = introText;
            myDictionary[Keys.RESPONSE_OPTIONS_KEY] = respOpts;
            myDictionary[Keys.ADVICE_KEY] = advice;
            myDictionary[Keys.FLEE_PASS_TEXT_KEY] = "You successfully fled!";
            myDictionary[Keys.FLEE_FAIL_TEXT_KEY] = "You failed to flee!";
            myDictionary[Keys.PARTY_MEMBER_TARGETED_KEY] = targetPartyMember;
        }


        public void AddResponseOption(ResponseOption toAdd)
        {
            ((List<Dictionary<string, object>>)myDictionary[Keys.RESPONSE_OPTIONS_KEY]).Add(toAdd.myMap);
        }

        public void SetResponseOptions(List<ResponseOption> list)
        {
            myDictionary[Keys.RESPONSE_OPTIONS_KEY] = new List<Dictionary<string, object>>();
            foreach (ResponseOption respOpt in list)
            {
                AddResponseOption(respOpt);
            }
        }

        public void SetResponseOptions(List<Dictionary<string, object>> list)
        {
            myDictionary[Keys.RESPONSE_OPTIONS_KEY] = list;
        }

    }
}
