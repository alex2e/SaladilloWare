using SaladilloWare.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladilloWare.Assets
{
    public class UserRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteAsyncConnection conn;

        public UserRepository(string dbPath)
        {
            //Initialize a new SQLiteConnection, le pasamos el dbPath que es el nombre donde esta el fichero de la base de datos...
            conn = new SQLiteAsyncConnection(dbPath);

            //Create the Person table
            conn.CreateTableAsync<User>().Wait(); //El Wait se pone por precaución para que se pare hasta que tenga la tabla 
        }

        /// <summary>
        /// Devuelve una lista con todos los usuarios de la BD.
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> GetAllPeopleAsync()
        {
            //Variable de lista de personas
            List<User> listResult = new List<User>();

            try
            {
                //return a list of people saved to the Person table in the database
                listResult = await conn.Table<User>().ToListAsync();
            }
            catch (Exception e)
            {
                StatusMessage = String.Format("Failed to retrieve date. {0}", e.Message);
            }

            //Se devuelve la lista de personas.
            return listResult;
        }


    }
}
