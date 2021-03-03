using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repository_Domain;
using Repository_Source;

namespace RepositoryPattern
{
    public class TraineeXMLRepository : XMLRepositoryBase<XMLSet<Trainee>, Trainee, int>, ITraineeRepository
    {
        public TraineeXMLRepository() : base("TraineeInformation.xml")
        {

        }
    }
}