using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace POManager
{
    public class DBCtrl
    {
        public SqlConnection sqlConn;
        ArrayList entity;

        public DBCtrl()
        {
        
        }
        
        public void DBConnect(string company)
        { 
            sqlConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
            sqlConn.Open();

            if ((sqlConn != null) && (sqlConn.State.Equals(ConnectionState.Open)))
            {
                CheckDB(company);
                CheckVenderTable();
                CheckPartsTable();
                CheckPOTable();
                CheckInputTable();
                CheckOutputTable();
            }
        }
        
        public void DBConnect(string servername, string id, string pwd, string company)
        {           
            sqlConn = new SqlConnection("Server="+servername+";uid="+id+";pwd="+pwd+";");
            sqlConn.Open();

            if ((sqlConn != null) && (sqlConn.State.Equals(ConnectionState.Open)))
            {
                CheckDB(company);
                CheckVenderTable();
                CheckPartsTable();
                CheckPOTable();
                CheckInputTable();
                CheckOutputTable();
            }
        }

        private void CheckDB(string company)
        {
            string useDB = "";

            if(company=="AiMS")
            {
                useDB = "POManager";
            }
            else if (company == "AsTEK")
            {
                useDB = "POManager_AsTEK";
            }
            else
            {                
                useDB = "POManager_AsTEKENG";
            }
            SendQuery("IF DB_ID (N'" + useDB + "') IS NULL BEGIN " +
                     "CREATE DATABASE " + useDB + " ON PRIMARY " +
                     "(NAME = " + useDB + ", " +
                     "FILENAME = '" + System.Environment.CurrentDirectory + "\\"+useDB+".mdf', " +
                     "SIZE = 3MB, FILEGROWTH = 10%) " +
                 "END ");

            SendQuery("USE " + useDB);
            
            /*
            SendQuery("IF DB_ID (N'POManager') IS NULL BEGIN " +
                    "CREATE DATABASE POManager ON PRIMARY " +
                    "(NAME = POManager, " +
                    "FILENAME = '" + System.Environment.CurrentDirectory + "\\POManager.mdf', " +
                    "SIZE = 3MB, FILEGROWTH = 10%) " +
                "END ");

            SendQuery("USE POManager ");*/
        }

        private void CheckVenderTable()
        {
            SendQuery("IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE Type = 'U' AND Name = N'Vendors') " +
                "CREATE TABLE Vendors ( " +
                    "VendorID int IDENTITY(1,1) PRIMARY KEY, " +
                    "VendorRecordDate datetime DEFAULT GETDATE(), " +
                    "VendorModifyDate datetime, " +
                    "[VendorCode] [varchar] (50) COLLATE Korean_Wansung_CI_AS NULL ,"+
                    "VendorName varchar(50), " +
                    "VendorAddr1 varchar(100), " +
                    "VendorAddr2 varchar(100), " +
                    "VendorAddr3 varchar(100), " +
                    "VendorCategory smallint, " +
                    "VendorHomepage varchar(100), " +
                    "VendorTel varchar(30), " +
                    "VendorPaymentTerms smallint, " +
                    "VendorDeliveryCondition smallint, " +
                    "VendorComment varchar(500), " +
                    "VendorIsUse bit DEFAULT 1 " +
                ") " +

                "IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE Type = 'U' AND Name = N'Contacts') " +
                    "CREATE TABLE Contacts ( " +
                    "ContactID int IDENTITY(1,1) PRIMARY KEY, " +
                    "ContactVendorID int NOT NULL, " +
                    "ContactRecordDate datetime DEFAULT GETDATE(), " +
                    "ContactModifyDate datetime, " +
                    "ContactName varchar(50), " +
                    "ContactTitle varchar(10), " +
                    "ContactTel varchar(30), " +
                    "ContactCell varchar(30), " +
                    "ContactFax varchar(30), " +
                    "ContactMail varchar(30), " +
                    "ContactIsUse bit DEFAULT 1 " +
                ") ");
        }

        private void CheckPartsTable()
        {
            SendQuery("IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE Type = 'U' AND Name = N'Parts') " +
                "CREATE TABLE Parts ( " +
                    "PartID int IDENTITY(1,1) PRIMARY KEY, " +
                    "PartVendorID int NOT NULL, " +
                    "PartRecordDate datetime DEFAULT GETDATE(), " +
                    "PartModifyDate datetime, " +
                    "PartCategory1 tinyint, " +
                    "PartCategory2 tinyint, " +
                    "PartsCode varchar(50), " +
                    "PartNumber varchar(100), " +
                    "PartName varchar(100), " +
                    "PartManufacture varchar(100), " +
                    "PartDrawingNumber varchar(100), " +                   
                    "PartMakerPN varchar(100), " +
                    "[PartMakerPNRV] char (10) DEFAULT 'A' ," +
                    "PartUnit varchar(30), " +
                    "PartUnitPrice float, " +
                    "PartUnitPriceType tinyint DEFAULT 0, " +
                    "PartDeliveryPeriod smallint, " +
                    "PartCurrentQuantity int DEFAULT 0, " +
                    "PartNeedParts tinyint, " +
                    "PartIsUse bit DEFAULT 1 " +
                ") ");
        }

        private void CheckPOTable()
        {
#if true
            SendQuery("IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE Type = 'U' AND Name = N'POs') " +
                "CREATE TABLE POs ( " +
                    "POID int IDENTITY(1,1) PRIMARY KEY, " +
                    "POVendorID int NOT NULL, " +
                    "PORecordDate datetime DEFAULT GETDATE(), " +
                    "POModifyDate datetime, " +
                    "POCategory tinyint, " +
                    "POConsultNumber varchar(100), " +
                    "PONumber varchar(100), " +
                    "PONumRevion tinyint, " +
                    "POTotalAmount float, " +
                    "POTotalAmountType tinyint DEFAULT 0, " +
                    "POEstimatedDeliveryDate datetime, " +
                    "PORequestDeliveryDate varchar(100), " +
                    "POPaymentTerms smallint, " +
                    "PODeliveryCondition smallint, " +
                    "POIsComplete bit DEFAULT 0, " +
                    "POIsUse bit DEFAULT 1 " +
                ") ");

            SendQuery("IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE Type = 'U' AND Name = N'POParts') " +
                "CREATE TABLE POParts ( " +
                    "POPartsID int IDENTITY(1,1) PRIMARY KEY, " +
                    "POPartsPOID int NOT NULL, " +
                    "POPartsPartID int NOT NULL, " +
                    "POPartRecordDate datetime DEFAULT GETDATE(), " +
                    "POPartModifyDate datetime, " +
                    "POPartQuantity int, " +
                    "POPartTotalAmount float, " +
                    "POPartInputQuantity int, " +
                    "POPartInputTotalAmount float, " +
                    "POPartInputMinusQuantity int, " +
                    "POPartMechineQuantity int, " +
                    "POPartRequirementsPartsQuantity int, " +
                    "POPartInputMinusTotalAmount float, " +
                    "POPartInputComment varchar(500), " +
                    "POPartInputResolver varchar(50), " +
                    "POPartInputDate datetime, " +
                    "POPartIsComplete bit DEFAULT 0, " +
                    "POPartIsUse bit DEFAULT 1 " +
                ") ");
#else
            SendQuery("IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE Type = 'U' AND Name = N'PurchaseOrders') " +
                "CREATE TABLE PurchaseOrders ( " +
                    "POID int IDENTITY(1,1) PRIMARY KEY, " +
                    "POPartID int NOT NULL, " +
                    "PORecordDate datetime DEFAULT GETDATE(), " +
                    "POModifyDate datetime, " +
                    "POCategory tinyint, " +
                    "POConsultNumber varchar(100), " +
                    "PONumber varchar(100), " +
                    "PONumRevion tinyint, " +
                    "POQuantity int, " +
                    "POTotalAmount bigint, " +
                    "POInputQuantity int, " +
                    "POInputTotalAmount bigint, " +
                    "POInputMinusQuantity int, " +
                    "POInputMinusTotalAmount bigint, " +
                    "POInputComment varchar(500), " +
                    "POInputResolver varchar(50), " +
                    "POInputDate datetime, " +
                    "POEstimatedDeliveryDate datetime, " +
                    "PORequestDeliveryDate datetime, " +
                    "POPaymentTerms smallint, " +
                    "PODeliveryCondition smallint, " +
                    "POIsComplete bit DEFAULT 0, " +
                    "POIsUse bit DEFAULT 1 " +
                ") ");
#endif
        }

        private void CheckInputTable()
        {
            SendQuery("IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE Type = 'U' AND Name = N'Inputs') " +
                "CREATE TABLE Inputs ( " +
                    "InputID int IDENTITY(1,1) PRIMARY KEY, " +
                    "InputPOID int NOT NULL, " +
                    "InputPartID int NOT NULL, " +
                    "InputRecordDate datetime DEFAULT GETDATE(), " +
                    "InputModifyDate datetime, " +
                    "InputRevion tinyint, " +
                    "InputQuantity int, " +
                    "InputTotalAmount float, " +
                    "InputMinusQuantity int, " +
                    "InputMinusTotalAmount float, " +
                    "InputComment varchar(500), " +
                    "InputResolver varchar(50), " +
                    "InputDate datetime, " +
                    "InputIsUse bit DEFAULT 1 " +
                ") ");
        }

        private void CheckOutputTable()
        {
            SendQuery("IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE Type = 'U' AND Name = N'Outputs') " +
                    "CREATE TABLE Outputs ( " +
                    "OutputID int IDENTITY(1,1) PRIMARY KEY, " +
                    "OutputPartID int NOT NULL, " +
                    "OutputRecordDate datetime DEFAULT GETDATE(), " +
                    "OutputModifyDate datetime, " +
                    "OutputCurrQuantity int, " +
                    "OutputCurrTotalAmount float, " +
                    "OutputQuantity int, " +
                    "OutputTotalAmount float, " +
                    "OutputRestQuantity int, " +
                    "OutputRestTotalAmount float, " +
                    "OutputComment varchar(500), " +
                    "OutputRequestDept tinyint, " +
                    "OutputRequestor varchar(50) NOT NULL, " +
                    "OutputDate datetime, " +
                    "OutputIsUse bit DEFAULT 1 " +
                ") ");
        }

        public void UpdateTable(string query, DataGridView dbg, int inVisbleCnt)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dbg.DataSource = table;

            for (int i = 0; i < inVisbleCnt; i++) 
            {
                dbg.Columns[i].Visible = false;
            }
        }

        public void SendQuery(string query)
        {
            if ((sqlConn != null) && (!sqlConn.State.Equals(ConnectionState.Open)))
            {
                sqlConn.Open();                          
            }

            using (SqlCommand myCommand = new SqlCommand(query, sqlConn))
            {
                myCommand.ExecuteNonQuery();
            }
        }

        public void CloseConnect()
        {
            if ((sqlConn != null) && (sqlConn.State.Equals(ConnectionState.Open)))
            {
                sqlConn.Close();
            }
        }

        public string AmountSum(String query)
        {
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlDataReader read = cmd.ExecuteReader();
            string sum;
            if (read.Read())
            {
                sum = read["Sum"].ToString();
            }
            else
            {
                sum = "0";
            }
            read.Close();
            
            return sum;
        }

        public string ConditionQuery;
        public void MakeConditionQuery(string str, bool isOrder)
        {
            if (isOrder)
            {
                ConditionQuery += " ORDER BY ";
            }
            else
            {
                if (ConditionQuery.Length == 0)
                {
                    ConditionQuery = " WHERE ";
                }
                else
                {
                    ConditionQuery += " AND ";
                }
            }
            ConditionQuery += str + " ";
        }
        public ArrayList GetData(string sql)
        {
            
            entity = new ArrayList();
            PartsDTO partDto;

            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read()){        
               
                partDto = new PartsDTO(Convert.ToInt16(read[0]), Convert.ToInt16(read[1]), Convert.ToInt16(read[2]),
                                       read[3].ToString(), read[4].ToString(), read[5].ToString(), read[6].ToString(),
                                       read[7].ToString(), read[8].ToString(), read[9].ToString(),
                                       Convert.ToDouble(read[10]), Convert.ToInt32(read[11]), Convert.ToDouble(read[12]),
                                       read[13].ToString());
                entity.Add(partDto);
            }
            read.Close();
            return entity;
        }
        public int GetPOid(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader read = cmd.ExecuteReader();
            int opNum=0;
            if (read.Read())
            {
                opNum = Convert.ToInt16(read[0]);
            }
            read.Close();
            return opNum;
        }
        public int GetVendorID(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader read = cmd.ExecuteReader();
            int vendorID = 0;
            if(read.Read())
            {
                vendorID = Convert.ToInt16(read[0]);
            }
            read.Close();
            return vendorID;
        }
        public int GetNeedParts(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader read = cmd.ExecuteReader();
            int NeedPart = 0;
            if (read.Read())
            {
                NeedPart = Convert.ToInt16(read[0]);
            }
            read.Close();
            return NeedPart;
        }

        public ArrayList GetPoPartsID(int id)
        {
            ArrayList PoPartsid = new ArrayList();            
            string query = "SELECT " +              
               "[POPartsPartID] " +              
           "FROM ([POParts] LEFT JOIN [Parts] ON [POPartsPartID] = [PartID]) LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID] " +
           "WHERE [POPartsPOID] = " + id;                       
            query = query + " ORDER BY [POPartsID] ";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                PoPartsid.Add(Convert.ToInt32(read[0]));
            }
            read.Close();
            return PoPartsid;
        }

        public String GetMaxPOid(string query)
        {
            String max="1";
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {              
                max=(read[0]).ToString();               
            }
            read.Close();
            return max;
        }

        public bool CheckUse(string query)
        {
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlDataReader read = cmd.ExecuteReader();
            bool flag = read.Read();
            read.Close();
            return flag;
        }

        public ArrayList GetPOIDs(int POVendorID)
        {
            ArrayList POIDs = new ArrayList();
            string query = "select POID from POs where POVendorID =" + POVendorID + "AND POIsUse = 1";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlDataReader read = cmd.ExecuteReader();
            
            while (read.Read())
            {               
                POIDs.Add(Convert.ToInt32(read[0]));
               
            }
            read.Close();
            return POIDs;
        }
    }
}