using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//作者：李纯辉LiChunhui    时间：201804
//本次编程是一个非常不错的体验，感觉Visual Stdio还是很好用
//虽然 VS和 JetBrains的思路很不一样，但是总体来说还是挺好的



//本次为了演示PCB所以用到了数据结构相关知识   栈
//下面是一个标准的自定义栈，具有通用性，虽然很简易
namespace PCBPancel
{
    //栈的名字叫做MyStack
    public class MyStack
    {

        //栈的三个参数：大小、数组、栈顶
        public int size;
        public int[] data;
        public int top;

        //public int this[int index]
        //{
        //    get { return data[index]; }
        //    set { data[index] = value; }
        //}

        //public int Top
        //{
        //    get { return top; }

        //}


        //构造函数
        public MyStack(int size)
        {
            data = new int[size];
            this.size = size;
            top = -1;
        }

        //用来获取栈的长度
        public int GetLength()
        {
            return top + 1;
        }

        //用来清空栈
        public void clear()
        {
            top = -1;
        }

        //栈顶位置
        public int Gettop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Execute Gettop(), but stack is empty !");
                return default(int);
            }
            Console.WriteLine("Execute Gettop(), stack top is :"+data[top]);
            return data[top];
        }

        //判断栈是否为空
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //判断栈是否为满
        public bool IsFull()
        {
            if (top == this.size - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //进栈操作
        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full !");
            }
            else
            {
                top++;
                Console.WriteLine("Execute Push, and stack top is : " + top+"  And stack top is "+item);
                data[top] = item;
            }
            PrintStack();
        }

        //出栈操作
        public int Pop()
        {
            int aim = default(int);
            if (IsEmpty())
            {

                Console.WriteLine("Stack is empty !");
                return default(int);
            }
            else
            {
                aim = data[top];
                --top;
                Console.WriteLine("Execute Pop() ， and stack top is : " + top+" And pop "+aim);
                PrintStack();
                return aim;
            }
        }
        public void  Pop(int index)
        {
            int local=0;
            for (int i=0;i<=top;i++)
            {
                if (index==data[i])
                {
                    local = i;
                }
            }
            for (int i = local; i < top; i++)
            {
                data[i] = data[i + 1];
            }
            top--;
        }


        //输出栈的函数
        public void PrintStack()
        {
           
            if (IsEmpty())
            {
                Console.WriteLine("Execute PrintStack(), but the Stack is Empty !");
            }
            else
            {
                Console.Write("Execute PrintStack(), MyStack :  ");
                for (int i = 0; i <= top; i++)
                {
                    Console.Write(data[i] + "  ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
