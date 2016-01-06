using MvcInAction.Interfaces;
using MvcInAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcInAction.Repositories
{
    public class MembersRepository : IMembersRepository
    {
        public void AddMember(Member member)
        {
            throw new NotImplementedException();
        }

        public Member FetchByLoginName(string loginName)
        {
            throw new NotImplementedException();
        }

        public void SubmitChanges()
        {
            throw new NotImplementedException();
        }

        //some comment
    }
}