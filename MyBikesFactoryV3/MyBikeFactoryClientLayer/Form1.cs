using MyBikeFactoryBusLayer;
using MyBikeFactoryDataLayer;
namespace MyBikeFactoryClientLayer
{
    public partial class Form1 : Form
    {
        // Lists to store different types of bikes
        List<Bike>? listOfBikes = new List<Bike>();
        List<MountainBike>? listOfMBike = new List<MountainBike>();
        List<RoadBike>? listOfRBike = new List<RoadBike>();
        List<FatBike>? listOfFBike = new List<FatBike>();

        // Variables to store the current bike of each type
        Bike currentBike; 
        MountainBike currentMBike;
        RoadBike currentRBike; 
        FatBike currentFBike;
        // Variable to store the current made date of a bike
        Date currentMadeDate;

        public Form1()
        {
            InitializeComponent();  // Initialize the form's components
        }

        // Event handler for when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the color combo box with enum values
            foreach (EnumColor bike in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(bike);
            }
            // Set the default value for the color combo box
            this.comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);
            // Populate the type combo box with enum values
            foreach (EnumBikeType bike in Enum.GetValues(typeof(EnumBikeType)))
            {
                this.comboBoxType.Items.Add(bike);
            }
            // Set the default value for the type combo box
            this.comboBoxType.Text = Convert.ToString(EnumBikeType.Undefined);
            // Populate the brakes combo box with enum values
            foreach (EnumBrakes bike in Enum.GetValues(typeof(EnumBrakes)))
            {
                this.comboBoxBrakes.Items.Add(bike);
            }
            // Set the default value for the brakes combo box
            this.comboBoxBrakes.Text = Convert.ToString(EnumBrakes.Undefined);
            // Populate the frame combo box with enum values
            foreach (EnumFrameType bike in Enum.GetValues(typeof(EnumFrameType)))
            {
                this.comboBoxFrame.Items.Add(bike);
            }
            // Set the default value for the frame combo box
            this.comboBoxFrame.Text = Convert.ToString(EnumFrameType.Undefined);
            // Populate the suspension combo box with enum values
            foreach (EnumSuspension bike in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.comboBoxSuspension.Items.Add(bike);
            }
            // Set the default value for the suspension combo box
            this.comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);
        }

        int currentIndex = -1; // Initialize currentIndex to -1
        private void listBoxBikes_SelectedIndexChanged(object sender, EventArgs e)
        {

            currentIndex = this.listBoxBikes.SelectedIndex; // Update currentIndex with the selected index
            EnumBikeType currentBikeType;





            this.listOfBikes = DataCollection.GetBikeList(); // Retrieve the list of bikes from DataCollection

            if (this.listOfBikes != null )
            {
                currentBikeType =this.listOfBikes[currentIndex].Type; // Get the type of the current bike

                this.comboBoxType.Text = Convert.ToString(currentBikeType);

                // Populate the form fields based on the type of the current bike
                if (currentIndex >= 0 && currentBikeType == EnumBikeType.MountainBike)
                {
                    MountainBike currentMBike = new MountainBike();

                    currentMBike = (MountainBike)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text =currentMBike.SerialNumber.ToString();
                    this.textBoxMake.Text = currentMBike.Make;
                    this.textBoxModel.Text = currentMBike.Model;
                    this.textBoxSpeed.Text =currentMBike.Speed.ToString();

                    //EnumColor
                    this.comboBoxColor.Text = currentMBike.Color.ToString();
                    this.comboBoxBrakes.Text = currentMBike.Brakes.ToString();
                    this.comboBoxFrame.Text = currentMBike.Frame.ToString();


                    this.textBoxMonth.Text = currentMBike.MadeDate.Month.ToString();
                    this.textBoxDay.Text = currentMBike.MadeDate.Day.ToString();         
                        this.textBoxYear.Text = currentMBike.MadeDate.Year.ToString();

                    this.textBoxHeight.Text = currentMBike.Height.ToString();
                    this.comboBoxSuspension.Text = currentMBike.Suspension.ToString();

                }

                else if (currentIndex >= 0 && currentBikeType == EnumBikeType.RoadBike)
                {
                    RoadBike currentRBike = new RoadBike();

                    currentRBike = (RoadBike)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentRBike.SerialNumber.ToString();
                    this.textBoxMake.Text = currentRBike.Make;
                    this.textBoxModel.Text = currentRBike.Model;
                    this.textBoxSpeed.Text = currentRBike.Speed.ToString();

                    //EnumLanguage
                    this.comboBoxColor.Text = currentRBike.Color.ToString();
                    this.comboBoxBrakes.Text = currentRBike.Brakes.ToString();
                    this.comboBoxFrame.Text = currentRBike.Frame.ToString();

                    //Date
                    this.textBoxMonth.Text = currentRBike.MadeDate.Month.ToString();
                    this.textBoxDay.Text = currentRBike.MadeDate.Day.ToString();
                    this.textBoxYear.Text = currentRBike.MadeDate.Year.ToString();

                    //capacity
                    this.textBoxSeatHeight.Text = currentRBike.SeatHeight.ToString();

                }
                else if (currentIndex >= 0 && currentBikeType == EnumBikeType.FatBike)
                {
                    FatBike currentFBike = new FatBike();

                    currentFBike = (FatBike)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentFBike.SerialNumber.ToString();
                    this.textBoxMake.Text = currentFBike.Make;
                    this.textBoxModel.Text = currentFBike.Model;
                    this.textBoxSpeed.Text = currentFBike.Speed.ToString();

                    //EnumLanguage
                    this.comboBoxColor.Text = currentFBike.Color.ToString();
                    this.comboBoxBrakes.Text = currentFBike.Brakes.ToString();
                    this.comboBoxFrame.Text = currentFBike.Frame.ToString();

                    //Date
                    this.textBoxMonth.Text = currentFBike.MadeDate.Month.ToString();
                    this.textBoxDay.Text = currentFBike.MadeDate.Day.ToString();
                    this.textBoxYear.Text = currentFBike.MadeDate.Year.ToString();

                    //Tire Width
                    this.textBoxTireWidth.Text = currentFBike.Width.ToString();

                }
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int serial_number; string make; string model; int speed;
            int currentMonth, currentDay, currentYear;

            try
            {


                // Create a new Date object to store the bike's manufacturing date
                currentMadeDate = new Date();



                if (comboBoxType.Text == "Undefined")
                {
                    MessageBox.Show("Please select a Bike Type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(this.textBoxSerialNumber.Text))
                {
                    MessageBox.Show("Please enter a serial number.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Validation for incorrect input type
                if (!int.TryParse(this.textBoxSerialNumber.Text, out int serialNumber))
                {
                    MessageBox.Show("Invalid Serial Number Format", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(this.textBoxMake.Text))
                {
                    MessageBox.Show("Please enter the make of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(this.textBoxModel.Text))
                {
                    MessageBox.Show("Please enter the model of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(this.textBoxSpeed.Text))
                {
                    MessageBox.Show("Please enter the speed of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!double.TryParse(this.textBoxSpeed.Text, out double newSpeed))
                {
                    MessageBox.Show("Please enter a valid speed.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Parse the selected bike type from the combo box
                EnumBikeType currentBikeType;
                Enum.TryParse(this.comboBoxType.Text, out currentBikeType);
                if (currentBikeType == EnumBikeType.MountainBike)
                {
                    MountainBike currentMBike = new MountainBike();
                    double Speedtest = Convert.ToInt32(this.textBoxSpeed.Text);
                    if (Speedtest > currentMBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                   "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }

                }
                else if (currentBikeType == EnumBikeType.RoadBike)
                {
                    RoadBike currentRBike = new RoadBike();
                    double Speedtest = Convert.ToInt32(this.textBoxSpeed.Text);
                    if (Speedtest > currentRBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                   "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                }
                else if (currentBikeType == EnumBikeType.FatBike)
                {
                    FatBike currentFBike = new FatBike();
                    double Speedtest = Convert.ToInt32(this.textBoxSpeed.Text);
                    if (Speedtest > currentFBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                   "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                }






                if (string.IsNullOrWhiteSpace(this.textBoxDay.Text))
                {
                    MessageBox.Show("Please enter the Day the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.textBoxMonth.Text))
                {
                    MessageBox.Show("Please enter the Month the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.textBoxYear.Text))
                {
                    MessageBox.Show("Please enter the year the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //validating date format
                if (!int.TryParse(this.textBoxMonth.Text, out int monthValue) ||
                     !int.TryParse(this.textBoxDay.Text, out int dayValue) ||
                      !int.TryParse(this.textBoxYear.Text, out int yearValue))
                {
                    MessageBox.Show("Please enter a valid date.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    DateTime date = new DateTime(yearValue, monthValue, dayValue);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Please enter a valid date.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                if (comboBoxColor.Text == "Undefined")
                {
                    MessageBox.Show("Please select a color.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxFrame.Text == "Undefined")
                {
                    MessageBox.Show("Please select a frame type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxBrakes.Text == "Undefined")
                {
                    MessageBox.Show("Please select a brakes type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

             



                // Parse the selected color from the combo box
                EnumColor currentColor;
                Enum.TryParse(this.comboBoxColor.Text, out currentColor);

              

                // Parse the selected frame type from the combo box
                EnumFrameType currentFrame;
                Enum.TryParse(this.comboBoxFrame.Text, out currentFrame);

                // Parse the selected brakes type from the combo box
                EnumBrakes currentBrakes;
                Enum.TryParse(this.comboBoxBrakes.Text, out currentBrakes);


                // Parse the serial number, make, model, and speed from the text boxes
                serial_number = Convert.ToInt32(this.textBoxSerialNumber.Text);
                make = this.textBoxMake.Text;
                model = this.textBoxModel.Text;
                speed = Convert.ToInt32(this.textBoxSpeed.Text);

                // Parse the made date from the text boxes
                currentMonth = Convert.ToInt32(this.textBoxMonth.Text);
                currentDay = Convert.ToInt32(this.textBoxDay.Text);
                currentYear = Convert.ToInt32(this.textBoxYear.Text);

                // Set the manufacturing date to the currentMadeDate object
                currentMadeDate.Month = currentMonth;
                currentMadeDate.Day = currentDay;
                currentMadeDate.Year = currentYear;

                // Process based on the selected bike type
                if (currentBikeType == EnumBikeType.MountainBike)
                {
                    MountainBike currentMBike = new MountainBike();



                    int height;
                    EnumSuspension currentSuspension;

                    if (string.IsNullOrWhiteSpace(this.textBoxHeight.Text))
                    {
                        MessageBox.Show("Please enter the height from ground of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(this.textBoxHeight.Text, out double newHeight))
                    {
                        MessageBox.Show("Please enter a valid height from ground.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (comboBoxSuspension.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a suspension type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double Speedtest = Convert.ToInt32(this.textBoxSpeed.Text);
                    if (Speedtest > currentMBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                   "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else
                    {
                        currentMBike.Speed = speed;
                    }

                    // Set properties of MountainBike
                    currentMBike.SerialNumber = serial_number;
                    currentMBike.Make = make;
                    currentMBike.Model = model;
                   
                    currentMBike.Frame = currentFrame;
                    currentMBike.Brakes = currentBrakes;
                    currentMBike.MadeDate = currentMadeDate;
                    currentMBike.Color = currentColor;
                    currentMBike.Type = currentBikeType;

                    try
                    {
                        // Parse and set the additional properties of MountainBike
                        height = Convert.ToInt32(this.textBoxHeight.Text);
                        currentMBike.Height = height;

                        Enum.TryParse(this.comboBoxSuspension.Text, out currentSuspension);
                        currentMBike.Suspension = currentSuspension;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    // Add the MountainBike to the data collection
                    if (DataCollection.ListOfBikes != null)
                    {
                        DataCollection.Add(currentMBike);
                    }

                }
                else if (currentBikeType == EnumBikeType.RoadBike)
                {
                    RoadBike currentRBike = new RoadBike();
                    int seat_height;
                    double Speedtest = Convert.ToInt32(this.textBoxSpeed.Text);
                    if (Speedtest > currentRBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                   "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else
                    {
                        currentRBike.Speed = speed;
                    }

                    if (string.IsNullOrWhiteSpace(this.textBoxSeatHeight.Text))
                    {
                        MessageBox.Show("Please enter the seat height of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(this.textBoxSeatHeight.Text, out double newSheight))
                    {
                        MessageBox.Show("Please enter a valid seat height.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                  


                    // Set properties of RoadBike
                    currentRBike.SerialNumber = serial_number;
                    currentRBike.Make = make;
                    currentRBike.Model = model;
                   
                    currentRBike.Frame = currentFrame;
                    currentRBike.Brakes = currentBrakes;
                    currentRBike.MadeDate = currentMadeDate;
                    currentRBike.Color = currentColor;
                    currentRBike.Type = currentBikeType;

                    try
                    {
                        // Parse and set the additional property of RoadBike
                        seat_height = Convert.ToInt32(this.textBoxSeatHeight.Text);
                        currentRBike.SeatHeight = seat_height;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    // Add the RoadBike to the data collection
                    if (DataCollection.ListOfBikes != null)
                    {
                        DataCollection.Add(currentRBike);
                    }

                }
                else if (currentBikeType == EnumBikeType.FatBike)
                {
                    FatBike currentFBike = new FatBike();
                    int tireWidth;

                    if (string.IsNullOrWhiteSpace(this.textBoxTireWidth.Text))
                    {
                        MessageBox.Show("Please enter the tire width of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(this.textBoxTireWidth.Text, out double newWidth))
                    {
                        MessageBox.Show("Please enter a valid tire width.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double Speedtest = Convert.ToInt32(this.textBoxSpeed.Text);
                    if (Speedtest > currentFBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                   "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else
                    {
                        currentFBike.Speed = speed;
                    }
                    // Set properties of FatBike
                    currentFBike.SerialNumber = serial_number;
                    currentFBike.Make = make;
                    currentFBike.Model = model;
                   
                    currentFBike.Frame = currentFrame;
                    currentFBike.Brakes = currentBrakes;
                    currentFBike.MadeDate = currentMadeDate;
                    currentFBike.Color = currentColor;
                    currentFBike.Type = currentBikeType;

                    try
                    {
                        // Parse and set the additional property of FatBike
                        tireWidth = Convert.ToInt32(this.textBoxTireWidth.Text);
                        currentFBike.Width = tireWidth;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    // Add the FatBike to the data collection
                    if (DataCollection.ListOfBikes != null)
                    {
                        DataCollection.Add(currentFBike);
                    }

                }
            }
            catch (Exception ex)
            {
                // Display error message if any exception occurs
                MessageBox.Show(ex.Message + "\n \t You must input a valid data");
                this.textBoxSerialNumber.Focus();
            }

            //deactivate the ADD button to avoid entering the same item twice
            this.buttonAdd.Enabled = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            // Clear the items in the listBox
            this.listBoxBikes.Items.Clear();


            // Check if the list of bikes is not null, has items, and the listBox is empty
            if (DataCollection.GetBikeList() != null && DataCollection.GetBikeList().Count > 0 && this.listBoxBikes.Items.Count == 0)
            {
                // Loop through each bike in the list
                foreach (Bike currentBike in DataCollection.GetBikeList())
                {
                    // If the bike is a MountainBike, cast it and add its string representation to the listBox
                    if (currentBike is MountainBike)
                    {
                        currentMBike = (MountainBike)currentBike;

                        this.listBoxBikes.Items.Add(currentMBike.ToString());
                    }
                    // If the bike is a RoadBike, cast it and add its state string representation to the listBox
                    else if (currentBike is RoadBike)
                    {
                        currentRBike = (RoadBike)currentBike;

                        this.listBoxBikes.Items.Add(currentRBike.GetState());
                    }
                    // If the bike is a FatBike, cast it and add its state string representation to the listBox
                    else if (currentBike is FatBike)
                    {
                        currentFBike = (FatBike)currentBike;

                        this.listBoxBikes.Items.Add(currentFBike.GetState());
                    }
                }
            }
            else
            {
                // Show a message if the list is already printed or empty
                MessageBox.Show("The list of bikes are already printed in the listBox or the list of items in memory is empty....");
            }

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare and parse the selected bike type
            EnumBikeType BikeType;
            Enum.TryParse(this.comboBoxType.Text, out BikeType);

            // Hide all bike type pictures and show the question mark picture by default
            this.pictureBoxFBike.Visible = false;
            this.pictureBoxRBike.Visible = false;
            this.pictureBoxMBike.Visible = false;
            this.pictureBoxQuestion.Visible = true;

            // Adjust the form controls based on the selected bike type
            if (BikeType == EnumBikeType.MountainBike)
            {
                this.textBoxHeight.Enabled = true;
                this.comboBoxSuspension.Enabled = true;
                this.textBoxSeatHeight.Enabled = false;
                this.textBoxTireWidth.Enabled = false;
                trackBarSpeedUp.Value = trackBarSpeedUp.Minimum;
                this.pictureBoxMBike.Visible = true;
                this.pictureBoxQuestion.Visible = false;

            }
            else if (BikeType == EnumBikeType.RoadBike)
            {
                this.textBoxHeight.Enabled = false;
                this.comboBoxSuspension.Enabled = false;
                this.textBoxSeatHeight.Enabled = true;
                this.textBoxTireWidth.Enabled = false;
                trackBarSpeedUp.Value = trackBarSpeedUp.Minimum;
                this.pictureBoxRBike.Visible = true;
                this.pictureBoxQuestion.Visible = false;


            }
            else if (BikeType == EnumBikeType.FatBike)
            {
                this.textBoxHeight.Enabled = false;
                this.comboBoxSuspension.Enabled = false;
                this.textBoxSeatHeight.Enabled = false;
                this.textBoxTireWidth.Enabled = true;
                trackBarSpeedUp.Value = trackBarSpeedUp.Minimum;
                this.pictureBoxFBike.Visible = true;
                this.pictureBoxQuestion.Visible = false;


            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //clearing input fields
            this.comboBoxType.Text = Convert.ToString(EnumBikeType.Undefined);
            this.textBoxSerialNumber.Text = string.Empty;
            this.textBoxSerialNumber.Focus();

            this.textBoxMake.Text = string.Empty;
            this.textBoxModel.Text = string.Empty;
            this.textBoxSpeed.Text = string.Empty;

            this.textBoxMonth.Text = string.Empty;
            this.textBoxDay.Text = string.Empty;
            this.textBoxYear.Text = string.Empty;
            this.textBoxTireWidth.Text = string.Empty;

            // Reset the combo box selections to their default values
            this.comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);
            this.comboBoxBrakes.Text = Convert.ToString(EnumBrakes.Undefined);
            this.comboBoxFrame.Text = Convert.ToString(EnumFrameType.Undefined);
            this.comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);


            this.textBoxHeight.Text = string.Empty;

            this.textBoxSeatHeight.Text = string.Empty;

            this.textBoxHeight.Enabled = true;
            this.comboBoxSuspension.Enabled = true;
            this.textBoxHeight.Enabled = true;
            this.textBoxSeatHeight.Enabled = true;

            // Clear the list box items
            this.listBoxBikes.Items.Clear();
            // Enable the Add button
            this.buttonAdd.Enabled = true;
            // Reset the track bar value
            trackBarSpeedUp.Value = trackBarSpeedUp.Minimum;

        }

        private void buttonPrintMBike_Click(object sender, EventArgs e)
        {
            // Clear the list box items
            this.listBoxBikes.Items.Clear();
            // Iterate through the mountain bike list and add each bike's state to the list box
            foreach (MountainBike currentMBike in DataCollection.GetMountainBikeList())
            {
                this.listBoxBikes.Items.Add(currentMBike.GetState());
                // Show the mountain bike picture box and hide others
                this.pictureBoxFBike.Visible = false;
                this.pictureBoxRBike.Visible = false;
                this.pictureBoxMBike.Visible = true;
                this.pictureBoxQuestion.Visible = false;
            }
        }

        private void buttonPrintRBike_Click(object sender, EventArgs e)
        {// Clear the list box items
            this.listBoxBikes.Items.Clear();
            // Iterate through the road bike list and add each bike's state to the list box
            foreach (RoadBike currentRBike in DataCollection.GetRoadBikeList())
            {
                this.listBoxBikes.Items.Add(currentRBike.GetState());
                // Show the road bike picture box and hide others
                this.pictureBoxFBike.Visible = false;
                this.pictureBoxRBike.Visible = true;
                this.pictureBoxMBike.Visible = false;
                this.pictureBoxQuestion.Visible = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            bool found = false;
            Bike bikeToSearch = null;
            MountainBike currentMBike; RoadBike currentRBike; FatBike currentFBike;

            //iterate through the list to find the specific bike
            foreach (Bike currentBike in DataCollection.ListOfBikes)
            {
                if (currentBike.SerialNumber == Convert.ToInt32(this.textBoxSerialNumber.Text))
                {
                    found = true;
                    bikeToSearch = currentBike;
                    break;
                }
            }
            // If the bike is found, display its information
            if (found)
            {
                // Check the type of the found bike and display a message box with its state
                if (bikeToSearch.Type == EnumBikeType.MountainBike)
                {
                    currentMBike = (MountainBike)bikeToSearch;

                    MessageBox.Show("Mountain Bike found ..." + currentMBike.GetState(),
                     "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBikes.Items.Add(currentMBike.GetState());
                }

                else if (bikeToSearch.Type == EnumBikeType.RoadBike)
                {
                    currentRBike = (RoadBike)bikeToSearch;

                    MessageBox.Show("Road Bike found ..." + currentRBike.GetState(),
                     "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBikes.Items.Add(currentRBike.GetState());

                }
                else if (bikeToSearch.Type == EnumBikeType.FatBike)
                {
                    currentFBike = (FatBike)bikeToSearch;

                    MessageBox.Show("Road Bike found ..." + currentFBike.GetState(),
                     "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBikes.Items.Add(currentFBike.GetState());

                }

            }
            else
            {// If the bike is not found, display a message box
                MessageBox.Show("Item not found ...",
                    "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            EnumBikeType currentBikeType;
            Enum.TryParse(this.comboBoxType.Text, out currentBikeType);
            // Check if the list of bikes is not null and the currentIndex is valid
            if (DataCollection.ListOfBikes != null)
            {
                // Update the currentBikeType if the list of bikes is not null
                currentBikeType = DataCollection.ListOfBikes[currentIndex].Type;
            }

            if (currentIndex >= 0 && listOfBikes != null)
            {
                
                // Update the bike based on its type
                if (currentBikeType == EnumBikeType.MountainBike)
                {
                    MountainBike currentMBike = new MountainBike();

                    // Assign new values
                 
                  
                    ///Validation for empty input fields

                    if (comboBoxType.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a Bike Type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (comboBoxType.Text != "MountainBike")
                    {
                        MessageBox.Show("Cannot change bike type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.textBoxSerialNumber.Text))
                    {
                        MessageBox.Show("Please enter a serial number.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //Validation for incorrect input type
                    if (!int.TryParse(this.textBoxSerialNumber.Text, out int serialNumber))
                    {
                        MessageBox.Show("Invalid Serial Number Format", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxMake.Text))
                    {
                        MessageBox.Show("Please enter the make of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxModel.Text))
                    {
                        MessageBox.Show("Please enter the model of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxSpeed.Text))
                    {
                        MessageBox.Show("Please enter the speed of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(this.textBoxSpeed.Text, out double newSpeed))
                    {
                        MessageBox.Show("Please enter a valid speed.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxHeight.Text))
                    {
                        MessageBox.Show("Please enter the height from ground of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(this.textBoxHeight.Text, out double newHeight))
                    {
                        MessageBox.Show("Please enter a valid height from ground.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    if (string.IsNullOrWhiteSpace(this.textBoxDay.Text))
                    {
                        MessageBox.Show("Please enter the Day the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.textBoxMonth.Text))
                    {
                        MessageBox.Show("Please enter the Month the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.textBoxYear.Text))
                    {
                        MessageBox.Show("Please enter the year the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //validating date format
                    if (!int.TryParse(this.textBoxMonth.Text, out int monthValue) ||
                         !int.TryParse(this.textBoxDay.Text, out int dayValue) ||
                          !int.TryParse(this.textBoxYear.Text, out int yearValue))
                    {
                        MessageBox.Show("Please enter a valid date.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        DateTime date = new DateTime(yearValue, monthValue, dayValue);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please enter a valid date.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    if (comboBoxColor.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a color.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (comboBoxFrame.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a frame type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (comboBoxBrakes.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a brakes type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (comboBoxSuspension.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a suspension type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }





                    currentMBike.Type = currentBikeType;
                    currentMBike.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentMBike.Make = this.textBoxMake.Text;
                    currentMBike.Model = this.textBoxModel.Text;

                    //double originalSpeed = currentMBike.Speed;
                    double Speedtest = Convert.ToInt32(this.textBoxSpeed.Text);
                    if (Speedtest > currentMBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                   "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       return;
                    
                    }
                    else
                    {
                        currentMBike.Speed = Convert.ToInt32(this.textBoxSpeed.Text);
                    }

                        EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentMBike.Color = currentColor;

                    EnumFrameType currentFrame;
                    Enum.TryParse(this.comboBoxFrame.Text, out currentFrame);
                    currentMBike.Frame = currentFrame;

                    EnumBrakes currentBrakes;
                    Enum.TryParse(this.comboBoxBrakes.Text, out currentBrakes);
                    currentMBike.Brakes = currentBrakes;

                    EnumSuspension currentSuspension;
                    Enum.TryParse(this.comboBoxSuspension.Text, out currentSuspension);
                    currentMBike.Suspension = currentSuspension;


                    Date currentDate = new Date();
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentMBike.MadeDate = currentDate;

                    currentMBike.Height = Convert.ToInt32(this.textBoxHeight.Text);
                    double tspeed = Convert.ToDouble(this.trackBarSpeedUp.Value);
                    currentMBike.SpeedUp(tspeed); //calls speed up function to assign new speed

                    // Remove the old bike and insert the updated one at the same index
                    DataCollection.RemoveAt(currentIndex);

                    DataCollection.InsertAt(currentIndex, currentMBike);

                }
                else if (currentBikeType == EnumBikeType.RoadBike)
                {
                    RoadBike currentRBike = new RoadBike();

                    if (comboBoxType.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a Bike Type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (comboBoxType.Text != "RoadBike")
                    {
                        MessageBox.Show("Cannot change bike type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.textBoxSerialNumber.Text))
                    {
                        MessageBox.Show("Please enter a serial number.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //Validation for incorrect input type
                    if (!int.TryParse(this.textBoxSerialNumber.Text, out int serialNumber))
                    {
                        MessageBox.Show("Invalid Serial Number Format", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxMake.Text))
                    {
                        MessageBox.Show("Please enter the make of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxModel.Text))
                    {
                        MessageBox.Show("Please enter the model of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxSpeed.Text))
                    {
                        MessageBox.Show("Please enter the speed of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(this.textBoxSpeed.Text, out double newSpeed))
                    {
                        MessageBox.Show("Please enter a valid speed.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxSeatHeight.Text))
                    {
                        MessageBox.Show("Please enter the seat height of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(this.textBoxSeatHeight.Text, out double newSheight))
                    {
                        MessageBox.Show("Please enter a valid seat height.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    if (string.IsNullOrWhiteSpace(this.textBoxDay.Text))
                    {
                        MessageBox.Show("Please enter the Day the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.textBoxMonth.Text))
                    {
                        MessageBox.Show("Please enter the Month the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.textBoxYear.Text))
                    {
                        MessageBox.Show("Please enter the year the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //validating date format
                    if (!int.TryParse(this.textBoxMonth.Text, out int monthValue) ||
                         !int.TryParse(this.textBoxDay.Text, out int dayValue) ||
                          !int.TryParse(this.textBoxYear.Text, out int yearValue))
                    {
                        MessageBox.Show("Please enter a valid date.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        DateTime date = new DateTime(yearValue, monthValue, dayValue);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please enter a valid date.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    if (comboBoxColor.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a color.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (comboBoxFrame.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a frame type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (comboBoxBrakes.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a brakes type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    currentRBike.Type = currentBikeType;
                    currentRBike.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentRBike.Make = this.textBoxMake.Text;
                    currentRBike.Model = this.textBoxModel.Text;

                    //check if bike exceeds speed before updating
                    double Speedtest = Convert.ToInt32(this.textBoxSpeed.Text);
                    if (Speedtest > currentRBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                   "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else
                    {
                        currentRBike.Speed = Convert.ToInt32(this.textBoxSpeed.Text);
                    }


                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentRBike.Color = currentColor;

                    EnumFrameType currentFrame;
                    Enum.TryParse(this.comboBoxFrame.Text, out currentFrame);
                    currentRBike.Frame = currentFrame;

                    EnumBrakes currentBrakes;
                    Enum.TryParse(this.comboBoxBrakes.Text, out currentBrakes);
                    currentRBike.Brakes = currentBrakes;




                    Date currentDate = new Date();
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentRBike.MadeDate = currentDate;

                    currentRBike.SeatHeight = Convert.ToInt32(this.textBoxSeatHeight.Text);

                    double tspeed = Convert.ToDouble(this.trackBarSpeedUp.Value);
                    currentRBike.SpeedUp(tspeed);

                    DataCollection.RemoveAt(currentIndex);

                    DataCollection.InsertAt(currentIndex, currentRBike);

                }
                else if (currentBikeType == EnumBikeType.FatBike)
                {
                    FatBike currentFBike = new FatBike();


                    if (comboBoxType.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a Bike Type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (comboBoxType.Text != "FatBike")
                    {
                        MessageBox.Show("Cannot change bike type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.textBoxSerialNumber.Text))
                    {
                        MessageBox.Show("Please enter a serial number.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //Validation for incorrect input type
                    if (!int.TryParse(this.textBoxSerialNumber.Text, out int serialNumber))
                    {
                        MessageBox.Show("Invalid Serial Number Format", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxMake.Text))
                    {
                        MessageBox.Show("Please enter the make of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxModel.Text))
                    {
                        MessageBox.Show("Please enter the model of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxSpeed.Text))
                    {
                        MessageBox.Show("Please enter the speed of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(this.textBoxSpeed.Text, out double newSpeed))
                    {
                        MessageBox.Show("Please enter a valid speed.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(this.textBoxTireWidth.Text))
                    {
                        MessageBox.Show("Please enter the tire width of the bike.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!double.TryParse(this.textBoxTireWidth.Text, out double newWidth))
                    {
                        MessageBox.Show("Please enter a valid tire width.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    if (string.IsNullOrWhiteSpace(this.textBoxDay.Text))
                    {
                        MessageBox.Show("Please enter the Day the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.textBoxMonth.Text))
                    {
                        MessageBox.Show("Please enter the Month the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.textBoxYear.Text))
                    {
                        MessageBox.Show("Please enter the year the bike was made.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //validating date format
                    if (!int.TryParse(this.textBoxMonth.Text, out int monthValue) ||
                         !int.TryParse(this.textBoxDay.Text, out int dayValue) ||
                          !int.TryParse(this.textBoxYear.Text, out int yearValue))
                    {
                        MessageBox.Show("Please enter a valid date.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        DateTime date = new DateTime(yearValue, monthValue, dayValue);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please enter a valid date.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    if (comboBoxColor.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a color.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (comboBoxFrame.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a frame type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (comboBoxBrakes.Text == "Undefined")
                    {
                        MessageBox.Show("Please select a brakes type.", "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                  





                    currentFBike.Type = currentBikeType;
                    currentFBike.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentFBike.Make = this.textBoxMake.Text;
                    currentFBike.Model = this.textBoxModel.Text;

                    double Speedtest = Convert.ToInt32(this.textBoxSpeed.Text);
                    if (Speedtest > currentFBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                   "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else
                    {
                        currentFBike.Speed = Convert.ToInt32(this.textBoxSpeed.Text);
                    }


                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentFBike.Color = currentColor;

                    EnumFrameType currentFrame;
                    Enum.TryParse(this.comboBoxFrame.Text, out currentFrame);
                    currentFBike.Frame = currentFrame;

                    EnumBrakes currentBrakes;
                    Enum.TryParse(this.comboBoxBrakes.Text, out currentBrakes);
                    currentFBike.Brakes = currentBrakes;




                    Date currentDate = new Date();
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentFBike.MadeDate = currentDate;

                    currentFBike.Width = Convert.ToInt32(this.textBoxTireWidth.Text);

                    double tspeed = Convert.ToDouble(this.trackBarSpeedUp.Value);
                    currentFBike.SpeedUp(tspeed);

                    DataCollection.RemoveAt(currentIndex);

                    DataCollection.InsertAt(currentIndex, currentFBike);

                }
            }
            else
            {
                MessageBox.Show("Choose from the listBox the Bike to UPDATE");
            }

            this.listBoxBikes.Items.Clear();

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && listOfBikes != null)
            {


                // Remove the bike at the current index
                DataCollection.ListOfBikes.RemoveAt(currentIndex);
            }
            else
            {
                MessageBox.Show("Choose from the listBox the Bike to REMOVE");
            }
            // Clear the listBox after removing
            this.listBoxBikes.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Shaquille Neil & Ping Chun Lui", "Event Programming with C#",
         MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void buttonWriteXml_Click(object sender, EventArgs e)
        {
            if (DataCollection.ListOfBikes != null)
            {
                // Call the WriteToXmlFile method of the FileManager class to write the list of bikes to an XML file
                FileManager.WriteToXmlFile(DataCollection.ListOfBikes);
            }
        }

        private void buttonReadXml_Click(object sender, EventArgs e)
        {
            // Clear the existing list of bikes
            this.listOfBikes.Clear();

            // Read the list of bikes from the XML file
            DataCollection.ListOfBikes = FileManager.ReadFromXmlFile();

            if ((DataCollection.ListOfBikes = FileManager.ReadFromXmlFile()) != null)
            {
                foreach (Bike currentBike in DataCollection.ListOfBikes)
                {
                    if (currentBike is MountainBike)
                    {
                        currentMBike = (MountainBike)currentBike;

                        this.listBoxBikes.Items.Add(currentMBike.GetState());

                    }

                    else if (currentBike is RoadBike)
                    {
                        currentRBike = (RoadBike)currentBike;

                        this.listBoxBikes.Items.Add(currentRBike.GetState());

                    }
                    else if (currentBike is FatBike)
                    {
                        currentFBike = (FatBike)currentBike;

                        this.listBoxBikes.Items.Add(currentFBike.GetState());

                    }
                }

            }

        }

        private void trackBarSpeedUp_Scroll(object sender, EventArgs e)
        {
            // Get the current bike type
            EnumBikeType currentBike;
            Enum.TryParse(this.comboBoxType.Text, out currentBike);
            // Check if the list of bikes is not null and the current index is valid
            if (DataCollection.ListOfBikes != null)
            {
                currentBike = DataCollection.ListOfBikes[currentIndex].Type;
            }


            if (currentIndex >= 0 && listOfBikes != null)
            {
                // Check the current bike type and update the speed accordingly
                if (currentBike == EnumBikeType.MountainBike)
                {
                    MountainBike currentMBike = new MountainBike();
                    double test = Convert.ToInt32(this.textBoxSpeed.Text) + trackBarSpeedUp.Value;
                    if (test > currentMBike.GetMaxSpeed())
                    {
                        // Display a warning message if the speed exceeds the maximum allowed speed
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                  "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        trackBarSpeedUp.Value = trackBarSpeedUp.Minimum;

                    }




                }

                else if (currentBike == EnumBikeType.RoadBike)
                {
                    RoadBike currentRBike = new RoadBike();
                    double test = Convert.ToInt32(this.textBoxSpeed.Text) + trackBarSpeedUp.Value;
                    if (test > currentRBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        trackBarSpeedUp.Value = trackBarSpeedUp.Minimum;
                    }


                }
                else if (currentBike == EnumBikeType.FatBike)
                {
                    FatBike currentFBike = new FatBike();
                    double test = Convert.ToInt32(this.textBoxSpeed.Text) + trackBarSpeedUp.Value;
                    if (test > currentFBike.GetMaxSpeed())
                    {
                        MessageBox.Show("Cannot Exceed Max Speed ...",
                     "Bike Library", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        trackBarSpeedUp.Value = trackBarSpeedUp.Minimum;
                    }


                }

            }

        }

        private void buttonFatBikes_Click(object sender, EventArgs e)
        {
            // Clear the items in the list box
            this.listBoxBikes.Items.Clear();
            // Iterate through the list of Fat Bikes and add their state to the list box
            foreach (FatBike currentFBike in DataCollection.GetFatBikeList())
            {
                this.listBoxBikes.Items.Add(currentFBike.GetState());
                // Show the Fat Bike picture and hide other bike pictures
                this.pictureBoxFBike.Visible = true;
                this.pictureBoxRBike.Visible = false;
                this.pictureBoxMBike.Visible = false;
                this.pictureBoxQuestion.Visible = false;
            }

        }
    }
}
