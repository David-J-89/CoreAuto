using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace coreauto.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }

        //iniatlize the collection with a constructor
        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}
