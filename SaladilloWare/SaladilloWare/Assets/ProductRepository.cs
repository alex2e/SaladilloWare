using SaladilloWare.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladilloWare.Assets
{
    public class ProductRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteAsyncConnection conn;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dbPath"></param>
        public ProductRepository(string dbPath)
        {
            //Initialize a new SQLiteConnection, le pasamos el dbPath que es el nombre donde esta el fichero de la base de datos...
            conn = new SQLiteAsyncConnection(dbPath);

            //Create the Person table
            conn.CreateTableAsync<Product>().Wait(); //El Wait se pone por precaución para que se pare hasta que tenga la tabla 
        }

        /// <summary>
        /// Devulve una lista con todos los productos de nuestra BD.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> GetAllPeopleAsync()
        {
            //Variable de lista de Productos
            List<Product> listResult = new List<Product>();

            try
            {
                //return a list of products saved to the Person table in the database
                listResult = await conn.Table<Product>().ToListAsync();
            }
            catch (Exception e)
            {
                StatusMessage = String.Format("Failed to retrieve date. {0}", e.Message);
            }

            //Se devuelve la lista de productos.
            return listResult;
        }

    }


}
