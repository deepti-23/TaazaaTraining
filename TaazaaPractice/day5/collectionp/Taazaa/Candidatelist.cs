using System.Collections;
using System.Collections.Generic;
using collectionp.models;
//Providing a new approach using Generics
namespace collectionp.Taazaa
{
    public class Candidatelist
    {
        public ArrayList Candidatedetails()
        {
            ArrayList arrayList=new ArrayList();
            arrayList.Add("bansal");
            arrayList.Add("Deepti");
            return arrayList;
            //return ("deepti");
        }
        public List<candidate> Candidatedetail()
        {
            List<candidate> obj =new List<candidate>();
            obj.Add(new candidate{
                cid=102,
                cname="Deepti"
            });
            obj.Add(new candidate{
                cid=108,
                cname="Geetika"
            });
            obj.Add(new candidate{
                cid=100,
                cname="Nikhil"
            });
            return obj;
        }
    }
}