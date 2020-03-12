using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemService.Models;
namespace ItemService.Repositories
{
    public interface IItemRepository
    {
        List<Items> GetAllItems();
        Items GetById(string id);
        void AddItem(Items obj);
        void DeleteItem(string id);
        void UpdateItem(Items obj);

    }
}
