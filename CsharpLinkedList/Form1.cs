namespace CsharpLinkedList
{
    public partial class Form1 : Form
    {
        
        class Node
        {
           public int Data;
           public Node next;
        }
        Node Start;
        Node End;
        int lengthOfList = 0;
        public void AddFront(int value) 
        { 
           Node NewNode = new Node();
            NewNode.Data = value;
            if (Start == null)
            {
                Start = NewNode;
                End = NewNode;
                


            }
            else
            {
                NewNode.next = Start;
                Start = NewNode;
            }
            lengthOfList++;


        }
        public void AddToBack(int value )//memory address 1,2,3,4,5,6,7,8,9 while != null  current node start current =  next node
        {
            Node NewNode = new Node();
            NewNode.Data = value;
            if (End == null)
            { 
                End = NewNode;
                Start = NewNode;
               
            }
            else
            {
                End.next = NewNode;
                NewNode.next = null;                
                End = NewNode ;
            }

        }
        public void DeleteFront()
        {
            Node NodeToDelete = new Node();
            if (Start != null)
            {
                NodeToDelete = Start;
                Start = Start.next;
            }
            else
            {
                MessageBox.Show("Start is nUll");
            }
            

        }
        public void DeleteBack()
        {
            Node NodeToDelete = new Node();
            Node Current = new Node();
            Current = Start;
            if (Start == null)
            {
                return;
            }
            while (Current.next != End)
            {
                Current = Current.next;
            }
             End = Current;
            Current.next = null;
        }
        public void AddBefore(int valueToAdd, int ToFind)
        {
            Node NewNode = new Node();
            Node Current = new Node();
            NewNode.Data = valueToAdd;
            if (Start != null)
            {
                Current = Start;
                while (Current.next.Data != ToFind)
                {
                    Current = Current.next;
                }
                NewNode.next = Current.next;
                Current.next = NewNode;
            }
            else
            {
                AddFront(valueToAdd);               
            }
            
        }
        public void AddAfter(int valueToAdd, int ToFind)
        { 
            Node Current = new Node();
            Node NewNode = new Node();
            if (Start != null)
            {
                NewNode.Data = valueToAdd;
                Current = Start;
                 while (Current.Data != ToFind || Current.next != null)
                {
                    
                    Current = Current.next;
                    
                }
                NewNode.next = Current.next;
                Current.next = NewNode;
            }
            else 
            {
                AddFront(valueToAdd);
            }
            
        }
       
        public void DeleteAfter(int toFind)
        {
            Node Current = new();
            Node NewNode = new();
            Current = Start;
            if (!(Current == null || Current.next == null))
            {
                while (Current.Data != toFind || Current.next != null)
                {
                    if (Current.next == null)
                    {
                        return;
                    }
                    Current = Current.next;
                }
                
                Current.next = Current.next.next;
            }
            

        }
        public void reverseLL()
        {
        Node current = new Node();       
        Node Storage = new Node();
            current = Start;
            Storage = current.next;
            int valueToLookFor;
            //Swap = Start;
            //newNode = End;
            if (Start.next == null)
            {
                return;
            }
            
            valueToLookFor = Start.Data;
            while (Storage != null )
            {
                
                Node Temp = Storage.next;
                Storage.next = current;
                current = Storage;
                Storage = Temp;
                


            }
            Start.next = null;
            End = Start;
             
            Start = current;

        }

        public void Print()
        {
            Node Current = new Node();
            Current = Start;
            richTextBox1.Text += "Null -> ";
            while (Current != null)
            {
                richTextBox1.Text += $"{Convert.ToString(Current.Data)} -> ";
                Current = Current.next;
            }
            richTextBox1.Text += " Null";

        }
        public void SpecificNode(int value)
        {
            int counter = 0;
            Node Current = new Node();
            Current = Start;
            if (value > lengthOfList)
            {
                return;
            }
            while (counter < value)
            {
                Current = Current.next; 
                counter ++;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddToBack(8);
            AddToBack(4);
            AddToBack(55);
            AddToBack(99);
            AddToBack(2);

            Print();
            reverseLL();
            Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}