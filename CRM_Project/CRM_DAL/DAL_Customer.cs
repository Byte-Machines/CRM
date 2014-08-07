﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient ;
using System.Configuration;
using CRM_BAL;
namespace CRM_DAL
{
    public class DAL_Customer
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        public int Customer_Save_Insert_Update_Delete(BAL_Customer bc)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@Cust_ID", bc.Cust_ID);
<<<<<<< HEAD
                cmd.Parameters.AddWithValue("@F_Date", bc.F_Date);
                cmd.Parameters.AddWithValue("@F_Message", bc.F_Message);
                cmd.Parameters.AddWithValue("@Walkins", bc.Walkins);
=======
                cmd.Parameters.AddWithValue("@Name", bc.Name);
                cmd.Parameters.AddWithValue("@Mobile_No", bc.Mobile_No);
                cmd.Parameters.AddWithValue("@Date_Of_Birth", bc.Date_Of_Birth);
                cmd.Parameters.AddWithValue("@Email_ID", bc.Email_ID);
                cmd.Parameters.AddWithValue("@Address", bc.Address);
                cmd.Parameters.AddWithValue("@Occupation", bc.Occupation);
>>>>>>> origin/master
                cmd.Parameters.AddWithValue("@S_Status", bc.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bc.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;


            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }
<<<<<<< HEAD
=======
        public int Customer_Update(BAL_Customer bc)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_Customer_Followup_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@FID", bc.FID);
                cmd.Parameters.AddWithValue("@S_Status", bc.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bc.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;


            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }
>>>>>>> origin/master
    }
}
