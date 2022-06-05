using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace WindowsFormsApp2{
class Node
{
    public String data;
    public Node left, right;
    public Node(String data)
    {
        this.data = data;
        left = right = null;
    }
}

public class Conversion{
    static String[] mathTokenization(string unTokenize)
    {
        string[] Tokenize = Regex.Split(unTokenize, @"([*()\^\/]|(?<!E)[\+\-])");
        return Tokenize;
    }

    public static bool isNumber(string substring)
    {
        int temp;
        return (int.TryParse(substring, out temp));
    }

    static string[] InfixToPrefix(string[] infixArray)
    {
        Stack<String> result = new Stack<string>();
        Stack<String> stack = new Stack<string>();

        for (int i = 0; i < infixArray.Length; ++i)
        {
            string c = infixArray[i];

            if (isNumber(infixArray[i]))
            {
                result.Push(c);
            }
            else if (c == "(")
            {
                stack.Push(c);
            }
            else if (c == ")")
            {
                while (stack.Count() > 0 && stack.Peek() != "(")
                {
                    result.Push(stack.Pop());
                }
                stack.Pop();
            }
            else
            {
                while (stack.Count() > 0 && getPriority(c) <= getPriority(stack.Peek()))
                {
                    result.Push(stack.Pop());
                }
                stack.Push(c);
            }
        }
        while (stack.Count() > 0)
        {
            result.Push(stack.Pop());
        }
        return result.ToArray();

    }

    static String[] emptyValueDeletor(String[] Bad)
    {
        return Bad.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    }

    static int getPriority(string C)
    {
        if (C == "-" || C == "+")
            return 1;
        else if (C == "*" || C == "/")
            return 2;
        else if (C == "^")
            return 3;
        return 0;
    }

    public static String[] intoTreeUtility(String s)
    {
        s = Minushandiling(s);
        String[] temp = emptyValueDeletor(InfixToPrefix(mathTokenization(s)));
        Array.Reverse(temp, 0, temp.Length);
        return temp;
    }

    static String Minushandiling(string s)
    {
        if (s[0] == '-')
        {
            s = s.Insert(0, "0");
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' && s[i + 1] == '-')
            {
                s = s.Insert(i + 1, "0");
            }
        }
        return s;
    }
}

public class calculator
{
    static double evalTree(Node root)
    {

        // Empty tree
        if (root == null)
            return 0;

        // Leaf node i.e, an integer
        if (root.left == null && root.right == null)
            return double.Parse(root.data);

        // Evaluate left subtree
        double leftEval = evalTree(root.left);

        // Evaluate right subtree
        double rightEval = evalTree(root.right);

        // Check which operator to apply
        if (root.data.Equals("+"))
            return leftEval + rightEval;

        if (root.data.Equals("-"))
            return leftEval - rightEval;

        if (root.data.Equals("*"))
            return leftEval * rightEval;

        if (root.data.Equals("^"))
            return Math.Pow(leftEval, rightEval);

        return leftEval / rightEval;
    }

    static Node expressiontree(String[] postfix)
    {
        Stack<Node> st = new Stack<Node>();
        Node t1, t2, temp;

        for (int i = 0; i < postfix.Length; i++)
        {
            if (Conversion.isNumber(postfix[i]))
            {
                temp = new Node(postfix[i]);
                st.Push(temp);
            }
            else
            {
                temp = new Node(postfix[i]);

                t1 = st.Pop();
                t2 = st.Pop();

                temp.left = t2;
                temp.right = t1;

                st.Push(temp);
            }

        }
        temp = st.Pop();
        return temp;
    }

    public static string final(string s)
    {
        var try1 = Conversion.intoTreeUtility(s);
        Node tree = expressiontree(try1);
        return evalTree(tree).ToString();
    }
    public static void Main(string[] args)
    {
        String s = ("1+34*53/21^5");
        Console.WriteLine(final(s));
    }
}
}