using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCreator
{
    static class TestEvent
    {

        public static Event GetEvent() {

            string eventId = "Socrates Attack";
            string type = "MoveTo";

		    List<String> possibleLocations = new List<String>();
		    possibleLocations.Add("Plains");
		    possibleLocations.Add("Jungle");
		
		    List<String> reqParty = new List<String>();
		    
		    string introText = "A wild Socrates approaches and asks for your thoughts on the education of today's youth!";
		
		    Dictionary<string,string> advice = new Dictionary<string,string>();
            advice.Add("Umbopa", "NRun!");
            advice.Add("Macumazahn", "NWhat's he doing here?");
            advice.Add("Wonai", "NI think we took a wrong turn...");
            advice.Add("Tariro", "NNot again!");
            advice.Add("Jan Kruger", "N...");
            advice.Add("Theunis Van Zyl", "NQuick, play dead!");
            advice.Add("Willem de Bruin", "NWhat a beard he has!");
            advice.Add("Jakobus Kotze", "NHow'd he get out here, anyway?");
            advice.Add("Roland Perry", "NMaybe if we stay really still he can't see us.");
            advice.Add("Jack Reed", "NThe wife will never believe this one.");
            advice.Add("Duncan MacKinnon", "NNo.");
            advice.Add("Gunther Reinhar", "NI'm hungry.");


            Event toRet = new Event(eventId, type, possibleLocations, reqParty, introText, GetResponseOptionSet(), advice, false);

            return toRet;
	    }



        private static List<ResponseOption> GetResponseOptionSet()
        {
            List<ResponseOption> responseOptions = new List<ResponseOption>();

		    List<int> resourceStatCost = new List<int>() { 10, 10 , 10, 10, 10, 10, 10, 10 };		    
		    List<int> partyStatCost = new List<int>() { 10, 10 , 10, 10, 10, 10, 10, 10 };		
            List<int> resourceStatReq = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2 };
		    List<int> partyStatReq = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2 };
            List<int> resourceModifiers = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2 };
            List<int> partyStatModifiers = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2 };		
		    string passText = "You passed the test!";
            string winText = "You won the challenge!";
            string loseText = "You lost the challenge! You died.";
            string winFollowUp = null;
            string passFollowUp = null;
            string loseFollowUp = null;
		    List<int> winResourceChange = new List<int>(){ 10, 10 , 10, 10, 10, 10, 10, 10 };
		    List<int> winPartyStatChange = new List<int>(){ 10, 10 , 10, 10, 10, 10, 10, 10 };
		    List<int> loseResourceChange = new List<int>(){ -10, -10 , -10, -10, -10, -10, -10, -10 };
		    List<int> losePartyStatChange = new List<int>(){ -10, -10 , -10, -10, -10, -10, -10, -10 };

            ResponseOption responseOption1 = new ResponseOption("Engage in Socratic Dialogue", resourceStatCost, partyStatCost, resourceStatReq, partyStatReq, resourceModifiers, partyStatModifiers,
                winText, passText, loseText, winFollowUp, passFollowUp, loseFollowUp, winResourceChange, winPartyStatChange, loseResourceChange, losePartyStatChange, false, false, false, 2, 2);	    
            ResponseOption responseOption2 = new ResponseOption("Take him to court!", resourceStatCost, partyStatCost, resourceStatReq, partyStatReq, resourceModifiers, partyStatModifiers,
                winText, passText, loseText, winFollowUp, passFollowUp, loseFollowUp, winResourceChange, winPartyStatChange, loseResourceChange, losePartyStatChange, false, false, false, 2, 2);
            ResponseOption responseOption3 = new ResponseOption("Ask about the oracle.", resourceStatCost, partyStatCost, resourceStatReq, partyStatReq, resourceModifiers, partyStatModifiers,
               winText, passText, loseText, winFollowUp, passFollowUp, loseFollowUp, winResourceChange, winPartyStatChange, loseResourceChange, losePartyStatChange, false, false, false, 2, 2);
            ResponseOption responseOption4 = new ResponseOption("Set up a system of organized trade.", resourceStatCost, partyStatCost, resourceStatReq, partyStatReq, resourceModifiers, partyStatModifiers,
                           winText, passText, loseText, winFollowUp, passFollowUp, loseFollowUp, winResourceChange, winPartyStatChange, loseResourceChange, losePartyStatChange, false, false, false, 2, 2);
            ResponseOption responseOption5 = new ResponseOption("Run Away!", resourceStatCost, partyStatCost, resourceStatReq, partyStatReq, resourceModifiers, partyStatModifiers,
                           winText, passText, loseText, winFollowUp, passFollowUp, loseFollowUp, winResourceChange, winPartyStatChange, loseResourceChange, losePartyStatChange, false, false, false, 2, 2);

            responseOptions.Add(responseOption1);
		    responseOptions.Add(responseOption2);
            responseOptions.Add(responseOption3);
            responseOptions.Add(responseOption4);
            responseOptions.Add(responseOption5);
		
            return responseOptions;
        }

    }
}
