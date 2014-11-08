using System;
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

        internal static string getEventType()
        {
            //TODO Return the event type
            return "";
        }

        internal static List<string> getPossibleLocations()
        {
            //TODO Return the list of possible locations
            return new List<string>();
        }

        internal static List<string> getRequiredParty()
        {
            //TODO Return the list of required party members
            return new List<string>();
        }

        internal static string getIntroText()
        {
            //TODO Return the intro text
            return "";
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

        /* ------------------------------------------------ */
        // ------------------------------------------------ //
        /* ------------------------------------------------ */

    }
}
