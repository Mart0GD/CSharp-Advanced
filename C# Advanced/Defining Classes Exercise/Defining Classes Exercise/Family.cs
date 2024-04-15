using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
		public Family()
		{
			Members = new();
		}

		private List<Person> members;

		public void AddMember(Person member)
		{
			Members.Add(member);
		}

		public Person GetOldestMember()
		{
			return members.MaxBy(x => x.Age);
		}


		public List<Person> Members
		{
			get { return members; }
			set { members = value; }
		}

	}
}
