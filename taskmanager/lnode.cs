using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace LN
{

    public class Node
    {
        //属性
        public  Process Data
        { get; set; }
        public Node Next
        { get; set; }
        //方法
        public Node(Process t_data = default(Process))
        {
            Data = t_data;
            Next = null;
        }

    };
    public class SingleLinkedList
    {
        //属性
        public Node Head
        { get; set; }
        public int Length { get; private set; }
        //方法
        public SingleLinkedList()
        {
            Head = null;
            Length = 0;
        }

        public SingleLinkedList(Node node)
        {
            Head = node;
            Head.Next = null;
            Length = 1;
        }

        public void Append(Process t_data)//追加节点：以传入结点的数据域的方式
        {
            Node temp = new Node(t_data);
            if (Head == null)
            {
                Head = temp;
                Length++;
                return;
            }
            Node h = Head;
            while (h.Next != null)
            {
                h = h.Next;
            }
            h.Next = temp;

            Length++;
        }

        public bool IsEmpty()//判断链表是否为空
        {
            if (Head == null)
            {
                return true;
            }
            return false;
        }
        public void Clear()//重置head
        {
            Head = null;
            Length = 0;
        }
        public void RemoveAt(int pos)//删除某个合法位置的结点
        {
            if (Length < pos || pos <= 0)//溢出检查
            {
                Console.WriteLine("超出链表长度!");
                return;
            }

            if (pos == 1)//删除头结点的情况
            {
                Head = Head.Next;
                Length--;
                return;
            }

            Node temp = Head;
            int i = 2;

            if (pos == Length)//删除尾结点的情况
            {
                while (i < Length)
                {
                    temp = temp.Next;
                }
                temp.Next = null;
                Length--;
                return;
            }

            i = 1;//一般情况
            while (i < pos - 1)
            {
                temp = temp.Next;
                i++;
            }
            temp.Next = temp.Next.Next;
            Length--;
        }
        public Node Find(Process t_data)//得到符合传入数据的结点
        {
            if (Head == null)
            {
                Console.WriteLine("链表为空!");
                return null;
            }
            Node temp = Head;
            int i = 1;
            while (temp.Next != null)
            {
                if (temp.Data.Equals(t_data))//此处疑问请参见https://ask.helplib.com/c-Sharp/post_153712
                {
                    RemoveAt(i);
                }
                temp = temp.Next;
                i++;
            }
            Console.WriteLine("未找到符合的数据结点!");
            return null;
        }
        public Node Search(string t_data)//得到符合传入数据的结点
        {
            if (Head == null)
            {
                MessageBox.Show("链表为空!");
                return null;
            }
            Node temp = Head;
            while (temp.Next != null)
            {
                if (temp.Data.ProcessName.Equals(t_data))//此处疑问请参见https://ask.helplib.com/c-Sharp/post_153712
                {
                    String str = "名称:" + t_data + "\n" + "UID:" + temp.Data.Id + "\n" + "内存:" + (temp.Data.PrivateMemorySize64 / 1024) + "k";
                    MessageBox.Show(str);
                    return null;
                }
                temp = temp.Next;
            }
            MessageBox.Show("未找到进程");
            return null;
        }
    }
}
