using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WCF_BD
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    [ServiceBehavior(MaxItemsInObjectGraph = 2147483646)]  
    public class Service1 : IService1
    {


        const int qtsucre = 1;
        SqlConnection connection;
        SqlCommand command;
        SqlConnectionStringBuilder connectionStringBuilder;

        public Service1()
        {
            connectToDB();
        }
        public void connectToDB()
        {
            string connect="Data Source=PC-HIND-PC\\SQLEXPRESS;Initial Catalog=coffeemachine;User ID=dbcoffeemachine;Password=123456";
            connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource ="PC-HIND-PC\\SQLEXPRESS";
            connectionStringBuilder.InitialCatalog ="coffeemachine";
            connectionStringBuilder.Encrypt =true;
            connectionStringBuilder.TrustServerCertificate =true;
            connectionStringBuilder.ConnectTimeout =30;
            connectionStringBuilder.AsynchronousProcessing =true;
            connectionStringBuilder.MultipleActiveResultSets =true;
            connectionStringBuilder.IntegratedSecurity =true;
            connection = new SqlConnection(connect);
            command=connection.CreateCommand();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Customer  searchCustomer(int id_customer)
        {
            try
            {
                Customer _customer = new Customer();
                _customer.qtSucre = qtsucre;
                command.CommandText = "SELECT * FROM drink Where id_customer="+id_customer;
                //command.Parameters.Add("@id_customer", id_customer);
                command.CommandType = CommandType.Text;
                connection.Open();
              
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        _customer.id_customer = Convert.ToInt32(reader.GetValue(0));
                        _customer.type_drink = Convert.ToString(reader.GetValue(1));
                        _customer.qtSucre = Convert.ToInt32(reader.GetValue(2));
                        _customer.mug = Convert.ToByte(reader.GetValue(3));
                    }
                    else
                        return _customer;
                }
                return _customer;
            }
            catch (Exception  ex)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
           
        }


        public int updateCustomer(Customer cst)
        {
            try
            {
                command.CommandText = "UPDATE drink SET id_customer=@id_customer , type_drink = @type_drink , qtSucre= @qtSucre , mug= @mug  WHERE id_customer= @id_customer";
              
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id_customer", cst.id_customer);
                command.Parameters.AddWithValue("@type_drink", cst.type_drink);
                command.Parameters.AddWithValue("@qtSucre", cst.qtSucre);
                command.Parameters.AddWithValue("@mug", cst.mug);
                command.CommandType = CommandType.Text;
                
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }

        public int insertCustomer(Customer cst)
        {
            try
            {
                command.CommandText ="INSERT INTO drink VALUES(@id_customer, @type_drink, @qtSucre, @mug)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id_customer", cst.id_customer);
                command.Parameters.AddWithValue("type_drink", cst.type_drink );
                command.Parameters.AddWithValue("qtSucre", cst.qtSucre);
                command.Parameters.AddWithValue("mug", cst.mug);
                command.CommandType = CommandType.Text;
                connection.Open();
                string val = connection.State.ToString();
                return command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
               return updateCustomer(cst);
               // throw;
            }
           
        }
    }
}
