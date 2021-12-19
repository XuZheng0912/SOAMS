using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateOwnedAssetsManagementSystem;
using StateOwnedAssetsManagementSystem.Class;
using StateOwnedAssetsManagementSystem.Class.document;
using StateOwnedAssetsManagementSystem.Class.Entity;
using StateOwnedAssetsManagementSystem.Class.SystemRole;
using StateOwnedAssetsManagementSystem.Interface;
using System.Data;
using System.Data.SqlClient;

namespace StateOwnedAssetsManagementSystem.Class.document
{
    public class Asset
    {
        public Asset(string number, string type, string name, double value, string keeper, string date)
        {
            Number = number;
            Type = type;
            Name = name;
            Value = value;
            Keeper = keeper;
            Date = date;
        }

        public string Number { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Keeper { get; set; }
        public string Date { get; set; }

        /// <summary>
        /// 资产统计
        /// </summary>
        /// <returns>Asset对象List集合</returns>
        public static List<Asset> AssetsStatistics()
        {
            List<Asset> assets = new List<Asset>();
            string statement = "select Number,Type,Name,Value,Keeper,Date from Assets";
            SqlDataReader sqlDataReader = DataBase.QueryExecute(statement);
            while (sqlDataReader.Read())
            {
                Asset asset = new Asset(sqlDataReader.GetString(0),
                                        sqlDataReader.GetString(1), 
                                        sqlDataReader.GetString(2),
                                        sqlDataReader.GetFloat(3),
                                        sqlDataReader.GetString(4),
                                        sqlDataReader.GetString(5));
                assets.Add(asset);
            }
            return assets;
        }
        /// <summary>
        /// 依据资产单号资产查询
        /// </summary>
        /// <returns>Asset对象</returns>
        public static Asset AssetsInquiry(string number)
        {
            string statement = $"select Number,Type,Name,Value,Keeper,Date from Assets where Number={number}";
            SqlDataReader sqlDataReader = DataBase.QueryExecute(statement);
            while (sqlDataReader.Read())
            {
                return  new Asset(sqlDataReader.GetString(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetFloat(3),
                        sqlDataReader.GetString(4),
                        sqlDataReader.GetString(5));
            }
            return null;
        }
        /// <summary>
        /// 资产查询
        /// </summary>
        /// <param name="column"></param>
        /// <param name="number"></param>
        /// <returns>Asset对象List集合</returns>
        public static List<Asset> AssetsInquiry(string column, string number)
        {
            List<Asset> assets = new List<Asset>();
            string statement = $"select Number,Type,Name,Value,Keeper,Date from Assets where {column}={number}";
            SqlDataReader sqlDataReader = DataBase.QueryExecute(statement);
            while (sqlDataReader.Read())
            {
                Asset asset =  new Asset(sqlDataReader.GetString(0),
                                         sqlDataReader.GetString(1),
                                         sqlDataReader.GetString(2),
                                         sqlDataReader.GetFloat(3),
                                         sqlDataReader.GetString(4),
                                         sqlDataReader.GetString(5));
                assets.Add(asset);
            }
            if (assets.Count == 0)
            {
                return null;
            }
            else
            {
                return assets;
            }
        }
    }
}
