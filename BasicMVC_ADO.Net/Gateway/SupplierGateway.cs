using BasicMVC_ADO.Net.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BasicMVC_ADO.Net.Gateway
{
    public class SupplierGateway : CommonGateway
    {

        //To View Supplier Details

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> aSuppliers = new List<Supplier>();

            Connection.Open();
            Command = new SqlCommand("GetSupplier", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Clear();

            Reader = Command.ExecuteReader();

            DataTable dt = new DataTable();


            while (Reader.Read())
            {
                Supplier aSupplier = new Supplier();

                aSupplier.Id = (int)Reader["Id"];
                aSupplier.SupplierName = Reader["SupplierName"].ToString();
                aSupplier.ContactNo = (int)Reader["ContactNo"];
                aSupplier.Email = Reader["Email"].ToString();
                aSupplier.Address = Reader["Address"].ToString();

                aSuppliers.Add(aSupplier);
            }

            /*
            dt.Load(Reader);

            foreach (DataRow data in dt.Rows)
            {
                aSuppliers.Add(
                    new Supplier
                    {
                        Id = Convert.ToInt32(data["Id"]),
                        SupplierName = Convert.ToString(data["SupplierName"]),
                        ContactNo = Convert.ToInt32(data["ContactNo"]),
                        Email = Convert.ToString(data["Email"]),
                        Address = Convert.ToString(data["Address"])

                    }
                    );
            }

            */

            Reader.Close();
            Connection.Close();

            return aSuppliers;
        }


        //To Add Suppler

        public bool AddSupplier(Supplier aSupplier)
        {
            Connection.Open();

            Command = new SqlCommand("AddNewSupplierDetails", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Clear();

            Command.Parameters.AddWithValue("@SupplierName", aSupplier.SupplierName);
            Command.Parameters.AddWithValue("@ContactNo", aSupplier.ContactNo);
            Command.Parameters.AddWithValue("@Email", aSupplier.Email);
            Command.Parameters.AddWithValue("@Address", aSupplier.Address);


            int i = Command.ExecuteNonQuery();
            Connection.Close();

            if (i >= 1)
                return true;
            else
            {
                return false;
            }

        }


        //To Update Supplier Details

        public bool UpdateSupplier(Supplier aSupplier)
        {
            Connection.Open();
            Command = new SqlCommand("UpdateSupplierDetails", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Clear();

            Command.Parameters.AddWithValue("@Id", aSupplier.Id);
            Command.Parameters.AddWithValue("@SupplierName", aSupplier.SupplierName);
            Command.Parameters.AddWithValue("@ContactNo", aSupplier.ContactNo);
            Command.Parameters.AddWithValue("@Email", aSupplier.Email);
            Command.Parameters.AddWithValue("@Address", aSupplier.Address);


            int i = Command.ExecuteNonQuery();
            Connection.Close();

            if (i >= 1)
                return true;
            else
            {
                return false;
            }

        }

        //To Delete SupplierById

        public bool DeleteSupplier(int Id)
        {
            Connection.Open();

            Command = new SqlCommand("DeleteSupplierByID", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Clear();

            Command.Parameters.AddWithValue("@Id", Id);


            int i = Command.ExecuteNonQuery();
            Connection.Close();

            if (i >= 1)
                return true;
            else
            {
                return false;
            }
        }


    }
}