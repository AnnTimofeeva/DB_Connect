using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBConnect
{
    class DBCars
    {
        public MySqlDataReader GetCars(MySqlConnection connection)
        {
            string sql = "SELECT * FROM car;";
            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            try
            {
                reader = cmd.ExecuteReader();
            }

            catch(MySqlException exp )
            {
                MessageBox.Show("Exception found: "+exp.Message);
            }
            return reader;
        }

        public bool Update(MySqlConnection connection, string originalVehicleRegNo, CarInfo carInfo)
        {
            string sql = "UPDATE car SET VehicleRegNo=@vehicleRegNo, Make=@make,EngineSize=@engineSize,DateRegistered=@dateRegistered, RentalPerDay=@cost, Available=@available WHERE VehicleRegNo=@originalVehicleRegNo";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@vehicleregno", carInfo.VehicleRegNo);
            cmd.Parameters.AddWithValue("@make", carInfo.Make);
            cmd.Parameters.AddWithValue("@engineSize", carInfo.Engine_Size);
            cmd.Parameters.AddWithValue("@dateregistered", carInfo.Date_Registered);
            cmd.Parameters.AddWithValue("@cost", carInfo.Rentalcost);
            cmd.Parameters.AddWithValue("@available", carInfo.Available);
            cmd.Parameters.AddWithValue("@originalVehicleRegNo", originalVehicleRegNo);
            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Exception found: " + ex.Message);
                return false;
            }
            return true;
        }

        public bool Insert(MySqlConnection connection, CarInfo carInfo)
        {
            
            string sql = "INSERT INTO car(VehicleRegNo, Make, EngineSize, DateRegistered,RentalPerDay,Available) VALUES(@vehicleRegNo, @make, @enginesize, @dateregistered, @cost, @available)";
            //string sql = "UPDATE car SET VehicleRegNo=@vehicleRegNo, Make=@make,EngineSize=@engineSize,DateRegistered=@dateRegistered, RentalPerDay=@cost, Available=@available";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@vehicleregno", carInfo.VehicleRegNo);
            cmd.Parameters.AddWithValue("@make", carInfo.Make);
            cmd.Parameters.AddWithValue("@engineSize", carInfo.Engine_Size);
            cmd.Parameters.AddWithValue("@dateregistered", carInfo.Date_Registered);
            cmd.Parameters.AddWithValue("@cost", carInfo.Rentalcost);
            cmd.Parameters.AddWithValue("@available", carInfo.Available);

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Exception found: "+ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete(MySqlConnection connection, string vehicleRegNo)
        {
            string sql = "DELETE FROM car WHERE VehicleRegNo=@vehicleRegNo";
            //string sql = "UPDATE car SET VehicleRegNo=@vehicleRegNo, Make=@make,EngineSize=@engineSize,DateRegistered=@dateRegistered, RentalPerDay=@cost, Available=@available";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            
            cmd.Parameters.AddWithValue("@vehicleregno", vehicleRegNo);
            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Exception found: " + ex.Message);
                return false;
            }
            return true;
        }
    }
}
