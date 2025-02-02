using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16_狀態模式
{
    public class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("當前時間:{0}點 加班睡著了", w.Hour);
        }
    }
}
