using GwoDb.Infrastructure;

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
                .Run();
        }

    }
}
