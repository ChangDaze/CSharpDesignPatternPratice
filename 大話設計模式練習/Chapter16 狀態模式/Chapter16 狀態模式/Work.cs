using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16_狀態模式
{

    #region part2
    //public class Work
    //{
    //    private int hour;
    //    public int Hour
    //    {
    //        get { return hour; }
    //        set { hour = value; }
    //    }
    //    private bool finish = false;
    //    public bool Taskfinished
    //    {
    //        get { return finish; }
    //        set { finish = value; }
    //    }
    //    public void WriteProgram()
    //    {
    //        if (Hour < 12)
    //        {
    //            Console.WriteLine("當前時間:{0}點 上午工作", Hour);
    //        }
    //        else if (Hour < 13)
    //        {
    //            Console.WriteLine("當前時間:{0}點 午休", Hour);
    //        }
    //        else if (Hour < 17)
    //        {
    //            Console.WriteLine("當前時間:{0}點 下午工作", Hour);
    //        }
    //        else
    //        {
    //            if (finish)
    //            {
    //                Console.WriteLine("當前時間:{0}點 下班", Hour);
    //            }
    //            else
    //            {
    //                if (Hour < 21)
    //                {
    //                    Console.WriteLine("當前時間:{0}點 加班", Hour);
    //                }
    //                else
    //                {
    //                    Console.WriteLine("當前時間:{0}點 加班睡著了", Hour);
    //                }
    //            }
    //        }
    //    }
    //}
    #endregion
    #region part 3
    public class Work
    {
        private State current;
        private double hour;
        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        private bool finish = false;
        public bool Taskfinished
        {
            get { return finish; }
            set { finish = value; }
        }
        public Work()
        {
            current = new ForenoonState();
        }
        public void SetState(State s)
        {
            current = s;
        }
        public void WriteProgram()
        {
            current.WriteProgram(this);            
        }        
    }
    #endregion
}
