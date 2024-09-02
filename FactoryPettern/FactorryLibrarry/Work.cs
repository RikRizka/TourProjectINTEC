namespace FactorryLibrarry
{
    public class Work : IWork
    {
        ILogger _logger;
        IMessageSender _messageSender;
        public string WorkName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; set; }

        public Work(ILogger loger, IMessageSender messageSender)
        {
            _logger = loger;
            _messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            // ILogger log = new Logger();

            _logger.Log($"Perfom worn on {WorkName}");
        }
        public void CompleteWork(double hours)
        {
            IsComplete = true;
            //ILogger log = new Logger();
            _logger.Log($"Completed {WorkName}");

            //IMessegeSender emailer = new Emailer();
            _messageSender.SendMessage(Owner, $"The worker {WorkName} is complete");
        }
    }
}
