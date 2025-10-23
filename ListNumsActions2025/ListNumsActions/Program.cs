namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "contains":
                        num = int.Parse(cmd[1]);
                        if(nums.Contains(num))
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No");
                        break;
                        //TODO
                        break;
                    case "del":
                        int toDelete = int.Parse(cmd[1]);
                        nums.Remove(toDelete);
                        break;
                    case "add":
                        int numOne = int.Parse(cmd[1]);
                        int numSecond = int.Parse(cmd[2]);
                        nums.Add(numOne+numSecond);
                        break;
                    case "remove":
                        int removeIndex = int.Parse(cmd[1]);
                        if (removeIndex >= 0 && removeIndex < nums.Count)
                        {
                            nums.RemoveAt(removeIndex);
                        }
                        break;
                    

<<<<<<< HEAD

                    //opraih go
                    //gotovo
=======
                    //TO DOdfghjkl
                    //xcvbjkl
>>>>>>> ea2c16ebccd4ae6f3635c167dc94ef4393a1d8d8
                    default:
                        break;
                }
            }
        }
    }
}
