using System;
using System.IO;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;

namespace Cafe
{
    public static class DBConnection
    {
        public static string connectionString;

        static DBConnection()
        {
            LoadDBConfig();
        }

        private static void LoadDBConfig()
        {
            try
            {
                string xmlFilePath = "ExternalConfig.xml";

                if (File.Exists(xmlFilePath))
                {
                    XDocument xmlDoc = XDocument.Load(xmlFilePath);

                    string user = xmlDoc.Root.Element("database").Element("user")?.Value;
                    string password = xmlDoc.Root.Element("database").Element("password")?.Value;
                    string host = xmlDoc.Root.Element("database").Element("host")?.Value;
                    string port = xmlDoc.Root.Element("database").Element("port")?.Value;
                    string service = xmlDoc.Root.Element("database").Element("service")?.Value;

                    if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(host) || string.IsNullOrEmpty(port) || string.IsNullOrEmpty(service))
                    {
                        throw new Exception("XML에서 DB 정보가 제대로 설정되지 않았습니다.");
                    }

                    connectionString = $"User Id={user};Password={password};Data Source={host}:{port}/{service}";
                }
                else
                {
                    Console.WriteLine("⚠️ XML 설정 파일을 찾을 수 없습니다. 기본 DB 정보를 사용합니다.");

                    // XML이 없을 경우 기본 연결 정보 사용
                    string defaultUser = "CAFE_DEV";
                    string defaultPassword = "CAFE";
                    string defaultHost = "127.0.0.1";
                    string defaultPort = "1521";
                    string defaultService = "orcl";

                    //connectionString = $"User Id={defaultUser};Password={defaultPassword};Data Source={defaultHost}:{defaultPort}/{defaultService}";
                    connectionString = "User Id=cafe_dev;Password=CAFE;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl)))";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ DB 설정 로드 실패: " + ex.Message);
            }
        }

        public static OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }
    }
}
