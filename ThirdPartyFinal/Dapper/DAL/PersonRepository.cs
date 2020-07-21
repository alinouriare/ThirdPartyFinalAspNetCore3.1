using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class PersonRepository
    {
        private readonly IDbConnection _cnn;
        public PersonRepository(IDbConnection cnn)
        {
            _cnn = cnn;
        }



        public List<Person> GetPeople()
        {
            List<Person> people = _cnn.Query<Person>("select * from Person").ToList();
            return people;
        }

        public int Update(int personId, string firstName, string lastName)
        {
            int result = _cnn.Execute("Person_Upadte", commandType: CommandType.StoredProcedure, param: new
            {
                personId = personId,
                firstName = firstName,
                lastName = lastName
            });
            return result;
        }
        public int Insert(string firstName, string lastName)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("FirstName", firstName, DbType.String, ParameterDirection.Input, null);
            dynamic.Add("LastName", lastName, DbType.String, ParameterDirection.Input, null);
            int result = _cnn.Execute("Person_Insert", param: dynamic, commandType: CommandType.StoredProcedure);

            return result;
        }

        public int Insert_All(List<Person> people)
        {
            List<DynamicParameters> parameters = new List<DynamicParameters>();
            foreach (var item in people)
            {
                DynamicParameters dynamic = new DynamicParameters();
                dynamic.Add("FirstName", item.FirstName, DbType.String, ParameterDirection.Input, null);
                dynamic.Add("LastName", item.LastName, DbType.String, ParameterDirection.Input, null);
                parameters.Add(dynamic);
            }
            int result = _cnn.Execute("Person_Insert", param: parameters, commandType: CommandType.StoredProcedure);

            return result;
        }

        public List<Person> ShowPersonandAddress()
        {
            string query = "select p.PersonId,p.FirstName,p.LastName,a.AddressId,a.PersonId,a.AddressLine from Person p inner join [dbo].[Address] a on p.PersonId=a.PersonId";



            var result = _cnn.Query<Person, Address, Person>(query, (person, address) =>
            {

                person.Address=address;
                return person;

            }, splitOn: "AddressId").Distinct().ToList();



            return result;
       
        }
        public void GetAllOrders()
        {
            string sql = "SELECT TOP 10 * FROM Orders AS A INNER JOIN OrderDetails AS B ON A.OrderID = B.OrderID;";


            var orderDictionary = new Dictionary<int, Order>();


            var list = _cnn.Query<Order, OrderDetail, Order>(
            sql,
            (order, orderDetail) =>
            {
                Order orderEntry;

                if (!orderDictionary.TryGetValue(order.OrderId, out orderEntry))
                {
                    orderEntry = order;
                    orderEntry.OrderDetails = new List<OrderDetail>();
                    orderDictionary.Add(orderEntry.OrderId, orderEntry);
                }

                orderEntry.OrderDetails.Add(orderDetail);
                return orderEntry;
            },
            splitOn: "OrderDetailId")
            .Distinct()
            .ToList();

            Console.WriteLine(list.Count);

        }

        public void GetAllPersonAndGetAllAddress()
        {
            string query = "Select * from Person; select * from Address";
            var multipleResult = _cnn.QueryMultiple(query);

            var listPerson = multipleResult.Read<Person>();
            var listAddress = multipleResult.Read<Address>();

        }
        public void GetAllPerson()
        {
            string query = "Select * from person where personId in @list";
            _cnn.Query(query, new int[] { 1, 2, 3, 4 });
        }

        public void GetTeachersAndStudents()
        {
            string query = "";
            using (var reader = _cnn.ExecuteReader(query))
            {
                var personParser = reader.GetRowParser<Person>();
                var addressParser = reader.GetRowParser<Address>();
                while (reader.Read())
                {
                    int persoType = (int)reader["personType"];
                    if (persoType == 1)
                    {
                        var person = personParser.Invoke(reader);
                    }
                    else if (persoType == 2)
                    {
                        var address = addressParser.Invoke(reader);
                    }
                }

            }
        }



        }
}
