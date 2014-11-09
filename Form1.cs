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

        //Advice Variables

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
            foreach (int index in reqPaMemInput.CheckedIndices)
            {
                reqPartyMem.Add((String)(reqPaMemInput.Items[index]));
            }
            return reqPartyMem;
        }

        internal string getIntroText()
        {
            return introDescInput.Text;
        }

        internal static bool getSelectPlayer()
        {
            //TODO Return whether or not to select a player
            return false;
        }

        /// <summary>
        /// Loads in an event. Calls all tabs' load methods.
        /// </summary>
        private void btnLoadEvent_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog_LoadEvent.ShowDialog();
            if (result == DialogResult.Cancel) return;

            Event toLoad = EventLoader.GetEventFromFile(openFileDialog_LoadEvent.FileName);

            GeneralInfoLoadEvent(toLoad);
            AdviceLoadEvent(toLoad);
            ResponseOptionsLoadEvent(toLoad);
            EditResponseOptionsLoadEvent(toLoad);
            FinishLoadEvent(toLoad);

        }

        /// <summary>
        /// Sets the general info tab information to load in all needed info from the event.
        /// </summary>
        /// <param name="theEvent">Event to load in</param>
        private void GeneralInfoLoadEvent(Event theEvent)
        {
            //TODO - Load event information for this tab.
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

            string letterYes = "U";
            string letterNo = "N";

            string preTxt = letterNo;
            if (chkUmbopa.Checked == true)
            {
                preTxt = letterYes;
            }
            string adviceHunter = preTxt + txtUmbopa.Text;

            preTxt = letterNo;
            if (chkMacumazahn.Checked == true)
            {
                preTxt = letterYes;
            }
            string adviceMercenary = preTxt + txtMacumazahn.Text;

            preTxt = letterNo;
            if (chkWonai.Checked == true)
            {
                preTxt = letterYes;
            }
            string adviceNaturalist = preTxt + txtWonai.Text;

            preTxt = letterNo;
            if (chkTariro.Checked == true)
            {
                preTxt = letterYes;
            }
            string adviceMissionary = preTxt + txtTariro.Text;

            preTxt = letterNo;
            if (chkJanKruger.Checked == true)
            {
                preTxt = letterYes;
            }
            string adviceExplorer = preTxt + txtJanKruger.Text;

            preTxt = letterNo;
            if (chkTheunisVanZyl.Checked == true)
            {
                preTxt = letterYes;
            }
            string adviceGuide = preTxt + txtTheunisVanZyl.Text;

            Dictionary<String, String> dictionaryAdvice = new Dictionary<String, String>();
            dictionaryAdvice.Add(lblUmbopa.Text, adviceHunter);
            dictionaryAdvice.Add(lblMacumazahn.Text, adviceMercenary);
            dictionaryAdvice.Add(lblWonai.Text, adviceNaturalist);
            dictionaryAdvice.Add(lblTariro.Text, adviceMissionary);
            dictionaryAdvice.Add(lblJanKruger.Text, adviceExplorer);
            dictionaryAdvice.Add(lblTheunisVanZyl.Text, adviceGuide);

            return dictionaryAdvice;
        }


        /// <summary>
        /// Sets the advice tab information to load in all needed info from the event.
        /// </summary>
        /// <param name="theEvent">Event to load in</param>
        private void AdviceLoadEvent(Event theEvent)
        {
            //TODO - Fill out advice load in
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
        private void ResponseOptionsLoadEvent(Event theEvent)
        {
            //TODO - Load in event info for this tab.
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


            //TODO - Save the Response! Woo!
            // Global Stats (Resource Modifiers)
            List<int> globalStats = new List<int>;
            if (foodModB.Checked){globalStats.Add((int)foodMod.Value);}
            else {globalStats.Add(-1)}
            if (waterModB.Checked){globalStats.Add((int)waterMod.Value);}
            else {globalStats.Add(-1)}
            if (vModB.Checked){globalStats.Add((int)valueMod.Value);}
            else {globalStats.Add(-1)}
            if (ammoModB.Checked){globalStats.Add((int)ammoMod.Value);}
            else {globalStats.Add(-1)}
            if (medModB.Checked){globalStats.Add((int)medMod.Value);}
            else {globalStats.Add(-1)}
            if (moraleModB.Checked){globalStats.Add((int)moraleMod.Value);}
            else {globalStats.Add(-1)}
            if (staminaModB.Checked){globalStats.Add((int)staminaMod.Value);}
            else {globalStats.Add(-1)}
            if (valueModB.Checked){globalStats.Add((int)packMod.Value);}
            else {globalStats.Add(-1)}

            responseToEdit.myMap[Keys.RESOURCE_MODIFIERS_KEY] = globalStats;

            // Member Stats (Party Stat Modifiers)
            List<int> memberStats = new List<int>;
            if (marksModB.Checked){memberStats.Add((int)markMod.Value);}
            else {memberStats.Add(-1)}
            if (percModB.Checked){memberStats.Add((int)percMod.Value);}
            else {memberStats.Add(-1)}
            if (tacticsModB.Checked){memberStats.Add((int)tacticsMod.Value);}
            else {memberStats.Add(-1)}
            if (loyalModB.Checked){memberStats.Add((int)loyalMod.Value);}
            else {memberStats.Add(-1)}
            if (agilityModB.Checked){memberStats.Add((int)agilityMod.Value);}
            else {memberStats.Add(-1)}
            if (strengthModB.Checked){memberStats.Add((int)strengthMod.Value);}
            else {memberStats.Add(-1)}
            if (diploModB.Checked){memberStats.Add((int)diploMod.Value);}
            else {memberStats.Add(-1)}
            if (knowModB.Checked){memberStats.Add((int)knowMod.Value);}
            else {memberStats.Add(-1)}

            responseToEdit.myMap[Keys.PARTY_STAT_MODIFIERS_KEY] = memberStats;

            // Global Variable Requirements (Resource Stat Requirement)
            List<int> resourceStatReq = new List<int>;
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
            List<int> partyMemReq = new List<int>;
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
            List<int> loseGlobal = new List<int>;
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
            List<int> loseMember = new List<int>;
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
            List<int> winGlobal = new List<int>;
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
            List<int> winMember = new List<int>;
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
            List<int> costResource = new List<int>;
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
            List<int> costMember = new List<int>;
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
            // TO - DO

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
            

            //TODO - Load the Response! Hooray!


            return "";
        }

        /// <summary>
        /// Sets the Edit Response Options tab information to load in all needed info from the event.
        /// </summary>
        /// <param name="theEvent">Event to load in</param>
        private void EditResponseOptionsLoadEvent(Event theEvent)
        {
            //TODO - Load in event info for this tab.
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
        private void FinishLoadEvent(Event theEvent)
        {
            //TODO - Load in event info for this tab.
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
            currentRspSelect = 0;
            comboBoxRespToEdit.SelectedIndex = currentRspSelect;
            editRespNeedSave = true;

            comboBoxWinApplication.SelectedIndex = EFFECT_ON_RANDOM;
            comboBoxPassApplication.SelectedIndex = EFFECT_ON_RANDOM;
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
        }

        private void tabGeneralInfo_Click(object sender, EventArgs e)
        {

        }

        private void locationsInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------------ */
        // ------------------------------------------------ //
        /* ------------------------------------------------ */

    }
}
