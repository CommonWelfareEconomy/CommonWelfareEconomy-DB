﻿using GwoDb.Infrastructure;
using GwoDb.Tools.Updater.Steps;

namespace GwoDb.Updates
{
    public class Update : IRegisterAsInstancePerLifetime
    {
        private readonly UpdateStepExecuter _updateStepExecuter;

        public Update(UpdateStepExecuter updateStepExecuter)
        {
            _updateStepExecuter = updateStepExecuter;
        }

        public void Run()
        {
            _updateStepExecuter
                .Add(2, UpdateToVs2.Run)
                .Add(3, UpdateToVs3.Run)
                .Add(4, UpdateToVs4.Run)
                .Add(5, UpdateToVs5.Run)
                .Add(6, UpdateToVs6.Run)
                .Add(7, UpdateToVs7.Run)
                .Run();
        }

    }
}
