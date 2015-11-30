using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace _6.PhonesTraversal
{
    public class PhoneBook
    {
        private Dictionary<string,HashSet<Entry>> entries;


        public PhoneBook()
        {
            this.entries = new Dictionary<string, HashSet<Entry>>();
        }

        public void Add(Entry entry)
        {
            if (!entries.ContainsKey(entry.Name))
            {
                entries.Add(entry.Name, new HashSet<Entry>());
            }

            entries[entry.Name].Add(entry);
        }

        public void Remove(Entry entry)
        {
            if (!this.entries.ContainsKey(entry.Name))
            {
                throw new KeyNotFoundException();
            }

            this.entries[entry.Name].Remove(entry);
        }
        
        public void Clear()
        {
            this.entries = new Dictionary<string, HashSet<Entry>>();
        }

        public ICollection<Entry> Find(string name)
        {
            var res = new List<Entry>();

            foreach (var pair in this.entries)
            {
                if (pair.Key.ToLower().Contains(name.ToLower()))
                {
                    res.AddRange(pair.Value);
                }
            }

            return res;
        }

        public ICollection<Entry> Find(string name, string town)
        {
            var res = this.Find(name);

            return res.Where(e => e.Town.ToLower().Contains(town.ToLower())).ToList();
        }  
    }
}