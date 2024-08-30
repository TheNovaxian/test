namespace MyBikeFactoryClientLayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelBiketype = new Label();
            labelSerialNumber = new Label();
            labelMake = new Label();
            labelModel = new Label();
            labelColor = new Label();
            labelSpeed = new Label();
            labelBrakes = new Label();
            labelFrame = new Label();
            labelSuspension = new Label();
            labelheight = new Label();
            labelSeat = new Label();
            comboBoxType = new ComboBox();
            comboBoxColor = new ComboBox();
            comboBoxBrakes = new ComboBox();
            comboBoxFrame = new ComboBox();
            textBoxSerialNumber = new TextBox();
            textBoxMake = new TextBox();
            textBoxModel = new TextBox();
            textBoxSpeed = new TextBox();
            textBoxHeight = new TextBox();
            textBoxSeatHeight = new TextBox();
            comboBoxSuspension = new ComboBox();
            listBoxBikes = new ListBox();
            buttonAdd = new Button();
            buttonPrint = new Button();
            buttonReset = new Button();
            labelDay = new Label();
            labelMonth = new Label();
            labelYear = new Label();
            textBoxDay = new TextBox();
            textBoxMonth = new TextBox();
            textBoxYear = new TextBox();
            buttonPrintMBike = new Button();
            buttonPrintRBike = new Button();
            buttonWriteXml = new Button();
            buttonReadXml = new Button();
            labelSearch = new Label();
            label1 = new Label();
            label2 = new Label();
            buttonSearch = new Button();
            buttonUpdate = new Button();
            buttonRemove = new Button();
            buttonExit = new Button();
            trackBarSpeedUp = new TrackBar();
            groupBoxCommon = new GroupBox();
            label3 = new Label();
            labelTireWidth = new Label();
            textBoxTireWidth = new TextBox();
            buttonFatBikes = new Button();
            groupBoxOperations = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBoxDate = new GroupBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            pictureBoxQuestion = new PictureBox();
            pictureBoxFBike = new PictureBox();
            pictureBoxRBike = new PictureBox();
            pictureBoxMBike = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeedUp).BeginInit();
            groupBoxCommon.SuspendLayout();
            groupBoxOperations.SuspendLayout();
            groupBoxDate.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFBike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRBike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMBike).BeginInit();
            SuspendLayout();
            // 
            // labelBiketype
            // 
            labelBiketype.BackColor = Color.WhiteSmoke;
            labelBiketype.BorderStyle = BorderStyle.Fixed3D;
            labelBiketype.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBiketype.Location = new Point(0, 24);
            labelBiketype.Name = "labelBiketype";
            labelBiketype.Size = new Size(161, 36);
            labelBiketype.TabIndex = 0;
            labelBiketype.Text = "Type of Bike:";
            // 
            // labelSerialNumber
            // 
            labelSerialNumber.BackColor = Color.WhiteSmoke;
            labelSerialNumber.BorderStyle = BorderStyle.Fixed3D;
            labelSerialNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSerialNumber.Location = new Point(0, 87);
            labelSerialNumber.Name = "labelSerialNumber";
            labelSerialNumber.Size = new Size(161, 28);
            labelSerialNumber.TabIndex = 1;
            labelSerialNumber.Text = "Bike Serial #:";
            // 
            // labelMake
            // 
            labelMake.BackColor = Color.WhiteSmoke;
            labelMake.BorderStyle = BorderStyle.Fixed3D;
            labelMake.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMake.Location = new Point(6, 130);
            labelMake.Name = "labelMake";
            labelMake.Size = new Size(74, 34);
            labelMake.TabIndex = 2;
            labelMake.Text = "Make:";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.BackColor = Color.WhiteSmoke;
            labelModel.BorderStyle = BorderStyle.Fixed3D;
            labelModel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelModel.Location = new Point(10, 181);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(80, 27);
            labelModel.TabIndex = 3;
            labelModel.Text = "Model:";
            // 
            // labelColor
            // 
            labelColor.BackColor = Color.WhiteSmoke;
            labelColor.BorderStyle = BorderStyle.Fixed3D;
            labelColor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelColor.Location = new Point(435, 92);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(161, 28);
            labelColor.TabIndex = 4;
            labelColor.Text = "Bike Color:";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.BackColor = Color.WhiteSmoke;
            labelSpeed.BorderStyle = BorderStyle.Fixed3D;
            labelSpeed.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSpeed.Location = new Point(6, 233);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(84, 27);
            labelSpeed.TabIndex = 5;
            labelSpeed.Text = "Speed:";
            // 
            // labelBrakes
            // 
            labelBrakes.AutoSize = true;
            labelBrakes.BackColor = Color.WhiteSmoke;
            labelBrakes.BorderStyle = BorderStyle.Fixed3D;
            labelBrakes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBrakes.Location = new Point(435, 149);
            labelBrakes.Name = "labelBrakes";
            labelBrakes.Size = new Size(167, 27);
            labelBrakes.TabIndex = 6;
            labelBrakes.Text = "Type of Brakes:";
            // 
            // labelFrame
            // 
            labelFrame.AutoSize = true;
            labelFrame.BackColor = Color.WhiteSmoke;
            labelFrame.BorderStyle = BorderStyle.Fixed3D;
            labelFrame.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFrame.Location = new Point(435, 216);
            labelFrame.Name = "labelFrame";
            labelFrame.Size = new Size(161, 27);
            labelFrame.TabIndex = 7;
            labelFrame.Text = "Type of Frame:";
            // 
            // labelSuspension
            // 
            labelSuspension.BackColor = Color.WhiteSmoke;
            labelSuspension.BorderStyle = BorderStyle.Fixed3D;
            labelSuspension.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuspension.Location = new Point(435, 24);
            labelSuspension.Name = "labelSuspension";
            labelSuspension.Size = new Size(160, 34);
            labelSuspension.TabIndex = 8;
            labelSuspension.Text = "Suspension:";
            // 
            // labelheight
            // 
            labelheight.AutoSize = true;
            labelheight.BorderStyle = BorderStyle.Fixed3D;
            labelheight.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelheight.Location = new Point(0, 36);
            labelheight.Name = "labelheight";
            labelheight.Size = new Size(204, 27);
            labelheight.TabIndex = 9;
            labelheight.Text = "Height from ground:";
            // 
            // labelSeat
            // 
            labelSeat.BorderStyle = BorderStyle.Fixed3D;
            labelSeat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSeat.Location = new Point(6, 83);
            labelSeat.Name = "labelSeat";
            labelSeat.Size = new Size(179, 29);
            labelSeat.TabIndex = 10;
            labelSeat.Text = "Seat Height:";
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(181, 22);
            comboBoxType.Margin = new Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(202, 43);
            comboBoxType.TabIndex = 11;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // comboBoxColor
            // 
            comboBoxColor.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(624, 83);
            comboBoxColor.Margin = new Padding(3, 4, 3, 4);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(242, 43);
            comboBoxColor.TabIndex = 12;
            // 
            // comboBoxBrakes
            // 
            comboBoxBrakes.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            comboBoxBrakes.FormattingEnabled = true;
            comboBoxBrakes.Location = new Point(624, 135);
            comboBoxBrakes.Margin = new Padding(3, 4, 3, 4);
            comboBoxBrakes.Name = "comboBoxBrakes";
            comboBoxBrakes.Size = new Size(242, 43);
            comboBoxBrakes.TabIndex = 13;
            // 
            // comboBoxFrame
            // 
            comboBoxFrame.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            comboBoxFrame.FormattingEnabled = true;
            comboBoxFrame.Location = new Point(624, 200);
            comboBoxFrame.Margin = new Padding(3, 4, 3, 4);
            comboBoxFrame.Name = "comboBoxFrame";
            comboBoxFrame.Size = new Size(242, 43);
            comboBoxFrame.TabIndex = 14;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.BackColor = Color.White;
            textBoxSerialNumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxSerialNumber.Location = new Point(181, 74);
            textBoxSerialNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(202, 41);
            textBoxSerialNumber.TabIndex = 15;
            // 
            // textBoxMake
            // 
            textBoxMake.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxMake.Location = new Point(181, 123);
            textBoxMake.Margin = new Padding(3, 4, 3, 4);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(202, 41);
            textBoxMake.TabIndex = 16;
            // 
            // textBoxModel
            // 
            textBoxModel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxModel.Location = new Point(181, 170);
            textBoxModel.Margin = new Padding(3, 4, 3, 4);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(202, 41);
            textBoxModel.TabIndex = 17;
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxSpeed.Location = new Point(181, 219);
            textBoxSpeed.Margin = new Padding(3, 4, 3, 4);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(202, 41);
            textBoxSpeed.TabIndex = 18;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxHeight.Location = new Point(210, 25);
            textBoxHeight.Margin = new Padding(3, 4, 3, 4);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(163, 41);
            textBoxHeight.TabIndex = 20;
            // 
            // textBoxSeatHeight
            // 
            textBoxSeatHeight.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxSeatHeight.Location = new Point(210, 73);
            textBoxSeatHeight.Margin = new Padding(3, 4, 3, 4);
            textBoxSeatHeight.Name = "textBoxSeatHeight";
            textBoxSeatHeight.Size = new Size(163, 41);
            textBoxSeatHeight.TabIndex = 21;
            // 
            // comboBoxSuspension
            // 
            comboBoxSuspension.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            comboBoxSuspension.FormattingEnabled = true;
            comboBoxSuspension.Location = new Point(624, 24);
            comboBoxSuspension.Margin = new Padding(3, 4, 3, 4);
            comboBoxSuspension.Name = "comboBoxSuspension";
            comboBoxSuspension.Size = new Size(242, 43);
            comboBoxSuspension.TabIndex = 22;
            // 
            // listBoxBikes
            // 
            listBoxBikes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxBikes.FormattingEnabled = true;
            listBoxBikes.HorizontalScrollbar = true;
            listBoxBikes.ItemHeight = 25;
            listBoxBikes.Location = new Point(-5, 569);
            listBoxBikes.Margin = new Padding(3, 4, 3, 4);
            listBoxBikes.Name = "listBoxBikes";
            listBoxBikes.Size = new Size(1893, 304);
            listBoxBikes.TabIndex = 23;
            listBoxBikes.SelectedIndexChanged += listBoxBikes_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Yellow;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(12, 524);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 38);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrint.Location = new Point(103, 524);
            buttonPrint.Margin = new Padding(3, 4, 3, 4);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(89, 38);
            buttonPrint.TabIndex = 25;
            buttonPrint.Text = "PRINT";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Yellow;
            buttonReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(193, 524);
            buttonReset.Margin = new Padding(3, 4, 3, 4);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(96, 38);
            buttonReset.TabIndex = 26;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.BorderStyle = BorderStyle.Fixed3D;
            labelDay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDay.Location = new Point(29, 67);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(58, 27);
            labelDay.TabIndex = 28;
            labelDay.Text = "DAY";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.BorderStyle = BorderStyle.Fixed3D;
            labelMonth.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMonth.Location = new Point(29, 119);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(93, 27);
            labelMonth.TabIndex = 29;
            labelMonth.Text = "MONTH";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BorderStyle = BorderStyle.Fixed3D;
            labelYear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelYear.Location = new Point(29, 169);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(71, 27);
            labelYear.TabIndex = 30;
            labelYear.Text = "YEAR";
            // 
            // textBoxDay
            // 
            textBoxDay.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxDay.Location = new Point(131, 56);
            textBoxDay.Margin = new Padding(3, 4, 3, 4);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(84, 41);
            textBoxDay.TabIndex = 31;
            // 
            // textBoxMonth
            // 
            textBoxMonth.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxMonth.Location = new Point(131, 105);
            textBoxMonth.Margin = new Padding(3, 4, 3, 4);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(84, 41);
            textBoxMonth.TabIndex = 32;
            // 
            // textBoxYear
            // 
            textBoxYear.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxYear.Location = new Point(131, 158);
            textBoxYear.Margin = new Padding(3, 4, 3, 4);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(84, 41);
            textBoxYear.TabIndex = 33;
            // 
            // buttonPrintMBike
            // 
            buttonPrintMBike.BackColor = Color.White;
            buttonPrintMBike.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrintMBike.Location = new Point(537, 524);
            buttonPrintMBike.Margin = new Padding(3, 4, 3, 4);
            buttonPrintMBike.Name = "buttonPrintMBike";
            buttonPrintMBike.Size = new Size(236, 38);
            buttonPrintMBike.TabIndex = 34;
            buttonPrintMBike.Text = "PRINT MOUNTAIN BIKES";
            buttonPrintMBike.UseVisualStyleBackColor = false;
            buttonPrintMBike.Click += buttonPrintMBike_Click;
            // 
            // buttonPrintRBike
            // 
            buttonPrintRBike.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrintRBike.Location = new Point(295, 524);
            buttonPrintRBike.Margin = new Padding(3, 4, 3, 4);
            buttonPrintRBike.Name = "buttonPrintRBike";
            buttonPrintRBike.Size = new Size(236, 38);
            buttonPrintRBike.TabIndex = 35;
            buttonPrintRBike.Text = "PRINT ROAD BIKES";
            buttonPrintRBike.UseVisualStyleBackColor = true;
            buttonPrintRBike.Click += buttonPrintRBike_Click;
            // 
            // buttonWriteXml
            // 
            buttonWriteXml.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonWriteXml.Location = new Point(1024, 524);
            buttonWriteXml.Margin = new Padding(3, 4, 3, 4);
            buttonWriteXml.Name = "buttonWriteXml";
            buttonWriteXml.Size = new Size(210, 38);
            buttonWriteXml.TabIndex = 36;
            buttonWriteXml.Text = "WRITE TO XML";
            buttonWriteXml.UseVisualStyleBackColor = true;
            buttonWriteXml.Click += buttonWriteXml_Click;
            // 
            // buttonReadXml
            // 
            buttonReadXml.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReadXml.Location = new Point(1240, 524);
            buttonReadXml.Margin = new Padding(3, 4, 3, 4);
            buttonReadXml.Name = "buttonReadXml";
            buttonReadXml.Size = new Size(204, 38);
            buttonReadXml.TabIndex = 37;
            buttonReadXml.Text = "READ FROM XML";
            buttonReadXml.UseVisualStyleBackColor = true;
            buttonReadXml.Click += buttonReadXml_Click;
            // 
            // labelSearch
            // 
            labelSearch.BorderStyle = BorderStyle.Fixed3D;
            labelSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(6, 24);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(362, 25);
            labelSearch.TabIndex = 38;
            labelSearch.Text = "Search Bike by Serial#:";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(362, 38);
            label1.TabIndex = 39;
            label1.Text = "Choose Bike in ListBox to Update\r\n";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(362, 34);
            label2.TabIndex = 40;
            label2.Text = "Choose Bike in ListBox to Remove\r\n";
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(417, 18);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(121, 38);
            buttonSearch.TabIndex = 41;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(415, 63);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(121, 38);
            buttonUpdate.TabIndex = 42;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.Location = new Point(415, 103);
            buttonRemove.Margin = new Padding(3, 4, 3, 4);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(121, 38);
            buttonRemove.TabIndex = 43;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(1459, 524);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(218, 38);
            buttonExit.TabIndex = 44;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // trackBarSpeedUp
            // 
            trackBarSpeedUp.Location = new Point(19, 204);
            trackBarSpeedUp.Margin = new Padding(3, 4, 3, 4);
            trackBarSpeedUp.Maximum = 45;
            trackBarSpeedUp.Name = "trackBarSpeedUp";
            trackBarSpeedUp.Size = new Size(519, 56);
            trackBarSpeedUp.TabIndex = 45;
            trackBarSpeedUp.Scroll += trackBarSpeedUp_Scroll;
            // 
            // groupBoxCommon
            // 
            groupBoxCommon.BackColor = Color.Transparent;
            groupBoxCommon.Controls.Add(labelBiketype);
            groupBoxCommon.Controls.Add(comboBoxType);
            groupBoxCommon.Controls.Add(labelSerialNumber);
            groupBoxCommon.Controls.Add(textBoxSerialNumber);
            groupBoxCommon.Controls.Add(labelMake);
            groupBoxCommon.Controls.Add(textBoxMake);
            groupBoxCommon.Controls.Add(labelModel);
            groupBoxCommon.Controls.Add(textBoxModel);
            groupBoxCommon.Controls.Add(labelSpeed);
            groupBoxCommon.Controls.Add(textBoxSpeed);
            groupBoxCommon.Controls.Add(labelColor);
            groupBoxCommon.Controls.Add(comboBoxColor);
            groupBoxCommon.Controls.Add(labelBrakes);
            groupBoxCommon.Controls.Add(comboBoxBrakes);
            groupBoxCommon.Controls.Add(labelFrame);
            groupBoxCommon.Controls.Add(comboBoxFrame);
            groupBoxCommon.Controls.Add(labelSuspension);
            groupBoxCommon.Controls.Add(comboBoxSuspension);
            groupBoxCommon.Location = new Point(314, 5);
            groupBoxCommon.Margin = new Padding(3, 4, 3, 4);
            groupBoxCommon.Name = "groupBoxCommon";
            groupBoxCommon.Padding = new Padding(3, 4, 3, 4);
            groupBoxCommon.Size = new Size(908, 271);
            groupBoxCommon.TabIndex = 46;
            groupBoxCommon.TabStop = false;
            groupBoxCommon.Text = "Common Values";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 145);
            label3.Name = "label3";
            label3.Size = new Size(461, 40);
            label3.TabIndex = 47;
            label3.Text = "select a bike in list and use the slider to adjust speed\r\n then press update to update";
            // 
            // labelTireWidth
            // 
            labelTireWidth.BorderStyle = BorderStyle.Fixed3D;
            labelTireWidth.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTireWidth.Location = new Point(6, 138);
            labelTireWidth.Name = "labelTireWidth";
            labelTireWidth.Size = new Size(179, 26);
            labelTireWidth.TabIndex = 48;
            labelTireWidth.Text = "Tire Width:";
            // 
            // textBoxTireWidth
            // 
            textBoxTireWidth.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxTireWidth.Location = new Point(210, 123);
            textBoxTireWidth.Margin = new Padding(3, 4, 3, 4);
            textBoxTireWidth.Name = "textBoxTireWidth";
            textBoxTireWidth.Size = new Size(163, 41);
            textBoxTireWidth.TabIndex = 49;
            // 
            // buttonFatBikes
            // 
            buttonFatBikes.BackColor = Color.White;
            buttonFatBikes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFatBikes.Location = new Point(779, 524);
            buttonFatBikes.Margin = new Padding(3, 4, 3, 4);
            buttonFatBikes.Name = "buttonFatBikes";
            buttonFatBikes.Size = new Size(236, 38);
            buttonFatBikes.TabIndex = 50;
            buttonFatBikes.Text = "PRINT FAT BIKES";
            buttonFatBikes.UseVisualStyleBackColor = false;
            buttonFatBikes.Click += buttonFatBikes_Click;
            // 
            // groupBoxOperations
            // 
            groupBoxOperations.BackColor = Color.White;
            groupBoxOperations.Controls.Add(label15);
            groupBoxOperations.Controls.Add(label14);
            groupBoxOperations.Controls.Add(label13);
            groupBoxOperations.Controls.Add(label12);
            groupBoxOperations.Controls.Add(label11);
            groupBoxOperations.Controls.Add(label10);
            groupBoxOperations.Controls.Add(label9);
            groupBoxOperations.Controls.Add(label8);
            groupBoxOperations.Controls.Add(label7);
            groupBoxOperations.Controls.Add(label6);
            groupBoxOperations.Controls.Add(label5);
            groupBoxOperations.Controls.Add(labelSearch);
            groupBoxOperations.Controls.Add(buttonSearch);
            groupBoxOperations.Controls.Add(label1);
            groupBoxOperations.Controls.Add(buttonUpdate);
            groupBoxOperations.Controls.Add(label2);
            groupBoxOperations.Controls.Add(buttonRemove);
            groupBoxOperations.Controls.Add(trackBarSpeedUp);
            groupBoxOperations.Controls.Add(label3);
            groupBoxOperations.Location = new Point(1222, 5);
            groupBoxOperations.Margin = new Padding(3, 4, 3, 4);
            groupBoxOperations.Name = "groupBoxOperations";
            groupBoxOperations.Padding = new Padding(3, 4, 3, 4);
            groupBoxOperations.Size = new Size(544, 352);
            groupBoxOperations.TabIndex = 54;
            groupBoxOperations.TabStop = false;
            groupBoxOperations.Text = "Operations";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(265, 310);
            label15.Name = "label15";
            label15.Size = new Size(56, 20);
            label15.TabIndex = 58;
            label15.Text = "KM/H";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(32, 254);
            label14.Name = "label14";
            label14.Size = new Size(18, 20);
            label14.TabIndex = 67;
            label14.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(511, 254);
            label13.Name = "label13";
            label13.Size = new Size(27, 20);
            label13.TabIndex = 66;
            label13.Text = "45\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(462, 254);
            label12.Name = "label12";
            label12.Size = new Size(27, 20);
            label12.TabIndex = 65;
            label12.Text = "40\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(404, 254);
            label11.Name = "label11";
            label11.Size = new Size(27, 20);
            label11.TabIndex = 64;
            label11.Text = "35\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(350, 254);
            label10.Name = "label10";
            label10.Size = new Size(27, 20);
            label10.TabIndex = 63;
            label10.Text = "30";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(295, 254);
            label9.Name = "label9";
            label9.Size = new Size(27, 20);
            label9.TabIndex = 62;
            label9.Text = "25\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(241, 254);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 61;
            label8.Text = "20";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(186, 254);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 60;
            label7.Text = "15";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(125, 254);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 59;
            label6.Text = " 10";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(86, 254);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 58;
            label5.Text = "5\n";
            // 
            // groupBoxDate
            // 
            groupBoxDate.Controls.Add(label4);
            groupBoxDate.Controls.Add(labelDay);
            groupBoxDate.Controls.Add(textBoxDay);
            groupBoxDate.Controls.Add(labelMonth);
            groupBoxDate.Controls.Add(textBoxMonth);
            groupBoxDate.Controls.Add(labelYear);
            groupBoxDate.Controls.Add(textBoxYear);
            groupBoxDate.Location = new Point(12, 284);
            groupBoxDate.Margin = new Padding(3, 4, 3, 4);
            groupBoxDate.Name = "groupBoxDate";
            groupBoxDate.Padding = new Padding(3, 4, 3, 4);
            groupBoxDate.Size = new Size(259, 207);
            groupBoxDate.TabIndex = 55;
            groupBoxDate.TabStop = false;
            groupBoxDate.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 24);
            label4.Name = "label4";
            label4.Size = new Size(168, 27);
            label4.TabIndex = 30;
            label4.Text = "Production Date";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelheight);
            groupBox1.Controls.Add(textBoxHeight);
            groupBox1.Controls.Add(labelSeat);
            groupBox1.Controls.Add(labelTireWidth);
            groupBox1.Controls.Add(textBoxSeatHeight);
            groupBox1.Controls.Add(textBoxTireWidth);
            groupBox1.Location = new Point(277, 295);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(387, 185);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "Extra Features";
            // 
            // pictureBoxQuestion
            // 
            pictureBoxQuestion.BackColor = Color.White;
            pictureBoxQuestion.BackgroundImage = Properties.Resources.Screenshot_2024_04_18_175256;
            pictureBoxQuestion.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxQuestion.Location = new Point(12, 4);
            pictureBoxQuestion.Margin = new Padding(3, 4, 3, 4);
            pictureBoxQuestion.Name = "pictureBoxQuestion";
            pictureBoxQuestion.Size = new Size(296, 271);
            pictureBoxQuestion.TabIndex = 57;
            pictureBoxQuestion.TabStop = false;
            // 
            // pictureBoxFBike
            // 
            pictureBoxFBike.BackColor = Color.White;
            pictureBoxFBike.BackgroundImage = Properties.Resources.FatBike;
            pictureBoxFBike.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxFBike.Location = new Point(12, 4);
            pictureBoxFBike.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFBike.Name = "pictureBoxFBike";
            pictureBoxFBike.Size = new Size(296, 271);
            pictureBoxFBike.TabIndex = 53;
            pictureBoxFBike.TabStop = false;
            // 
            // pictureBoxRBike
            // 
            pictureBoxRBike.BackColor = Color.White;
            pictureBoxRBike.BackgroundImage = Properties.Resources.RoadBike;
            pictureBoxRBike.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRBike.Location = new Point(12, 5);
            pictureBoxRBike.Margin = new Padding(3, 4, 3, 4);
            pictureBoxRBike.Name = "pictureBoxRBike";
            pictureBoxRBike.Size = new Size(296, 271);
            pictureBoxRBike.TabIndex = 52;
            pictureBoxRBike.TabStop = false;
            // 
            // pictureBoxMBike
            // 
            pictureBoxMBike.BackColor = Color.White;
            pictureBoxMBike.BackgroundImage = Properties.Resources.MountainBike;
            pictureBoxMBike.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxMBike.Location = new Point(12, 5);
            pictureBoxMBike.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMBike.Name = "pictureBoxMBike";
            pictureBoxMBike.Size = new Size(296, 271);
            pictureBoxMBike.TabIndex = 51;
            pictureBoxMBike.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1765, 904);
            Controls.Add(pictureBoxQuestion);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxDate);
            Controls.Add(groupBoxOperations);
            Controls.Add(pictureBoxFBike);
            Controls.Add(pictureBoxRBike);
            Controls.Add(pictureBoxMBike);
            Controls.Add(buttonFatBikes);
            Controls.Add(groupBoxCommon);
            Controls.Add(buttonExit);
            Controls.Add(buttonReadXml);
            Controls.Add(buttonWriteXml);
            Controls.Add(buttonPrintRBike);
            Controls.Add(buttonPrintMBike);
            Controls.Add(buttonReset);
            Controls.Add(buttonPrint);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxBikes);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Shaquille O Neil";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarSpeedUp).EndInit();
            groupBoxCommon.ResumeLayout(false);
            groupBoxCommon.PerformLayout();
            groupBoxOperations.ResumeLayout(false);
            groupBoxOperations.PerformLayout();
            groupBoxDate.ResumeLayout(false);
            groupBoxDate.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFBike).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRBike).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMBike).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelBiketype;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelBrakes;
        private System.Windows.Forms.Label labelFrame;
        private System.Windows.Forms.Label labelSuspension;
        private System.Windows.Forms.Label labelheight;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxBrakes;
        private System.Windows.Forms.ComboBox comboBoxFrame;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxSeatHeight;
        private System.Windows.Forms.ComboBox comboBoxSuspension;
        private System.Windows.Forms.ListBox listBoxBikes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonPrintMBike;
        private System.Windows.Forms.Button buttonPrintRBike;
        private System.Windows.Forms.Button buttonWriteXml;
        private System.Windows.Forms.Button buttonReadXml;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TrackBar trackBarSpeedUp;
        private System.Windows.Forms.GroupBox groupBoxCommon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTireWidth;
        private System.Windows.Forms.TextBox textBoxTireWidth;
        private System.Windows.Forms.Button buttonFatBikes;
        private System.Windows.Forms.PictureBox pictureBoxMBike;
        private System.Windows.Forms.PictureBox pictureBoxRBike;
        private System.Windows.Forms.PictureBox pictureBoxFBike;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxQuestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
