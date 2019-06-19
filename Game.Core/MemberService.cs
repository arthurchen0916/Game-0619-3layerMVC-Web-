using Game.Common.Entities;
using Game.Common.Interfaces;
using Game.Dal;
using System.Collections.Generic;

namespace Game.Core
{
    public class MemberService
    {
        IRepository<Member> memberRepository;

        public MemberService()
        {
            memberRepository = new MemberRepository();
        }
        public IEnumerable<Member> GetAll()
        {
            var result = memberRepository.FindAll();
            return result;
        }
    }
}