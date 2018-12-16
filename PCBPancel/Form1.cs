using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBPancel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int time_1 = 10;
        private int time_2 = 10;
        private int time_3 = 10;
        private int time_4 = 10;
        private int time_5 = 10;
        private int time = 5;
        //Timer


        


        MyStack Ready = new MyStack(5);
        MyStack Run = new MyStack(1);
        MyStack Block = new MyStack(5);
        
        //CreateArea
        private void P1Create_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 1 Created !\n");
            P1Signal.BackColor = System.Drawing.Color.Yellow;
            System.Threading.Thread.Sleep(300);
            P1Ready_Click(sender,e);
        }

        private void P2Create_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 2 Created !\n");
            P2Signal.BackColor = System.Drawing.Color.Yellow;
            System.Threading.Thread.Sleep(300);
            P2Ready_Click(sender, e);
        }

        private void P3Create_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 3 Created !\n");
            P3Signal.BackColor = System.Drawing.Color.Yellow;
            System.Threading.Thread.Sleep(300);
            P3Ready_Click(sender, e);
        }

        private void P4Create_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 4 Created !\n");
            P4Signal.BackColor = System.Drawing.Color.Yellow;
            System.Threading.Thread.Sleep(300);
            P4Ready_Click(sender, e);
        }

        private void P5Create_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 5 Created !\n");
            P5Signal.BackColor = System.Drawing.Color.Yellow;
            System.Threading.Thread.Sleep(300);
            P5Ready_Click(sender, e);
        }


        //ReadyArea

       public void P1Ready_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 1 is Ready !\n");
            P1Signal.BackColor = System.Drawing.Color.Yellow;
            Ready.Push(1);
        }


        private void P2Ready_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 2 is Ready !\n");
            P2Signal.BackColor = System.Drawing.Color.Yellow;
            Ready.Push(2);
        }

        private void P3Ready_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 3 is Ready !\n");
            P3Signal.BackColor = System.Drawing.Color.Yellow;
            Ready.Push(3);
        }

        private void P4Ready_Click(object sender, EventArgs e)
        {
           MainBox.AppendText("PCB 4 is Ready !\n");
            P4Signal.BackColor = System.Drawing.Color.Yellow;
            Ready.Push(4);
        }

        private void P5Ready_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 5 is Ready !\n");
            P5Signal.BackColor = System.Drawing.Color.Yellow;
            Ready.Push(5);
        }

        private void mainTimer_Tick(object sender, EventArgs e,int i)
        {

        //    timerLabel.Text = "剩余时间：" + time+" S";
        //    time--;


        //    if (time >= 0)
        //    {

        //    }
        //    else
        //    {
        //        timerLabel.Text = "剩余时间：0 S" ;
        //        if (Block.IsEmpty())
        //        {
        //        }
        //        else
        //        {
        //            Run.Pop();
        //            Run.Push(Block.Pop());
        //        }
        //    }
        }

        //RunArea
        private void P1Run_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 1 is Running !\n");
            P1Signal.BackColor = System.Drawing.Color.Green;
            //timer1.Start();
            //mainTimer.Start();
            if (Run.IsEmpty())  Run.Push(1);
            else
            {
                RunToBlock(sender, e);
                Run.Push(1);
            }
        }


        private void P2Run_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 2 is Running !\n");
            P2Signal.BackColor = System.Drawing.Color.Green;
            if (Run.IsEmpty()) Run.Push(2);
            else
            {
                RunToBlock(sender, e);
                Run.Push(2);
            }
        }


        private void P3Run_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 3 is Running !\n");
            P3Signal.BackColor = System.Drawing.Color.Green;
            if (Run.IsEmpty()) Run.Push(3);
            else
            {
                RunToBlock(sender, e);
                Run.Push(3);
            }
        }

        public  void P4Run_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 4 is Running !\n");
            P4Signal.BackColor = System.Drawing.Color.Green;
            if (Run.IsEmpty()) Run.Push(4);
            else
            {
                RunToBlock(sender, e);
                Run.Push(4);
            }
        }

        private void P5Run_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 5 is Running !\n");
            P5Signal.BackColor = System.Drawing.Color.Green;
            if (Run.IsEmpty()) Run.Push(5);
            else
            {
                RunToBlock(sender, e);
                Run.Push(5);
            }
            
        }


        //blockArea

        private void P1Block_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 1 is Blocking !\n");
            P1Signal.BackColor = System.Drawing.Color.Red;
            //BlockToRun(sender, e, 1);

            if (Run.Gettop() == 1)
            {
                Console.WriteLine("Run的栈顶是" + Run.Gettop());
                Console.WriteLine("Block的栈顶是" + Block.Gettop());
                Run.Pop();
                Run.Push(Block.Gettop());
                Console.WriteLine("RunPush之后的站顶是" + Run.Gettop());
                ToLight(sender, e, Run.Gettop());
                Block.Pop();
                Block.Push(1);
                Console.WriteLine("Block的栈顶是" + Block.Gettop());
            }
            else
            {
                Block.Push(1);
            }


        }

        private void P2Block_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 2 is Blocking !\n");
            P2Signal.BackColor = System.Drawing.Color.Red;

            if (Run.Gettop() == 2)
            {
                Console.WriteLine("Run的栈顶是" + Run.Gettop());
                Console.WriteLine("Block的栈顶是" + Block.Gettop());
                Run.Pop();
                Run.Push(Block.Gettop());
                Console.WriteLine("RunPush之后的站顶是" + Run.Gettop());
                ToLight(sender, e, Run.Gettop());
                Block.Pop();
                Block.Push(2);
                Console.WriteLine("Block的栈顶是" + Block.Gettop());
            }
            else
            {
                Block.Push(2);
            }

        }
        private void P3Block_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 3 is Blocking !\n");
            P3Signal.BackColor = System.Drawing.Color.Red;

            if (Run.Gettop() == 3)
            {
                Console.WriteLine("Run的栈顶是" + Run.Gettop());
                Console.WriteLine("Block的栈顶是" + Block.Gettop());
                Run.Pop();
                Run.Push(Block.Gettop());
                Console.WriteLine("RunPush之后的站顶是" + Run.Gettop());
                ToLight(sender, e, Run.Gettop());
                Block.Pop();
                Block.Push(3);
                Console.WriteLine("Block的栈顶是" + Block.Gettop());
            }
            else
            {
                Block.Push(3);
            }

        }

        private void P4Block_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 4 is Blocking !\n");
            P4Signal.BackColor = System.Drawing.Color.Red;

            if (Run.Gettop() == 4)
            {
                Console.WriteLine("Run的栈顶是" + Run.Gettop());
                Console.WriteLine("Block的栈顶是" + Block.Gettop());
                Run.Pop();
                Run.Push(Block.Gettop());
                Console.WriteLine("RunPush之后的站顶是" + Run.Gettop());
                ToLight(sender, e, Run.Gettop());
                Block.Pop();
                Block.Push(4);
                Console.WriteLine("Block的栈顶是" + Block.Gettop());
            }
            else
            {
                Block.Push(4);
            }

        }

            private void P5Block_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 5 is Blocking !\n");
            P5Signal.BackColor = System.Drawing.Color.Red;

            if (Run.Gettop() == 5)
            {
                Console.WriteLine("Run的栈顶是"+Run.Gettop());
                Console.WriteLine("Block的栈顶是" +Block.Gettop());
                Run.Pop();
                Run.Push(Block.Gettop());
                Console.WriteLine("RunPush之后的站顶是"+Run.Gettop());
                ToLight(sender,e,Run.Gettop());
                Block.Pop();
                Block.Push(5);
                Console.WriteLine("Block的栈顶是" + Block.Gettop());
            }
            else
            {
                Block.Push(5);
            }

        }

        public void ToLight(object sender, EventArgs e,int i)
        {

            switch (i)
            {
                case 1: P1Signal.BackColor = System.Drawing.Color.Green; MainBox.AppendText("PCB 1  is running !\n"); break;
                case 2: P2Signal.BackColor = System.Drawing.Color.Green; MainBox.AppendText("PCB 2  is running !\n"); break;
                case 3: P3Signal.BackColor = System.Drawing.Color.Green; MainBox.AppendText("PCB 3  is running !\n"); break;
                case 4: P4Signal.BackColor = System.Drawing.Color.Green; MainBox.AppendText("PCB 4  is running !\n"); break;
                case 5: P5Signal.BackColor = System.Drawing.Color.Green; MainBox.AppendText("PCB 5  is running !\n"); break;
                default: Console.WriteLine("用户这辈子都看不到这句话！"); break;
            }
        }


        //ExitArea
        private void P1Exit_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 1 Exited !\n");
            P1Signal.BackColor = System.Drawing.Color.White;
            //Bar1.Value = 0;
            if (Run.Gettop() == 1)
            {
                Run.Pop();
                if (!Block.IsEmpty())
                {
                    Run.Push(Block.Pop());
                    ExitToLight(sender, e);
                }
            }
            Ready.Pop(1);
        }

        private void P2Exit_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 2 Exited !\n");
            P2Signal.BackColor = System.Drawing.Color.White;
            //Bar1.Value = 0;
            if (Run.Gettop() == 2)
            {
                Run.Pop();
                if (!Block.IsEmpty())
                {
                    Run.Push(Block.Pop());
                    ExitToLight(sender, e);
                }
            }
            Ready.Pop(2);
        }


        private void P3Exit_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 3 Exited !\n");
            P3Signal.BackColor = System.Drawing.Color.White;
            //Bar1.Value = 0;
            if (Run.Gettop() == 3)
            {
                Run.Pop();
                if (!Block.IsEmpty())
                {
                    Run.Push(Block.Pop());
                    ExitToLight(sender, e);
                }
            }
            Ready.Pop(3);
        }

        private void P4Exit_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 4 Exited !\n");
            P4Signal.BackColor = System.Drawing.Color.White;
            //Bar1.Value = 0;
            if (Run.Gettop() == 4)
            {
                Run.Pop();
                if (!Block.IsEmpty())
                {
                    Run.Push(Block.Pop());
                    ExitToLight(sender, e);
                }
            }
            Ready.Pop(4);
        }

        private void P5Exit_Click(object sender, EventArgs e)
        {
            MainBox.AppendText("PCB 5 Exited !\n");
            P5Signal.BackColor = System.Drawing.Color.White;
            //Bar1.Value = 0;
            if (Run.Gettop() == 5)
            {
                Run.Pop();
                if (!Block.IsEmpty())
                {
                    Run.Push(Block.Pop());
                    ExitToLight(sender,e);
                }
            }
            Ready.Pop(5);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            time_1--;
            if (time_1 >= 0)
            {
                //Bar1.Value = time_1 * 10;
            }
            else timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time_2--;
            if (time_2 >= 0)
            {
                //Bar2.Value = time_2 * 10;
            }
            else timer2.Stop();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            time_3--;
            if (time_3 >= 0)
            {
                //Bar3.Value = time_3 * 10;
            }
            else timer3.Stop();
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            time_4--;
            if (time_4 >= 0)
            {
                //Bar4.Value = time_4 * 10;
            }
            else timer4.Stop();
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            time_5--;
            if (time_5 >= 0)
            {
                //Bar5.Value = time_5 * 10;
            }
            else timer5.Stop();
        }



        private void RunToBlock(object sender, EventArgs e)
        {

            switch (Run.Gettop())
            {
                case 1: Run.Pop(); MainBox.AppendText("PCB 1 goto Block !\n"); P1Block_Click(sender, e); break;
                case 2: Run.Pop(); MainBox.AppendText("PCB 2 goto Block !\n"); P2Block_Click(sender, e); break;
                case 3: Run.Pop() ;MainBox.AppendText("PCB 3 goto Block !\n"); P3Block_Click(sender, e); break;
                case 4: Run.Pop(); MainBox.AppendText("PCB 4 goto Block !\n"); P4Block_Click(sender, e); break;
                case 5: Run.Pop(); MainBox.AppendText("PCB 5 goto Block !\n"); P5Block_Click(sender, e); break;
                default: Console.WriteLine("用户这辈子都看不到这句话！"); break;
            }
        }

        private void ExitToLight(object sender,EventArgs e)
        {
            switch (Run.Gettop())
            {
                case 1:  MainBox.AppendText("PCB 1 goto Running !\n"); P1Signal.BackColor = System.Drawing.Color.Green; break;
                case 2:  MainBox.AppendText("PCB 2 goto Running !\n"); P2Signal.BackColor = System.Drawing.Color.Green; break;
                case 3:  MainBox.AppendText("PCB 3 goto Running !\n"); P3Signal.BackColor = System.Drawing.Color.Green; break;
                case 4:  MainBox.AppendText("PCB 4 goto Running !\n"); P4Signal.BackColor = System.Drawing.Color.Green; break;
                case 5:  MainBox.AppendText("PCB 5 goto Running !\n"); P5Signal.BackColor = System.Drawing.Color.Green; break;
                default: Console.WriteLine("用户这辈子都看不到这句话！"); break;
            }
        }


        private void BlockToRun(object sender,EventArgs e,int i)
        {
            switch (i)
            {
                case 1:
                    Run.Pop(1);
                    if (!Block.IsEmpty())
                    {
                        Run.Push(Block.Gettop());
                        P1Run_Click(sender, e);
                        Block.Push(1);
                    }
                    else
                    {
                        Block.Push(1);
                    }
                    break;
                case 2:
                    Run.Pop(2);
                    if (!Block.IsEmpty())
                    {
                        Run.Push(Block.Gettop());
                        P2Run_Click(sender, e);
                        Block.Push(2);
                    }
                    else
                    {
                        Block.Push(2);
                    }
                    break;
                case 3:
                    Run.Pop(3);
                    if (!Block.IsEmpty())
                    {
                        Run.Push(Block.Gettop());
                        P3Run_Click(sender, e);
                        Block.Push(3);
                    }
                    else
                    {
                        Block.Push(3);
                    }
                    break;
                case 4:
                    Run.Pop(4);
                    if (!Block.IsEmpty())
                    {
                        Run.Push(Block.Gettop());
                        P4Run_Click(sender, e);
                        Block.Push(4);
                    }
                    else
                    {
                        Block.Push(4);
                    }
                    break;
                case 5:
                    Run.Pop(5);
                    if (!Block.IsEmpty())
                    {
                        Run.Push(Block.Gettop());
                        P5Run_Click(sender, e);
                        Block.Push(5);
                    }
                    else
                    {
                        Block.Push(5);
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    P1Create_Click(sender, e); System.Threading.Thread.Sleep(300);
        //    P2Create_Click(sender, e); System.Threading.Thread.Sleep(300);
        //    P3Create_Click(sender, e); System.Threading.Thread.Sleep(300);
        //    P4Create_Click(sender, e); System.Threading.Thread.Sleep(300);
        //    P5Create_Click(sender, e); System.Threading.Thread.Sleep(300);


        //}
    }
}
