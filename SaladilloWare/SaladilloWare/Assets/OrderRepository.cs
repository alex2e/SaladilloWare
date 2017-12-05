using SaladilloWare.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladilloWare.Assets
{
    public class OrderRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteAsyncConnection conn;
        private String rutaDB;

        public OrderRepository(String dbPath)
        {
            //Initialize a new SQLiteConnection, le pasamos el dbPath que es el nombre donde esta el fichero de la base de datos...
            conn = new SQLiteAsyncConnection(dbPath);

            //Create the Person table
            conn.CreateTableAsync<Order>().Wait(); //El Wait se pone por precaución para que se pare hasta que tenga la tabla 
            rutaDB = dbPath;
        }

        public async Task AddNewOrderAsync(String codUser, int codPlaca, int codProcesador, int codTorre, int codMemoria, int codGrafica)
        {
            int result = 0;
            try
            {

                // Insert a new Order into the Order table
                result = await conn.InsertAsync(new Order {NameClient = codUser, CodPlaca = codPlaca, CodProcesador = codProcesador, CodTorre = codTorre, CodMemoria = codMemoria, CodGrafica = codGrafica});

                StatusMessage = string.Format("Order added successfully");
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add Order. Error: {1}", ex.Message);
            }

        }

        public async Task<List<Order>> GetAllOrderAsync()
        {
            //Variable de lista de pedidos
            List<Order> listResult = new List<Order>();

            try
            {
                //return a list of people saved to the Order table in the database
                listResult = await conn.Table<Order>().ToListAsync();
            }
            catch (Exception e)
            {
                StatusMessage = String.Format("Failed to retrieve date. {0}", e.Message);
            }

            //Se devuelve la lista de pedidos.
            return listResult;
        }
    }
}
