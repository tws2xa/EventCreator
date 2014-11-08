using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCreator
{
    public static class Keys
    {
        //* ----------------------------------- */
        // Event Key Values                     //
        //* ----------------------------------- */
        public const string EVENT_ID_KEY = "eventID";
        public const string EVENT_TYPE_KEY = "eventType";
        public const string POSSIBLE_LOCATIONS_KEY = "possibleLocations";
        public const string REQ_PARTY_KEY = "reqParty";

        public const string INTRO_TEXT_KEY = "introText";
        public const string RESPONSE_OPTIONS_KEY = "responseOptions";
        public const string ADVICE_KEY = "advice";
        public const string FLEE_PASS_TEXT_KEY = "fleePassText";
        public const string FLEE_FAIL_TEXT_KEY = "fleeFailText";

        public const string PARTY_MEMBER_TARGETED_KEY = "partyMemberTargeted";


        //* ----------------------------------- */
        // Response Key Values                  //
        //* ----------------------------------- */

        public const String TEXT_KEY = "text";
        //List<Integer>
        public const String RESOURCE_STAT_COST_KEY = "resourceStatCost";
        //List<Integer>
        public const String PARTY_STAT_REQUIREMENT_KEY = "partyStatRequirement";

        //Needed for determining win/lose
        //List<int>
        public const String RESOURCE_MODIFIERS_KEY = "resourceModifiers";
        //List<int>
        public const String PARTY_STAT_MODIFIERS_KEY = "partyStatModifiers";

        //Pass Info
        public const String PASS_TEXT_KEY = "passText";

        //Victory Info
        public const String WIN_TEXT_KEY = "winText";
        public const String WIN_FOLLOW_UP_KEY = "winFollowUp";
        //List<Integer>
        public const String WIN_RESOURCE_CHANGE_KEY = "winResourceChange";
        //List<Integer>
        public const String WIN_PARTY_STAT_CHANGE_KEY = "winPartyStatChange";

        //Lose Info
        public const String LOSE_TEXT_KEY = "loseText";
        public const String LOSE_FOLLOW_UP_KEY = "loseFollowUp";
        //List<Integer>
        public const String LOSE_RESOURCE_CHANGE_KEY = "loseResourceChange";
        //List<Integer>
        public const String LOSE_PARTY_STAT_CHANGE_KEY = "losePartyStatChange";

        
        public const String KILL_PERSON_PASS_KEY = "killPersonPass";
        public const String KILL_PERSON_WIN_KEY = "killPersonWin";
        public const String KILL_PERSON_LOSE_KEY = "killPersonLose";
        public const String REWARD_DISPERSE_LOSE_KEY = "rewardDisperseLose";
        public const String REWARD_DISPERSE_WIN_KEY = "rewardDisperseWin";


    }
}
