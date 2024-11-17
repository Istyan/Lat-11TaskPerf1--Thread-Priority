namespace ThreadPrio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }          
        private void btn_Run_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");
            lbl_Thread.Text = "-Thread Starts-";

            ThreadStart Thread1 = new ThreadStart(MyThreadClass.thread1);
            ThreadStart Thread2 = new ThreadStart(MyThreadClass.thread2);

            Thread threadA = new Thread(Thread1);
            Thread threadB = new Thread(Thread1);
            Thread threadC = new Thread(Thread2);
            Thread threadD = new Thread(Thread2);

            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadA.Name = "Thread A Process";

            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadB.Name = "Thread B Process";

            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadC.Name = "Thread C Process";

            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;
            threadD.Name = "Thread D Process";            

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            
            Console.WriteLine("-End of Threads-");
            
            lbl_Thread.Text = "-End of Threads-";          
        }
    }   
}

