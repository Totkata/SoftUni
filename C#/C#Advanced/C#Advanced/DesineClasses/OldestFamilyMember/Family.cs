using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            familyMembers = new List<Person>();
        }
        public void AddFamilyMember(Person member)
        {
            familyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldest = familyMembers.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldest;
        }

    }
}
