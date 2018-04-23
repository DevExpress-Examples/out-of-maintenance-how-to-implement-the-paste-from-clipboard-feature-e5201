using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E5201_CS {
    public class Record {
        private string id;
        private string name;

        public string ID {
            get { return id; }
            set { id = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }
    }
}
