using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCreator
{
    public class ResponseOption
    {

        //Dictionary with default values.
        public Dictionary<string, object> myMap = new Dictionary<string, object>()
        { 
		    {Keys.TEXT_KEY, null},
            {Keys.RESOURCE_STAT_COST_KEY, new List<int>() {0, 0, 0, 0, 0, 0, 0, 0}},
		    {Keys.PARTY_STAT_REQUIREMENT_KEY,  new List<int>() {0, 0, 0, 0, 0, 0, 0, 0}},
		    {Keys.RESOURCE_MODIFIERS_KEY, new List<string>() {"0", "0", "0", "0", "0", "0", "0", "0"}},
            {Keys.PARTY_STAT_MODIFIERS_KEY, new List<string>() {"0", "0", "0", "0", "0", "0", "0", "0"}},
		    {Keys.PASS_TEXT_KEY, ""},
		    {Keys.WIN_TEXT_KEY, ""},
		    {Keys.WIN_FOLLOW_UP_KEY, ""},
		    {Keys.WIN_RESOURCE_CHANGE_KEY, new List<int>() {0, 0, 0, 0, 0, 0, 0, 0}},
		    {Keys.WIN_PARTY_STAT_CHANGE_KEY, new List<int>() {0, 0, 0, 0, 0, 0, 0, 0}},
            {Keys.LOSE_TEXT_KEY, ""},
		    {Keys.LOSE_FOLLOW_UP_KEY, ""},
		    {Keys.LOSE_RESOURCE_CHANGE_KEY, new List<int>() {0, 0, 0, 0, 0, 0, 0, 0}},
		    {Keys.LOSE_PARTY_STAT_CHANGE_KEY, new List<int>() {0, 0, 0, 0, 0, 0, 0, 0}}
        };

        /// <summary>
        /// Creates an empty response option with default values.
        /// </summary>
        /// <param name="text">The text for the response option.</param>
        public ResponseOption(string text)
        {
            myMap[Keys.TEXT_KEY] = text;
        }

        /// <summary>
        /// Creates a response option with ALL the things!
        /// </summary>
        /// <param name="text">Text for the response.</param>
        /// <param name="resourceStatCosts">Cost for all resource (global) stats.</param>
        /// <param name="partyStatCosts">Cost for all party stats.</param>
        /// <param name="resourceStatReqs">Requirements for all resource (global) stats.</param>
        /// <param name="partyStatReqs">Requirements for all party stats.</param>
        /// <param name="resourceStatModifiers">Modifier values for resource (global) stats.</param>
        /// <param name="partyStatModifiers">Modifier values for party stats.</param>
        /// <param name="winText">Text displayed if you win the event.</param>
        /// <param name="passText">Text displayed if you pass the event.</param>
        /// <param name="failText">Text displayed if you fail the event.</param>
        /// <param name="winFollowUp">File address of follow up event if you win.</param>
        /// <param name="passFollowUp">File address of follow up event if you pass.</param>
        /// <param name="loseFollowUp">File address of follow up event if you lose.</param>
        /// <param name="winResourceChange">Resource (global) stat changes if you win the event.</param>
        /// <param name="winPartyStatChange">Party stat changes if you win.</param>
        /// <param name="loseResourceChange">Resource (global) stat changes if you lose.</param>
        /// <param name="losePartyStatChange">Party stat changes if you lose.</param>
        public ResponseOption(string text, List<int> resourceStatCosts, List<int> partyStatCosts, List<int> resourceStatReqs, List<int> partyStatReqs,
            List<string> resourceStatModifiers, List<string> partyStatModifiers,
            string winText, string passText, string failText, string winFollowUp, string passFollowUp, string loseFollowUp,
            List<int> winResourceChange, List<int> winPartyStatChange, List<int> loseResourceChange, List<int> losePartyStatChange)
        {
            myMap[Keys.TEXT_KEY] = text;
            myMap[Keys.RESOURCE_STAT_COST_KEY] = resourceStatCosts;
            myMap[Keys.PARTY_STAT_REQUIREMENT_KEY] = partyStatReqs;
            myMap[Keys.RESOURCE_MODIFIERS_KEY] = resourceStatModifiers;
            myMap[Keys.PARTY_STAT_MODIFIERS_KEY] = partyStatModifiers;
            myMap[Keys.PASS_TEXT_KEY] = passText;
            myMap[Keys.WIN_TEXT_KEY] = winText;
            myMap[Keys.WIN_FOLLOW_UP_KEY] = winFollowUp;
            myMap[Keys.WIN_RESOURCE_CHANGE_KEY] = winResourceChange;
            myMap[Keys.WIN_PARTY_STAT_CHANGE_KEY] = winPartyStatChange;
            myMap[Keys.LOSE_TEXT_KEY] = failText;
            myMap[Keys.LOSE_FOLLOW_UP_KEY] = loseFollowUp;
            myMap[Keys.LOSE_RESOURCE_CHANGE_KEY] = loseResourceChange;
            myMap[Keys.LOSE_PARTY_STAT_CHANGE_KEY] = losePartyStatChange;

        }
    }
}
