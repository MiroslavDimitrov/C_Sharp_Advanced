namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        { 
            var friends = new List<string>()
            { 
                "Miro", "Tanya", "Teodora",
                "Iliyan", "Veronika", "Angel",
                "Joro", "Nadya", "Maria"
            };
            var partyFriends = GetPartyFriends(friends, 3);
            foreach (var name in friends)
            {
                Console.WriteLine(name);
            }
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
