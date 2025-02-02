namespace Chapter16_狀態模式
{
    internal class Program
    {
        #region part 1
        //static int Hour = 0;
        //static bool WorkFinished = false;
        //static void WriteProgram()
        //{
        //    if (Hour < 12)
        //    {
        //        Console.WriteLine("當前時間:{0}點 上午工作", Hour);
        //    }
        //    else if (Hour < 13)
        //    {
        //        Console.WriteLine("當前時間:{0}點 午休", Hour);
        //    }
        //    else if (Hour < 17)
        //    {
        //        Console.WriteLine("當前時間:{0}點 下午工作", Hour);
        //    }
        //    else
        //    {
        //        if(WorkFinished)
        //        {
        //            Console.WriteLine("當前時間:{0}點 下班", Hour);
        //        }
        //        else
        //        {
        //            if (Hour < 21)
        //            {
        //                Console.WriteLine("當前時間:{0}點 加班", Hour);
        //            }
        //            else
        //            {
        //                Console.WriteLine("當前時間:{0}點 加班睡著了", Hour);
        //            }
        //        }
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region part 1
            //Hour = 9;
            //WriteProgram();
            //Hour = 10;
            //WriteProgram();
            //Hour = 12;
            //WriteProgram();
            //Hour = 13;
            //WriteProgram();
            //Hour = 14;
            //WriteProgram();
            //Hour = 17;
            //WorkFinished = true;
            //WriteProgram();
            //Hour = 19;
            //WriteProgram();
            //Hour = 22;
            //WriteProgram();
            #endregion

            #region part 2
            //Work emergencyProjects = new Work();
            //emergencyProjects.Hour = 9;
            //emergencyProjects.WriteProgram();
            //emergencyProjects.Hour = 10;
            //emergencyProjects.WriteProgram();
            //emergencyProjects.Hour = 12;
            //emergencyProjects.WriteProgram();
            //emergencyProjects.Hour = 13;
            //emergencyProjects.WriteProgram();
            //emergencyProjects.Hour = 14;
            //emergencyProjects.WriteProgram();
            //emergencyProjects.Hour = 17;
            ////emergencyProjects.Taskfinished = true;
            //emergencyProjects.WriteProgram();
            //emergencyProjects.Hour = 19;
            //emergencyProjects.WriteProgram();
            //emergencyProjects.Hour = 22;
            //emergencyProjects.WriteProgram();
            #endregion

            #region part 3
            Work emergencyProjects = new Work();
            emergencyProjects.Hour = 9;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 10;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 12;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 13;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 14;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 17;
            emergencyProjects.Taskfinished = true;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 19;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 22;
            emergencyProjects.WriteProgram();
            #endregion

            Console.ReadLine();
        }
    }
}
