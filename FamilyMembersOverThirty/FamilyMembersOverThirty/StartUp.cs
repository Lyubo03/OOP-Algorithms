using System;
using System.Collections.Generic;
using System.Linq;
namespace FamilyMembersOverThirty
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());
            List<Member> members = new List<Member>();
            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] input = Console.ReadLine().Split();
                int age = int.Parse(input[1]); string name = input[0];
                Member member = new Member(name, age);
                members.Add(member);
            }
            members = members.OrderBy(x => x.GetName()).ToList();
            foreach (var member in members)
            {
                if (member.GetAge()>=30)
                {
                    Console.WriteLine($"{member.GetName()} - {member.GetAge()}");
                }
            }
        }
    }
}
