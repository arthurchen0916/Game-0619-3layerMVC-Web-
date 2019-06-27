using Game.Common.Entities;
using Game.Common.Interfaces;
using Game.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Game.Core
{
    public class MemberService
    {
        public readonly object Members;
        IRepository<Member> memberRepository;

        public MemberService()
        {
            memberRepository = new MemberRepository();
        }

        //Read
        public IEnumerable<Member> GetAll()
        {
            var result = memberRepository.FindAll();
            return result;
        }

        //Add 
        public bool Add(Member member)
        {
            bool result = false;
            var chk = memberRepository.GetById(member.Id);
            if (chk == null)
            {
                memberRepository.Add(member);
                result = true;
            }
            return result;
        }

        //Delete
        public bool Delete(int id)
        {
            bool result = false;
            var chk = memberRepository.GetById(id);

            if (chk == null)
            {
                //to do something
            }
            else
            {
                memberRepository.Remove(chk);
                result = true;
            }
            return result;
        }
        //Detail
        public Member Query(int id)
        {
            var member = memberRepository.Find(x => x.Id == id).SingleOrDefault();
            return member;
        }

        //Update
        public bool Update(Member member)
        {
            bool result = false;
            var chk = memberRepository.GetById(member.Id);
            if (chk == null)
            {
                //to do something
            }
            else
            {
                memberRepository.Update(member);
                result = true;
            }
            return result;
        }
    }
}