using Contactos.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contactos.Data
{
    public class FriendDataBase
    {
        private readonly SQLiteAsyncConnection database;

        public FriendDataBase(String dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Friend>().Wait();
        }
        public async Task<List<Friend>> GetFriendsAsync()
        {
            return await database.Table<Friend>().ToListAsync();
        }

        public Task<Friend> GetFriendsAsync(int id)
        {
            return database.Table<Friend>().Where(f => f.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveFriendsAsync(Friend friend)
        {
            if ( friend.ID != 0)
            {
                return database.UpdateAsync(friend);
            } else
            {
                return database.InsertAsync(friend);
            }
        }

        public Task<int> DeleteFriendAsync (Friend friend)
        {
            return database.DeleteAsync(friend);
        }

    }
}
