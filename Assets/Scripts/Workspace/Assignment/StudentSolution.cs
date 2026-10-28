using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        public class Action
        {
            public string Name;
            public int Value;
        }

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int count = stack.Count;
            int popped = stack.Pop();
            int peek = stack.Peek();
            int countAfterPeek = stack.Count;
            return (count, popped, peek, countAfterPeek);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            int count = queue.Count;
            int dequeued = queue.Dequeue();
            int peek = queue.Peek();
            int countAfterPeek = queue.Count;
            return (count, dequeued, peek, countAfterPeek);
        }

        public string[] LCT03_ActionStack()
        {
            Stack<Action> stack = new Stack<Action>();
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);

            List<string> list = new List<string>();
            while (stack.Count > 0)
            {
                Action act = stack.Pop();
                list.Add(act.Name);
            }
            return list.ToArray();
        }

        public string[] LCT04_ActionQueue()
        {
            Queue<Action> queue = new Queue<Action>();
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);

            List<string> list = new List<string>();
            while (queue.Count > 0)
            {
                Action act = queue.Dequeue();
                list.Add(act.Name);
            }
            return list.ToArray();
        }

        public string ASN01_ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                stack.Push(c);
            }
            string result = "";
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }
            return result;
        }

        public bool ASN02_StackPalindrome(string str)
        {
            string cleaned = "";
            foreach (char c in str)
            {
                if (!char.IsWhiteSpace(c))
                {
                    cleaned += char.ToLower(c);
                }
            }

            Stack<char> stack = new Stack<char>();
            foreach (char c in cleaned)
            {
                stack.Push(c);
            }

            string reversed = "";
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            return cleaned == reversed;
        }

        public bool EX01_ParenthesesChecker(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char open = stack.Pop();
                    if ((c == ')' && open != '(') ||
                        (c == ']' && open != '[') ||
                        (c == '}' && open != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}

