using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Passport.DataClasses;

namespace Passport
{
   public class conOpen
    {
       private static string _databaseName;
       private static string _serverName;
       private static string _conStr;


       public static string DatabaseName
       {
           get { return _databaseName; }
           set 
           {
               if (_databaseName != value)
               {
                   _databaseName = value;
               }
           }
       }
       public static string ServerName
       {
           get { return _serverName; }
           set
           {
               if (_serverName != value)
               {
                   _serverName = value;
               }
           }
       }
       public static string ConnectionString
       {
           get { return _conStr; }
           set { _conStr = value; }
       }

       
       public static bool getConnected()
       {
           bool conOpened = false;
           string conStrTest;
           try 
            {
                //conStrTest = @"Server='" + ServerName + "';Database='" + DatabaseName + "';Integrated Security=True;User Instance=True";
                conStrTest = @"Data Source=.\sqlexpress;AttachDbFilename=C:\PassportData\PassportDB.mdf;Integrated Security=True;User Instance=True"; 
                var embassyData = new EmbassyDataDataContext(conStrTest);

                conOpened = isConnected(embassyData);
              if (conOpened)
               {
                   ConnectionString = conStrTest;                  
               }
                return conOpened;
           }
           catch(Exception ex)
           {
               throw new Exception(ex.Message);
           }
        
       }
       public static bool isConnected(EmbassyDataDataContext d)
       {          
           try
           {               
               d.Connection.Open();
               return true;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           finally
           {
               if (d.Connection.State == System.Data.ConnectionState.Open)
                   d.Connection.Close();
           }
       }
    }
}
