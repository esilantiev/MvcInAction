using MvcInAction.Interfaces;
using MvcInAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class FakeMembersRepository : IMembersRepository
    {
        public List<Member> Members = new List<Member>();
        public bool DidSubmitChanges = false;

        public void AddMember(Member member)
        {
            throw new NotImplementedException();
        }

        public Member FetchByLoginName(string loginName)
        {
            return Members.First(f => f.LoginName == loginName);
        }

        public void SubmitChanges()
        {
            DidSubmitChanges = true;
        }

    }
}
