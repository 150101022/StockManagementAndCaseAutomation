using Stok_Takibi.Models;
using Stok_Takibi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Stok_Takibi
{
    public class Variables
    {
        public static XmlDocument xmlDoc = new XmlDocument();

        public static string XmlDocument
        {
            set { xmlDoc.LoadXml(value); }
        }

        public static DatabaseService _databaseService = new DatabaseService(new DatabaseSettings());

        public static string userID {get; set;}
    }
}
