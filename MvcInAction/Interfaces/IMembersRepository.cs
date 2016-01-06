using MvcInAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcInAction.Interfaces
{
    public interface IMembersRepository
    {
        void AddMember(Member member);
        Member FetchByLoginName(string loginName);
        void SubmitChanges();
       
    }
}
