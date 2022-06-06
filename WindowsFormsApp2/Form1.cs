using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool firstClick = true;
        bool mouseDown;
        private Point mousePos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button4_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void mouseDownEvent(object sender, MouseEventArgs e)
        {
            mousePos.X = e.X;
            mousePos.Y = e.Y;
            mouseDown = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }catch (Exception)
            {
                MessageBox.Show("Input is empty");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (firstClick)
            {
                textBox1.Text = textBox1.Text.TrimStart('0'); ;
                firstClick = false;
            }
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean invalidinput = true;
            string s = textBox1.Text;
            s = s.Replace(",", string.Empty);
            s = Conversion.RootDefaultHandling(s);
            s = Conversion.Minushandiling(s);
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (calculator.isOperatorchar(textBox1.Text[i]) && calculator.isOperatorchar(textBox1.Text[i + 1]))
                {
                    invalidinput = false; break;
                }
            }

            if (calculator.isOperatorchar(s[s.Length-1]))
            {
                MessageBox.Show("input is invalid");
            }

            else if (calculator.isOperatorchar(s[0])) { 
                MessageBox.Show("input is invalid");
            }
            else if (!invalidinput)
            {
                MessageBox.Show("input is invalid");
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = calculator.final(s);
                History.Items.Add(s + "=" + calculator.final(s));
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstClick = true;
        }

        private void History_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void weightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3  form3 = new Form3();
            form3.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mouseMoveEvent(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - mousePos.X, currentScreenPos.Y - mousePos.Y);

            }
        }

        private void mouseUpEvent(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            History.Items.Clear();
            textBox1.Text = "0";
            firstClick = true;
        }

        private void lengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }
    }

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

    public class Conversion
    {
        static String[] mathTokenization(string unTokenize)
        {
            string[] Tokenize = Regex.Split(unTokenize, @"([*()%\√^\/]|(?<!E)[\+\-])");
            return Tokenize;
        }

        public static bool isNumber(string substring)
        {
            double temp;
            return (double.TryParse(substring, out temp));
        }

        static string[] RootHandling(string[] unreverse)
        {
            for(int i = 0; i < unreverse.Length; i++)
            {
                if(unreverse[i] == "√")
                {
                    string temp = unreverse[i+1];
                    unreverse[i+1] = unreverse[i-1];
                    unreverse[i-1] = temp;
                }
            }
            return unreverse;
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
            else if (C == "*" || C == "/" || C == "%")
                return 2;
            else if (C == "^" || C== "√")
                return 3;
            return 0;
        }

        public static String[] intoTreeUtility(String s)
        {
            String[] temp = InfixToPrefix(RootHandling(emptyValueDeletor(mathTokenization(s))));
            Array.Reverse(temp, 0, temp.Length);
            foreach(var match in temp)
            {
                Console.WriteLine(match);
            }
            return temp;
        }

        public static String Minushandiling(string s)
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
        public static String RootDefaultHandling(string s)
        {
            if (s[0] == '√')
            {
                s = s.Insert(0, "2");
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '√' && calculator.isOperatorchar(s[i - 1]))
                {
                    s = s.Insert(i - 1, "2");
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' && s[i + 1] == '√')
                {
                    s = s.Insert(i + 1, "2");
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

            // Leaf node i.e, a double
            if (root.left == null && root.right == null) {
                if (double.Parse(root.data) % 1 == 0)
                {
                    return int.Parse(root.data);
                }
                return double.Parse(root.data);
            }
                

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

            if (root.data.Equals("%"))
                return leftEval % rightEval;

            if (root.data.Equals("^"))
                return Math.Pow(leftEval, rightEval);

            if (root.data.Equals("√"))
                return Math.Pow(leftEval, (double)1/rightEval);
            
            return leftEval / rightEval;
        }
        public static bool isOperatorchar(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '^' || ch == '%' || ch == '√')
            {
                return true;
            }
            return false;
        }
        public static bool isOperator(string s)
        {
            if (s == "+" || s == "-" || s == "*" || s == "/" || s == "^" ||s == "%" || s== "√")
            {
                return true;
            }
            return false;
        }

        static Node expressiontree(String[] postfix)
        {
            Stack<Node> st = new Stack<Node>();
            Node t1, t2, temp;

            for (int i = 0; i < postfix.Length; i++)
            {
                if (!isOperator(postfix[i]))
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
            if (evalTree(tree) % 1 == 0)
                return evalTree(tree).ToString("#,##0");
            return evalTree(tree).ToString("N2");



        }
    }

}
