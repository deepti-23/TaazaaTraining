using advgenerics.Models;
using System.Collections.Generic;
namespace advgenerics.TrainingList
{
    public class TaazaaTrainingList
    {
        public List<Details> TrainingList()
        {
            List<Details> obj =new List<Details>();
            obj.Add(new Details{
                PhoneNumber=798,
                Email="ss.com"
            });
            obj.Add(new Details{
                PhoneNumber=502,
                Email="abc.com"
            });
            return obj;
        }
    }
}