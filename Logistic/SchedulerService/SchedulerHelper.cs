
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic
{
    public static class SchedulerHelper
    {
        // 0 0 0 * * ?
        private static readonly string ScheduleCronExpression = "0 0 0 * * ?";
        public static async void SchedulerSetup()
        {

            var _scheduler = await new StdSchedulerFactory().GetScheduler();
            await _scheduler.Start();

            var showDateTimeJob = JobBuilder.Create<ShowDateTimeJob>()
                .WithIdentity("ShowDateTimeJob")
                .Build();
  
            var trigger = TriggerBuilder.Create().WithIdentity("ShowDateTimeJob", "group1").WithCronSchedule(ScheduleCronExpression).Build();

            var result = await _scheduler.ScheduleJob(showDateTimeJob, trigger);
        }

        public static async void SchedulerSetupComplete()
        {

            var _scheduler = await new StdSchedulerFactory().GetScheduler();
            await _scheduler.Start();

            var showDateTimeJob = JobBuilder.Create<ShowDateTimeJob>()
                .WithIdentity("ShowDateTimeJob")
                .Build();
            var trigger = TriggerBuilder.Create()
                .WithIdentity("ShowDateTimeJob")
                .StartNow()
                .WithSimpleSchedule(builder => builder.WithIntervalInHours(1).RepeatForever()).WithCronSchedule("0 0 0 * * ?")
                .Build();
            

            var result = await _scheduler.ScheduleJob(showDateTimeJob, trigger);
        }
    }
}
