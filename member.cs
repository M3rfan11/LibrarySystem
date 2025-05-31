using System.Reflection.Metadata;

namespace library
{
    class Member : Person
    {

        public int memberID{ get; set; }
        public Member(int ID, string name, string email) : base(name, email)
        {
            this.memberID = ID;
        }

        public override void PersonInformation()
        {
            System.Console.WriteLine($"ID => {memberID}, Name => {name} - Email => {email}");
        }
    }
}