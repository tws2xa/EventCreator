﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventCreator
{
    public partial class frmMain : Form
    {
        //General Info Variables
        int frmWidth;
        int frmHeight;
        const int minWidth = 880;
        const int minHeight = 600;
        const string useOr = "USE_OR";
        const string useNot = "USE_NOT";

        //Advice Variables
        public const string LETTER_USEFUL = "U";
        public const string LETTER_NOT_USEFUL = "N";

        //Response Option Definition Variables
        int numOfClicks = 0;
        List<TextBox> textBoxes = new List<TextBox>();
        List<Label> numLabels = new List<Label>();
        
        //Edit Response Variables
        int currentRspSelect = 0;
        bool editRespNeedSave = false;
        public Dictionary<int, ResponseOption> responseOptions = new Dictionary<int, ResponseOption>();
        public const int EFFECT_ON_EVERYONE = 0;
        public const int EFFECT_ON_SELECTED = 1;
        public const int EFFECT_ON_RANDOM = 2;
        public const int notAppliedModifier = -1000;
        List<Panel> respEditPanels;

        //Finish Variables

        //Other Variables


        /* ------------------------------------------------ */
        // General Info Stuff                               //
        /* ------------------------------------------------ */

        internal string getEventId()
        {
            return eventNameInput.Text;
        }

        internal string getEventType()
        {
            return (string)eventTypeInput.Items[eventTypeInput.SelectedIndex];
        }

        internal string getFrequency()
        {          
            string toAdd = "";
            if(chkOnlyOnce.Checked) toAdd = "1";
            return (toAdd + (string)frequencyInput.Items[frequencyInput.SelectedIndex]);
        }

        internal List<string> getPossibleLocations()
        {
            List<String> possibleLocations = new List<String>();
            foreach (int index in locationsInput.CheckedIndices)
            {
                possibleLocations.Add((String)(locationsInput.Items[index]));
            }
            return possibleLocations;
        }

        internal List<string> getRequiredParty()
        {        
            List<String> reqPartyMem = new List<String>();
            //AND
            foreach (int index in andClassInput.CheckedIndices)
            {
                reqPartyMem.Add((String)(andClassInput.Items[index]));
            }
            //OR
            reqPartyMem.Add(useOr);
            foreach (int index in orClassInput.CheckedIndices)
            {
                reqPartyMem.Add((String)(orClassInput.Items[index]));
            }
            //NOT
            reqPartyMem.Add(useNot);
            foreach (int index in notClassInput.CheckedIndices)
            {
                reqPartyMem.Add((String)(notClassInput.Items[index]));
            }
            return reqPartyMem;
        }

        internal string getIntroText()
        {
            return introDescInput.Text;
        }

        internal bool getSelectPlayer()
        {
            return selectplayerB.Checked;
        }

        /// <summary>
        /// Loads in an event. Calls all tabs' load methods.
        /// </summary>
        private void btnLoadEvent_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog_LoadEvent.ShowDialog();
            if (result == DialogResult.Cancel) return;

            Event toLoad = EventLoader.GetEventFromFile(openFileDialog_LoadEvent.FileName);

            string loadStatus = "";

            string tmp = GeneralInfoLoadEvent(toLoad);
            if (!String.IsNullOrWhiteSpace(tmp)) loadStatus += "\n" + tmp;
            tmp = AdviceLoadEvent(toLoad);
            if (!String.IsNullOrWhiteSpace(tmp)) loadStatus += "\n" + tmp;
            tmp = ResponseOptionsLoadEvent(toLoad);
            if (!String.IsNullOrWhiteSpace(tmp)) loadStatus += "\n" + tmp;
            tmp = EditResponseOptionsLoadEvent(toLoad);
            if (!String.IsNullOrWhiteSpace(tmp)) loadStatus += "\n" + tmp;
            tmp = FinishLoadEvent(toLoad);
            if (!String.IsNullOrWhiteSpace(tmp)) loadStatus += "\n" + tmp;

            if (!String.IsNullOrWhiteSpace(loadStatus))
            {
                MessageBox.Show("Uh-oh! Unable to properly load the following tabs:\n" + loadStatus + "\n\nSorry!");
            }
        }

        /// <summary>
        /// Sets the general info tab information to load in all needed info from the event.
        /// </summary>
        /// <param name="theEvent">Event to load in</param>
        private string GeneralInfoLoadEvent(Event theEvent)
        {
            try
            {
                eventNameInput.Text = (string)theEvent.myDictionary[Keys.EVENT_ID_KEY];
                SelectStrInComboBox(eventTypeInput, (string)theEvent.myDictionary[Keys.EVENT_TYPE_KEY]);
                string freq = (string)theEvent.myDictionary[Keys.EVENT_FREQUENCY_KEY];
                if(freq[0] == '1') {
                    freq = freq.Substring(1);
                    chkOnlyOnce.Checked = true;
                } else {
                    chkOnlyOnce.Checked = false;
                }
                SelectStrInComboBox(frequencyInput, freq);
                List<string> locations = GetListFromJSON<List<string>>(theEvent.myDictionary[Keys.POSSIBLE_LOCATIONS_KEY]);
                for (int i = 0; i < locationsInput.Items.Count; i++)
                {
                    locationsInput.SetItemChecked(i, locations.Contains(locationsInput.Items[i]));
                }

                //Clear the and/or/not boxes for required party members
                CheckedListBox toClear = andClassInput;
                for (int j = 0; j < 3; j++)
                {
                    foreach (int index in toClear.CheckedIndices)
                    {
                        toClear.SetItemChecked(index, false);
                    }
                    if (toClear == andClassInput) toClear = orClassInput;
                    else if (toClear == orClassInput) toClear = notClassInput;
                    else break;
                }
                //Re-fill the and/or/not boxes of required party members
                List<string> partyNeeded = GetListFromJSON<List<string>>(theEvent.myDictionary[Keys.REQ_PARTY_KEY]);
                CheckedListBox curBox = andClassInput;
                for (int i = 0; i < partyNeeded.Count; i++)
                {
                    if (partyNeeded[i] == useOr)
                    {
                        curBox = orClassInput;
                        continue;
                    }
                    if (partyNeeded[i] == useNot)
                    {
                        curBox = notClassInput;
                        continue;
                    }
                    if (curBox.Items.Contains(partyNeeded[i]))
                    {
                        Console.WriteLine("ADDING " + partyNeeded[i] + " TO " + curBox.Name); 
                        curBox.SetItemChecked(curBox.Items.IndexOf(partyNeeded[i]), true);
                    }
                }


                introDescInput.Text = (string)theEvent.myDictionary[Keys.INTRO_TEXT_KEY];
                selectplayerB.Checked = (bool)theEvent.myDictionary[Keys.PARTY_MEMBER_TARGETED_KEY];
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading General Info Tab:\n" + e.Message);
                return "General Information";
            }
            return "";
        }


        /* ------------------------------------------------ */
        // Advice Stuff                                     //
        /* ------------------------------------------------ */

        /// <summary>
        /// Creates the dictionary containing advice from every character.
        /// </summary>
        /// <returns>Dictionary[string, string] of the form (character name, advice).</returns>
        public Dictionary<string, string> generateAdviceDictionary()
        {

            string preTxt = LETTER_NOT_USEFUL;
            if (chkHunter.Checked == true)
            {
                preTxt = LETTER_USEFUL;
            }
            string adviceHunter = preTxt + txtHunter.Text;

            preTxt = LETTER_NOT_USEFUL;
            if (chkMercenary.Checked == true)
            {
                preTxt = LETTER_USEFUL;
            }
            string adviceMercenary = preTxt + txtMercenary.Text;

            preTxt = LETTER_NOT_USEFUL;
            if (chkNaturalist.Checked == true)
            {
                preTxt = LETTER_USEFUL;
            }
            string adviceNaturalist = preTxt + txtNaturalist.Text;

            preTxt = LETTER_NOT_USEFUL;
            if (chkMissionary.Checked == true)
            {
                preTxt = LETTER_USEFUL;
            }
            string adviceMissionary = preTxt + txtMissionary.Text;

            preTxt = LETTER_NOT_USEFUL;
            if (chkExplorer.Checked == true)
            {
                preTxt = LETTER_USEFUL;
            }
            string adviceExplorer = preTxt + txtExplorer.Text;

            preTxt = LETTER_NOT_USEFUL;
            if (chkGuide.Checked == true)
            {
                preTxt = LETTER_USEFUL;
            }
            string adviceGuide = preTxt + txtGuide.Text;


            Dictionary<String, String> dictionaryAdvice = new Dictionary<String, String>();
            dictionaryAdvice.Add(lblHunter.Text, adviceHunter);
            dictionaryAdvice.Add(lblMercenary.Text, adviceMercenary);
            dictionaryAdvice.Add(lblNaturalist.Text, adviceNaturalist);
            dictionaryAdvice.Add(lblMissionary.Text, adviceMissionary);
            dictionaryAdvice.Add(lblExplorer.Text, adviceExplorer);
            dictionaryAdvice.Add(lblGuide.Text, adviceGuide);            

            return dictionaryAdvice;
        }


        /// <summary>
        /// Sets the advice tab information to load in all needed info from the event.
        /// </summary>
        /// <param name="theEvent">Event to load in</param>
        private string AdviceLoadEvent(Event theEvent)
        {
            try
            {
                //First we check for advice listed by class
                //If it doesn't exist, it may be an old event from previous event creator iterations, which saved advice by person.
                //So if no advice by class, it checks both people who were of that class in old versions.
                //If still nothing, leave advice blank.
                Dictionary<string, string> advice = GetObjFromJSON<Dictionary<string, string>>(theEvent.myDictionary[Keys.ADVICE_KEY]);
                //Hunter
                if (advice.ContainsKey(lblHunter.Text)) SetAdviceRow(txtHunter, chkHunter, advice[lblHunter.Text]);
                else if (advice.ContainsKey("Macumazahn")) SetAdviceRow(txtHunter, chkHunter, advice["Macumazahn"]);
                else if (advice.ContainsKey("Jan Kruger")) SetAdviceRow(txtHunter, chkHunter, advice["Jan Kruger"]);
                //Mercenary
                if (advice.ContainsKey(lblMercenary.Text)) SetAdviceRow(txtMercenary, chkMercenary, advice[lblMercenary.Text]);
                else if (advice.ContainsKey("Umbopa")) SetAdviceRow(txtHunter, chkHunter, advice["Umbopa"]);
                else if (advice.ContainsKey("Gunther Reinhart")) SetAdviceRow(txtHunter, chkHunter, advice["Gunther Reinhart"]);
                //Naturalist
                if (advice.ContainsKey(lblNaturalist.Text)) SetAdviceRow(txtNaturalist, chkNaturalist, advice[lblNaturalist.Text]);
                else if (advice.ContainsKey("Wonai")) SetAdviceRow(txtHunter, chkHunter, advice["Wonai"]);
                else if (advice.ContainsKey("Roland Perry")) SetAdviceRow(txtHunter, chkHunter, advice["Roland Perry"]);
                //Missionary
                if (advice.ContainsKey(lblMissionary.Text)) SetAdviceRow(txtMissionary, chkMissionary, advice[lblMissionary.Text]);
                else if (advice.ContainsKey("Theunis Van Zyl")) SetAdviceRow(txtHunter, chkHunter, advice["Theunis Van Zyl"]);
                else if (advice.ContainsKey("Duncan MacKinnon")) SetAdviceRow(txtHunter, chkHunter, advice["Duncan MacKinnon"]);
                //Explorer
                if (advice.ContainsKey(lblExplorer.Text)) SetAdviceRow(txtExplorer, chkExplorer, advice[lblExplorer.Text]);
                else if (advice.ContainsKey("Willem de Bruin")) SetAdviceRow(txtHunter, chkHunter, advice["Willem de Bruin"]);
                else if (advice.ContainsKey("Jack Reed")) SetAdviceRow(txtHunter, chkHunter, advice["Jack Reed"]);
                //Guide
                if (advice.ContainsKey(lblGuide.Text)) SetAdviceRow(txtGuide, chkGuide, advice[lblGuide.Text]);
                else if (advice.ContainsKey("Tariro")) SetAdviceRow(txtHunter, chkHunter, advice["Tariro"]);
                else if (advice.ContainsKey("Jakobus Kotze")) SetAdviceRow(txtHunter, chkHunter, advice["Jakobus Kotze"]);
            }
            catch (Exception e)
            {
                return "Advice";
            }
            return "";
        }

        private void SetAdviceRow(TextBox txtBox, CheckBox chkBox, string fullAdviceStr) {
            string firstChar = fullAdviceStr.Substring(0, 1);
            string advice = fullAdviceStr.Substring(1);
            chkBox.Checked = (firstChar == LETTER_USEFUL);
            txtBox.Text = advice;
        }

        /* ------------------------------------------------ */
        // Response Options Intro Stuff                     //
        /* ------------------------------------------------ */

        /// <summary>
        /// Called when the add response button is clicked.
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (numOfClicks < 4)
            {
                numOfClicks++;
                removeNumBox.Maximum = numOfClicks + 1;
                responseOptions[numOfClicks] = new ResponseOption("");
                handlePlus();
            }
        }

        /// <summary>
        /// Sets the appropriate response option box to visible.
        /// </summary>
        private void handlePlus()
        {
            if (numOfClicks == 1)
            {
                // text responses
                textResponse2.Visible = true;
                textResponse2.Enabled = true;
                // label responses
                labelResponse2.Visible = true;
            }
            if (numOfClicks == 2)
            {
                // text responses
                textResponse2.Visible = true;
                textResponse2.Enabled = true;
                textResponse3.Visible = true;
                textResponse3.Enabled = true;
                // label responses
                labelResponse2.Visible = true;
                labelResponse3.Visible = true;
            }
            if (numOfClicks == 3)
            {
                // text responses
                textResponse2.Visible = true;
                textResponse2.Enabled = true;
                textResponse3.Visible = true;
                textResponse3.Enabled = true;
                textResponse4.Visible = true;
                textResponse4.Enabled = true;
                // label responses
                labelResponse2.Visible = true;
                labelResponse3.Visible = true;
                labelResponse4.Visible = true;
            }
            if (numOfClicks == 4)
            {
                // text responses
                textResponse2.Visible = true;
                textResponse2.Enabled = true;
                textResponse3.Visible = true;
                textResponse3.Enabled = true;
                textResponse4.Visible = true;
                textResponse4.Enabled = true;
                textResponse5.Visible = true;
                textResponse5.Enabled = true;
                // label responses
                labelResponse2.Visible = true;
                labelResponse3.Visible = true;
                labelResponse4.Visible = true;
                labelResponse5.Visible = true;
            }

        }

        /// <summary>
        /// Called when the remove response option button is clicked.
        /// </summary>
        private void removeResponseButton_Click(object sender, EventArgs e)
        {
            handleRemove();
        }

        /// <summary>
        /// Removes the appropriate response option.
        /// </summary>
        private void handleRemove()
        {

            int toRemove = (int)removeNumBox.Value;
            if (numOfClicks > 0)
            {
                if ((numOfClicks + 1) >= toRemove)
                {
                    for (int i = (toRemove); i <= numOfClicks; i++)
                    {
                        responseOptions[i - 1] = responseOptions[i];
                        textBoxes[i - 1].Text = textBoxes[i].Text;
                    }

                    textBoxes[numOfClicks].Visible = false;
                    textBoxes[numOfClicks].Enabled = false;
                    numLabels[numOfClicks].Visible = false;
                    responseOptions.Remove(numOfClicks);
                    numOfClicks--;
                    removeNumBox.Maximum = numOfClicks + 1;
                }
            }
            else
            {
                MessageBox.Show("You must have at least one response option!");
            }
        }

        private void textResponse1_TextChanged(object sender, EventArgs e)
        {
            responseOptions[0].myMap[Keys.TEXT_KEY] = textResponse1.Text;
        }

        private void textResponse2_TextChanged(object sender, EventArgs e)
        {
            responseOptions[1].myMap[Keys.TEXT_KEY] = textResponse2.Text;
        }

        private void textResponse3_TextChanged(object sender, EventArgs e)
        {
            responseOptions[2].myMap[Keys.TEXT_KEY] = textResponse3.Text;
        }

        private void textResponse4_TextChanged(object sender, EventArgs e)
        {
            responseOptions[3].myMap[Keys.TEXT_KEY] = textResponse4.Text;
        }

        private void textResponse5_TextChanged(object sender, EventArgs e)
        {
            responseOptions[4].myMap[Keys.TEXT_KEY] = textResponse5.Text;
        }
        
        /// <summary>
        /// Sets the Response Options tab information to load in all needed info from the event.
        /// </summary>
        /// <param name="theEvent">Event to load in</param>
        private string ResponseOptionsLoadEvent(Event theEvent)
        {
            List<Dictionary<string, object>> respOps;
            try
            {
                respOps = GetListFromJSON<List<Dictionary<string, object>>>(theEvent.myDictionary[Keys.RESPONSE_OPTIONS_KEY]);
            }
            catch (Exception e)
            {
                return "All of them. Corrupt JSON information.";
            }

            numOfClicks = respOps.Count() - 1;
            if (numOfClicks > 4) return "Response Options (Too Many Response Options)";
            if (numOfClicks < 0) return "Response Options (Too Few Response Options)";

            int currentLoc = 0;
            responseOptions.Clear();
            foreach (Dictionary<string, object> option in respOps)
            {
                responseOptions.Add(currentLoc, CreateRespOpFromJSONDictionary(option));
                textBoxes[currentLoc].Text = (string)option[Keys.TEXT_KEY];
                currentLoc++;
            }

            handlePlus(); //Sets all the appropriate boxes to visible.

            LoadResponse((string)responseOptions[0].myMap[Keys.TEXT_KEY]); //Load in first response option.

            return "";
            
        }

        private ResponseOption CreateRespOpFromJSONDictionary(Dictionary<string, object> option)
        {
            string text = (string)option[Keys.TEXT_KEY];
            List<int> resCosts = GetListFromJSON<List<int>>(option[Keys.RESOURCE_STAT_COST_KEY]);
            List<int> partCosts = GetListFromJSON<List<int>>(option[Keys.PARTY_STAT_COST_KEY]);
            List<int> partReqs = GetListFromJSON<List<int>>(option[Keys.PARTY_STAT_REQUIREMENT_KEY]);
            List<int> resReqs = GetListFromJSON<List<int>>(option[Keys.RESOURCE_STAT_REQUIREMENT_KEY]);
            List<int> resMods = GetListFromJSON<List<int>>(option[Keys.RESOURCE_MODIFIERS_KEY]);
            List<int> partMods = GetListFromJSON<List<int>>(option[Keys.PARTY_STAT_MODIFIERS_KEY]);
            string passText = (string)option[Keys.PASS_TEXT_KEY];
            string winText = (string)option[Keys.WIN_TEXT_KEY];
            string winFollowup = (string)option[Keys.WIN_FOLLOW_UP_KEY];
            string passFollowup = (string)option[Keys.PASS_FOLLOW_UP_KEY];
            List<int> winResChange = GetListFromJSON<List<int>>(option[Keys.WIN_RESOURCE_CHANGE_KEY]);
            List<int> winPartyChange = GetListFromJSON<List<int>>(option[Keys.WIN_PARTY_STAT_CHANGE_KEY]);
            string loseText = (string)option[Keys.LOSE_TEXT_KEY];
            string loseFollowup = (string)option[Keys.LOSE_FOLLOW_UP_KEY];
            List<int> loseResChange = GetListFromJSON<List<int>>(option[Keys.LOSE_RESOURCE_CHANGE_KEY]);
            List<int> losePartyChange = GetListFromJSON<List<int>>(option[Keys.LOSE_PARTY_STAT_CHANGE_KEY]);
            bool killOnLose = (bool)option[Keys.KILL_PERSON_LOSE_KEY];
            bool killOnPass = (bool)option[Keys.KILL_PERSON_PASS_KEY];
            bool killOnWin = (bool)option[Keys.KILL_PERSON_WIN_KEY];

            long dispLose = (long)option[Keys.REWARD_DISPERSE_LOSE_KEY];
            long dispWin = (long)option[Keys.REWARD_DISPERSE_WIN_KEY];

            int rewardDispLose = Convert.ToInt32(dispLose);
            int rewardDispWin = Convert.ToInt32(dispWin);


            return new ResponseOption(text, resCosts, partCosts, resReqs, partReqs, resMods, partMods, winText, passText, loseText,
                winFollowup, passFollowup, loseFollowup, winResChange, winPartyChange, loseResChange, losePartyChange, killOnLose, killOnPass, killOnWin,
                rewardDispWin, rewardDispLose);
        }
        /* ------------------------------------------------ */
        // Edit Response Stuff                              //
        /* ------------------------------------------------ */

        /// <summary>
        /// Allows the user to select a file for a win follow up event.
        /// </summary>
        private void browse1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                winFollowUp.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Allows the user to select a file for a pass follow up event.
        /// </summary>
        private void browse2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                passFollowUp.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Allows the user to select a file for a lose follow up event.
        /// </summary>
        private void browse3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loseFollowUp.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Checks if the user is sure they want to switch to a new event before saving.
        /// If so, changes the form.
        /// </summary>
        private void comboBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editRespNeedSave)
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to change response?\nAll unsaved changes to this event will be lost.", "Abort Changes?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    comboBoxRespToEdit.SelectedIndex = currentRspSelect;
                    return;
                }
            }
            string respToLoad = comboBoxRespToEdit.Items[comboBoxRespToEdit.SelectedIndex].ToString();
            string load = LoadResponse(respToLoad);
            if (load != "")
            {
                MessageBox.Show("An Error Occured Loading the Event!\n" + load);
                comboBoxRespToEdit.SelectedIndex = currentRspSelect;
                return;
            }

            currentRspSelect = comboBoxRespToEdit.SelectedIndex;
            editRespNeedSave = true;
        }

        /// <summary>
        /// Saves the current Edit Response Info.
        /// </summary>
        private void btnRespOptSave_Click(object sender, EventArgs e)
        {
            if (comboBoxRespToEdit.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an event to edit.");
                return;
            }

            string respToSave = comboBoxRespToEdit.Items[comboBoxRespToEdit.SelectedIndex].ToString();
            string save = SaveResponse(respToSave);



            if (save == "")
            {
                editRespNeedSave = false;
            }
            else
            {
                MessageBox.Show("Save Failed!\n" + save);
            }
        }

        /// <summary>
        /// Ensures that the form always has the most updated list of response options.
        /// </summary>
        private void tabEditRespOpts_Enter(object sender, EventArgs e)
        {
            comboBoxRespToEdit.Items.Clear();
            foreach (ResponseOption resp in responseOptions.Values)
            {
                comboBoxRespToEdit.Items.Add(resp.myMap[Keys.TEXT_KEY]);
            }
            if (comboBoxRespToEdit.Items.Count > 0)
            {
                if (comboBoxRespToEdit.Items.Count <= currentRspSelect) currentRspSelect = 0;
                comboBoxRespToEdit.SelectedIndex = currentRspSelect;
            }
        }

        /// <summary>
        /// Provides the Dictionary containing all response options.
        /// </summary>
        public List<ResponseOption> getResponseOptions()
        {
            return responseOptions.Values.ToList<ResponseOption>();
        }

        /// <summary>
        /// Checks if the player has decided to apply effects to the selected player, but hasn't selected the "select player" option.
        /// If so, they are provided the option to enable it.
        /// </summary>
        private void EffectApplicationDropdownChanged(object sender, EventArgs e)
        {
            ComboBox changedBox = (ComboBox)sender;
            if (changedBox.SelectedIndex == EFFECT_ON_SELECTED && !selectplayerB.Checked)
            {
                DialogResult result = MessageBox.Show("You have not set the event to select a player.\nWould you like to enable the \"Select Player Beforehand\" option?", "Select Player?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    changedBox.SelectedIndex = EFFECT_ON_EVERYONE;
                    return;
                }
                else
                {
                    selectplayerB.Checked = true;
                }
            }
        }

        /// <summary>
        /// Looks up the response containing the given text.
        /// </summary>
        /// <param name="text">Desired response's text.</param>
        /// <returns>ResponseOption if found, otherwise null.</returns>
        public ResponseOption GetResponseOptionWithText(string text)
        {
            foreach (ResponseOption resp in responseOptions.Values)
            {
                if ((string)(resp.myMap[Keys.TEXT_KEY]) == text)
                {
                    return resp;
                }
            }
            return null;
        }


        public List<int> getGlobalStats()
        {
            List<int> globalStats = new List<int>();
            if (foodModB.Checked) { globalStats.Add((int)foodMod.Value); }
            else { globalStats.Add(notAppliedModifier); }
            if (waterModB.Checked) { globalStats.Add((int)waterMod.Value); }
            else { globalStats.Add(notAppliedModifier); }
            if (vModB.Checked) { globalStats.Add((int)valueMod.Value); }
            else { globalStats.Add(notAppliedModifier); }
            if (ammoModB.Checked) { globalStats.Add((int)ammoMod.Value); }
            else { globalStats.Add(notAppliedModifier); }
            if (medModB.Checked) { globalStats.Add((int)medMod.Value); }
            else { globalStats.Add(notAppliedModifier); }
            if (moraleModB.Checked) { globalStats.Add((int)moraleMod.Value); }
            else { globalStats.Add(notAppliedModifier); }
            if (staminaModB.Checked) { globalStats.Add((int)staminaMod.Value); }
            else { globalStats.Add(notAppliedModifier); }
            if (valueModB.Checked) { globalStats.Add((int)packMod.Value); }
            else { globalStats.Add(notAppliedModifier); }
            return globalStats;
        }

        public List<int> getMemberStats()
        {
            List<int> memberStats = new List<int>();
            if (marksModB.Checked) { memberStats.Add((int)markMod.Value); }
            else { memberStats.Add(notAppliedModifier); }
            if (percModB.Checked) { memberStats.Add((int)percMod.Value); }
            else { memberStats.Add(notAppliedModifier); }
            if (tacticsModB.Checked) { memberStats.Add((int)tacticsMod.Value); }
            else { memberStats.Add(notAppliedModifier); }
            if (loyalModB.Checked) { memberStats.Add((int)loyalMod.Value); }
            else { memberStats.Add(notAppliedModifier); }
            if (agilityModB.Checked) { memberStats.Add((int)agilityMod.Value); }
            else { memberStats.Add(notAppliedModifier); }
            if (strengthModB.Checked) { memberStats.Add((int)strengthMod.Value); }
            else { memberStats.Add(notAppliedModifier); }
            if (diploModB.Checked) { memberStats.Add((int)diploMod.Value); }
            else { memberStats.Add(notAppliedModifier); }
            if (knowModB.Checked) { memberStats.Add((int)knowMod.Value); }
            else { memberStats.Add(notAppliedModifier); }
            return memberStats;
        }

        /// <summary>
        /// Saves all response option information in the edit response form into the given response.
        /// </summary>
        /// <param name="respText">The key to the given repsonse.</param>
        /// <returns>Empty string if success. Error Message if fail.</returns>
        private string SaveResponse(string respText)
        {
            ResponseOption responseToEdit = GetResponseOptionWithText(respText);
            if(responseToEdit == null) {
                Console.WriteLine("Error: Could not find response option \"" + respText + "\" in saveEvent!");
                return "We couldn't find the response option \"" + respText + "\" - Sorry!";
            }
            
            responseToEdit.myMap[Keys.RESOURCE_MODIFIERS_KEY] = getGlobalStats();


            responseToEdit.myMap[Keys.PARTY_STAT_MODIFIERS_KEY] = getMemberStats();

            // Global Variable Requirements (Resource Stat Requirement)
            List<int> resourceStatReq = new List<int>();
            resourceStatReq.Add((int)foodReq.Value);
            resourceStatReq.Add((int)waterReq.Value);
            resourceStatReq.Add((int)valueReq.Value);
            resourceStatReq.Add((int)ammoReq.Value);
            resourceStatReq.Add((int)medReq.Value);
            resourceStatReq.Add((int)moraleReq.Value);
            resourceStatReq.Add((int)staminaReq.Value);
            resourceStatReq.Add((int)packReq.Value);

            responseToEdit.myMap[Keys.RESOURCE_STAT_REQUIREMENT_KEY] = resourceStatReq;

            // Party Member Requirements (Party Stat Requirement)
            List<int> partyMemReq = new List<int>();
            partyMemReq.Add((int)marksReq.Value);
            partyMemReq.Add((int)percReq.Value);
            partyMemReq.Add((int)tacticsReq.Value);
            partyMemReq.Add((int)loyalReq.Value);
            partyMemReq.Add((int)agilityReq.Value);
            partyMemReq.Add((int)strengthReq.Value);
            partyMemReq.Add((int)diploReq.Value);
            partyMemReq.Add((int)knowReq.Value);

            responseToEdit.myMap[Keys.PARTY_STAT_REQUIREMENT_KEY] = partyMemReq;

            // Lose Global Stats (Lose Resource Change)
            List<int> loseGlobal = new List<int>();
            loseGlobal.Add((int)foodLose.Value);
            loseGlobal.Add((int)waterLose.Value);
            loseGlobal.Add((int)valueLose.Value);
            loseGlobal.Add((int)ammoLose.Value);
            loseGlobal.Add((int)medLose.Value);
            loseGlobal.Add((int)moraleLose.Value);
            loseGlobal.Add((int)staminaLose.Value);
            loseGlobal.Add((int)packLose.Value);

            responseToEdit.myMap[Keys.LOSE_RESOURCE_CHANGE_KEY] = loseGlobal;

            // Lose Member Stats (Lose Party Stat Change)
            List<int> loseMember = new List<int>();
            loseMember.Add((int)markLose.Value);
            loseMember.Add((int)percLose.Value);
            loseMember.Add((int)tacticsLose.Value);
            loseMember.Add((int)loyalLose.Value);
            loseMember.Add((int)agilityLose.Value);
            loseMember.Add((int)strengthLose.Value);
            loseMember.Add((int)diploLose.Value);
            loseMember.Add((int)knowLose.Value);

            responseToEdit.myMap[Keys.LOSE_PARTY_STAT_CHANGE_KEY] = loseMember;

            // Win Global Stats (Win Resource Change)
            List<int> winGlobal = new List<int>();
            winGlobal.Add((int)foodWin.Value);
            winGlobal.Add((int)waterWin.Value);
            winGlobal.Add((int)valueWin.Value);
            winGlobal.Add((int)ammoWin.Value);
            winGlobal.Add((int)medWin.Value);
            winGlobal.Add((int)moraleWin.Value);
            winGlobal.Add((int)staminaWin.Value);
            winGlobal.Add((int)packWin.Value);

            responseToEdit.myMap[Keys.WIN_RESOURCE_CHANGE_KEY] = winGlobal;

            // Win Member Stats (WIN_PARTY_STAT_CHANGE_KEY)
            List<int> winMember = new List<int>();
            winMember.Add((int)marksWin.Value);
            winMember.Add((int)percWin.Value);
            winMember.Add((int)tacticsWin.Value);
            winMember.Add((int)loyalWin.Value);
            winMember.Add((int)agilityWin.Value);
            winMember.Add((int)strengthWin.Value);
            winMember.Add((int)diploWin.Value);
            winMember.Add((int)knowWin.Value);

            responseToEdit.myMap[Keys.WIN_PARTY_STAT_CHANGE_KEY] = winMember;

            // Cost Resource Stats (RESOURCE_STAT_COST_KEY)
            List<int> costResource = new List<int>();
            costResource.Add((int)foodCost.Value);
            costResource.Add((int)waterCost.Value);
            costResource.Add((int)valueCost.Value);
            costResource.Add((int)ammoCost.Value);
            costResource.Add((int)medCost.Value);
            costResource.Add((int)moraleCost.Value);
            costResource.Add((int)staminaCost.Value);
            costResource.Add((int)packCost.Value);

            responseToEdit.myMap[Keys.RESOURCE_STAT_COST_KEY] = costResource;

            // Cost Member Stats (PARTY_STAT_COST_KEY)
            List<int> costMember = new List<int>();
            costMember.Add((int)marksCost.Value);
            costMember.Add((int)percCost.Value);
            costMember.Add((int)tacticsCost.Value);
            costMember.Add((int)loyalCost.Value);
            costMember.Add((int)agilityCost.Value);
            costMember.Add((int)strengthCost.Value);
            costMember.Add((int)diploCost.Value);
            costMember.Add((int)knowCost.Value);

            responseToEdit.myMap[Keys.PARTY_STAT_COST_KEY] = costMember;

            // Win Text (WIN_TEXT_KEY)
            responseToEdit.myMap[Keys.WIN_TEXT_KEY] = winText.Text;

            // Lose Text (LOSE_TEXT_KEY)
            responseToEdit.myMap[Keys.LOSE_TEXT_KEY] = loseText.Text;

            // Pass Text (PASS_TEXT_KEY)
            responseToEdit.myMap[Keys.PASS_TEXT_KEY] = passText.Text;

            // KILL_PERSON_LOSE_KEY
            responseToEdit.myMap[Keys.KILL_PERSON_LOSE_KEY] = chkKillLose.Checked;

            // KILL_PERSON_WIN_KEY
            responseToEdit.myMap[Keys.KILL_PERSON_WIN_KEY] = chkWinKill.Checked;

            // WIN_FOLLOW_UP_KEY
            responseToEdit.myMap[Keys.WIN_FOLLOW_UP_KEY] = winFollowUp.Text;

            // LOSE_FOLLOW_UP_KEY
            responseToEdit.myMap[Keys.LOSE_FOLLOW_UP_KEY] = loseFollowUp.Text;

            // PASS_FOLLOW_UP_KEY
            responseToEdit.myMap[Keys.PASS_FOLLOW_UP_KEY] = passFollowUp.Text;

            // REWARD_DISPERSE_LOSE_KEY
            responseToEdit.myMap[Keys.REWARD_DISPERSE_LOSE_KEY] = comboBoxLoseApplication.SelectedIndex;

            // REWARD_DISPERSE_WIN_KEY
            responseToEdit.myMap[Keys.REWARD_DISPERSE_WIN_KEY] = comboBoxWinApplication.SelectedIndex;

            return "";
        }

        /// <summary>
        /// Loads an response's info into the Edit Response form.
        /// </summary>
        /// <param name="toLoad">Response to load.</param>
        /// <returns>Empty string if all goes well. Otherwise, an error message.</returns>
        private string LoadResponse(string toLoad)
        {
            ResponseOption responseToLoad = GetResponseOptionWithText(toLoad);
            if (responseToLoad == null)
            {
                Console.WriteLine("Error: Could not find response option \"" + toLoad + "\" in loadEvent!");
                return "We couldn't find the response option \"" + toLoad + "\" - Sorry!";
            }
            
            // Global Stats (Resource Modifiers)
            List<int> globalStats = (List<int>)(responseToLoad.myMap[Keys.RESOURCE_MODIFIERS_KEY]);
            if (globalStats[0] == notAppliedModifier) { foodMod.Value = 0; } else { foodMod.Value = globalStats[0]; }
            foodModB.Checked = (globalStats[0] != notAppliedModifier);
            if (globalStats[1] == notAppliedModifier) { waterMod.Value = 0; } else { waterMod.Value = globalStats[1]; }
            waterModB.Checked = (globalStats[1] != notAppliedModifier);
            if (globalStats[2] == notAppliedModifier) { valueMod.Value = 0; } else { valueMod.Value = globalStats[2]; }
            vModB.Checked = (globalStats[2] != notAppliedModifier);
            if (globalStats[3] == notAppliedModifier) { ammoMod.Value = 0; } else { ammoMod.Value = globalStats[3]; }
            ammoModB.Checked = (globalStats[3] != notAppliedModifier);
            if (globalStats[4] == notAppliedModifier) { medMod.Value = 0; } else { medMod.Value = globalStats[4]; }
            medModB.Checked = (globalStats[4] != notAppliedModifier);
            if (globalStats[5] == notAppliedModifier) { moraleMod.Value = 0; } else { moraleMod.Value = globalStats[5]; }
            moraleModB.Checked = (globalStats[5] != notAppliedModifier);
            if (globalStats[6] == notAppliedModifier) { staminaMod.Value = 0; } else { staminaMod.Value = globalStats[6]; }
            staminaModB.Checked = (globalStats[6] != notAppliedModifier);
            if (globalStats[7] == notAppliedModifier) { packMod.Value = 0; } else { packMod.Value = globalStats[7]; }
            valueModB.Checked = (globalStats[7] != notAppliedModifier);


            // Member Stats (Party Stat Modifiers)
            List<int> memberStats = (List<int>)(responseToLoad.myMap[Keys.PARTY_STAT_MODIFIERS_KEY]);
            if (memberStats[0] == notAppliedModifier) { markMod.Value = 0; } else { markMod.Value = memberStats[0]; }
            marksModB.Checked = (memberStats[0] != notAppliedModifier);
            if (memberStats[1] == notAppliedModifier) { percMod.Value = 0; } else { percMod.Value = memberStats[1]; }
            percModB.Checked = (memberStats[1] != notAppliedModifier);
            if (memberStats[2] == notAppliedModifier) { tacticsMod.Value = 0; } else { tacticsMod.Value = memberStats[2]; }
            tacticsModB.Checked = (memberStats[2] != notAppliedModifier);
            if (memberStats[3] == notAppliedModifier) { loyalMod.Value = 0; } else { loyalMod.Value = memberStats[3]; }
            loyalModB.Checked = (memberStats[3] != notAppliedModifier);
            if (memberStats[4] == notAppliedModifier) { agilityMod.Value = 0; } else { agilityMod.Value = memberStats[4]; }
            agilityModB.Checked = (memberStats[4] != notAppliedModifier);
            if (memberStats[5] == notAppliedModifier) { strengthMod.Value = 0; } else { strengthMod.Value = memberStats[5]; }
            strengthModB.Checked = (memberStats[5] != notAppliedModifier);
            if (memberStats[6] == notAppliedModifier) { diploMod.Value = 0; } else { diploMod.Value = memberStats[6]; }
            diploModB.Checked = (memberStats[6] != notAppliedModifier);
            if (memberStats[7] == notAppliedModifier) { knowMod.Value = 0; } else { knowMod.Value = memberStats[7]; }
            knowModB.Checked = (memberStats[7] != notAppliedModifier);


            // Global Variable Requirements (Resource Stat Requirement)
            List<int> resourceStatReq = (List<int>)(responseToLoad.myMap[Keys.RESOURCE_STAT_REQUIREMENT_KEY]);
            foodReq.Value = resourceStatReq[0];
            waterReq.Value = resourceStatReq[1];
            valueReq.Value = resourceStatReq[2];
            ammoReq.Value = resourceStatReq[3];
            medReq.Value = resourceStatReq[4];
            moraleReq.Value = resourceStatReq[5];
            staminaReq.Value = resourceStatReq[6];
            packReq.Value = resourceStatReq[7];

            // Party Member Requirements (Party Stat Requirement)
            List<int> partyMemReq = (List<int>)responseToLoad.myMap[Keys.PARTY_STAT_REQUIREMENT_KEY];
            marksReq.Value = partyMemReq[0];
            percReq.Value = partyMemReq[1];
            tacticsReq.Value = partyMemReq[2];
            loyalReq.Value = partyMemReq[3];
            agilityReq.Value = partyMemReq[4];
            strengthReq.Value = partyMemReq[5];
            diploReq.Value = partyMemReq[6];
            knowReq.Value = partyMemReq[7];

            // Lose Global Stats (Lose Resource Change)
            List<int> loseGlobal = (List<int>)responseToLoad.myMap[Keys.LOSE_RESOURCE_CHANGE_KEY];
            foodLose.Value = loseGlobal[0];
            waterLose.Value = loseGlobal[1];
            valueLose.Value = loseGlobal[2];
            ammoLose.Value = loseGlobal[3];
            medLose.Value = loseGlobal[4];
            moraleLose.Value = loseGlobal[5];
            staminaLose.Value = loseGlobal[6];
            packLose.Value = loseGlobal[7];


            // Lose Member Stats (Lose Party Stat Change)
            List<int> loseMember = (List<int>)responseToLoad.myMap[Keys.LOSE_PARTY_STAT_CHANGE_KEY];
            markLose.Value = loseMember[0];
            percLose.Value = loseMember[1];
            tacticsLose.Value = loseMember[2];
            loyalLose.Value = loseMember[3];
            agilityLose.Value = loseMember[4];
            strengthLose.Value = loseMember[5];
            diploLose.Value = loseMember[6];
            knowLose.Value = loseMember[7];


            // Win Global Stats (Win Resource Change)
            List<int> winGlobal = (List<int>)responseToLoad.myMap[Keys.WIN_RESOURCE_CHANGE_KEY];
            foodWin.Value = winGlobal[0];
            waterWin.Value = winGlobal[1];
            valueWin.Value = winGlobal[2];
            ammoWin.Value = winGlobal[3];
            medWin.Value = winGlobal[4];
            moraleWin.Value = winGlobal[5];
            staminaWin.Value = winGlobal[6];
            packWin.Value = winGlobal[7];


            // Win Member Stats (WIN_PARTY_STAT_CHANGE_KEY)
            List<int> winMember = (List<int>)responseToLoad.myMap[Keys.WIN_PARTY_STAT_CHANGE_KEY];
            marksWin.Value = winMember[0];
            percWin.Value = winMember[1];
            tacticsWin.Value = winMember[2];
            loyalWin.Value = winMember[3];
            agilityWin.Value = winMember[4];
            strengthWin.Value = winMember[5];
            diploWin.Value = winMember[6];
            knowWin.Value = winMember[7];


            // Cost Resource Stats (RESOURCE_STAT_COST_KEY)
            List<int> costResource = (List<int>)responseToLoad.myMap[Keys.RESOURCE_STAT_COST_KEY];
            foodCost.Value = costResource[0];
            waterCost.Value = costResource[1];
            valueCost.Value = costResource[2];
            ammoCost.Value = costResource[3];
            medCost.Value = costResource[4];
            moraleCost.Value = costResource[5];
            staminaCost.Value = costResource[6];
            packCost.Value = costResource[7];


            // Cost Member Stats (PARTY_STAT_COST_KEY)
            List<int> costMember = (List<int>)responseToLoad.myMap[Keys.PARTY_STAT_COST_KEY];
            marksCost.Value = costMember[0];
            percCost.Value = costMember[1];
            tacticsCost.Value = costMember[2];
            loyalCost.Value = costMember[3];
            agilityCost.Value = costMember[4];
            strengthCost.Value = costMember[5];
            diploCost.Value = costMember[6];
            knowCost.Value = costMember[7];


            // Win Text (WIN_TEXT_KEY)
            winText.Text = (string)responseToLoad.myMap[Keys.WIN_TEXT_KEY];

            // Lose Text (LOSE_TEXT_KEY)
            loseText.Text = (string)responseToLoad.myMap[Keys.LOSE_TEXT_KEY];

            // Pass Text (PASS_TEXT_KEY)
            passText.Text = (string)responseToLoad.myMap[Keys.PASS_TEXT_KEY];

            // KILL_PERSON_LOSE_KEY
            chkKillLose.Checked = (bool)responseToLoad.myMap[Keys.KILL_PERSON_LOSE_KEY];

            // KILL_PERSON_WIN_KEY
            chkWinKill.Checked = (bool)responseToLoad.myMap[Keys.KILL_PERSON_WIN_KEY];

            // WIN_FOLLOW_UP_KEY
            winFollowUp.Text = (string)responseToLoad.myMap[Keys.WIN_FOLLOW_UP_KEY];

            // LOSE_FOLLOW_UP_KEY
            loseFollowUp.Text = (string)responseToLoad.myMap[Keys.LOSE_FOLLOW_UP_KEY];

            // PASS_FOLLOW_UP_KEY
            passFollowUp.Text = (string)responseToLoad.myMap[Keys.PASS_FOLLOW_UP_KEY];

            // REWARD_DISPERSE_LOSE_KEY
            comboBoxLoseApplication.SelectedIndex = (int)responseToLoad.myMap[Keys.REWARD_DISPERSE_LOSE_KEY];

            // REWARD_DISPERSE_WIN_KEY
            comboBoxWinApplication.SelectedIndex = (int)responseToLoad.myMap[Keys.REWARD_DISPERSE_WIN_KEY];


            return "";
        }


        private void tabEditRespOpts_Resize(object sender, EventArgs e)
        {

        }

        private void setEditRespLayout()
        {
            //int panelWidth = pnlMod.Width;
            //int panelHeight = pnlMod.Height;

            int tabWidth = tabMain.Width;

            int hSpacer = 52;
            int vSpacer = 8;
            int border = 8;

            int curX = border;
            int curY = 100;

            int pnlIndex = 0;

            bool finished = false;

            int maxHeightThisRow = 0;

            while (pnlIndex <= respEditPanels.Count - 1)
            {
                while (!finished && curX + respEditPanels[pnlIndex].Width < tabWidth)
                {
                    Panel curPnl = respEditPanels[pnlIndex];

                    curPnl.Location = new Point(curX, curY);
                    curX += respEditPanels[pnlIndex].Width + hSpacer;

                    if (respEditPanels[pnlIndex].Height > maxHeightThisRow) maxHeightThisRow = respEditPanels[pnlIndex].Height;

                    pnlIndex++;

                    if (pnlIndex > respEditPanels.Count - 1) finished = true;

                }
                curX = border;
                curY += maxHeightThisRow + vSpacer;
                maxHeightThisRow = 0;
            }

            //pnlOther.Location = new Point(curX, curY + vSpacer);
        }

        private void waterModB_CheckedChanged(object sender, EventArgs e)
        {
            updateRespProbabilities();
        }

        private void waterMod_ValueChanged(object sender, EventArgs e)
        {
            updateRespProbabilities();
        }

        public void updateRespProbabilities()
        {
            double rollNum = 50; //How many sides on the die.
            int[,] avgTops = new int[3, 8]{
                                {13, 13, 13, 13, 13, 13, 13, 13},
                                {11, 11, 11, 11, 11, 11, 11, 11},
                                {10, 10, 10, 10, 10, 10, 10, 10}
                              };
            List<int> partyStatModifiers = getMemberStats();
            int statNum = 0;

            int totalMod = 0;
            foreach(int modifier in partyStatModifiers) {
                if (modifier == notAppliedModifier) continue;
                
                int top0 = avgTops[0, statNum];
                int top1 = avgTops[1, statNum];
                int top2 = avgTops[2, statNum];

                double[] weights = getWeights(modifier, top0, top1, top2);

                double weightedAvg = ((weights[0] * top0 + weights[1] * top1 + weights[2] * top2) / (weights[0] + weights[1] + weights[2]));

                totalMod += ((int)Math.Floor(weightedAvg) - modifier);

                statNum++;
            }

            //If rollNum = 50 (i.e. 50 sided die)
            //probability that roll 0 to 50 + mod is >= 25 -> win
            //probability that roll 0 to 50 + mod is < 25 -> lose
            //Thus check if roll 0-50 < 25 - mod for lose or >= 25 - mod for win.

            Console.WriteLine("Total Mod: " + totalMod);
            double dividor = rollNum / 2.0 - totalMod;

            double winInterval = Math.Floor(((rollNum - dividor) / rollNum) * 100);
            double loseInterval = Math.Floor((dividor / rollNum) * 100);

            winInterval = Math.Min(100, Math.Max(winInterval, 0));
            loseInterval = Math.Min(100, Math.Max(loseInterval, 0));

            lblProbWin.Text = (winInterval + "%");
            lblProbLose.Text = (loseInterval + "%");
        }

        private double[] getWeights(int modifier, int top0, int top1, int top2)
        {
            int minWeight = 1;

            double dif1 = top0 - modifier;
            double dif2 = top1 - modifier;
            double dif3 = top2 - modifier;

            double addNum = Math.Max(0, minWeight - dif3);

            dif1 += addNum;
            dif2 += addNum;
            dif3 += addNum;

            return new double[3] { dif1, dif2, dif3 };
        }
        
        private void waterCost_ValueChanged(object sender, EventArgs e)
        {
            editRespNeedSave = true;
        }

        /// <summary>
        /// Sets the Edit Response Options tab information to load in all needed info from the event.
        /// </summary>
        /// <param name="theEvent">Event to load in</param>
        private string EditResponseOptionsLoadEvent(Event theEvent)
        {
            //TODO - Load in event info for this tab.
            return "";
        }
        
        /* ------------------------------------------------ */
        // Finish Stuff                                     //
        /* ------------------------------------------------ */

        /// <summary>
        /// Allows the user to browse for a file save location for the event.
        /// </summary>
        private void btnSaveBrowse_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                txtFileLoc.Text = saveFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Saves the event as a text file.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileLoc = txtFileLoc.Text;
            string valid = isValidFileName(fileLoc);

            if (valid != "")
            {
                lblStatus.Text = valid;
                lblStatus.ForeColor = Color.Red;
                return;
            }

            lblStatus.Text = "Saving... Please Wait.";
            lblStatus.ForeColor = Color.Black;

            String result = EventSaver.SaveEvent(this);

            if (result == "")
            {
                lblStatus.Text = "Save Complete!";
            }
            else
            {
                lblStatus.Text = "An Error Occured:\n" + result;
                lblStatus.ForeColor = Color.Red;
            }

        }

        /// <summary>
        /// Checks if a file name is a valid text file.
        /// </summary>
        /// <param name="fileLoc">File location to check.</param>
        /// <returns>Returns "" if it's valid. Otherwise an error message.</returns>
        public string isValidFileName(string fileLoc)
        {
            if (String.IsNullOrWhiteSpace(fileLoc))
            {
                return "Please enter a file name for your event.";
            }
            if (fileLoc.Length <= 4 || fileLoc.Substring(fileLoc.Length - 4) != ".txt")
            {
                return "Output must be a .txt file.";
            }
            return "";
        }

        /// <summary>
        /// Provides file name for the event's output file. Null if user input is invalid.
        /// </summary>
        public string GetOutputFileName()
        {
            string fileLoc = txtFileLoc.Text;
            if (isValidFileName(fileLoc) == "") return fileLoc;
            else return null;
        }
        
        /// <summary>
        /// Sets the Finish tab information to load in all needed info from the event.
        /// </summary>
        /// <param name="theEvent">Event to load in</param>
        private string FinishLoadEvent(Event theEvent)
        {
            //TODO - Load in event info for this tab.
            return "";
        }
        /* ------------------------------------------------ */
        // Other                                            //
        /* ------------------------------------------------ */
        /// <summary>
        /// Sets up the form.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the current selected response option stuff up in the Edit Response tab.
        /// Also default drop downs for who effects are applied to.
        /// Also adds the text boxes and labels to their lists for adding/removing response options.
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWidth = this.Width;
            frmHeight = this.Height;

            eventTypeInput.SelectedIndex = 0;
            frequencyInput.SelectedIndex = 2;

            currentRspSelect = 0;
            comboBoxRespToEdit.SelectedIndex = currentRspSelect;
            editRespNeedSave = true;

            comboBoxWinApplication.SelectedIndex = EFFECT_ON_RANDOM;
            comboBoxLoseApplication.SelectedIndex = EFFECT_ON_RANDOM;

            textBoxes.Add(textResponse1);
            textBoxes.Add(textResponse2);
            textBoxes.Add(textResponse3);
            textBoxes.Add(textResponse4);
            textBoxes.Add(textResponse5);

            numLabels.Add(labelResponse1);
            numLabels.Add(labelResponse2);
            numLabels.Add(labelResponse3);
            numLabels.Add(labelResponse4);
            numLabels.Add(labelResponse5);

            responseOptions.Add(0, new ResponseOption(textResponse1.Text));

            respEditPanels = new List<Panel>()
            {
                pnlMod, pnlReq, pnlCost, pnlWin, pnlLose, pnlResText, pnlOther
            };
        }

        public T GetListFromJSON<T>(object toList)
        {
            Newtonsoft.Json.Linq.JArray array = (Newtonsoft.Json.Linq.JArray)(toList);
            return array.ToObject<T>();
        }
        
        public static T GetObjFromJSON<T>(object toConvert)
        {
            Newtonsoft.Json.Linq.JObject obj = (Newtonsoft.Json.Linq.JObject)(toConvert);
            return obj.ToObject<T>();
        }

        /// <summary>
        /// Selects the item in the combo box (if there is one) that matches the given string.
        /// Selects -1 if no match.
        /// </summary>
        /// <param name="box">ComboBox to look through</param>
        /// <param name="toSelect">String to find</param>
        public void SelectStrInComboBox(ComboBox box, string toSelect)
        {
            for (int i = 0; i < box.Items.Count; i++)
            {
                if ((string)(box.Items[i]) == toSelect)
                {
                    box.SelectedIndex = i;
                    return;
                }
            }
            box.SelectedIndex = -1;
        }

        private void tabGeneralInfo_Click(object sender, EventArgs e)
        {

        }

        private void locationsInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.Width < minWidth) this.Width = minWidth;
            if (this.Height < minHeight) this.Height = minHeight;

            int wDiff = this.Width - frmWidth;
            int hDiff = this.Height - frmHeight;

            tabMain.Width += wDiff;
            tabMain.Height += hDiff;

            frmWidth = this.Width;
            frmHeight = this.Height;

            setEditRespLayout();
        }

        private void loyalCostC_Click(object sender, EventArgs e)
        {

        }
        
        /* ------------------------------------------------ */
        // ------------------------------------------------ //
        /* ------------------------------------------------ */

    }
}
