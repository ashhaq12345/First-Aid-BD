using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GART.Data;

namespace MosqueFinder
{
    internal class Destination : ARItem
    {
        private string description;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description != value)
                {
                    description = value;
                    NotifyPropertyChanged(() => Description);
                }
            }

        }
    }
}
