using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnect
{
    public partial class frmDBConnect : Form
    {
        
        DBConnection db = null;
        List<CarInfo> CarInfoList = null;

        int currentIndex = 0;

        public frmDBConnect()
        {
            InitializeComponent();
        }
        private void MakeDBConnection()
        {
            this.db = new DBConnection("localhost", "hire", "csharp", "password");

            if (db.Connect()==false)
                MessageBox.Show("Problem connecting to MySql database");
            //db.Close();
        }

        
        private void Loadcars()
        {
            DBCars dbcars = new DBCars();
            MySqlDataReader reader = dbcars.GetCars(this.db.Connection);

            while (reader.Read())
            {
                string vehicleRegNo = reader.GetString(0);
                string make = reader.GetString(1);
                string engineSize = reader.GetString(2);
                DateTime dateregistered = reader.GetDateTime(3);
                double rentalCost = reader.GetDouble(4);
                int available = reader.GetInt32(5);

                //string message = string.Format($"Vehicle registration = {vehicleRegNo}, Make = {make}, Date registered = {dateregistered}, Engine size = {engineSize},Cost= { rentalCost}, Available = {available}");
                //MessageBox.Show(message);

                CarInfo carinfo = new CarInfo(vehicleRegNo,make,engineSize,rentalCost,available,dateregistered);
                this.CarInfoList.Add(carinfo);
            }

            reader.Close();
        } 
        

        private void DBConnect_Load(object sender, EventArgs e)
        {
            ToolTip toolTip =new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.SetToolTip(this.textBoxRegNumber, "Enter the registration number of the vehicle");
            toolTip.SetToolTip(this.textBoxMake, "Enter the make of the vehicle");
            toolTip.SetToolTip(this.textBoxEngineSize, "Enter the engine size of the vehicle");


            this.CarInfoList = new List<CarInfo>();
            MakeDBConnection();
            Loadcars();
            //
            DisplayCarInfo(currentIndex);
        }

        private void DisplayCarInfo(int index)
        {
            CarInfo carInfo                 = this.CarInfoList[index];
            this.textBoxRegNumber.Text      = carInfo.VehicleRegNo;
            this.textBoxMake.Text           = carInfo.Make;
            this.textBoxEngineSize.Text     = carInfo.Engine_Size;
            this.textBoxDateRegistered.Text = $"{carInfo.Date_Registered:yyyy-MM-dd}";
            this.textBoxRentalPerDay.Text   = $"€{carInfo.Rentalcost:n2}";
            if (carInfo.Available == 1)
            {
                this.checkBoxAvailable.Checked = true;
            }
            else
            {
                this.checkBoxAvailable.Checked = false;
            }
                textBoxRange.Text = BuildNavigationStatus();
        }

        private void FrmConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.db != null)
            {
                this.db.Close();
            }
        }

        private bool VehicleRegHasChanged()
        {
            CarInfo currentCarInfo = this.CarInfoList[this.currentIndex];

            if (currentCarInfo.VehicleRegNo != this.textBoxRegNumber.Text)
            {

                return true;
            }
            return false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DBCars dbCars = new DBCars();
            CarInfo currentCarInfo = this.CarInfoList[this.currentIndex];

                    //if (VehicleRegHasChanged() && ListContainsVehicleRegNo(this.textBoxDateRegistered.Text))
                    //{
                    //    MessageBox.Show($"Vehicle registration number:{this.textBoxRegNumber} already exists.\n Vehicle registration number must be unique.");
                    //    return;
                    //}
                    string originalVehicleRegNo = this.CarInfoList[this.currentIndex].VehicleRegNo;    
            
                    CarInfo carInfo = CreateCarInfoFromForm();

                    if (carInfo==null)
                        {
                            return;    
                        }
                    

                    if (dbCars.Update(db.Connection, originalVehicleRegNo, carInfo) == true)
                    {
                        this.CarInfoList[this.currentIndex] = carInfo;
                        MessageBox.Show($"Vehicle Reg No: {carInfo.VehicleRegNo} has been updated" , "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DBCars dbCars = new DBCars();

            CarInfo carInfo = CreateCarInfoFromForm();

            if (carInfo == null)
            {
                return;
            }

            this.CarInfoList.Add(carInfo);
            //add record to database
            if (dbCars.Insert(this.db.Connection, carInfo) == true)
            {
                //Update navigation controls
                this.currentIndex = this.CarInfoList.Count - 1;

                DisplayCarInfo(this.currentIndex);
                MessageBox.Show($"Vehicle Reg No: {carInfo.VehicleRegNo} has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DBCars dbCars = new DBCars();
            String vehicleRegNo = this.CarInfoList[this.currentIndex].VehicleRegNo;
            DialogResult  result=MessageBox.Show($"You are about to delete Vehicle Reg:{vehicleRegNo}. \n Are you sure to continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (result ==DialogResult.No)
            {
                return;
            }

            if (dbCars.Delete(db.Connection, vehicleRegNo) == true)
            {
                this.CarInfoList.RemoveAt(currentIndex);

                //if we have removed the last element in the list, we need to 
                //move the current index back one place 

                if (this.currentIndex == this.CarInfoList.Count)
                {
                    this.currentIndex--;
                }

                DisplayCarInfo(this.currentIndex);
            }
            
        }



        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.currentIndex+1 < (this.CarInfoList.Count))
            {
                this.currentIndex++;
                DisplayCarInfo(currentIndex);
                
            }
            else
                MessageBox.Show("No more records exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.currentIndex = this.CarInfoList.Count - 1;
            DisplayCarInfo(this.currentIndex);
            

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (this.currentIndex>0)
            {
                this.currentIndex--;
                DisplayCarInfo(currentIndex);
            }
            else
                MessageBox.Show("There are no earlier records.");
                
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            this.currentIndex = 0;
            DisplayCarInfo(this.currentIndex);
            
        }

        private string BuildNavigationStatus()
        {
            return $"{this.currentIndex+1} of {this.CarInfoList.Count}";
             
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ListContainsVehicleRegNo(string vehicleRegNo)
        {
            foreach (CarInfo carInfo in CarInfoList)
            {
                if (carInfo.VehicleRegNo == vehicleRegNo)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidateVehicleRegNo(string vehicleRegNo)
        {
            if (vehicleRegNo.Length>0 && vehicleRegNo.Length <= 10)
            {
                
                return true;
            }
            MessageBox.Show("Vehicle Registration No must be greater than 0 charecters and no  more than 10 charecters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private bool ValidateMake(string make)
        {
            if (make.Length > 0 && make.Length <= 50)
            {

                return true;
            }
            MessageBox.Show("Make must be greater than 0 charecters and no more than 50 characters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private bool ValidateEngineSize(string engineSize)
        {
            if (engineSize.Length > 0 && engineSize.Length <= 10)
            {

                return true;
            }
            MessageBox.Show("Engine size must be greater than 0 charecters and and no more than 10", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private CarInfo CreateCarInfoFromForm()
        {
            String vehicleRegNo     = this.textBoxRegNumber.Text;
            if (ValidateVehicleRegNo(vehicleRegNo) == false)
            {
                return null;
            }
            String Make             = this.textBoxMake.Text;
            if (ValidateMake(Make) == false)
            {
                return null;
            }
            String EngineSize       = this.textBoxEngineSize.Text;
            if (ValidateEngineSize(EngineSize) == false)
            {
                return null;
            }
            DateTime dateRegistered;

            if (DateTime.TryParse(this.textBoxDateRegistered.Text, out dateRegistered) == false)
            {
                MessageBox.Show("Please enter a date in the format YYYY-MM-DD", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            String StringRentalPerDay = "";
            if (this.textBoxRentalPerDay.Text.Length > 0)
            {
                StringRentalPerDay = this.textBoxRentalPerDay.Text.Substring(1);
            }
            Double RentalPerDay;

            if (Double.TryParse(StringRentalPerDay, out RentalPerDay) == false)
            {
                MessageBox.Show("Please enter a valid rental cost", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            int available           = 0;

            if (this.checkBoxAvailable.Checked)
            {
                available           = 1;
            }

            CarInfo carInfo         = new CarInfo(vehicleRegNo, Make, EngineSize, RentalPerDay, available, dateRegistered);
            return carInfo;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DisplayCarInfo(this.currentIndex);
        }

        private string GetCarDescriptions()
        {
            string CarDescription = "";
            foreach (CarInfo carinfo in CarInfoList)
            {
                CarDescription += carinfo.ToString()+"\n";
                
            }
            return CarDescription;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string carDescriptions = GetCarDescriptions();
            DocumentPrinter documentPrinter = new DocumentPrinter(carDescriptions, "Car details");
            documentPrinter.Print();

        }
    }
}
