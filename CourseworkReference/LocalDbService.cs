using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkReference
{
    public class LocalDbService
    {
        private const string DB_NAME = "demo_local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Transaction>();
        }

        public async Task<List<Transaction>> GetAllTransactions()
        {
            return await _connection.Table<Transaction>().ToListAsync();
        }

        public async Task CreateTransaction(Transaction transaction)
        {
            await _connection.InsertAsync(transaction);
        }
    }
}
