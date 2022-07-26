using SOLID.D.Enums;
using SOLID.D.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class RelationshipsBetter : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> _relations
            = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }

        //With this we have a low level module that is dependent on an abstraction

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            foreach (var r in _relations.Where(
                x => x.Item1.Name == name &&
                x.Item2 == Relationship.Parent))
            {
                yield return r.Item3;
            }
        }
    }
}
