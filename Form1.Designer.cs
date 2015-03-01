namespace EventCreator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabGeneralInfo = new System.Windows.Forms.TabPage();
            this.lblNot = new System.Windows.Forms.Label();
            this.notClassInput = new System.Windows.Forms.CheckedListBox();
            this.lblOr = new System.Windows.Forms.Label();
            this.orClassInput = new System.Windows.Forms.CheckedListBox();
            this.lblAnd = new System.Windows.Forms.Label();
            this.chkOnlyOnce = new System.Windows.Forms.CheckBox();
            this.btnLoadEvent = new System.Windows.Forms.Button();
            this.selectplayerB = new System.Windows.Forms.CheckBox();
            this.introDescLabel = new System.Windows.Forms.Label();
            this.introDescInput = new System.Windows.Forms.TextBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.frequencyInput = new System.Windows.Forms.ComboBox();
            this.andClassInput = new System.Windows.Forms.CheckedListBox();
            this.reqClassLabel = new System.Windows.Forms.Label();
            this.possibleLocationsLabel = new System.Windows.Forms.Label();
            this.locationsInput = new System.Windows.Forms.CheckedListBox();
            this.eventTypeInput = new System.Windows.Forms.ComboBox();
            this.eventTypeLabel = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventNameInput = new System.Windows.Forms.TextBox();
            this.Advice = new System.Windows.Forms.TabPage();
            this.lblGuide = new System.Windows.Forms.Label();
            this.lblExplorer = new System.Windows.Forms.Label();
            this.lblMissionary = new System.Windows.Forms.Label();
            this.lblNaturalist = new System.Windows.Forms.Label();
            this.chkGuide = new System.Windows.Forms.CheckBox();
            this.chkNaturalist = new System.Windows.Forms.CheckBox();
            this.chkMissionary = new System.Windows.Forms.CheckBox();
            this.chkExplorer = new System.Windows.Forms.CheckBox();
            this.chkMercenary = new System.Windows.Forms.CheckBox();
            this.txtExplorer = new System.Windows.Forms.TextBox();
            this.txtGuide = new System.Windows.Forms.TextBox();
            this.txtMissionary = new System.Windows.Forms.TextBox();
            this.txtNaturalist = new System.Windows.Forms.TextBox();
            this.txtMercenary = new System.Windows.Forms.TextBox();
            this.IsAdviceUseful = new System.Windows.Forms.Label();
            this.CharacterAdvice = new System.Windows.Forms.Label();
            this.CharacterTtype = new System.Windows.Forms.Label();
            this.lblMercenary = new System.Windows.Forms.Label();
            this.chkHunter = new System.Windows.Forms.CheckBox();
            this.txtHunter = new System.Windows.Forms.TextBox();
            this.lblHunter = new System.Windows.Forms.Label();
            this.tabRespOpts = new System.Windows.Forms.TabPage();
            this.removeNumBox = new System.Windows.Forms.NumericUpDown();
            this.textResponse1 = new System.Windows.Forms.TextBox();
            this.textResponse2 = new System.Windows.Forms.TextBox();
            this.labelResponse1 = new System.Windows.Forms.Label();
            this.textResponse3 = new System.Windows.Forms.TextBox();
            this.removeResponseNumLabel = new System.Windows.Forms.Label();
            this.textResponse4 = new System.Windows.Forms.TextBox();
            this.removeResponseButton = new System.Windows.Forms.Button();
            this.textResponse5 = new System.Windows.Forms.TextBox();
            this.addResponseButton = new System.Windows.Forms.Button();
            this.labelResponse3 = new System.Windows.Forms.Label();
            this.labelResponse2 = new System.Windows.Forms.Label();
            this.labelResponse4 = new System.Windows.Forms.Label();
            this.labelResponse5 = new System.Windows.Forms.Label();
            this.tabEditRespOpts = new System.Windows.Forms.TabPage();
            this.passText = new System.Windows.Forms.TextBox();
            this.lblProbLose = new System.Windows.Forms.Label();
            this.passTextLabel = new System.Windows.Forms.Label();
            this.strengthReq = new System.Windows.Forms.NumericUpDown();
            this.strengthCost = new System.Windows.Forms.NumericUpDown();
            this.knowCost = new System.Windows.Forms.NumericUpDown();
            this.lblProbWin = new System.Windows.Forms.Label();
            this.browse2 = new System.Windows.Forms.Button();
            this.marksCost = new System.Windows.Forms.NumericUpDown();
            this.knowReq = new System.Windows.Forms.NumericUpDown();
            this.loyalCost = new System.Windows.Forms.NumericUpDown();
            this.passFollowUp = new System.Windows.Forms.TextBox();
            this.lblWithStdParty = new System.Windows.Forms.Label();
            this.percCost = new System.Windows.Forms.NumericUpDown();
            this.marksReq = new System.Windows.Forms.NumericUpDown();
            this.passFollowUpLabel = new System.Windows.Forms.Label();
            this.agilityCost = new System.Windows.Forms.NumericUpDown();
            this.lblProbLoseTxt = new System.Windows.Forms.Label();
            this.diploCost = new System.Windows.Forms.NumericUpDown();
            this.loyalReq = new System.Windows.Forms.NumericUpDown();
            this.tacticsCost = new System.Windows.Forms.NumericUpDown();
            this.strengthLabelC = new System.Windows.Forms.Label();
            this.percReq = new System.Windows.Forms.NumericUpDown();
            this.knowLabelC = new System.Windows.Forms.Label();
            this.lblProbOfWinTxt = new System.Windows.Forms.Label();
            this.marksLabelC = new System.Windows.Forms.Label();
            this.agilityReq = new System.Windows.Forms.NumericUpDown();
            this.loyalCostC = new System.Windows.Forms.Label();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.lblLoseEffects = new System.Windows.Forms.Label();
            this.comboBoxLoseApplication = new System.Windows.Forms.ComboBox();
            this.lblWinEffects = new System.Windows.Forms.Label();
            this.comboBoxWinApplication = new System.Windows.Forms.ComboBox();
            this.chkKillLose = new System.Windows.Forms.CheckBox();
            this.chkWinKill = new System.Windows.Forms.CheckBox();
            this.btnRespOptSave = new System.Windows.Forms.Button();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.browse1 = new System.Windows.Forms.Button();
            this.loseFollowUp = new System.Windows.Forms.TextBox();
            this.winFollowUp = new System.Windows.Forms.TextBox();
            this.loseFollowUpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.percLabelC = new System.Windows.Forms.Label();
            this.diploReq = new System.Windows.Forms.NumericUpDown();
            this.agilityLabelC = new System.Windows.Forms.Label();
            this.pnlResText = new System.Windows.Forms.Panel();
            this.loseText = new System.Windows.Forms.TextBox();
            this.loseTextLabel = new System.Windows.Forms.Label();
            this.winText = new System.Windows.Forms.TextBox();
            this.winTextLabel = new System.Windows.Forms.Label();
            this.diploLabelC = new System.Windows.Forms.Label();
            this.tacticsReq = new System.Windows.Forms.NumericUpDown();
            this.tacticsLabelC = new System.Windows.Forms.Label();
            this.pnlCost = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.statLabelC = new System.Windows.Forms.Label();
            this.foodCost = new System.Windows.Forms.NumericUpDown();
            this.staminaCost = new System.Windows.Forms.NumericUpDown();
            this.moraleCost = new System.Windows.Forms.NumericUpDown();
            this.valueCost = new System.Windows.Forms.NumericUpDown();
            this.packCost = new System.Windows.Forms.NumericUpDown();
            this.ammoCost = new System.Windows.Forms.NumericUpDown();
            this.medCost = new System.Windows.Forms.NumericUpDown();
            this.waterCost = new System.Windows.Forms.NumericUpDown();
            this.foodLabelC = new System.Windows.Forms.Label();
            this.staminaLabelC = new System.Windows.Forms.Label();
            this.moraleLabelC = new System.Windows.Forms.Label();
            this.valueLabelC = new System.Windows.Forms.Label();
            this.packLabelC = new System.Windows.Forms.Label();
            this.ammoLabelC = new System.Windows.Forms.Label();
            this.medLabelC = new System.Windows.Forms.Label();
            this.waterLabelC = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.strengthLabelR = new System.Windows.Forms.Label();
            this.knowLabelR = new System.Windows.Forms.Label();
            this.pnlLose = new System.Windows.Forms.Panel();
            this.subtractLabel = new System.Windows.Forms.Label();
            this.statLabelL = new System.Windows.Forms.Label();
            this.amountLLabel = new System.Windows.Forms.Label();
            this.strengthLose = new System.Windows.Forms.NumericUpDown();
            this.knowLose = new System.Windows.Forms.NumericUpDown();
            this.markLose = new System.Windows.Forms.NumericUpDown();
            this.loyalLose = new System.Windows.Forms.NumericUpDown();
            this.percLose = new System.Windows.Forms.NumericUpDown();
            this.agilityLose = new System.Windows.Forms.NumericUpDown();
            this.diploLose = new System.Windows.Forms.NumericUpDown();
            this.tacticsLose = new System.Windows.Forms.NumericUpDown();
            this.strengthLabelL = new System.Windows.Forms.Label();
            this.knowLabelL = new System.Windows.Forms.Label();
            this.marksLabelL = new System.Windows.Forms.Label();
            this.loyalLabelL = new System.Windows.Forms.Label();
            this.percLabelL = new System.Windows.Forms.Label();
            this.agilityLabelL = new System.Windows.Forms.Label();
            this.diploLabelL = new System.Windows.Forms.Label();
            this.tacticsLabelL = new System.Windows.Forms.Label();
            this.foodLose = new System.Windows.Forms.NumericUpDown();
            this.staminaLose = new System.Windows.Forms.NumericUpDown();
            this.moraleLose = new System.Windows.Forms.NumericUpDown();
            this.valueLose = new System.Windows.Forms.NumericUpDown();
            this.packLose = new System.Windows.Forms.NumericUpDown();
            this.ammoLose = new System.Windows.Forms.NumericUpDown();
            this.medLose = new System.Windows.Forms.NumericUpDown();
            this.waterLose = new System.Windows.Forms.NumericUpDown();
            this.foodLabelL = new System.Windows.Forms.Label();
            this.staminaLabelL = new System.Windows.Forms.Label();
            this.moraleLabelL = new System.Windows.Forms.Label();
            this.valueLabelL = new System.Windows.Forms.Label();
            this.packLabelL = new System.Windows.Forms.Label();
            this.ammoLabelL = new System.Windows.Forms.Label();
            this.medLabelL = new System.Windows.Forms.Label();
            this.waterLabelL = new System.Windows.Forms.Label();
            this.loseLabel = new System.Windows.Forms.Label();
            this.marksLabelR = new System.Windows.Forms.Label();
            this.pnlWin = new System.Windows.Forms.Panel();
            this.addLabel = new System.Windows.Forms.Label();
            this.statLabelW = new System.Windows.Forms.Label();
            this.amountWLabel = new System.Windows.Forms.Label();
            this.strengthWin = new System.Windows.Forms.NumericUpDown();
            this.knowWin = new System.Windows.Forms.NumericUpDown();
            this.marksWin = new System.Windows.Forms.NumericUpDown();
            this.loyalWin = new System.Windows.Forms.NumericUpDown();
            this.percWin = new System.Windows.Forms.NumericUpDown();
            this.agilityWin = new System.Windows.Forms.NumericUpDown();
            this.diploWin = new System.Windows.Forms.NumericUpDown();
            this.tacticsWin = new System.Windows.Forms.NumericUpDown();
            this.strengthLabelW = new System.Windows.Forms.Label();
            this.knowLabelW = new System.Windows.Forms.Label();
            this.markLabelW = new System.Windows.Forms.Label();
            this.loyalLabelW = new System.Windows.Forms.Label();
            this.percLabelW = new System.Windows.Forms.Label();
            this.agilityLabelW = new System.Windows.Forms.Label();
            this.diploLabelW = new System.Windows.Forms.Label();
            this.tacticsLabelW = new System.Windows.Forms.Label();
            this.foodWin = new System.Windows.Forms.NumericUpDown();
            this.staminaWin = new System.Windows.Forms.NumericUpDown();
            this.moraleWin = new System.Windows.Forms.NumericUpDown();
            this.valueWin = new System.Windows.Forms.NumericUpDown();
            this.packWin = new System.Windows.Forms.NumericUpDown();
            this.ammoWin = new System.Windows.Forms.NumericUpDown();
            this.medWin = new System.Windows.Forms.NumericUpDown();
            this.waterWin = new System.Windows.Forms.NumericUpDown();
            this.foodLabelW = new System.Windows.Forms.Label();
            this.staminaLabelW = new System.Windows.Forms.Label();
            this.moraleLabelW = new System.Windows.Forms.Label();
            this.valueLabelW = new System.Windows.Forms.Label();
            this.packLabelW = new System.Windows.Forms.Label();
            this.ammoLabelW = new System.Windows.Forms.Label();
            this.medLabelW = new System.Windows.Forms.Label();
            this.waterLabelW = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.loyalLabelR = new System.Windows.Forms.Label();
            this.pnlReq = new System.Windows.Forms.Panel();
            this.statLabelR = new System.Windows.Forms.Label();
            this.amountLabelR = new System.Windows.Forms.Label();
            this.foodReq = new System.Windows.Forms.NumericUpDown();
            this.staminaReq = new System.Windows.Forms.NumericUpDown();
            this.moraleReq = new System.Windows.Forms.NumericUpDown();
            this.valueReq = new System.Windows.Forms.NumericUpDown();
            this.packReq = new System.Windows.Forms.NumericUpDown();
            this.ammoReq = new System.Windows.Forms.NumericUpDown();
            this.medReq = new System.Windows.Forms.NumericUpDown();
            this.waterReq = new System.Windows.Forms.NumericUpDown();
            this.foodLabelR = new System.Windows.Forms.Label();
            this.staminaLabelR = new System.Windows.Forms.Label();
            this.moraleLabelR = new System.Windows.Forms.Label();
            this.valueLabelR = new System.Windows.Forms.Label();
            this.packLabelR = new System.Windows.Forms.Label();
            this.ammoLabelR = new System.Windows.Forms.Label();
            this.medLabelR = new System.Windows.Forms.Label();
            this.waterLabelR = new System.Windows.Forms.Label();
            this.reqLabel = new System.Windows.Forms.Label();
            this.percLabelR = new System.Windows.Forms.Label();
            this.pnlMod = new System.Windows.Forms.Panel();
            this.statMLabel = new System.Windows.Forms.Label();
            this.applyMLabel = new System.Windows.Forms.Label();
            this.amountMLabel = new System.Windows.Forms.Label();
            this.strengthModB = new System.Windows.Forms.CheckBox();
            this.knowModB = new System.Windows.Forms.CheckBox();
            this.marksModB = new System.Windows.Forms.CheckBox();
            this.loyalModB = new System.Windows.Forms.CheckBox();
            this.percModB = new System.Windows.Forms.CheckBox();
            this.agilityModB = new System.Windows.Forms.CheckBox();
            this.diploModB = new System.Windows.Forms.CheckBox();
            this.tacticsModB = new System.Windows.Forms.CheckBox();
            this.strengthMod = new System.Windows.Forms.NumericUpDown();
            this.knowMod = new System.Windows.Forms.NumericUpDown();
            this.markMod = new System.Windows.Forms.NumericUpDown();
            this.loyalMod = new System.Windows.Forms.NumericUpDown();
            this.percMod = new System.Windows.Forms.NumericUpDown();
            this.agilityMod = new System.Windows.Forms.NumericUpDown();
            this.diploMod = new System.Windows.Forms.NumericUpDown();
            this.tacticsMod = new System.Windows.Forms.NumericUpDown();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.knowLabel = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.loyalLabel = new System.Windows.Forms.Label();
            this.percLabel = new System.Windows.Forms.Label();
            this.agilityLabel = new System.Windows.Forms.Label();
            this.diploLabel = new System.Windows.Forms.Label();
            this.tacticsLabel = new System.Windows.Forms.Label();
            this.modLabel = new System.Windows.Forms.Label();
            this.agilityLabelR = new System.Windows.Forms.Label();
            this.lblCurrentResponse = new System.Windows.Forms.Label();
            this.diploLabelR = new System.Windows.Forms.Label();
            this.comboBoxRespToEdit = new System.Windows.Forms.ComboBox();
            this.tacticsLabelR = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();
            this.waterMod = new System.Windows.Forms.NumericUpDown();
            this.medLabel = new System.Windows.Forms.Label();
            this.staminaMod = new System.Windows.Forms.NumericUpDown();
            this.valueModB = new System.Windows.Forms.CheckBox();
            this.ammoLabel = new System.Windows.Forms.Label();
            this.vModB = new System.Windows.Forms.CheckBox();
            this.foodMod = new System.Windows.Forms.NumericUpDown();
            this.packLabel = new System.Windows.Forms.Label();
            this.moraleMod = new System.Windows.Forms.NumericUpDown();
            this.ammoModB = new System.Windows.Forms.CheckBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.moraleModB = new System.Windows.Forms.CheckBox();
            this.waterModB = new System.Windows.Forms.CheckBox();
            this.moraleLabel = new System.Windows.Forms.Label();
            this.valueMod = new System.Windows.Forms.NumericUpDown();
            this.medModB = new System.Windows.Forms.CheckBox();
            this.stamLabel = new System.Windows.Forms.Label();
            this.staminaModB = new System.Windows.Forms.CheckBox();
            this.packMod = new System.Windows.Forms.NumericUpDown();
            this.foodLabel = new System.Windows.Forms.Label();
            this.foodModB = new System.Windows.Forms.CheckBox();
            this.ammoMod = new System.Windows.Forms.NumericUpDown();
            this.medMod = new System.Windows.Forms.NumericUpDown();
            this.tabFinish = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileLoc = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_LoadEvent = new System.Windows.Forms.OpenFileDialog();
            this.tabMain.SuspendLayout();
            this.tabGeneralInfo.SuspendLayout();
            this.Advice.SuspendLayout();
            this.tabRespOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeNumBox)).BeginInit();
            this.tabEditRespOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityReq)).BeginInit();
            this.pnlOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diploReq)).BeginInit();
            this.pnlResText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsReq)).BeginInit();
            this.pnlCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterCost)).BeginInit();
            this.pnlLose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterLose)).BeginInit();
            this.pnlWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterWin)).BeginInit();
            this.pnlReq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterReq)).BeginInit();
            this.pnlMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medMod)).BeginInit();
            this.tabFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabGeneralInfo);
            this.tabMain.Controls.Add(this.Advice);
            this.tabMain.Controls.Add(this.tabRespOpts);
            this.tabMain.Controls.Add(this.tabEditRespOpts);
            this.tabMain.Controls.Add(this.tabFinish);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(864, 560);
            this.tabMain.TabIndex = 0;
            // 
            // tabGeneralInfo
            // 
            this.tabGeneralInfo.Controls.Add(this.lblNot);
            this.tabGeneralInfo.Controls.Add(this.notClassInput);
            this.tabGeneralInfo.Controls.Add(this.lblOr);
            this.tabGeneralInfo.Controls.Add(this.orClassInput);
            this.tabGeneralInfo.Controls.Add(this.lblAnd);
            this.tabGeneralInfo.Controls.Add(this.chkOnlyOnce);
            this.tabGeneralInfo.Controls.Add(this.btnLoadEvent);
            this.tabGeneralInfo.Controls.Add(this.selectplayerB);
            this.tabGeneralInfo.Controls.Add(this.introDescLabel);
            this.tabGeneralInfo.Controls.Add(this.introDescInput);
            this.tabGeneralInfo.Controls.Add(this.frequencyLabel);
            this.tabGeneralInfo.Controls.Add(this.frequencyInput);
            this.tabGeneralInfo.Controls.Add(this.andClassInput);
            this.tabGeneralInfo.Controls.Add(this.reqClassLabel);
            this.tabGeneralInfo.Controls.Add(this.possibleLocationsLabel);
            this.tabGeneralInfo.Controls.Add(this.locationsInput);
            this.tabGeneralInfo.Controls.Add(this.eventTypeInput);
            this.tabGeneralInfo.Controls.Add(this.eventTypeLabel);
            this.tabGeneralInfo.Controls.Add(this.eventNameLabel);
            this.tabGeneralInfo.Controls.Add(this.eventNameInput);
            this.tabGeneralInfo.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralInfo.Name = "tabGeneralInfo";
            this.tabGeneralInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralInfo.Size = new System.Drawing.Size(856, 534);
            this.tabGeneralInfo.TabIndex = 0;
            this.tabGeneralInfo.Text = "General Info";
            this.tabGeneralInfo.UseVisualStyleBackColor = true;
            this.tabGeneralInfo.Click += new System.EventHandler(this.tabGeneralInfo_Click);
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(9, 419);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(33, 13);
            this.lblNot.TabIndex = 31;
            this.lblNot.Text = "NOT:";
            // 
            // notClassInput
            // 
            this.notClassInput.CheckOnClick = true;
            this.notClassInput.FormattingEnabled = true;
            this.notClassInput.Items.AddRange(new object[] {
            "Hunter",
            "Mercenary",
            "Naturalist",
            "Missionary",
            "Explorer",
            "Guide"});
            this.notClassInput.Location = new System.Drawing.Point(48, 416);
            this.notClassInput.MultiColumn = true;
            this.notClassInput.Name = "notClassInput";
            this.notClassInput.Size = new System.Drawing.Size(744, 19);
            this.notClassInput.TabIndex = 30;
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(9, 385);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(26, 13);
            this.lblOr.TabIndex = 29;
            this.lblOr.Text = "OR:";
            // 
            // orClassInput
            // 
            this.orClassInput.CheckOnClick = true;
            this.orClassInput.FormattingEnabled = true;
            this.orClassInput.Items.AddRange(new object[] {
            "Hunter",
            "Mercenary",
            "Naturalist",
            "Missionary",
            "Explorer",
            "Guide"});
            this.orClassInput.Location = new System.Drawing.Point(48, 382);
            this.orClassInput.MultiColumn = true;
            this.orClassInput.Name = "orClassInput";
            this.orClassInput.Size = new System.Drawing.Size(744, 19);
            this.orClassInput.TabIndex = 28;
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(9, 347);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(33, 13);
            this.lblAnd.TabIndex = 27;
            this.lblAnd.Text = "AND:";
            // 
            // chkOnlyOnce
            // 
            this.chkOnlyOnce.AutoSize = true;
            this.chkOnlyOnce.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOnlyOnce.Location = new System.Drawing.Point(679, 38);
            this.chkOnlyOnce.Name = "chkOnlyOnce";
            this.chkOnlyOnce.Size = new System.Drawing.Size(113, 17);
            this.chkOnlyOnce.TabIndex = 4;
            this.chkOnlyOnce.Text = "Only Occurs Once";
            this.chkOnlyOnce.UseVisualStyleBackColor = true;
            // 
            // btnLoadEvent
            // 
            this.btnLoadEvent.Location = new System.Drawing.Point(717, 441);
            this.btnLoadEvent.Name = "btnLoadEvent";
            this.btnLoadEvent.Size = new System.Drawing.Size(75, 23);
            this.btnLoadEvent.TabIndex = 11;
            this.btnLoadEvent.Text = "Load Event";
            this.btnLoadEvent.UseVisualStyleBackColor = true;
            this.btnLoadEvent.Click += new System.EventHandler(this.btnLoadEvent_Click);
            // 
            // selectplayerB
            // 
            this.selectplayerB.AutoSize = true;
            this.selectplayerB.Location = new System.Drawing.Point(12, 274);
            this.selectplayerB.Name = "selectplayerB";
            this.selectplayerB.Size = new System.Drawing.Size(182, 17);
            this.selectplayerB.TabIndex = 6;
            this.selectplayerB.Text = "Select Party Member Beforehand";
            this.selectplayerB.UseVisualStyleBackColor = true;
            // 
            // introDescLabel
            // 
            this.introDescLabel.AutoSize = true;
            this.introDescLabel.Location = new System.Drawing.Point(215, 81);
            this.introDescLabel.Name = "introDescLabel";
            this.introDescLabel.Size = new System.Drawing.Size(122, 13);
            this.introDescLabel.TabIndex = 26;
            this.introDescLabel.Text = "Introduction Description:";
            // 
            // introDescInput
            // 
            this.introDescInput.Location = new System.Drawing.Point(218, 107);
            this.introDescInput.Multiline = true;
            this.introDescInput.Name = "introDescInput";
            this.introDescInput.Size = new System.Drawing.Size(574, 139);
            this.introDescInput.TabIndex = 5;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(506, 13);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(60, 13);
            this.frequencyLabel.TabIndex = 24;
            this.frequencyLabel.Text = "Frequency:";
            // 
            // frequencyInput
            // 
            this.frequencyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frequencyInput.FormattingEnabled = true;
            this.frequencyInput.Items.AddRange(new object[] {
            "Never",
            "Rare",
            "Uncommon",
            "Common",
            "Likely"});
            this.frequencyInput.Location = new System.Drawing.Point(572, 10);
            this.frequencyInput.Name = "frequencyInput";
            this.frequencyInput.Size = new System.Drawing.Size(220, 21);
            this.frequencyInput.TabIndex = 3;
            // 
            // andClassInput
            // 
            this.andClassInput.CheckOnClick = true;
            this.andClassInput.FormattingEnabled = true;
            this.andClassInput.Items.AddRange(new object[] {
            "Hunter",
            "Mercenary",
            "Naturalist",
            "Missionary",
            "Explorer",
            "Guide"});
            this.andClassInput.Location = new System.Drawing.Point(48, 344);
            this.andClassInput.MultiColumn = true;
            this.andClassInput.Name = "andClassInput";
            this.andClassInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.andClassInput.Size = new System.Drawing.Size(744, 19);
            this.andClassInput.TabIndex = 10;
            // 
            // reqClassLabel
            // 
            this.reqClassLabel.AutoSize = true;
            this.reqClassLabel.Location = new System.Drawing.Point(9, 318);
            this.reqClassLabel.Name = "reqClassLabel";
            this.reqClassLabel.Size = new System.Drawing.Size(92, 13);
            this.reqClassLabel.TabIndex = 21;
            this.reqClassLabel.Text = "Required Classes:";
            // 
            // possibleLocationsLabel
            // 
            this.possibleLocationsLabel.AutoSize = true;
            this.possibleLocationsLabel.Location = new System.Drawing.Point(9, 81);
            this.possibleLocationsLabel.Name = "possibleLocationsLabel";
            this.possibleLocationsLabel.Size = new System.Drawing.Size(98, 13);
            this.possibleLocationsLabel.TabIndex = 20;
            this.possibleLocationsLabel.Text = "Possible Locations:";
            // 
            // locationsInput
            // 
            this.locationsInput.CheckOnClick = true;
            this.locationsInput.FormattingEnabled = true;
            this.locationsInput.Items.AddRange(new object[] {
            "Desert",
            "Oasis",
            "Jungle",
            "Water",
            "Savannah",
            "Mountain",
            "Highland",
            "King Solomon’s Mines",
            "Village"});
            this.locationsInput.Location = new System.Drawing.Point(11, 107);
            this.locationsInput.Name = "locationsInput";
            this.locationsInput.Size = new System.Drawing.Size(151, 139);
            this.locationsInput.TabIndex = 2;
            this.locationsInput.SelectedIndexChanged += new System.EventHandler(this.locationsInput_SelectedIndexChanged);
            // 
            // eventTypeInput
            // 
            this.eventTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventTypeInput.FormattingEnabled = true;
            this.eventTypeInput.Items.AddRange(new object[] {
            "Move",
            "Rest",
            "Investigate",
            "Other"});
            this.eventTypeInput.Location = new System.Drawing.Point(83, 37);
            this.eventTypeInput.MaxDropDownItems = 3;
            this.eventTypeInput.Name = "eventTypeInput";
            this.eventTypeInput.Size = new System.Drawing.Size(361, 21);
            this.eventTypeInput.TabIndex = 1;
            // 
            // eventTypeLabel
            // 
            this.eventTypeLabel.AutoSize = true;
            this.eventTypeLabel.Location = new System.Drawing.Point(8, 40);
            this.eventTypeLabel.Name = "eventTypeLabel";
            this.eventTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.eventTypeLabel.TabIndex = 17;
            this.eventTypeLabel.Text = "Event Type:";
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(8, 14);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(69, 13);
            this.eventNameLabel.TabIndex = 16;
            this.eventNameLabel.Text = "Event Name:";
            // 
            // eventNameInput
            // 
            this.eventNameInput.Location = new System.Drawing.Point(83, 11);
            this.eventNameInput.Name = "eventNameInput";
            this.eventNameInput.Size = new System.Drawing.Size(361, 20);
            this.eventNameInput.TabIndex = 0;
            // 
            // Advice
            // 
            this.Advice.Controls.Add(this.lblGuide);
            this.Advice.Controls.Add(this.lblExplorer);
            this.Advice.Controls.Add(this.lblMissionary);
            this.Advice.Controls.Add(this.lblNaturalist);
            this.Advice.Controls.Add(this.chkGuide);
            this.Advice.Controls.Add(this.chkNaturalist);
            this.Advice.Controls.Add(this.chkMissionary);
            this.Advice.Controls.Add(this.chkExplorer);
            this.Advice.Controls.Add(this.chkMercenary);
            this.Advice.Controls.Add(this.txtExplorer);
            this.Advice.Controls.Add(this.txtGuide);
            this.Advice.Controls.Add(this.txtMissionary);
            this.Advice.Controls.Add(this.txtNaturalist);
            this.Advice.Controls.Add(this.txtMercenary);
            this.Advice.Controls.Add(this.IsAdviceUseful);
            this.Advice.Controls.Add(this.CharacterAdvice);
            this.Advice.Controls.Add(this.CharacterTtype);
            this.Advice.Controls.Add(this.lblMercenary);
            this.Advice.Controls.Add(this.chkHunter);
            this.Advice.Controls.Add(this.txtHunter);
            this.Advice.Controls.Add(this.lblHunter);
            this.Advice.Location = new System.Drawing.Point(4, 22);
            this.Advice.Name = "Advice";
            this.Advice.Padding = new System.Windows.Forms.Padding(3);
            this.Advice.Size = new System.Drawing.Size(856, 534);
            this.Advice.TabIndex = 1;
            this.Advice.Text = "Advice";
            this.Advice.UseVisualStyleBackColor = true;
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.Location = new System.Drawing.Point(34, 241);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(35, 13);
            this.lblGuide.TabIndex = 20;
            this.lblGuide.Text = "Guide";
            // 
            // lblExplorer
            // 
            this.lblExplorer.AutoSize = true;
            this.lblExplorer.Location = new System.Drawing.Point(24, 204);
            this.lblExplorer.Name = "lblExplorer";
            this.lblExplorer.Size = new System.Drawing.Size(45, 13);
            this.lblExplorer.TabIndex = 19;
            this.lblExplorer.Text = "Explorer";
            // 
            // lblMissionary
            // 
            this.lblMissionary.AutoSize = true;
            this.lblMissionary.Location = new System.Drawing.Point(13, 168);
            this.lblMissionary.Name = "lblMissionary";
            this.lblMissionary.Size = new System.Drawing.Size(56, 13);
            this.lblMissionary.TabIndex = 18;
            this.lblMissionary.Text = "Missionary";
            // 
            // lblNaturalist
            // 
            this.lblNaturalist.AutoSize = true;
            this.lblNaturalist.Location = new System.Drawing.Point(18, 129);
            this.lblNaturalist.Name = "lblNaturalist";
            this.lblNaturalist.Size = new System.Drawing.Size(51, 13);
            this.lblNaturalist.TabIndex = 17;
            this.lblNaturalist.Text = "Naturalist";
            // 
            // chkGuide
            // 
            this.chkGuide.AutoSize = true;
            this.chkGuide.Location = new System.Drawing.Point(821, 240);
            this.chkGuide.Name = "chkGuide";
            this.chkGuide.Size = new System.Drawing.Size(15, 14);
            this.chkGuide.TabIndex = 18;
            this.chkGuide.UseVisualStyleBackColor = true;
            // 
            // chkNaturalist
            // 
            this.chkNaturalist.AutoSize = true;
            this.chkNaturalist.Location = new System.Drawing.Point(821, 132);
            this.chkNaturalist.Name = "chkNaturalist";
            this.chkNaturalist.Size = new System.Drawing.Size(15, 14);
            this.chkNaturalist.TabIndex = 15;
            this.chkNaturalist.UseVisualStyleBackColor = true;
            // 
            // chkMissionary
            // 
            this.chkMissionary.AutoSize = true;
            this.chkMissionary.Location = new System.Drawing.Point(822, 168);
            this.chkMissionary.Name = "chkMissionary";
            this.chkMissionary.Size = new System.Drawing.Size(15, 14);
            this.chkMissionary.TabIndex = 16;
            this.chkMissionary.UseVisualStyleBackColor = true;
            // 
            // chkExplorer
            // 
            this.chkExplorer.AutoSize = true;
            this.chkExplorer.Location = new System.Drawing.Point(821, 204);
            this.chkExplorer.Name = "chkExplorer";
            this.chkExplorer.Size = new System.Drawing.Size(15, 14);
            this.chkExplorer.TabIndex = 17;
            this.chkExplorer.UseVisualStyleBackColor = true;
            // 
            // chkMercenary
            // 
            this.chkMercenary.AutoSize = true;
            this.chkMercenary.Location = new System.Drawing.Point(821, 97);
            this.chkMercenary.Name = "chkMercenary";
            this.chkMercenary.Size = new System.Drawing.Size(15, 14);
            this.chkMercenary.TabIndex = 14;
            this.chkMercenary.UseVisualStyleBackColor = true;
            // 
            // txtExplorer
            // 
            this.txtExplorer.Location = new System.Drawing.Point(75, 201);
            this.txtExplorer.Name = "txtExplorer";
            this.txtExplorer.Size = new System.Drawing.Size(740, 20);
            this.txtExplorer.TabIndex = 5;
            // 
            // txtGuide
            // 
            this.txtGuide.Location = new System.Drawing.Point(75, 237);
            this.txtGuide.Name = "txtGuide";
            this.txtGuide.Size = new System.Drawing.Size(740, 20);
            this.txtGuide.TabIndex = 6;
            // 
            // txtMissionary
            // 
            this.txtMissionary.Location = new System.Drawing.Point(75, 165);
            this.txtMissionary.Name = "txtMissionary";
            this.txtMissionary.Size = new System.Drawing.Size(740, 20);
            this.txtMissionary.TabIndex = 4;
            // 
            // txtNaturalist
            // 
            this.txtNaturalist.Location = new System.Drawing.Point(75, 129);
            this.txtNaturalist.Name = "txtNaturalist";
            this.txtNaturalist.Size = new System.Drawing.Size(740, 20);
            this.txtNaturalist.TabIndex = 3;
            // 
            // txtMercenary
            // 
            this.txtMercenary.Location = new System.Drawing.Point(75, 94);
            this.txtMercenary.Name = "txtMercenary";
            this.txtMercenary.Size = new System.Drawing.Size(740, 20);
            this.txtMercenary.TabIndex = 2;
            // 
            // IsAdviceUseful
            // 
            this.IsAdviceUseful.AutoSize = true;
            this.IsAdviceUseful.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsAdviceUseful.Location = new System.Drawing.Point(807, 40);
            this.IsAdviceUseful.Name = "IsAdviceUseful";
            this.IsAdviceUseful.Size = new System.Drawing.Size(43, 13);
            this.IsAdviceUseful.TabIndex = 6;
            this.IsAdviceUseful.Text = "Useful";
            // 
            // CharacterAdvice
            // 
            this.CharacterAdvice.AutoSize = true;
            this.CharacterAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterAdvice.Location = new System.Drawing.Point(408, 40);
            this.CharacterAdvice.Name = "CharacterAdvice";
            this.CharacterAdvice.Size = new System.Drawing.Size(46, 13);
            this.CharacterAdvice.TabIndex = 5;
            this.CharacterAdvice.Text = "Advice";
            // 
            // CharacterTtype
            // 
            this.CharacterTtype.AutoSize = true;
            this.CharacterTtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterTtype.Location = new System.Drawing.Point(32, 40);
            this.CharacterTtype.Name = "CharacterTtype";
            this.CharacterTtype.Size = new System.Drawing.Size(37, 13);
            this.CharacterTtype.TabIndex = 4;
            this.CharacterTtype.Text = "Class";
            // 
            // lblMercenary
            // 
            this.lblMercenary.AutoSize = true;
            this.lblMercenary.Location = new System.Drawing.Point(12, 97);
            this.lblMercenary.Name = "lblMercenary";
            this.lblMercenary.Size = new System.Drawing.Size(57, 13);
            this.lblMercenary.TabIndex = 3;
            this.lblMercenary.Text = "Mercenary";
            // 
            // chkHunter
            // 
            this.chkHunter.AutoSize = true;
            this.chkHunter.Location = new System.Drawing.Point(821, 64);
            this.chkHunter.Name = "chkHunter";
            this.chkHunter.Size = new System.Drawing.Size(15, 14);
            this.chkHunter.TabIndex = 13;
            this.chkHunter.UseVisualStyleBackColor = true;
            // 
            // txtHunter
            // 
            this.txtHunter.Location = new System.Drawing.Point(75, 61);
            this.txtHunter.Name = "txtHunter";
            this.txtHunter.Size = new System.Drawing.Size(740, 20);
            this.txtHunter.TabIndex = 1;
            // 
            // lblHunter
            // 
            this.lblHunter.AutoSize = true;
            this.lblHunter.Location = new System.Drawing.Point(30, 61);
            this.lblHunter.Name = "lblHunter";
            this.lblHunter.Size = new System.Drawing.Size(39, 13);
            this.lblHunter.TabIndex = 0;
            this.lblHunter.Text = "Hunter";
            // 
            // tabRespOpts
            // 
            this.tabRespOpts.Controls.Add(this.removeNumBox);
            this.tabRespOpts.Controls.Add(this.textResponse1);
            this.tabRespOpts.Controls.Add(this.textResponse2);
            this.tabRespOpts.Controls.Add(this.labelResponse1);
            this.tabRespOpts.Controls.Add(this.textResponse3);
            this.tabRespOpts.Controls.Add(this.removeResponseNumLabel);
            this.tabRespOpts.Controls.Add(this.textResponse4);
            this.tabRespOpts.Controls.Add(this.removeResponseButton);
            this.tabRespOpts.Controls.Add(this.textResponse5);
            this.tabRespOpts.Controls.Add(this.addResponseButton);
            this.tabRespOpts.Controls.Add(this.labelResponse3);
            this.tabRespOpts.Controls.Add(this.labelResponse2);
            this.tabRespOpts.Controls.Add(this.labelResponse4);
            this.tabRespOpts.Controls.Add(this.labelResponse5);
            this.tabRespOpts.Location = new System.Drawing.Point(4, 22);
            this.tabRespOpts.Name = "tabRespOpts";
            this.tabRespOpts.Size = new System.Drawing.Size(856, 534);
            this.tabRespOpts.TabIndex = 2;
            this.tabRespOpts.Text = "Response Options";
            this.tabRespOpts.UseVisualStyleBackColor = true;
            // 
            // removeNumBox
            // 
            this.removeNumBox.Location = new System.Drawing.Point(676, 505);
            this.removeNumBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.removeNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.removeNumBox.Name = "removeNumBox";
            this.removeNumBox.Size = new System.Drawing.Size(40, 20);
            this.removeNumBox.TabIndex = 6;
            this.removeNumBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textResponse1
            // 
            this.textResponse1.Location = new System.Drawing.Point(34, 33);
            this.textResponse1.Name = "textResponse1";
            this.textResponse1.Size = new System.Drawing.Size(814, 20);
            this.textResponse1.TabIndex = 1;
            this.textResponse1.Text = "Response 1";
            this.textResponse1.TextChanged += new System.EventHandler(this.textResponse1_TextChanged);
            // 
            // textResponse2
            // 
            this.textResponse2.Enabled = false;
            this.textResponse2.Location = new System.Drawing.Point(34, 80);
            this.textResponse2.Name = "textResponse2";
            this.textResponse2.Size = new System.Drawing.Size(814, 20);
            this.textResponse2.TabIndex = 2;
            this.textResponse2.Visible = false;
            this.textResponse2.TextChanged += new System.EventHandler(this.textResponse2_TextChanged);
            // 
            // labelResponse1
            // 
            this.labelResponse1.AutoSize = true;
            this.labelResponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponse1.Location = new System.Drawing.Point(8, 33);
            this.labelResponse1.Name = "labelResponse1";
            this.labelResponse1.Size = new System.Drawing.Size(20, 17);
            this.labelResponse1.TabIndex = 18;
            this.labelResponse1.Text = "1:";
            // 
            // textResponse3
            // 
            this.textResponse3.Enabled = false;
            this.textResponse3.Location = new System.Drawing.Point(34, 127);
            this.textResponse3.Name = "textResponse3";
            this.textResponse3.Size = new System.Drawing.Size(814, 20);
            this.textResponse3.TabIndex = 3;
            this.textResponse3.Visible = false;
            this.textResponse3.TextChanged += new System.EventHandler(this.textResponse3_TextChanged);
            // 
            // removeResponseNumLabel
            // 
            this.removeResponseNumLabel.AutoSize = true;
            this.removeResponseNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeResponseNumLabel.Location = new System.Drawing.Point(604, 506);
            this.removeResponseNumLabel.Name = "removeResponseNumLabel";
            this.removeResponseNumLabel.Size = new System.Drawing.Size(66, 15);
            this.removeResponseNumLabel.TabIndex = 19;
            this.removeResponseNumLabel.Text = "Remove #:";
            // 
            // textResponse4
            // 
            this.textResponse4.Enabled = false;
            this.textResponse4.Location = new System.Drawing.Point(34, 174);
            this.textResponse4.Name = "textResponse4";
            this.textResponse4.Size = new System.Drawing.Size(814, 20);
            this.textResponse4.TabIndex = 4;
            this.textResponse4.Visible = false;
            this.textResponse4.TextChanged += new System.EventHandler(this.textResponse4_TextChanged);
            // 
            // removeResponseButton
            // 
            this.removeResponseButton.Location = new System.Drawing.Point(722, 503);
            this.removeResponseButton.Name = "removeResponseButton";
            this.removeResponseButton.Size = new System.Drawing.Size(58, 23);
            this.removeResponseButton.TabIndex = 7;
            this.removeResponseButton.Text = "Remove";
            this.removeResponseButton.UseVisualStyleBackColor = true;
            this.removeResponseButton.Click += new System.EventHandler(this.removeResponseButton_Click);
            // 
            // textResponse5
            // 
            this.textResponse5.Enabled = false;
            this.textResponse5.Location = new System.Drawing.Point(34, 221);
            this.textResponse5.Name = "textResponse5";
            this.textResponse5.Size = new System.Drawing.Size(814, 20);
            this.textResponse5.TabIndex = 5;
            this.textResponse5.Visible = false;
            this.textResponse5.TextChanged += new System.EventHandler(this.textResponse5_TextChanged);
            // 
            // addResponseButton
            // 
            this.addResponseButton.Location = new System.Drawing.Point(819, 502);
            this.addResponseButton.Name = "addResponseButton";
            this.addResponseButton.Size = new System.Drawing.Size(29, 25);
            this.addResponseButton.TabIndex = 8;
            this.addResponseButton.Text = "+";
            this.addResponseButton.UseVisualStyleBackColor = true;
            this.addResponseButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // labelResponse3
            // 
            this.labelResponse3.AutoSize = true;
            this.labelResponse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponse3.Location = new System.Drawing.Point(8, 130);
            this.labelResponse3.Name = "labelResponse3";
            this.labelResponse3.Size = new System.Drawing.Size(20, 17);
            this.labelResponse3.TabIndex = 25;
            this.labelResponse3.Text = "3:";
            this.labelResponse3.Visible = false;
            // 
            // labelResponse2
            // 
            this.labelResponse2.AutoSize = true;
            this.labelResponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponse2.Location = new System.Drawing.Point(8, 80);
            this.labelResponse2.Name = "labelResponse2";
            this.labelResponse2.Size = new System.Drawing.Size(20, 17);
            this.labelResponse2.TabIndex = 22;
            this.labelResponse2.Text = "2:";
            this.labelResponse2.Visible = false;
            // 
            // labelResponse4
            // 
            this.labelResponse4.AutoSize = true;
            this.labelResponse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponse4.Location = new System.Drawing.Point(8, 173);
            this.labelResponse4.Name = "labelResponse4";
            this.labelResponse4.Size = new System.Drawing.Size(20, 17);
            this.labelResponse4.TabIndex = 24;
            this.labelResponse4.Text = "4:";
            this.labelResponse4.Visible = false;
            // 
            // labelResponse5
            // 
            this.labelResponse5.AutoSize = true;
            this.labelResponse5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponse5.Location = new System.Drawing.Point(8, 224);
            this.labelResponse5.Name = "labelResponse5";
            this.labelResponse5.Size = new System.Drawing.Size(20, 17);
            this.labelResponse5.TabIndex = 23;
            this.labelResponse5.Text = "5:";
            this.labelResponse5.Visible = false;
            // 
            // tabEditRespOpts
            // 
            this.tabEditRespOpts.AutoScroll = true;
            this.tabEditRespOpts.Controls.Add(this.passText);
            this.tabEditRespOpts.Controls.Add(this.lblProbLose);
            this.tabEditRespOpts.Controls.Add(this.passTextLabel);
            this.tabEditRespOpts.Controls.Add(this.strengthReq);
            this.tabEditRespOpts.Controls.Add(this.strengthCost);
            this.tabEditRespOpts.Controls.Add(this.knowCost);
            this.tabEditRespOpts.Controls.Add(this.lblProbWin);
            this.tabEditRespOpts.Controls.Add(this.browse2);
            this.tabEditRespOpts.Controls.Add(this.marksCost);
            this.tabEditRespOpts.Controls.Add(this.knowReq);
            this.tabEditRespOpts.Controls.Add(this.loyalCost);
            this.tabEditRespOpts.Controls.Add(this.passFollowUp);
            this.tabEditRespOpts.Controls.Add(this.lblWithStdParty);
            this.tabEditRespOpts.Controls.Add(this.percCost);
            this.tabEditRespOpts.Controls.Add(this.marksReq);
            this.tabEditRespOpts.Controls.Add(this.passFollowUpLabel);
            this.tabEditRespOpts.Controls.Add(this.agilityCost);
            this.tabEditRespOpts.Controls.Add(this.lblProbLoseTxt);
            this.tabEditRespOpts.Controls.Add(this.diploCost);
            this.tabEditRespOpts.Controls.Add(this.loyalReq);
            this.tabEditRespOpts.Controls.Add(this.tacticsCost);
            this.tabEditRespOpts.Controls.Add(this.strengthLabelC);
            this.tabEditRespOpts.Controls.Add(this.percReq);
            this.tabEditRespOpts.Controls.Add(this.knowLabelC);
            this.tabEditRespOpts.Controls.Add(this.lblProbOfWinTxt);
            this.tabEditRespOpts.Controls.Add(this.marksLabelC);
            this.tabEditRespOpts.Controls.Add(this.agilityReq);
            this.tabEditRespOpts.Controls.Add(this.loyalCostC);
            this.tabEditRespOpts.Controls.Add(this.pnlOther);
            this.tabEditRespOpts.Controls.Add(this.percLabelC);
            this.tabEditRespOpts.Controls.Add(this.diploReq);
            this.tabEditRespOpts.Controls.Add(this.agilityLabelC);
            this.tabEditRespOpts.Controls.Add(this.pnlResText);
            this.tabEditRespOpts.Controls.Add(this.diploLabelC);
            this.tabEditRespOpts.Controls.Add(this.tacticsReq);
            this.tabEditRespOpts.Controls.Add(this.tacticsLabelC);
            this.tabEditRespOpts.Controls.Add(this.pnlCost);
            this.tabEditRespOpts.Controls.Add(this.strengthLabelR);
            this.tabEditRespOpts.Controls.Add(this.knowLabelR);
            this.tabEditRespOpts.Controls.Add(this.pnlLose);
            this.tabEditRespOpts.Controls.Add(this.marksLabelR);
            this.tabEditRespOpts.Controls.Add(this.pnlWin);
            this.tabEditRespOpts.Controls.Add(this.loyalLabelR);
            this.tabEditRespOpts.Controls.Add(this.pnlReq);
            this.tabEditRespOpts.Controls.Add(this.percLabelR);
            this.tabEditRespOpts.Controls.Add(this.pnlMod);
            this.tabEditRespOpts.Controls.Add(this.agilityLabelR);
            this.tabEditRespOpts.Controls.Add(this.lblCurrentResponse);
            this.tabEditRespOpts.Controls.Add(this.diploLabelR);
            this.tabEditRespOpts.Controls.Add(this.comboBoxRespToEdit);
            this.tabEditRespOpts.Controls.Add(this.tacticsLabelR);
            this.tabEditRespOpts.Controls.Add(this.waterLabel);
            this.tabEditRespOpts.Controls.Add(this.waterMod);
            this.tabEditRespOpts.Controls.Add(this.medLabel);
            this.tabEditRespOpts.Controls.Add(this.staminaMod);
            this.tabEditRespOpts.Controls.Add(this.valueModB);
            this.tabEditRespOpts.Controls.Add(this.ammoLabel);
            this.tabEditRespOpts.Controls.Add(this.vModB);
            this.tabEditRespOpts.Controls.Add(this.foodMod);
            this.tabEditRespOpts.Controls.Add(this.packLabel);
            this.tabEditRespOpts.Controls.Add(this.moraleMod);
            this.tabEditRespOpts.Controls.Add(this.ammoModB);
            this.tabEditRespOpts.Controls.Add(this.valueLabel);
            this.tabEditRespOpts.Controls.Add(this.moraleModB);
            this.tabEditRespOpts.Controls.Add(this.waterModB);
            this.tabEditRespOpts.Controls.Add(this.moraleLabel);
            this.tabEditRespOpts.Controls.Add(this.valueMod);
            this.tabEditRespOpts.Controls.Add(this.medModB);
            this.tabEditRespOpts.Controls.Add(this.stamLabel);
            this.tabEditRespOpts.Controls.Add(this.staminaModB);
            this.tabEditRespOpts.Controls.Add(this.packMod);
            this.tabEditRespOpts.Controls.Add(this.foodLabel);
            this.tabEditRespOpts.Controls.Add(this.foodModB);
            this.tabEditRespOpts.Controls.Add(this.ammoMod);
            this.tabEditRespOpts.Controls.Add(this.medMod);
            this.tabEditRespOpts.Location = new System.Drawing.Point(4, 22);
            this.tabEditRespOpts.Name = "tabEditRespOpts";
            this.tabEditRespOpts.Size = new System.Drawing.Size(856, 534);
            this.tabEditRespOpts.TabIndex = 3;
            this.tabEditRespOpts.Text = "Edit Response Optioins";
            this.tabEditRespOpts.UseVisualStyleBackColor = true;
            this.tabEditRespOpts.Enter += new System.EventHandler(this.tabEditRespOpts_Enter);
            // 
            // passText
            // 
            this.passText.Enabled = false;
            this.passText.Location = new System.Drawing.Point(449, 71);
            this.passText.Multiline = true;
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(96, 20);
            this.passText.TabIndex = 481;
            this.passText.Visible = false;
            // 
            // lblProbLose
            // 
            this.lblProbLose.AutoSize = true;
            this.lblProbLose.Location = new System.Drawing.Point(236, 66);
            this.lblProbLose.Name = "lblProbLose";
            this.lblProbLose.Size = new System.Drawing.Size(27, 13);
            this.lblProbLose.TabIndex = 524;
            this.lblProbLose.Text = "50%";
            // 
            // passTextLabel
            // 
            this.passTextLabel.AutoSize = true;
            this.passTextLabel.Enabled = false;
            this.passTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextLabel.Location = new System.Drawing.Point(446, 51);
            this.passTextLabel.Name = "passTextLabel";
            this.passTextLabel.Size = new System.Drawing.Size(63, 13);
            this.passTextLabel.TabIndex = 480;
            this.passTextLabel.Text = "Pass Text";
            this.passTextLabel.Visible = false;
            // 
            // strengthReq
            // 
            this.strengthReq.Enabled = false;
            this.strengthReq.Location = new System.Drawing.Point(777, 49);
            this.strengthReq.Name = "strengthReq";
            this.strengthReq.Size = new System.Drawing.Size(44, 20);
            this.strengthReq.TabIndex = 367;
            this.strengthReq.Visible = false;
            this.strengthReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // strengthCost
            // 
            this.strengthCost.Enabled = false;
            this.strengthCost.Location = new System.Drawing.Point(641, 73);
            this.strengthCost.Name = "strengthCost";
            this.strengthCost.Size = new System.Drawing.Size(44, 20);
            this.strengthCost.TabIndex = 474;
            this.strengthCost.Visible = false;
            this.strengthCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // knowCost
            // 
            this.knowCost.Enabled = false;
            this.knowCost.Location = new System.Drawing.Point(641, 73);
            this.knowCost.Name = "knowCost";
            this.knowCost.Size = new System.Drawing.Size(44, 20);
            this.knowCost.TabIndex = 473;
            this.knowCost.Visible = false;
            this.knowCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // lblProbWin
            // 
            this.lblProbWin.AutoSize = true;
            this.lblProbWin.Location = new System.Drawing.Point(97, 66);
            this.lblProbWin.Name = "lblProbWin";
            this.lblProbWin.Size = new System.Drawing.Size(27, 13);
            this.lblProbWin.TabIndex = 522;
            this.lblProbWin.Text = "50%";
            // 
            // browse2
            // 
            this.browse2.Enabled = false;
            this.browse2.Location = new System.Drawing.Point(564, 66);
            this.browse2.Name = "browse2";
            this.browse2.Size = new System.Drawing.Size(10, 23);
            this.browse2.TabIndex = 491;
            this.browse2.Text = "Browse";
            this.browse2.UseVisualStyleBackColor = true;
            this.browse2.Visible = false;
            this.browse2.Click += new System.EventHandler(this.browse2_Click);
            // 
            // marksCost
            // 
            this.marksCost.Enabled = false;
            this.marksCost.Location = new System.Drawing.Point(641, 72);
            this.marksCost.Name = "marksCost";
            this.marksCost.Size = new System.Drawing.Size(44, 20);
            this.marksCost.TabIndex = 472;
            this.marksCost.Visible = false;
            this.marksCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // knowReq
            // 
            this.knowReq.Enabled = false;
            this.knowReq.Location = new System.Drawing.Point(778, 52);
            this.knowReq.Name = "knowReq";
            this.knowReq.Size = new System.Drawing.Size(44, 20);
            this.knowReq.TabIndex = 366;
            this.knowReq.Visible = false;
            this.knowReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // loyalCost
            // 
            this.loyalCost.Enabled = false;
            this.loyalCost.Location = new System.Drawing.Point(643, 75);
            this.loyalCost.Name = "loyalCost";
            this.loyalCost.Size = new System.Drawing.Size(44, 20);
            this.loyalCost.TabIndex = 471;
            this.loyalCost.Visible = false;
            this.loyalCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // passFollowUp
            // 
            this.passFollowUp.Enabled = false;
            this.passFollowUp.Location = new System.Drawing.Point(503, 68);
            this.passFollowUp.Name = "passFollowUp";
            this.passFollowUp.Size = new System.Drawing.Size(55, 20);
            this.passFollowUp.TabIndex = 488;
            this.passFollowUp.Visible = false;
            // 
            // lblWithStdParty
            // 
            this.lblWithStdParty.AutoSize = true;
            this.lblWithStdParty.Location = new System.Drawing.Point(10, 49);
            this.lblWithStdParty.Name = "lblWithStdParty";
            this.lblWithStdParty.Size = new System.Drawing.Size(114, 13);
            this.lblWithStdParty.TabIndex = 521;
            this.lblWithStdParty.Text = "With a Standard Party:";
            // 
            // percCost
            // 
            this.percCost.Enabled = false;
            this.percCost.Location = new System.Drawing.Point(643, 73);
            this.percCost.Name = "percCost";
            this.percCost.Size = new System.Drawing.Size(44, 20);
            this.percCost.TabIndex = 470;
            this.percCost.Visible = false;
            this.percCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // marksReq
            // 
            this.marksReq.Enabled = false;
            this.marksReq.Location = new System.Drawing.Point(783, 52);
            this.marksReq.Name = "marksReq";
            this.marksReq.Size = new System.Drawing.Size(44, 20);
            this.marksReq.TabIndex = 365;
            this.marksReq.Visible = false;
            this.marksReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // passFollowUpLabel
            // 
            this.passFollowUpLabel.AutoSize = true;
            this.passFollowUpLabel.Enabled = false;
            this.passFollowUpLabel.Location = new System.Drawing.Point(500, 52);
            this.passFollowUpLabel.Name = "passFollowUpLabel";
            this.passFollowUpLabel.Size = new System.Drawing.Size(109, 13);
            this.passFollowUpLabel.TabIndex = 485;
            this.passFollowUpLabel.Text = "Pass Follow-up Event";
            this.passFollowUpLabel.Visible = false;
            // 
            // agilityCost
            // 
            this.agilityCost.Enabled = false;
            this.agilityCost.Location = new System.Drawing.Point(643, 75);
            this.agilityCost.Name = "agilityCost";
            this.agilityCost.Size = new System.Drawing.Size(44, 20);
            this.agilityCost.TabIndex = 469;
            this.agilityCost.Visible = false;
            this.agilityCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // lblProbLoseTxt
            // 
            this.lblProbLoseTxt.AutoSize = true;
            this.lblProbLoseTxt.Location = new System.Drawing.Point(145, 66);
            this.lblProbLoseTxt.Name = "lblProbLoseTxt";
            this.lblProbLoseTxt.Size = new System.Drawing.Size(99, 13);
            this.lblProbLoseTxt.TabIndex = 520;
            this.lblProbLoseTxt.Text = "Probability of Lose: ";
            // 
            // diploCost
            // 
            this.diploCost.Enabled = false;
            this.diploCost.Location = new System.Drawing.Point(643, 73);
            this.diploCost.Name = "diploCost";
            this.diploCost.Size = new System.Drawing.Size(44, 20);
            this.diploCost.TabIndex = 468;
            this.diploCost.Visible = false;
            this.diploCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // loyalReq
            // 
            this.loyalReq.Enabled = false;
            this.loyalReq.Location = new System.Drawing.Point(785, 50);
            this.loyalReq.Name = "loyalReq";
            this.loyalReq.Size = new System.Drawing.Size(44, 20);
            this.loyalReq.TabIndex = 364;
            this.loyalReq.Visible = false;
            this.loyalReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // tacticsCost
            // 
            this.tacticsCost.Enabled = false;
            this.tacticsCost.Location = new System.Drawing.Point(643, 73);
            this.tacticsCost.Name = "tacticsCost";
            this.tacticsCost.Size = new System.Drawing.Size(44, 20);
            this.tacticsCost.TabIndex = 467;
            this.tacticsCost.Visible = false;
            this.tacticsCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // strengthLabelC
            // 
            this.strengthLabelC.AutoSize = true;
            this.strengthLabelC.Enabled = false;
            this.strengthLabelC.Location = new System.Drawing.Point(554, 72);
            this.strengthLabelC.Name = "strengthLabelC";
            this.strengthLabelC.Size = new System.Drawing.Size(45, 13);
            this.strengthLabelC.TabIndex = 466;
            this.strengthLabelC.Text = "strength";
            this.strengthLabelC.Visible = false;
            // 
            // percReq
            // 
            this.percReq.Enabled = false;
            this.percReq.Location = new System.Drawing.Point(788, 54);
            this.percReq.Name = "percReq";
            this.percReq.Size = new System.Drawing.Size(44, 20);
            this.percReq.TabIndex = 363;
            this.percReq.Visible = false;
            this.percReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // knowLabelC
            // 
            this.knowLabelC.AutoSize = true;
            this.knowLabelC.Enabled = false;
            this.knowLabelC.Location = new System.Drawing.Point(555, 72);
            this.knowLabelC.Name = "knowLabelC";
            this.knowLabelC.Size = new System.Drawing.Size(59, 13);
            this.knowLabelC.TabIndex = 465;
            this.knowLabelC.Text = "knowledge";
            this.knowLabelC.Visible = false;
            // 
            // lblProbOfWinTxt
            // 
            this.lblProbOfWinTxt.AutoSize = true;
            this.lblProbOfWinTxt.Location = new System.Drawing.Point(10, 66);
            this.lblProbOfWinTxt.Name = "lblProbOfWinTxt";
            this.lblProbOfWinTxt.Size = new System.Drawing.Size(95, 13);
            this.lblProbOfWinTxt.TabIndex = 518;
            this.lblProbOfWinTxt.Text = "Probability of Win: ";
            // 
            // marksLabelC
            // 
            this.marksLabelC.AutoSize = true;
            this.marksLabelC.Enabled = false;
            this.marksLabelC.Location = new System.Drawing.Point(555, 72);
            this.marksLabelC.Name = "marksLabelC";
            this.marksLabelC.Size = new System.Drawing.Size(74, 13);
            this.marksLabelC.TabIndex = 464;
            this.marksLabelC.Text = "marksmanship";
            this.marksLabelC.Visible = false;
            // 
            // agilityReq
            // 
            this.agilityReq.Enabled = false;
            this.agilityReq.Location = new System.Drawing.Point(787, 50);
            this.agilityReq.Name = "agilityReq";
            this.agilityReq.Size = new System.Drawing.Size(44, 20);
            this.agilityReq.TabIndex = 362;
            this.agilityReq.Visible = false;
            this.agilityReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // loyalCostC
            // 
            this.loyalCostC.AutoSize = true;
            this.loyalCostC.Enabled = false;
            this.loyalCostC.Location = new System.Drawing.Point(557, 74);
            this.loyalCostC.Name = "loyalCostC";
            this.loyalCostC.Size = new System.Drawing.Size(36, 13);
            this.loyalCostC.TabIndex = 463;
            this.loyalCostC.Text = "loyalty";
            this.loyalCostC.Visible = false;
            this.loyalCostC.Click += new System.EventHandler(this.loyalCostC_Click);
            // 
            // pnlOther
            // 
            this.pnlOther.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOther.Controls.Add(this.lblLoseEffects);
            this.pnlOther.Controls.Add(this.comboBoxLoseApplication);
            this.pnlOther.Controls.Add(this.lblWinEffects);
            this.pnlOther.Controls.Add(this.comboBoxWinApplication);
            this.pnlOther.Controls.Add(this.chkKillLose);
            this.pnlOther.Controls.Add(this.chkWinKill);
            this.pnlOther.Controls.Add(this.btnRespOptSave);
            this.pnlOther.Controls.Add(this.btnBrowse3);
            this.pnlOther.Controls.Add(this.browse1);
            this.pnlOther.Controls.Add(this.loseFollowUp);
            this.pnlOther.Controls.Add(this.winFollowUp);
            this.pnlOther.Controls.Add(this.loseFollowUpLabel);
            this.pnlOther.Controls.Add(this.label1);
            this.pnlOther.Location = new System.Drawing.Point(13, 827);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(810, 178);
            this.pnlOther.TabIndex = 517;
            // 
            // lblLoseEffects
            // 
            this.lblLoseEffects.AutoSize = true;
            this.lblLoseEffects.Location = new System.Drawing.Point(552, 98);
            this.lblLoseEffects.Name = "lblLoseEffects";
            this.lblLoseEffects.Size = new System.Drawing.Size(123, 13);
            this.lblLoseEffects.TabIndex = 510;
            this.lblLoseEffects.Text = "Lose Effects Applied To:";
            // 
            // comboBoxLoseApplication
            // 
            this.comboBoxLoseApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoseApplication.FormattingEnabled = true;
            this.comboBoxLoseApplication.Items.AddRange(new object[] {
            "Everyone",
            "Selected Player",
            "Random Player"});
            this.comboBoxLoseApplication.Location = new System.Drawing.Point(681, 95);
            this.comboBoxLoseApplication.Name = "comboBoxLoseApplication";
            this.comboBoxLoseApplication.Size = new System.Drawing.Size(109, 21);
            this.comboBoxLoseApplication.TabIndex = 509;
            this.comboBoxLoseApplication.SelectedIndexChanged += new System.EventHandler(this.EffectApplicationDropdownChanged);
            // 
            // lblWinEffects
            // 
            this.lblWinEffects.AutoSize = true;
            this.lblWinEffects.Location = new System.Drawing.Point(552, 63);
            this.lblWinEffects.Name = "lblWinEffects";
            this.lblWinEffects.Size = new System.Drawing.Size(119, 13);
            this.lblWinEffects.TabIndex = 506;
            this.lblWinEffects.Text = "Win Effects Applied To:";
            // 
            // comboBoxWinApplication
            // 
            this.comboBoxWinApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWinApplication.FormattingEnabled = true;
            this.comboBoxWinApplication.Items.AddRange(new object[] {
            "Everyone",
            "Selected Player",
            "Random Player"});
            this.comboBoxWinApplication.Location = new System.Drawing.Point(681, 60);
            this.comboBoxWinApplication.Name = "comboBoxWinApplication";
            this.comboBoxWinApplication.Size = new System.Drawing.Size(111, 21);
            this.comboBoxWinApplication.TabIndex = 505;
            this.comboBoxWinApplication.SelectedIndexChanged += new System.EventHandler(this.EffectApplicationDropdownChanged);
            // 
            // chkKillLose
            // 
            this.chkKillLose.AutoSize = true;
            this.chkKillLose.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKillLose.Location = new System.Drawing.Point(648, 33);
            this.chkKillLose.Name = "chkKillLose";
            this.chkKillLose.Size = new System.Drawing.Size(148, 17);
            this.chkKillLose.TabIndex = 504;
            this.chkKillLose.Text = "Kill Party Member on Lose";
            this.chkKillLose.UseVisualStyleBackColor = true;
            // 
            // chkWinKill
            // 
            this.chkWinKill.AutoSize = true;
            this.chkWinKill.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkWinKill.Location = new System.Drawing.Point(649, 6);
            this.chkWinKill.Name = "chkWinKill";
            this.chkWinKill.Size = new System.Drawing.Size(147, 17);
            this.chkWinKill.TabIndex = 501;
            this.chkWinKill.Text = "Kill Party Member on Win ";
            this.chkWinKill.UseVisualStyleBackColor = true;
            // 
            // btnRespOptSave
            // 
            this.btnRespOptSave.Location = new System.Drawing.Point(349, 148);
            this.btnRespOptSave.Name = "btnRespOptSave";
            this.btnRespOptSave.Size = new System.Drawing.Size(109, 23);
            this.btnRespOptSave.TabIndex = 499;
            this.btnRespOptSave.Text = "Save";
            this.btnRespOptSave.UseVisualStyleBackColor = true;
            this.btnRespOptSave.Click += new System.EventHandler(this.btnRespOptSave_Click);
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.Location = new System.Drawing.Point(445, 93);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse3.TabIndex = 492;
            this.btnBrowse3.Text = "Browse";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Click += new System.EventHandler(this.browse3_Click);
            // 
            // browse1
            // 
            this.browse1.Location = new System.Drawing.Point(444, 24);
            this.browse1.Name = "browse1";
            this.browse1.Size = new System.Drawing.Size(75, 23);
            this.browse1.TabIndex = 490;
            this.browse1.Text = "Browse";
            this.browse1.UseVisualStyleBackColor = true;
            this.browse1.Click += new System.EventHandler(this.browse1_Click);
            // 
            // loseFollowUp
            // 
            this.loseFollowUp.Location = new System.Drawing.Point(6, 95);
            this.loseFollowUp.Name = "loseFollowUp";
            this.loseFollowUp.Size = new System.Drawing.Size(429, 20);
            this.loseFollowUp.TabIndex = 489;
            // 
            // winFollowUp
            // 
            this.winFollowUp.Location = new System.Drawing.Point(6, 26);
            this.winFollowUp.Name = "winFollowUp";
            this.winFollowUp.Size = new System.Drawing.Size(429, 20);
            this.winFollowUp.TabIndex = 487;
            // 
            // loseFollowUpLabel
            // 
            this.loseFollowUpLabel.AutoSize = true;
            this.loseFollowUpLabel.Location = new System.Drawing.Point(3, 79);
            this.loseFollowUpLabel.Name = "loseFollowUpLabel";
            this.loseFollowUpLabel.Size = new System.Drawing.Size(109, 13);
            this.loseFollowUpLabel.TabIndex = 486;
            this.loseFollowUpLabel.Text = "Lose Follow-up Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 484;
            this.label1.Text = "Win Follow-up Event";
            // 
            // percLabelC
            // 
            this.percLabelC.AutoSize = true;
            this.percLabelC.Enabled = false;
            this.percLabelC.Location = new System.Drawing.Point(556, 72);
            this.percLabelC.Name = "percLabelC";
            this.percLabelC.Size = new System.Drawing.Size(57, 13);
            this.percLabelC.TabIndex = 462;
            this.percLabelC.Text = "perception";
            this.percLabelC.Visible = false;
            // 
            // diploReq
            // 
            this.diploReq.Enabled = false;
            this.diploReq.Location = new System.Drawing.Point(787, 51);
            this.diploReq.Name = "diploReq";
            this.diploReq.Size = new System.Drawing.Size(44, 20);
            this.diploReq.TabIndex = 361;
            this.diploReq.Visible = false;
            this.diploReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // agilityLabelC
            // 
            this.agilityLabelC.AutoSize = true;
            this.agilityLabelC.Enabled = false;
            this.agilityLabelC.Location = new System.Drawing.Point(555, 76);
            this.agilityLabelC.Name = "agilityLabelC";
            this.agilityLabelC.Size = new System.Drawing.Size(33, 13);
            this.agilityLabelC.TabIndex = 461;
            this.agilityLabelC.Text = "agility";
            this.agilityLabelC.Visible = false;
            // 
            // pnlResText
            // 
            this.pnlResText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlResText.Controls.Add(this.loseText);
            this.pnlResText.Controls.Add(this.loseTextLabel);
            this.pnlResText.Controls.Add(this.winText);
            this.pnlResText.Controls.Add(this.winTextLabel);
            this.pnlResText.Location = new System.Drawing.Point(13, 637);
            this.pnlResText.Name = "pnlResText";
            this.pnlResText.Size = new System.Drawing.Size(810, 178);
            this.pnlResText.TabIndex = 516;
            // 
            // loseText
            // 
            this.loseText.Location = new System.Drawing.Point(17, 103);
            this.loseText.Multiline = true;
            this.loseText.Name = "loseText";
            this.loseText.Size = new System.Drawing.Size(775, 50);
            this.loseText.TabIndex = 479;
            // 
            // loseTextLabel
            // 
            this.loseTextLabel.AutoSize = true;
            this.loseTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseTextLabel.Location = new System.Drawing.Point(14, 87);
            this.loseTextLabel.Name = "loseTextLabel";
            this.loseTextLabel.Size = new System.Drawing.Size(63, 13);
            this.loseTextLabel.TabIndex = 478;
            this.loseTextLabel.Text = "Lose Text";
            // 
            // winText
            // 
            this.winText.Location = new System.Drawing.Point(17, 23);
            this.winText.Multiline = true;
            this.winText.Name = "winText";
            this.winText.Size = new System.Drawing.Size(775, 50);
            this.winText.TabIndex = 477;
            // 
            // winTextLabel
            // 
            this.winTextLabel.AutoSize = true;
            this.winTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winTextLabel.Location = new System.Drawing.Point(14, 7);
            this.winTextLabel.Name = "winTextLabel";
            this.winTextLabel.Size = new System.Drawing.Size(58, 13);
            this.winTextLabel.TabIndex = 476;
            this.winTextLabel.Text = "Win Text";
            // 
            // diploLabelC
            // 
            this.diploLabelC.AutoSize = true;
            this.diploLabelC.Enabled = false;
            this.diploLabelC.Location = new System.Drawing.Point(555, 73);
            this.diploLabelC.Name = "diploLabelC";
            this.diploLabelC.Size = new System.Drawing.Size(54, 13);
            this.diploLabelC.TabIndex = 460;
            this.diploLabelC.Text = "diplomacy";
            this.diploLabelC.Visible = false;
            // 
            // tacticsReq
            // 
            this.tacticsReq.Enabled = false;
            this.tacticsReq.Location = new System.Drawing.Point(788, 50);
            this.tacticsReq.Name = "tacticsReq";
            this.tacticsReq.Size = new System.Drawing.Size(44, 20);
            this.tacticsReq.TabIndex = 360;
            this.tacticsReq.Visible = false;
            this.tacticsReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // tacticsLabelC
            // 
            this.tacticsLabelC.AutoSize = true;
            this.tacticsLabelC.Enabled = false;
            this.tacticsLabelC.Location = new System.Drawing.Point(555, 75);
            this.tacticsLabelC.Name = "tacticsLabelC";
            this.tacticsLabelC.Size = new System.Drawing.Size(38, 13);
            this.tacticsLabelC.TabIndex = 459;
            this.tacticsLabelC.Text = "tactics";
            this.tacticsLabelC.Visible = false;
            // 
            // pnlCost
            // 
            this.pnlCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCost.Controls.Add(this.label23);
            this.pnlCost.Controls.Add(this.label40);
            this.pnlCost.Controls.Add(this.statLabelC);
            this.pnlCost.Controls.Add(this.foodCost);
            this.pnlCost.Controls.Add(this.staminaCost);
            this.pnlCost.Controls.Add(this.moraleCost);
            this.pnlCost.Controls.Add(this.valueCost);
            this.pnlCost.Controls.Add(this.packCost);
            this.pnlCost.Controls.Add(this.ammoCost);
            this.pnlCost.Controls.Add(this.medCost);
            this.pnlCost.Controls.Add(this.waterCost);
            this.pnlCost.Controls.Add(this.foodLabelC);
            this.pnlCost.Controls.Add(this.staminaLabelC);
            this.pnlCost.Controls.Add(this.moraleLabelC);
            this.pnlCost.Controls.Add(this.valueLabelC);
            this.pnlCost.Controls.Add(this.packLabelC);
            this.pnlCost.Controls.Add(this.ammoLabelC);
            this.pnlCost.Controls.Add(this.medLabelC);
            this.pnlCost.Controls.Add(this.waterLabelC);
            this.pnlCost.Controls.Add(this.costLabel);
            this.pnlCost.Location = new System.Drawing.Point(593, 101);
            this.pnlCost.Name = "pnlCost";
            this.pnlCost.Size = new System.Drawing.Size(230, 262);
            this.pnlCost.TabIndex = 515;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(112, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 483;
            this.label23.Text = "subtracted";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(122, 13);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(48, 13);
            this.label40.TabIndex = 482;
            this.label40.Text = "amount";
            // 
            // statLabelC
            // 
            this.statLabelC.AutoSize = true;
            this.statLabelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabelC.Location = new System.Drawing.Point(22, 26);
            this.statLabelC.Name = "statLabelC";
            this.statLabelC.Size = new System.Drawing.Size(28, 13);
            this.statLabelC.TabIndex = 475;
            this.statLabelC.Text = "stat";
            // 
            // foodCost
            // 
            this.foodCost.Location = new System.Drawing.Point(122, 228);
            this.foodCost.Name = "foodCost";
            this.foodCost.Size = new System.Drawing.Size(44, 20);
            this.foodCost.TabIndex = 458;
            this.foodCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // staminaCost
            // 
            this.staminaCost.Location = new System.Drawing.Point(122, 203);
            this.staminaCost.Name = "staminaCost";
            this.staminaCost.Size = new System.Drawing.Size(44, 20);
            this.staminaCost.TabIndex = 457;
            this.staminaCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // moraleCost
            // 
            this.moraleCost.Location = new System.Drawing.Point(122, 177);
            this.moraleCost.Name = "moraleCost";
            this.moraleCost.Size = new System.Drawing.Size(44, 20);
            this.moraleCost.TabIndex = 456;
            this.moraleCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // valueCost
            // 
            this.valueCost.Location = new System.Drawing.Point(122, 151);
            this.valueCost.Name = "valueCost";
            this.valueCost.Size = new System.Drawing.Size(44, 20);
            this.valueCost.TabIndex = 455;
            this.valueCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // packCost
            // 
            this.packCost.Location = new System.Drawing.Point(122, 125);
            this.packCost.Name = "packCost";
            this.packCost.Size = new System.Drawing.Size(44, 20);
            this.packCost.TabIndex = 454;
            this.packCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // ammoCost
            // 
            this.ammoCost.Location = new System.Drawing.Point(122, 99);
            this.ammoCost.Name = "ammoCost";
            this.ammoCost.Size = new System.Drawing.Size(44, 20);
            this.ammoCost.TabIndex = 453;
            this.ammoCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // medCost
            // 
            this.medCost.Location = new System.Drawing.Point(122, 74);
            this.medCost.Name = "medCost";
            this.medCost.Size = new System.Drawing.Size(44, 20);
            this.medCost.TabIndex = 452;
            this.medCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // waterCost
            // 
            this.waterCost.Location = new System.Drawing.Point(122, 46);
            this.waterCost.Name = "waterCost";
            this.waterCost.Size = new System.Drawing.Size(44, 20);
            this.waterCost.TabIndex = 451;
            this.waterCost.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // foodLabelC
            // 
            this.foodLabelC.AutoSize = true;
            this.foodLabelC.Location = new System.Drawing.Point(22, 227);
            this.foodLabelC.Name = "foodLabelC";
            this.foodLabelC.Size = new System.Drawing.Size(28, 13);
            this.foodLabelC.TabIndex = 450;
            this.foodLabelC.Text = "food";
            // 
            // staminaLabelC
            // 
            this.staminaLabelC.AutoSize = true;
            this.staminaLabelC.Location = new System.Drawing.Point(22, 202);
            this.staminaLabelC.Name = "staminaLabelC";
            this.staminaLabelC.Size = new System.Drawing.Size(43, 13);
            this.staminaLabelC.TabIndex = 449;
            this.staminaLabelC.Text = "stamina";
            // 
            // moraleLabelC
            // 
            this.moraleLabelC.AutoSize = true;
            this.moraleLabelC.Location = new System.Drawing.Point(22, 176);
            this.moraleLabelC.Name = "moraleLabelC";
            this.moraleLabelC.Size = new System.Drawing.Size(38, 13);
            this.moraleLabelC.TabIndex = 448;
            this.moraleLabelC.Text = "morale";
            // 
            // valueLabelC
            // 
            this.valueLabelC.AutoSize = true;
            this.valueLabelC.Location = new System.Drawing.Point(22, 151);
            this.valueLabelC.Name = "valueLabelC";
            this.valueLabelC.Size = new System.Drawing.Size(52, 13);
            this.valueLabelC.TabIndex = 447;
            this.valueLabelC.Text = "valuables";
            // 
            // packLabelC
            // 
            this.packLabelC.AutoSize = true;
            this.packLabelC.Location = new System.Drawing.Point(22, 124);
            this.packLabelC.Name = "packLabelC";
            this.packLabelC.Size = new System.Drawing.Size(69, 13);
            this.packLabelC.TabIndex = 446;
            this.packLabelC.Text = "pack animals";
            // 
            // ammoLabelC
            // 
            this.ammoLabelC.AutoSize = true;
            this.ammoLabelC.Location = new System.Drawing.Point(22, 100);
            this.ammoLabelC.Name = "ammoLabelC";
            this.ammoLabelC.Size = new System.Drawing.Size(35, 13);
            this.ammoLabelC.TabIndex = 445;
            this.ammoLabelC.Text = "ammo";
            // 
            // medLabelC
            // 
            this.medLabelC.AutoSize = true;
            this.medLabelC.Location = new System.Drawing.Point(22, 74);
            this.medLabelC.Name = "medLabelC";
            this.medLabelC.Size = new System.Drawing.Size(49, 13);
            this.medLabelC.TabIndex = 444;
            this.medLabelC.Text = "medicine";
            // 
            // waterLabelC
            // 
            this.waterLabelC.AutoSize = true;
            this.waterLabelC.Location = new System.Drawing.Point(22, 48);
            this.waterLabelC.Name = "waterLabelC";
            this.waterLabelC.Size = new System.Drawing.Size(33, 13);
            this.waterLabelC.TabIndex = 443;
            this.waterLabelC.Text = "water";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(22, 10);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(32, 13);
            this.costLabel.TabIndex = 442;
            this.costLabel.Text = "Cost";
            // 
            // strengthLabelR
            // 
            this.strengthLabelR.AutoSize = true;
            this.strengthLabelR.Enabled = false;
            this.strengthLabelR.Location = new System.Drawing.Point(685, 51);
            this.strengthLabelR.Name = "strengthLabelR";
            this.strengthLabelR.Size = new System.Drawing.Size(45, 13);
            this.strengthLabelR.TabIndex = 359;
            this.strengthLabelR.Text = "strength";
            this.strengthLabelR.Visible = false;
            // 
            // knowLabelR
            // 
            this.knowLabelR.AutoSize = true;
            this.knowLabelR.Enabled = false;
            this.knowLabelR.Location = new System.Drawing.Point(687, 54);
            this.knowLabelR.Name = "knowLabelR";
            this.knowLabelR.Size = new System.Drawing.Size(59, 13);
            this.knowLabelR.TabIndex = 358;
            this.knowLabelR.Text = "knowledge";
            this.knowLabelR.Visible = false;
            // 
            // pnlLose
            // 
            this.pnlLose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLose.Controls.Add(this.subtractLabel);
            this.pnlLose.Controls.Add(this.statLabelL);
            this.pnlLose.Controls.Add(this.amountLLabel);
            this.pnlLose.Controls.Add(this.strengthLose);
            this.pnlLose.Controls.Add(this.knowLose);
            this.pnlLose.Controls.Add(this.markLose);
            this.pnlLose.Controls.Add(this.loyalLose);
            this.pnlLose.Controls.Add(this.percLose);
            this.pnlLose.Controls.Add(this.agilityLose);
            this.pnlLose.Controls.Add(this.diploLose);
            this.pnlLose.Controls.Add(this.tacticsLose);
            this.pnlLose.Controls.Add(this.strengthLabelL);
            this.pnlLose.Controls.Add(this.knowLabelL);
            this.pnlLose.Controls.Add(this.marksLabelL);
            this.pnlLose.Controls.Add(this.loyalLabelL);
            this.pnlLose.Controls.Add(this.percLabelL);
            this.pnlLose.Controls.Add(this.agilityLabelL);
            this.pnlLose.Controls.Add(this.diploLabelL);
            this.pnlLose.Controls.Add(this.tacticsLabelL);
            this.pnlLose.Controls.Add(this.foodLose);
            this.pnlLose.Controls.Add(this.staminaLose);
            this.pnlLose.Controls.Add(this.moraleLose);
            this.pnlLose.Controls.Add(this.valueLose);
            this.pnlLose.Controls.Add(this.packLose);
            this.pnlLose.Controls.Add(this.ammoLose);
            this.pnlLose.Controls.Add(this.medLose);
            this.pnlLose.Controls.Add(this.waterLose);
            this.pnlLose.Controls.Add(this.foodLabelL);
            this.pnlLose.Controls.Add(this.staminaLabelL);
            this.pnlLose.Controls.Add(this.moraleLabelL);
            this.pnlLose.Controls.Add(this.valueLabelL);
            this.pnlLose.Controls.Add(this.packLabelL);
            this.pnlLose.Controls.Add(this.ammoLabelL);
            this.pnlLose.Controls.Add(this.medLabelL);
            this.pnlLose.Controls.Add(this.waterLabelL);
            this.pnlLose.Controls.Add(this.loseLabel);
            this.pnlLose.Location = new System.Drawing.Point(13, 369);
            this.pnlLose.Name = "pnlLose";
            this.pnlLose.Size = new System.Drawing.Size(364, 262);
            this.pnlLose.TabIndex = 514;
            // 
            // subtractLabel
            // 
            this.subtractLabel.AutoSize = true;
            this.subtractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractLabel.Location = new System.Drawing.Point(110, 26);
            this.subtractLabel.Name = "subtractLabel";
            this.subtractLabel.Size = new System.Drawing.Size(67, 13);
            this.subtractLabel.TabIndex = 441;
            this.subtractLabel.Text = "subtracted";
            // 
            // statLabelL
            // 
            this.statLabelL.AutoSize = true;
            this.statLabelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabelL.Location = new System.Drawing.Point(22, 26);
            this.statLabelL.Name = "statLabelL";
            this.statLabelL.Size = new System.Drawing.Size(28, 13);
            this.statLabelL.TabIndex = 439;
            this.statLabelL.Text = "stat";
            // 
            // amountLLabel
            // 
            this.amountLLabel.AutoSize = true;
            this.amountLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLLabel.Location = new System.Drawing.Point(122, 13);
            this.amountLLabel.Name = "amountLLabel";
            this.amountLLabel.Size = new System.Drawing.Size(48, 13);
            this.amountLLabel.TabIndex = 438;
            this.amountLLabel.Text = "amount";
            // 
            // strengthLose
            // 
            this.strengthLose.Location = new System.Drawing.Point(302, 227);
            this.strengthLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.strengthLose.Name = "strengthLose";
            this.strengthLose.Size = new System.Drawing.Size(44, 20);
            this.strengthLose.TabIndex = 437;
            this.strengthLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // knowLose
            // 
            this.knowLose.Location = new System.Drawing.Point(302, 202);
            this.knowLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.knowLose.Name = "knowLose";
            this.knowLose.Size = new System.Drawing.Size(44, 20);
            this.knowLose.TabIndex = 436;
            this.knowLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // markLose
            // 
            this.markLose.Location = new System.Drawing.Point(302, 176);
            this.markLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.markLose.Name = "markLose";
            this.markLose.Size = new System.Drawing.Size(44, 20);
            this.markLose.TabIndex = 435;
            this.markLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // loyalLose
            // 
            this.loyalLose.Location = new System.Drawing.Point(302, 150);
            this.loyalLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.loyalLose.Name = "loyalLose";
            this.loyalLose.Size = new System.Drawing.Size(44, 20);
            this.loyalLose.TabIndex = 434;
            this.loyalLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // percLose
            // 
            this.percLose.Location = new System.Drawing.Point(302, 124);
            this.percLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.percLose.Name = "percLose";
            this.percLose.Size = new System.Drawing.Size(44, 20);
            this.percLose.TabIndex = 433;
            this.percLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // agilityLose
            // 
            this.agilityLose.Location = new System.Drawing.Point(302, 98);
            this.agilityLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.agilityLose.Name = "agilityLose";
            this.agilityLose.Size = new System.Drawing.Size(44, 20);
            this.agilityLose.TabIndex = 432;
            this.agilityLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // diploLose
            // 
            this.diploLose.Location = new System.Drawing.Point(302, 73);
            this.diploLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.diploLose.Name = "diploLose";
            this.diploLose.Size = new System.Drawing.Size(44, 20);
            this.diploLose.TabIndex = 431;
            this.diploLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // tacticsLose
            // 
            this.tacticsLose.Location = new System.Drawing.Point(302, 46);
            this.tacticsLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tacticsLose.Name = "tacticsLose";
            this.tacticsLose.Size = new System.Drawing.Size(44, 20);
            this.tacticsLose.TabIndex = 430;
            this.tacticsLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // strengthLabelL
            // 
            this.strengthLabelL.AutoSize = true;
            this.strengthLabelL.Location = new System.Drawing.Point(221, 228);
            this.strengthLabelL.Name = "strengthLabelL";
            this.strengthLabelL.Size = new System.Drawing.Size(45, 13);
            this.strengthLabelL.TabIndex = 429;
            this.strengthLabelL.Text = "strength";
            // 
            // knowLabelL
            // 
            this.knowLabelL.AutoSize = true;
            this.knowLabelL.Location = new System.Drawing.Point(222, 203);
            this.knowLabelL.Name = "knowLabelL";
            this.knowLabelL.Size = new System.Drawing.Size(59, 13);
            this.knowLabelL.TabIndex = 428;
            this.knowLabelL.Text = "knowledge";
            // 
            // marksLabelL
            // 
            this.marksLabelL.AutoSize = true;
            this.marksLabelL.Location = new System.Drawing.Point(222, 178);
            this.marksLabelL.Name = "marksLabelL";
            this.marksLabelL.Size = new System.Drawing.Size(74, 13);
            this.marksLabelL.TabIndex = 427;
            this.marksLabelL.Text = "marksmanship";
            // 
            // loyalLabelL
            // 
            this.loyalLabelL.AutoSize = true;
            this.loyalLabelL.Location = new System.Drawing.Point(222, 151);
            this.loyalLabelL.Name = "loyalLabelL";
            this.loyalLabelL.Size = new System.Drawing.Size(36, 13);
            this.loyalLabelL.TabIndex = 426;
            this.loyalLabelL.Text = "loyalty";
            // 
            // percLabelL
            // 
            this.percLabelL.AutoSize = true;
            this.percLabelL.Location = new System.Drawing.Point(221, 125);
            this.percLabelL.Name = "percLabelL";
            this.percLabelL.Size = new System.Drawing.Size(57, 13);
            this.percLabelL.TabIndex = 425;
            this.percLabelL.Text = "perception";
            // 
            // agilityLabelL
            // 
            this.agilityLabelL.AutoSize = true;
            this.agilityLabelL.Location = new System.Drawing.Point(220, 101);
            this.agilityLabelL.Name = "agilityLabelL";
            this.agilityLabelL.Size = new System.Drawing.Size(33, 13);
            this.agilityLabelL.TabIndex = 424;
            this.agilityLabelL.Text = "agility";
            // 
            // diploLabelL
            // 
            this.diploLabelL.AutoSize = true;
            this.diploLabelL.Location = new System.Drawing.Point(220, 75);
            this.diploLabelL.Name = "diploLabelL";
            this.diploLabelL.Size = new System.Drawing.Size(54, 13);
            this.diploLabelL.TabIndex = 423;
            this.diploLabelL.Text = "diplomacy";
            // 
            // tacticsLabelL
            // 
            this.tacticsLabelL.AutoSize = true;
            this.tacticsLabelL.Location = new System.Drawing.Point(220, 48);
            this.tacticsLabelL.Name = "tacticsLabelL";
            this.tacticsLabelL.Size = new System.Drawing.Size(38, 13);
            this.tacticsLabelL.TabIndex = 422;
            this.tacticsLabelL.Text = "tactics";
            // 
            // foodLose
            // 
            this.foodLose.Location = new System.Drawing.Point(122, 226);
            this.foodLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.foodLose.Name = "foodLose";
            this.foodLose.Size = new System.Drawing.Size(44, 20);
            this.foodLose.TabIndex = 421;
            this.foodLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // staminaLose
            // 
            this.staminaLose.Location = new System.Drawing.Point(122, 201);
            this.staminaLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.staminaLose.Name = "staminaLose";
            this.staminaLose.Size = new System.Drawing.Size(44, 20);
            this.staminaLose.TabIndex = 420;
            this.staminaLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // moraleLose
            // 
            this.moraleLose.Location = new System.Drawing.Point(122, 175);
            this.moraleLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.moraleLose.Name = "moraleLose";
            this.moraleLose.Size = new System.Drawing.Size(44, 20);
            this.moraleLose.TabIndex = 419;
            this.moraleLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // valueLose
            // 
            this.valueLose.Location = new System.Drawing.Point(122, 149);
            this.valueLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.valueLose.Name = "valueLose";
            this.valueLose.Size = new System.Drawing.Size(44, 20);
            this.valueLose.TabIndex = 418;
            this.valueLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // packLose
            // 
            this.packLose.Location = new System.Drawing.Point(122, 123);
            this.packLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.packLose.Name = "packLose";
            this.packLose.Size = new System.Drawing.Size(44, 20);
            this.packLose.TabIndex = 417;
            this.packLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // ammoLose
            // 
            this.ammoLose.Location = new System.Drawing.Point(122, 97);
            this.ammoLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ammoLose.Name = "ammoLose";
            this.ammoLose.Size = new System.Drawing.Size(44, 20);
            this.ammoLose.TabIndex = 416;
            this.ammoLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // medLose
            // 
            this.medLose.Location = new System.Drawing.Point(122, 72);
            this.medLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.medLose.Name = "medLose";
            this.medLose.Size = new System.Drawing.Size(44, 20);
            this.medLose.TabIndex = 415;
            this.medLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // waterLose
            // 
            this.waterLose.Location = new System.Drawing.Point(122, 46);
            this.waterLose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.waterLose.Name = "waterLose";
            this.waterLose.Size = new System.Drawing.Size(44, 20);
            this.waterLose.TabIndex = 414;
            this.waterLose.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // foodLabelL
            // 
            this.foodLabelL.AutoSize = true;
            this.foodLabelL.Location = new System.Drawing.Point(22, 226);
            this.foodLabelL.Name = "foodLabelL";
            this.foodLabelL.Size = new System.Drawing.Size(28, 13);
            this.foodLabelL.TabIndex = 413;
            this.foodLabelL.Text = "food";
            // 
            // staminaLabelL
            // 
            this.staminaLabelL.AutoSize = true;
            this.staminaLabelL.Location = new System.Drawing.Point(22, 201);
            this.staminaLabelL.Name = "staminaLabelL";
            this.staminaLabelL.Size = new System.Drawing.Size(43, 13);
            this.staminaLabelL.TabIndex = 412;
            this.staminaLabelL.Text = "stamina";
            // 
            // moraleLabelL
            // 
            this.moraleLabelL.AutoSize = true;
            this.moraleLabelL.Location = new System.Drawing.Point(22, 175);
            this.moraleLabelL.Name = "moraleLabelL";
            this.moraleLabelL.Size = new System.Drawing.Size(38, 13);
            this.moraleLabelL.TabIndex = 411;
            this.moraleLabelL.Text = "morale";
            // 
            // valueLabelL
            // 
            this.valueLabelL.AutoSize = true;
            this.valueLabelL.Location = new System.Drawing.Point(22, 150);
            this.valueLabelL.Name = "valueLabelL";
            this.valueLabelL.Size = new System.Drawing.Size(52, 13);
            this.valueLabelL.TabIndex = 410;
            this.valueLabelL.Text = "valuables";
            // 
            // packLabelL
            // 
            this.packLabelL.AutoSize = true;
            this.packLabelL.Location = new System.Drawing.Point(22, 123);
            this.packLabelL.Name = "packLabelL";
            this.packLabelL.Size = new System.Drawing.Size(69, 13);
            this.packLabelL.TabIndex = 409;
            this.packLabelL.Text = "pack animals";
            // 
            // ammoLabelL
            // 
            this.ammoLabelL.AutoSize = true;
            this.ammoLabelL.Location = new System.Drawing.Point(22, 99);
            this.ammoLabelL.Name = "ammoLabelL";
            this.ammoLabelL.Size = new System.Drawing.Size(35, 13);
            this.ammoLabelL.TabIndex = 408;
            this.ammoLabelL.Text = "ammo";
            // 
            // medLabelL
            // 
            this.medLabelL.AutoSize = true;
            this.medLabelL.Location = new System.Drawing.Point(22, 73);
            this.medLabelL.Name = "medLabelL";
            this.medLabelL.Size = new System.Drawing.Size(49, 13);
            this.medLabelL.TabIndex = 407;
            this.medLabelL.Text = "medicine";
            // 
            // waterLabelL
            // 
            this.waterLabelL.AutoSize = true;
            this.waterLabelL.Location = new System.Drawing.Point(22, 46);
            this.waterLabelL.Name = "waterLabelL";
            this.waterLabelL.Size = new System.Drawing.Size(33, 13);
            this.waterLabelL.TabIndex = 406;
            this.waterLabelL.Text = "water";
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseLabel.Location = new System.Drawing.Point(22, 6);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(34, 13);
            this.loseLabel.TabIndex = 405;
            this.loseLabel.Text = "Lose";
            // 
            // marksLabelR
            // 
            this.marksLabelR.AutoSize = true;
            this.marksLabelR.Enabled = false;
            this.marksLabelR.Location = new System.Drawing.Point(692, 55);
            this.marksLabelR.Name = "marksLabelR";
            this.marksLabelR.Size = new System.Drawing.Size(74, 13);
            this.marksLabelR.TabIndex = 357;
            this.marksLabelR.Text = "marksmanship";
            this.marksLabelR.Visible = false;
            // 
            // pnlWin
            // 
            this.pnlWin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlWin.Controls.Add(this.addLabel);
            this.pnlWin.Controls.Add(this.statLabelW);
            this.pnlWin.Controls.Add(this.amountWLabel);
            this.pnlWin.Controls.Add(this.strengthWin);
            this.pnlWin.Controls.Add(this.knowWin);
            this.pnlWin.Controls.Add(this.marksWin);
            this.pnlWin.Controls.Add(this.loyalWin);
            this.pnlWin.Controls.Add(this.percWin);
            this.pnlWin.Controls.Add(this.agilityWin);
            this.pnlWin.Controls.Add(this.diploWin);
            this.pnlWin.Controls.Add(this.tacticsWin);
            this.pnlWin.Controls.Add(this.strengthLabelW);
            this.pnlWin.Controls.Add(this.knowLabelW);
            this.pnlWin.Controls.Add(this.markLabelW);
            this.pnlWin.Controls.Add(this.loyalLabelW);
            this.pnlWin.Controls.Add(this.percLabelW);
            this.pnlWin.Controls.Add(this.agilityLabelW);
            this.pnlWin.Controls.Add(this.diploLabelW);
            this.pnlWin.Controls.Add(this.tacticsLabelW);
            this.pnlWin.Controls.Add(this.foodWin);
            this.pnlWin.Controls.Add(this.staminaWin);
            this.pnlWin.Controls.Add(this.moraleWin);
            this.pnlWin.Controls.Add(this.valueWin);
            this.pnlWin.Controls.Add(this.packWin);
            this.pnlWin.Controls.Add(this.ammoWin);
            this.pnlWin.Controls.Add(this.medWin);
            this.pnlWin.Controls.Add(this.waterWin);
            this.pnlWin.Controls.Add(this.foodLabelW);
            this.pnlWin.Controls.Add(this.staminaLabelW);
            this.pnlWin.Controls.Add(this.moraleLabelW);
            this.pnlWin.Controls.Add(this.valueLabelW);
            this.pnlWin.Controls.Add(this.packLabelW);
            this.pnlWin.Controls.Add(this.ammoLabelW);
            this.pnlWin.Controls.Add(this.medLabelW);
            this.pnlWin.Controls.Add(this.waterLabelW);
            this.pnlWin.Controls.Add(this.winLabel);
            this.pnlWin.Location = new System.Drawing.Point(459, 369);
            this.pnlWin.Name = "pnlWin";
            this.pnlWin.Size = new System.Drawing.Size(364, 262);
            this.pnlWin.TabIndex = 513;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabel.Location = new System.Drawing.Point(122, 26);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(42, 13);
            this.addLabel.TabIndex = 440;
            this.addLabel.Text = "added";
            // 
            // statLabelW
            // 
            this.statLabelW.AutoSize = true;
            this.statLabelW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabelW.Location = new System.Drawing.Point(22, 26);
            this.statLabelW.Name = "statLabelW";
            this.statLabelW.Size = new System.Drawing.Size(28, 13);
            this.statLabelW.TabIndex = 404;
            this.statLabelW.Text = "stat";
            // 
            // amountWLabel
            // 
            this.amountWLabel.AutoSize = true;
            this.amountWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountWLabel.Location = new System.Drawing.Point(119, 13);
            this.amountWLabel.Name = "amountWLabel";
            this.amountWLabel.Size = new System.Drawing.Size(48, 13);
            this.amountWLabel.TabIndex = 403;
            this.amountWLabel.Text = "amount";
            // 
            // strengthWin
            // 
            this.strengthWin.Location = new System.Drawing.Point(302, 226);
            this.strengthWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.strengthWin.Name = "strengthWin";
            this.strengthWin.Size = new System.Drawing.Size(44, 20);
            this.strengthWin.TabIndex = 402;
            this.strengthWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // knowWin
            // 
            this.knowWin.Location = new System.Drawing.Point(302, 201);
            this.knowWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.knowWin.Name = "knowWin";
            this.knowWin.Size = new System.Drawing.Size(44, 20);
            this.knowWin.TabIndex = 401;
            this.knowWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // marksWin
            // 
            this.marksWin.Location = new System.Drawing.Point(302, 175);
            this.marksWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.marksWin.Name = "marksWin";
            this.marksWin.Size = new System.Drawing.Size(44, 20);
            this.marksWin.TabIndex = 400;
            this.marksWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // loyalWin
            // 
            this.loyalWin.Location = new System.Drawing.Point(302, 149);
            this.loyalWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.loyalWin.Name = "loyalWin";
            this.loyalWin.Size = new System.Drawing.Size(44, 20);
            this.loyalWin.TabIndex = 399;
            this.loyalWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // percWin
            // 
            this.percWin.Location = new System.Drawing.Point(302, 123);
            this.percWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.percWin.Name = "percWin";
            this.percWin.Size = new System.Drawing.Size(44, 20);
            this.percWin.TabIndex = 398;
            this.percWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // agilityWin
            // 
            this.agilityWin.Location = new System.Drawing.Point(302, 97);
            this.agilityWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.agilityWin.Name = "agilityWin";
            this.agilityWin.Size = new System.Drawing.Size(44, 20);
            this.agilityWin.TabIndex = 397;
            this.agilityWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // diploWin
            // 
            this.diploWin.Location = new System.Drawing.Point(302, 72);
            this.diploWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.diploWin.Name = "diploWin";
            this.diploWin.Size = new System.Drawing.Size(44, 20);
            this.diploWin.TabIndex = 396;
            this.diploWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // tacticsWin
            // 
            this.tacticsWin.Location = new System.Drawing.Point(302, 46);
            this.tacticsWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tacticsWin.Name = "tacticsWin";
            this.tacticsWin.Size = new System.Drawing.Size(44, 20);
            this.tacticsWin.TabIndex = 395;
            this.tacticsWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // strengthLabelW
            // 
            this.strengthLabelW.AutoSize = true;
            this.strengthLabelW.Location = new System.Drawing.Point(221, 226);
            this.strengthLabelW.Name = "strengthLabelW";
            this.strengthLabelW.Size = new System.Drawing.Size(45, 13);
            this.strengthLabelW.TabIndex = 394;
            this.strengthLabelW.Text = "strength";
            // 
            // knowLabelW
            // 
            this.knowLabelW.AutoSize = true;
            this.knowLabelW.Location = new System.Drawing.Point(222, 201);
            this.knowLabelW.Name = "knowLabelW";
            this.knowLabelW.Size = new System.Drawing.Size(59, 13);
            this.knowLabelW.TabIndex = 393;
            this.knowLabelW.Text = "knowledge";
            // 
            // markLabelW
            // 
            this.markLabelW.AutoSize = true;
            this.markLabelW.Location = new System.Drawing.Point(222, 176);
            this.markLabelW.Name = "markLabelW";
            this.markLabelW.Size = new System.Drawing.Size(74, 13);
            this.markLabelW.TabIndex = 392;
            this.markLabelW.Text = "marksmanship";
            // 
            // loyalLabelW
            // 
            this.loyalLabelW.AutoSize = true;
            this.loyalLabelW.Location = new System.Drawing.Point(222, 149);
            this.loyalLabelW.Name = "loyalLabelW";
            this.loyalLabelW.Size = new System.Drawing.Size(36, 13);
            this.loyalLabelW.TabIndex = 391;
            this.loyalLabelW.Text = "loyalty";
            // 
            // percLabelW
            // 
            this.percLabelW.AutoSize = true;
            this.percLabelW.Location = new System.Drawing.Point(221, 123);
            this.percLabelW.Name = "percLabelW";
            this.percLabelW.Size = new System.Drawing.Size(57, 13);
            this.percLabelW.TabIndex = 390;
            this.percLabelW.Text = "perception";
            // 
            // agilityLabelW
            // 
            this.agilityLabelW.AutoSize = true;
            this.agilityLabelW.Location = new System.Drawing.Point(220, 99);
            this.agilityLabelW.Name = "agilityLabelW";
            this.agilityLabelW.Size = new System.Drawing.Size(33, 13);
            this.agilityLabelW.TabIndex = 389;
            this.agilityLabelW.Text = "agility";
            // 
            // diploLabelW
            // 
            this.diploLabelW.AutoSize = true;
            this.diploLabelW.Location = new System.Drawing.Point(220, 73);
            this.diploLabelW.Name = "diploLabelW";
            this.diploLabelW.Size = new System.Drawing.Size(54, 13);
            this.diploLabelW.TabIndex = 388;
            this.diploLabelW.Text = "diplomacy";
            // 
            // tacticsLabelW
            // 
            this.tacticsLabelW.AutoSize = true;
            this.tacticsLabelW.Location = new System.Drawing.Point(220, 46);
            this.tacticsLabelW.Name = "tacticsLabelW";
            this.tacticsLabelW.Size = new System.Drawing.Size(38, 13);
            this.tacticsLabelW.TabIndex = 387;
            this.tacticsLabelW.Text = "tactics";
            // 
            // foodWin
            // 
            this.foodWin.Location = new System.Drawing.Point(122, 226);
            this.foodWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.foodWin.Name = "foodWin";
            this.foodWin.Size = new System.Drawing.Size(44, 20);
            this.foodWin.TabIndex = 386;
            this.foodWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // staminaWin
            // 
            this.staminaWin.Location = new System.Drawing.Point(122, 201);
            this.staminaWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.staminaWin.Name = "staminaWin";
            this.staminaWin.Size = new System.Drawing.Size(44, 20);
            this.staminaWin.TabIndex = 385;
            this.staminaWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // moraleWin
            // 
            this.moraleWin.Location = new System.Drawing.Point(122, 175);
            this.moraleWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.moraleWin.Name = "moraleWin";
            this.moraleWin.Size = new System.Drawing.Size(44, 20);
            this.moraleWin.TabIndex = 384;
            this.moraleWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // valueWin
            // 
            this.valueWin.Location = new System.Drawing.Point(122, 149);
            this.valueWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.valueWin.Name = "valueWin";
            this.valueWin.Size = new System.Drawing.Size(44, 20);
            this.valueWin.TabIndex = 383;
            this.valueWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // packWin
            // 
            this.packWin.Location = new System.Drawing.Point(122, 123);
            this.packWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.packWin.Name = "packWin";
            this.packWin.Size = new System.Drawing.Size(44, 20);
            this.packWin.TabIndex = 382;
            this.packWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // ammoWin
            // 
            this.ammoWin.Location = new System.Drawing.Point(122, 97);
            this.ammoWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ammoWin.Name = "ammoWin";
            this.ammoWin.Size = new System.Drawing.Size(44, 20);
            this.ammoWin.TabIndex = 381;
            this.ammoWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // medWin
            // 
            this.medWin.Location = new System.Drawing.Point(122, 72);
            this.medWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.medWin.Name = "medWin";
            this.medWin.Size = new System.Drawing.Size(44, 20);
            this.medWin.TabIndex = 380;
            this.medWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // waterWin
            // 
            this.waterWin.Location = new System.Drawing.Point(122, 46);
            this.waterWin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.waterWin.Name = "waterWin";
            this.waterWin.Size = new System.Drawing.Size(44, 20);
            this.waterWin.TabIndex = 379;
            this.waterWin.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // foodLabelW
            // 
            this.foodLabelW.AutoSize = true;
            this.foodLabelW.Location = new System.Drawing.Point(22, 226);
            this.foodLabelW.Name = "foodLabelW";
            this.foodLabelW.Size = new System.Drawing.Size(28, 13);
            this.foodLabelW.TabIndex = 378;
            this.foodLabelW.Text = "food";
            // 
            // staminaLabelW
            // 
            this.staminaLabelW.AutoSize = true;
            this.staminaLabelW.Location = new System.Drawing.Point(22, 201);
            this.staminaLabelW.Name = "staminaLabelW";
            this.staminaLabelW.Size = new System.Drawing.Size(43, 13);
            this.staminaLabelW.TabIndex = 377;
            this.staminaLabelW.Text = "stamina";
            // 
            // moraleLabelW
            // 
            this.moraleLabelW.AutoSize = true;
            this.moraleLabelW.Location = new System.Drawing.Point(22, 175);
            this.moraleLabelW.Name = "moraleLabelW";
            this.moraleLabelW.Size = new System.Drawing.Size(38, 13);
            this.moraleLabelW.TabIndex = 376;
            this.moraleLabelW.Text = "morale";
            // 
            // valueLabelW
            // 
            this.valueLabelW.AutoSize = true;
            this.valueLabelW.Location = new System.Drawing.Point(22, 150);
            this.valueLabelW.Name = "valueLabelW";
            this.valueLabelW.Size = new System.Drawing.Size(52, 13);
            this.valueLabelW.TabIndex = 375;
            this.valueLabelW.Text = "valuables";
            // 
            // packLabelW
            // 
            this.packLabelW.AutoSize = true;
            this.packLabelW.Location = new System.Drawing.Point(22, 123);
            this.packLabelW.Name = "packLabelW";
            this.packLabelW.Size = new System.Drawing.Size(69, 13);
            this.packLabelW.TabIndex = 374;
            this.packLabelW.Text = "pack animals";
            // 
            // ammoLabelW
            // 
            this.ammoLabelW.AutoSize = true;
            this.ammoLabelW.Location = new System.Drawing.Point(22, 99);
            this.ammoLabelW.Name = "ammoLabelW";
            this.ammoLabelW.Size = new System.Drawing.Size(35, 13);
            this.ammoLabelW.TabIndex = 373;
            this.ammoLabelW.Text = "ammo";
            // 
            // medLabelW
            // 
            this.medLabelW.AutoSize = true;
            this.medLabelW.Location = new System.Drawing.Point(22, 73);
            this.medLabelW.Name = "medLabelW";
            this.medLabelW.Size = new System.Drawing.Size(49, 13);
            this.medLabelW.TabIndex = 372;
            this.medLabelW.Text = "medicine";
            // 
            // waterLabelW
            // 
            this.waterLabelW.AutoSize = true;
            this.waterLabelW.Location = new System.Drawing.Point(22, 48);
            this.waterLabelW.Name = "waterLabelW";
            this.waterLabelW.Size = new System.Drawing.Size(33, 13);
            this.waterLabelW.TabIndex = 371;
            this.waterLabelW.Text = "water";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(22, 6);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(29, 13);
            this.winLabel.TabIndex = 370;
            this.winLabel.Text = "Win";
            // 
            // loyalLabelR
            // 
            this.loyalLabelR.AutoSize = true;
            this.loyalLabelR.Enabled = false;
            this.loyalLabelR.Location = new System.Drawing.Point(694, 52);
            this.loyalLabelR.Name = "loyalLabelR";
            this.loyalLabelR.Size = new System.Drawing.Size(36, 13);
            this.loyalLabelR.TabIndex = 356;
            this.loyalLabelR.Text = "loyalty";
            this.loyalLabelR.Visible = false;
            // 
            // pnlReq
            // 
            this.pnlReq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlReq.Controls.Add(this.statLabelR);
            this.pnlReq.Controls.Add(this.amountLabelR);
            this.pnlReq.Controls.Add(this.foodReq);
            this.pnlReq.Controls.Add(this.staminaReq);
            this.pnlReq.Controls.Add(this.moraleReq);
            this.pnlReq.Controls.Add(this.valueReq);
            this.pnlReq.Controls.Add(this.packReq);
            this.pnlReq.Controls.Add(this.ammoReq);
            this.pnlReq.Controls.Add(this.medReq);
            this.pnlReq.Controls.Add(this.waterReq);
            this.pnlReq.Controls.Add(this.foodLabelR);
            this.pnlReq.Controls.Add(this.staminaLabelR);
            this.pnlReq.Controls.Add(this.moraleLabelR);
            this.pnlReq.Controls.Add(this.valueLabelR);
            this.pnlReq.Controls.Add(this.packLabelR);
            this.pnlReq.Controls.Add(this.ammoLabelR);
            this.pnlReq.Controls.Add(this.medLabelR);
            this.pnlReq.Controls.Add(this.waterLabelR);
            this.pnlReq.Controls.Add(this.reqLabel);
            this.pnlReq.Location = new System.Drawing.Point(303, 100);
            this.pnlReq.Name = "pnlReq";
            this.pnlReq.Size = new System.Drawing.Size(230, 262);
            this.pnlReq.TabIndex = 512;
            // 
            // statLabelR
            // 
            this.statLabelR.AutoSize = true;
            this.statLabelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabelR.Location = new System.Drawing.Point(22, 26);
            this.statLabelR.Name = "statLabelR";
            this.statLabelR.Size = new System.Drawing.Size(28, 13);
            this.statLabelR.TabIndex = 369;
            this.statLabelR.Text = "stat";
            // 
            // amountLabelR
            // 
            this.amountLabelR.AutoSize = true;
            this.amountLabelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabelR.Location = new System.Drawing.Point(120, 26);
            this.amountLabelR.Name = "amountLabelR";
            this.amountLabelR.Size = new System.Drawing.Size(48, 13);
            this.amountLabelR.TabIndex = 368;
            this.amountLabelR.Text = "amount";
            // 
            // foodReq
            // 
            this.foodReq.Location = new System.Drawing.Point(122, 226);
            this.foodReq.Name = "foodReq";
            this.foodReq.Size = new System.Drawing.Size(44, 20);
            this.foodReq.TabIndex = 351;
            this.foodReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // staminaReq
            // 
            this.staminaReq.Location = new System.Drawing.Point(122, 201);
            this.staminaReq.Name = "staminaReq";
            this.staminaReq.Size = new System.Drawing.Size(44, 20);
            this.staminaReq.TabIndex = 350;
            this.staminaReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // moraleReq
            // 
            this.moraleReq.Location = new System.Drawing.Point(122, 175);
            this.moraleReq.Name = "moraleReq";
            this.moraleReq.Size = new System.Drawing.Size(44, 20);
            this.moraleReq.TabIndex = 349;
            this.moraleReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // valueReq
            // 
            this.valueReq.Location = new System.Drawing.Point(122, 149);
            this.valueReq.Name = "valueReq";
            this.valueReq.Size = new System.Drawing.Size(44, 20);
            this.valueReq.TabIndex = 348;
            this.valueReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // packReq
            // 
            this.packReq.Location = new System.Drawing.Point(122, 123);
            this.packReq.Name = "packReq";
            this.packReq.Size = new System.Drawing.Size(44, 20);
            this.packReq.TabIndex = 347;
            this.packReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // ammoReq
            // 
            this.ammoReq.Location = new System.Drawing.Point(122, 97);
            this.ammoReq.Name = "ammoReq";
            this.ammoReq.Size = new System.Drawing.Size(44, 20);
            this.ammoReq.TabIndex = 346;
            this.ammoReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // medReq
            // 
            this.medReq.Location = new System.Drawing.Point(122, 72);
            this.medReq.Name = "medReq";
            this.medReq.Size = new System.Drawing.Size(44, 20);
            this.medReq.TabIndex = 345;
            this.medReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // waterReq
            // 
            this.waterReq.Location = new System.Drawing.Point(122, 46);
            this.waterReq.Name = "waterReq";
            this.waterReq.Size = new System.Drawing.Size(44, 20);
            this.waterReq.TabIndex = 344;
            this.waterReq.ValueChanged += new System.EventHandler(this.waterCost_ValueChanged);
            // 
            // foodLabelR
            // 
            this.foodLabelR.AutoSize = true;
            this.foodLabelR.Location = new System.Drawing.Point(22, 228);
            this.foodLabelR.Name = "foodLabelR";
            this.foodLabelR.Size = new System.Drawing.Size(28, 13);
            this.foodLabelR.TabIndex = 343;
            this.foodLabelR.Text = "food";
            // 
            // staminaLabelR
            // 
            this.staminaLabelR.AutoSize = true;
            this.staminaLabelR.Location = new System.Drawing.Point(22, 203);
            this.staminaLabelR.Name = "staminaLabelR";
            this.staminaLabelR.Size = new System.Drawing.Size(43, 13);
            this.staminaLabelR.TabIndex = 342;
            this.staminaLabelR.Text = "stamina";
            // 
            // moraleLabelR
            // 
            this.moraleLabelR.AutoSize = true;
            this.moraleLabelR.Location = new System.Drawing.Point(22, 177);
            this.moraleLabelR.Name = "moraleLabelR";
            this.moraleLabelR.Size = new System.Drawing.Size(38, 13);
            this.moraleLabelR.TabIndex = 341;
            this.moraleLabelR.Text = "morale";
            // 
            // valueLabelR
            // 
            this.valueLabelR.AutoSize = true;
            this.valueLabelR.Location = new System.Drawing.Point(22, 152);
            this.valueLabelR.Name = "valueLabelR";
            this.valueLabelR.Size = new System.Drawing.Size(52, 13);
            this.valueLabelR.TabIndex = 340;
            this.valueLabelR.Text = "valuables";
            // 
            // packLabelR
            // 
            this.packLabelR.AutoSize = true;
            this.packLabelR.Location = new System.Drawing.Point(22, 125);
            this.packLabelR.Name = "packLabelR";
            this.packLabelR.Size = new System.Drawing.Size(69, 13);
            this.packLabelR.TabIndex = 339;
            this.packLabelR.Text = "pack animals";
            // 
            // ammoLabelR
            // 
            this.ammoLabelR.AutoSize = true;
            this.ammoLabelR.Location = new System.Drawing.Point(22, 101);
            this.ammoLabelR.Name = "ammoLabelR";
            this.ammoLabelR.Size = new System.Drawing.Size(35, 13);
            this.ammoLabelR.TabIndex = 338;
            this.ammoLabelR.Text = "ammo";
            // 
            // medLabelR
            // 
            this.medLabelR.AutoSize = true;
            this.medLabelR.Location = new System.Drawing.Point(22, 75);
            this.medLabelR.Name = "medLabelR";
            this.medLabelR.Size = new System.Drawing.Size(49, 13);
            this.medLabelR.TabIndex = 337;
            this.medLabelR.Text = "medicine";
            // 
            // waterLabelR
            // 
            this.waterLabelR.AutoSize = true;
            this.waterLabelR.Location = new System.Drawing.Point(22, 48);
            this.waterLabelR.Name = "waterLabelR";
            this.waterLabelR.Size = new System.Drawing.Size(33, 13);
            this.waterLabelR.TabIndex = 336;
            this.waterLabelR.Text = "water";
            // 
            // reqLabel
            // 
            this.reqLabel.AutoSize = true;
            this.reqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqLabel.Location = new System.Drawing.Point(22, 6);
            this.reqLabel.Name = "reqLabel";
            this.reqLabel.Size = new System.Drawing.Size(84, 13);
            this.reqLabel.TabIndex = 335;
            this.reqLabel.Text = "Requirements";
            // 
            // percLabelR
            // 
            this.percLabelR.AutoSize = true;
            this.percLabelR.Enabled = false;
            this.percLabelR.Location = new System.Drawing.Point(696, 56);
            this.percLabelR.Name = "percLabelR";
            this.percLabelR.Size = new System.Drawing.Size(57, 13);
            this.percLabelR.TabIndex = 355;
            this.percLabelR.Text = "perception";
            this.percLabelR.Visible = false;
            // 
            // pnlMod
            // 
            this.pnlMod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMod.Controls.Add(this.statMLabel);
            this.pnlMod.Controls.Add(this.applyMLabel);
            this.pnlMod.Controls.Add(this.amountMLabel);
            this.pnlMod.Controls.Add(this.strengthModB);
            this.pnlMod.Controls.Add(this.knowModB);
            this.pnlMod.Controls.Add(this.marksModB);
            this.pnlMod.Controls.Add(this.loyalModB);
            this.pnlMod.Controls.Add(this.percModB);
            this.pnlMod.Controls.Add(this.agilityModB);
            this.pnlMod.Controls.Add(this.diploModB);
            this.pnlMod.Controls.Add(this.tacticsModB);
            this.pnlMod.Controls.Add(this.strengthMod);
            this.pnlMod.Controls.Add(this.knowMod);
            this.pnlMod.Controls.Add(this.markMod);
            this.pnlMod.Controls.Add(this.loyalMod);
            this.pnlMod.Controls.Add(this.percMod);
            this.pnlMod.Controls.Add(this.agilityMod);
            this.pnlMod.Controls.Add(this.diploMod);
            this.pnlMod.Controls.Add(this.tacticsMod);
            this.pnlMod.Controls.Add(this.strengthLabel);
            this.pnlMod.Controls.Add(this.knowLabel);
            this.pnlMod.Controls.Add(this.markLabel);
            this.pnlMod.Controls.Add(this.loyalLabel);
            this.pnlMod.Controls.Add(this.percLabel);
            this.pnlMod.Controls.Add(this.agilityLabel);
            this.pnlMod.Controls.Add(this.diploLabel);
            this.pnlMod.Controls.Add(this.tacticsLabel);
            this.pnlMod.Controls.Add(this.modLabel);
            this.pnlMod.Location = new System.Drawing.Point(13, 100);
            this.pnlMod.Name = "pnlMod";
            this.pnlMod.Size = new System.Drawing.Size(230, 262);
            this.pnlMod.TabIndex = 511;
            // 
            // statMLabel
            // 
            this.statMLabel.AutoSize = true;
            this.statMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statMLabel.Location = new System.Drawing.Point(18, 30);
            this.statMLabel.Name = "statMLabel";
            this.statMLabel.Size = new System.Drawing.Size(28, 13);
            this.statMLabel.TabIndex = 334;
            this.statMLabel.Text = "stat";
            // 
            // applyMLabel
            // 
            this.applyMLabel.AutoSize = true;
            this.applyMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyMLabel.Location = new System.Drawing.Point(150, 30);
            this.applyMLabel.Name = "applyMLabel";
            this.applyMLabel.Size = new System.Drawing.Size(44, 13);
            this.applyMLabel.TabIndex = 333;
            this.applyMLabel.Text = "apply?";
            // 
            // amountMLabel
            // 
            this.amountMLabel.AutoSize = true;
            this.amountMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountMLabel.Location = new System.Drawing.Point(96, 30);
            this.amountMLabel.Name = "amountMLabel";
            this.amountMLabel.Size = new System.Drawing.Size(48, 13);
            this.amountMLabel.TabIndex = 332;
            this.amountMLabel.Text = "amount";
            // 
            // strengthModB
            // 
            this.strengthModB.AutoSize = true;
            this.strengthModB.Location = new System.Drawing.Point(165, 233);
            this.strengthModB.Name = "strengthModB";
            this.strengthModB.Size = new System.Drawing.Size(15, 14);
            this.strengthModB.TabIndex = 331;
            this.strengthModB.UseVisualStyleBackColor = true;
            this.strengthModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // knowModB
            // 
            this.knowModB.AutoSize = true;
            this.knowModB.Location = new System.Drawing.Point(165, 208);
            this.knowModB.Name = "knowModB";
            this.knowModB.Size = new System.Drawing.Size(15, 14);
            this.knowModB.TabIndex = 330;
            this.knowModB.UseVisualStyleBackColor = true;
            this.knowModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // marksModB
            // 
            this.marksModB.AutoSize = true;
            this.marksModB.Location = new System.Drawing.Point(165, 183);
            this.marksModB.Name = "marksModB";
            this.marksModB.Size = new System.Drawing.Size(15, 14);
            this.marksModB.TabIndex = 329;
            this.marksModB.UseVisualStyleBackColor = true;
            this.marksModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // loyalModB
            // 
            this.loyalModB.AutoSize = true;
            this.loyalModB.Location = new System.Drawing.Point(165, 156);
            this.loyalModB.Name = "loyalModB";
            this.loyalModB.Size = new System.Drawing.Size(15, 14);
            this.loyalModB.TabIndex = 328;
            this.loyalModB.UseVisualStyleBackColor = true;
            this.loyalModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // percModB
            // 
            this.percModB.AutoSize = true;
            this.percModB.Location = new System.Drawing.Point(165, 130);
            this.percModB.Name = "percModB";
            this.percModB.Size = new System.Drawing.Size(15, 14);
            this.percModB.TabIndex = 327;
            this.percModB.UseVisualStyleBackColor = true;
            this.percModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // agilityModB
            // 
            this.agilityModB.AutoSize = true;
            this.agilityModB.Location = new System.Drawing.Point(165, 106);
            this.agilityModB.Name = "agilityModB";
            this.agilityModB.Size = new System.Drawing.Size(15, 14);
            this.agilityModB.TabIndex = 326;
            this.agilityModB.UseVisualStyleBackColor = true;
            this.agilityModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // diploModB
            // 
            this.diploModB.AutoSize = true;
            this.diploModB.Location = new System.Drawing.Point(165, 79);
            this.diploModB.Name = "diploModB";
            this.diploModB.Size = new System.Drawing.Size(15, 14);
            this.diploModB.TabIndex = 325;
            this.diploModB.UseVisualStyleBackColor = true;
            this.diploModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // tacticsModB
            // 
            this.tacticsModB.AutoSize = true;
            this.tacticsModB.Location = new System.Drawing.Point(165, 53);
            this.tacticsModB.Name = "tacticsModB";
            this.tacticsModB.Size = new System.Drawing.Size(15, 14);
            this.tacticsModB.TabIndex = 324;
            this.tacticsModB.UseVisualStyleBackColor = true;
            this.tacticsModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // strengthMod
            // 
            this.strengthMod.Location = new System.Drawing.Point(98, 231);
            this.strengthMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.strengthMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.strengthMod.Name = "strengthMod";
            this.strengthMod.Size = new System.Drawing.Size(44, 20);
            this.strengthMod.TabIndex = 323;
            this.strengthMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // knowMod
            // 
            this.knowMod.Location = new System.Drawing.Point(98, 206);
            this.knowMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.knowMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.knowMod.Name = "knowMod";
            this.knowMod.Size = new System.Drawing.Size(44, 20);
            this.knowMod.TabIndex = 322;
            this.knowMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // markMod
            // 
            this.markMod.Location = new System.Drawing.Point(98, 180);
            this.markMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.markMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.markMod.Name = "markMod";
            this.markMod.Size = new System.Drawing.Size(44, 20);
            this.markMod.TabIndex = 321;
            this.markMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // loyalMod
            // 
            this.loyalMod.Location = new System.Drawing.Point(98, 154);
            this.loyalMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyalMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.loyalMod.Name = "loyalMod";
            this.loyalMod.Size = new System.Drawing.Size(44, 20);
            this.loyalMod.TabIndex = 320;
            this.loyalMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // percMod
            // 
            this.percMod.Location = new System.Drawing.Point(98, 128);
            this.percMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.percMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.percMod.Name = "percMod";
            this.percMod.Size = new System.Drawing.Size(44, 20);
            this.percMod.TabIndex = 319;
            this.percMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // agilityMod
            // 
            this.agilityMod.Location = new System.Drawing.Point(98, 102);
            this.agilityMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.agilityMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.agilityMod.Name = "agilityMod";
            this.agilityMod.Size = new System.Drawing.Size(44, 20);
            this.agilityMod.TabIndex = 318;
            this.agilityMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // diploMod
            // 
            this.diploMod.Location = new System.Drawing.Point(98, 77);
            this.diploMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.diploMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.diploMod.Name = "diploMod";
            this.diploMod.Size = new System.Drawing.Size(44, 20);
            this.diploMod.TabIndex = 317;
            this.diploMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // tacticsMod
            // 
            this.tacticsMod.Location = new System.Drawing.Point(98, 51);
            this.tacticsMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.tacticsMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.tacticsMod.Name = "tacticsMod";
            this.tacticsMod.Size = new System.Drawing.Size(44, 20);
            this.tacticsMod.TabIndex = 316;
            this.tacticsMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(18, 233);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(45, 13);
            this.strengthLabel.TabIndex = 315;
            this.strengthLabel.Text = "strength";
            // 
            // knowLabel
            // 
            this.knowLabel.AutoSize = true;
            this.knowLabel.Location = new System.Drawing.Point(18, 208);
            this.knowLabel.Name = "knowLabel";
            this.knowLabel.Size = new System.Drawing.Size(59, 13);
            this.knowLabel.TabIndex = 314;
            this.knowLabel.Text = "knowledge";
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Location = new System.Drawing.Point(18, 183);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(74, 13);
            this.markLabel.TabIndex = 313;
            this.markLabel.Text = "marksmanship";
            // 
            // loyalLabel
            // 
            this.loyalLabel.AutoSize = true;
            this.loyalLabel.Location = new System.Drawing.Point(18, 156);
            this.loyalLabel.Name = "loyalLabel";
            this.loyalLabel.Size = new System.Drawing.Size(36, 13);
            this.loyalLabel.TabIndex = 312;
            this.loyalLabel.Text = "loyalty";
            // 
            // percLabel
            // 
            this.percLabel.AutoSize = true;
            this.percLabel.Location = new System.Drawing.Point(18, 130);
            this.percLabel.Name = "percLabel";
            this.percLabel.Size = new System.Drawing.Size(57, 13);
            this.percLabel.TabIndex = 311;
            this.percLabel.Text = "perception";
            // 
            // agilityLabel
            // 
            this.agilityLabel.AutoSize = true;
            this.agilityLabel.Location = new System.Drawing.Point(18, 106);
            this.agilityLabel.Name = "agilityLabel";
            this.agilityLabel.Size = new System.Drawing.Size(33, 13);
            this.agilityLabel.TabIndex = 310;
            this.agilityLabel.Text = "agility";
            // 
            // diploLabel
            // 
            this.diploLabel.AutoSize = true;
            this.diploLabel.Location = new System.Drawing.Point(18, 80);
            this.diploLabel.Name = "diploLabel";
            this.diploLabel.Size = new System.Drawing.Size(54, 13);
            this.diploLabel.TabIndex = 309;
            this.diploLabel.Text = "diplomacy";
            // 
            // tacticsLabel
            // 
            this.tacticsLabel.AutoSize = true;
            this.tacticsLabel.Location = new System.Drawing.Point(18, 53);
            this.tacticsLabel.Name = "tacticsLabel";
            this.tacticsLabel.Size = new System.Drawing.Size(38, 13);
            this.tacticsLabel.TabIndex = 308;
            this.tacticsLabel.Text = "tactics";
            // 
            // modLabel
            // 
            this.modLabel.AutoSize = true;
            this.modLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modLabel.Location = new System.Drawing.Point(18, 6);
            this.modLabel.Name = "modLabel";
            this.modLabel.Size = new System.Drawing.Size(55, 13);
            this.modLabel.TabIndex = 283;
            this.modLabel.Text = "Modifers";
            // 
            // agilityLabelR
            // 
            this.agilityLabelR.AutoSize = true;
            this.agilityLabelR.Enabled = false;
            this.agilityLabelR.Location = new System.Drawing.Point(694, 54);
            this.agilityLabelR.Name = "agilityLabelR";
            this.agilityLabelR.Size = new System.Drawing.Size(33, 13);
            this.agilityLabelR.TabIndex = 354;
            this.agilityLabelR.Text = "agility";
            this.agilityLabelR.Visible = false;
            // 
            // lblCurrentResponse
            // 
            this.lblCurrentResponse.AutoSize = true;
            this.lblCurrentResponse.Location = new System.Drawing.Point(10, 15);
            this.lblCurrentResponse.Name = "lblCurrentResponse";
            this.lblCurrentResponse.Size = new System.Drawing.Size(132, 13);
            this.lblCurrentResponse.TabIndex = 498;
            this.lblCurrentResponse.Text = "Current Response To Edit:";
            // 
            // diploLabelR
            // 
            this.diploLabelR.AutoSize = true;
            this.diploLabelR.Enabled = false;
            this.diploLabelR.Location = new System.Drawing.Point(694, 54);
            this.diploLabelR.Name = "diploLabelR";
            this.diploLabelR.Size = new System.Drawing.Size(54, 13);
            this.diploLabelR.TabIndex = 353;
            this.diploLabelR.Text = "diplomacy";
            this.diploLabelR.Visible = false;
            // 
            // comboBoxRespToEdit
            // 
            this.comboBoxRespToEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRespToEdit.FormattingEnabled = true;
            this.comboBoxRespToEdit.Items.AddRange(new object[] {
            "Event 1",
            "Event 2",
            "Event 3"});
            this.comboBoxRespToEdit.Location = new System.Drawing.Point(148, 12);
            this.comboBoxRespToEdit.Name = "comboBoxRespToEdit";
            this.comboBoxRespToEdit.Size = new System.Drawing.Size(675, 21);
            this.comboBoxRespToEdit.TabIndex = 497;
            this.comboBoxRespToEdit.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEvent_SelectedIndexChanged);
            // 
            // tacticsLabelR
            // 
            this.tacticsLabelR.AutoSize = true;
            this.tacticsLabelR.Enabled = false;
            this.tacticsLabelR.Location = new System.Drawing.Point(695, 52);
            this.tacticsLabelR.Name = "tacticsLabelR";
            this.tacticsLabelR.Size = new System.Drawing.Size(38, 13);
            this.tacticsLabelR.TabIndex = 352;
            this.tacticsLabelR.Text = "tactics";
            this.tacticsLabelR.Visible = false;
            // 
            // waterLabel
            // 
            this.waterLabel.AutoSize = true;
            this.waterLabel.Enabled = false;
            this.waterLabel.Location = new System.Drawing.Point(500, 49);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(33, 13);
            this.waterLabel.TabIndex = 284;
            this.waterLabel.Text = "water";
            this.waterLabel.Visible = false;
            // 
            // waterMod
            // 
            this.waterMod.Enabled = false;
            this.waterMod.Location = new System.Drawing.Point(591, 47);
            this.waterMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.waterMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.waterMod.Name = "waterMod";
            this.waterMod.Size = new System.Drawing.Size(44, 20);
            this.waterMod.TabIndex = 292;
            this.waterMod.Visible = false;
            this.waterMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // medLabel
            // 
            this.medLabel.AutoSize = true;
            this.medLabel.Enabled = false;
            this.medLabel.Location = new System.Drawing.Point(500, 49);
            this.medLabel.Name = "medLabel";
            this.medLabel.Size = new System.Drawing.Size(49, 13);
            this.medLabel.TabIndex = 285;
            this.medLabel.Text = "medicine";
            this.medLabel.Visible = false;
            // 
            // staminaMod
            // 
            this.staminaMod.Enabled = false;
            this.staminaMod.Location = new System.Drawing.Point(591, 50);
            this.staminaMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.staminaMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.staminaMod.Name = "staminaMod";
            this.staminaMod.Size = new System.Drawing.Size(44, 20);
            this.staminaMod.TabIndex = 298;
            this.staminaMod.Visible = false;
            this.staminaMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // valueModB
            // 
            this.valueModB.AutoSize = true;
            this.valueModB.Enabled = false;
            this.valueModB.Location = new System.Drawing.Point(646, 47);
            this.valueModB.Name = "valueModB";
            this.valueModB.Size = new System.Drawing.Size(15, 14);
            this.valueModB.TabIndex = 303;
            this.valueModB.UseVisualStyleBackColor = true;
            this.valueModB.Visible = false;
            this.valueModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // ammoLabel
            // 
            this.ammoLabel.AutoSize = true;
            this.ammoLabel.Enabled = false;
            this.ammoLabel.Location = new System.Drawing.Point(501, 49);
            this.ammoLabel.Name = "ammoLabel";
            this.ammoLabel.Size = new System.Drawing.Size(35, 13);
            this.ammoLabel.TabIndex = 286;
            this.ammoLabel.Text = "ammo";
            this.ammoLabel.Visible = false;
            // 
            // vModB
            // 
            this.vModB.AutoSize = true;
            this.vModB.Enabled = false;
            this.vModB.Location = new System.Drawing.Point(647, 49);
            this.vModB.Name = "vModB";
            this.vModB.Size = new System.Drawing.Size(15, 14);
            this.vModB.TabIndex = 304;
            this.vModB.UseVisualStyleBackColor = true;
            this.vModB.Visible = false;
            this.vModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // foodMod
            // 
            this.foodMod.Enabled = false;
            this.foodMod.Location = new System.Drawing.Point(594, 46);
            this.foodMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.foodMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.foodMod.Name = "foodMod";
            this.foodMod.Size = new System.Drawing.Size(44, 20);
            this.foodMod.TabIndex = 299;
            this.foodMod.Visible = false;
            this.foodMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // packLabel
            // 
            this.packLabel.AutoSize = true;
            this.packLabel.Enabled = false;
            this.packLabel.Location = new System.Drawing.Point(500, 47);
            this.packLabel.Name = "packLabel";
            this.packLabel.Size = new System.Drawing.Size(69, 13);
            this.packLabel.TabIndex = 287;
            this.packLabel.Text = "pack animals";
            this.packLabel.Visible = false;
            // 
            // moraleMod
            // 
            this.moraleMod.Enabled = false;
            this.moraleMod.Location = new System.Drawing.Point(593, 48);
            this.moraleMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.moraleMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.moraleMod.Name = "moraleMod";
            this.moraleMod.Size = new System.Drawing.Size(44, 20);
            this.moraleMod.TabIndex = 297;
            this.moraleMod.Visible = false;
            this.moraleMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // ammoModB
            // 
            this.ammoModB.AutoSize = true;
            this.ammoModB.Enabled = false;
            this.ammoModB.Location = new System.Drawing.Point(647, 49);
            this.ammoModB.Name = "ammoModB";
            this.ammoModB.Size = new System.Drawing.Size(15, 14);
            this.ammoModB.TabIndex = 302;
            this.ammoModB.UseVisualStyleBackColor = true;
            this.ammoModB.Visible = false;
            this.ammoModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Enabled = false;
            this.valueLabel.Location = new System.Drawing.Point(501, 50);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(52, 13);
            this.valueLabel.TabIndex = 288;
            this.valueLabel.Text = "valuables";
            this.valueLabel.Visible = false;
            // 
            // moraleModB
            // 
            this.moraleModB.AutoSize = true;
            this.moraleModB.Enabled = false;
            this.moraleModB.Location = new System.Drawing.Point(648, 51);
            this.moraleModB.Name = "moraleModB";
            this.moraleModB.Size = new System.Drawing.Size(15, 14);
            this.moraleModB.TabIndex = 305;
            this.moraleModB.UseVisualStyleBackColor = true;
            this.moraleModB.Visible = false;
            this.moraleModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // waterModB
            // 
            this.waterModB.AutoSize = true;
            this.waterModB.Enabled = false;
            this.waterModB.Location = new System.Drawing.Point(646, 49);
            this.waterModB.Name = "waterModB";
            this.waterModB.Size = new System.Drawing.Size(15, 14);
            this.waterModB.TabIndex = 300;
            this.waterModB.UseVisualStyleBackColor = true;
            this.waterModB.Visible = false;
            this.waterModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // moraleLabel
            // 
            this.moraleLabel.AutoSize = true;
            this.moraleLabel.Enabled = false;
            this.moraleLabel.Location = new System.Drawing.Point(502, 50);
            this.moraleLabel.Name = "moraleLabel";
            this.moraleLabel.Size = new System.Drawing.Size(38, 13);
            this.moraleLabel.TabIndex = 289;
            this.moraleLabel.Text = "morale";
            this.moraleLabel.Visible = false;
            // 
            // valueMod
            // 
            this.valueMod.Enabled = false;
            this.valueMod.Location = new System.Drawing.Point(592, 47);
            this.valueMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.valueMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.valueMod.Name = "valueMod";
            this.valueMod.Size = new System.Drawing.Size(44, 20);
            this.valueMod.TabIndex = 296;
            this.valueMod.Visible = false;
            this.valueMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // medModB
            // 
            this.medModB.AutoSize = true;
            this.medModB.Enabled = false;
            this.medModB.Location = new System.Drawing.Point(646, 49);
            this.medModB.Name = "medModB";
            this.medModB.Size = new System.Drawing.Size(15, 14);
            this.medModB.TabIndex = 301;
            this.medModB.UseVisualStyleBackColor = true;
            this.medModB.Visible = false;
            this.medModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // stamLabel
            // 
            this.stamLabel.AutoSize = true;
            this.stamLabel.Enabled = false;
            this.stamLabel.Location = new System.Drawing.Point(500, 52);
            this.stamLabel.Name = "stamLabel";
            this.stamLabel.Size = new System.Drawing.Size(43, 13);
            this.stamLabel.TabIndex = 290;
            this.stamLabel.Text = "stamina";
            this.stamLabel.Visible = false;
            // 
            // staminaModB
            // 
            this.staminaModB.AutoSize = true;
            this.staminaModB.Enabled = false;
            this.staminaModB.Location = new System.Drawing.Point(646, 52);
            this.staminaModB.Name = "staminaModB";
            this.staminaModB.Size = new System.Drawing.Size(15, 14);
            this.staminaModB.TabIndex = 306;
            this.staminaModB.UseVisualStyleBackColor = true;
            this.staminaModB.Visible = false;
            this.staminaModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // packMod
            // 
            this.packMod.Enabled = false;
            this.packMod.Location = new System.Drawing.Point(591, 45);
            this.packMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.packMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.packMod.Name = "packMod";
            this.packMod.Size = new System.Drawing.Size(44, 20);
            this.packMod.TabIndex = 295;
            this.packMod.Visible = false;
            this.packMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Enabled = false;
            this.foodLabel.Location = new System.Drawing.Point(503, 48);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(28, 13);
            this.foodLabel.TabIndex = 291;
            this.foodLabel.Text = "food";
            this.foodLabel.Visible = false;
            // 
            // foodModB
            // 
            this.foodModB.AutoSize = true;
            this.foodModB.Enabled = false;
            this.foodModB.Location = new System.Drawing.Point(649, 48);
            this.foodModB.Name = "foodModB";
            this.foodModB.Size = new System.Drawing.Size(15, 14);
            this.foodModB.TabIndex = 307;
            this.foodModB.UseVisualStyleBackColor = true;
            this.foodModB.Visible = false;
            this.foodModB.CheckedChanged += new System.EventHandler(this.waterModB_CheckedChanged);
            // 
            // ammoMod
            // 
            this.ammoMod.Enabled = false;
            this.ammoMod.Location = new System.Drawing.Point(592, 45);
            this.ammoMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ammoMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.ammoMod.Name = "ammoMod";
            this.ammoMod.Size = new System.Drawing.Size(44, 20);
            this.ammoMod.TabIndex = 294;
            this.ammoMod.Visible = false;
            this.ammoMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // medMod
            // 
            this.medMod.Enabled = false;
            this.medMod.Location = new System.Drawing.Point(591, 46);
            this.medMod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.medMod.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.medMod.Name = "medMod";
            this.medMod.Size = new System.Drawing.Size(44, 20);
            this.medMod.TabIndex = 293;
            this.medMod.Visible = false;
            this.medMod.ValueChanged += new System.EventHandler(this.waterMod_ValueChanged);
            // 
            // tabFinish
            // 
            this.tabFinish.Controls.Add(this.lblStatus);
            this.tabFinish.Controls.Add(this.btnSave);
            this.tabFinish.Controls.Add(this.btnBrowse);
            this.tabFinish.Controls.Add(this.txtFileLoc);
            this.tabFinish.Controls.Add(this.lblFileName);
            this.tabFinish.Location = new System.Drawing.Point(4, 22);
            this.tabFinish.Name = "tabFinish";
            this.tabFinish.Size = new System.Drawing.Size(856, 534);
            this.tabFinish.TabIndex = 4;
            this.tabFinish.Text = "Finish";
            this.tabFinish.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(8, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(759, 29);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Please enter a file name for your event.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(773, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(773, 68);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnSaveBrowse_Click);
            // 
            // txtFileLoc
            // 
            this.txtFileLoc.Location = new System.Drawing.Point(8, 68);
            this.txtFileLoc.Name = "txtFileLoc";
            this.txtFileLoc.Size = new System.Drawing.Size(759, 20);
            this.txtFileLoc.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(8, 52);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(89, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Output File Name";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text Files|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text File|*.txt";
            // 
            // openFileDialog_LoadEvent
            // 
            this.openFileDialog_LoadEvent.FileName = "*.txt";
            this.openFileDialog_LoadEvent.Filter = "Text Files|*.txt";
            this.openFileDialog_LoadEvent.Title = "Load Event";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Event Creator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tabMain.ResumeLayout(false);
            this.tabGeneralInfo.ResumeLayout(false);
            this.tabGeneralInfo.PerformLayout();
            this.Advice.ResumeLayout(false);
            this.Advice.PerformLayout();
            this.tabRespOpts.ResumeLayout(false);
            this.tabRespOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeNumBox)).EndInit();
            this.tabEditRespOpts.ResumeLayout(false);
            this.tabEditRespOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityReq)).EndInit();
            this.pnlOther.ResumeLayout(false);
            this.pnlOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diploReq)).EndInit();
            this.pnlResText.ResumeLayout(false);
            this.pnlResText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsReq)).EndInit();
            this.pnlCost.ResumeLayout(false);
            this.pnlCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterCost)).EndInit();
            this.pnlLose.ResumeLayout(false);
            this.pnlLose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterLose)).EndInit();
            this.pnlWin.ResumeLayout(false);
            this.pnlWin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterWin)).EndInit();
            this.pnlReq.ResumeLayout(false);
            this.pnlReq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterReq)).EndInit();
            this.pnlMod.ResumeLayout(false);
            this.pnlMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacticsMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medMod)).EndInit();
            this.tabFinish.ResumeLayout(false);
            this.tabFinish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage Advice;
        private System.Windows.Forms.TabPage tabEditRespOpts;
        private System.Windows.Forms.CheckBox chkHunter;
        private System.Windows.Forms.TextBox txtHunter;
        private System.Windows.Forms.Label lblHunter;
        private System.Windows.Forms.Label CharacterAdvice;
        private System.Windows.Forms.Label CharacterTtype;
        private System.Windows.Forms.Label lblMercenary;
        private System.Windows.Forms.Label IsAdviceUseful;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Label lblExplorer;
        private System.Windows.Forms.Label lblMissionary;
        private System.Windows.Forms.Label lblNaturalist;
        private System.Windows.Forms.CheckBox chkGuide;
        private System.Windows.Forms.CheckBox chkNaturalist;
        private System.Windows.Forms.CheckBox chkMissionary;
        private System.Windows.Forms.CheckBox chkExplorer;
        private System.Windows.Forms.CheckBox chkMercenary;
        private System.Windows.Forms.TextBox txtExplorer;
        private System.Windows.Forms.TextBox txtGuide;
        private System.Windows.Forms.TextBox txtMissionary;
        private System.Windows.Forms.TextBox txtNaturalist;
        private System.Windows.Forms.TextBox txtMercenary;
        private System.Windows.Forms.TabPage tabGeneralInfo;
        private System.Windows.Forms.TabPage tabRespOpts;
        private System.Windows.Forms.TabPage tabFinish;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileLoc;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox selectplayerB;
        private System.Windows.Forms.Label introDescLabel;
        private System.Windows.Forms.TextBox introDescInput;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.ComboBox frequencyInput;
        private System.Windows.Forms.CheckedListBox andClassInput;
        private System.Windows.Forms.Label reqClassLabel;
        private System.Windows.Forms.Label possibleLocationsLabel;
        private System.Windows.Forms.CheckedListBox locationsInput;
        private System.Windows.Forms.ComboBox eventTypeInput;
        private System.Windows.Forms.Label eventTypeLabel;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.TextBox eventNameInput;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.Button browse2;
        private System.Windows.Forms.Button browse1;
        private System.Windows.Forms.TextBox loseFollowUp;
        private System.Windows.Forms.TextBox passFollowUp;
        private System.Windows.Forms.TextBox winFollowUp;
        private System.Windows.Forms.Label loseFollowUpLabel;
        private System.Windows.Forms.Label passFollowUpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label passTextLabel;
        private System.Windows.Forms.TextBox loseText;
        private System.Windows.Forms.Label loseTextLabel;
        private System.Windows.Forms.TextBox winText;
        private System.Windows.Forms.Label winTextLabel;
        private System.Windows.Forms.Label statLabelC;
        private System.Windows.Forms.NumericUpDown strengthCost;
        private System.Windows.Forms.NumericUpDown knowCost;
        private System.Windows.Forms.NumericUpDown marksCost;
        private System.Windows.Forms.NumericUpDown loyalCost;
        private System.Windows.Forms.NumericUpDown percCost;
        private System.Windows.Forms.NumericUpDown agilityCost;
        private System.Windows.Forms.NumericUpDown diploCost;
        private System.Windows.Forms.NumericUpDown tacticsCost;
        private System.Windows.Forms.Label strengthLabelC;
        private System.Windows.Forms.Label knowLabelC;
        private System.Windows.Forms.Label marksLabelC;
        private System.Windows.Forms.Label loyalCostC;
        private System.Windows.Forms.Label percLabelC;
        private System.Windows.Forms.Label agilityLabelC;
        private System.Windows.Forms.Label diploLabelC;
        private System.Windows.Forms.Label tacticsLabelC;
        private System.Windows.Forms.NumericUpDown foodCost;
        private System.Windows.Forms.NumericUpDown staminaCost;
        private System.Windows.Forms.NumericUpDown moraleCost;
        private System.Windows.Forms.NumericUpDown valueCost;
        private System.Windows.Forms.NumericUpDown packCost;
        private System.Windows.Forms.NumericUpDown ammoCost;
        private System.Windows.Forms.NumericUpDown medCost;
        private System.Windows.Forms.NumericUpDown waterCost;
        private System.Windows.Forms.Label foodLabelC;
        private System.Windows.Forms.Label staminaLabelC;
        private System.Windows.Forms.Label moraleLabelC;
        private System.Windows.Forms.Label valueLabelC;
        private System.Windows.Forms.Label packLabelC;
        private System.Windows.Forms.Label ammoLabelC;
        private System.Windows.Forms.Label medLabelC;
        private System.Windows.Forms.Label waterLabelC;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label subtractLabel;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label statLabelL;
        private System.Windows.Forms.Label amountLLabel;
        private System.Windows.Forms.NumericUpDown strengthLose;
        private System.Windows.Forms.NumericUpDown knowLose;
        private System.Windows.Forms.NumericUpDown markLose;
        private System.Windows.Forms.NumericUpDown loyalLose;
        private System.Windows.Forms.NumericUpDown percLose;
        private System.Windows.Forms.NumericUpDown agilityLose;
        private System.Windows.Forms.NumericUpDown diploLose;
        private System.Windows.Forms.NumericUpDown tacticsLose;
        private System.Windows.Forms.Label strengthLabelL;
        private System.Windows.Forms.Label knowLabelL;
        private System.Windows.Forms.Label marksLabelL;
        private System.Windows.Forms.Label loyalLabelL;
        private System.Windows.Forms.Label percLabelL;
        private System.Windows.Forms.Label agilityLabelL;
        private System.Windows.Forms.Label diploLabelL;
        private System.Windows.Forms.Label tacticsLabelL;
        private System.Windows.Forms.NumericUpDown foodLose;
        private System.Windows.Forms.NumericUpDown staminaLose;
        private System.Windows.Forms.NumericUpDown moraleLose;
        private System.Windows.Forms.NumericUpDown valueLose;
        private System.Windows.Forms.NumericUpDown packLose;
        private System.Windows.Forms.NumericUpDown ammoLose;
        private System.Windows.Forms.NumericUpDown medLose;
        private System.Windows.Forms.NumericUpDown waterLose;
        private System.Windows.Forms.Label foodLabelL;
        private System.Windows.Forms.Label staminaLabelL;
        private System.Windows.Forms.Label moraleLabelL;
        private System.Windows.Forms.Label valueLabelL;
        private System.Windows.Forms.Label packLabelL;
        private System.Windows.Forms.Label ammoLabelL;
        private System.Windows.Forms.Label medLabelL;
        private System.Windows.Forms.Label waterLabelL;
        private System.Windows.Forms.Label loseLabel;
        private System.Windows.Forms.Label statLabelW;
        private System.Windows.Forms.Label amountWLabel;
        private System.Windows.Forms.NumericUpDown strengthWin;
        private System.Windows.Forms.NumericUpDown knowWin;
        private System.Windows.Forms.NumericUpDown marksWin;
        private System.Windows.Forms.NumericUpDown loyalWin;
        private System.Windows.Forms.NumericUpDown percWin;
        private System.Windows.Forms.NumericUpDown agilityWin;
        private System.Windows.Forms.NumericUpDown diploWin;
        private System.Windows.Forms.NumericUpDown tacticsWin;
        private System.Windows.Forms.Label strengthLabelW;
        private System.Windows.Forms.Label knowLabelW;
        private System.Windows.Forms.Label markLabelW;
        private System.Windows.Forms.Label loyalLabelW;
        private System.Windows.Forms.Label percLabelW;
        private System.Windows.Forms.Label agilityLabelW;
        private System.Windows.Forms.Label diploLabelW;
        private System.Windows.Forms.Label tacticsLabelW;
        private System.Windows.Forms.NumericUpDown foodWin;
        private System.Windows.Forms.NumericUpDown staminaWin;
        private System.Windows.Forms.NumericUpDown moraleWin;
        private System.Windows.Forms.NumericUpDown valueWin;
        private System.Windows.Forms.NumericUpDown packWin;
        private System.Windows.Forms.NumericUpDown ammoWin;
        private System.Windows.Forms.NumericUpDown medWin;
        private System.Windows.Forms.NumericUpDown waterWin;
        private System.Windows.Forms.Label foodLabelW;
        private System.Windows.Forms.Label staminaLabelW;
        private System.Windows.Forms.Label moraleLabelW;
        private System.Windows.Forms.Label valueLabelW;
        private System.Windows.Forms.Label packLabelW;
        private System.Windows.Forms.Label ammoLabelW;
        private System.Windows.Forms.Label medLabelW;
        private System.Windows.Forms.Label waterLabelW;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label statLabelR;
        private System.Windows.Forms.Label amountLabelR;
        private System.Windows.Forms.NumericUpDown strengthReq;
        private System.Windows.Forms.NumericUpDown knowReq;
        private System.Windows.Forms.NumericUpDown marksReq;
        private System.Windows.Forms.NumericUpDown loyalReq;
        private System.Windows.Forms.NumericUpDown percReq;
        private System.Windows.Forms.NumericUpDown agilityReq;
        private System.Windows.Forms.NumericUpDown diploReq;
        private System.Windows.Forms.NumericUpDown tacticsReq;
        private System.Windows.Forms.Label strengthLabelR;
        private System.Windows.Forms.Label knowLabelR;
        private System.Windows.Forms.Label marksLabelR;
        private System.Windows.Forms.Label loyalLabelR;
        private System.Windows.Forms.Label percLabelR;
        private System.Windows.Forms.Label agilityLabelR;
        private System.Windows.Forms.Label diploLabelR;
        private System.Windows.Forms.Label tacticsLabelR;
        private System.Windows.Forms.NumericUpDown foodReq;
        private System.Windows.Forms.NumericUpDown staminaReq;
        private System.Windows.Forms.NumericUpDown moraleReq;
        private System.Windows.Forms.NumericUpDown valueReq;
        private System.Windows.Forms.NumericUpDown packReq;
        private System.Windows.Forms.NumericUpDown ammoReq;
        private System.Windows.Forms.NumericUpDown medReq;
        private System.Windows.Forms.NumericUpDown waterReq;
        private System.Windows.Forms.Label foodLabelR;
        private System.Windows.Forms.Label staminaLabelR;
        private System.Windows.Forms.Label moraleLabelR;
        private System.Windows.Forms.Label valueLabelR;
        private System.Windows.Forms.Label packLabelR;
        private System.Windows.Forms.Label ammoLabelR;
        private System.Windows.Forms.Label medLabelR;
        private System.Windows.Forms.Label waterLabelR;
        private System.Windows.Forms.Label reqLabel;
        private System.Windows.Forms.Label statMLabel;
        private System.Windows.Forms.Label applyMLabel;
        private System.Windows.Forms.Label amountMLabel;
        private System.Windows.Forms.CheckBox strengthModB;
        private System.Windows.Forms.CheckBox knowModB;
        private System.Windows.Forms.CheckBox marksModB;
        private System.Windows.Forms.CheckBox loyalModB;
        private System.Windows.Forms.CheckBox percModB;
        private System.Windows.Forms.CheckBox agilityModB;
        private System.Windows.Forms.CheckBox diploModB;
        private System.Windows.Forms.CheckBox tacticsModB;
        private System.Windows.Forms.NumericUpDown strengthMod;
        private System.Windows.Forms.NumericUpDown knowMod;
        private System.Windows.Forms.NumericUpDown markMod;
        private System.Windows.Forms.NumericUpDown loyalMod;
        private System.Windows.Forms.NumericUpDown percMod;
        private System.Windows.Forms.NumericUpDown agilityMod;
        private System.Windows.Forms.NumericUpDown diploMod;
        private System.Windows.Forms.NumericUpDown tacticsMod;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label knowLabel;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label loyalLabel;
        private System.Windows.Forms.Label percLabel;
        private System.Windows.Forms.Label agilityLabel;
        private System.Windows.Forms.Label diploLabel;
        private System.Windows.Forms.Label tacticsLabel;
        private System.Windows.Forms.CheckBox foodModB;
        private System.Windows.Forms.CheckBox staminaModB;
        private System.Windows.Forms.CheckBox moraleModB;
        private System.Windows.Forms.CheckBox vModB;
        private System.Windows.Forms.CheckBox valueModB;
        private System.Windows.Forms.CheckBox ammoModB;
        private System.Windows.Forms.CheckBox medModB;
        private System.Windows.Forms.CheckBox waterModB;
        private System.Windows.Forms.NumericUpDown foodMod;
        private System.Windows.Forms.NumericUpDown staminaMod;
        private System.Windows.Forms.NumericUpDown moraleMod;
        private System.Windows.Forms.NumericUpDown valueMod;
        private System.Windows.Forms.NumericUpDown packMod;
        private System.Windows.Forms.NumericUpDown ammoMod;
        private System.Windows.Forms.NumericUpDown medMod;
        private System.Windows.Forms.NumericUpDown waterMod;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label stamLabel;
        private System.Windows.Forms.Label moraleLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label packLabel;
        private System.Windows.Forms.Label ammoLabel;
        private System.Windows.Forms.Label medLabel;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label modLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCurrentResponse;
        private System.Windows.Forms.ComboBox comboBoxRespToEdit;
        private System.Windows.Forms.Button btnRespOptSave;
        private System.Windows.Forms.CheckBox chkWinKill;
        private System.Windows.Forms.CheckBox chkKillLose;
        private System.Windows.Forms.Label lblLoseEffects;
        private System.Windows.Forms.ComboBox comboBoxLoseApplication;
        private System.Windows.Forms.Label lblWinEffects;
        private System.Windows.Forms.ComboBox comboBoxWinApplication;
        private System.Windows.Forms.NumericUpDown removeNumBox;
        private System.Windows.Forms.TextBox textResponse1;
        private System.Windows.Forms.TextBox textResponse2;
        private System.Windows.Forms.Label labelResponse1;
        private System.Windows.Forms.TextBox textResponse3;
        private System.Windows.Forms.Label removeResponseNumLabel;
        private System.Windows.Forms.TextBox textResponse4;
        private System.Windows.Forms.Button removeResponseButton;
        private System.Windows.Forms.TextBox textResponse5;
        private System.Windows.Forms.Button addResponseButton;
        private System.Windows.Forms.Label labelResponse3;
        private System.Windows.Forms.Label labelResponse2;
        private System.Windows.Forms.Label labelResponse4;
        private System.Windows.Forms.Label labelResponse5;
        private System.Windows.Forms.Button btnLoadEvent;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LoadEvent;
        private System.Windows.Forms.CheckBox chkOnlyOnce;
        private System.Windows.Forms.Panel pnlResText;
        private System.Windows.Forms.Panel pnlCost;
        private System.Windows.Forms.Panel pnlLose;
        private System.Windows.Forms.Panel pnlWin;
        private System.Windows.Forms.Panel pnlReq;
        private System.Windows.Forms.Panel pnlMod;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.Label lblProbLose;
        private System.Windows.Forms.Label lblProbWin;
        private System.Windows.Forms.Label lblWithStdParty;
        private System.Windows.Forms.Label lblProbLoseTxt;
        private System.Windows.Forms.Label lblProbOfWinTxt;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.CheckedListBox notClassInput;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.CheckedListBox orClassInput;

    }
}

