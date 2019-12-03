using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreDbAzure.Logic
{
    public class TaskManager
    {
        private readonly AzureDb _db;

        public TaskManager(AzureDb db)
        {
            _db = db;
        }

        public List<Task> GetAll()
        {
            return _db.Tasks.OrderBy(t => t.Id).ToList();
        }

        public void Delete(int id)
        {
            var task = _db.Tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _db.Tasks.Remove(task);
                _db.SaveChanges();
            }
        }

        public void Create(string description)
        {
            var task = new Task()
            {
                Description = description,
            };

            _db.Tasks.Add(task);
            _db.SaveChanges();
        }
    }
}
